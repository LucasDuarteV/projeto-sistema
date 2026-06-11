using Microsoft.EntityFrameworkCore;

public class SalesWebMvcContext(DbContextOptions<SalesWebMvcContext> options) : DbContext(options)
{
    public DbSet<SalesWebMvc.Models.ViewModels.Department> Department { get; set; } = default!;
}
