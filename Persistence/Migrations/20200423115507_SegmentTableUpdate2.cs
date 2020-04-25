using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class SegmentTableUpdate2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "TargetFrequency",
                table: "Segment",
                type: "decimal(12,2)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(12,2)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "TargetFrequency",
                table: "Segment",
                type: "decimal(12,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(12,2)",
                oldNullable: true);
        }
    }
}
