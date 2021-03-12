
using Library.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Library.Infrastructure.Config
{
    public class ReviewConfiguration : IEntityTypeConfiguration<Review>
    {
        public void Configure(EntityTypeBuilder<Review> builder)
        {
            builder
                .Property(r => r.Reviewer)
                .IsRequired();

            builder
                .Property(r => r.Text)
                .IsRequired();

            builder
                .HasOne(r => r.Book)
                .WithMany(b => b.Reviews)
                .IsRequired();

            builder
                .HasData(
                    new Review
                    {
                        Id = 1,
                        Text = "Boring!!!!",
                        Reviewer = "Aaron Burr",
                        BookId = 1,
                    },
                    new Review
                    {
                        Id = 2,
                        Text = "This book was okay.",
                        Reviewer = "Timult",
                        BookId = 2,
                    },
                    new Review
                    {
                        Id = 3,
                        Text = "Thoroughly enjoyed reading this book. Would totally read again every few years.",
                        Reviewer = "BookReader101",
                        BookId = 5,
                    },
                    new Review
                    {
                        Id = 4,
                        Text = "5/5. Pretty Scary!!!!",
                        Reviewer = "Jackson B.",
                        BookId = 5,
                    }
                );
        }
    }
}
