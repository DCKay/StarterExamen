using Project1.Models.Items;

namespace Project1.Data
{
    public class DummyKeySwitch : IDummyData
    {
        public void DummyData()
        {
           new KeySwitch
                { Id = 1,
                Title = "Corsair keyswitches",
                SubTitle = "Pretty sweet TBH",
                Rating = 4, Image = "",
                Manufacturer = "Corsair",
                Colour = Colour.White,
                Name = "Corsair keyswitches" };
        }
    }
}