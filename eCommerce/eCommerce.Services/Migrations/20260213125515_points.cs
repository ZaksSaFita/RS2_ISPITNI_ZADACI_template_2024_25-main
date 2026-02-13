using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace eCommerce.Services.Migrations
{
    /// <inheritdoc />
    public partial class points : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "NumberOfPoints",
                table: "UserActivityBrojIndeksa",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "ActivityBrojIndeksa",
                keyColumn: "Id",
                keyValue: 1,
                column: "DueDate",
                value: new DateTime(2026, 2, 23, 12, 55, 15, 270, DateTimeKind.Utc).AddTicks(1111));

            migrationBuilder.UpdateData(
                table: "ActivityBrojIndeksa",
                keyColumn: "Id",
                keyValue: 2,
                column: "DueDate",
                value: new DateTime(2026, 2, 28, 12, 55, 15, 270, DateTimeKind.Utc).AddTicks(1115));

            migrationBuilder.UpdateData(
                table: "ActivityBrojIndeksa",
                keyColumn: "Id",
                keyValue: 3,
                column: "DueDate",
                value: new DateTime(2026, 3, 5, 12, 55, 15, 270, DateTimeKind.Utc).AddTicks(1117));

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 13, 12, 55, 15, 270, DateTimeKind.Utc).AddTicks(936));

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 13, 12, 55, 15, 270, DateTimeKind.Utc).AddTicks(937));

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 13, 12, 55, 15, 270, DateTimeKind.Utc).AddTicks(938));

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 13, 12, 55, 15, 270, DateTimeKind.Utc).AddTicks(940));

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 13, 12, 55, 15, 270, DateTimeKind.Utc).AddTicks(941));

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 13, 12, 55, 15, 270, DateTimeKind.Utc).AddTicks(942));

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 13, 12, 55, 15, 270, DateTimeKind.Utc).AddTicks(943));

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 13, 12, 55, 15, 270, DateTimeKind.Utc).AddTicks(944));

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 13, 12, 55, 15, 270, DateTimeKind.Utc).AddTicks(945));

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 13, 12, 55, 15, 270, DateTimeKind.Utc).AddTicks(946));

            migrationBuilder.UpdateData(
                table: "CartItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddedAt",
                value: new DateTime(2026, 2, 13, 12, 55, 15, 270, DateTimeKind.Utc).AddTicks(1035));

            migrationBuilder.UpdateData(
                table: "CartItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "AddedAt",
                value: new DateTime(2026, 2, 13, 12, 55, 15, 270, DateTimeKind.Utc).AddTicks(1037));

            migrationBuilder.UpdateData(
                table: "Carts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 13, 12, 55, 15, 270, DateTimeKind.Utc).AddTicks(1016));

            migrationBuilder.UpdateData(
                table: "Carts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 13, 12, 55, 15, 270, DateTimeKind.Utc).AddTicks(1018));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 13, 12, 55, 15, 270, DateTimeKind.Utc).AddTicks(615));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 13, 12, 55, 15, 270, DateTimeKind.Utc).AddTicks(617));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 13, 12, 55, 15, 270, DateTimeKind.Utc).AddTicks(622));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 13, 12, 55, 15, 270, DateTimeKind.Utc).AddTicks(623));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                column: "OrderDate",
                value: new DateTime(2026, 2, 13, 12, 55, 15, 270, DateTimeKind.Utc).AddTicks(1053));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                column: "OrderDate",
                value: new DateTime(2026, 2, 13, 12, 55, 15, 270, DateTimeKind.Utc).AddTicks(1057));

            migrationBuilder.UpdateData(
                table: "ProductReviews",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 13, 12, 55, 15, 270, DateTimeKind.Utc).AddTicks(994));

            migrationBuilder.UpdateData(
                table: "ProductReviews",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 13, 12, 55, 15, 270, DateTimeKind.Utc).AddTicks(996));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 13, 12, 55, 15, 270, DateTimeKind.Utc).AddTicks(734));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 13, 12, 55, 15, 270, DateTimeKind.Utc).AddTicks(736));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 13, 12, 55, 15, 270, DateTimeKind.Utc).AddTicks(838));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 13, 12, 55, 15, 270, DateTimeKind.Utc).AddTicks(843));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 13, 12, 55, 15, 270, DateTimeKind.Utc).AddTicks(846));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 13, 12, 55, 15, 270, DateTimeKind.Utc).AddTicks(849));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 13, 12, 55, 15, 270, DateTimeKind.Utc).AddTicks(852));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 13, 12, 55, 15, 270, DateTimeKind.Utc).AddTicks(854));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 13, 12, 55, 15, 270, DateTimeKind.Utc).AddTicks(857));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 13, 12, 55, 15, 270, DateTimeKind.Utc).AddTicks(860));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 13, 12, 55, 15, 270, DateTimeKind.Utc).AddTicks(904));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 13, 12, 55, 15, 270, DateTimeKind.Utc).AddTicks(907));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 13, 12, 55, 15, 270, DateTimeKind.Utc).AddTicks(780));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 13, 12, 55, 15, 270, DateTimeKind.Utc).AddTicks(781));

            migrationBuilder.UpdateData(
                table: "UnitsOfMeasure",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 13, 12, 55, 15, 270, DateTimeKind.Utc).AddTicks(758));

            migrationBuilder.UpdateData(
                table: "UnitsOfMeasure",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 13, 12, 55, 15, 270, DateTimeKind.Utc).AddTicks(759));

            migrationBuilder.UpdateData(
                table: "UserActivityBrojIndeksa",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AssignedAt", "CompletedAt", "NumberOfPoints", "RewardedAt" },
                values: new object[] { new DateTime(2026, 2, 13, 12, 55, 15, 270, DateTimeKind.Utc).AddTicks(1154), new DateTime(2026, 2, 20, 12, 55, 15, 270, DateTimeKind.Utc).AddTicks(1155), 0, new DateTime(2026, 2, 20, 12, 55, 15, 270, DateTimeKind.Utc).AddTicks(1158) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateAssigned",
                value: new DateTime(2026, 2, 13, 12, 55, 15, 270, DateTimeKind.Utc).AddTicks(1092));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateAssigned",
                value: new DateTime(2026, 2, 13, 12, 55, 15, 270, DateTimeKind.Utc).AddTicks(1093));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 13, 12, 55, 15, 270, DateTimeKind.Utc).AddTicks(807));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 13, 12, 55, 15, 270, DateTimeKind.Utc).AddTicks(809));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NumberOfPoints",
                table: "UserActivityBrojIndeksa");

            migrationBuilder.UpdateData(
                table: "ActivityBrojIndeksa",
                keyColumn: "Id",
                keyValue: 1,
                column: "DueDate",
                value: new DateTime(2026, 2, 22, 19, 34, 50, 221, DateTimeKind.Utc).AddTicks(8561));

            migrationBuilder.UpdateData(
                table: "ActivityBrojIndeksa",
                keyColumn: "Id",
                keyValue: 2,
                column: "DueDate",
                value: new DateTime(2026, 2, 27, 19, 34, 50, 221, DateTimeKind.Utc).AddTicks(8566));

            migrationBuilder.UpdateData(
                table: "ActivityBrojIndeksa",
                keyColumn: "Id",
                keyValue: 3,
                column: "DueDate",
                value: new DateTime(2026, 3, 4, 19, 34, 50, 221, DateTimeKind.Utc).AddTicks(8568));

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 12, 19, 34, 50, 221, DateTimeKind.Utc).AddTicks(8343));

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 12, 19, 34, 50, 221, DateTimeKind.Utc).AddTicks(8345));

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 12, 19, 34, 50, 221, DateTimeKind.Utc).AddTicks(8346));

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 12, 19, 34, 50, 221, DateTimeKind.Utc).AddTicks(8347));

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 12, 19, 34, 50, 221, DateTimeKind.Utc).AddTicks(8348));

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 12, 19, 34, 50, 221, DateTimeKind.Utc).AddTicks(8349));

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 12, 19, 34, 50, 221, DateTimeKind.Utc).AddTicks(8350));

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 12, 19, 34, 50, 221, DateTimeKind.Utc).AddTicks(8351));

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 12, 19, 34, 50, 221, DateTimeKind.Utc).AddTicks(8352));

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 12, 19, 34, 50, 221, DateTimeKind.Utc).AddTicks(8354));

            migrationBuilder.UpdateData(
                table: "CartItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddedAt",
                value: new DateTime(2026, 2, 12, 19, 34, 50, 221, DateTimeKind.Utc).AddTicks(8481));

            migrationBuilder.UpdateData(
                table: "CartItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "AddedAt",
                value: new DateTime(2026, 2, 12, 19, 34, 50, 221, DateTimeKind.Utc).AddTicks(8482));

            migrationBuilder.UpdateData(
                table: "Carts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 12, 19, 34, 50, 221, DateTimeKind.Utc).AddTicks(8462));

            migrationBuilder.UpdateData(
                table: "Carts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 12, 19, 34, 50, 221, DateTimeKind.Utc).AddTicks(8463));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 12, 19, 34, 50, 221, DateTimeKind.Utc).AddTicks(7989));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 12, 19, 34, 50, 221, DateTimeKind.Utc).AddTicks(7992));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 12, 19, 34, 50, 221, DateTimeKind.Utc).AddTicks(7995));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 12, 19, 34, 50, 221, DateTimeKind.Utc).AddTicks(7996));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                column: "OrderDate",
                value: new DateTime(2026, 2, 12, 19, 34, 50, 221, DateTimeKind.Utc).AddTicks(8500));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                column: "OrderDate",
                value: new DateTime(2026, 2, 12, 19, 34, 50, 221, DateTimeKind.Utc).AddTicks(8504));

            migrationBuilder.UpdateData(
                table: "ProductReviews",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 12, 19, 34, 50, 221, DateTimeKind.Utc).AddTicks(8439));

            migrationBuilder.UpdateData(
                table: "ProductReviews",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 12, 19, 34, 50, 221, DateTimeKind.Utc).AddTicks(8442));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 12, 19, 34, 50, 221, DateTimeKind.Utc).AddTicks(8110));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 12, 19, 34, 50, 221, DateTimeKind.Utc).AddTicks(8111));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 12, 19, 34, 50, 221, DateTimeKind.Utc).AddTicks(8287));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 12, 19, 34, 50, 221, DateTimeKind.Utc).AddTicks(8292));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 12, 19, 34, 50, 221, DateTimeKind.Utc).AddTicks(8295));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 12, 19, 34, 50, 221, DateTimeKind.Utc).AddTicks(8298));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 12, 19, 34, 50, 221, DateTimeKind.Utc).AddTicks(8300));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 12, 19, 34, 50, 221, DateTimeKind.Utc).AddTicks(8303));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 12, 19, 34, 50, 221, DateTimeKind.Utc).AddTicks(8305));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 12, 19, 34, 50, 221, DateTimeKind.Utc).AddTicks(8308));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 12, 19, 34, 50, 221, DateTimeKind.Utc).AddTicks(8310));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 12, 19, 34, 50, 221, DateTimeKind.Utc).AddTicks(8313));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 12, 19, 34, 50, 221, DateTimeKind.Utc).AddTicks(8227));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 12, 19, 34, 50, 221, DateTimeKind.Utc).AddTicks(8229));

            migrationBuilder.UpdateData(
                table: "UnitsOfMeasure",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 12, 19, 34, 50, 221, DateTimeKind.Utc).AddTicks(8203));

            migrationBuilder.UpdateData(
                table: "UnitsOfMeasure",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 12, 19, 34, 50, 221, DateTimeKind.Utc).AddTicks(8206));

            migrationBuilder.UpdateData(
                table: "UserActivityBrojIndeksa",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AssignedAt", "CompletedAt", "RewardedAt" },
                values: new object[] { new DateTime(2026, 2, 12, 19, 34, 50, 221, DateTimeKind.Utc).AddTicks(8603), new DateTime(2026, 2, 19, 19, 34, 50, 221, DateTimeKind.Utc).AddTicks(8604), new DateTime(2026, 2, 19, 19, 34, 50, 221, DateTimeKind.Utc).AddTicks(8608) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateAssigned",
                value: new DateTime(2026, 2, 12, 19, 34, 50, 221, DateTimeKind.Utc).AddTicks(8543));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateAssigned",
                value: new DateTime(2026, 2, 12, 19, 34, 50, 221, DateTimeKind.Utc).AddTicks(8544));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 12, 19, 34, 50, 221, DateTimeKind.Utc).AddTicks(8252));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 12, 19, 34, 50, 221, DateTimeKind.Utc).AddTicks(8254));
        }
    }
}
