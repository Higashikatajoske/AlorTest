using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AlorTest.Migrations
{
    /// <inheritdoc />
    public partial class RenameIndividualDesignationTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "IndividualDesignation",
                columns: table => new
                {
                    IndividualId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IndividualDesignation", x => new { x.IndividualId, x.Description });
                    table.ForeignKey(
                        name: "FK_IndividualDesignation_Individuals_IndividualId",
                        column: x => x.IndividualId,
                        principalTable: "Individuals",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "IndividualDesignation");
        }
    }
}
