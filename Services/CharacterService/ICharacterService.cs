using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnet_rpg.Services.CharacterService
{
    public interface ICharacterService
    {
        // get all the 3 methods
        List<Character> GetAllCharacters();

        Character GetCharacterById(int id);

        List<Character> AddCharacter(Character newCharacter);
    }
}