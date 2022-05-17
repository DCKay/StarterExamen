using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project1.Data.Migrations
{
    public partial class AddComputers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Computers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Manufacturer = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CPU = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ram = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    SubTitle = table.Column<string>(type: "nvarchar(350)", maxLength: 350, nullable: false),
                    Rating = table.Column<int>(type: "int", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Computers", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Computers",
                columns: new[] { "Id", "CPU", "Image", "Manufacturer", "Ram", "Rating", "SubTitle", "Title" },
                values: new object[] { 1, "Intel I7", "https://www.lenovo.com/medias/lenovo-desktop-v530-amd-tower-hero.png?context=bWFzdGVyfHJvb3R8MjA0MjA3fGltYWdlL3BuZ3xoYTQvaGQxLzk5MTA5NjMwNzcxNTAucG5nfDQ0ZGRjZmY0MTQyM2RlNGFjMGFjMzU0MDgxMmYyN2U3OGMwZWM2NDVkMTQ1ZjY1ZmQ1N2Y2OGFmYzE0MGZjOWE", "Lenovo", "16GB DDR4", 4, "Pretty sweet TBH", "Lenovo Workstation" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Computers");
        }
    }
}
