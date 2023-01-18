using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnet_rpg
{
    public class AutoMapperProfile : Profile
    {
        // constructor witt no parmater
        public AutoMapperProfile()
        {
            CreateMap<Character, GetCharacterDto>();
            CreateMap<AddCharacterDto, Character>();

            // option if _mapper.Map(updatedCharacter, character); is used in CharacterService
            // CreateMap<UpdateCharacterDto, Character>();


        }
    }
}