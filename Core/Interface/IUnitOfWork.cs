using Core.Entities;

namespace Core.Interface
{
    public interface IUnitOfWork
    {
        IRepository<Author> AuthorRepository { get; }
        IRepository<Book> BookRepository { get; }
        IRepository<Review> ReviewRepository { get; }
        void Dispose();
        void Save();
    }
}