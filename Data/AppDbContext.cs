using Microsoft.EntityFrameworkCore;
using BackendApi.Models;
namespace BackendApi.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext() { }
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<Product> Products { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        //cambiar nombre de mi servidor
        optionsBuilder.UseSqlServer("server=LUDKANT;Initial Catalog=ProductDb;Trusted_Connection=True;TrustServerCertificate=True;");
    }        
    }
}