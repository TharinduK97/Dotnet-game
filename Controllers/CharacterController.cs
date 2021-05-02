using Microsoft.AspNetCore.Mvc;
using xxx.Models;

namespace xxx.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CharacterController : ControllerBase
    {
        private static Character knight= new Character();

        [HttpGet]
        public ActionResult<Character> Get(){
                return Ok(knight);
        }
    }
}