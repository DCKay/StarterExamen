using Project1.Models.Items
;

namespace Project1.Business
{
    public interface IMiceService
    {
        Task AddMice(Mice mice);

        Task RemoveMice(Mice mice);

        Task UpdateMice(Mice mice);

        Task<IEnumerable<Mice>> GetAsync();
    }
}