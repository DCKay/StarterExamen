using Project1.Models.Items;

namespace Project1.Data
{
    public class DummyComputer : IDummyData
    {
        public void DummyData()
        {
             new Computer
                { Id = 2,
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