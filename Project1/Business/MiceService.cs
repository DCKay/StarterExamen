using Microsoft.EntityFrameworkCore;
using Project1.Data;
using Project1.Models;

namespace Project1.Business
{
    public class MiceService : IMiceService
    {
        private ApplicationDbContext _context;

        public MiceService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Mice>> GetAsync()
        {
            return await _context.ManyMice.ToArrayAsync();
        }

        public async Task AddMice(Mice mice)
        {
            _context.Add(mice);
            await _context.SaveChangesAsync();
        }

        public async Task RemoveMice(Mice mice)
        {
            _context.Remove(mice);
            await _context.SaveChangesAsync();
        }
    }
}