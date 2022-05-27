using Microsoft.EntityFrameworkCore;
using Project1.Data;
using Project1.Models.Items
;

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

        public async Task RemoveMousemat(Mousemat mousemat)
        {
            _context.Remove(mousemat);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateMousemat(Mousemat mousemat)
        {
            _context.Update(mousemat);
            await _context.SaveChangesAsync();
        }
    }
}