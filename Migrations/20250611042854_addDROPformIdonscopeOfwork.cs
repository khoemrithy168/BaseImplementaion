using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BOM.API.Migrations
{
    /// <inheritdoc />
    public partial class addDROPformIdonscopeOfwork : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FormInspectID",
                table: "ef_bom_scope_of_work");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "FormInspectID",
                table: "ef_bom_scope_of_work",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
