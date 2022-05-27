using Project1.Models.Items;

namespace Project1.Data
{
    public class DummyComputer : IDummyData
    {
        //public DummyComputer()
        //{
                
        //}

        //public int Id { get; private set; }
        //public string Title { get; private set; }
        //public string SubTitle { get; private set; }
        //public int Rating { get; private set; }
        //public string Image { get; private set; }
        //public string Manufacturer { get; private set; }
        //public string CPU { get; private set; }
        //public string Ram { get; private set; }
        //public string Storage { get; private set; }
        //public string Name { get; private set; }
        //public Colour Colour { get; private set; }
        //public string OS { get; private set; }
        //public string GPU { get; private set; }
        //public string PSU { get; private set; }
        //public bool WiFi { get; private set; }

        public void DummyData()
        {
            new Computer
                { Id = 1,
                Title = "Lenovo Workstation",
                SubTitle = "Pretty sweet TBH",
                Rating = 4,
                Image = "https://www.lenovo.com/medias/lenovo-desktop-v530-amd-tower-hero.png?context=bWFzdGVyfHJvb3R8MjA0MjA3fGltYWdlL3BuZ3xoYTQvaGQxLzk5MTA5NjMwNzcxNTAucG5nfDQ0ZGRjZmY0MTQyM2RlNGFjMGFjMzU0MDgxMmYyN2U3OGMwZWM2NDVkMTQ1ZjY1ZmQ1N2Y2OGFmYzE0MGZjOWE",
                Manufacturer = "Lenovo",
                CPU = "Intel I7",
                Ram = "16GB DDR4",
                Storage = "500GB NVME SSD",
                Name = "Computer",
                Colour = Colour.Black,
                OS = "Windows 11",
                GPU = "MSI GeForce RTX 3090 GAMING X TRIO 24GB",
                PSU = "ASUS ROG STRIX 850W Gold PSU",
                WiFi = true};
        }
    }
}