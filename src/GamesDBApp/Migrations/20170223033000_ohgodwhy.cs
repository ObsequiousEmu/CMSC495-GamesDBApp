using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GamesDBApp.Migrations
{
    public partial class ohgodwhy : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Game",
                columns: table => new
                {
                    GameId = table.Column<int>(nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    Developer = table.Column<string>(maxLength: 100, nullable: false),
                    Genre = table.Column<string>(maxLength: 100, nullable: false),
                    Platform = table.Column<string>(maxLength: 100, nullable: false),
                    Rating = table.Column<double>(nullable: false),
                    ReleaseDate = table.Column<DateTime>(nullable: false),
                    Title = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Game", x => x.GameId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Game");
        }
    }
}
