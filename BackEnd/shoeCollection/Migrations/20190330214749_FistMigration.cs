using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace shoeCollection.Migrations
{
    public partial class FistMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ShoeTypes",
                columns: table => new
                {
                    ShoeTypeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ShoeTypeName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShoeTypes", x => x.ShoeTypeId);
                });

            migrationBuilder.InsertData(
                table: "ShoeTypes",
                columns: new[] { "ShoeTypeId", "ShoeTypeName" },
                values: new object[,]
                {
                    { 1, "Basketball" },
                    { 2, "Casual" },
                    { 3, "Cross-trainer" },
                    { 4, "Running" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ShoeTypes");
        }
    }
}
