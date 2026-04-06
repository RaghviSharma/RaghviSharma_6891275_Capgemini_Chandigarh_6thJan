using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SmartHealthcare.API.Migrations
{
    /// <inheritdoc />
    public partial class AddBillEntity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Bills",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AppointmentId = table.Column<int>(type: "int", nullable: false),
                    ConsultationFee = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    MedicineCharges = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PaymentStatus = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bills", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Bills_Appointments_AppointmentId",
                        column: x => x.AppointmentId,
                        principalTable: "Appointments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "PasswordHash" },
                values: new object[] { new DateTime(2026, 4, 4, 5, 53, 30, 325, DateTimeKind.Utc).AddTicks(2050), "$2a$11$XdKeIZfgH10F79I6uvXw7OuU2L2nWjTDWfPicXY2zrfDVGwTEEJ5u" });

            migrationBuilder.CreateIndex(
                name: "IX_Bills_AppointmentId",
                table: "Bills",
                column: "AppointmentId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bills");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "PasswordHash" },
                values: new object[] { new DateTime(2026, 4, 4, 5, 23, 30, 892, DateTimeKind.Utc).AddTicks(3428), "$2a$11$2r3A3OZnvCAPL70xLkGlkOVVyrVKTbiVNHjN7PymDupIbihvTHFMK" });
        }
    }
}
