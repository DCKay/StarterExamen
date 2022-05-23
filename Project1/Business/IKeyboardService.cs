using Project1.Models;
using Project1.Models.Items;

namespace Project1.Business
{
    public interface IKeyboardService
    {
        Task AddKeyboard(Keyboard keyboard);

        Task RemoveKeyboard(Keyboard keyboard);

        Task UpdateKeyboard(Keyboard keyboard);

        Task<IEnumerable<Keyboard>> GetAsync();
    }
}