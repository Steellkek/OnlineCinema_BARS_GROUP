using Microsoft.EntityFrameworkCore;
using OnlineCinema_BARS_GROUP.Data.Models;

namespace OnlineCinema_BARS_GROUP.Data;

public class CinemaContext : DbContext
{
    public DbSet<AgeRestriction> AgeRestrictions { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Comment> Comments { get; set; }
    public DbSet<Genre> Genres { get; set; }
    public DbSet<Movie> Movies { get; set; }
    public DbSet<Playlist> Playlists { get; set; }
    public DbSet<Review> Reviews { get; set; }
    public DbSet<Room> Rooms { get; set; }
    public DbSet<User> Users { get; set; }

    public CinemaContext(DbContextOptions<CinemaContext> options)
        : base(options)
    {
        
    }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<AgeRestriction>().HasKey(x => x.Id);
        modelBuilder.Entity<Category>().HasKey(x => x.Id);
        modelBuilder.Entity<Comment>().HasKey(x => x.Id);
        modelBuilder.Entity<Genre>().HasKey(x => x.Id);
        modelBuilder.Entity<Movie>().HasKey(x => x.Id);
        modelBuilder.Entity<Playlist>().HasKey(x => x.Id);
        modelBuilder.Entity<Review>().HasKey(x => x.Id);
        modelBuilder.Entity<Room>().HasKey(x => x.Id);
        modelBuilder.Entity<User>().HasKey(x => x.Id);
        
        modelBuilder.Entity<Comment>()
            .HasOne(x => x.Parent)
            .WithMany(x => x.Children);
        
        /*modelBuilder.Entity<Comment>()
            .HasOne(x => x.Review)
            .WithMany(x => x.Comments);*/

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

        modelBuilder.Entity<Movie>()
            .HasOne(x => x.AgeRestriction)
            .WithMany(x => x.Movies);
        
        modelBuilder.Entity<Movie>()
            .HasMany(x => x.Rooms)
            .WithMany(x => x.Movies);
        
        modelBuilder.Entity<Movie>()
            .HasMany(x => x.Playlists)
            .WithMany(x => x.Movies);
        
        modelBuilder.Entity<User>()
            .HasMany(x => x.Rooms)
            .WithMany(x => x.Users);
    }
}