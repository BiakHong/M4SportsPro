﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SportsPro.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ReleaseDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Technicians",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Technicians", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Name", "Price", "ProductCode", "ReleaseDate" },
                values: new object[,]
                {
                    { 1, "Tourmanment Master 1.0", 4.99m, "TRYNY10", new DateTime(2018, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, "League Scheduler 1.0", 7.99m, "LEAG10", new DateTime(2019, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, "Draft Manager 1.0", 4.99m, "DRAFT10", new DateTime(2019, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, "Team Manager 1.0", 4.99m, "TEAM10", new DateTime(2020, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, "Tourmanment Master 2.0", 5.99m, "TEAM20", new DateTime(2021, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 6, "Draft Manager 2.0", 5.99m, "TRYNY10", new DateTime(2022, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Technicians",
                columns: new[] { "Id", "Email", "Name", "Phone" },
                values: new object[,]
                {
                    { 11, "alison@sportsprosoftware.com", "Alison Diaz", "800-555-0443" },
                    { 12, "jason@sportsprosoftware.com", "Jason Lee", "800-555-0444" },
                    { 13, "awilson@sportsprosoftware.com", "Andrew Wilson", "800-555-0449" },
                    { 14, "gunter@sportsprosoftware.com", "Gunter Wendt", "800-555-0400" },
                    { 15, "gfiori@sportsprosoftware.com", "Gina Fiori", "800-555-0459" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Technicians");
        }
    }
}
