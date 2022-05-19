using Project1.Models;

namespace Project1.Business
{
    public interface IMousematService
    {
        Task AddMousemat(Mousemat mousemat);

        Task RemoveMousemat(Mousemat mousemat);

        Task<IEnumerable<Mousemat>> GetAsync();
    }
}