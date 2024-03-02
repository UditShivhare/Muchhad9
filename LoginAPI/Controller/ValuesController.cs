using LoginAPI.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LoginAPI.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly IBookRepository _bookRepository;

        public ValuesController(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }
        public string SayHii()
        {
            return "Hii Learners values";
        }
    }
}
