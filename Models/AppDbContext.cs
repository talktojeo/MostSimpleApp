using Microsoft.EntityFrameworkCore;
using System; // 👈 This is necessary for DateTime

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options) { }

    public DbSet<CurrentTime> Times { get; set; }
}

public class CurrentTime
{
    public int Id { get; set; }
    public DateTime ServerTime { get; set; }
}
