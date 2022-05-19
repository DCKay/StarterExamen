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
                new Computer {  Id = 1,
                                Title = "Lenovo Workstation",
                                SubTitle = "Pretty sweet TBH",
                                Rating = 4,
                                Image = "https://www.lenovo.com/medias/lenovo-desktop-v530-amd-tower-hero.png?context=bWFzdGVyfHJvb3R8MjA0MjA3fGltYWdlL3BuZ3xoYTQvaGQxLzk5MTA5NjMwNzcxNTAucG5nfDQ0ZGRjZmY0MTQyM2RlNGFjMGFjMzU0MDgxMmYyN2U3OGMwZWM2NDVkMTQ1ZjY1ZmQ1N2Y2OGFmYzE0MGZjOWE",
                                CPU = "Intel I7",
                                Manufacturer = "Lenovo",
                                Ram = "16GB DDR4"   },

                







                );
            builder.Entity<Headset>().HasData(
                new Headset {   Id = 1,
                                Title = "Bose 700 Noise Cancelling Headphones Headset",
                                SubTitle = "Pretty sweet TBH",
                                Rating = 5,
                                Image = "",
                            }
                );
            builder.Entity<Keyboard>().HasData(
                new Keyboard {  Id = 1,
                                Title = "Corsair K60 Pro",
                                SubTitle = "Pretty sweet TBH",
                                Rating = 5,
                                Image = "",
                             }
                );
            builder.Entity<Keycap>().HasData(
                new Keycap {    Id = 1,
                                Title = "Corsair Gaming PBT - Double-shot Keycaps",
                                SubTitle = "Pretty sweet TBH",
                                Rating = 3,
                                Image = "",
                           }
                );
            builder.Entity<KeySwitch>().HasData(
                new KeySwitch {    Id = 1,
                                   Title = "Corsair keyswitches",
                                   SubTitle = "Pretty sweet TBH",
                                   Rating = 4,
                                   Image = "",
                              }
                );
            builder.Entity<Mice>().HasData(
                new Mice {  Id = 1,
                            Title = "Logitech G502 HERO",
                            SubTitle = "Pretty sweet TBH",
                            Rating = 4,
                            Image = "",
                         }
                );
            builder.Entity<Microphone>().HasData(
                new Microphone {    Id = 1,
                                    Title = "Blue Microphones Yeti ",
                                    SubTitle = "Pretty sweet TBH",
                                    Rating = 3,
                                    Image = "",
                               }
                );
            builder.Entity<Mousemat>().HasData(
                new Mousemat {  Id = 1,
                                Title = "Corsair MM300 Pro Premium Spill-Proof Cloth Gaming Extended Muismat",
                                SubTitle = "Pretty sweet TBH",
                                Rating = 3,
                                Image = "",
                             }
                );
            builder.Entity<Screen>().HasData(
                new Screen {    Id = 1,
                                Title = "MSI Optix G24C4",
                                SubTitle = "Pretty sweet TBH",
                                Rating = 4,
                                Image = "",
                           }
                );




            base.OnModelCreating(builder);
        }
    }
}