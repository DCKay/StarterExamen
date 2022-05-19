using Microsoft.EntityFrameworkCore;
using Project1.Data;
using Project1.Models;

namespace Project1.Business
{
    public class HeadsetService : IHeadsetService
    {
        private ApplicationDbContext _context;

        public HeadsetService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Headset>> GetAsync()
        {
            return await _context.Headsets.ToArrayAsync();
        }

        public async Task AddHeadset(Headset headset)
        {
            _context.Add(headset);
            await _context.SaveChangesAsync();
        }

        public async Task RemoveHeadset(Headset headset)
        {
            _context.Remove(headset);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateHeadset(Headset headset)
        {
            _context.Update(headset);
            await _context.SaveChangesAsync();
        }
    }
}