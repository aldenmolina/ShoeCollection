using Microsoft.EntityFrameworkCore.Migrations;

namespace shoeCollection.Migrations
{
    public partial class AddedMoreImages2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Shoes",
                keyColumn: "ShoeId",
                keyValue: 4,
                column: "ImagePath",
                value: "http://images.footlocker.com/pi/DV5242/zoom/DV5242.jpeg");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Shoes",
                keyColumn: "ShoeId",
                keyValue: 4,
                column: "ImagePath",
                value: "/Img/cross-trng-shoe-1.jpeg");
        }
    }
}
