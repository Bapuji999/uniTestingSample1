using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace XUnitExample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        [HttpGet]
        public string Index()
        {
            return "I am in Home.";
        }
        [HttpGet("CheckNumber/{guessedNumber}")]
        public string CheckNumber(int guessedNumber)
        {
            if (guessedNumber > 100)
            {
                return "Worng ! try Smaller Number.";
            }
            else if (guessedNumber < 100)
            {
                return "Worng ! try Greter Number.";
            }
            else
            {
                return "You guessed correct number.";
            }
        }
    }
}
