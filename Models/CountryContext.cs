using HomeWork65.Services;
using Microsoft.EntityFrameworkCore;

namespace HomeWork65.Models;

public class CountryContext :DbContext
{
    public DbSet<Country> Countries { get; set; }

    public CountryContext(DbContextOptions<CountryContext> options) : base(options) { }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        new CountryInitializer(modelBuilder).Seed();
    }
}