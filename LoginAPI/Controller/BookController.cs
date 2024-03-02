using LoginAPI.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace LoginAPI.Controller
{
    [Route("api/[controller]")]
    [ApiController]
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
            var records = await _bookRepository.GetAllBooksAsync();
            return Ok(records);
        }

        //public async Task<IActionResult> GetBookById(int Id)
        //{
        //   var book= await _bookRepository.GetBookById(Id);
        //    return Ok(book);
        //}


    }
}
