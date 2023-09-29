using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TripsDb.Migrations
{
    /// <inheritdoc />
    public partial class changeorigindestinationlimits : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Origin",
                table: "Flight",
                type: "nvarchar(3)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)");

            migrationBuilder.AlterColumn<string>(
                name: "Destination",
                table: "Flight",
                type: "nvarchar(3)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Origin",
                table: "Flight",
                type: "nvarchar(100)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(3)");

            migrationBuilder.AlterColumn<string>(
                name: "Destination",
                table: "Flight",
                type: "nvarchar(100)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(3)");
        }
    }
}
