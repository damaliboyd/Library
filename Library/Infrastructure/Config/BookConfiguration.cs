using Library.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Library.Infrastructure.Config
{
    public class BookConfiguration : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder
                .Property(b => b.Title)
                .IsRequired();

            builder
                .Property(b => b.Genre)
                .IsRequired();

            builder
                .HasData(
                    new Book
                    {
                        Id = 1,
                        Title = "Discovering Alternate Dimensions",
                        Genre = "Science Fiction"
                    },
                    new Book
                    {
                        Id = 2,
                        Title = "Autobiography of Alexander Hamilton",
                        Genre = "Nonfiction"
                    },
                    new Book
                    {
                        Id = 3,
                        Title = "Doctor What",
                        Genre = "Science Fiction"
                    },
                    new Book
                    {
                        Id = 4,
                        Title = "Call of Cuthulu",
                        Genre = "Horror"
                    },
                    new Book
                    {
                        Id = 5,
                        Title = "Murder on Crow Hill",
                        Genre = "Horror"
                    });
        }
    }
}
