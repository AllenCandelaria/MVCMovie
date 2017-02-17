using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MVCMovie.Data.Migrations
{
    public partial class rating : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Rating",
                table: "Movie",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "title",
                table: "Movie",
                nullable: false);

            migrationBuilder.RenameColumn(
                name: "title",
                table: "Movie",
                newName: "Title");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Rating",
                table: "Movie");

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Movie",
                nullable: true);

            migrationBuilder.RenameColumn(
                name: "Title",
                table: "Movie",
                newName: "title");
        }
    }
}
