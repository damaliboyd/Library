using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.Core.Entities
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Genre { get; set; }
        public ICollection<BookAuthor> BooksAuthors { get; set; }
        public ICollection<Review> Reviews {get;set;}
    }
}
