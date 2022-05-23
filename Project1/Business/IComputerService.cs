using Project1.Models;
using Project1.Models.Items;

namespace Project1.Business
{
    public interface IComputerService
    {
        Task AddComputer(Computer computer);

        Task RemoveComputer(Computer computer);

        Task UpdateComputer(Computer computer);

        Task<IEnumerable<Computer>> GetAsync();
    }
}