using Project1.Models.Items;

namespace Project1.Data
{
    public class DummyMice : IDummyData
    {
        public void DummyData()
        {
            new Mice
                { Id = 1,
                Title = "Logitech G502 HERO",
                SubTitle = "Pretty sweet TBH",
                Rating = 4,
                Image = "https://external-content.duckduckgo.com/iu/?u=https%3A%2F%2Ftse4.mm.bing.net%2Fth%3Fid%3DOIP.q8hqRYN1rrE3NasGTholJwHaGX%26pid%3DApi&f=1",
                Manufacturer = "Logitech",
                Colour = Colour.Black,
                Name = "G502 HERO",
                Wireless = true,
                DPI = 25000,
                Handy = Handedness.Right };
        }
    }
}