using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace eCommerce.Services.Migrations
{
    /// <inheritdoc />
    public partial class init2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CartEvents_CartItems_CartItemId",
                table: "CartEvents");

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 22, 53, 14, 212, DateTimeKind.Utc).AddTicks(2947));

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 22, 53, 14, 212, DateTimeKind.Utc).AddTicks(2950));

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 22, 53, 14, 212, DateTimeKind.Utc).AddTicks(2951));

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 22, 53, 14, 212, DateTimeKind.Utc).AddTicks(2952));

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 22, 53, 14, 212, DateTimeKind.Utc).AddTicks(2953));

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 22, 53, 14, 212, DateTimeKind.Utc).AddTicks(2955));

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 22, 53, 14, 212, DateTimeKind.Utc).AddTicks(2956));

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 22, 53, 14, 212, DateTimeKind.Utc).AddTicks(2957));

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 22, 53, 14, 212, DateTimeKind.Utc).AddTicks(2958));

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 22, 53, 14, 212, DateTimeKind.Utc).AddTicks(2959));

            migrationBuilder.UpdateData(
                table: "CartEvents",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 22, 53, 14, 212, DateTimeKind.Utc).AddTicks(3172));

            migrationBuilder.UpdateData(
                table: "CartEvents",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 22, 53, 14, 212, DateTimeKind.Utc).AddTicks(3174));

            migrationBuilder.UpdateData(
                table: "CartItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddedAt",
                value: new DateTime(2026, 2, 10, 22, 53, 14, 212, DateTimeKind.Utc).AddTicks(3075));

            migrationBuilder.UpdateData(
                table: "CartItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "AddedAt",
                value: new DateTime(2026, 2, 10, 22, 53, 14, 212, DateTimeKind.Utc).AddTicks(3077));

            migrationBuilder.UpdateData(
                table: "CartItems",
                keyColumn: "Id",
                keyValue: 3,
                column: "AddedAt",
                value: new DateTime(2026, 2, 15, 22, 53, 14, 212, DateTimeKind.Utc).AddTicks(3078));

            migrationBuilder.UpdateData(
                table: "Carts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 22, 53, 14, 212, DateTimeKind.Utc).AddTicks(3031));

            migrationBuilder.UpdateData(
                table: "Carts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 22, 53, 14, 212, DateTimeKind.Utc).AddTicks(3032));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 22, 53, 14, 212, DateTimeKind.Utc).AddTicks(2641));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 22, 53, 14, 212, DateTimeKind.Utc).AddTicks(2643));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 22, 53, 14, 212, DateTimeKind.Utc).AddTicks(2644));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 22, 53, 14, 212, DateTimeKind.Utc).AddTicks(2646));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                column: "OrderDate",
                value: new DateTime(2026, 2, 10, 22, 53, 14, 212, DateTimeKind.Utc).AddTicks(3111));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                column: "OrderDate",
                value: new DateTime(2026, 2, 10, 22, 53, 14, 212, DateTimeKind.Utc).AddTicks(3114));

            migrationBuilder.UpdateData(
                table: "ProductReviews",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 22, 53, 14, 212, DateTimeKind.Utc).AddTicks(3008));

            migrationBuilder.UpdateData(
                table: "ProductReviews",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 22, 53, 14, 212, DateTimeKind.Utc).AddTicks(3010));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 22, 53, 14, 212, DateTimeKind.Utc).AddTicks(2751));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 22, 53, 14, 212, DateTimeKind.Utc).AddTicks(2753));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 22, 53, 14, 212, DateTimeKind.Utc).AddTicks(2894));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 22, 53, 14, 212, DateTimeKind.Utc).AddTicks(2899));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 22, 53, 14, 212, DateTimeKind.Utc).AddTicks(2901));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 22, 53, 14, 212, DateTimeKind.Utc).AddTicks(2904));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 22, 53, 14, 212, DateTimeKind.Utc).AddTicks(2907));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 22, 53, 14, 212, DateTimeKind.Utc).AddTicks(2910));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 22, 53, 14, 212, DateTimeKind.Utc).AddTicks(2912));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 22, 53, 14, 212, DateTimeKind.Utc).AddTicks(2914));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 22, 53, 14, 212, DateTimeKind.Utc).AddTicks(2917));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 22, 53, 14, 212, DateTimeKind.Utc).AddTicks(2920));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 22, 53, 14, 212, DateTimeKind.Utc).AddTicks(2797));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 22, 53, 14, 212, DateTimeKind.Utc).AddTicks(2798));

            migrationBuilder.UpdateData(
                table: "UnitsOfMeasure",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 22, 53, 14, 212, DateTimeKind.Utc).AddTicks(2776));

            migrationBuilder.UpdateData(
                table: "UnitsOfMeasure",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 22, 53, 14, 212, DateTimeKind.Utc).AddTicks(2777));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateAssigned",
                value: new DateTime(2026, 2, 10, 22, 53, 14, 212, DateTimeKind.Utc).AddTicks(3151));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateAssigned",
                value: new DateTime(2026, 2, 10, 22, 53, 14, 212, DateTimeKind.Utc).AddTicks(3153));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 22, 53, 14, 212, DateTimeKind.Utc).AddTicks(2866));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 22, 53, 14, 212, DateTimeKind.Utc).AddTicks(2868));

            migrationBuilder.AddForeignKey(
                name: "FK_CartEvents_CartItems_CartItemId",
                table: "CartEvents",
                column: "CartItemId",
                principalTable: "CartItems",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CartEvents_CartItems_CartItemId",
                table: "CartEvents");

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 22, 17, 44, 823, DateTimeKind.Utc).AddTicks(1016));

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 22, 17, 44, 823, DateTimeKind.Utc).AddTicks(1018));

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 22, 17, 44, 823, DateTimeKind.Utc).AddTicks(1019));

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 22, 17, 44, 823, DateTimeKind.Utc).AddTicks(1020));

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 22, 17, 44, 823, DateTimeKind.Utc).AddTicks(1021));

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 22, 17, 44, 823, DateTimeKind.Utc).AddTicks(1023));

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 22, 17, 44, 823, DateTimeKind.Utc).AddTicks(1024));

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 22, 17, 44, 823, DateTimeKind.Utc).AddTicks(1025));

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 22, 17, 44, 823, DateTimeKind.Utc).AddTicks(1026));

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 22, 17, 44, 823, DateTimeKind.Utc).AddTicks(1027));

            migrationBuilder.UpdateData(
                table: "CartEvents",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 22, 17, 44, 823, DateTimeKind.Utc).AddTicks(1243));

            migrationBuilder.UpdateData(
                table: "CartEvents",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 22, 17, 44, 823, DateTimeKind.Utc).AddTicks(1244));

            migrationBuilder.UpdateData(
                table: "CartItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddedAt",
                value: new DateTime(2026, 2, 10, 22, 17, 44, 823, DateTimeKind.Utc).AddTicks(1123));

            migrationBuilder.UpdateData(
                table: "CartItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "AddedAt",
                value: new DateTime(2026, 2, 10, 22, 17, 44, 823, DateTimeKind.Utc).AddTicks(1124));

            migrationBuilder.UpdateData(
                table: "CartItems",
                keyColumn: "Id",
                keyValue: 3,
                column: "AddedAt",
                value: new DateTime(2026, 2, 15, 22, 17, 44, 823, DateTimeKind.Utc).AddTicks(1126));

            migrationBuilder.UpdateData(
                table: "Carts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 22, 17, 44, 823, DateTimeKind.Utc).AddTicks(1104));

            migrationBuilder.UpdateData(
                table: "Carts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 22, 17, 44, 823, DateTimeKind.Utc).AddTicks(1105));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 22, 17, 44, 823, DateTimeKind.Utc).AddTicks(666));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 22, 17, 44, 823, DateTimeKind.Utc).AddTicks(669));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 22, 17, 44, 823, DateTimeKind.Utc).AddTicks(670));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 22, 17, 44, 823, DateTimeKind.Utc).AddTicks(672));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                column: "OrderDate",
                value: new DateTime(2026, 2, 10, 22, 17, 44, 823, DateTimeKind.Utc).AddTicks(1159));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                column: "OrderDate",
                value: new DateTime(2026, 2, 10, 22, 17, 44, 823, DateTimeKind.Utc).AddTicks(1163));

            migrationBuilder.UpdateData(
                table: "ProductReviews",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 22, 17, 44, 823, DateTimeKind.Utc).AddTicks(1080));

            migrationBuilder.UpdateData(
                table: "ProductReviews",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 22, 17, 44, 823, DateTimeKind.Utc).AddTicks(1082));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 22, 17, 44, 823, DateTimeKind.Utc).AddTicks(800));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 22, 17, 44, 823, DateTimeKind.Utc).AddTicks(802));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 22, 17, 44, 823, DateTimeKind.Utc).AddTicks(911));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 22, 17, 44, 823, DateTimeKind.Utc).AddTicks(962));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 22, 17, 44, 823, DateTimeKind.Utc).AddTicks(965));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 22, 17, 44, 823, DateTimeKind.Utc).AddTicks(968));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 22, 17, 44, 823, DateTimeKind.Utc).AddTicks(970));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 22, 17, 44, 823, DateTimeKind.Utc).AddTicks(972));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 22, 17, 44, 823, DateTimeKind.Utc).AddTicks(975));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 22, 17, 44, 823, DateTimeKind.Utc).AddTicks(978));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 22, 17, 44, 823, DateTimeKind.Utc).AddTicks(980));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 22, 17, 44, 823, DateTimeKind.Utc).AddTicks(983));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 22, 17, 44, 823, DateTimeKind.Utc).AddTicks(849));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 22, 17, 44, 823, DateTimeKind.Utc).AddTicks(850));

            migrationBuilder.UpdateData(
                table: "UnitsOfMeasure",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 22, 17, 44, 823, DateTimeKind.Utc).AddTicks(825));

            migrationBuilder.UpdateData(
                table: "UnitsOfMeasure",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 22, 17, 44, 823, DateTimeKind.Utc).AddTicks(827));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateAssigned",
                value: new DateTime(2026, 2, 10, 22, 17, 44, 823, DateTimeKind.Utc).AddTicks(1224));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateAssigned",
                value: new DateTime(2026, 2, 10, 22, 17, 44, 823, DateTimeKind.Utc).AddTicks(1225));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 22, 17, 44, 823, DateTimeKind.Utc).AddTicks(873));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 22, 17, 44, 823, DateTimeKind.Utc).AddTicks(875));

            migrationBuilder.AddForeignKey(
                name: "FK_CartEvents_CartItems_CartItemId",
                table: "CartEvents",
                column: "CartItemId",
                principalTable: "CartItems",
                principalColumn: "Id");
        }
    }
}
