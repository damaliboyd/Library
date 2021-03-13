using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Config
{
    public class AuthorConfiguration : IEntityTypeConfiguration<Author>
    {
        public void Configure(EntityTypeBuilder<Author> builder)
        {
            builder
                .Property(a => a.FirstName)
                .IsRequired();

            builder
                .Property(a => a.LastName)
                .IsRequired();

            builder
                .HasData(
                    new Author
                    {
                        Id = 1,
                        FirstName = "John",
                        LastName = "Doe"
                    },
                    new Author
                    {
                        Id = 2,
                        FirstName = "Captain",
                        LastName = "Morgan"
                    },
                    new Author
                    {
                        Id = 3,
                        FirstName = "Rick",
                        LastName = "Sanchez"
                    }
                 );
        }
    }
}
