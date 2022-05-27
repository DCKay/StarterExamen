using Project1.Models.Items;

namespace Project1.Data
{
    public class DummyMicrophone : IDummyData
    {
        public void DummyData()
        {
            new Microphone
                { Id = 1,
                Title = "Blue Microphones Yeti",
                SubTitle = "Pretty sweet TBH",
                Rating = 3,
                Image = "https://external-content.duckduckgo.com/iu/?u=https%3A%2F%2Fwww.ple.com.au%2Fimagelibrary%2Finventoryitemimages%2F82117-619939-full.jpg&f=1&nofb=1",
                Manufacturer = "Yeti",
                Colour = Colour.Black,
                Name = "Blue Microphones Yeti" };
        }
    }
}