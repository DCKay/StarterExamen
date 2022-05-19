using Project1.Models;

namespace Project1.Business
{
    public interface IKeySwitchService
    {
        Task AddKeySwitch(KeySwitch keySwitch);

        Task<IEnumerable<KeySwitch>> GetAsync();
    }
}