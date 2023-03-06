using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class mig_guide_add : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Destinations_Guides_GuideId",
                table: "Destinations");

            migrationBuilder.DropIndex(
                name: "IX_Destinations_GuideId",
                table: "Destinations");

            migrationBuilder.DropColumn(
                name: "Guide",
                table: "Destinations");

            migrationBuilder.DropColumn(
                name: "GuideId",
                table: "Destinations");

            migrationBuilder.RenameColumn(
                name: "TwitterUrl",
                table: "Guides",
                newName: "LinkedinUrl");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "LinkedinUrl",
                table: "Guides",
                newName: "TwitterUrl");

            migrationBuilder.AddColumn<int>(
                name: "Guide",
                table: "Destinations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "GuideId",
                table: "Destinations",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Destinations_GuideId",
                table: "Destinations",
                column: "GuideId");

            migrationBuilder.AddForeignKey(
                name: "FK_Destinations_Guides_GuideId",
                table: "Destinations",
                column: "GuideId",
                principalTable: "Guides",
                principalColumn: "GuideId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
