using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace back_end_ecom_api.Migrations
{
    public partial class DbInit03 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "is_delete",
                table: "user");

            migrationBuilder.DropColumn(
                name: "is_delete",
                table: "size");

            migrationBuilder.DropColumn(
                name: "is_delete",
                table: "product_file");

            migrationBuilder.DropColumn(
                name: "is_delete",
                table: "product");

            migrationBuilder.DropColumn(
                name: "is_delete",
                table: "logo");

            migrationBuilder.DropColumn(
                name: "is_delete",
                table: "category_product ");

            migrationBuilder.DropColumn(
                name: "is_delete",
                table: "banner");

            migrationBuilder.DropColumn(
                name: "is_delete",
                table: "admin_user");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "is_delete",
                table: "user",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "is_delete",
                table: "size",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "is_delete",
                table: "product_file",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "is_delete",
                table: "product",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "is_delete",
                table: "logo",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "is_delete",
                table: "category_product ",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "is_delete",
                table: "banner",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "is_delete",
                table: "admin_user",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }
    }
}
