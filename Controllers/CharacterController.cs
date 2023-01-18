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
        private static Character knight = new Character();
      

        /*
        Implement the GET Method to get our game character
        */
        // allows us to send specific HTTP status code back to client together with requested data
        [HttpGet]
        // public IActionResult Get()
        public ActionResult<Character> Get()
      
        {
            // return Ok(knight);
            return Ok(knight);
        }
    }
}