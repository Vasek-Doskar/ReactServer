using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ReactServer.Models;

namespace ReactServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RandomController : ControllerBase
    {
        [HttpPost]
        public IActionResult GetRandom([FromBody] Randomator randomator)
        {
            if(randomator is not null)
            {
                return Ok(randomator.Random);
            }
            return BadRequest("Chyba");
        }
    }
}
