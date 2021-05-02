using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using xxx.Models;

namespace xxx.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CharacterController : ControllerBase
    {
        private static List<Character> characters = new List<Character> {
            new Character(),
            new Character{ Name = "Kuma"}
        };

        [HttpGet("GetAll")]
        
        public ActionResult<List<Character>> Get(){
                return Ok(characters);
        }

        [HttpGet]
        public ActionResult<Character> GetSingle(){
            return Ok(characters[0]);
        }
    }
}