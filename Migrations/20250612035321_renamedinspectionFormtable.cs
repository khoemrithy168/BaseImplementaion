using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BOM.API.Migrations
{
    /// <inheritdoc />
    public partial class renamedinspectionFormtable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ef_boq_inspectionformitemchecklist_ef_boq_inspectionformitemgroup_FormItemGroupId",
                table: "ef_boq_inspectionformitemchecklist");

            migrationBuilder.DropForeignKey(
                name: "FK_ef_boq_inspectionformitemgroup_ef_boq_inspectionform_FormId",
                table: "ef_boq_inspectionformitemgroup");

            migrationBuilder.DropForeignKey(
                name: "FK_ef_boq_site_inspection_form_group_record_ef_boq_inspectionformitemgroup_FormGroupId",
                table: "ef_boq_site_inspection_form_group_record");

            migrationBuilder.DropForeignKey(
                name: "FK_ef_boq_site_inspection_form_item_check_record_ef_boq_inspectionformitemchecklist_InspectionFormItemId",
                table: "ef_boq_site_inspection_form_item_check_record");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ef_boq_inspectionformitemgroup",
                table: "ef_boq_inspectionformitemgroup");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ef_boq_inspectionformitemchecklist",
                table: "ef_boq_inspectionformitemchecklist");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ef_boq_inspectionform",
                table: "ef_boq_inspectionform");

            migrationBuilder.RenameTable(
                name: "ef_boq_inspectionformitemgroup",
                newName: "ef_boq_site_inspection_form_item_group");

            migrationBuilder.RenameTable(
                name: "ef_boq_inspectionformitemchecklist",
                newName: "ef_boq_site_inspection_form_item_checklist");

            migrationBuilder.RenameTable(
                name: "ef_boq_inspectionform",
                newName: "ef_boq_site_inspection_form");

            migrationBuilder.RenameIndex(
                name: "IX_ef_boq_inspectionformitemgroup_FormId",
                table: "ef_boq_site_inspection_form_item_group",
                newName: "IX_ef_boq_site_inspection_form_item_group_FormId");

            migrationBuilder.RenameIndex(
                name: "IX_ef_boq_inspectionformitemchecklist_FormItemGroupId",
                table: "ef_boq_site_inspection_form_item_checklist",
                newName: "IX_ef_boq_site_inspection_form_item_checklist_FormItemGroupId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ef_boq_site_inspection_form_item_group",
                table: "ef_boq_site_inspection_form_item_group",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ef_boq_site_inspection_form_item_checklist",
                table: "ef_boq_site_inspection_form_item_checklist",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ef_boq_site_inspection_form",
                table: "ef_boq_site_inspection_form",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ef_boq_site_inspection_form_group_record_ef_boq_site_inspection_form_item_group_FormGroupId",
                table: "ef_boq_site_inspection_form_group_record",
                column: "FormGroupId",
                principalTable: "ef_boq_site_inspection_form_item_group",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ef_boq_site_inspection_form_item_check_record_ef_boq_site_inspection_form_item_checklist_InspectionFormItemId",
                table: "ef_boq_site_inspection_form_item_check_record",
                column: "InspectionFormItemId",
                principalTable: "ef_boq_site_inspection_form_item_checklist",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ef_boq_site_inspection_form_item_checklist_ef_boq_site_inspection_form_item_group_FormItemGroupId",
                table: "ef_boq_site_inspection_form_item_checklist",
                column: "FormItemGroupId",
                principalTable: "ef_boq_site_inspection_form_item_group",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ef_boq_site_inspection_form_item_group_ef_boq_site_inspection_form_FormId",
                table: "ef_boq_site_inspection_form_item_group",
                column: "FormId",
                principalTable: "ef_boq_site_inspection_form",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ef_boq_site_inspection_form_group_record_ef_boq_site_inspection_form_item_group_FormGroupId",
                table: "ef_boq_site_inspection_form_group_record");

            migrationBuilder.DropForeignKey(
                name: "FK_ef_boq_site_inspection_form_item_check_record_ef_boq_site_inspection_form_item_checklist_InspectionFormItemId",
                table: "ef_boq_site_inspection_form_item_check_record");

            migrationBuilder.DropForeignKey(
                name: "FK_ef_boq_site_inspection_form_item_checklist_ef_boq_site_inspection_form_item_group_FormItemGroupId",
                table: "ef_boq_site_inspection_form_item_checklist");

            migrationBuilder.DropForeignKey(
                name: "FK_ef_boq_site_inspection_form_item_group_ef_boq_site_inspection_form_FormId",
                table: "ef_boq_site_inspection_form_item_group");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ef_boq_site_inspection_form_item_group",
                table: "ef_boq_site_inspection_form_item_group");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ef_boq_site_inspection_form_item_checklist",
                table: "ef_boq_site_inspection_form_item_checklist");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ef_boq_site_inspection_form",
                table: "ef_boq_site_inspection_form");

            migrationBuilder.RenameTable(
                name: "ef_boq_site_inspection_form_item_group",
                newName: "ef_boq_inspectionformitemgroup");

            migrationBuilder.RenameTable(
                name: "ef_boq_site_inspection_form_item_checklist",
                newName: "ef_boq_inspectionformitemchecklist");

            migrationBuilder.RenameTable(
                name: "ef_boq_site_inspection_form",
                newName: "ef_boq_inspectionform");

            migrationBuilder.RenameIndex(
                name: "IX_ef_boq_site_inspection_form_item_group_FormId",
                table: "ef_boq_inspectionformitemgroup",
                newName: "IX_ef_boq_inspectionformitemgroup_FormId");

            migrationBuilder.RenameIndex(
                name: "IX_ef_boq_site_inspection_form_item_checklist_FormItemGroupId",
                table: "ef_boq_inspectionformitemchecklist",
                newName: "IX_ef_boq_inspectionformitemchecklist_FormItemGroupId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ef_boq_inspectionformitemgroup",
                table: "ef_boq_inspectionformitemgroup",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ef_boq_inspectionformitemchecklist",
                table: "ef_boq_inspectionformitemchecklist",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ef_boq_inspectionform",
                table: "ef_boq_inspectionform",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ef_boq_inspectionformitemchecklist_ef_boq_inspectionformitemgroup_FormItemGroupId",
                table: "ef_boq_inspectionformitemchecklist",
                column: "FormItemGroupId",
                principalTable: "ef_boq_inspectionformitemgroup",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ef_boq_inspectionformitemgroup_ef_boq_inspectionform_FormId",
                table: "ef_boq_inspectionformitemgroup",
                column: "FormId",
                principalTable: "ef_boq_inspectionform",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ef_boq_site_inspection_form_group_record_ef_boq_inspectionformitemgroup_FormGroupId",
                table: "ef_boq_site_inspection_form_group_record",
                column: "FormGroupId",
                principalTable: "ef_boq_inspectionformitemgroup",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ef_boq_site_inspection_form_item_check_record_ef_boq_inspectionformitemchecklist_InspectionFormItemId",
                table: "ef_boq_site_inspection_form_item_check_record",
                column: "InspectionFormItemId",
                principalTable: "ef_boq_inspectionformitemchecklist",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
