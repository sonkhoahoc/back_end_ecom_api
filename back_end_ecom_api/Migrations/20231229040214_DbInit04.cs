﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace back_end_ecom_api.Migrations
{
    public partial class DbInit04 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "quantity",
                table: "product",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "quantity",
                table: "product");
        }
    }
}
