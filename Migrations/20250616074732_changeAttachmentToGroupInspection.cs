using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BOM.API.Migrations
{
    /// <inheritdoc />
    public partial class changeAttachmentToGroupInspection : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ef_boq_inspection_form_item_check_record_attachment");

            migrationBuilder.CreateTable(
                name: "ef_boq_inspection_form_group_record_attachment",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FormGroupRecordId = table.Column<int>(type: "int", nullable: false),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InspectionFormItemCheckRecordId = table.Column<int>(type: "int", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    Remark = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    Version = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ef_boq_inspection_form_group_record_attachment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ef_boq_inspection_form_group_record_attachment_ef_boq_site_inspection_form_group_record_FormGroupRecordId",
                        column: x => x.FormGroupRecordId,
                        principalTable: "ef_boq_site_inspection_form_group_record",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ef_boq_inspection_form_group_record_attachment_ef_boq_site_inspection_form_item_check_record_InspectionFormItemCheckRecordId",
                        column: x => x.InspectionFormItemCheckRecordId,
                        principalTable: "ef_boq_site_inspection_form_item_check_record",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_ef_boq_inspection_form_group_record_attachment_FormGroupRecordId",
                table: "ef_boq_inspection_form_group_record_attachment",
                column: "FormGroupRecordId");

            migrationBuilder.CreateIndex(
                name: "IX_ef_boq_inspection_form_group_record_attachment_InspectionFormItemCheckRecordId",
                table: "ef_boq_inspection_form_group_record_attachment",
                column: "InspectionFormItemCheckRecordId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ef_boq_inspection_form_group_record_attachment");

            migrationBuilder.CreateTable(
                name: "ef_boq_inspection_form_item_check_record_attachment",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CheckedRecordID = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Remark = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Version = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ef_boq_inspection_form_item_check_record_attachment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ef_boq_inspection_form_item_check_record_attachment_ef_boq_site_inspection_form_item_check_record_CheckedRecordID",
                        column: x => x.CheckedRecordID,
                        principalTable: "ef_boq_site_inspection_form_item_check_record",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ef_boq_inspection_form_item_check_record_attachment_CheckedRecordID",
                table: "ef_boq_inspection_form_item_check_record_attachment",
                column: "CheckedRecordID");
        }
    }
}
