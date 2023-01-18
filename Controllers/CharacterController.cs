using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace dotnet_rpg.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CharacterController: ControllerBase
    {
        // private static Character knight = new Character();
        private static List<Character> characters = new List<Character>{
            new Character(),
            new Character { Name = "Sam"}
        };
      

        /*
         GET list of  characters
        */
        // allows us to send specific HTTP status code back to client together with requested data
        [HttpGet("GetAll")]
        public ActionResult<List<Character>> Get()
        {
            // return Ok(knight);
            return Ok(characters);
        }

        /*
         GET a single character
        */
        
        [HttpGet]
        public ActionResult<List<Character>> GetSingle()
        {
            // return Ok(knight);
            return Ok(characters[0]);
        }
    }
}