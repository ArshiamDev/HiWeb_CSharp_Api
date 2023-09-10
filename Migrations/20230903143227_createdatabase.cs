using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HiWebAPI.Migrations
{
    /// <inheritdoc />
    public partial class createdatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "gifts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    lastGiftTimeString = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    lastGiftTimeDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    totalNet = table.Column<int>(type: "int", nullable: false),
                    remainNet = table.Column<int>(type: "int", nullable: false),
                    giftNet = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_gifts", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "gifts");
        }
    }
}
