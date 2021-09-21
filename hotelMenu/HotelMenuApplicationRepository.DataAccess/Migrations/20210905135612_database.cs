﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace HotelMenuApplicationRepository.DataAccess.Migrations
{
    public partial class database : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MenuTable",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DishName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DishDescription = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    VegOrNonVeg = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Category = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MenuTable", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MenuTable");
        }
    }
}
