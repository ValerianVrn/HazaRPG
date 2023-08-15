using HazaRPG.Api.Infrastructure;
using HazaRPG.Api.Models;
using Microsoft.EntityFrameworkCore;

namespace HazaRPG.Api.Repositories
{
    public class CharacterRepository : ICharacterRepository
    {
        private readonly ApplicationContext _context;

        public CharacterRepository(ApplicationContext applicationContext)
        {
            _context = applicationContext;
        }

        public async Task<List<Character>> GetCharacterListAsync()
        {
            return await _context
                .Characters
                .ToListAsync();
        }

        public async Task<Character> GetCharacterAsync(int id)
        {
            var character = await _context
                .Characters
                .FirstOrDefaultAsync(o => o.Id == id);
            if (character == null)
            {
                character = _context
                    .Characters
                    .Local
                    .FirstOrDefault(o => o.Id == id);
            }

            if (character != null)
            {
                await _context.Entry(character)
                    .Reference(i => i.ArtifactEquipment).LoadAsync();
                await _context.Entry(character)
                    .Reference(i => i.DefenseEquipment).LoadAsync();
                await _context.Entry(character)
                    .Reference(i => i.AttackEquipment).LoadAsync();
            }

            return character;
        }
    }
}
