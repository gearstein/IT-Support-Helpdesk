﻿// <auto-generated />
using System;
using API52.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace API52.Migrations
{
    [DbContext(typeof(MyContext))]
    [Migration("20210713083100_ChangeTipedata")]
    partial class ChangeTipedata
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.7")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("API52.Models.Account", b =>
                {
                    b.Property<string>("NIK")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("NIK");

                    b.ToTable("tb_M_Accounts");
                });

            modelBuilder.Entity("API52.Models.AccountRole", b =>
                {
                    b.Property<string>("NIK")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("IDRole")
                        .HasColumnType("int");

                    b.HasKey("NIK");

                    b.HasIndex("IDRole");

                    b.ToTable("tb_Tr_AccountRoles");
                });

            modelBuilder.Entity("API52.Models.Chat", b =>
                {
                    b.Property<int>("IDChat")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AccountNIK")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("IDCS")
                        .HasColumnType("int");

                    b.Property<int>("IDTicket")
                        .HasColumnType("int");

                    b.HasKey("IDChat");

                    b.HasIndex("AccountNIK");

                    b.HasIndex("IDTicket")
                        .IsUnique();

                    b.ToTable("tb_M_Chats");
                });

            modelBuilder.Entity("API52.Models.ChatDetail", b =>
                {
                    b.Property<int>("IDDetail")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("ChatIDChat")
                        .HasColumnType("int");

                    b.Property<int>("IDChat")
                        .HasColumnType("int");

                    b.Property<string>("Message")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("SendDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.HasKey("IDDetail");

                    b.HasIndex("ChatIDChat");

                    b.ToTable("tb_M_ChatDetails");
                });

            modelBuilder.Entity("API52.Models.Employee", b =>
                {
                    b.Property<string>("NIK")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("NIK");

                    b.ToTable("tb_M_Employees");
                });

            modelBuilder.Entity("API52.Models.Role", b =>
                {
                    b.Property<int>("IDRole")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("RoleName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IDRole");

                    b.ToTable("tb_M_Roles");
                });

            modelBuilder.Entity("API52.Models.Status", b =>
                {
                    b.Property<int>("IDStat")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Detail")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IDStat");

                    b.ToTable("tb_Tr_Status");
                });

            modelBuilder.Entity("API52.Models.TicketHistory", b =>
                {
                    b.Property<int>("IdTicket")
                        .HasColumnType("int");

                    b.Property<int>("IdStat")
                        .HasColumnType("int");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.HasKey("IdTicket", "IdStat");

                    b.HasIndex("IdStat");

                    b.ToTable("tb_M_TicketHistory");
                });

            modelBuilder.Entity("API52.Models.TicketRequest", b =>
                {
                    b.Property<int>("IDTicket")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("EmployeeNIK")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("IDStat")
                        .HasColumnType("int");

                    b.Property<string>("Message")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NIK")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("StatusIDStat")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.HasKey("IDTicket");

                    b.HasIndex("EmployeeNIK");

                    b.HasIndex("StatusIDStat");

                    b.ToTable("tb_M_TicketRequest");
                });

            modelBuilder.Entity("API52.Models.Account", b =>
                {
                    b.HasOne("API52.Models.Employee", "Employee")
                        .WithOne("Account")
                        .HasForeignKey("API52.Models.Account", "NIK")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("API52.Models.AccountRole", b =>
                {
                    b.HasOne("API52.Models.Role", "Role")
                        .WithMany()
                        .HasForeignKey("IDRole")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("API52.Models.Account", "Account")
                        .WithMany()
                        .HasForeignKey("NIK")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Account");

                    b.Navigation("Role");
                });

            modelBuilder.Entity("API52.Models.Chat", b =>
                {
                    b.HasOne("API52.Models.Account", "Account")
                        .WithMany("Chats")
                        .HasForeignKey("AccountNIK");

                    b.HasOne("API52.Models.TicketRequest", "TicketRequest")
                        .WithOne("Chat")
                        .HasForeignKey("API52.Models.Chat", "IDTicket")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Account");

                    b.Navigation("TicketRequest");
                });

            modelBuilder.Entity("API52.Models.ChatDetail", b =>
                {
                    b.HasOne("API52.Models.Chat", "Chat")
                        .WithMany("ChatDetails")
                        .HasForeignKey("ChatIDChat");

                    b.Navigation("Chat");
                });

            modelBuilder.Entity("API52.Models.TicketHistory", b =>
                {
                    b.HasOne("API52.Models.Status", "Status")
                        .WithMany("TicketHistories")
                        .HasForeignKey("IdStat")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("API52.Models.TicketRequest", "TicketRequest")
                        .WithMany("TicketHistories")
                        .HasForeignKey("IdTicket")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Status");

                    b.Navigation("TicketRequest");
                });

            modelBuilder.Entity("API52.Models.TicketRequest", b =>
                {
                    b.HasOne("API52.Models.Employee", "Employee")
                        .WithMany("TicketRequests")
                        .HasForeignKey("EmployeeNIK");

                    b.HasOne("API52.Models.Status", "Status")
                        .WithMany("TicketRequests")
                        .HasForeignKey("StatusIDStat");

                    b.Navigation("Employee");

                    b.Navigation("Status");
                });

            modelBuilder.Entity("API52.Models.Account", b =>
                {
                    b.Navigation("Chats");
                });

            modelBuilder.Entity("API52.Models.Chat", b =>
                {
                    b.Navigation("ChatDetails");
                });

            modelBuilder.Entity("API52.Models.Employee", b =>
                {
                    b.Navigation("Account");

                    b.Navigation("TicketRequests");
                });

            modelBuilder.Entity("API52.Models.Status", b =>
                {
                    b.Navigation("TicketHistories");

                    b.Navigation("TicketRequests");
                });

            modelBuilder.Entity("API52.Models.TicketRequest", b =>
                {
                    b.Navigation("Chat");

                    b.Navigation("TicketHistories");
                });
#pragma warning restore 612, 618
        }
    }
}
