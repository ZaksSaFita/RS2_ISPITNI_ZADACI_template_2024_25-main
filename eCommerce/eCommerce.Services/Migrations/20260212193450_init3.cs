using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace eCommerce.Services.Migrations
{
    /// <inheritdoc />
    public partial class init3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "RewardedAt",
                table: "UserActivityBrojIndeksa",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CompletedAt",
                table: "UserActivityBrojIndeksa",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "RewardedAt",
                table: "UserActivityBrojIndeksa",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CompletedAt",
                table: "UserActivityBrojIndeksa",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "ActivityBrojIndeksa",
                keyColumn: "Id",
                keyValue: 1,
                column: "DueDate",
                value: new DateTime(2026, 2, 22, 17, 20, 7, 561, DateTimeKind.Utc).AddTicks(9636));

            migrationBuilder.UpdateData(
                table: "ActivityBrojIndeksa",
                keyColumn: "Id",
                keyValue: 2,
                column: "DueDate",
                value: new DateTime(2026, 2, 27, 17, 20, 7, 561, DateTimeKind.Utc).AddTicks(9640));

            migrationBuilder.UpdateData(
                table: "ActivityBrojIndeksa",
                keyColumn: "Id",
                keyValue: 3,
                column: "DueDate",
                value: new DateTime(2026, 3, 4, 17, 20, 7, 561, DateTimeKind.Utc).AddTicks(9641));

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 12, 17, 20, 7, 561, DateTimeKind.Utc).AddTicks(9420));

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 12, 17, 20, 7, 561, DateTimeKind.Utc).AddTicks(9424));

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 12, 17, 20, 7, 561, DateTimeKind.Utc).AddTicks(9425));

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 12, 17, 20, 7, 561, DateTimeKind.Utc).AddTicks(9426));

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 12, 17, 20, 7, 561, DateTimeKind.Utc).AddTicks(9427));

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 12, 17, 20, 7, 561, DateTimeKind.Utc).AddTicks(9429));

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 12, 17, 20, 7, 561, DateTimeKind.Utc).AddTicks(9430));

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 12, 17, 20, 7, 561, DateTimeKind.Utc).AddTicks(9431));

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 12, 17, 20, 7, 561, DateTimeKind.Utc).AddTicks(9432));

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 12, 17, 20, 7, 561, DateTimeKind.Utc).AddTicks(9433));

            migrationBuilder.UpdateData(
                table: "CartItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddedAt",
                value: new DateTime(2026, 2, 12, 17, 20, 7, 561, DateTimeKind.Utc).AddTicks(9558));

            migrationBuilder.UpdateData(
                table: "CartItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "AddedAt",
                value: new DateTime(2026, 2, 12, 17, 20, 7, 561, DateTimeKind.Utc).AddTicks(9560));

            migrationBuilder.UpdateData(
                table: "Carts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 12, 17, 20, 7, 561, DateTimeKind.Utc).AddTicks(9535));

            migrationBuilder.UpdateData(
                table: "Carts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 12, 17, 20, 7, 561, DateTimeKind.Utc).AddTicks(9536));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 12, 17, 20, 7, 561, DateTimeKind.Utc).AddTicks(9098));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 12, 17, 20, 7, 561, DateTimeKind.Utc).AddTicks(9101));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 12, 17, 20, 7, 561, DateTimeKind.Utc).AddTicks(9103));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 12, 17, 20, 7, 561, DateTimeKind.Utc).AddTicks(9105));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                column: "OrderDate",
                value: new DateTime(2026, 2, 12, 17, 20, 7, 561, DateTimeKind.Utc).AddTicks(9576));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                column: "OrderDate",
                value: new DateTime(2026, 2, 12, 17, 20, 7, 561, DateTimeKind.Utc).AddTicks(9579));

            migrationBuilder.UpdateData(
                table: "ProductReviews",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 12, 17, 20, 7, 561, DateTimeKind.Utc).AddTicks(9510));

            migrationBuilder.UpdateData(
                table: "ProductReviews",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 12, 17, 20, 7, 561, DateTimeKind.Utc).AddTicks(9514));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 12, 17, 20, 7, 561, DateTimeKind.Utc).AddTicks(9213));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 12, 17, 20, 7, 561, DateTimeKind.Utc).AddTicks(9220));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 12, 17, 20, 7, 561, DateTimeKind.Utc).AddTicks(9365));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 12, 17, 20, 7, 561, DateTimeKind.Utc).AddTicks(9369));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 12, 17, 20, 7, 561, DateTimeKind.Utc).AddTicks(9372));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 12, 17, 20, 7, 561, DateTimeKind.Utc).AddTicks(9375));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 12, 17, 20, 7, 561, DateTimeKind.Utc).AddTicks(9378));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 12, 17, 20, 7, 561, DateTimeKind.Utc).AddTicks(9381));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 12, 17, 20, 7, 561, DateTimeKind.Utc).AddTicks(9383));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 12, 17, 20, 7, 561, DateTimeKind.Utc).AddTicks(9386));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 12, 17, 20, 7, 561, DateTimeKind.Utc).AddTicks(9388));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 12, 17, 20, 7, 561, DateTimeKind.Utc).AddTicks(9391));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 12, 17, 20, 7, 561, DateTimeKind.Utc).AddTicks(9307));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 12, 17, 20, 7, 561, DateTimeKind.Utc).AddTicks(9309));

            migrationBuilder.UpdateData(
                table: "UnitsOfMeasure",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 12, 17, 20, 7, 561, DateTimeKind.Utc).AddTicks(9284));

            migrationBuilder.UpdateData(
                table: "UnitsOfMeasure",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 12, 17, 20, 7, 561, DateTimeKind.Utc).AddTicks(9286));

            migrationBuilder.UpdateData(
                table: "UserActivityBrojIndeksa",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AssignedAt", "CompletedAt", "RewardedAt" },
                values: new object[] { new DateTime(2026, 2, 12, 17, 20, 7, 561, DateTimeKind.Utc).AddTicks(9676), new DateTime(2026, 2, 19, 17, 20, 7, 561, DateTimeKind.Utc).AddTicks(9677), new DateTime(2026, 2, 19, 17, 20, 7, 561, DateTimeKind.Utc).AddTicks(9678) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateAssigned",
                value: new DateTime(2026, 2, 12, 17, 20, 7, 561, DateTimeKind.Utc).AddTicks(9619));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateAssigned",
                value: new DateTime(2026, 2, 12, 17, 20, 7, 561, DateTimeKind.Utc).AddTicks(9620));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 12, 17, 20, 7, 561, DateTimeKind.Utc).AddTicks(9333));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 12, 17, 20, 7, 561, DateTimeKind.Utc).AddTicks(9335));
        }
    }
}
