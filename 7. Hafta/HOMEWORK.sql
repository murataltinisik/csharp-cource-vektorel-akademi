-- 1-)Tüm cirom ne kadar?
SELECT SUM(UnitPrice * Quantity * (1 - Discount)) FROM [Order Details]

-- 2-)Bugün doğumgünü olan çalışanlarım kimler?
SELECT FirstName, LastName, BirthDate FROM Employees 
WHERE 
    MONTH(BirthDate) = 1 -- MONTH(GETDATE()) 
    AND
    DAY(BirthDate) = DAY(GETDATE());

-- 3-)Hangi çalışanım hangi çalışanıma bağlı? (İsim - İsim)
SELECT 
    CONCAT(e1.FirstName, ' ', e1.LastName) AS Manager,
    CONCAT(e2.FirstName, ' ', e2.LastName) AS Employee
FROM Employees e1 JOIN Employees e2 ON e1.EmployeeID = e2.ReportsTo;

-- 4-)Çalışanlarım ne kadarlık satış yapmışlar? 
SELECT 
    CONCAT(e.FirstName, ' ', e.LastName) AS Employee, 
    SUM(od.UnitPrice * od.Quantity * (1 - od.Discount)) 
FROM Employees e 
    LEFT JOIN Orders o ON e.EmployeeID = o.EmployeeID
    JOIN [Order Details] od ON o.OrderId = od.OrderId
    GROUP BY CONCAT(e.FirstName, ' ', e.LastName)

-- 5-)Hangi ülkelere ihracat yapıyorum?
SELECT DISTINCT(ShipCountry) FROM Orders;

-- 6-)Ürünlere göre satışım nasıl? (Ürün-Adet-Gelir)
SELECT 
    p.ProductName, 
    SUM(od.Quantity) AS Quantity, 
    SUM(od.UnitPrice * od.Quantity * (1 - od.Discount)) AS TotalPrice 
FROM Orders o 
    JOIN [Order Details] od ON o.OrderId = od.OrderId 
    JOIN Products p ON od.ProductID = p.ProductID
    GROUP BY p.ProductName

-- 7-)Ürün kategorilerine göre satışlarım nasıl? (Gelir bazında)
SELECT c.CategoryName, SUM(od.UnitPrice * od.Quantity * (1 - od.Discount)) as TotalPrice
    FROM Products p 
    JOIN Categories c ON p.CategoryId = c.CategoryId
    LEFT JOIN [Order Details] od ON p.ProductId = od.ProductId
    GROUP BY c.CategoryName

-- 8-)Ürün kategorilerine göre satışlarım nasıl? (Adet bazında)
SELECT c.CategoryName, SUM(od.Quantity) as TotalAmount
    FROM Products p 
    JOIN Categories c ON p.CategoryId = c.CategoryId
    LEFT JOIN [Order Details] od ON p.ProductId = od.ProductId
    GROUP BY c.CategoryName

-- 9-)Çalışanlarım ürün bazında ne kadarlık satış yapmışlar? 
SELECT 
    CONCAT(e.FirstName, ' ', e.LastName) as Employee,
    p.ProductName,
    SUM(od.UnitPrice * od.Quantity * (1 - od.Discount)) as TotalPrice 
FROM Employees e 
    JOIN Orders o ON e.EmployeeID = o.EmployeeID
    JOIN [Order Details] od ON o.OrderId = od.OrderId
    JOIN Products p ON od.ProductId = p.ProductId
    GROUP BY 
        CONCAT(e.FirstName, ' ', e.LastName),
        p.ProductName
    ORDER BY Employee

-- 10-)Hangi kargo şirketine toplam ne kadar ödeme yapmışım?
SELECT s.CompanyName, SUM(o.Freight) as TotalFreight FROM Orders o 
    JOIN [Order Details] od ON o.OrderId = od.OrderId
    JOIN Shippers s ON o.ShipVia = s.ShipperId
    GROUP BY s.CompanyName

-- 11-)Tost yapmayı seven çalışanım hangisi? 
SELECT 'MURAT ALTINIŞIK' -- HOCAM ANLAMADIM SORUYU

-- 12-)Hangi tedarkçiden aldığım ürünlerden ne kadar satmışım? 
SELECT 
    s.CompanyName, 
    p.ProductName, 
    SUM(od.Quantity) as TotalQuantity, 
    SUM(od.UnitPrice * od.Quantity * (1 - od.Discount)) as TotalPrice
FROM Products p 
     LEFT JOIN Suppliers s ON p.SupplierId = s.SupplierId
     JOIN [Order Details] od ON p.ProductId = od.ProductID
     GROUP BY s.CompanyName, p.ProductName

-- 13-)En değerli müşterim hangisi? (en fazla satış yaptığım müşteri) (Gelir ve adet bazında)
SELECT TOP 1
    c.ContactName, 
    SUM(od.UnitPrice * od.Quantity * (1 - od.Discount)) as TotalPrice
FROM Customers c 
    LEFT JOIN Orders o ON c.CustomerId = o.CustomerId
    JOIN [Order Details] od ON o.OrderId = od.OrderId
    GROUP BY c.ContactName
    ORDER BY TotalPrice DESC

-- 14-)Hangi ülkelere ne kadarlık satış yapmışım?
SELECT 
    o.ShipCountry, 
    SUM(od.UnitPrice * od.Quantity * (1 - od.Discount)) as TotalPrice
FROM Orders o 
    JOIN [Order Details] od ON o.OrderId = od.OrderId
    GROUP BY o.ShipCountry

-- 15-)Zamanında teslim edemediğim siparişlerim ID’leri nelerdir ve kaç gün geç göndermişim?
SELECT OrderId, DATEDIFF(DAY, ShippedDate, RequiredDate) FROM Orders WHERE DATEDIFF(DAY, ShippedDate, RequiredDate) > 0

-- 16-) Ortalama satış miktarının üzerine çıkan satışlarım hangisi
SELECT 
    o.OrderId, 
    AVG(od.Quantity) as AverageQuantity
FROM Orders o 
    JOIN [Order Details] od ON o.OrderId = od.OrderId
    GROUP BY o.OrderId
    HAVING 
        AVG(od.Quantity) > (
            SELECT AVG(Quantity) FROM [Order Details] 
        ) 
    ORDER BY AverageQuantity

-- 17-)Satışlarımı kaç günde teslim etmişim?
SELECT OrderId, DATEDIFF(DAY, ShippedDate, RequiredDate) AS DeliveredDate FROM Orders