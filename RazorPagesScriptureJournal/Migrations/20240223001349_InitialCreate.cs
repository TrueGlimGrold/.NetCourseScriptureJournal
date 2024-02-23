using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RazorPagesScriptureJournal.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Scripture",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StandardWork = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    Book = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    Chapter = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    Verse = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    JounralEntry = table.Column<string>(type: "nvarchar(600)", maxLength: 600, nullable: false),
                    Keywords = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: false),
                    DateAdded = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Scripture", x => x.ID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Scripture");
        }
    }
}
