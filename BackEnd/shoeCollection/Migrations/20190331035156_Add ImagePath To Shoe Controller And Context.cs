using Microsoft.EntityFrameworkCore.Migrations;

namespace shoeCollection.Migrations
{
    public partial class AddImagePathToShoeControllerAndContext : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImagePath",
                table: "Shoes",
                nullable: true);

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
                value: "https://dyet20dn14z30.cloudfront.net/actions/nmcImages/image/generateImage?height=720&width=&c=9&path=https://ffecom.s3.amazonaws.com/Nike/Footwear/AQ0070-003-C_PREM-2000.jpeg");

            migrationBuilder.UpdateData(
                table: "Shoes",
                keyColumn: "ShoeId",
                keyValue: 3,
                column: "ImagePath",
                value: "https://i.pinimg.com/originals/b7/a8/92/b7a89250834ee2e264c310a12b9493bf.jpg");

            migrationBuilder.UpdateData(
                table: "Shoes",
                keyColumn: "ShoeId",
                keyValue: 4,
                column: "ImagePath",
                value: "https://images.finishline.com/is/image/FinishLine/CN2127_BGM?$Main_gray$");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImagePath",
                table: "Shoes");
        }
    }
}
