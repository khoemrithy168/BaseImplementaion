using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BOM.API.Migrations
{
    /// <inheritdoc />
    public partial class addinspectionformgrouprecord : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ef_boq_site_inspection_form_group_record",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FormGroupId = table.Column<int>(type: "int", nullable: false),
                    InspectRecordId = table.Column<int>(type: "int", nullable: false),
                    InspectionRate = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
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
                    table.PrimaryKey("PK_ef_boq_site_inspection_form_group_record", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ef_boq_site_inspection_form_group_record_ef_boq_inspectionformitemgroup_FormGroupId",
                        column: x => x.FormGroupId,
                        principalTable: "ef_boq_inspectionformitemgroup",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ef_boq_site_inspection_form_group_record_ef_boq_site_inspection_form_record_InspectRecordId",
                        column: x => x.InspectRecordId,
                        principalTable: "ef_boq_site_inspection_form_record",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ef_boq_site_inspection_form_group_record_FormGroupId",
                table: "ef_boq_site_inspection_form_group_record",
                column: "FormGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_ef_boq_site_inspection_form_group_record_InspectRecordId",
                table: "ef_boq_site_inspection_form_group_record",
                column: "InspectRecordId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ef_boq_site_inspection_form_group_record");
        }
    }
}
