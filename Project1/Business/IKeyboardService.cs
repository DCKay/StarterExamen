using Project1.Models;

namespace Project1.Business
{
    public interface IKeyboardService
    {
        Task AddKeyboard(Keyboard keyboard);

        Task RemoveKeyboard(Keyboard keyboard);

        Task<IEnumerable<Keyboard>> GetAsync();
    }
}