using Duende.IdentityServer.EntityFramework.Options;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Project1.Models;

namespace Project1.Data
{
    public class ApplicationDbContext : ApiAuthorizationDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions options, IOptions<OperationalStoreOptions> operationalStoreOptions)
            : base(options, operationalStoreOptions)
        {
        }

        public DbSet<Computer> Computers { get; set; }
        public DbSet<Headset> Headsets { get; set; }
        public DbSet<Keyboard> Keyboards { get; set; }
        public DbSet<Keycap> Keycaps { get; set; }
        public DbSet<KeySwitch> KeySwitches { get; set; }
        public DbSet<Mice> ManyMice { get; set; }
        public DbSet<Microphone> Microphones { get; set; }
        public DbSet<Mousemat> Mousemats { get; set; }
        public DbSet<Screen> Screens { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Computer>().HasData(
                new Computer
                {
                    Id = 1,
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
                    WiFi = true
                }

                );
            builder.Entity<Headset>().HasData(
                new Headset
                {
                    Id = 1,
                    Title = "Bose 700 Noise Cancelling Headphones Headset",
                    SubTitle = "Pretty sweet TBH",
                    Rating = 5,
                    Image = "https://external-content.duckduckgo.com/iu/?u=https%3A%2F%2Ftse2.mm.bing.net%2Fth%3Fid%3DOIP.0B_DLoshSJW0je8gzD0IXQHaHa%26pid%3DApi&f=1",
                    Manufacturer = "Bose",
                    Colour = Colour.Black,
                    Name = "Bose 700",
                    HasMicro = false,
                    IsWired = false
                }
                );
            builder.Entity<Keyboard>().HasData(
                new Keyboard
                {
                    Id = 1,
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
                    Size = "Full"
                }
                );
            builder.Entity<Keycap>().HasData(
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
                }
                );
            builder.Entity<KeySwitch>().HasData(
                new KeySwitch
                {
                    Id = 1,
                    Title = "Corsair keyswitches",
                    SubTitle = "Pretty sweet TBH",
                    Rating = 4,
                    Image = "",
                    Manufacturer = "Corsair",
                    Colour = Colour.White,
                    Name = "Corsair keyswitches"
                }
                );
            builder.Entity<Mice>().HasData(
                new Mice
                {
                    Id = 1,
                    Title = "Logitech G502 HERO",
                    SubTitle = "Pretty sweet TBH",
                    Rating = 4,
                    Image = "https://external-content.duckduckgo.com/iu/?u=https%3A%2F%2Ftse4.mm.bing.net%2Fth%3Fid%3DOIP.q8hqRYN1rrE3NasGTholJwHaGX%26pid%3DApi&f=1",
                    Manufacturer = "Logitech",
                    Colour = Colour.Black,
                    Name = "G502 HERO",
                    Wireless = true,
                    DPI = 25000,
                    Handy = Handedness.Right
                }
                );
            builder.Entity<Microphone>().HasData(
                new Microphone
                {
                    Id = 1,
                    Title = "Blue Microphones Yeti",
                    SubTitle = "Pretty sweet TBH",
                    Rating = 3,
                    Image = "https://external-content.duckduckgo.com/iu/?u=https%3A%2F%2Fwww.ple.com.au%2Fimagelibrary%2Finventoryitemimages%2F82117-619939-full.jpg&f=1&nofb=1",
                    Manufacturer = "Yeti",
                    Colour = Colour.Black,
                    Name = "Blue Microphones Yeti",
                }
                );
            builder.Entity<Mousemat>().HasData(
                new Mousemat
                {
                    Id = 1,
                    Title = "Corsair MM300 Pro Premium Spill-Proof Cloth Gaming Extended Muismat",
                    SubTitle = "Pretty sweet TBH",
                    Rating = 3,
                    Image = "https://external-content.duckduckgo.com/iu/?u=https%3A%2F%2Fpisces.bbystatic.com%2Fimage2%2FBestBuy_US%2Fimages%2Fproducts%2F6428%2F6428301cv12d.jpg&f=1&nofb=1",
                    Manufacturer = "Corsair",
                    Colour = Colour.Black,
                    Name = "MM300 Pro",
                    Size = Size.XL
                }
                );
            builder.Entity<Screen>().HasData(
                new Screen
                {
                    Id = 1,
                    Title = "MSI Optix G24C4",
                    SubTitle = "Pretty sweet TBH",
                    Rating = 4,
                    Image = "https://external-content.duckduckgo.com/iu/?u=https%3A%2F%2Fgts.jo%2Fimage%2Fcache%2Fcatalog%2Fproducts%2Fmonitor%2FMSI%2Fproduct_3_20190819052103_5d5a31bf61d59_1200x1200-1200x1200.png&f=1&nofb=1",
                    Manufacturer = "MSI",
                    Colour = Colour.Black,
                    Name = "Optix G24C4",
                    Resolution = "1440p",
                    FPS = 144
                }
                );

            base.OnModelCreating(builder);
        }
    }
}