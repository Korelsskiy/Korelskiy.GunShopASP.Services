using Microsoft.EntityFrameworkCore.Migrations;

namespace Korelskiy.GunShopASP.Services.Migrations
{
    public partial class InitDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(nullable: false),
                    Producer = table.Column<string>(nullable: false),
                    Country = table.Column<string>(nullable: false),
                    Price = table.Column<decimal>(nullable: false),
                    PhotoPath = table.Column<string>(nullable: true),
                    Category = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
