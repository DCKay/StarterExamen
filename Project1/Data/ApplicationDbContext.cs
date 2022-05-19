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
                new Computer { Id = 1, CPU = "Intel I7", Image = "https://www.lenovo.com/medias/lenovo-desktop-v530-amd-tower-hero.png?context=bWFzdGVyfHJvb3R8MjA0MjA3fGltYWdlL3BuZ3xoYTQvaGQxLzk5MTA5NjMwNzcxNTAucG5nfDQ0ZGRjZmY0MTQyM2RlNGFjMGFjMzU0MDgxMmYyN2U3OGMwZWM2NDVkMTQ1ZjY1ZmQ1N2Y2OGFmYzE0MGZjOWE", Manufacturer = "Lenovo", Ram = "16GB DDR4", Rating = 4, Title = "Lenovo Workstation", SubTitle = "Pretty sweet TBH" });

            base.OnModelCreating(builder);
        }
    }
}