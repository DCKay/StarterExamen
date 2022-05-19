using Microsoft.EntityFrameworkCore;
using Project1.Data;
using Project1.Models;

namespace Project1.Business
{
    public class ScreenService : IScreenService
    {
        private ApplicationDbContext _context;

        public ScreenService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Screen>> GetAsync()
        {
            return await _context.Screens.ToArrayAsync();
        }

        public async Task AddScreen(Screen screen)
        {
            _context.Add(screen);
            await _context.SaveChangesAsync();
        }
    }
}