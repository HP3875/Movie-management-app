using Microsoft.EntityFrameworkCore;

public class HPDbContext : DbContext
{
    public HPDbContext(DbContextOptions<HPDbContext> options) : base(options)
    {
    }

    public DbSet<Movie> Movies { get; set; }
}
