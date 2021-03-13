using Core.Entities;
using Core.Interface;
using Infrastructure;
using Infrastructure.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace Web.Controllers
{
    [Route("library")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private IUnitOfWork unitOfWork;
        private BookRepository BookRepository;
        public BooksController(IUnitOfWork unitOfWork, LibraryContext context)
        {
            this.unitOfWork = unitOfWork;
            this.BookRepository = new BookRepository(context);
        }
        // GET: api/<BooksController>
        [HttpGet]
        public IEnumerable<Book> Get()
        {
            var books = BookRepository.GetBooksAndReviews();
            return books;
        }

        // GET api/<BooksController>/5
        [HttpGet("{id}")]
        public Book Get(int id)
        {
            var book = BookRepository.GetBookAndReviews(id);
            return book;
        }

        // POST api/<BooksController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<BooksController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<BooksController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
