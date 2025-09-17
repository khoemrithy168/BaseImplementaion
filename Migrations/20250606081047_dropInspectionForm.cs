using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BOM.API.Migrations
{
    /// <inheritdoc />
    public partial class dropInspectionForm : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ef_bom_block_ef_projects_ProjectId",
                table: "ef_bom_block");

            migrationBuilder.DropForeignKey(
                name: "FK_ef_bom_scope_of_work_ef_bom_type_BomTypeID",
                table: "ef_bom_scope_of_work");

            migrationBuilder.DropForeignKey(
                name: "FK_ef_boq_unit_items_ef_boqs_BoqId",
                table: "ef_boq_unit_items");

            migrationBuilder.DropForeignKey(
                name: "FK_ef_boq_Units_ef_projects_ProjectId",
                table: "ef_boq_Units");

            migrationBuilder.DropForeignKey(
                name: "FK_ef_boqs_ef_projects_ProjectId",
                table: "ef_boqs");

            migrationBuilder.AddForeignKey(
                name: "FK_ef_bom_block_ef_projects_ProjectId",
                table: "ef_bom_block",
                column: "ProjectId",
                principalTable: "ef_projects",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ef_bom_scope_of_work_ef_bom_type_BomTypeID",
                table: "ef_bom_scope_of_work",
                column: "BomTypeID",
                principalTable: "ef_bom_type",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ef_boq_unit_items_ef_boqs_BoqId",
                table: "ef_boq_unit_items",
                column: "BoqId",
                principalTable: "ef_boqs",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ef_boq_Units_ef_projects_ProjectId",
                table: "ef_boq_Units",
                column: "ProjectId",
                principalTable: "ef_projects",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ef_boqs_ef_projects_ProjectId",
                table: "ef_boqs",
                column: "ProjectId",
                principalTable: "ef_projects",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ef_bom_block_ef_projects_ProjectId",
                table: "ef_bom_block");

            migrationBuilder.DropForeignKey(
                name: "FK_ef_bom_scope_of_work_ef_bom_type_BomTypeID",
                table: "ef_bom_scope_of_work");

            migrationBuilder.DropForeignKey(
                name: "FK_ef_boq_unit_items_ef_boqs_BoqId",
                table: "ef_boq_unit_items");

            migrationBuilder.DropForeignKey(
                name: "FK_ef_boq_Units_ef_projects_ProjectId",
                table: "ef_boq_Units");

            migrationBuilder.DropForeignKey(
                name: "FK_ef_boqs_ef_projects_ProjectId",
                table: "ef_boqs");

            migrationBuilder.AddForeignKey(
                name: "FK_ef_bom_block_ef_projects_ProjectId",
                table: "ef_bom_block",
                column: "ProjectId",
                principalTable: "ef_projects",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ef_bom_scope_of_work_ef_bom_type_BomTypeID",
                table: "ef_bom_scope_of_work",
                column: "BomTypeID",
                principalTable: "ef_bom_type",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ef_boq_unit_items_ef_boqs_BoqId",
                table: "ef_boq_unit_items",
                column: "BoqId",
                principalTable: "ef_boqs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ef_boq_Units_ef_projects_ProjectId",
                table: "ef_boq_Units",
                column: "ProjectId",
                principalTable: "ef_projects",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ef_boqs_ef_projects_ProjectId",
                table: "ef_boqs",
                column: "ProjectId",
                principalTable: "ef_projects",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
