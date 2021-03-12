
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
        }
    }
}
