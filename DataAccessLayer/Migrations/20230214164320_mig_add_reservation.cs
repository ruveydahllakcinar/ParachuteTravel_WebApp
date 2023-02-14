using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class mig_add_reservation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reservations_Reservations_ReservationId1",
                table: "Reservations");

            migrationBuilder.DropIndex(
                name: "IX_Reservations_ReservationId1",
                table: "Reservations");

            migrationBuilder.DropColumn(
                name: "ReservationId1",
                table: "Reservations");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ReservationId1",
                table: "Reservations",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_ReservationId1",
                table: "Reservations",
                column: "ReservationId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Reservations_Reservations_ReservationId1",
                table: "Reservations",
                column: "ReservationId1",
                principalTable: "Reservations",
                principalColumn: "ReservationId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
