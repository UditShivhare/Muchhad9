using LoginApiN.Data;
using LoginApiN.Models;
using LoginApiN.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;

namespace LoginApiN.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class BookController : ControllerBase
    {
        private readonly IBookRepository _bookRepository;

        public BookController(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllBook()
        {
            var records = await _bookRepository.GetAppBookAsync();
            return Ok(records);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetAllBookById([FromRoute]int id)
        {
            var records = await _bookRepository.GetBookByIdAsync(id);
            if (records == null)
            {
                NotFound();
            }
            return Ok(records);
        }

        [HttpPost]
        public async Task<IActionResult> AddNewBook([FromBody] BookModel model)
        {
            var Id = await _bookRepository.AddBookAsync(model);
            return CreatedAtAction( nameof(GetAllBookById), new { id = Id, Controller = "Book" }, Id);
            //return Ok(records);
        }

        [HttpPatch("{id}")]
        public async Task<IActionResult> UpdateBookPatch([FromRoute] int id,[FromBody] JsonPatchDocument bookModel)
        {
           await _bookRepository.UpdateBookPatchAsync(id,bookModel);
           return Ok();
        }
    }
}
