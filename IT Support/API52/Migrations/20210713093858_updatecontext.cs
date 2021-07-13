using Microsoft.EntityFrameworkCore.Migrations;

namespace API52.Migrations
{
    public partial class updatecontext : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tb_M_ChatDetails_tb_M_Chats_ChatIDChat",
                table: "tb_M_ChatDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_tb_M_Chats_tb_M_Accounts_AccountNIK",
                table: "tb_M_Chats");

            migrationBuilder.DropIndex(
                name: "IX_tb_M_Chats_AccountNIK",
                table: "tb_M_Chats");

            migrationBuilder.DropIndex(
                name: "IX_tb_M_ChatDetails_ChatIDChat",
                table: "tb_M_ChatDetails");

            migrationBuilder.DropColumn(
                name: "AccountNIK",
                table: "tb_M_Chats");

            migrationBuilder.DropColumn(
                name: "ChatIDChat",
                table: "tb_M_ChatDetails");

            migrationBuilder.RenameColumn(
                name: "IDChat",
                table: "tb_M_Chats",
                newName: "ChatID");

            migrationBuilder.RenameColumn(
                name: "IDChat",
                table: "tb_M_ChatDetails",
                newName: "ChatID");

            migrationBuilder.AlterColumn<string>(
                name: "IDCS",
                table: "tb_M_Chats",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateIndex(
                name: "IX_tb_M_Chats_IDCS",
                table: "tb_M_Chats",
                column: "IDCS",
                unique: true,
                filter: "[IDCS] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_tb_M_ChatDetails_ChatID",
                table: "tb_M_ChatDetails",
                column: "ChatID");

            migrationBuilder.AddForeignKey(
                name: "FK_tb_M_ChatDetails_tb_M_Chats_ChatID",
                table: "tb_M_ChatDetails",
                column: "ChatID",
                principalTable: "tb_M_Chats",
                principalColumn: "ChatID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tb_M_Chats_tb_M_Accounts_IDCS",
                table: "tb_M_Chats",
                column: "IDCS",
                principalTable: "tb_M_Accounts",
                principalColumn: "NIK",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tb_M_ChatDetails_tb_M_Chats_ChatID",
                table: "tb_M_ChatDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_tb_M_Chats_tb_M_Accounts_IDCS",
                table: "tb_M_Chats");

            migrationBuilder.DropIndex(
                name: "IX_tb_M_Chats_IDCS",
                table: "tb_M_Chats");

            migrationBuilder.DropIndex(
                name: "IX_tb_M_ChatDetails_ChatID",
                table: "tb_M_ChatDetails");

            migrationBuilder.RenameColumn(
                name: "ChatID",
                table: "tb_M_Chats",
                newName: "IDChat");

            migrationBuilder.RenameColumn(
                name: "ChatID",
                table: "tb_M_ChatDetails",
                newName: "IDChat");

            migrationBuilder.AlterColumn<int>(
                name: "IDCS",
                table: "tb_M_Chats",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AccountNIK",
                table: "tb_M_Chats",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ChatIDChat",
                table: "tb_M_ChatDetails",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_tb_M_Chats_AccountNIK",
                table: "tb_M_Chats",
                column: "AccountNIK");

            migrationBuilder.CreateIndex(
                name: "IX_tb_M_ChatDetails_ChatIDChat",
                table: "tb_M_ChatDetails",
                column: "ChatIDChat");

            migrationBuilder.AddForeignKey(
                name: "FK_tb_M_ChatDetails_tb_M_Chats_ChatIDChat",
                table: "tb_M_ChatDetails",
                column: "ChatIDChat",
                principalTable: "tb_M_Chats",
                principalColumn: "IDChat",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_tb_M_Chats_tb_M_Accounts_AccountNIK",
                table: "tb_M_Chats",
                column: "AccountNIK",
                principalTable: "tb_M_Accounts",
                principalColumn: "NIK",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
