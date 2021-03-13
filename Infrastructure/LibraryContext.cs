using Core.Entities;
using Infrastructure.Config;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure
{
    public class LibraryContext : DbContext
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Review> Reviews { get; set; }

        public LibraryContext(DbContextOptions<LibraryContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new BookConfiguration());
            modelBuilder.ApplyConfiguration(new AuthorConfiguration());
            modelBuilder.ApplyConfiguration(new ReviewConfiguration());
            modelBuilder.ApplyConfiguration(new BookAuthorConfiguration());
        }
    }
}
