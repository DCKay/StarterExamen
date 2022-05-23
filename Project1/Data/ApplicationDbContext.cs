using Duende.IdentityServer.EntityFramework.Options;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Project1.Models;
using Project1.Models.Items;
using Project1.Models.Users;

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

        DummyComputer dComp = new();
        DummyHeadset dHead = new();
        DummyKeyboard dKeyB = new();
        DummyKeycap dKeyC = new();
        DummyKeySwitch dKeyS = new();
        DummyMice dMice = new();
        DummyMicrophone dMicro = new();
        DummyMousemat dMMat = new();
        DummyScreen dScreen = new();

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Computer>().HasData(
                dComp.DummyData()
                );
            builder.Entity<Headset>().HasData(
                dHead.DummyData()
                );
            builder.Entity<Keyboard>().HasData(
                dKeyB.DummyData()
                );
            builder.Entity<Keycap>().HasData(
                dKeyC.DummyData()
                );
            builder.Entity<KeySwitch>().HasData(
                dKeyS.DummyData()
                );
            builder.Entity<Mice>().HasData(
                dMice.DummyData()
                );
            builder.Entity<Microphone>().HasData(
                dMicro.DummyData()
                );
            builder.Entity<Mousemat>().HasData(
                dMMat.DummyData()
                );
            builder.Entity<Screen>().HasData(
                dScreen.DummyData()
                );

            base.OnModelCreating(builder);
        }

        private Computer[] DummyData()
        {
            throw new NotImplementedException();
        }
    }
}