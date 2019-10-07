using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BookStoreAPI.Migrations
{
    public partial class OrderDetailv4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DeliveryMethod_DeliveryMethodCost_DeliveryMethodCostId",
                table: "DeliveryMethod");

            migrationBuilder.DropTable(
                name: "DeliveryMethodCost");

            migrationBuilder.DropIndex(
                name: "IX_DeliveryMethod_DeliveryMethodCostId",
                table: "DeliveryMethod");

            migrationBuilder.DropColumn(
                name: "DeliveryMethodCostId",
                table: "DeliveryMethod");

            migrationBuilder.AddColumn<float>(
                name: "April",
                table: "DeliveryMethod",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "August",
                table: "DeliveryMethod",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "December",
                table: "DeliveryMethod",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "February",
                table: "DeliveryMethod",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "January",
                table: "DeliveryMethod",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "July",
                table: "DeliveryMethod",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "June",
                table: "DeliveryMethod",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "March",
                table: "DeliveryMethod",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "May",
                table: "DeliveryMethod",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "November",
                table: "DeliveryMethod",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "October",
                table: "DeliveryMethod",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "September",
                table: "DeliveryMethod",
                nullable: false,
                defaultValue: 0f);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "April",
                table: "DeliveryMethod");

            migrationBuilder.DropColumn(
                name: "August",
                table: "DeliveryMethod");

            migrationBuilder.DropColumn(
                name: "December",
                table: "DeliveryMethod");

            migrationBuilder.DropColumn(
                name: "February",
                table: "DeliveryMethod");

            migrationBuilder.DropColumn(
                name: "January",
                table: "DeliveryMethod");

            migrationBuilder.DropColumn(
                name: "July",
                table: "DeliveryMethod");

            migrationBuilder.DropColumn(
                name: "June",
                table: "DeliveryMethod");

            migrationBuilder.DropColumn(
                name: "March",
                table: "DeliveryMethod");

            migrationBuilder.DropColumn(
                name: "May",
                table: "DeliveryMethod");

            migrationBuilder.DropColumn(
                name: "November",
                table: "DeliveryMethod");

            migrationBuilder.DropColumn(
                name: "October",
                table: "DeliveryMethod");

            migrationBuilder.DropColumn(
                name: "September",
                table: "DeliveryMethod");

            migrationBuilder.AddColumn<long>(
                name: "DeliveryMethodCostId",
                table: "DeliveryMethod",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.CreateTable(
                name: "DeliveryMethodCost",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    April = table.Column<float>(type: "real", nullable: false),
                    August = table.Column<float>(type: "real", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    December = table.Column<float>(type: "real", nullable: false),
                    February = table.Column<float>(type: "real", nullable: false),
                    January = table.Column<float>(type: "real", nullable: false),
                    July = table.Column<float>(type: "real", nullable: false),
                    June = table.Column<float>(type: "real", nullable: false),
                    March = table.Column<float>(type: "real", nullable: false),
                    May = table.Column<float>(type: "real", nullable: false),
                    November = table.Column<float>(type: "real", nullable: false),
                    October = table.Column<float>(type: "real", nullable: false),
                    September = table.Column<float>(type: "real", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeliveryMethodCost", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DeliveryMethod_DeliveryMethodCostId",
                table: "DeliveryMethod",
                column: "DeliveryMethodCostId");

            migrationBuilder.AddForeignKey(
                name: "FK_DeliveryMethod_DeliveryMethodCost_DeliveryMethodCostId",
                table: "DeliveryMethod",
                column: "DeliveryMethodCostId",
                principalTable: "DeliveryMethodCost",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
