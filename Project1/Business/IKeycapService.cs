using Project1.Models;

namespace Project1.Business
{
    public interface IKeycapService
    {
        Task AddKeycap(Keycap keycap);

        Task<IEnumerable<Keycap>> GetAsync();
    }
}