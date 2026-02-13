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
                name: "ActivityBrojIndeksa",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DueDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ActivityBrojIndeksa", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RewardRuleBrojIndeksa",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ActivityBrojIndeksaId = table.Column<int>(type: "int", nullable: false),
                    RewardTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MaxDaysToComplete = table.Column<int>(type: "int", nullable: false),
                    NumberOfPoints = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RewardRuleBrojIndeksa", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RewardRuleBrojIndeksa_ActivityBrojIndeksa_ActivityBrojIndeksaId",
                        column: x => x.ActivityBrojIndeksaId,
                        principalTable: "ActivityBrojIndeksa",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "UserActivityBrojIndeksa",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    ActivityBrojIndeksaId = table.Column<int>(type: "int", nullable: false),
                    AssignedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompletedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RewardTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RewardedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserActivityBrojIndeksa", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserActivityBrojIndeksa_ActivityBrojIndeksa_ActivityBrojIndeksaId",
                        column: x => x.ActivityBrojIndeksaId,
                        principalTable: "ActivityBrojIndeksa",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_UserActivityBrojIndeksa_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "ActivityBrojIndeksa",
                columns: new[] { "Id", "Description", "DueDate", "Name" },
                values: new object[,]
                {
                    { 1, "Odabrati datum i vrijeme sastanka", new DateTime(2026, 2, 22, 17, 20, 7, 561, DateTimeKind.Utc).AddTicks(9636), "Organizacija sastanka" },
                    { 2, "Pripremiti sve podatke i prezentovati", new DateTime(2026, 2, 27, 17, 20, 7, 561, DateTimeKind.Utc).AddTicks(9640), "Izrada prezentacije" },
                    { 3, "Zavrsna analiza troskova i zarade projekta", new DateTime(2026, 3, 4, 17, 20, 7, 561, DateTimeKind.Utc).AddTicks(9641), "Analiza projekta" }
                });

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

            migrationBuilder.InsertData(
                table: "RewardRuleBrojIndeksa",
                columns: new[] { "Id", "ActivityBrojIndeksaId", "MaxDaysToComplete", "NumberOfPoints", "RewardTitle" },
                values: new object[,]
                {
                    { 1, 1, 10, 10, "Organizator!" },
                    { 2, 2, 15, 15, "Prezenter!" },
                    { 3, 3, 20, 20, "Analiticar!" }
                });

            migrationBuilder.InsertData(
                table: "UserActivityBrojIndeksa",
                columns: new[] { "Id", "ActivityBrojIndeksaId", "AssignedAt", "CompletedAt", "Note", "RewardTitle", "RewardedAt", "Status", "UserId" },
                values: new object[] { 1, 1, new DateTime(2026, 2, 12, 17, 20, 7, 561, DateTimeKind.Utc).AddTicks(9676), new DateTime(2026, 2, 19, 17, 20, 7, 561, DateTimeKind.Utc).AddTicks(9677), "Done", "Organizator!", new DateTime(2026, 2, 19, 17, 20, 7, 561, DateTimeKind.Utc).AddTicks(9678), "Completed", 1 });

            migrationBuilder.CreateIndex(
                name: "IX_RewardRuleBrojIndeksa_ActivityBrojIndeksaId",
                table: "RewardRuleBrojIndeksa",
                column: "ActivityBrojIndeksaId");

            migrationBuilder.CreateIndex(
                name: "IX_UserActivityBrojIndeksa_ActivityBrojIndeksaId",
                table: "UserActivityBrojIndeksa",
                column: "ActivityBrojIndeksaId");

            migrationBuilder.CreateIndex(
                name: "IX_UserActivityBrojIndeksa_UserId",
                table: "UserActivityBrojIndeksa",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RewardRuleBrojIndeksa");

            migrationBuilder.DropTable(
                name: "UserActivityBrojIndeksa");

            migrationBuilder.DropTable(
                name: "ActivityBrojIndeksa");

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 12, 15, 39, 11, 611, DateTimeKind.Utc).AddTicks(3094));

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 12, 15, 39, 11, 611, DateTimeKind.Utc).AddTicks(3096));

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 12, 15, 39, 11, 611, DateTimeKind.Utc).AddTicks(3097));

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 12, 15, 39, 11, 611, DateTimeKind.Utc).AddTicks(3099));

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 12, 15, 39, 11, 611, DateTimeKind.Utc).AddTicks(3100));

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 12, 15, 39, 11, 611, DateTimeKind.Utc).AddTicks(3101));

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 12, 15, 39, 11, 611, DateTimeKind.Utc).AddTicks(3102));

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 12, 15, 39, 11, 611, DateTimeKind.Utc).AddTicks(3103));

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 12, 15, 39, 11, 611, DateTimeKind.Utc).AddTicks(3104));

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 12, 15, 39, 11, 611, DateTimeKind.Utc).AddTicks(3105));

            migrationBuilder.UpdateData(
                table: "CartItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddedAt",
                value: new DateTime(2026, 2, 12, 15, 39, 11, 611, DateTimeKind.Utc).AddTicks(3197));

            migrationBuilder.UpdateData(
                table: "CartItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "AddedAt",
                value: new DateTime(2026, 2, 12, 15, 39, 11, 611, DateTimeKind.Utc).AddTicks(3199));

            migrationBuilder.UpdateData(
                table: "Carts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 12, 15, 39, 11, 611, DateTimeKind.Utc).AddTicks(3174));

            migrationBuilder.UpdateData(
                table: "Carts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 12, 15, 39, 11, 611, DateTimeKind.Utc).AddTicks(3177));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 12, 15, 39, 11, 611, DateTimeKind.Utc).AddTicks(2792));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 12, 15, 39, 11, 611, DateTimeKind.Utc).AddTicks(2795));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 12, 15, 39, 11, 611, DateTimeKind.Utc).AddTicks(2797));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 12, 15, 39, 11, 611, DateTimeKind.Utc).AddTicks(2799));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                column: "OrderDate",
                value: new DateTime(2026, 2, 12, 15, 39, 11, 611, DateTimeKind.Utc).AddTicks(3217));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                column: "OrderDate",
                value: new DateTime(2026, 2, 12, 15, 39, 11, 611, DateTimeKind.Utc).AddTicks(3221));

            migrationBuilder.UpdateData(
                table: "ProductReviews",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 12, 15, 39, 11, 611, DateTimeKind.Utc).AddTicks(3156));

            migrationBuilder.UpdateData(
                table: "ProductReviews",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 12, 15, 39, 11, 611, DateTimeKind.Utc).AddTicks(3158));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 12, 15, 39, 11, 611, DateTimeKind.Utc).AddTicks(2925));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 12, 15, 39, 11, 611, DateTimeKind.Utc).AddTicks(2927));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 12, 15, 39, 11, 611, DateTimeKind.Utc).AddTicks(3021));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 12, 15, 39, 11, 611, DateTimeKind.Utc).AddTicks(3025));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 12, 15, 39, 11, 611, DateTimeKind.Utc).AddTicks(3028));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 12, 15, 39, 11, 611, DateTimeKind.Utc).AddTicks(3031));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 12, 15, 39, 11, 611, DateTimeKind.Utc).AddTicks(3034));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 12, 15, 39, 11, 611, DateTimeKind.Utc).AddTicks(3037));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 12, 15, 39, 11, 611, DateTimeKind.Utc).AddTicks(3039));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 12, 15, 39, 11, 611, DateTimeKind.Utc).AddTicks(3042));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 12, 15, 39, 11, 611, DateTimeKind.Utc).AddTicks(3063));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 12, 15, 39, 11, 611, DateTimeKind.Utc).AddTicks(3066));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 12, 15, 39, 11, 611, DateTimeKind.Utc).AddTicks(2970));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 12, 15, 39, 11, 611, DateTimeKind.Utc).AddTicks(2972));

            migrationBuilder.UpdateData(
                table: "UnitsOfMeasure",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 12, 15, 39, 11, 611, DateTimeKind.Utc).AddTicks(2948));

            migrationBuilder.UpdateData(
                table: "UnitsOfMeasure",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 12, 15, 39, 11, 611, DateTimeKind.Utc).AddTicks(2951));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateAssigned",
                value: new DateTime(2026, 2, 12, 15, 39, 11, 611, DateTimeKind.Utc).AddTicks(3253));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateAssigned",
                value: new DateTime(2026, 2, 12, 15, 39, 11, 611, DateTimeKind.Utc).AddTicks(3255));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 12, 15, 39, 11, 611, DateTimeKind.Utc).AddTicks(2993));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 12, 15, 39, 11, 611, DateTimeKind.Utc).AddTicks(2995));
        }
    }
}
