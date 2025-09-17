using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BOM.API.Migrations
{
    /// <inheritdoc />
    public partial class droppercentage : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "InspectionPercentage",
                table: "ef_boq_inspectionformitemgroup");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "InspectionPercentage",
                table: "ef_boq_inspectionformitemgroup",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);
        }
    }
}
