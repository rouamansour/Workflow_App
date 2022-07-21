using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    public partial class UpdateRequest : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_User_Request",
                table: "User_Request");

            migrationBuilder.RenameTable(
                name: "User_Request",
                newName: "UserRequest");

            migrationBuilder.RenameIndex(
                name: "IX_User_Request_RequestId",
                table: "UserRequest",
                newName: "IX_UserRequest_RequestId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserRequest",
                table: "UserRequest",
                columns: new[] { "UserId", "RequestId" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_UserRequest",
                table: "UserRequest");

            migrationBuilder.RenameTable(
                name: "UserRequest",
                newName: "User_Request");

            migrationBuilder.RenameIndex(
                name: "IX_UserRequest_RequestId",
                table: "User_Request",
                newName: "IX_User_Request_RequestId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_User_Request",
                table: "User_Request",
                columns: new[] { "UserId", "RequestId" });
        }
    }
}
