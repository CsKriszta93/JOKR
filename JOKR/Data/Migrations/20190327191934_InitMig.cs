using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace JOKR.Data.Migrations
{
    public partial class InitMig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Games",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    GameName = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Rate = table.Column<float>(nullable: false),
                    Price = table.Column<decimal>(nullable: false),
                    Release = table.Column<DateTime>(nullable: false),
                    DownloadLink = table.Column<string>(nullable: true),
                    DemoLink = table.Column<string>(nullable: true),
                    NumOfDownloads = table.Column<int>(nullable: false),
                    MinSysReqId = table.Column<Guid>(nullable: false),
                    RecSysReqId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Games", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "StoreUsers",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    UserName = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Facebook = table.Column<string>(nullable: true),
                    Registration = table.Column<DateTime>(nullable: false),
                    BankAccount = table.Column<string>(nullable: true),
                    IsAdmin = table.Column<bool>(nullable: false),
                    ConfigId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StoreUsers", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Games");

            migrationBuilder.DropTable(
                name: "StoreUsers");
        }
    }
}
