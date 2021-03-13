using Core.Entities;
using Core.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infrastructure.Repository
{
    public class BookRepository : GenericRepository<Book>
    {
        public BookRepository(LibraryContext context):base(context)
        {
            this.context = context;
        }

        public IEnumerable<Book> GetBooksAndReviews()
        {
            var books = context.Books
                .Include(books => books.BooksAuthors)
                .ThenInclude(bookauthor => bookauthor.Author)
                .ToList();
            return books;
        }

        public Book GetBookAndReviews(int id)
        {
            var book = context.Books
                .Include(books => books.BooksAuthors)
                .ThenInclude(booksauthors => booksauthors.Author)
                .Include(books => books.Reviews)
                .Single(book => book.Id == id);
            return book;
        }
    }
}
