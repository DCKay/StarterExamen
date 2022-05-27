using Microsoft.EntityFrameworkCore;
using Project1.Data;
using Project1.Models.Items;

namespace Project1.Business
{
    public class MicrophoneService : IMicrophoneService
    {
        private ApplicationDbContext _context;

        public MicrophoneService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Microphone>> GetAsync()
        {
            return await _context.Microphones.ToArrayAsync();
        }

        public async Task AddMicrophone(Microphone microphone)
        {
            _context.Add(microphone);
            await _context.SaveChangesAsync();
        }

        public async Task RemoveMicrophone(Microphone microphone)
        {
            _context.Remove(microphone);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateMicrophone(Microphone microphone)
        {
            _context.Update(microphone);
            await _context.SaveChangesAsync();
        }
    }
}