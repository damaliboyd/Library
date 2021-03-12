using Library.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.Infrastructure.Config
{
    public class BooksAuthorsConfiguration : IEntityTypeConfiguration<BooksAuthors>
    {
        public void Configure(EntityTypeBuilder<BooksAuthors> builder)
        {
            builder
             .HasKey(t => new { t.BookId, t.AuthorId});
                 

            builder
                .HasOne(ba => ba.Book)
                .WithMany(b => b.BooksAuthors)
                .HasForeignKey(ba => ba.BookId);

            builder
                .HasOne(ba => ba.Author)
                .WithMany(a => a.BooksAuthors)
                .HasForeignKey(ba => ba.AuthorId);

        }
    }
}
