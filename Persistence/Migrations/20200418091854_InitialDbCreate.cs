using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class InitialDbCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "City",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Active = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_City", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Department",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Active = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Department", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Market",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Active = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Market", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Team",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Active = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Team", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DepartmentCity",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    PhysicianCount = table.Column<decimal>(type: "decimal(12,2)", nullable: false),
                    Active = table.Column<bool>(nullable: false),
                    DepartmentId = table.Column<Guid>(nullable: false),
                    CityId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DepartmentCity", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DepartmentCity_City_CityId",
                        column: x => x.CityId,
                        principalTable: "City",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DepartmentCity_Department_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "Department",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MarketCity",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(12,2)", nullable: false),
                    Active = table.Column<bool>(nullable: false),
                    MarketId = table.Column<Guid>(nullable: false),
                    CityId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MarketCity", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MarketCity_City_CityId",
                        column: x => x.CityId,
                        principalTable: "City",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MarketCity_Market_MarketId",
                        column: x => x.MarketId,
                        principalTable: "Market",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Active = table.Column<bool>(nullable: false),
                    MarketId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Product_Market_MarketId",
                        column: x => x.MarketId,
                        principalTable: "Market",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Plan",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Active = table.Column<bool>(nullable: false),
                    DeductionMPR = table.Column<decimal>(type: "decimal(12,2)", nullable: true),
                    InductionMPR = table.Column<decimal>(type: "decimal(12,2)", nullable: true),
                    ActualMPR = table.Column<decimal>(type: "decimal(12,2)", nullable: false),
                    MinimumScope = table.Column<decimal>(type: "decimal(12,2)", nullable: false),
                    Created = table.Column<DateTime>(nullable: false),
                    TeamId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Plan", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Plan_Team_TeamId",
                        column: x => x.TeamId,
                        principalTable: "Team",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Deduction",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    AnnualWorkingDay = table.Column<decimal>(type: "decimal(12,2)", nullable: true),
                    MonthlyWorkingDay = table.Column<decimal>(type: "decimal(12,2)", nullable: true),
                    DailyVisit = table.Column<decimal>(type: "decimal(12,2)", nullable: true),
                    MonthlyVisitCapacity = table.Column<decimal>(type: "decimal(12,2)", nullable: true),
                    MonthlyTargetVisitFrequency = table.Column<decimal>(type: "decimal(12,2)", nullable: true),
                    MonthlyTargetMPR = table.Column<decimal>(type: "decimal(12,2)", nullable: true),
                    TargetedTotalPhysician = table.Column<decimal>(type: "decimal(12,2)", nullable: true),
                    TargetedTotalVisit = table.Column<decimal>(type: "decimal(12,2)", nullable: true),
                    AverageFrequency = table.Column<decimal>(type: "decimal(12,2)", nullable: true),
                    PlanId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Deduction", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Deduction_Plan_PlanId",
                        column: x => x.PlanId,
                        principalTable: "Plan",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Induction",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    GeographicRatio = table.Column<decimal>(type: "decimal(12,2)", nullable: true),
                    PhysicianRatio = table.Column<decimal>(type: "decimal(12,2)", nullable: true),
                    PlanId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Induction", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Induction_Plan_PlanId",
                        column: x => x.PlanId,
                        principalTable: "Plan",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PlanMarket",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    PlanId = table.Column<Guid>(nullable: false),
                    MarketId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlanMarket", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PlanMarket_Market_MarketId",
                        column: x => x.MarketId,
                        principalTable: "Market",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PlanMarket_Plan_PlanId",
                        column: x => x.PlanId,
                        principalTable: "Plan",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DeductionDetail",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    PhysicianUniverse = table.Column<decimal>(type: "decimal(12,2)", nullable: true),
                    PhysicianUniverseCovered = table.Column<decimal>(type: "decimal(12,2)", nullable: true),
                    Scope = table.Column<decimal>(type: "decimal(12,2)", nullable: true),
                    ScopeCount = table.Column<decimal>(type: "decimal(12,2)", nullable: true),
                    DepartmentId = table.Column<Guid>(nullable: false),
                    DeductionId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeductionDetail", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DeductionDetail_Deduction_DeductionId",
                        column: x => x.DeductionId,
                        principalTable: "Deduction",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DeductionDetail_Department_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "Department",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "InductionDetail",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Market = table.Column<decimal>(type: "decimal(12,2)", nullable: true),
                    MarketGeographicRatio = table.Column<decimal>(type: "decimal(12,2)", nullable: true),
                    PhysicianCount = table.Column<decimal>(type: "decimal(12,2)", nullable: true),
                    PhysicianGeographicRatio = table.Column<decimal>(type: "decimal(12,2)", nullable: true),
                    WeightedGeographicRatio = table.Column<decimal>(type: "decimal(12,2)", nullable: true),
                    CityId = table.Column<Guid>(nullable: false),
                    InductionId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InductionDetail", x => x.Id);
                    table.ForeignKey(
                        name: "FK_InductionDetail_City_CityId",
                        column: x => x.CityId,
                        principalTable: "City",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_InductionDetail_Induction_InductionId",
                        column: x => x.InductionId,
                        principalTable: "Induction",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Segment",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Rate = table.Column<decimal>(type: "decimal(12,2)", nullable: false),
                    TargetCount = table.Column<decimal>(type: "decimal(12,2)", nullable: false),
                    TargetFrequency = table.Column<decimal>(type: "decimal(12,2)", nullable: false),
                    Visit = table.Column<decimal>(type: "decimal(12,2)", nullable: false),
                    DeductionDetailId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Segment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Segment_DeductionDetail_DeductionDetailId",
                        column: x => x.DeductionDetailId,
                        principalTable: "DeductionDetail",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Deduction_PlanId",
                table: "Deduction",
                column: "PlanId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_DeductionDetail_DeductionId",
                table: "DeductionDetail",
                column: "DeductionId");

            migrationBuilder.CreateIndex(
                name: "IX_DeductionDetail_DepartmentId",
                table: "DeductionDetail",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_DepartmentCity_CityId",
                table: "DepartmentCity",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_DepartmentCity_DepartmentId",
                table: "DepartmentCity",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Induction_PlanId",
                table: "Induction",
                column: "PlanId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_InductionDetail_CityId",
                table: "InductionDetail",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_InductionDetail_InductionId",
                table: "InductionDetail",
                column: "InductionId");

            migrationBuilder.CreateIndex(
                name: "IX_MarketCity_CityId",
                table: "MarketCity",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_MarketCity_MarketId",
                table: "MarketCity",
                column: "MarketId");

            migrationBuilder.CreateIndex(
                name: "IX_Plan_TeamId",
                table: "Plan",
                column: "TeamId");

            migrationBuilder.CreateIndex(
                name: "IX_PlanMarket_MarketId",
                table: "PlanMarket",
                column: "MarketId");

            migrationBuilder.CreateIndex(
                name: "IX_PlanMarket_PlanId",
                table: "PlanMarket",
                column: "PlanId");

            migrationBuilder.CreateIndex(
                name: "IX_Product_MarketId",
                table: "Product",
                column: "MarketId");

            migrationBuilder.CreateIndex(
                name: "IX_Segment_DeductionDetailId",
                table: "Segment",
                column: "DeductionDetailId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DepartmentCity");

            migrationBuilder.DropTable(
                name: "InductionDetail");

            migrationBuilder.DropTable(
                name: "MarketCity");

            migrationBuilder.DropTable(
                name: "PlanMarket");

            migrationBuilder.DropTable(
                name: "Product");

            migrationBuilder.DropTable(
                name: "Segment");

            migrationBuilder.DropTable(
                name: "Induction");

            migrationBuilder.DropTable(
                name: "City");

            migrationBuilder.DropTable(
                name: "Market");

            migrationBuilder.DropTable(
                name: "DeductionDetail");

            migrationBuilder.DropTable(
                name: "Deduction");

            migrationBuilder.DropTable(
                name: "Department");

            migrationBuilder.DropTable(
                name: "Plan");

            migrationBuilder.DropTable(
                name: "Team");
        }
    }
}
