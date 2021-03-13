using Library.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Library.Core.Common
{
    public class BookRepository : IRepository<Book>
    {
        public void Delete(object id)
        {
            throw new NotImplementedException();
        }

        public void Delete(Book entityToDelete)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Book> Get(Expression<Func<Book, bool>> filter = null, Func<IQueryable<Book>, IOrderedQueryable<Book>> orderBy = null, string includeProperties = "")
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Book> GetAll()
        {

        }

        public Book GetByID(object id)
        {
            throw new NotImplementedException();
        }

        public void Insert(Book entity)
        {
            throw new NotImplementedException();
        }

        public void Update(Book entityToUpdate)
        {
            throw new NotImplementedException();
        }
    }
}
