using System.Collections.Generic;

namespace Core.Entities
{
    public class Author
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public ICollection<BookAuthor> BooksAuthors { get; set; }
    }
}
