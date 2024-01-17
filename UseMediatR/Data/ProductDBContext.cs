using Microsoft.EntityFrameworkCore;
using UseMediatR.Models;

namespace UseMediatR.Data;
public class ProductDBContext : DbContext
{
    public DbSet<Product> Products { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder options) =>
            options.UseSqlite("DataSource=products.db;Cache=Shared");
}