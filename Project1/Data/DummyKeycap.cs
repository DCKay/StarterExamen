using Project1.Models.Items;

namespace Project1.Data
{
    public class DummyKeycap : IDummyData
    {
        public void DummyData()
        {
             new Keycap
             {
                 Id = 1,
                 Title = "Corsair Gaming PBT - Double-shot Keycaps",
                 SubTitle = "Pretty sweet TBH",
                 Rating = 3,
                 Image = "https://external-content.duckduckgo.com/iu/?u=https%3A%2F%2Ftse4.mm.bing.net%2Fth%3Fid%3DOIP.NUmtgJ7KfXu1BmPN75CbDwHaFj%26pid%3DApi&f=1",
                 Manufacturer = "Corsair",
                 Colour = Colour.Black,
                 Name = "Gaming PBT - Double-shot Keycaps"
             };
        }
    }
}