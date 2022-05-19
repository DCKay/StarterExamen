using Project1.Models;

namespace Project1.Business
{
    public interface IScreenService
    {
        Task AddScreen(Screen screen);

        Task RemoveScreen(Screen screen);

        Task UpdateScreen(Screen screen);

        Task<IEnumerable<Screen>> GetAsync();
    }
}