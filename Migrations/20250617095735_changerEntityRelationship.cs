using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BOM.API.Migrations
{
    /// <inheritdoc />
    public partial class changerEntityRelationship : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ef_boq_inspection_form_group_record_attachment_ef_boq_site_inspection_form_group_record_FormGroupRecordId",
                table: "ef_boq_inspection_form_group_record_attachment");

            migrationBuilder.DropForeignKey(
                name: "FK_ef_boq_site_inspection_form_group_record_ef_boq_site_inspection_form_item_group_FormGroupId",
                table: "ef_boq_site_inspection_form_group_record");

            migrationBuilder.DropForeignKey(
                name: "FK_ef_boq_site_inspection_form_group_record_ef_boq_site_inspection_form_record_InspectRecordId",
                table: "ef_boq_site_inspection_form_group_record");

            migrationBuilder.DropForeignKey(
                name: "FK_ef_boq_site_inspection_form_item_check_record_ef_boq_site_inspection_form_item_checklist_InspectionFormItemId",
                table: "ef_boq_site_inspection_form_item_check_record");

            migrationBuilder.DropIndex(
                name: "IX_ef_boq_site_inspection_form_item_check_record_InspectionFormItemId",
                table: "ef_boq_site_inspection_form_item_check_record");

            migrationBuilder.DropIndex(
                name: "IX_ef_boq_site_inspection_form_group_record_FormGroupId",
                table: "ef_boq_site_inspection_form_group_record");

            migrationBuilder.DropIndex(
                name: "IX_ef_boq_site_inspection_form_group_record_InspectRecordId",
                table: "ef_boq_site_inspection_form_group_record");

            migrationBuilder.DropIndex(
                name: "IX_ef_boq_inspection_form_group_record_attachment_FormGroupRecordId",
                table: "ef_boq_inspection_form_group_record_attachment");

            migrationBuilder.AddColumn<int>(
                name: "InspectionFormItemGroupId",
                table: "ef_boq_site_inspection_form_group_record",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "InspectionFormRecordId",
                table: "ef_boq_site_inspection_form_group_record",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ef_boq_site_inspection_form_group_record_InspectionFormItemGroupId",
                table: "ef_boq_site_inspection_form_group_record",
                column: "InspectionFormItemGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_ef_boq_site_inspection_form_group_record_InspectionFormRecordId",
                table: "ef_boq_site_inspection_form_group_record",
                column: "InspectionFormRecordId");

            migrationBuilder.AddForeignKey(
                name: "FK_ef_boq_site_inspection_form_group_record_ef_boq_site_inspection_form_item_group_InspectionFormItemGroupId",
                table: "ef_boq_site_inspection_form_group_record",
                column: "InspectionFormItemGroupId",
                principalTable: "ef_boq_site_inspection_form_item_group",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ef_boq_site_inspection_form_group_record_ef_boq_site_inspection_form_record_InspectionFormRecordId",
                table: "ef_boq_site_inspection_form_group_record",
                column: "InspectionFormRecordId",
                principalTable: "ef_boq_site_inspection_form_record",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ef_boq_site_inspection_form_group_record_ef_boq_site_inspection_form_item_group_InspectionFormItemGroupId",
                table: "ef_boq_site_inspection_form_group_record");

            migrationBuilder.DropForeignKey(
                name: "FK_ef_boq_site_inspection_form_group_record_ef_boq_site_inspection_form_record_InspectionFormRecordId",
                table: "ef_boq_site_inspection_form_group_record");

            migrationBuilder.DropIndex(
                name: "IX_ef_boq_site_inspection_form_group_record_InspectionFormItemGroupId",
                table: "ef_boq_site_inspection_form_group_record");

            migrationBuilder.DropIndex(
                name: "IX_ef_boq_site_inspection_form_group_record_InspectionFormRecordId",
                table: "ef_boq_site_inspection_form_group_record");

            migrationBuilder.DropColumn(
                name: "InspectionFormItemGroupId",
                table: "ef_boq_site_inspection_form_group_record");

            migrationBuilder.DropColumn(
                name: "InspectionFormRecordId",
                table: "ef_boq_site_inspection_form_group_record");

            migrationBuilder.CreateIndex(
                name: "IX_ef_boq_site_inspection_form_item_check_record_InspectionFormItemId",
                table: "ef_boq_site_inspection_form_item_check_record",
                column: "InspectionFormItemId");

            migrationBuilder.CreateIndex(
                name: "IX_ef_boq_site_inspection_form_group_record_FormGroupId",
                table: "ef_boq_site_inspection_form_group_record",
                column: "FormGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_ef_boq_site_inspection_form_group_record_InspectRecordId",
                table: "ef_boq_site_inspection_form_group_record",
                column: "InspectRecordId");

            migrationBuilder.CreateIndex(
                name: "IX_ef_boq_inspection_form_group_record_attachment_FormGroupRecordId",
                table: "ef_boq_inspection_form_group_record_attachment",
                column: "FormGroupRecordId");

            migrationBuilder.AddForeignKey(
                name: "FK_ef_boq_inspection_form_group_record_attachment_ef_boq_site_inspection_form_group_record_FormGroupRecordId",
                table: "ef_boq_inspection_form_group_record_attachment",
                column: "FormGroupRecordId",
                principalTable: "ef_boq_site_inspection_form_group_record",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ef_boq_site_inspection_form_group_record_ef_boq_site_inspection_form_item_group_FormGroupId",
                table: "ef_boq_site_inspection_form_group_record",
                column: "FormGroupId",
                principalTable: "ef_boq_site_inspection_form_item_group",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ef_boq_site_inspection_form_group_record_ef_boq_site_inspection_form_record_InspectRecordId",
                table: "ef_boq_site_inspection_form_group_record",
                column: "InspectRecordId",
                principalTable: "ef_boq_site_inspection_form_record",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ef_boq_site_inspection_form_item_check_record_ef_boq_site_inspection_form_item_checklist_InspectionFormItemId",
                table: "ef_boq_site_inspection_form_item_check_record",
                column: "InspectionFormItemId",
                principalTable: "ef_boq_site_inspection_form_item_checklist",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
