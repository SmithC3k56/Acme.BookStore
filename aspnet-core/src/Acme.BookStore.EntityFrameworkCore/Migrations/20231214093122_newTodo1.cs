using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Acme.BookStore.Migrations
{
    /// <inheritdoc />
    public partial class newTodo1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AppBooks_AppCategories_CategoryID",
                table: "AppBooks");

            migrationBuilder.DropIndex(
                name: "IX_AppBooks_CategoryID",
                table: "AppBooks");

            migrationBuilder.DropColumn(
                name: "CategoryID",
                table: "AppBooks");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "CategoryID",
                table: "AppBooks",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_AppBooks_CategoryID",
                table: "AppBooks",
                column: "CategoryID");

            migrationBuilder.AddForeignKey(
                name: "FK_AppBooks_AppCategories_CategoryID",
                table: "AppBooks",
                column: "CategoryID",
                principalTable: "AppCategories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
