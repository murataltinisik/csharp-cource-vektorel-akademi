# MvcProject

MvcProject, bir ASP.NET Core MVC uygulamasıdır. Bu proje, kullanıcı oturum açma işlemleri, çalışan yönetimi ve bir yönetici alanı (Admin Area) içermektedir.

## Özellikler

- Kullanıcı oturum açma işlemleri (Login)
- Çalışanların listelenmesi, eklenmesi, güncellenmesi ve silinmesi
- Yönetici alanı (Admin Area)
- Veritabanı olarak SQL Server kullanımı
- Session yönetimi ile kullanıcı doğrulama
- Katmanlı yapı:
    - Controllers, Models (DTOs, Entities, ViewModels) ve Views

## Kurulum

### 1. Depoyu Klonlama

Projeyi yerel makinenize klonlayın:

```bash
git clone <project-name>
cd MvcProject
```

### 2. Veritabanı Bağlantısını Yapılandırma

`appsettings.json` dosyasını düzenleyerek SQL Server bağlantı dizesini kendi veritabanı bilgilerinizle güncelleyin:

```json
"ConnectionStrings": {
  "SqlServer": "Server=localhost,1433;Database=Northwind;User Id=sa;Password=[YOUR_PASSWORD];TrustServerCertificate=true;"
}
```

### 3. Bağımlılıkları Yükleme

Proje bağımlılıklarını yüklemek için aşağıdaki komutu çalıştırın:

```bash
dotnet restore
```

### 4. Veritabanını Güncelleme

Veritabanını hazırlamak için EF Core Migration komutlarını kullanabilirsiniz. Henüz migration dosyası oluşturulmadıysa aşağıdaki adımları izleyin:

```bash
dotnet ef migrations add InitialCreate
dotnet ef database update
```

### 5. Projeyi Çalıştırma

Projeyi çalıştırmak için:

```bash
dotnet run
```

Varsayılan olarak proje `https://localhost:5001` veya `http://localhost:5000` üzerinde çalışacaktır.

## Proje Yapısı

```plaintext
MvcProject
├── Controllers
│   ├── Authenticate
│   ├── Dashboard
│   └── Employee
├── Models
│   ├── Context
│   ├── DTOs
│   ├── Entities
│   └── ViewModels
├── Views
│   ├── Authenticate
│   ├── Dashboard
│   ├── Employee
│   └── Shared
└── Program.cs
```

### Önemli Dosyalar

- **Program.cs**: ASP.NET Core uygulamasının başlangıç noktası.
- **appsettings.json**: Uygulama yapılandırma dosyası.
- **Controllers**: HTTP isteklerini yöneten controller'lar.
- **Models**: Veritabanı ve veri transfer nesneleri.
- **Views**: Kullanıcıya gösterilen Razor sayfaları.

## Kullanım

### Yönetici Girişi

- `http://localhost:5000/admin/authenticate/login` adresinden yönetici girişi yapılabilir.
- Kullanıcı oturumu kapalıyken `admin` alanına erişim engellenir.

### Çalışan Yönetimi

- `http://localhost:5000/admin/employee/index`: Çalışan listesini gösterir.
- Çalışan ekleme, güncelleme ve silme işlemleri yapılabilir.

## API Endpoint'leri

- **Login:** `POST /admin/authenticate/login`
- **Çalışan Ekle:** `POST /admin/employee/create`
- **Çalışan Güncelle:** `PUT /admin/employee/update/{id}`
- **Çalışan Sil:** `DELETE /admin/employee/delete/{id}`
