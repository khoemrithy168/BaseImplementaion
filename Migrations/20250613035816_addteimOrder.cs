using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BOM.API.Migrations
{
    /// <inheritdoc />
    public partial class addteimOrder : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "DescriptionKH",
                table: "ef_boq_site_inspection_form_record",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ItemOrder",
                table: "ef_boq_site_inspection_form_item_checklist",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "DescriptionKH",
                table: "ef_boq_site_inspection_form_item_check_record",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DescriptionKH",
                table: "ef_boq_site_inspection_form_group_record",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DescriptionKH",
                table: "ef_boq_site_inspection_form_record");

            migrationBuilder.DropColumn(
                name: "ItemOrder",
                table: "ef_boq_site_inspection_form_item_checklist");

            migrationBuilder.DropColumn(
                name: "DescriptionKH",
                table: "ef_boq_site_inspection_form_item_check_record");

            migrationBuilder.DropColumn(
                name: "DescriptionKH",
                table: "ef_boq_site_inspection_form_group_record");
        }
    }
}
