using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BOM.API.Migrations
{
    /// <inheritdoc />
    public partial class addinspectionformrecord : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ef_boq_site_inspection_form_record",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FormId = table.Column<int>(type: "int", nullable: false),
                    InspectionRateId = table.Column<int>(type: "int", nullable: false),
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
                    table.PrimaryKey("PK_ef_boq_site_inspection_form_record", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ef_boq_site_inspection_form_record_ef_boq_site_progress_inspection_rate_InspectionRateId",
                        column: x => x.InspectionRateId,
                        principalTable: "ef_boq_site_progress_inspection_rate",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ef_boq_site_inspection_form_record_InspectionRateId",
                table: "ef_boq_site_inspection_form_record",
                column: "InspectionRateId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ef_boq_site_inspection_form_record");
        }
    }
}
