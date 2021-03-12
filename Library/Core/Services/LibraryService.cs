using Library.Core.Common;
using Library.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.Core.Services
{
    public class LibraryService
    {
        private IUnitOfWork unitOfWork;
        public LibraryService(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public void CreateBook(Book book, Author author) {
            
            book.BooksAuthors = new List<BookAuthor>
            {
              new BookAuthor {
                Author = author,
                Book = book,
              }
            };

            //Now add this book, with all its relationships, to the database
            unitOfWork.BookRepository.Insert(book);
            unitOfWork.Save();
        }
    }
}
