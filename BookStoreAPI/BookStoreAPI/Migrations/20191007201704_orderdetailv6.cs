using Microsoft.EntityFrameworkCore.Migrations;

namespace BookStoreAPI.Migrations
{
    public partial class orderdetailv6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Order_FromDeliveryInfo_FromDeliveryInfoId",
                table: "Order");

            migrationBuilder.DropForeignKey(
                name: "FK_Order_ToDeliveryInfo_ToDeliveryInfoId",
                table: "Order");

            migrationBuilder.AlterColumn<long>(
                name: "ToDeliveryInfoId",
                table: "Order",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AlterColumn<long>(
                name: "FromDeliveryInfoId",
                table: "Order",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AddForeignKey(
                name: "FK_Order_FromDeliveryInfo_FromDeliveryInfoId",
                table: "Order",
                column: "FromDeliveryInfoId",
                principalTable: "FromDeliveryInfo",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Order_ToDeliveryInfo_ToDeliveryInfoId",
                table: "Order",
                column: "ToDeliveryInfoId",
                principalTable: "ToDeliveryInfo",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Order_FromDeliveryInfo_FromDeliveryInfoId",
                table: "Order");

            migrationBuilder.DropForeignKey(
                name: "FK_Order_ToDeliveryInfo_ToDeliveryInfoId",
                table: "Order");

            migrationBuilder.AlterColumn<long>(
                name: "ToDeliveryInfoId",
                table: "Order",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldNullable: true);

            migrationBuilder.AlterColumn<long>(
                name: "FromDeliveryInfoId",
                table: "Order",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Order_FromDeliveryInfo_FromDeliveryInfoId",
                table: "Order",
                column: "FromDeliveryInfoId",
                principalTable: "FromDeliveryInfo",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Order_ToDeliveryInfo_ToDeliveryInfoId",
                table: "Order",
                column: "ToDeliveryInfoId",
                principalTable: "ToDeliveryInfo",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
