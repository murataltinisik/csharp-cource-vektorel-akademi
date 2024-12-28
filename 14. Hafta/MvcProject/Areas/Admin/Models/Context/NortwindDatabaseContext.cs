using Microsoft.EntityFrameworkCore;
using MvcProject.Areas.Admin.Models.Entities;

namespace MvcProject.Areas.Admin.Models.Context;

public class NortwindDatabaseContext : DbContext
{
    // Define Tables
    public DbSet<User> Users { get; set; }
    public DbSet<Employee> Employees { get; set; }
    
    public NortwindDatabaseContext(DbContextOptions<NortwindDatabaseContext> options) : base(options) {}
}