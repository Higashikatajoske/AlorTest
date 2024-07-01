using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AlorTest.Migrations
{
    /// <inheritdoc />
    public partial class IndividualTitleCreateTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "IndividualTitles",
                columns: table => new
                {
                    IndividualId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IndividualTitles", x => new { x.Title, x.IndividualId });
                    table.ForeignKey(
                        name: "FK_IndividualTitles_Individuals_IndividualId",
                        column: x => x.IndividualId,
                        principalTable: "Individuals",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_IndividualTitles_IndividualId",
                table: "IndividualTitles",
                column: "IndividualId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "IndividualTitles");
        }
    }
}
