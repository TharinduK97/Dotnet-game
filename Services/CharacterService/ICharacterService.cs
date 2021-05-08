using System.Collections.Generic;
using System.Threading.Tasks;
using xxx.Dtos.Character;
using xxx.Models;

namespace xxx.Services.CharacterService
{
    public interface ICharacterService
    {
          Task<ServiceResponse<List<GetCharacterDto>>> GetAllCharacters();
         Task<ServiceResponse<GetCharacterDto>> GetCharacterById(int id);
          Task<ServiceResponse<List<GetCharacterDto>>>  AddCharacter(AddCharacterDto newCharacter);
          Task<ServiceResponse<GetCharacterDto>> UpdateCharacter(UpdateCharacterDto updateCharacter);
    }
}