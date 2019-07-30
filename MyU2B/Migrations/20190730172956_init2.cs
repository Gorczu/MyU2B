using Microsoft.EntityFrameworkCore.Migrations;

namespace MyU2B.Migrations
{
    public partial class init2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MyProperty_AspNetUsers_OwnerId",
                table: "MyProperty");

            migrationBuilder.DropForeignKey(
                name: "FK_MyProperty_Playlists_PlaylistId",
                table: "MyProperty");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MyProperty",
                table: "MyProperty");

            migrationBuilder.RenameTable(
                name: "MyProperty",
                newName: "Items");

            migrationBuilder.RenameIndex(
                name: "IX_MyProperty_PlaylistId",
                table: "Items",
                newName: "IX_Items_PlaylistId");

            migrationBuilder.RenameIndex(
                name: "IX_MyProperty_OwnerId",
                table: "Items",
                newName: "IX_Items_OwnerId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Items",
                table: "Items",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Items_AspNetUsers_OwnerId",
                table: "Items",
                column: "OwnerId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Items_Playlists_PlaylistId",
                table: "Items",
                column: "PlaylistId",
                principalTable: "Playlists",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Items_AspNetUsers_OwnerId",
                table: "Items");

            migrationBuilder.DropForeignKey(
                name: "FK_Items_Playlists_PlaylistId",
                table: "Items");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Items",
                table: "Items");

            migrationBuilder.RenameTable(
                name: "Items",
                newName: "MyProperty");

            migrationBuilder.RenameIndex(
                name: "IX_Items_PlaylistId",
                table: "MyProperty",
                newName: "IX_MyProperty_PlaylistId");

            migrationBuilder.RenameIndex(
                name: "IX_Items_OwnerId",
                table: "MyProperty",
                newName: "IX_MyProperty_OwnerId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MyProperty",
                table: "MyProperty",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_MyProperty_AspNetUsers_OwnerId",
                table: "MyProperty",
                column: "OwnerId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MyProperty_Playlists_PlaylistId",
                table: "MyProperty",
                column: "PlaylistId",
                principalTable: "Playlists",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
