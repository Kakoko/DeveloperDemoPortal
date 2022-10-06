using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DeveloperDemoPortal.Server.Migrations
{
    public partial class CreatedDeveloperTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Developers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Company = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Developers", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Developers",
                columns: new[] { "Id", "Company", "Email", "UserName" },
                values: new object[] { new Guid("107d0302-033a-49b8-9546-604236dd3c55"), "CodeUnparalled", "chiefscientist@code.com", "ChiefScientist" });

            migrationBuilder.InsertData(
                table: "Developers",
                columns: new[] { "Id", "Company", "Email", "UserName" },
                values: new object[] { new Guid("b8a1d4a4-f55c-42e4-b4ae-d09ef72f968f"), "Microsoft", "codefather@code.com", "CodeFather" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Developers");
        }
    }
}
