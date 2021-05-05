using System.Collections.Generic;
using System.Threading.Tasks;
using xxx.Models;

namespace xxx.Services.CharacterService
{
    public interface ICharacterService
    {
          Task<ServiceResponse<List<Character>>> GetAllCharacters();
         Task<ServiceResponse<Character>> GetCharacterById(int id);
          Task<ServiceResponse<List<Character>>>  AddCharacter(Character newCharacter);
    }
}