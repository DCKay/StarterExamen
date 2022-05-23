using Project1.Models;
using Project1.Models.Items;

namespace Project1.Business
{
    public interface IHeadsetService
    {
        Task AddHeadset(Headset headset);

        Task RemoveHeadset(Headset headset);

        Task UpdateHeadset(Headset headset);

        Task<IEnumerable<Headset>> GetAsync();
    }
}