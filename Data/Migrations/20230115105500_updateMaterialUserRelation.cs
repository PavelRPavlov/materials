using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Materials.Data.Migrations
{
    /// <inheritdoc />
    public partial class updateMaterialUserRelation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Materials_User_OwnerId",
                table: "Materials");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropIndex(
                name: "IX_Materials_OwnerId",
                table: "Materials");

            migrationBuilder.AddColumn<string>(
                name: "OwnerId1",
                table: "Materials",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Materials_OwnerId1",
                table: "Materials",
                column: "OwnerId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Materials_AspNetUsers_OwnerId1",
                table: "Materials",
                column: "OwnerId1",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Materials_AspNetUsers_OwnerId1",
                table: "Materials");

            migrationBuilder.DropIndex(
                name: "IX_Materials_OwnerId1",
                table: "Materials");

            migrationBuilder.DropColumn(
                name: "OwnerId1",
                table: "Materials");

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Contact = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Materials_OwnerId",
                table: "Materials",
                column: "OwnerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Materials_User_OwnerId",
                table: "Materials",
                column: "OwnerId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
