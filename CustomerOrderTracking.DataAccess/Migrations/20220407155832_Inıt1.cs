using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CustomerOrderTracking.DataAccess.Migrations
{
    public partial class Inıt1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "OrderId",
                table: "CustomerOrders",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OrderId",
                table: "CustomerOrders");
        }
    }
}
