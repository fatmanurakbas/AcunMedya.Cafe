using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AcunMedya.Cafe.Migrations
{
    /// <inheritdoc />
    public partial class mig4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DashboardViewModel",
                columns: table => new
                {
                    ProductCount = table.Column<int>(type: "int", nullable: false),
                    SubscriberCount = table.Column<int>(type: "int", nullable: false),
                    ReferenceCount = table.Column<int>(type: "int", nullable: false),
                    MostPreferredCategory = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CoffeeNames = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CoffeePreferences = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PositiveComments = table.Column<int>(type: "int", nullable: false),
                    NeutralComments = table.Column<int>(type: "int", nullable: false),
                    NegativeComments = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DashboardViewModel");
        }
    }
}
