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
            _dComp = new();
            _dHead = new();
            _dKeyB = new();
            _dKeyC = new();
            _dKeyS = new();
            _dMice = new();
            _dMicro = new();
            _dMMat = new();
            _dScreen = new();
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

        private DummyComputer _dComp;
        private DummyHeadset _dHead;
        private DummyKeyboard _dKeyB;
        private DummyKeycap _dKeyC;
        private DummyKeySwitch _dKeyS;
        private DummyMice _dMice;
        private DummyMicrophone _dMicro;
        private DummyMousemat _dMMat;
        private DummyScreen _dScreen;

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Computer>().HasData(
                _dComp.DummyData()
                );
            builder.Entity<Headset>().HasData(
                _dHead.DummyData()
                );
            builder.Entity<Keyboard>().HasData(
                _dKeyB.DummyData()
                );
            builder.Entity<Keycap>().HasData(
                _dKeyC.DummyData()
                );
            builder.Entity<KeySwitch>().HasData(
                _dKeyS.DummyData()
                );
            builder.Entity<Mice>().HasData(
                _dMice.DummyData()
                );
            builder.Entity<Microphone>().HasData(
                _dMicro.DummyData()
                );
            builder.Entity<Mousemat>().HasData(
                _dMMat.DummyData()
                );
            builder.Entity<Screen>().HasData(
                _dScreen.DummyData()
                );

            base.OnModelCreating(builder);
        }

        private Computer[] DummyData()
        {
            throw new NotImplementedException();
        }
    }
}