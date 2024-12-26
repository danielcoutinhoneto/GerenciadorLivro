using GerenciadorLivro.API.Models;
using Microsoft.AspNetCore.Mvc;

namespace GerenciadorLivro.API.Controllers
{
    [Route("api/livros")]
    [ApiController]
    public class BooksController : ControllerBase
    {

        // GET api/books
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok();
        }

        // GET api/books/123
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            return Ok();
        }

        // POST api/books
        [HttpPost]
        public IActionResult Post(CreateBooksInputModel model)
        {
            return CreatedAtAction(nameof(GetById), new { id = 1 }, model);
        }

        // DELETE api/books//123
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return NoContent();
        }


    }
}
