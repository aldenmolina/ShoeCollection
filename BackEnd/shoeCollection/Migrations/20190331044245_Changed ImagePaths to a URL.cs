using Microsoft.EntityFrameworkCore.Migrations;

namespace shoeCollection.Migrations
{
    public partial class ChangedImagePathstoaURL : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Shoes",
                keyColumn: "ShoeId",
                keyValue: 1,
                column: "ImagePath",
                value: "https://stockx-360.imgix.net/Nike-Air-Force-1-Low-Off-White-Black-White/Images/Nike-Air-Force-1-Low-Off-White-Black-White/Lv2/img01.jpg?auto=format,compress&w=559&q=90&dpr=2&updated_at=1546755764");

            migrationBuilder.UpdateData(
                table: "Shoes",
                keyColumn: "ShoeId",
                keyValue: 2,
                column: "ImagePath",
                value: "https://images.finishline.com/is/image/FinishLine/AQ0067_011?$Main_gray$");

            migrationBuilder.UpdateData(
                table: "Shoes",
                keyColumn: "ShoeId",
                keyValue: 3,
                column: "ImagePath",
                value: "https://images.champssports.com/pi/39210100/zoom/puma-avid-evoknit-mens");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Shoes",
                keyColumn: "ShoeId",
                keyValue: 1,
                column: "ImagePath",
                value: "/Img/basketball-shoe-1.jpg");

            migrationBuilder.UpdateData(
                table: "Shoes",
                keyColumn: "ShoeId",
                keyValue: 2,
                column: "ImagePath",
                value: "/Img/running-shoe-1.jpg");

            migrationBuilder.UpdateData(
                table: "Shoes",
                keyColumn: "ShoeId",
                keyValue: 3,
                column: "ImagePath",
                value: "/Img/tennis-shoe-1.jpg");
        }
    }
}
