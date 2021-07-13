using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace API52.Migrations
{
    public partial class updated_context : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tb_M_Employees",
                columns: table => new
                {
                    NIK = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_M_Employees", x => x.NIK);
                });

            migrationBuilder.CreateTable(
                name: "tb_M_Roles",
                columns: table => new
                {
                    IDRole = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_M_Roles", x => x.IDRole);
                });

            migrationBuilder.CreateTable(
                name: "tb_Tr_Status",
                columns: table => new
                {
                    IDStat = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Detail = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_Tr_Status", x => x.IDStat);
                });

            migrationBuilder.CreateTable(
                name: "tb_M_Accounts",
                columns: table => new
                {
                    NIK = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_M_Accounts", x => x.NIK);
                    table.ForeignKey(
                        name: "FK_tb_M_Accounts_tb_M_Employees_NIK",
                        column: x => x.NIK,
                        principalTable: "tb_M_Employees",
                        principalColumn: "NIK",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tb_M_TicketRequest",
                columns: table => new
                {
                    IDTicket = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Message = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IDStat = table.Column<int>(type: "int", nullable: false),
                    NIK = table.Column<int>(type: "int", nullable: false),
                    StatusIDStat = table.Column<int>(type: "int", nullable: true),
                    EmployeeNIK = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_M_TicketRequest", x => x.IDTicket);
                    table.ForeignKey(
                        name: "FK_tb_M_TicketRequest_tb_M_Employees_EmployeeNIK",
                        column: x => x.EmployeeNIK,
                        principalTable: "tb_M_Employees",
                        principalColumn: "NIK",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_tb_M_TicketRequest_tb_Tr_Status_StatusIDStat",
                        column: x => x.StatusIDStat,
                        principalTable: "tb_Tr_Status",
                        principalColumn: "IDStat",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "tb_Tr_AccountRoles",
                columns: table => new
                {
                    NIK = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    IDRole = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_Tr_AccountRoles", x => x.NIK);
                    table.ForeignKey(
                        name: "FK_tb_Tr_AccountRoles_tb_M_Accounts_NIK",
                        column: x => x.NIK,
                        principalTable: "tb_M_Accounts",
                        principalColumn: "NIK",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tb_Tr_AccountRoles_tb_M_Roles_IDRole",
                        column: x => x.IDRole,
                        principalTable: "tb_M_Roles",
                        principalColumn: "IDRole",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tb_M_Chats",
                columns: table => new
                {
                    IDChat = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IDTicket = table.Column<int>(type: "int", nullable: false),
                    IDCS = table.Column<int>(type: "int", nullable: false),
                    AccountNIK = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_M_Chats", x => x.IDChat);
                    table.ForeignKey(
                        name: "FK_tb_M_Chats_tb_M_Accounts_AccountNIK",
                        column: x => x.AccountNIK,
                        principalTable: "tb_M_Accounts",
                        principalColumn: "NIK",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_tb_M_Chats_tb_M_TicketRequest_IDTicket",
                        column: x => x.IDTicket,
                        principalTable: "tb_M_TicketRequest",
                        principalColumn: "IDTicket",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tb_M_TicketHistory",
                columns: table => new
                {
                    IdTicket = table.Column<int>(type: "int", nullable: false),
                    IdStat = table.Column<int>(type: "int", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_M_TicketHistory", x => new { x.IdTicket, x.IdStat });
                    table.ForeignKey(
                        name: "FK_tb_M_TicketHistory_tb_M_TicketRequest_IdTicket",
                        column: x => x.IdTicket,
                        principalTable: "tb_M_TicketRequest",
                        principalColumn: "IDTicket",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tb_M_TicketHistory_tb_Tr_Status_IdStat",
                        column: x => x.IdStat,
                        principalTable: "tb_Tr_Status",
                        principalColumn: "IDStat",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tb_M_ChatDetails",
                columns: table => new
                {
                    IDDetail = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Message = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SendDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IDChat = table.Column<int>(type: "int", nullable: false),
                    ChatIDChat = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_M_ChatDetails", x => x.IDDetail);
                    table.ForeignKey(
                        name: "FK_tb_M_ChatDetails_tb_M_Chats_ChatIDChat",
                        column: x => x.ChatIDChat,
                        principalTable: "tb_M_Chats",
                        principalColumn: "IDChat",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_tb_M_ChatDetails_ChatIDChat",
                table: "tb_M_ChatDetails",
                column: "ChatIDChat");

            migrationBuilder.CreateIndex(
                name: "IX_tb_M_Chats_AccountNIK",
                table: "tb_M_Chats",
                column: "AccountNIK");

            migrationBuilder.CreateIndex(
                name: "IX_tb_M_Chats_IDTicket",
                table: "tb_M_Chats",
                column: "IDTicket",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_tb_M_TicketHistory_IdStat",
                table: "tb_M_TicketHistory",
                column: "IdStat");

            migrationBuilder.CreateIndex(
                name: "IX_tb_M_TicketRequest_EmployeeNIK",
                table: "tb_M_TicketRequest",
                column: "EmployeeNIK");

            migrationBuilder.CreateIndex(
                name: "IX_tb_M_TicketRequest_StatusIDStat",
                table: "tb_M_TicketRequest",
                column: "StatusIDStat");

            migrationBuilder.CreateIndex(
                name: "IX_tb_Tr_AccountRoles_IDRole",
                table: "tb_Tr_AccountRoles",
                column: "IDRole");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tb_M_ChatDetails");

            migrationBuilder.DropTable(
                name: "tb_M_TicketHistory");

            migrationBuilder.DropTable(
                name: "tb_Tr_AccountRoles");

            migrationBuilder.DropTable(
                name: "tb_M_Chats");

            migrationBuilder.DropTable(
                name: "tb_M_Roles");

            migrationBuilder.DropTable(
                name: "tb_M_Accounts");

            migrationBuilder.DropTable(
                name: "tb_M_TicketRequest");

            migrationBuilder.DropTable(
                name: "tb_M_Employees");

            migrationBuilder.DropTable(
                name: "tb_Tr_Status");
        }
    }
}
