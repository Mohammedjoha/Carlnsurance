using Microsoft.EntityFrameworkCore;

public class CarlnsuranceContext(DbContextOptions<CarlnsuranceContext> options) : DbContext(options)
{
    public DbSet<CarInsurance.Models.Insuree> Insuree { get; set; } = default!;
}
