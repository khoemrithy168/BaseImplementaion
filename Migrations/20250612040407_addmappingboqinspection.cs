using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BOM.API.Migrations
{
    /// <inheritdoc />
    public partial class addmappingboqinspection : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ef_boq_site_inspection_form_record_ef_boq_site_progress_inspection_rate_InspectionRateId",
                table: "ef_boq_site_inspection_form_record");

            migrationBuilder.RenameColumn(
                name: "InspectionRateId",
                table: "ef_boq_site_inspection_form_record",
                newName: "BoqSiteInspectionID");

            migrationBuilder.RenameIndex(
                name: "IX_ef_boq_site_inspection_form_record_InspectionRateId",
                table: "ef_boq_site_inspection_form_record",
                newName: "IX_ef_boq_site_inspection_form_record_BoqSiteInspectionID");

            migrationBuilder.AddForeignKey(
                name: "FK_ef_boq_site_inspection_form_record_ef_boq_site_inspection_BoqSiteInspectionID",
                table: "ef_boq_site_inspection_form_record",
                column: "BoqSiteInspectionID",
                principalTable: "ef_boq_site_inspection",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ef_boq_site_inspection_form_record_ef_boq_site_inspection_BoqSiteInspectionID",
                table: "ef_boq_site_inspection_form_record");

            migrationBuilder.RenameColumn(
                name: "BoqSiteInspectionID",
                table: "ef_boq_site_inspection_form_record",
                newName: "InspectionRateId");

            migrationBuilder.RenameIndex(
                name: "IX_ef_boq_site_inspection_form_record_BoqSiteInspectionID",
                table: "ef_boq_site_inspection_form_record",
                newName: "IX_ef_boq_site_inspection_form_record_InspectionRateId");

            migrationBuilder.AddForeignKey(
                name: "FK_ef_boq_site_inspection_form_record_ef_boq_site_progress_inspection_rate_InspectionRateId",
                table: "ef_boq_site_inspection_form_record",
                column: "InspectionRateId",
                principalTable: "ef_boq_site_progress_inspection_rate",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
