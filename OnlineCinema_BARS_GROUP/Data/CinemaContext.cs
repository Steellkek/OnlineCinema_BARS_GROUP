using Microsoft.EntityFrameworkCore;
using OnlineCinema_BARS_GROUP.Data.Models;

namespace OnlineCinema_BARS_GROUP.Data;

public class CinemaContext : DbContext
{
    public DbSet<Category> Categories { get; set; }
    public DbSet<Genre> Genres { get; set; }
    public DbSet<Movie> Movies { get; set; }
    public DbSet<Review> Reviews { get; set; }
    public DbSet<User> Users { get; set; }

    public CinemaContext(DbContextOptions<CinemaContext> options)
        : base(options)
    {
        
    }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Category>().HasKey(x => x.Id);
        modelBuilder.Entity<Genre>().HasKey(x => x.Id);
        modelBuilder.Entity<Movie>().HasKey(x => x.Id);
        modelBuilder.Entity<Review>().HasKey(x => x.Id);
        modelBuilder.Entity<User>().HasKey(x => x.Id);

        modelBuilder.Entity<User>()
            .HasMany(x => x.Reviews)
            .WithOne(x => x.Author);

        modelBuilder.Entity<Movie>()
            .HasMany(x => x.Genres)
            .WithMany(x => x.Movies);

        modelBuilder.Entity<Movie>()
            .HasOne(x => x.Category)
            .WithMany(x => x.Movies);

        modelBuilder.Entity<Movie>()
            .HasMany(x => x.Reviews)
            .WithOne(x => x.Movie);

    }
}