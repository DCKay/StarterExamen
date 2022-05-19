using Microsoft.EntityFrameworkCore;
using Project1.Data;
using Project1.Models;

namespace Project1.Business
{
    public class KeyboardService : IKeyboardService
    {
        private ApplicationDbContext _context;

        public KeyboardService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Keyboard>> GetAsync()
        {
            return await _context.Keyboards.ToArrayAsync();
        }

        public async Task AddKeyboard(Keyboard keyboard)
        {
            _context.Add(keyboard);
            await _context.SaveChangesAsync();
        }
    }
}