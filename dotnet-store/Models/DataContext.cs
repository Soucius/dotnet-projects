using Microsoft.EntityFrameworkCore;
namespace dotnet_store.Models;

public class DataContext : DbContext {
    public DataContext(DbContextOptions<DataContext> options) : base(options) {
        
    }

    public DbSet<Urun> Urunler { get; set; }
}