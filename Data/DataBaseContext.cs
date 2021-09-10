using Microsoft.EntityFrameworkCore;
namespace Blazor.Data;

public class DataBaseContext : DbContext {

  public DbSet<Product> Products {get; set;}

  public DataBaseContext(DbContextOptions<DataBaseContext> options) : base(options) {

  }
}