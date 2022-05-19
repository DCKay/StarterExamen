using Microsoft.EntityFrameworkCore;
using Project1.Data;
using Project1.Models;

namespace Project1.Business
{
    public class ComputerService : IComputerService
    {
        private ApplicationDbContext _context;

        public ComputerService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Computer>> GetAsync()
        {
            return await _context.Computers.ToArrayAsync();
        }

        public async Task AddComputer(Computer computer)
        {
            _context.Add(computer);
            await _context.SaveChangesAsync();
        }

        public async Task RemoveComputer(Computer computer)
        {
            _context.Remove(computer);
            await _context.SaveChangesAsync();
        }
    }
}