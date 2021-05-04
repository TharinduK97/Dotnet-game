using System.Collections.Generic;
using xxx.Models;

namespace xxx.Services.CharacterService
{
    public interface ICharacterService
    {
         List<Character> GetAllCharacters();
         Character GetCharacterById(int id);
         List<Character> AddCharacter(Character newCharacter);
    }
}