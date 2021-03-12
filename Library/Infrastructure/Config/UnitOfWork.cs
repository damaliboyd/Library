using Library.Core.Entities;
using Library.Infrastructure.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.Infrastructure.Config
{
    public class UnitOfWork 
    {
        private LibraryContext context;
        private GenericRepository<Book> Books;
        private GenericRepository<Author> Authors;
        private GenericRepository<Review> Reviews;

        public UnitOfWork(LibraryContext context)
        {
            this.context = context;
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
