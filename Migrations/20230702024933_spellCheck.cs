using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IWantApp.Migrations
{
    /// <inheritdoc />
    public partial class spellCheck : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CraetedBy",
                table: "Products",
                newName: "CreatedBy");

            migrationBuilder.RenameColumn(
                name: "CraetedBy",
                table: "Categories",
                newName: "CreatedBy");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CreatedBy",
                table: "Products",
                newName: "CraetedBy");

            migrationBuilder.RenameColumn(
                name: "CreatedBy",
                table: "Categories",
                newName: "CraetedBy");
        }
    }
}
