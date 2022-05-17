
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    [ApiController]
    [Route("/api/reader")]
    public class ReaderController : ControllerBase
    {
        private List<Reader> Reader { get; set; }

        public ReaderController()
        {
            Reader = new List<Reader>()
            {
                new Reader() {Id = 1, FirstName = "Andrey", LastName = "Ivanov", Age = 8},
                new Reader() {Id = 2, FirstName = "Masha", LastName = "Petrov", Age = 8},
                new Reader() {Id = 3, FirstName = "Alexander", LastName = "Sidorov", Age = 8},
                new Reader() {Id = 4, FirstName = "Yulia", LastName = "Abobbov", Age = 8},
                new Reader() {Id = 5, FirstName = "Svetlana", LastName = "Popolov", Age = 8},
               
            };
        }
        
        [HttpGet]
        public ActionResult GetAllReader()
        {
            return Ok(Reader);
        }
    }
}