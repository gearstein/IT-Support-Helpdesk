using Microsoft.EntityFrameworkCore.Migrations;

namespace API52.Migrations
{
    public partial class addpriority : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_tb_M_TicketHistory",
                table: "tb_M_TicketHistory");

            migrationBuilder.AddColumn<int>(
                name: "IDPriority",
                table: "tb_M_TicketRequest",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "tb_M_TicketHistory",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<int>(
                name: "IDHistory",
                table: "tb_M_TicketHistory",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_tb_M_TicketHistory",
                table: "tb_M_TicketHistory",
                column: "IDHistory");

            migrationBuilder.CreateTable(
                name: "tb_M_Priorities",
                columns: table => new
                {
                    IDPriority = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PriorityName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_M_Priorities", x => x.IDPriority);
                });

            migrationBuilder.CreateIndex(
                name: "IX_tb_M_TicketRequest_IDPriority",
                table: "tb_M_TicketRequest",
                column: "IDPriority");

            migrationBuilder.AddForeignKey(
                name: "FK_tb_M_TicketRequest_tb_M_Priorities_IDPriority",
                table: "tb_M_TicketRequest",
                column: "IDPriority",
                principalTable: "tb_M_Priorities",
                principalColumn: "IDPriority",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tb_M_TicketRequest_tb_M_Priorities_IDPriority",
                table: "tb_M_TicketRequest");

            migrationBuilder.DropTable(
                name: "tb_M_Priorities");

            migrationBuilder.DropIndex(
                name: "IX_tb_M_TicketRequest_IDPriority",
                table: "tb_M_TicketRequest");

            migrationBuilder.DropPrimaryKey(
                name: "PK_tb_M_TicketHistory",
                table: "tb_M_TicketHistory");

            migrationBuilder.DropColumn(
                name: "IDPriority",
                table: "tb_M_TicketRequest");

            migrationBuilder.DropColumn(
                name: "IDHistory",
                table: "tb_M_TicketHistory");

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "tb_M_TicketHistory",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_tb_M_TicketHistory",
                table: "tb_M_TicketHistory",
                column: "Title");
        }
    }
}
