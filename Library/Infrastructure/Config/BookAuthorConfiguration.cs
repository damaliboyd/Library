using Library.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.Infrastructure.Config
{
    public class BookAuthorConfiguration : IEntityTypeConfiguration<BookAuthor>
    {
        public void Configure(EntityTypeBuilder<BookAuthor> builder)
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

            builder
                .HasData(
                    new BookAuthor
                    {
                        BookId = 1,
                        AuthorId = 1
                    },
                    new BookAuthor
                    {
                        BookId = 2,
                        AuthorId = 1
                    },
                    new BookAuthor
                    {
                        BookId = 3,
                        AuthorId = 1
                    },
                    new BookAuthor
                    {
                        BookId = 3,
                        AuthorId = 2
                    },
                    new BookAuthor
                    {
                        BookId = 4,
                        AuthorId = 3
                    },
                    new BookAuthor
                    {
                        BookId = 5,
                        AuthorId = 3
                    }
                );

        }
    }
}
