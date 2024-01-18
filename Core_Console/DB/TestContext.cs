using Microsoft.EntityFrameworkCore;

namespace Core_Console.DB;
public class TestContext : DbContext
{
    public DbSet<Film> Films { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder options) =>
            options.UseSqlite("DataSource=products.db;Cache=Shared");
}