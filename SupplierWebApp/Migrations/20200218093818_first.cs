using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SupplierWebApp.Migrations
{
    public partial class first : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Area",
                columns: table => new
                {
                    AreaCod = table.Column<int>(nullable: false),
                    AreaName = table.Column<string>(maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Area", x => x.AreaCod);
                });

            migrationBuilder.CreateTable(
                name: "BidType",
                columns: table => new
                {
                    Code = table.Column<int>(nullable: false),
                    Name = table.Column<string>(maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BidType", x => x.Code);
                });

            migrationBuilder.CreateTable(
                name: "Details",
                columns: table => new
                {
                    Code = table.Column<int>(nullable: false),
                    Name = table.Column<string>(maxLength: 10, nullable: true),
                    Amount = table.Column<string>(maxLength: 10, nullable: true),
                    Value = table.Column<string>(maxLength: 10, nullable: true),
                    SupplyDate = table.Column<DateTime>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Details", x => x.Code);
                });

            migrationBuilder.CreateTable(
                name: "OfferingMethod",
                columns: table => new
                {
                    Code = table.Column<int>(nullable: false),
                    Name = table.Column<string>(maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OfferingMethod", x => x.Code);
                });

            migrationBuilder.CreateTable(
                name: "OfferingType",
                columns: table => new
                {
                    OfferingCod = table.Column<int>(nullable: false),
                    OfferingName = table.Column<string>(maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OfferingType", x => x.OfferingCod);
                });

            migrationBuilder.CreateTable(
                name: "Place",
                columns: table => new
                {
                    Code = table.Column<int>(nullable: false),
                    Comission = table.Column<string>(maxLength: 10, nullable: true),
                    Branches = table.Column<string>(maxLength: 10, nullable: true),
                    ConditionCode = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Place", x => x.Code);
                });

            migrationBuilder.CreateTable(
                name: "school",
                columns: table => new
                {
                    Code = table.Column<int>(nullable: false),
                    Name = table.Column<string>(maxLength: 10, nullable: true),
                    ConditionCode = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_school", x => x.Code);
                });

            migrationBuilder.CreateTable(
                name: "Status_FinacialDecision",
                columns: table => new
                {
                    Code = table.Column<int>(nullable: false),
                    Name = table.Column<string>(maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Status_FinacialDecision", x => x.Code);
                });

            migrationBuilder.CreateTable(
                name: "Status_SpplyOrder",
                columns: table => new
                {
                    Code = table.Column<int>(nullable: false),
                    Name = table.Column<bool>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Status", x => x.Code);
                });

            migrationBuilder.CreateTable(
                name: "Status_TechnicalDecision",
                columns: table => new
                {
                    Code = table.Column<int>(nullable: false),
                    Name = table.Column<string>(maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Status_TechnicalDecision", x => x.Code);
                });

            migrationBuilder.CreateTable(
                name: "SupplierType",
                columns: table => new
                {
                    SuuplierCod = table.Column<int>(nullable: false),
                    SuopplierName = table.Column<string>(maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SupplierType", x => x.SuuplierCod);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    UserName = table.Column<string>(maxLength: 10, nullable: false),
                    FirstName = table.Column<string>(maxLength: 10, nullable: true),
                    Address = table.Column<string>(maxLength: 10, nullable: true),
                    Phone = table.Column<string>(maxLength: 10, nullable: true),
                    Email = table.Column<string>(maxLength: 10, nullable: true),
                    Balance = table.Column<string>(maxLength: 10, nullable: true),
                    NickName = table.Column<string>(maxLength: 10, nullable: true),
                    SuuplierCode = table.Column<int>(nullable: true),
                    AreaCode = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.UserName);
                    table.ForeignKey(
                        name: "FK_User_Area",
                        column: x => x.AreaCode,
                        principalTable: "Area",
                        principalColumn: "AreaCod",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_User_User",
                        column: x => x.SuuplierCode,
                        principalTable: "SupplierType",
                        principalColumn: "SuuplierCod",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Bids",
                columns: table => new
                {
                    BidNumber = table.Column<int>(nullable: false),
                    OfferingCode = table.Column<int>(nullable: true),
                    OfferingType = table.Column<int>(nullable: true),
                    OfferingMethod = table.Column<int>(nullable: true),
                    UserName = table.Column<string>(maxLength: 10, nullable: true),
                    TecnicalDecision_Code = table.Column<int>(nullable: true),
                    Status_TechnicalCode = table.Column<int>(nullable: true),
                    Status_Financial_Code = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bids", x => x.BidNumber);
                    table.ForeignKey(
                        name: "FK_Bids_BidType",
                        column: x => x.BidNumber,
                        principalTable: "BidType",
                        principalColumn: "Code",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Bids",
                        column: x => x.OfferingCode,
                        principalTable: "OfferingType",
                        principalColumn: "OfferingCod",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Bids_OfferingMethod",
                        column: x => x.OfferingMethod,
                        principalTable: "OfferingMethod",
                        principalColumn: "Code",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Bids_Status_FinacialDecision",
                        column: x => x.Status_Financial_Code,
                        principalTable: "Status_FinacialDecision",
                        principalColumn: "Code",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Bids_Status_TechnicalDecision",
                        column: x => x.Status_TechnicalCode,
                        principalTable: "Status_TechnicalDecision",
                        principalColumn: "Code",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Bids_User",
                        column: x => x.UserName,
                        principalTable: "User",
                        principalColumn: "UserName",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SupplyOrder",
                columns: table => new
                {
                    Code = table.Column<string>(maxLength: 10, nullable: false),
                    SupplyDate = table.Column<DateTime>(type: "date", nullable: true),
                    SchoolName = table.Column<string>(maxLength: 10, nullable: true),
                    Date = table.Column<DateTime>(type: "date", nullable: true),
                    StatusCode = table.Column<int>(nullable: true),
                    OrderNumber = table.Column<int>(nullable: true),
                    DetailsCode = table.Column<int>(nullable: true),
                    UserName = table.Column<string>(maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SupplyOrder", x => x.Code);
                    table.ForeignKey(
                        name: "FK_SupplyOrder",
                        column: x => x.DetailsCode,
                        principalTable: "Details",
                        principalColumn: "Code",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SupplyOrder_Status",
                        column: x => x.StatusCode,
                        principalTable: "Status_SpplyOrder",
                        principalColumn: "Code",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SupplyOrder_User",
                        column: x => x.UserName,
                        principalTable: "User",
                        principalColumn: "UserName",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Conditions",
                columns: table => new
                {
                    code = table.Column<int>(nullable: false),
                    price = table.Column<decimal>(type: "decimal(18, 0)", nullable: true),
                    SchoolCode = table.Column<int>(nullable: true),
                    PrimaryInsurance = table.Column<decimal>(type: "decimal(18, 0)", nullable: true),
                    InsurancePayment = table.Column<DateTime>(type: "datetime", nullable: true),
                    PlaceCode = table.Column<int>(nullable: true),
                    BidNumber = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Conditions", x => x.code);
                    table.ForeignKey(
                        name: "FK_Conditions_Bids",
                        column: x => x.BidNumber,
                        principalTable: "Bids",
                        principalColumn: "BidNumber",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Conditions_Place",
                        column: x => x.PlaceCode,
                        principalTable: "Place",
                        principalColumn: "Code",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Conditions_school",
                        column: x => x.SchoolCode,
                        principalTable: "school",
                        principalColumn: "Code",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Bids_OfferingCode",
                table: "Bids",
                column: "OfferingCode");

            migrationBuilder.CreateIndex(
                name: "IX_Bids_OfferingMethod",
                table: "Bids",
                column: "OfferingMethod");

            migrationBuilder.CreateIndex(
                name: "IX_Bids_Status_Financial_Code",
                table: "Bids",
                column: "Status_Financial_Code");

            migrationBuilder.CreateIndex(
                name: "IX_Bids_Status_TechnicalCode",
                table: "Bids",
                column: "Status_TechnicalCode");

            migrationBuilder.CreateIndex(
                name: "IX_Bids_UserName",
                table: "Bids",
                column: "UserName");

            migrationBuilder.CreateIndex(
                name: "IX_Conditions_BidNumber",
                table: "Conditions",
                column: "BidNumber");

            migrationBuilder.CreateIndex(
                name: "IX_Conditions_PlaceCode",
                table: "Conditions",
                column: "PlaceCode");

            migrationBuilder.CreateIndex(
                name: "IX_Conditions_SchoolCode",
                table: "Conditions",
                column: "SchoolCode");

            migrationBuilder.CreateIndex(
                name: "IX_SupplyOrder_DetailsCode",
                table: "SupplyOrder",
                column: "DetailsCode");

            migrationBuilder.CreateIndex(
                name: "IX_SupplyOrder_StatusCode",
                table: "SupplyOrder",
                column: "StatusCode");

            migrationBuilder.CreateIndex(
                name: "IX_SupplyOrder_UserName",
                table: "SupplyOrder",
                column: "UserName");

            migrationBuilder.CreateIndex(
                name: "IX_User_AreaCode",
                table: "User",
                column: "AreaCode");

            migrationBuilder.CreateIndex(
                name: "IX_User_SuuplierCode",
                table: "User",
                column: "SuuplierCode");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Conditions");

            migrationBuilder.DropTable(
                name: "SupplyOrder");

            migrationBuilder.DropTable(
                name: "Bids");

            migrationBuilder.DropTable(
                name: "Place");

            migrationBuilder.DropTable(
                name: "school");

            migrationBuilder.DropTable(
                name: "Details");

            migrationBuilder.DropTable(
                name: "Status_SpplyOrder");

            migrationBuilder.DropTable(
                name: "BidType");

            migrationBuilder.DropTable(
                name: "OfferingType");

            migrationBuilder.DropTable(
                name: "OfferingMethod");

            migrationBuilder.DropTable(
                name: "Status_FinacialDecision");

            migrationBuilder.DropTable(
                name: "Status_TechnicalDecision");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "Area");

            migrationBuilder.DropTable(
                name: "SupplierType");
        }
    }
}
