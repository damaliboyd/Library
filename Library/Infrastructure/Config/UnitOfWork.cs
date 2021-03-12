using Library.Core.Common;
using Library.Core.Entities;
using Library.Infrastructure.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.Infrastructure.Config
{

    public class UnitOfWork : IUnitOfWork
    {
        private LibraryContext context;
        private GenericRepository<Book> bookRepository;
        private GenericRepository<Author> authorRepository;
        private GenericRepository<Review> reviewRepository;

        public UnitOfWork(LibraryContext context)
        {
            this.context = context;
        }

        public GenericRepository<Book> BookRepository
        {
            get
            {

                if (this.bookRepository == null)
                {
                    this.bookRepository = new GenericRepository<Book>(context);
                }
                return BookRepository;
            }
        }

        public GenericRepository<Author> AuthorRepository
        {
            get
            {

                if (this.authorRepository == null)
                {
                    this.authorRepository = new GenericRepository<Author>(context);
                }
                return AuthorRepository;
            }
        }

        public GenericRepository<Review> ReviewRepository
        {
            get
            {

                if (this.reviewRepository == null)
                {
                    this.reviewRepository = new GenericRepository<Review>(context);
                }
                return ReviewRepository;
            }
        }


        public void Save()
        {
            context.SaveChanges();
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
