using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TripsDb.Migrations
{
    /// <inheritdoc />
    public partial class FirstMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Journey",
                columns: table => new
                {
                    JourneyId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Origin = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    Destination = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(19,4)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Journey", x => x.JourneyId);
                });

            migrationBuilder.CreateTable(
                name: "Transport",
                columns: table => new
                {
                    TransportId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FlightCarrier = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    FlightNumber = table.Column<string>(type: "nvarchar(100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transport", x => x.TransportId);
                });

            migrationBuilder.CreateTable(
                name: "Flight",
                columns: table => new
                {
                    FlightId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Origin = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    Destination = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(19,4)", nullable: false),
                    TransportId = table.Column<int>(type: "int", nullable: false),
                    JourneyId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Flight", x => x.FlightId);
                    table.ForeignKey(
                        name: "FK_Flight_Journey_JourneyId",
                        column: x => x.JourneyId,
                        principalTable: "Journey",
                        principalColumn: "JourneyId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Flight_Transport_TransportId",
                        column: x => x.TransportId,
                        principalTable: "Transport",
                        principalColumn: "TransportId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Flight_JourneyId",
                table: "Flight",
                column: "JourneyId");

            migrationBuilder.CreateIndex(
                name: "IX_Flight_TransportId",
                table: "Flight",
                column: "TransportId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Flight");

            migrationBuilder.DropTable(
                name: "Journey");

            migrationBuilder.DropTable(
                name: "Transport");
        }
    }
}
