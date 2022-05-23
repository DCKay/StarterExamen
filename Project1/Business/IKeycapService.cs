using Project1.Models;
using Project1.Models.Items;

namespace Project1.Business
{
    public interface IKeycapService
    {
        Task AddKeycap(Keycap keycap);

        Task RemoveKeycap(Keycap keycap);

        Task UpdateKeycap(Keycap keycap);

        Task<IEnumerable<Keycap>> GetAsync();
    }
}