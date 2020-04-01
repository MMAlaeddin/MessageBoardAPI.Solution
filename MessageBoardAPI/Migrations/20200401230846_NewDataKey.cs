using Microsoft.EntityFrameworkCore.Migrations;

namespace MessageBoardAPI.Migrations
{
    public partial class NewDataKey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Messages_Groups_GroupId",
                table: "Messages");

            migrationBuilder.DropIndex(
                name: "IX_Messages_GroupId",
                table: "Messages");

            migrationBuilder.AlterColumn<string>(
                name: "GroupId",
                table: "Messages",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<int>(
                name: "GroupId1",
                table: "Messages",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Messages_GroupId1",
                table: "Messages",
                column: "GroupId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Messages_Groups_GroupId1",
                table: "Messages",
                column: "GroupId1",
                principalTable: "Groups",
                principalColumn: "GroupId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Messages_Groups_GroupId1",
                table: "Messages");

            migrationBuilder.DropIndex(
                name: "IX_Messages_GroupId1",
                table: "Messages");

            migrationBuilder.DropColumn(
                name: "GroupId1",
                table: "Messages");

            migrationBuilder.AlterColumn<int>(
                name: "GroupId",
                table: "Messages",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Messages_GroupId",
                table: "Messages",
                column: "GroupId");

            migrationBuilder.AddForeignKey(
                name: "FK_Messages_Groups_GroupId",
                table: "Messages",
                column: "GroupId",
                principalTable: "Groups",
                principalColumn: "GroupId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
