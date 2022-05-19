using Project1.Models;

namespace Project1.Business
{
    public interface IMicrophoneService
    {
        Task AddMicrophone(Microphone microphone);

        Task<IEnumerable<Microphone>> GetAsync();
    }
}