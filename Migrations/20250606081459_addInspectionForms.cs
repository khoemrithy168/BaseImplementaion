using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BOM.API.Migrations
{
    /// <inheritdoc />
    public partial class addInspectionForms : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ef_boq_inspectionformitemchecklistc_ef_boq_inspectionformitemgroup_FormItemGroupId",
                table: "ef_boq_inspectionformitemchecklistc");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ef_boq_inspectionformitemchecklistc",
                table: "ef_boq_inspectionformitemchecklistc");

            migrationBuilder.RenameTable(
                name: "ef_boq_inspectionformitemchecklistc",
                newName: "ef_boq_inspectionformitemchecklist");

            migrationBuilder.RenameIndex(
                name: "IX_ef_boq_inspectionformitemchecklistc_FormItemGroupId",
                table: "ef_boq_inspectionformitemchecklist",
                newName: "IX_ef_boq_inspectionformitemchecklist_FormItemGroupId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ef_boq_inspectionformitemchecklist",
                table: "ef_boq_inspectionformitemchecklist",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ef_boq_inspectionformitemchecklist_ef_boq_inspectionformitemgroup_FormItemGroupId",
                table: "ef_boq_inspectionformitemchecklist",
                column: "FormItemGroupId",
                principalTable: "ef_boq_inspectionformitemgroup",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ef_boq_inspectionformitemchecklist_ef_boq_inspectionformitemgroup_FormItemGroupId",
                table: "ef_boq_inspectionformitemchecklist");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ef_boq_inspectionformitemchecklist",
                table: "ef_boq_inspectionformitemchecklist");

            migrationBuilder.RenameTable(
                name: "ef_boq_inspectionformitemchecklist",
                newName: "ef_boq_inspectionformitemchecklistc");

            migrationBuilder.RenameIndex(
                name: "IX_ef_boq_inspectionformitemchecklist_FormItemGroupId",
                table: "ef_boq_inspectionformitemchecklistc",
                newName: "IX_ef_boq_inspectionformitemchecklistc_FormItemGroupId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ef_boq_inspectionformitemchecklistc",
                table: "ef_boq_inspectionformitemchecklistc",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ef_boq_inspectionformitemchecklistc_ef_boq_inspectionformitemgroup_FormItemGroupId",
                table: "ef_boq_inspectionformitemchecklistc",
                column: "FormItemGroupId",
                principalTable: "ef_boq_inspectionformitemgroup",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
