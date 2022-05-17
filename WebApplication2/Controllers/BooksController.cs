using Microsoft.AspNetCore.Mvc;
using WebApplication2.Models;
using System.Collections.Generic;

namespace WebApplication2.Controllers
{
    [ApiController]
    [Route("/api/books")]
    public class BooksController : ControllerBase
    {
        private List<Books> Books { get; set; }

        public BooksController()
        {
            Books = new List<Books>()
            {
                new Books() {Id = 1, Author = "R.R. Tolkien", Genre = "fantasy"},
                new Books() {Id = 2, Author = "Martin George", Genre = "fantasy"},
                new Books() {Id = 3, Author = "Clive Staples Lewis", Genre = "fantasy"},
                new Books() {Id = 4, Author = "Andrzej Sapkowski", Genre = "fantasy"},
                new Books() {Id = 5, Author = "Rowling Joan Kathleen", Genre = "fantasy"},
            };
        }
        [HttpGet]
        public ActionResult GetAllBooks()
        {
            return Ok(Books);
        }
    }
}
