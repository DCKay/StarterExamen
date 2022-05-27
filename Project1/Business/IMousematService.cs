using Project1.Models.Items;

namespace Project1.Business
{
    public interface IMousematService
    {
        Task AddMousemat(Mousemat mousemat);

        Task RemoveMousemat(Mousemat mousemat);

        Task UpdateMousemat(Mousemat mousemat);

        Task<IEnumerable<Mousemat>> GetAsync();
    }
}