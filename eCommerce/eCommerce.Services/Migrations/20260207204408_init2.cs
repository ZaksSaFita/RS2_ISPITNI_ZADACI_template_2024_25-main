using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace eCommerce.Services.Migrations
{
    /// <inheritdoc />
    public partial class init2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FavoriteBrojIndeksas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FavoriteBrojIndeksas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FavoriteBrojIndeksas_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FavoriteBrojIndeksas_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 7, 20, 44, 8, 22, DateTimeKind.Utc).AddTicks(8502));

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 7, 20, 44, 8, 22, DateTimeKind.Utc).AddTicks(8505));

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 7, 20, 44, 8, 22, DateTimeKind.Utc).AddTicks(8506));

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 7, 20, 44, 8, 22, DateTimeKind.Utc).AddTicks(8507));

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 7, 20, 44, 8, 22, DateTimeKind.Utc).AddTicks(8508));

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 7, 20, 44, 8, 22, DateTimeKind.Utc).AddTicks(8509));

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 7, 20, 44, 8, 22, DateTimeKind.Utc).AddTicks(8510));

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 7, 20, 44, 8, 22, DateTimeKind.Utc).AddTicks(8552));

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 7, 20, 44, 8, 22, DateTimeKind.Utc).AddTicks(8553));

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 7, 20, 44, 8, 22, DateTimeKind.Utc).AddTicks(8554));

            migrationBuilder.UpdateData(
                table: "CartItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddedAt",
                value: new DateTime(2026, 2, 7, 20, 44, 8, 22, DateTimeKind.Utc).AddTicks(8641));

            migrationBuilder.UpdateData(
                table: "CartItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "AddedAt",
                value: new DateTime(2026, 2, 7, 20, 44, 8, 22, DateTimeKind.Utc).AddTicks(8643));

            migrationBuilder.UpdateData(
                table: "Carts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 7, 20, 44, 8, 22, DateTimeKind.Utc).AddTicks(8624));

            migrationBuilder.UpdateData(
                table: "Carts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 7, 20, 44, 8, 22, DateTimeKind.Utc).AddTicks(8625));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 7, 20, 44, 8, 22, DateTimeKind.Utc).AddTicks(8184));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 7, 20, 44, 8, 22, DateTimeKind.Utc).AddTicks(8186));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 7, 20, 44, 8, 22, DateTimeKind.Utc).AddTicks(8187));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 7, 20, 44, 8, 22, DateTimeKind.Utc).AddTicks(8189));

            migrationBuilder.InsertData(
                table: "FavoriteBrojIndeksas",
                columns: new[] { "Id", "CreatedAt", "ProductId", "UserId" },
                values: new object[,]
                {
                    { 1, new DateTime(2026, 2, 7, 20, 44, 8, 22, DateTimeKind.Utc).AddTicks(8719), 1, 2 },
                    { 2, new DateTime(2026, 2, 12, 20, 44, 8, 22, DateTimeKind.Utc).AddTicks(8720), 2, 2 },
                    { 3, new DateTime(2026, 2, 14, 20, 44, 8, 22, DateTimeKind.Utc).AddTicks(8725), 3, 2 },
                    { 4, new DateTime(2026, 2, 17, 20, 44, 8, 22, DateTimeKind.Utc).AddTicks(8726), 4, 2 }
                });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                column: "OrderDate",
                value: new DateTime(2026, 2, 7, 20, 44, 8, 22, DateTimeKind.Utc).AddTicks(8659));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                column: "OrderDate",
                value: new DateTime(2026, 2, 7, 20, 44, 8, 22, DateTimeKind.Utc).AddTicks(8662));

            migrationBuilder.UpdateData(
                table: "ProductReviews",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 7, 20, 44, 8, 22, DateTimeKind.Utc).AddTicks(8605));

            migrationBuilder.UpdateData(
                table: "ProductReviews",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 7, 20, 44, 8, 22, DateTimeKind.Utc).AddTicks(8607));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 7, 20, 44, 8, 22, DateTimeKind.Utc).AddTicks(8338));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 7, 20, 44, 8, 22, DateTimeKind.Utc).AddTicks(8340));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 7, 20, 44, 8, 22, DateTimeKind.Utc).AddTicks(8444));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 7, 20, 44, 8, 22, DateTimeKind.Utc).AddTicks(8449));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 7, 20, 44, 8, 22, DateTimeKind.Utc).AddTicks(8452));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 7, 20, 44, 8, 22, DateTimeKind.Utc).AddTicks(8455));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 7, 20, 44, 8, 22, DateTimeKind.Utc).AddTicks(8457));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 7, 20, 44, 8, 22, DateTimeKind.Utc).AddTicks(8461));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 7, 20, 44, 8, 22, DateTimeKind.Utc).AddTicks(8463));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 7, 20, 44, 8, 22, DateTimeKind.Utc).AddTicks(8466));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 7, 20, 44, 8, 22, DateTimeKind.Utc).AddTicks(8469));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 7, 20, 44, 8, 22, DateTimeKind.Utc).AddTicks(8472));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 7, 20, 44, 8, 22, DateTimeKind.Utc).AddTicks(8391));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 7, 20, 44, 8, 22, DateTimeKind.Utc).AddTicks(8392));

            migrationBuilder.UpdateData(
                table: "UnitsOfMeasure",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 7, 20, 44, 8, 22, DateTimeKind.Utc).AddTicks(8362));

            migrationBuilder.UpdateData(
                table: "UnitsOfMeasure",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 7, 20, 44, 8, 22, DateTimeKind.Utc).AddTicks(8365));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateAssigned",
                value: new DateTime(2026, 2, 7, 20, 44, 8, 22, DateTimeKind.Utc).AddTicks(8701));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateAssigned",
                value: new DateTime(2026, 2, 7, 20, 44, 8, 22, DateTimeKind.Utc).AddTicks(8702));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 7, 20, 44, 8, 22, DateTimeKind.Utc).AddTicks(8415));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 7, 20, 44, 8, 22, DateTimeKind.Utc).AddTicks(8417));

            migrationBuilder.CreateIndex(
                name: "IX_FavoriteBrojIndeksas_ProductId",
                table: "FavoriteBrojIndeksas",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_FavoriteBrojIndeksas_UserId_ProductId",
                table: "FavoriteBrojIndeksas",
                columns: new[] { "UserId", "ProductId" },
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FavoriteBrojIndeksas");

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 7, 20, 34, 1, 299, DateTimeKind.Utc).AddTicks(2785));

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 7, 20, 34, 1, 299, DateTimeKind.Utc).AddTicks(2788));

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 7, 20, 34, 1, 299, DateTimeKind.Utc).AddTicks(2789));

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 7, 20, 34, 1, 299, DateTimeKind.Utc).AddTicks(2791));

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 7, 20, 34, 1, 299, DateTimeKind.Utc).AddTicks(2792));

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 7, 20, 34, 1, 299, DateTimeKind.Utc).AddTicks(2793));

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 7, 20, 34, 1, 299, DateTimeKind.Utc).AddTicks(2794));

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 7, 20, 34, 1, 299, DateTimeKind.Utc).AddTicks(2795));

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 7, 20, 34, 1, 299, DateTimeKind.Utc).AddTicks(2796));

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 7, 20, 34, 1, 299, DateTimeKind.Utc).AddTicks(2797));

            migrationBuilder.UpdateData(
                table: "CartItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddedAt",
                value: new DateTime(2026, 2, 7, 20, 34, 1, 299, DateTimeKind.Utc).AddTicks(2887));

            migrationBuilder.UpdateData(
                table: "CartItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "AddedAt",
                value: new DateTime(2026, 2, 7, 20, 34, 1, 299, DateTimeKind.Utc).AddTicks(2888));

            migrationBuilder.UpdateData(
                table: "Carts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 7, 20, 34, 1, 299, DateTimeKind.Utc).AddTicks(2867));

            migrationBuilder.UpdateData(
                table: "Carts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 7, 20, 34, 1, 299, DateTimeKind.Utc).AddTicks(2869));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 7, 20, 34, 1, 299, DateTimeKind.Utc).AddTicks(2500));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 7, 20, 34, 1, 299, DateTimeKind.Utc).AddTicks(2502));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 7, 20, 34, 1, 299, DateTimeKind.Utc).AddTicks(2504));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 7, 20, 34, 1, 299, DateTimeKind.Utc).AddTicks(2506));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                column: "OrderDate",
                value: new DateTime(2026, 2, 7, 20, 34, 1, 299, DateTimeKind.Utc).AddTicks(2906));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                column: "OrderDate",
                value: new DateTime(2026, 2, 7, 20, 34, 1, 299, DateTimeKind.Utc).AddTicks(2910));

            migrationBuilder.UpdateData(
                table: "ProductReviews",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 7, 20, 34, 1, 299, DateTimeKind.Utc).AddTicks(2848));

            migrationBuilder.UpdateData(
                table: "ProductReviews",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 7, 20, 34, 1, 299, DateTimeKind.Utc).AddTicks(2850));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 7, 20, 34, 1, 299, DateTimeKind.Utc).AddTicks(2615));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 7, 20, 34, 1, 299, DateTimeKind.Utc).AddTicks(2617));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 7, 20, 34, 1, 299, DateTimeKind.Utc).AddTicks(2709));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 7, 20, 34, 1, 299, DateTimeKind.Utc).AddTicks(2713));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 7, 20, 34, 1, 299, DateTimeKind.Utc).AddTicks(2716));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 7, 20, 34, 1, 299, DateTimeKind.Utc).AddTicks(2719));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 7, 20, 34, 1, 299, DateTimeKind.Utc).AddTicks(2742));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 7, 20, 34, 1, 299, DateTimeKind.Utc).AddTicks(2745));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 7, 20, 34, 1, 299, DateTimeKind.Utc).AddTicks(2748));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 7, 20, 34, 1, 299, DateTimeKind.Utc).AddTicks(2750));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 7, 20, 34, 1, 299, DateTimeKind.Utc).AddTicks(2752));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 7, 20, 34, 1, 299, DateTimeKind.Utc).AddTicks(2755));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 7, 20, 34, 1, 299, DateTimeKind.Utc).AddTicks(2658));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 7, 20, 34, 1, 299, DateTimeKind.Utc).AddTicks(2659));

            migrationBuilder.UpdateData(
                table: "UnitsOfMeasure",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 7, 20, 34, 1, 299, DateTimeKind.Utc).AddTicks(2637));

            migrationBuilder.UpdateData(
                table: "UnitsOfMeasure",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 7, 20, 34, 1, 299, DateTimeKind.Utc).AddTicks(2638));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateAssigned",
                value: new DateTime(2026, 2, 7, 20, 34, 1, 299, DateTimeKind.Utc).AddTicks(2944));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateAssigned",
                value: new DateTime(2026, 2, 7, 20, 34, 1, 299, DateTimeKind.Utc).AddTicks(2945));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 7, 20, 34, 1, 299, DateTimeKind.Utc).AddTicks(2680));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 7, 20, 34, 1, 299, DateTimeKind.Utc).AddTicks(2682));
        }
    }
}
