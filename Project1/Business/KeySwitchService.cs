using Microsoft.EntityFrameworkCore;
using Project1.Data;
using Project1.Models.Items
;

namespace Project1.Business
{
    public class KeySwitchService : IKeySwitchService
    {
        private ApplicationDbContext _context;

        public KeySwitchService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<KeySwitch>> GetAsync()
        {
            return await _context.KeySwitches.ToArrayAsync();
        }

        public async Task AddKeySwitch(KeySwitch keySwitch)
        {
            _context.Add(keySwitch);
            await _context.SaveChangesAsync();
        }

        public async Task RemoveKeySwitch(KeySwitch keySwitch)
        {
            _context.Remove(keySwitch);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateKeySwitch(KeySwitch keySwitch)
        {
            _context.Update(keySwitch);
            await _context.SaveChangesAsync();
        }
    }
}