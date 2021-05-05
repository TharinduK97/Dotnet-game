using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using xxx.Dtos.Character;
using xxx.Models;

namespace xxx.Services.CharacterService
{
    public class CharacterService : ICharacterService
    {

            private static List<Character> characters = new List<Character> {
            new Character(),
            new Character{ Id=1, Name = "Kuma"}
        };

        public async Task<ServiceResponse<List<GetCharacterDto>>> AddCharacter(AddCharacterDto newCharacter)
        {
            var serviceResponse = new ServiceResponse<List<GetCharacterDto>>();
            characters.Add(newCharacter);
            serviceResponse.Data = characters;
            return serviceResponse;
        }

        public async Task<ServiceResponse<List<GetCharacterDto>>> GetAllCharacters()
        {
             var serviceResponse = new ServiceResponse<List<GetCharacterDto>>();
             serviceResponse.Data = characters;
             return serviceResponse;
        }

        public async Task<ServiceResponse<GetCharacterDto>> GetCharacterById(int id)
        {
             var serviceResponse = new ServiceResponse<GetCharacterDto>();
            serviceResponse.Data= characters.FirstOrDefault(c => c.Id == id);
            return serviceResponse;
        }
    }
}