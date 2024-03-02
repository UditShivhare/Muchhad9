using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LoginAPI.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        
        public string SayHii()
        {
            return "Hii Learners";
        }
    }
}
