using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AlorTest.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DownloadedFiles",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FileName = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    FileType = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Files__3213E83F9A72F920", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Entities",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DataId = table.Column<int>(type: "int", nullable: false),
                    VersionNum = table.Column<int>(type: "int", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UnListType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ReferenceNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ListedOn = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NameOriginalScript = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Comments1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SortKey = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SortKeyLastMod = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Entities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Individuals",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DataId = table.Column<int>(type: "int", nullable: false),
                    VersionNum = table.Column<int>(type: "int", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SecondName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ThirdName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FourthName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UnListType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ReferenceNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ListedOn = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NameOriginalScript = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Comments1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SortKey = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SortKeyLastMod = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Individuals", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DownloadedFiles");

            migrationBuilder.DropTable(
                name: "Entities");

            migrationBuilder.DropTable(
                name: "Individuals");
        }
    }
}
