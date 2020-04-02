using Microsoft.EntityFrameworkCore.Migrations;

namespace MessageBoardAPI.Migrations
{
    public partial class seed1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "Groups",
                columns: new[] { "GroupId", "Topic" },
                values: new object[] { 7, "Surviving COVID" });

            migrationBuilder.InsertData(
                table: "Groups",
                columns: new[] { "GroupId", "Topic" },
                values: new object[] { 8, "Cooking during COVID" });

            migrationBuilder.InsertData(
                table: "Groups",
                columns: new[] { "GroupId", "Topic" },
                values: new object[] { 9, "Gaming during COVID" });

            migrationBuilder.InsertData(
                table: "Messages",
                columns: new[] { "MessageId", "Description", "GroupId" },
                values: new object[] { 1, "How to stash water and fuel", 7 });

            migrationBuilder.InsertData(
                table: "Messages",
                columns: new[] { "MessageId", "Description", "GroupId" },
                values: new object[] { 2, "How to cook the squirrel that died in your backyard", 8 });

            migrationBuilder.InsertData(
                table: "Messages",
                columns: new[] { "MessageId", "Description", "GroupId" },
                values: new object[] { 3, "How to cheat at a puzzle", 9 });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Messages_Groups_GroupId",
                table: "Messages");

            migrationBuilder.DropIndex(
                name: "IX_Messages_GroupId",
                table: "Messages");

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "MessageId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 9);

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
    }
}
