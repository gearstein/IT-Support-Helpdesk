using Microsoft.EntityFrameworkCore.Migrations;

namespace API52.Migrations
{
    public partial class changeIDStat : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tb_M_TicketHistory_tb_M_TicketRequest_IdTicket",
                table: "tb_M_TicketHistory");

            migrationBuilder.DropForeignKey(
                name: "FK_tb_M_TicketHistory_tb_Tr_Status_IdStat",
                table: "tb_M_TicketHistory");

            migrationBuilder.RenameColumn(
                name: "IdTicket",
                table: "tb_M_TicketHistory",
                newName: "IDTicket");

            migrationBuilder.RenameColumn(
                name: "IdStat",
                table: "tb_M_TicketHistory",
                newName: "IDStat");

            migrationBuilder.RenameIndex(
                name: "IX_tb_M_TicketHistory_IdTicket",
                table: "tb_M_TicketHistory",
                newName: "IX_tb_M_TicketHistory_IDTicket");

            migrationBuilder.RenameIndex(
                name: "IX_tb_M_TicketHistory_IdStat",
                table: "tb_M_TicketHistory",
                newName: "IX_tb_M_TicketHistory_IDStat");

            migrationBuilder.AddForeignKey(
                name: "FK_tb_M_TicketHistory_tb_M_TicketRequest_IDTicket",
                table: "tb_M_TicketHistory",
                column: "IDTicket",
                principalTable: "tb_M_TicketRequest",
                principalColumn: "IDTicket",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tb_M_TicketHistory_tb_Tr_Status_IDStat",
                table: "tb_M_TicketHistory",
                column: "IDStat",
                principalTable: "tb_Tr_Status",
                principalColumn: "IDStat",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tb_M_TicketHistory_tb_M_TicketRequest_IDTicket",
                table: "tb_M_TicketHistory");

            migrationBuilder.DropForeignKey(
                name: "FK_tb_M_TicketHistory_tb_Tr_Status_IDStat",
                table: "tb_M_TicketHistory");

            migrationBuilder.RenameColumn(
                name: "IDTicket",
                table: "tb_M_TicketHistory",
                newName: "IdTicket");

            migrationBuilder.RenameColumn(
                name: "IDStat",
                table: "tb_M_TicketHistory",
                newName: "IdStat");

            migrationBuilder.RenameIndex(
                name: "IX_tb_M_TicketHistory_IDTicket",
                table: "tb_M_TicketHistory",
                newName: "IX_tb_M_TicketHistory_IdTicket");

            migrationBuilder.RenameIndex(
                name: "IX_tb_M_TicketHistory_IDStat",
                table: "tb_M_TicketHistory",
                newName: "IX_tb_M_TicketHistory_IdStat");

            migrationBuilder.AddForeignKey(
                name: "FK_tb_M_TicketHistory_tb_M_TicketRequest_IdTicket",
                table: "tb_M_TicketHistory",
                column: "IdTicket",
                principalTable: "tb_M_TicketRequest",
                principalColumn: "IDTicket",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tb_M_TicketHistory_tb_Tr_Status_IdStat",
                table: "tb_M_TicketHistory",
                column: "IdStat",
                principalTable: "tb_Tr_Status",
                principalColumn: "IDStat",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
