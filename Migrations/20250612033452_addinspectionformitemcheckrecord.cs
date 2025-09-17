using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BOM.API.Migrations
{
    /// <inheritdoc />
    public partial class addinspectionformitemcheckrecord : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ef_boq_site_inspection_form_item_check_record",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InspectionFormItemId = table.Column<int>(type: "int", nullable: false),
                    FormGroupRecordId = table.Column<int>(type: "int", nullable: false),
                    InspectionFormGroupRecordId = table.Column<int>(type: "int", nullable: true),
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
                    table.PrimaryKey("PK_ef_boq_site_inspection_form_item_check_record", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ef_boq_site_inspection_form_item_check_record_ef_boq_inspectionformitemchecklist_InspectionFormItemId",
                        column: x => x.InspectionFormItemId,
                        principalTable: "ef_boq_inspectionformitemchecklist",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ef_boq_site_inspection_form_item_check_record_ef_boq_site_inspection_form_group_record_InspectionFormGroupRecordId",
                        column: x => x.InspectionFormGroupRecordId,
                        principalTable: "ef_boq_site_inspection_form_group_record",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_ef_boq_site_inspection_form_item_check_record_InspectionFormGroupRecordId",
                table: "ef_boq_site_inspection_form_item_check_record",
                column: "InspectionFormGroupRecordId");

            migrationBuilder.CreateIndex(
                name: "IX_ef_boq_site_inspection_form_item_check_record_InspectionFormItemId",
                table: "ef_boq_site_inspection_form_item_check_record",
                column: "InspectionFormItemId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ef_boq_site_inspection_form_item_check_record");
        }
    }
}
