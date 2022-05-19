using Project1.Models;

namespace Project1.Business
{
    public interface IMiceService
    {
        Task AddMice(Mice mice);

        Task RemoveMice(Mice mice);

        Task<IEnumerable<Mice>> GetAsync();
    }
}