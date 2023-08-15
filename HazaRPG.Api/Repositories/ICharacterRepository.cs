using HazaRPG.Api.Models;

namespace HazaRPG.Api.Repositories
{
    public interface ICharacterRepository
    {
        Task<List<Character>> GetCharacterListAsync();

        Task<Character> GetCharacterAsync(int id);
    }
}
