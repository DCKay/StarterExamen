using Microsoft.EntityFrameworkCore;
using Project1.Data;
using Project1.Models;

namespace Project1.Business
{
    public class MousematService : IMousematService
    {
        private ApplicationDbContext _context;

        public MousematService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Mousemat>> GetAsync()
        {
            return await _context.Mousemats.ToArrayAsync();
        }

        public async Task AddMousemat(Mousemat mousemat)
        {
            _context.Add(mousemat);
            await _context.SaveChangesAsync();
        }
    }
}