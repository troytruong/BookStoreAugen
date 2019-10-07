using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BookStoreAPI.Migrations
{
    public partial class OrderDetailv3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "OrderDetail",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "ItemId",
                table: "OrderDetail",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedDate",
                table: "OrderDetail",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "Order",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<float>(
                name: "DeliveryMethodCost",
                table: "Order",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<long>(
                name: "DeliveryMethodId",
                table: "Order",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "FromDeliveryInfoId",
                table: "Order",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "ToDeliveryInfoId",
                table: "Order",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedDate",
                table: "Order",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.CreateTable(
                name: "DeliveryMethodCost",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    UpdatedDate = table.Column<DateTime>(nullable: false),
                    January = table.Column<float>(nullable: false),
                    February = table.Column<float>(nullable: false),
                    March = table.Column<float>(nullable: false),
                    April = table.Column<float>(nullable: false),
                    May = table.Column<float>(nullable: false),
                    June = table.Column<float>(nullable: false),
                    July = table.Column<float>(nullable: false),
                    August = table.Column<float>(nullable: false),
                    September = table.Column<float>(nullable: false),
                    October = table.Column<float>(nullable: false),
                    November = table.Column<float>(nullable: false),
                    December = table.Column<float>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeliveryMethodCost", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FromDeliveryInfo",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    UpdatedDate = table.Column<DateTime>(nullable: false),
                    FullName = table.Column<string>(maxLength: 100, nullable: true),
                    Address = table.Column<string>(maxLength: 200, nullable: true),
                    City = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FromDeliveryInfo", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ToDeliveryInfo",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    UpdatedDate = table.Column<DateTime>(nullable: false),
                    FullName = table.Column<string>(maxLength: 100, nullable: true),
                    Address = table.Column<string>(maxLength: 200, nullable: true),
                    City = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ToDeliveryInfo", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DeliveryMethod",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    UpdatedDate = table.Column<DateTime>(nullable: false),
                    Name = table.Column<string>(maxLength: 50, nullable: true),
                    DeliveryMethodCostId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeliveryMethod", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DeliveryMethod_DeliveryMethodCost_DeliveryMethodCostId",
                        column: x => x.DeliveryMethodCostId,
                        principalTable: "DeliveryMethodCost",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Order_DeliveryMethodId",
                table: "Order",
                column: "DeliveryMethodId");

            migrationBuilder.CreateIndex(
                name: "IX_Order_FromDeliveryInfoId",
                table: "Order",
                column: "FromDeliveryInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_Order_ToDeliveryInfoId",
                table: "Order",
                column: "ToDeliveryInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_DeliveryMethod_DeliveryMethodCostId",
                table: "DeliveryMethod",
                column: "DeliveryMethodCostId");

            migrationBuilder.AddForeignKey(
                name: "FK_Order_DeliveryMethod_DeliveryMethodId",
                table: "Order",
                column: "DeliveryMethodId",
                principalTable: "DeliveryMethod",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Order_DeliveryMethod_DeliveryMethodId",
                table: "Order");

            migrationBuilder.DropForeignKey(
                name: "FK_Order_FromDeliveryInfo_FromDeliveryInfoId",
                table: "Order");

            migrationBuilder.DropForeignKey(
                name: "FK_Order_ToDeliveryInfo_ToDeliveryInfoId",
                table: "Order");

            migrationBuilder.DropTable(
                name: "DeliveryMethod");

            migrationBuilder.DropTable(
                name: "FromDeliveryInfo");

            migrationBuilder.DropTable(
                name: "ToDeliveryInfo");

            migrationBuilder.DropTable(
                name: "DeliveryMethodCost");

            migrationBuilder.DropIndex(
                name: "IX_Order_DeliveryMethodId",
                table: "Order");

            migrationBuilder.DropIndex(
                name: "IX_Order_FromDeliveryInfoId",
                table: "Order");

            migrationBuilder.DropIndex(
                name: "IX_Order_ToDeliveryInfoId",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "OrderDetail");

            migrationBuilder.DropColumn(
                name: "ItemId",
                table: "OrderDetail");

            migrationBuilder.DropColumn(
                name: "UpdatedDate",
                table: "OrderDetail");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "DeliveryMethodCost",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "DeliveryMethodId",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "FromDeliveryInfoId",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "ToDeliveryInfoId",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "UpdatedDate",
                table: "Order");
        }
    }
}
