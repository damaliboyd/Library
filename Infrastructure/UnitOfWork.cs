using Core.Interface;
using Core.Entities;
using Infrastructure.Repository;
using System;

namespace Infrastructure
{

    public class UnitOfWork : IUnitOfWork
    {
        private LibraryContext context;
        private IRepository<Book> bookRepository;
        private IRepository<Author> authorRepository;
        private IRepository<Review> reviewRepository;

        public UnitOfWork(LibraryContext context)
        {
            this.context = context;
        }

        public IRepository<Book> BookRepository
        {
            get
            {

                if (this.bookRepository == null)
                {
                    this.bookRepository = new BookRepository(context);
                }
                return BookRepository;
            }
        }

        public IRepository<Author> AuthorRepository
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

        public IRepository<Review> ReviewRepository
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
