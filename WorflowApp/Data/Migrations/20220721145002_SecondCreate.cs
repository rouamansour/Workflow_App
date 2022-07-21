using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    public partial class SecondCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TypeRequestTypeId",
                table: "Requests",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "TypeRequests",
                columns: table => new
                {
                    TypeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TypeRequests", x => x.TypeId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Requests_TypeRequestTypeId",
                table: "Requests",
                column: "TypeRequestTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Requests_TypeRequests_TypeRequestTypeId",
                table: "Requests",
                column: "TypeRequestTypeId",
                principalTable: "TypeRequests",
                principalColumn: "TypeId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Requests_TypeRequests_TypeRequestTypeId",
                table: "Requests");

            migrationBuilder.DropTable(
                name: "TypeRequests");

            migrationBuilder.DropIndex(
                name: "IX_Requests_TypeRequestTypeId",
                table: "Requests");

            migrationBuilder.DropColumn(
                name: "TypeRequestTypeId",
                table: "Requests");
        }
    }
}
