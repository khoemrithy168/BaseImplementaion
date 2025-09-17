using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BOM.API.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ef_bom_active_status",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
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
                    table.PrimaryKey("PK_ef_bom_active_status", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ef_bom_active_tracking",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BomId = table.Column<int>(type: "int", nullable: false),
                    BomCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RevCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BomTypeId = table.Column<int>(type: "int", nullable: false),
                    BomTypeName = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    BuildTypeId = table.Column<int>(type: "int", nullable: false),
                    BuildingTypeName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UnitTypeId = table.Column<int>(type: "int", nullable: false),
                    UnitTypeName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ScopeWorkId = table.Column<int>(type: "int", nullable: false),
                    ScopeWorkName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UnitNameId = table.Column<int>(type: "int", nullable: false),
                    UnitName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsReleased = table.Column<int>(type: "int", maxLength: 2, nullable: false),
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
                    table.PrimaryKey("PK_ef_bom_active_tracking", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ef_Bom_Balance",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BomId = table.Column<int>(type: "int", nullable: false),
                    BomReleasedId = table.Column<int>(type: "int", nullable: false),
                    BomRevCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BomQty = table.Column<decimal>(type: "decimal(18,10)", nullable: false),
                    ItemId = table.Column<int>(type: "int", nullable: false),
                    ItemCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    QtyConsume = table.Column<decimal>(type: "decimal(18,10)", nullable: false),
                    Balance = table.Column<decimal>(type: "decimal(18,10)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ef_Bom_Balance", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ef_bom_block_status_tracking",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
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
                    table.PrimaryKey("PK_ef_bom_block_status_tracking", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ef_bom_block_update_tracking",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BomBlockId = table.Column<int>(type: "int", nullable: false),
                    BlockCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedByName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedByName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Rev = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProjectId = table.Column<int>(type: "int", nullable: false),
                    PhaseId = table.Column<int>(type: "int", nullable: false),
                    MainBlockId = table.Column<int>(type: "int", nullable: false),
                    SubBlockId = table.Column<int>(type: "int", nullable: false),
                    BomTypeId = table.Column<int>(type: "int", nullable: false),
                    ScopeWorkId = table.Column<int>(type: "int", nullable: false),
                    ClassicficationId = table.Column<int>(type: "int", nullable: false),
                    isReleased = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    isReleasedId = table.Column<int>(type: "int", nullable: false),
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
                    table.PrimaryKey("PK_ef_bom_block_update_tracking", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ef_bom_building_type",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KhmerDescription = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    ProjectId = table.Column<int>(type: "int", nullable: false),
                    ProjectName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProjectCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhaseId = table.Column<int>(type: "int", nullable: false),
                    PhaseName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhaseCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                    table.PrimaryKey("PK_ef_bom_building_type", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ef_bom_classification",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClassificationCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    DescriptionKH = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
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
                    table.PrimaryKey("PK_ef_bom_classification", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ef_bom_status",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    isActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ef_bom_status", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ef_bom_type",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    DescriptionKH = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
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
                    table.PrimaryKey("PK_ef_bom_type", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ef_bom_typeofbom",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
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
                    table.PrimaryKey("PK_ef_bom_typeofbom", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ef_bom_updated_tracking",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BomId = table.Column<int>(type: "int", nullable: false),
                    BomCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RevCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    BomTypeId = table.Column<int>(type: "int", nullable: false),
                    BomTypeName = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    BuildTypeId = table.Column<int>(type: "int", nullable: false),
                    BuildingTypeName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UnitTypeId = table.Column<int>(type: "int", nullable: false),
                    UnitTypeName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ScopeWorkId = table.Column<int>(type: "int", nullable: false),
                    ScopeWorkName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UnitNameId = table.Column<int>(type: "int", nullable: false),
                    UnitName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    isReleased = table.Column<int>(type: "int", maxLength: 2, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ef_bom_updated_tracking", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ef_bomblock_active_tracking",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BomBlockId = table.Column<int>(type: "int", nullable: false),
                    BlockCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedByName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedByName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Rev = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProjectId = table.Column<int>(type: "int", nullable: false),
                    PhaseId = table.Column<int>(type: "int", nullable: false),
                    MainBlockId = table.Column<int>(type: "int", nullable: false),
                    SubBlockId = table.Column<int>(type: "int", nullable: false),
                    BomTypeId = table.Column<int>(type: "int", nullable: false),
                    ScopeWorkId = table.Column<int>(type: "int", nullable: false),
                    ClassicficationId = table.Column<int>(type: "int", nullable: false),
                    isReleased = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    isReleasedId = table.Column<int>(type: "int", nullable: false),
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
                    table.PrimaryKey("PK_ef_bomblock_active_tracking", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ef_boq_building_floor",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
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
                    table.PrimaryKey("PK_ef_boq_building_floor", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ef_boq_site_inspection",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProjectID = table.Column<int>(type: "int", nullable: false),
                    ProjectName = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    PhaseID = table.Column<int>(type: "int", nullable: false),
                    PhaseName = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    MainBlockID = table.Column<int>(type: "int", nullable: false),
                    MainBlockName = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    ClassificationID = table.Column<int>(type: "int", nullable: false),
                    ClassificationName = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    SubBlockID = table.Column<int>(type: "int", nullable: false),
                    SubBlockName = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    UnitNameID = table.Column<int>(type: "int", nullable: false),
                    UnitName = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    UnitNumberID = table.Column<int>(type: "int", nullable: false),
                    UnitNumber = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    BomTypeId = table.Column<int>(type: "int", nullable: false),
                    BomTypeName = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    ScopeWorkID = table.Column<int>(type: "int", nullable: false),
                    ScopeWorkName = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    BoqUnitId = table.Column<int>(type: "int", nullable: false),
                    BoqUnitItemId = table.Column<int>(type: "int", nullable: false),
                    BoqRevCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    Remark = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    Version = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EmployeeID = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    DocumentNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    DocumentDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DocumentStatus = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ef_boq_site_inspection", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ef_boq_site_inspection_vo_history",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BoqInspectionId = table.Column<int>(type: "int", nullable: false),
                    EmployeeID = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    DocumentNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    DocumentDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DocumentStatus = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: true),
                    ProjectID = table.Column<int>(type: "int", nullable: false),
                    ProjectName = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    PhaseID = table.Column<int>(type: "int", nullable: false),
                    PhaseName = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    MainBlockID = table.Column<int>(type: "int", nullable: false),
                    MainBlockName = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    ClassificationID = table.Column<int>(type: "int", nullable: false),
                    ClassificationName = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    SubBlockID = table.Column<int>(type: "int", nullable: false),
                    SubBlockName = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    UnitNameID = table.Column<int>(type: "int", nullable: false),
                    UnitName = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    UnitNumberID = table.Column<int>(type: "int", nullable: false),
                    UnitNumber = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    BomTypeId = table.Column<int>(type: "int", nullable: false),
                    BomTypeName = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    ScopeWorkID = table.Column<int>(type: "int", nullable: false),
                    ScopeWorkName = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    BoqUnitId = table.Column<int>(type: "int", nullable: false),
                    BoqUnitItemId = table.Column<int>(type: "int", nullable: false),
                    BoqRevCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                    table.PrimaryKey("PK_ef_boq_site_inspection_vo_history", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ef_boq_unit_vo_history",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    boqUnitId = table.Column<int>(type: "int", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Rev = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProjectId = table.Column<int>(type: "int", nullable: false),
                    ProjectName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhaseId = table.Column<int>(type: "int", nullable: false),
                    PhaseName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MainBlockId = table.Column<int>(type: "int", nullable: false),
                    MainBlockName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SubBlockId = table.Column<int>(type: "int", nullable: false),
                    SubBlockName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClassicficationId = table.Column<int>(type: "int", nullable: false),
                    ClassicficationName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UnitNumberId = table.Column<int>(type: "int", nullable: false),
                    UnitNumberName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UnitNameId = table.Column<int>(type: "int", nullable: false),
                    UnitName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsReleased = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Action = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VoDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    VoBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                    table.PrimaryKey("PK_ef_boq_unit_vo_history", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ef_PR_Requests",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    ProjectId = table.Column<int>(type: "int", nullable: false),
                    ProjectName = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    PhaseId = table.Column<int>(type: "int", nullable: false),
                    PhaseName = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    MainBlockId = table.Column<int>(type: "int", nullable: false),
                    MainBlockName = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    ClassificationId = table.Column<int>(type: "int", nullable: false),
                    ClassificationName = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    SubBlockId = table.Column<int>(type: "int", nullable: false),
                    SubBlockName = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    BomTypeId = table.Column<int>(type: "int", nullable: false),
                    BomTypeName = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    ScopeOfWorkId = table.Column<int>(type: "int", nullable: false),
                    ScopeOfWorkName = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    TotalPrAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    StatusId = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StatusApprovalId = table.Column<int>(type: "int", nullable: false),
                    StatusApproval = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ef_PR_Requests", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ef_projects",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProjectCode = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    ProjectName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ProjectNameKhmer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Company = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AddressKhmer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Logo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedByName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedByName = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                    table.PrimaryKey("PK_ef_projects", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ef_bom_detail_active_tracking",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Bom_Detail_Id = table.Column<int>(type: "int", nullable: false),
                    BomId = table.Column<int>(type: "int", nullable: false),
                    ItemCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TypeCode = table.Column<int>(type: "int", nullable: false),
                    BomUnit = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Quantity_REV = table.Column<decimal>(type: "decimal(18,10)", nullable: false),
                    Quantity = table.Column<decimal>(type: "decimal(18,10)", nullable: false),
                    Wastage = table.Column<decimal>(type: "decimal(18,10)", nullable: false),
                    UnitPrice = table.Column<decimal>(type: "decimal(18,10)", nullable: false),
                    BomActiveId = table.Column<int>(type: "int", nullable: false),
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
                    table.PrimaryKey("PK_ef_bom_detail_active_tracking", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ef_bom_detail_active_tracking_ef_bom_active_tracking_BomActiveId",
                        column: x => x.BomActiveId,
                        principalTable: "ef_bom_active_tracking",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ef_bom_block_detail_update_tracking",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RefBomBlockId = table.Column<int>(type: "int", nullable: false),
                    BomBlockDetailId = table.Column<int>(type: "int", nullable: false),
                    BomBlockId = table.Column<int>(type: "int", nullable: false),
                    BomId = table.Column<int>(type: "int", nullable: false),
                    BomRevCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BomReleasedId = table.Column<int>(type: "int", nullable: false),
                    UnitNumberId = table.Column<int>(type: "int", nullable: false),
                    CreatedByName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedByName = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                    table.PrimaryKey("PK_ef_bom_block_detail_update_tracking", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ef_bom_block_detail_update_tracking_ef_bom_block_update_tracking_RefBomBlockId",
                        column: x => x.RefBomBlockId,
                        principalTable: "ef_bom_block_update_tracking",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ef_unit_type",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DescriptionKH = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UnitTypeCode = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: true),
                    DisplayUnitTypeCode = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: true),
                    UnitTypeName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    UnitTypeLoc = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    TypeGrouped = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    BuildingTypeID = table.Column<int>(type: "int", nullable: true),
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
                    table.PrimaryKey("PK_ef_unit_type", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ef_unit_type_ef_bom_building_type_BuildingTypeID",
                        column: x => x.BuildingTypeID,
                        principalTable: "ef_bom_building_type",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ef_bom_sub_block",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClassificationID = table.Column<int>(type: "int", nullable: false),
                    SubBlockCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    DescriptionKH = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
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
                    table.PrimaryKey("PK_ef_bom_sub_block", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ef_bom_sub_block_ef_bom_classification_ClassificationID",
                        column: x => x.ClassificationID,
                        principalTable: "ef_bom_classification",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ef_bom_scope_of_work",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    DescriptionKH = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    BomTypeID = table.Column<int>(type: "int", nullable: false),
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
                    table.PrimaryKey("PK_ef_bom_scope_of_work", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ef_bom_scope_of_work_ef_bom_type_BomTypeID",
                        column: x => x.BomTypeID,
                        principalTable: "ef_bom_type",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ef_boms",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BomCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RevCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    BomTypeId = table.Column<int>(type: "int", nullable: false),
                    BomTypeName = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    BuildTypeId = table.Column<int>(type: "int", nullable: false),
                    BuildingTypeName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UnitTypeId = table.Column<int>(type: "int", nullable: false),
                    UnitTypeName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ScopeWorkId = table.Column<int>(type: "int", nullable: false),
                    ScopeWorkName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UnitNameId = table.Column<int>(type: "int", nullable: false),
                    UnitName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    isReleased = table.Column<int>(type: "int", maxLength: 2, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ef_boms", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ef_boms_ef_bom_type_BomTypeId",
                        column: x => x.BomTypeId,
                        principalTable: "ef_bom_type",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ef_bom_detail_update_tracking",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Bom_Detail_Id = table.Column<int>(type: "int", nullable: false),
                    BomId = table.Column<int>(type: "int", nullable: false),
                    ItemCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TypeCode = table.Column<int>(type: "int", nullable: false),
                    BomUnit = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Quantity_REV = table.Column<decimal>(type: "decimal(18,10)", nullable: false),
                    Quantity = table.Column<decimal>(type: "decimal(18,10)", nullable: false),
                    Wastage = table.Column<decimal>(type: "decimal(18,10)", nullable: false),
                    UnitPrice = table.Column<decimal>(type: "decimal(18,10)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    BomRevId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ef_bom_detail_update_tracking", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ef_bom_detail_update_tracking_ef_bom_updated_tracking_BomRevId",
                        column: x => x.BomRevId,
                        principalTable: "ef_bom_updated_tracking",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ef_bomblock_details_active_tracking",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RefBomBlockActiveId = table.Column<int>(type: "int", nullable: false),
                    BomBlockDetailId = table.Column<int>(type: "int", nullable: false),
                    BomBlockId = table.Column<int>(type: "int", nullable: false),
                    BomId = table.Column<int>(type: "int", nullable: false),
                    BomReleasedId = table.Column<int>(type: "int", nullable: false),
                    UnitNumberId = table.Column<int>(type: "int", nullable: false),
                    CreatedByName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedByName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RefBomBlockId = table.Column<int>(type: "int", nullable: true),
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
                    table.PrimaryKey("PK_ef_bomblock_details_active_tracking", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ef_bomblock_details_active_tracking_ef_bomblock_active_tracking_RefBomBlockId",
                        column: x => x.RefBomBlockId,
                        principalTable: "ef_bomblock_active_tracking",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ef_boq_site_inspection_floor",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BoqId = table.Column<int>(type: "int", nullable: false),
                    BoqItemsDetailID = table.Column<int>(type: "int", nullable: false),
                    UoM = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WorkTaskName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ItemId = table.Column<int>(type: "int", nullable: false),
                    UnitPrice = table.Column<double>(type: "float", nullable: false),
                    Weight = table.Column<double>(type: "float", nullable: false),
                    Quantity = table.Column<double>(type: "float", nullable: false),
                    QuantityREV = table.Column<double>(type: "float", nullable: false),
                    BuildingFloorID = table.Column<int>(type: "int", nullable: false),
                    SiteInspectPercentageID = table.Column<int>(type: "int", nullable: false),
                    SiteInspectPercentage = table.Column<int>(type: "int", nullable: false),
                    BuildingFloor = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    BoqSiteInspectionID = table.Column<int>(type: "int", nullable: false),
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
                    table.PrimaryKey("PK_ef_boq_site_inspection_floor", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ef_boq_site_inspection_floor_ef_boq_site_inspection_BoqSiteInspectionID",
                        column: x => x.BoqSiteInspectionID,
                        principalTable: "ef_boq_site_inspection",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ef_boq_site_inspection_floor_vo_history",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BoqInspectionFloorId = table.Column<int>(type: "int", nullable: false),
                    BoqId = table.Column<int>(type: "int", nullable: false),
                    BoqItemsDetailID = table.Column<int>(type: "int", nullable: false),
                    UoM = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WorkTaskName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ItemId = table.Column<int>(type: "int", nullable: false),
                    UnitPrice = table.Column<double>(type: "float", nullable: false),
                    Weight = table.Column<double>(type: "float", nullable: false),
                    Quantity = table.Column<double>(type: "float", nullable: false),
                    QuantityREV = table.Column<double>(type: "float", nullable: false),
                    BuildingFloorID = table.Column<int>(type: "int", nullable: false),
                    SiteInspectPercentageID = table.Column<int>(type: "int", nullable: false),
                    SiteInspectPercentage = table.Column<int>(type: "int", nullable: false),
                    BuildingFloor = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    BoqSiteInspectionID = table.Column<int>(type: "int", nullable: false),
                    BoqInspectionId = table.Column<int>(type: "int", nullable: true),
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
                    table.PrimaryKey("PK_ef_boq_site_inspection_floor_vo_history", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ef_boq_site_inspection_floor_vo_history_ef_boq_site_inspection_vo_history_BoqInspectionId",
                        column: x => x.BoqInspectionId,
                        principalTable: "ef_boq_site_inspection_vo_history",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ef_boq_unit_item_vo_history",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BoqUnitVoId = table.Column<int>(type: "int", nullable: false),
                    boqUnitItemId = table.Column<int>(type: "int", nullable: false),
                    BoqUnitId = table.Column<int>(type: "int", nullable: false),
                    BoqId = table.Column<int>(type: "int", nullable: false),
                    BoqName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BomTypeId = table.Column<int>(type: "int", nullable: false),
                    BomTypeName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ScopeWorkId = table.Column<int>(type: "int", nullable: false),
                    ScopeWorkName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Action = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VoDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    VoBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                    table.PrimaryKey("PK_ef_boq_unit_item_vo_history", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ef_boq_unit_item_vo_history_ef_boq_unit_vo_history_BoqUnitVoId",
                        column: x => x.BoqUnitVoId,
                        principalTable: "ef_boq_unit_vo_history",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ef_PR_bom_Items_Requests",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RefPrReqId = table.Column<int>(type: "int", nullable: false),
                    BomId = table.Column<int>(type: "int", nullable: false),
                    BomReleasedId = table.Column<int>(type: "int", nullable: false),
                    BomRevCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BomBlockId = table.Column<int>(type: "int", nullable: false),
                    BomBlockRevCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UnitNumberId = table.Column<int>(type: "int", nullable: false),
                    UnitNumberName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ItemQty = table.Column<decimal>(type: "decimal(18,10)", nullable: false),
                    BomQty = table.Column<decimal>(type: "decimal(18,10)", nullable: false),
                    BomBalance = table.Column<decimal>(type: "decimal(18,10)", nullable: false),
                    RequestQty = table.Column<decimal>(type: "decimal(18,10)", nullable: false),
                    Wastage = table.Column<decimal>(type: "decimal(18,10)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ef_PR_bom_Items_Requests", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ef_PR_bom_Items_Requests_ef_PR_Requests_RefPrReqId",
                        column: x => x.RefPrReqId,
                        principalTable: "ef_PR_Requests",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ef_PR_Requests_Bom",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RefPrId = table.Column<int>(type: "int", nullable: false),
                    BomId = table.Column<int>(type: "int", nullable: false),
                    BomRevCode = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    BomBlockId = table.Column<int>(type: "int", nullable: false),
                    BomBlockRevCode = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ef_PR_Requests_Bom", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ef_PR_Requests_Bom_ef_PR_Requests_RefPrId",
                        column: x => x.RefPrId,
                        principalTable: "ef_PR_Requests",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ef_PR_Requests_Units",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RefPrId = table.Column<int>(type: "int", nullable: false),
                    UnitNumberId = table.Column<int>(type: "int", nullable: false),
                    UnitNumberName = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    UnitTypeId = table.Column<int>(type: "int", nullable: false),
                    UnitTypeName = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    BuildingTypeId = table.Column<int>(type: "int", nullable: false),
                    BuildingTypeName = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    RedsUnitCode = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    SapUnitCode = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    IsCheck = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ef_PR_Requests_Units", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ef_PR_Requests_Units_ef_PR_Requests_RefPrId",
                        column: x => x.RefPrId,
                        principalTable: "ef_PR_Requests",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ef_project_phases",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PhaseCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PhaseName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PhaseNameKhmer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhaseNameLoc = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ConstructionType = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Logo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ProjectId = table.Column<int>(type: "int", nullable: false),
                    CreatedByName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedByName = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                    table.PrimaryKey("PK_ef_project_phases", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ef_project_phases_ef_projects_ProjectId",
                        column: x => x.ProjectId,
                        principalTable: "ef_projects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ef_unit_name",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DescriptionKH = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UnitCode = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: true),
                    UnitTypeID = table.Column<int>(type: "int", nullable: false),
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
                    table.PrimaryKey("PK_ef_unit_name", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ef_unit_name_ef_unit_type_UnitTypeID",
                        column: x => x.UnitTypeID,
                        principalTable: "ef_unit_type",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ef_boq_work_item_task",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    MainBlockId = table.Column<int>(type: "int", nullable: false),
                    SubBlockId = table.Column<int>(type: "int", nullable: false),
                    DescriptionKH = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    UoM = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BomTypeID = table.Column<int>(type: "int", nullable: false),
                    ScopeWorkId = table.Column<int>(type: "int", nullable: false),
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
                    table.PrimaryKey("PK_ef_boq_work_item_task", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ef_boq_work_item_task_ef_bom_scope_of_work_ScopeWorkId",
                        column: x => x.ScopeWorkId,
                        principalTable: "ef_bom_scope_of_work",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ef_boq_work_item_task_ef_bom_type_BomTypeID",
                        column: x => x.BomTypeID,
                        principalTable: "ef_bom_type",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ef_bom_details",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BomId = table.Column<int>(type: "int", nullable: false),
                    ItemCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TypeCode = table.Column<int>(type: "int", nullable: false),
                    BomUnit = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Quantity_REV = table.Column<decimal>(type: "decimal(18,10)", nullable: false),
                    Quantity = table.Column<decimal>(type: "decimal(18,10)", nullable: false),
                    Wastage = table.Column<decimal>(type: "decimal(18,10)", nullable: false),
                    UnitPrice = table.Column<decimal>(type: "decimal(18,10)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ef_bom_details", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ef_bom_details_ef_boms_BomId",
                        column: x => x.BomId,
                        principalTable: "ef_boms",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ef_bom_status_trackings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BomId = table.Column<int>(type: "int", nullable: false),
                    BomCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    CreatedName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Action = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ef_bom_status_trackings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ef_bom_status_trackings_ef_boms_BomId",
                        column: x => x.BomId,
                        principalTable: "ef_boms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ef_boq_site_inspection_floor_attachment",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BoqSiteInspectionFloorId = table.Column<int>(type: "int", nullable: true),
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
                    table.PrimaryKey("PK_ef_boq_site_inspection_floor_attachment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ef_boq_site_inspection_floor_attachment_ef_boq_site_inspection_floor_BoqSiteInspectionFloorId",
                        column: x => x.BoqSiteInspectionFloorId,
                        principalTable: "ef_boq_site_inspection_floor",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ef_boq_site_inspection_floor_attachment_vo_history",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BoqInspectionFloorAttId = table.Column<int>(type: "int", nullable: false),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BoqInspectionFloorVoId = table.Column<int>(type: "int", nullable: true),
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
                    table.PrimaryKey("PK_ef_boq_site_inspection_floor_attachment_vo_history", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ef_boq_site_inspection_floor_attachment_vo_history_ef_boq_site_inspection_floor_vo_history_BoqInspectionFloorVoId",
                        column: x => x.BoqInspectionFloorVoId,
                        principalTable: "ef_boq_site_inspection_floor_vo_history",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ef_PR_Requests_Items",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RefPrId = table.Column<int>(type: "int", nullable: false),
                    ItemId = table.Column<int>(type: "int", nullable: false),
                    ItemCode = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    TypeCode = table.Column<int>(type: "int", nullable: false),
                    Qty = table.Column<decimal>(type: "decimal(18,10)", nullable: false),
                    Wastage = table.Column<decimal>(type: "decimal(18,10)", nullable: false),
                    BaseUnitPrice = table.Column<decimal>(type: "decimal(18,10)", nullable: false),
                    BaseUnitOfMeasureId = table.Column<int>(type: "int", nullable: false),
                    BaseUnitOfMeasureName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UnitOfMeasureId = table.Column<int>(type: "int", nullable: false),
                    UnitOfMeasureName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UnitPrice = table.Column<decimal>(type: "decimal(18,10)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PRBomRequestId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ef_PR_Requests_Items", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ef_PR_Requests_Items_ef_PR_Requests_Bom_PRBomRequestId",
                        column: x => x.PRBomRequestId,
                        principalTable: "ef_PR_Requests_Bom",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ef_PR_Requests_Items_ef_PR_Requests_RefPrId",
                        column: x => x.RefPrId,
                        principalTable: "ef_PR_Requests",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ef_bom_block",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BlockCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedByName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedByName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Rev = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProjectId = table.Column<int>(type: "int", nullable: false),
                    PhaseId = table.Column<int>(type: "int", nullable: false),
                    MainBlockId = table.Column<int>(type: "int", nullable: false),
                    SubBlockId = table.Column<int>(type: "int", nullable: false),
                    BomTypeId = table.Column<int>(type: "int", nullable: false),
                    ScopeWorkId = table.Column<int>(type: "int", nullable: false),
                    ClassicficationId = table.Column<int>(type: "int", nullable: false),
                    isReleased = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    isReleasedId = table.Column<int>(type: "int", nullable: false),
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
                    table.PrimaryKey("PK_ef_bom_block", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ef_bom_block_ef_project_phases_PhaseId",
                        column: x => x.PhaseId,
                        principalTable: "ef_project_phases",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ef_bom_block_ef_projects_ProjectId",
                        column: x => x.ProjectId,
                        principalTable: "ef_projects",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ef_bom_main_block",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PhaseID = table.Column<int>(type: "int", nullable: false),
                    MainBlockCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    DescriptionKH = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
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
                    table.PrimaryKey("PK_ef_bom_main_block", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ef_bom_main_block_ef_project_phases_PhaseID",
                        column: x => x.PhaseID,
                        principalTable: "ef_project_phases",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ef_boq_Units",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Rev = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProjectId = table.Column<int>(type: "int", nullable: false),
                    ProjectName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhaseId = table.Column<int>(type: "int", nullable: false),
                    PhaseName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MainBlockId = table.Column<int>(type: "int", nullable: false),
                    MainBlockName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SubBlockId = table.Column<int>(type: "int", nullable: false),
                    SubBlockName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClassicficationId = table.Column<int>(type: "int", nullable: false),
                    ClassicficationName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UnitNumberId = table.Column<int>(type: "int", nullable: false),
                    UnitNumberName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UnitNameId = table.Column<int>(type: "int", nullable: false),
                    UnitName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsReleased = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                    table.PrimaryKey("PK_ef_boq_Units", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ef_boq_Units_ef_project_phases_PhaseId",
                        column: x => x.PhaseId,
                        principalTable: "ef_project_phases",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ef_boq_Units_ef_projects_ProjectId",
                        column: x => x.ProjectId,
                        principalTable: "ef_projects",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ef_boqs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProjectId = table.Column<int>(type: "int", nullable: false),
                    ProjectName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhaseId = table.Column<int>(type: "int", nullable: false),
                    PhaseName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BoqCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RevCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    BomTypeId = table.Column<int>(type: "int", nullable: false),
                    BomTypeName = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    BuildTypeId = table.Column<int>(type: "int", nullable: false),
                    BuildingTypeName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UnitTypeId = table.Column<int>(type: "int", nullable: false),
                    UnitTypeName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ScopeWorkId = table.Column<int>(type: "int", nullable: false),
                    ScopeWorkName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UnitNameId = table.Column<int>(type: "int", nullable: false),
                    UnitName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OrderNumber = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ef_boqs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ef_boqs_ef_project_phases_PhaseId",
                        column: x => x.PhaseId,
                        principalTable: "ef_project_phases",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ef_boqs_ef_projects_ProjectId",
                        column: x => x.ProjectId,
                        principalTable: "ef_projects",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ef_PR_Requests_Items_Schedules",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RefPrId = table.Column<int>(type: "int", nullable: false),
                    ItmReqId = table.Column<int>(type: "int", nullable: false),
                    ItemId = table.Column<int>(type: "int", nullable: false),
                    ItemCode = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    UnitOfMeasureId = table.Column<int>(type: "int", nullable: false),
                    UnitOfMeasureName = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    Quantity = table.Column<decimal>(type: "decimal(18,10)", nullable: false),
                    ScheduleDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ef_PR_Requests_Items_Schedules", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ef_PR_Requests_Items_Schedules_ef_PR_Requests_Items_ItmReqId",
                        column: x => x.ItmReqId,
                        principalTable: "ef_PR_Requests_Items",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ef_PRItemsRequestAttachments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RefItemRqId = table.Column<int>(type: "int", nullable: false),
                    Attachment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ef_PRItemsRequestAttachments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ef_PRItemsRequestAttachments_ef_PR_Requests_Items_RefItemRqId",
                        column: x => x.RefItemRqId,
                        principalTable: "ef_PR_Requests_Items",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ef_bom_block_details",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BomBlockId = table.Column<int>(type: "int", nullable: false),
                    BomId = table.Column<int>(type: "int", nullable: false),
                    BomRevCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BomReleasedId = table.Column<int>(type: "int", nullable: false),
                    UnitNumberId = table.Column<int>(type: "int", nullable: false),
                    CreatedByName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedByName = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                    table.PrimaryKey("PK_ef_bom_block_details", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ef_bom_block_details_ef_bom_block_BomBlockId",
                        column: x => x.BomBlockId,
                        principalTable: "ef_bom_block",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ef_bom_block_details_ef_boms_BomId",
                        column: x => x.BomId,
                        principalTable: "ef_boms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ef_unit_numbers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProjectId = table.Column<int>(type: "int", nullable: false),
                    PhaseId = table.Column<int>(type: "int", nullable: false),
                    BlockId = table.Column<int>(type: "int", nullable: false),
                    SubBlockId = table.Column<int>(type: "int", nullable: false),
                    UnitNameId = table.Column<int>(type: "int", nullable: false),
                    RedsUnitCode = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    SapUnitCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                    table.PrimaryKey("PK_ef_unit_numbers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ef_unit_numbers_ef_bom_main_block_BlockId",
                        column: x => x.BlockId,
                        principalTable: "ef_bom_main_block",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ef_unit_numbers_ef_bom_sub_block_SubBlockId",
                        column: x => x.SubBlockId,
                        principalTable: "ef_bom_sub_block",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ef_unit_numbers_ef_unit_name_UnitNameId",
                        column: x => x.UnitNameId,
                        principalTable: "ef_unit_name",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ef_boq_items",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BoqId = table.Column<int>(type: "int", nullable: false),
                    ItemId = table.Column<int>(type: "int", nullable: false),
                    WorkTaskName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FloorId = table.Column<int>(type: "int", nullable: false),
                    FloorName = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    UoM = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    QuantityREV = table.Column<decimal>(type: "decimal(18,10)", nullable: false),
                    Quantity = table.Column<decimal>(type: "decimal(18,10)", nullable: false),
                    Weight = table.Column<decimal>(type: "decimal(18,10)", nullable: false),
                    UnitPrice = table.Column<decimal>(type: "decimal(18,10)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    OrderNumber = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ef_boq_items", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ef_boq_items_ef_boq_work_item_task_ItemId",
                        column: x => x.ItemId,
                        principalTable: "ef_boq_work_item_task",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ef_boq_items_ef_boqs_BoqId",
                        column: x => x.BoqId,
                        principalTable: "ef_boqs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ef_boq_unit_items",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BoqUnitId = table.Column<int>(type: "int", nullable: false),
                    BoqId = table.Column<int>(type: "int", nullable: false),
                    BoqName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BomTypeId = table.Column<int>(type: "int", nullable: false),
                    BomTypeName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ScopeWorkId = table.Column<int>(type: "int", nullable: false),
                    ScopeWorkName = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                    table.PrimaryKey("PK_ef_boq_unit_items", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ef_boq_unit_items_ef_boq_Units_BoqUnitId",
                        column: x => x.BoqUnitId,
                        principalTable: "ef_boq_Units",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ef_boq_unit_items_ef_boqs_BoqId",
                        column: x => x.BoqId,
                        principalTable: "ef_boqs",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ef_boq_site_progress_inspection_rate",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BoqId = table.Column<int>(type: "int", nullable: false),
                    BoqName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BoqItemId = table.Column<int>(type: "int", nullable: false),
                    SiteProgressPercent = table.Column<decimal>(type: "decimal(18,10)", nullable: false),
                    Selected = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ef_boq_site_progress_inspection_rate", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ef_boq_site_progress_inspection_rate_ef_boq_items_BoqItemId",
                        column: x => x.BoqItemId,
                        principalTable: "ef_boq_items",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ef_bom_block_PhaseId",
                table: "ef_bom_block",
                column: "PhaseId");

            migrationBuilder.CreateIndex(
                name: "IX_ef_bom_block_ProjectId",
                table: "ef_bom_block",
                column: "ProjectId");

            migrationBuilder.CreateIndex(
                name: "IX_ef_bom_block_detail_update_tracking_RefBomBlockId",
                table: "ef_bom_block_detail_update_tracking",
                column: "RefBomBlockId");

            migrationBuilder.CreateIndex(
                name: "IX_ef_bom_block_details_BomBlockId",
                table: "ef_bom_block_details",
                column: "BomBlockId");

            migrationBuilder.CreateIndex(
                name: "IX_ef_bom_block_details_BomId",
                table: "ef_bom_block_details",
                column: "BomId");

            migrationBuilder.CreateIndex(
                name: "IX_ef_bom_detail_active_tracking_BomActiveId",
                table: "ef_bom_detail_active_tracking",
                column: "BomActiveId");

            migrationBuilder.CreateIndex(
                name: "IX_ef_bom_detail_update_tracking_BomRevId",
                table: "ef_bom_detail_update_tracking",
                column: "BomRevId");

            migrationBuilder.CreateIndex(
                name: "IX_ef_bom_details_BomId",
                table: "ef_bom_details",
                column: "BomId");

            migrationBuilder.CreateIndex(
                name: "IX_ef_bom_main_block_PhaseID",
                table: "ef_bom_main_block",
                column: "PhaseID");

            migrationBuilder.CreateIndex(
                name: "IX_ef_bom_scope_of_work_BomTypeID",
                table: "ef_bom_scope_of_work",
                column: "BomTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_ef_bom_status_trackings_BomId",
                table: "ef_bom_status_trackings",
                column: "BomId");

            migrationBuilder.CreateIndex(
                name: "IX_ef_bom_sub_block_ClassificationID",
                table: "ef_bom_sub_block",
                column: "ClassificationID");

            migrationBuilder.CreateIndex(
                name: "IX_ef_bomblock_details_active_tracking_RefBomBlockId",
                table: "ef_bomblock_details_active_tracking",
                column: "RefBomBlockId");

            migrationBuilder.CreateIndex(
                name: "IX_ef_boms_BomTypeId",
                table: "ef_boms",
                column: "BomTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_ef_boq_items_BoqId",
                table: "ef_boq_items",
                column: "BoqId");

            migrationBuilder.CreateIndex(
                name: "IX_ef_boq_items_ItemId",
                table: "ef_boq_items",
                column: "ItemId");

            migrationBuilder.CreateIndex(
                name: "IX_ef_boq_site_inspection_floor_BoqSiteInspectionID",
                table: "ef_boq_site_inspection_floor",
                column: "BoqSiteInspectionID");

            migrationBuilder.CreateIndex(
                name: "IX_ef_boq_site_inspection_floor_attachment_BoqSiteInspectionFloorId",
                table: "ef_boq_site_inspection_floor_attachment",
                column: "BoqSiteInspectionFloorId");

            migrationBuilder.CreateIndex(
                name: "IX_ef_boq_site_inspection_floor_attachment_vo_history_BoqInspectionFloorVoId",
                table: "ef_boq_site_inspection_floor_attachment_vo_history",
                column: "BoqInspectionFloorVoId");

            migrationBuilder.CreateIndex(
                name: "IX_ef_boq_site_inspection_floor_vo_history_BoqInspectionId",
                table: "ef_boq_site_inspection_floor_vo_history",
                column: "BoqInspectionId");

            migrationBuilder.CreateIndex(
                name: "IX_ef_boq_site_progress_inspection_rate_BoqItemId",
                table: "ef_boq_site_progress_inspection_rate",
                column: "BoqItemId");

            migrationBuilder.CreateIndex(
                name: "IX_ef_boq_unit_item_vo_history_BoqUnitVoId",
                table: "ef_boq_unit_item_vo_history",
                column: "BoqUnitVoId");

            migrationBuilder.CreateIndex(
                name: "IX_ef_boq_unit_items_BoqId",
                table: "ef_boq_unit_items",
                column: "BoqId");

            migrationBuilder.CreateIndex(
                name: "IX_ef_boq_unit_items_BoqUnitId",
                table: "ef_boq_unit_items",
                column: "BoqUnitId");

            migrationBuilder.CreateIndex(
                name: "IX_ef_boq_Units_PhaseId",
                table: "ef_boq_Units",
                column: "PhaseId");

            migrationBuilder.CreateIndex(
                name: "IX_ef_boq_Units_ProjectId",
                table: "ef_boq_Units",
                column: "ProjectId");

            migrationBuilder.CreateIndex(
                name: "IX_ef_boq_work_item_task_BomTypeID",
                table: "ef_boq_work_item_task",
                column: "BomTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_ef_boq_work_item_task_ScopeWorkId",
                table: "ef_boq_work_item_task",
                column: "ScopeWorkId");

            migrationBuilder.CreateIndex(
                name: "IX_ef_boqs_PhaseId",
                table: "ef_boqs",
                column: "PhaseId");

            migrationBuilder.CreateIndex(
                name: "IX_ef_boqs_ProjectId",
                table: "ef_boqs",
                column: "ProjectId");

            migrationBuilder.CreateIndex(
                name: "IX_ef_PR_bom_Items_Requests_RefPrReqId",
                table: "ef_PR_bom_Items_Requests",
                column: "RefPrReqId");

            migrationBuilder.CreateIndex(
                name: "IX_ef_PR_Requests_Bom_RefPrId",
                table: "ef_PR_Requests_Bom",
                column: "RefPrId");

            migrationBuilder.CreateIndex(
                name: "IX_ef_PR_Requests_Items_PRBomRequestId",
                table: "ef_PR_Requests_Items",
                column: "PRBomRequestId");

            migrationBuilder.CreateIndex(
                name: "IX_ef_PR_Requests_Items_RefPrId",
                table: "ef_PR_Requests_Items",
                column: "RefPrId");

            migrationBuilder.CreateIndex(
                name: "IX_ef_PR_Requests_Items_Schedules_ItmReqId",
                table: "ef_PR_Requests_Items_Schedules",
                column: "ItmReqId");

            migrationBuilder.CreateIndex(
                name: "IX_ef_PR_Requests_Units_RefPrId",
                table: "ef_PR_Requests_Units",
                column: "RefPrId");

            migrationBuilder.CreateIndex(
                name: "IX_ef_PRItemsRequestAttachments_RefItemRqId",
                table: "ef_PRItemsRequestAttachments",
                column: "RefItemRqId");

            migrationBuilder.CreateIndex(
                name: "IX_ef_project_phases_ProjectId",
                table: "ef_project_phases",
                column: "ProjectId");

            migrationBuilder.CreateIndex(
                name: "IX_ef_unit_name_UnitTypeID",
                table: "ef_unit_name",
                column: "UnitTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_ef_unit_numbers_BlockId",
                table: "ef_unit_numbers",
                column: "BlockId");

            migrationBuilder.CreateIndex(
                name: "IX_ef_unit_numbers_SubBlockId",
                table: "ef_unit_numbers",
                column: "SubBlockId");

            migrationBuilder.CreateIndex(
                name: "IX_ef_unit_numbers_UnitNameId",
                table: "ef_unit_numbers",
                column: "UnitNameId");

            migrationBuilder.CreateIndex(
                name: "IX_ef_unit_type_BuildingTypeID",
                table: "ef_unit_type",
                column: "BuildingTypeID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ef_bom_active_status");

            migrationBuilder.DropTable(
                name: "ef_Bom_Balance");

            migrationBuilder.DropTable(
                name: "ef_bom_block_detail_update_tracking");

            migrationBuilder.DropTable(
                name: "ef_bom_block_details");

            migrationBuilder.DropTable(
                name: "ef_bom_block_status_tracking");

            migrationBuilder.DropTable(
                name: "ef_bom_detail_active_tracking");

            migrationBuilder.DropTable(
                name: "ef_bom_detail_update_tracking");

            migrationBuilder.DropTable(
                name: "ef_bom_details");

            migrationBuilder.DropTable(
                name: "ef_bom_status");

            migrationBuilder.DropTable(
                name: "ef_bom_status_trackings");

            migrationBuilder.DropTable(
                name: "ef_bom_typeofbom");

            migrationBuilder.DropTable(
                name: "ef_bomblock_details_active_tracking");

            migrationBuilder.DropTable(
                name: "ef_boq_building_floor");

            migrationBuilder.DropTable(
                name: "ef_boq_site_inspection_floor_attachment");

            migrationBuilder.DropTable(
                name: "ef_boq_site_inspection_floor_attachment_vo_history");

            migrationBuilder.DropTable(
                name: "ef_boq_site_progress_inspection_rate");

            migrationBuilder.DropTable(
                name: "ef_boq_unit_item_vo_history");

            migrationBuilder.DropTable(
                name: "ef_boq_unit_items");

            migrationBuilder.DropTable(
                name: "ef_PR_bom_Items_Requests");

            migrationBuilder.DropTable(
                name: "ef_PR_Requests_Items_Schedules");

            migrationBuilder.DropTable(
                name: "ef_PR_Requests_Units");

            migrationBuilder.DropTable(
                name: "ef_PRItemsRequestAttachments");

            migrationBuilder.DropTable(
                name: "ef_unit_numbers");

            migrationBuilder.DropTable(
                name: "ef_bom_block_update_tracking");

            migrationBuilder.DropTable(
                name: "ef_bom_block");

            migrationBuilder.DropTable(
                name: "ef_bom_active_tracking");

            migrationBuilder.DropTable(
                name: "ef_bom_updated_tracking");

            migrationBuilder.DropTable(
                name: "ef_boms");

            migrationBuilder.DropTable(
                name: "ef_bomblock_active_tracking");

            migrationBuilder.DropTable(
                name: "ef_boq_site_inspection_floor");

            migrationBuilder.DropTable(
                name: "ef_boq_site_inspection_floor_vo_history");

            migrationBuilder.DropTable(
                name: "ef_boq_items");

            migrationBuilder.DropTable(
                name: "ef_boq_unit_vo_history");

            migrationBuilder.DropTable(
                name: "ef_boq_Units");

            migrationBuilder.DropTable(
                name: "ef_PR_Requests_Items");

            migrationBuilder.DropTable(
                name: "ef_bom_main_block");

            migrationBuilder.DropTable(
                name: "ef_bom_sub_block");

            migrationBuilder.DropTable(
                name: "ef_unit_name");

            migrationBuilder.DropTable(
                name: "ef_boq_site_inspection");

            migrationBuilder.DropTable(
                name: "ef_boq_site_inspection_vo_history");

            migrationBuilder.DropTable(
                name: "ef_boq_work_item_task");

            migrationBuilder.DropTable(
                name: "ef_boqs");

            migrationBuilder.DropTable(
                name: "ef_PR_Requests_Bom");

            migrationBuilder.DropTable(
                name: "ef_bom_classification");

            migrationBuilder.DropTable(
                name: "ef_unit_type");

            migrationBuilder.DropTable(
                name: "ef_bom_scope_of_work");

            migrationBuilder.DropTable(
                name: "ef_project_phases");

            migrationBuilder.DropTable(
                name: "ef_PR_Requests");

            migrationBuilder.DropTable(
                name: "ef_bom_building_type");

            migrationBuilder.DropTable(
                name: "ef_bom_type");

            migrationBuilder.DropTable(
                name: "ef_projects");
        }
    }
}
