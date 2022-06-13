using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Pen.Entity.Migrations
{
    public partial class First : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BodyMaterials",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Bodymaterial = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Deleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BodyMaterials", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Covertype",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Covertypes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Deleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Covertype", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FillingMechanism",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FillingMechanisms = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Deleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FillingMechanism", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FountainPen",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FountainPenTypes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Deleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FountainPen", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PenStatus",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Penstatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Deleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PenStatus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TipTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TipType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Deleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PenInformation",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Brand = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Model = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PenImage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PenImage1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PenImage2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductYear = table.Column<int>(type: "int", nullable: false),
                    TipTypeId = table.Column<int>(type: "int", nullable: false),
                    FillingMechanismId = table.Column<int>(type: "int", nullable: false),
                    CovertypeId = table.Column<int>(type: "int", nullable: false),
                    PenStatusId = table.Column<int>(type: "int", nullable: false),
                    BodyMaterialId = table.Column<int>(type: "int", nullable: false),
                    PurchaseDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Color = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CapLength = table.Column<int>(type: "int", nullable: false),
                    PenLengthExcludingCap = table.Column<int>(type: "int", nullable: false),
                    CapClosedPenLength = table.Column<int>(type: "int", nullable: false),
                    DiameterOfThePen = table.Column<int>(type: "int", nullable: false),
                    Conduction = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Explanation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Deleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PenInformation", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PenInformation_BodyMaterials_BodyMaterialId",
                        column: x => x.BodyMaterialId,
                        principalTable: "BodyMaterials",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PenInformation_Covertype_CovertypeId",
                        column: x => x.CovertypeId,
                        principalTable: "Covertype",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PenInformation_FillingMechanism_FillingMechanismId",
                        column: x => x.FillingMechanismId,
                        principalTable: "FillingMechanism",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PenInformation_PenStatus_PenStatusId",
                        column: x => x.PenStatusId,
                        principalTable: "PenStatus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PenInformation_TipTypes_TipTypeId",
                        column: x => x.TipTypeId,
                        principalTable: "TipTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PenInformation_BodyMaterialId",
                table: "PenInformation",
                column: "BodyMaterialId");

            migrationBuilder.CreateIndex(
                name: "IX_PenInformation_CovertypeId",
                table: "PenInformation",
                column: "CovertypeId");

            migrationBuilder.CreateIndex(
                name: "IX_PenInformation_FillingMechanismId",
                table: "PenInformation",
                column: "FillingMechanismId");

            migrationBuilder.CreateIndex(
                name: "IX_PenInformation_PenStatusId",
                table: "PenInformation",
                column: "PenStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_PenInformation_TipTypeId",
                table: "PenInformation",
                column: "TipTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FountainPen");

            migrationBuilder.DropTable(
                name: "PenInformation");

            migrationBuilder.DropTable(
                name: "BodyMaterials");

            migrationBuilder.DropTable(
                name: "Covertype");

            migrationBuilder.DropTable(
                name: "FillingMechanism");

            migrationBuilder.DropTable(
                name: "PenStatus");

            migrationBuilder.DropTable(
                name: "TipTypes");
        }
    }
}
