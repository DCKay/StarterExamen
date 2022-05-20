using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project1.Data.Migrations
{
    public partial class AddItems : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Ram",
                table: "Computers",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Manufacturer",
                table: "Computers",
                type: "nvarchar(35)",
                maxLength: 35,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "CPU",
                table: "Computers",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<int>(
                name: "Colour",
                table: "Computers",
                type: "int",
                maxLength: 20,
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "GPU",
                table: "Computers",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Computers",
                type: "nvarchar(35)",
                maxLength: 35,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "OS",
                table: "Computers",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PSU",
                table: "Computers",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Storage",
                table: "Computers",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "WiFi",
                table: "Computers",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.CreateTable(
                name: "Headsets",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Manufacturer = table.Column<string>(type: "nvarchar(35)", maxLength: 35, nullable: false),
                    Colour = table.Column<int>(type: "int", maxLength: 20, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(35)", maxLength: 35, nullable: false),
                    HasMicro = table.Column<bool>(type: "bit", nullable: false),
                    IsWired = table.Column<bool>(type: "bit", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    SubTitle = table.Column<string>(type: "nvarchar(350)", maxLength: 350, nullable: false),
                    Rating = table.Column<int>(type: "int", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Headsets", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Keyboards",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Manufacturer = table.Column<string>(type: "nvarchar(35)", maxLength: 35, nullable: false),
                    Colour = table.Column<int>(type: "int", maxLength: 20, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(35)", maxLength: 35, nullable: false),
                    HasRGB = table.Column<bool>(type: "bit", nullable: false),
                    Layout = table.Column<int>(type: "int", nullable: false),
                    Switches = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Wireless = table.Column<bool>(type: "bit", nullable: false),
                    Size = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    SubTitle = table.Column<string>(type: "nvarchar(350)", maxLength: 350, nullable: false),
                    Rating = table.Column<int>(type: "int", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Keyboards", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Keycaps",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Manufacturer = table.Column<string>(type: "nvarchar(35)", maxLength: 35, nullable: false),
                    Colour = table.Column<int>(type: "int", maxLength: 20, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(35)", maxLength: 35, nullable: false),
                    Title = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    SubTitle = table.Column<string>(type: "nvarchar(350)", maxLength: 350, nullable: false),
                    Rating = table.Column<int>(type: "int", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Keycaps", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "KeySwitches",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Manufacturer = table.Column<string>(type: "nvarchar(35)", maxLength: 35, nullable: false),
                    Colour = table.Column<int>(type: "int", maxLength: 20, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(35)", maxLength: 35, nullable: false),
                    Title = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    SubTitle = table.Column<string>(type: "nvarchar(350)", maxLength: 350, nullable: false),
                    Rating = table.Column<int>(type: "int", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KeySwitches", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ManyMice",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Manufacturer = table.Column<string>(type: "nvarchar(35)", maxLength: 35, nullable: false),
                    Colour = table.Column<int>(type: "int", maxLength: 20, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(35)", maxLength: 35, nullable: false),
                    Wireless = table.Column<bool>(type: "bit", nullable: false),
                    DPI = table.Column<int>(type: "int", nullable: false),
                    Handy = table.Column<int>(type: "int", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    SubTitle = table.Column<string>(type: "nvarchar(350)", maxLength: 350, nullable: false),
                    Rating = table.Column<int>(type: "int", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ManyMice", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Microphones",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Manufacturer = table.Column<string>(type: "nvarchar(35)", maxLength: 35, nullable: false),
                    Colour = table.Column<int>(type: "int", maxLength: 20, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(35)", maxLength: 35, nullable: false),
                    Title = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    SubTitle = table.Column<string>(type: "nvarchar(350)", maxLength: 350, nullable: false),
                    Rating = table.Column<int>(type: "int", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Microphones", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Mousemats",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Manufacturer = table.Column<string>(type: "nvarchar(35)", maxLength: 35, nullable: false),
                    Colour = table.Column<int>(type: "int", maxLength: 20, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(35)", maxLength: 35, nullable: false),
                    Size = table.Column<int>(type: "int", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    SubTitle = table.Column<string>(type: "nvarchar(350)", maxLength: 350, nullable: false),
                    Rating = table.Column<int>(type: "int", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mousemats", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Screens",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Manufacturer = table.Column<string>(type: "nvarchar(35)", maxLength: 35, nullable: false),
                    Colour = table.Column<int>(type: "int", maxLength: 20, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(35)", maxLength: 35, nullable: false),
                    Resolution = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FPS = table.Column<int>(type: "int", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    SubTitle = table.Column<string>(type: "nvarchar(350)", maxLength: 350, nullable: false),
                    Rating = table.Column<int>(type: "int", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Screens", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Computers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "GPU", "Name", "OS", "PSU", "Storage", "WiFi" },
                values: new object[] { "MSI GeForce RTX 3090 GAMING X TRIO 24GB", "Computer", "Windows 11", "ASUS ROG STRIX 850W Gold PSU", "500GB NVME SSD", true });

            migrationBuilder.InsertData(
                table: "Headsets",
                columns: new[] { "Id", "Colour", "HasMicro", "Image", "IsWired", "Manufacturer", "Name", "Rating", "SubTitle", "Title" },
                values: new object[] { 1, 0, false, "https://external-content.duckduckgo.com/iu/?u=https%3A%2F%2Ftse2.mm.bing.net%2Fth%3Fid%3DOIP.0B_DLoshSJW0je8gzD0IXQHaHa%26pid%3DApi&f=1", false, "Bose", "Bose 700", 5, "Pretty sweet TBH", "Bose 700 Noise Cancelling Headphones Headset" });

            migrationBuilder.InsertData(
                table: "KeySwitches",
                columns: new[] { "Id", "Colour", "Image", "Manufacturer", "Name", "Rating", "SubTitle", "Title" },
                values: new object[] { 1, 1, "", "Corsair", "Corsair keyswitches", 4, "Pretty sweet TBH", "Corsair keyswitches" });

            migrationBuilder.InsertData(
                table: "Keyboards",
                columns: new[] { "Id", "Colour", "HasRGB", "Image", "Layout", "Manufacturer", "Name", "Rating", "Size", "SubTitle", "Switches", "Title", "Wireless" },
                values: new object[] { 1, 0, true, "https://external-content.duckduckgo.com/iu/?u=https%3A%2F%2Ftse4.mm.bing.net%2Fth%3Fid%3DOIP.I5_GWlQKTGWqzyrwvl9J0AHaFj%26pid%3DApi&f=1", 4, "Corsair", "K60 Pro", 5, "Full", "Pretty sweet TBH", "Corsair keyswitches", "Corsair K60 Pro", false });

            migrationBuilder.InsertData(
                table: "Keycaps",
                columns: new[] { "Id", "Colour", "Image", "Manufacturer", "Name", "Rating", "SubTitle", "Title" },
                values: new object[] { 1, 0, "https://external-content.duckduckgo.com/iu/?u=https%3A%2F%2Ftse4.mm.bing.net%2Fth%3Fid%3DOIP.NUmtgJ7KfXu1BmPN75CbDwHaFj%26pid%3DApi&f=1", "Corsair", "Gaming PBT - Double-shot Keycaps", 3, "Pretty sweet TBH", "Corsair Gaming PBT - Double-shot Keycaps" });

            migrationBuilder.InsertData(
                table: "ManyMice",
                columns: new[] { "Id", "Colour", "DPI", "Handy", "Image", "Manufacturer", "Name", "Rating", "SubTitle", "Title", "Wireless" },
                values: new object[] { 1, 0, 25000, 0, "https://external-content.duckduckgo.com/iu/?u=https%3A%2F%2Ftse4.mm.bing.net%2Fth%3Fid%3DOIP.q8hqRYN1rrE3NasGTholJwHaGX%26pid%3DApi&f=1", "Logitech", "G502 HERO", 4, "Pretty sweet TBH", "Logitech G502 HERO", true });

            migrationBuilder.InsertData(
                table: "Microphones",
                columns: new[] { "Id", "Colour", "Image", "Manufacturer", "Name", "Rating", "SubTitle", "Title" },
                values: new object[] { 1, 0, "https://external-content.duckduckgo.com/iu/?u=https%3A%2F%2Fwww.ple.com.au%2Fimagelibrary%2Finventoryitemimages%2F82117-619939-full.jpg&f=1&nofb=1", "Yeti", "Blue Microphones Yeti", 3, "Pretty sweet TBH", "Blue Microphones Yeti" });

            migrationBuilder.InsertData(
                table: "Mousemats",
                columns: new[] { "Id", "Colour", "Image", "Manufacturer", "Name", "Rating", "Size", "SubTitle", "Title" },
                values: new object[] { 1, 0, "https://external-content.duckduckgo.com/iu/?u=https%3A%2F%2Fpisces.bbystatic.com%2Fimage2%2FBestBuy_US%2Fimages%2Fproducts%2F6428%2F6428301cv12d.jpg&f=1&nofb=1", "Corsair", "MM300 Pro", 3, 5, "Pretty sweet TBH", "Corsair MM300 Pro Premium Spill-Proof Cloth Gaming Extended Muismat" });

            migrationBuilder.InsertData(
                table: "Screens",
                columns: new[] { "Id", "Colour", "FPS", "Image", "Manufacturer", "Name", "Rating", "Resolution", "SubTitle", "Title" },
                values: new object[] { 1, 0, 144, "https://external-content.duckduckgo.com/iu/?u=https%3A%2F%2Fgts.jo%2Fimage%2Fcache%2Fcatalog%2Fproducts%2Fmonitor%2FMSI%2Fproduct_3_20190819052103_5d5a31bf61d59_1200x1200-1200x1200.png&f=1&nofb=1", "MSI", "Optix G24C4", 4, "1440p", "Pretty sweet TBH", "MSI Optix G24C4" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Headsets");

            migrationBuilder.DropTable(
                name: "Keyboards");

            migrationBuilder.DropTable(
                name: "Keycaps");

            migrationBuilder.DropTable(
                name: "KeySwitches");

            migrationBuilder.DropTable(
                name: "ManyMice");

            migrationBuilder.DropTable(
                name: "Microphones");

            migrationBuilder.DropTable(
                name: "Mousemats");

            migrationBuilder.DropTable(
                name: "Screens");

            migrationBuilder.DropColumn(
                name: "Colour",
                table: "Computers");

            migrationBuilder.DropColumn(
                name: "GPU",
                table: "Computers");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Computers");

            migrationBuilder.DropColumn(
                name: "OS",
                table: "Computers");

            migrationBuilder.DropColumn(
                name: "PSU",
                table: "Computers");

            migrationBuilder.DropColumn(
                name: "Storage",
                table: "Computers");

            migrationBuilder.DropColumn(
                name: "WiFi",
                table: "Computers");

            migrationBuilder.AlterColumn<string>(
                name: "Ram",
                table: "Computers",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20);

            migrationBuilder.AlterColumn<string>(
                name: "Manufacturer",
                table: "Computers",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(35)",
                oldMaxLength: 35);

            migrationBuilder.AlterColumn<string>(
                name: "CPU",
                table: "Computers",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20);
        }
    }
}
