using Microsoft.EntityFrameworkCore;
using Project1.Data;
using Project1.Models;

namespace Project1.Business
{
    public class KeycapService : IKeycapService
    {
        private ApplicationDbContext _context;

        public KeycapService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Keycap>> GetAsync()
        {
            return await _context.Keycaps.ToArrayAsync();
        }

        public async Task AddKeycap(Keycap keycap)
        {
            _context.Add(keycap);
            await _context.SaveChangesAsync();
        }

        public async Task RemoveKeycap(Keycap keycap)
        {
            _context.Remove(keycap);
            await _context.SaveChangesAsync();
        }
        public async Task UpdateKeycap(Keycap keycap)
        {
            _context.Update(keycap);
            await _context.SaveChangesAsync();
        }

    }
}