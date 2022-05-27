using Project1.Models.Items;

namespace Project1.Data
{
    public class DummyKeyboard : IDummyData
    {
        public void DummyData()
        {
             new Keyboard
                { Id = 1,
                Title = "Corsair K60 Pro",
                SubTitle = "Pretty sweet TBH",
                Rating = 5,
                Image = "https://external-content.duckduckgo.com/iu/?u=https%3A%2F%2Ftse4.mm.bing.net%2Fth%3Fid%3DOIP.I5_GWlQKTGWqzyrwvl9J0AHaFj%26pid%3DApi&f=1",
                Manufacturer = "Corsair",
                Colour = Colour.Black,
                Name = "K60 Pro",
                HasRGB = true,
                Layout = Layout.AZERTY,
                Switches = "Corsair keyswitches",
                Wireless = false,
                Size = "Full" };
        }
    }
}