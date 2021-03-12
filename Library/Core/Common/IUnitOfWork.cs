using Library.Core.Entities;
using Library.Infrastructure.Repository;

namespace Library.Core.Common
{
    public interface IUnitOfWork
    {
        GenericRepository<Author> AuthorRepository { get; }
        GenericRepository<Book> BookRepository { get; }
        GenericRepository<Review> ReviewRepository { get; }
        void Dispose();
        void Save();
    }
}