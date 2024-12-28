using Microsoft.AspNetCore.Mvc;
using MvcProject.Areas.Admin.Models.Context;
using MvcProject.Areas.Admin.Models.DTOs;
using MvcProject.Areas.Admin.Models.Entities;
using MvcProject.Areas.Admin.Models.ViewModels;

namespace MvcProject.Areas.Admin.Controllers;

[Area("Admin")]
public class EmployeeController : BaseController
{
    private readonly NortwindDatabaseContext _context;

    public EmployeeController(NortwindDatabaseContext context)
    {
        _context = context;
    }
    
    public IActionResult Index()
    {
        // Employees 
        List<Employee> employees = _context.Employees.OrderDescending().ToList();
        
        // Employee
        EmployeeViewModel employeeViewModel = new()
        {
            Employees = employees,
            NumberOfEmployee = employees.Count,
        };
        
        return View(employeeViewModel);
    }

    [HttpPost]
    public IActionResult Create(EmployeeDto employee)
    {
        // Is Error
        if (!ModelState.IsValid)
        {
            // Get Error
            var error = ModelState.Values.SelectMany(v => v.Errors).Select(e => e.ErrorMessage);
            
            // Json
            return Json(new { Message = error, StatusCode = 400 });
        }
        
        // Create Instance Employee
        Employee e = new()
        {
            FirstName = employee.FirstName,
            LastName = employee.LastName,
            City = employee.City,
            Country = employee.Country,
            BirthDate = employee.BirthDate,
            HireDate = employee.HireDate,
        };
        
        // Add DbSet
        _context.Employees.Add(e);
        
        // Save Changes
        _context.SaveChanges();
        
        return Json(new { Data = e, Message = "Employee Created Successfully!", StatusCode = 200 });
    }

    [HttpPut]
    public IActionResult Update(EmployeeDto employee, int id)
    {
        try
        {
            // Is Error
            if (!ModelState.IsValid)
            {
                // Get Error
                var error = ModelState.Values.SelectMany(v => v.Errors).Select(e => e.ErrorMessage);
            
                // Json
                return Json(new { Message = error, StatusCode = 400 });
            }
        
            // Get Employee By Id
            var getEmployee = _context.Employees.SingleOrDefault(e => e.EmployeeId == id);
        
            // Is Not Found Employee
            if (getEmployee is null) return Json(new { Message = "Employee Not Found", StatusCode = 404 });
        
            // Fill Get Employee
            getEmployee.FirstName = employee.FirstName;
            getEmployee.LastName = employee.LastName;
            getEmployee.BirthDate = employee.BirthDate;
            getEmployee.HireDate = employee.HireDate;
            getEmployee.Country = employee.Country;
            getEmployee.City = employee.City;
        
            // Update
            _context.Employees.Update(getEmployee);
        
            // Save Changes
            _context.SaveChanges();

            return Json(new { Data = getEmployee, Message = "Updated Successfully...", StatusCode = 200 });
        }
        catch (Exception ex)
        {
            return Json(new { Message = ex.Message, StatusCode = 500 });
        }
    }

    [HttpDelete]
    public IActionResult Delete(int id)
    {
        try
        {
            // Get Employee
            var getEmployee = _context.Employees.SingleOrDefault(e => e.EmployeeId == id);
        
            // Exists Employee
            if(getEmployee is null) return Json(new { Message = "Employee Not Found", StatusCode = 404 });
        
            // Delete Employee
            _context.Employees.Remove(getEmployee);
        
            // Save Changes
            _context.SaveChanges();
        
            // Return Success Message
            return Json(new { Message = "Deleted Successfully", StatusCode = 200 });
        }
        catch (Exception ex)
        {
            return Json(new { Message = ex.Message, StatusCode = 500 });
        }
    }
}