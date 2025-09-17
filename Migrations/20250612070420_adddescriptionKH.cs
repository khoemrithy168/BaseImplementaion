using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BOM.API.Migrations
{
    /// <inheritdoc />
    public partial class adddescriptionKH : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "DescriptionKH",
                table: "ef_boq_site_inspection_form_item_group",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DescriptionKH",
                table: "ef_boq_site_inspection_form_item_checklist",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DescriptionKH",
                table: "ef_boq_site_inspection_form",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DescriptionKH",
                table: "ef_boq_site_inspection_form_item_group");

            migrationBuilder.DropColumn(
                name: "DescriptionKH",
                table: "ef_boq_site_inspection_form_item_checklist");

            migrationBuilder.DropColumn(
                name: "DescriptionKH",
                table: "ef_boq_site_inspection_form");
        }
    }
}
