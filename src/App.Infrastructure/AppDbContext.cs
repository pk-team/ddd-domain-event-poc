using App.Domain.Users;

using Microsoft.EntityFrameworkCore;

namespace App.Infrastructure;

public class AppDbContext : DbContext {
    public DbSet<User> Users { get; set; } = null!;

    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder) {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);
    }
}