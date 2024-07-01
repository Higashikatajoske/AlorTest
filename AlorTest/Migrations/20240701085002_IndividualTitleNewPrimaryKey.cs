using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AlorTest.Migrations
{
    /// <inheritdoc />
    public partial class IndividualTitleNewPrimaryKey : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_IndividualTitles",
                table: "IndividualTitles");

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "IndividualTitles",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<Guid>(
                name: "Id",
                table: "IndividualTitles",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddPrimaryKey(
                name: "PK_IndividualTitles",
                table: "IndividualTitles",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_IndividualTitles",
                table: "IndividualTitles");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "IndividualTitles");

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "IndividualTitles",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_IndividualTitles",
                table: "IndividualTitles",
                columns: new[] { "Title", "IndividualId" });
        }
    }
}
