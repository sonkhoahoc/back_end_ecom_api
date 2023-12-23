using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace back_end_ecom_api.Migrations
{
    public partial class DbInit02 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "isDeleted",
                table: "user",
                newName: "is_delete");

            migrationBuilder.RenameColumn(
                name: "isDeleted",
                table: "size",
                newName: "is_delete");

            migrationBuilder.RenameColumn(
                name: "isDeleted",
                table: "product_file",
                newName: "is_delete");

            migrationBuilder.RenameColumn(
                name: "isDeleted",
                table: "product",
                newName: "is_delete");

            migrationBuilder.RenameColumn(
                name: "isDeleted",
                table: "logo",
                newName: "is_delete");

            migrationBuilder.RenameColumn(
                name: "isDeleted",
                table: "category_product ",
                newName: "is_delete");

            migrationBuilder.RenameColumn(
                name: "isDeleted",
                table: "banner",
                newName: "is_delete");

            migrationBuilder.RenameColumn(
                name: "isDeleted",
                table: "admin_user",
                newName: "is_delete");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "is_delete",
                table: "user",
                newName: "isDeleted");

            migrationBuilder.RenameColumn(
                name: "is_delete",
                table: "size",
                newName: "isDeleted");

            migrationBuilder.RenameColumn(
                name: "is_delete",
                table: "product_file",
                newName: "isDeleted");

            migrationBuilder.RenameColumn(
                name: "is_delete",
                table: "product",
                newName: "isDeleted");

            migrationBuilder.RenameColumn(
                name: "is_delete",
                table: "logo",
                newName: "isDeleted");

            migrationBuilder.RenameColumn(
                name: "is_delete",
                table: "category_product ",
                newName: "isDeleted");

            migrationBuilder.RenameColumn(
                name: "is_delete",
                table: "banner",
                newName: "isDeleted");

            migrationBuilder.RenameColumn(
                name: "is_delete",
                table: "admin_user",
                newName: "isDeleted");
        }
    }
}
