using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BOM.API.Migrations
{
    /// <inheritdoc />
    public partial class addformIdonWorkItemTask : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "FormInspectID",
                table: "ef_boq_work_item_task",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FormInspectID",
                table: "ef_boq_work_item_task");
        }
    }
}
