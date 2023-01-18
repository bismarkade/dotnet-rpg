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
            new Character { Id = 1,  Name = "Sam"}
        };
        private readonly ICharacterService _characterService;


        // Character Constructor
        public CharacterController(ICharacterService characterService)
      {
            _characterService = characterService;
        }
        
        /*
         GET list of  characters
        */
        // allows us to send specific HTTP status code back to client together with requested data
        [HttpGet("GetAll")]
        public async Task<ActionResult<ServiceResponse<List<GetCharacterDto>>>> Get()
        {
            // return Ok(knight);
            return Ok(await _characterService.GetAllCharacters());
        }


        /*
         GET a single character
        */
        [HttpGet("{id}")]
        public async Task<ActionResult<ServiceResponse<List<GetCharacterDto>>>> GetSingle(int id)
        {
            return Ok(await _characterService.GetCharacterById(id));
        }

        /*
        POST a character
        */
        [HttpPost]
        public async Task<ActionResult<ServiceResponse<List<GetCharacterDto>>>> AddCharacter(AddCharacterDto newCharacter)
        {
            return Ok(await _characterService.AddCharacter(newCharacter));
        }

        /*
        Update a character
        */
        [HttpPut]
        public async Task<ActionResult<ServiceResponse<List<GetCharacterDto>>>> UpdateCharacter(UpdateCharacterDto updatedCharacter)
        {
            var response = await _characterService.UpdateCharacter(updatedCharacter);
            if(response.Data is null){
                return NotFound(response);
            }
            return Ok(response);
        }

    }
}