using Project1.Models;

namespace Project1.Business
{
    public interface IComputerService
    {
        Task AddComputer(Computer computer);
        Task<IEnumerable<Computer>> GetAsync();
    }
}