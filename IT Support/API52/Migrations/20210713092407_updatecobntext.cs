using Microsoft.EntityFrameworkCore.Migrations;

namespace API52.Migrations
{
    public partial class updatecobntext : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tb_M_TicketRequest_tb_M_Employees_EmployeeNIK",
                table: "tb_M_TicketRequest");

            migrationBuilder.DropForeignKey(
                name: "FK_tb_M_TicketRequest_tb_Tr_Status_StatusIDStat",
                table: "tb_M_TicketRequest");

            migrationBuilder.DropIndex(
                name: "IX_tb_M_TicketRequest_EmployeeNIK",
                table: "tb_M_TicketRequest");

            migrationBuilder.DropIndex(
                name: "IX_tb_M_TicketRequest_StatusIDStat",
                table: "tb_M_TicketRequest");

            migrationBuilder.DropPrimaryKey(
                name: "PK_tb_M_TicketHistory",
                table: "tb_M_TicketHistory");

            migrationBuilder.DropColumn(
                name: "EmployeeNIK",
                table: "tb_M_TicketRequest");

            migrationBuilder.DropColumn(
                name: "StatusIDStat",
                table: "tb_M_TicketRequest");

            migrationBuilder.AlterColumn<string>(
                name: "NIK",
                table: "tb_M_TicketRequest",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

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

            migrationBuilder.CreateIndex(
                name: "IX_tb_M_TicketRequest_NIK",
                table: "tb_M_TicketRequest",
                column: "NIK");

            migrationBuilder.CreateIndex(
                name: "IX_tb_M_TicketHistory_IdTicket",
                table: "tb_M_TicketHistory",
                column: "IdTicket");

            migrationBuilder.AddForeignKey(
                name: "FK_tb_M_TicketRequest_tb_M_Employees_NIK",
                table: "tb_M_TicketRequest",
                column: "NIK",
                principalTable: "tb_M_Employees",
                principalColumn: "NIK",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tb_M_TicketRequest_tb_M_Employees_NIK",
                table: "tb_M_TicketRequest");

            migrationBuilder.DropIndex(
                name: "IX_tb_M_TicketRequest_NIK",
                table: "tb_M_TicketRequest");

            migrationBuilder.DropPrimaryKey(
                name: "PK_tb_M_TicketHistory",
                table: "tb_M_TicketHistory");

            migrationBuilder.DropIndex(
                name: "IX_tb_M_TicketHistory_IdTicket",
                table: "tb_M_TicketHistory");

            migrationBuilder.AlterColumn<int>(
                name: "NIK",
                table: "tb_M_TicketRequest",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EmployeeNIK",
                table: "tb_M_TicketRequest",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "StatusIDStat",
                table: "tb_M_TicketRequest",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "tb_M_TicketHistory",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_tb_M_TicketHistory",
                table: "tb_M_TicketHistory",
                columns: new[] { "IdTicket", "IdStat" });

            migrationBuilder.CreateIndex(
                name: "IX_tb_M_TicketRequest_EmployeeNIK",
                table: "tb_M_TicketRequest",
                column: "EmployeeNIK");

            migrationBuilder.CreateIndex(
                name: "IX_tb_M_TicketRequest_StatusIDStat",
                table: "tb_M_TicketRequest",
                column: "StatusIDStat");

            migrationBuilder.AddForeignKey(
                name: "FK_tb_M_TicketRequest_tb_M_Employees_EmployeeNIK",
                table: "tb_M_TicketRequest",
                column: "EmployeeNIK",
                principalTable: "tb_M_Employees",
                principalColumn: "NIK",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_tb_M_TicketRequest_tb_Tr_Status_StatusIDStat",
                table: "tb_M_TicketRequest",
                column: "StatusIDStat",
                principalTable: "tb_Tr_Status",
                principalColumn: "IDStat",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
