using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Popcorn.DAL.Migrations
{
    /// <inheritdoc />
    public partial class _1_AddPopcornItem : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Popcorn",
                columns: table => new
                {
                    PopcornId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Popcorn", x => x.PopcornId);
                });

            migrationBuilder.InsertData(
                table: "Popcorn",
                columns: new[] { "PopcornId", "CreationDate", "Description", "Name", "UpdateDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 2, 6, 19, 51, 46, 367, DateTimeKind.Local).AddTicks(3064), "Pour les coeurs tendres", "Sucré", null },
                    { 2, new DateTime(2024, 2, 6, 19, 51, 46, 367, DateTimeKind.Local).AddTicks(3102), "Pour les autres", "Salé", null },
                    { 3, new DateTime(2024, 2, 6, 19, 51, 46, 367, DateTimeKind.Local).AddTicks(3104), "Pour les indécis", "Nature", null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Popcorn");
        }
    }
}
