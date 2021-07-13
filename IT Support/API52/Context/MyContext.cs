using API52.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API52.Context
{ //Menghubungkan Aplikasi dengan Database
    public class MyContext : DbContext
    {
        public MyContext(DbContextOptions<MyContext> options) : base(options)
        {

        }
        //public static object Employee { get; internal set; }
        public DbSet<Account> Accounts { get; set; }
        public DbSet<AccountRole> AccountRoles { get; set; }
        public DbSet<Chat> Chats { get; set; }
        public DbSet<ChatDetail> ChatDetails { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Status> Statuses { get; set; }
        public DbSet<TicketHistory> TicketHistories { get; set; }
        public DbSet<TicketRequest> TicketRequests { get; set; }
      

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseLazyLoadingProxies();
        //}
        protected override void OnModelCreating(ModelBuilder modelbuilder)
        {
            //Account - Employee
            modelbuilder.Entity<Account>()
                .HasOne(e => e.Employee)
                .WithOne(a => a.Account)
                .HasForeignKey<Employee>(d => d.NIK);

            //Account - Chat
            modelbuilder.Entity<Account>()
                .HasMany(c => c.Chats)
                .WithOne(a => a.Account);

            //Account - AccountRole - Role
            modelbuilder.Entity<Role>().HasMany(a => a.Accounts)
                .WithMany(b => b.Roles).UsingEntity<AccountRole>
                (c => c.HasOne(d => d.Account)
                .WithMany().HasForeignKey(e => e.NIK), f => f.HasOne(g => g.Role)
                .WithMany().HasForeignKey(h => h.IDRole));

            //Chat - ChatDetail
            modelbuilder.Entity<Chat>()
                .HasMany(cd => cd.ChatDetails)
                .WithOne(c => c.Chat);

            //TicketRequest - Chat  
            modelbuilder.Entity<TicketRequest>()
                .HasOne(t => t.Chat)
                .WithOne(c => c.TicketRequest)
                .HasForeignKey<Chat>(d => d.IDTicket);

            //Employee - Account  
            modelbuilder.Entity<Employee>()
                .HasOne(t => t.Account)
                .WithOne(c => c.Employee)
                .HasForeignKey<Account>(d => d.NIK);

            //Employee - TicketRequest
            modelbuilder.Entity<Employee>()
                .HasMany(t => t.TicketRequests)
                .WithOne(e => e.Employee);

            //Status - TicketRequest
            modelbuilder.Entity<Status>()
                .HasMany(t => t.TicketRequests)
                .WithOne(s => s.Status);

            //ticket request -> Ticket History <- status
            modelbuilder.Entity<TicketHistory>()
        .HasKey(bc => new { bc.IdTicket, bc.IdStat});
            modelbuilder.Entity<TicketHistory>()
                .HasOne(bc => bc.TicketRequest)
                .WithMany(b => b.TicketHistories)
                .HasForeignKey(bc => bc.IdTicket);
            modelbuilder.Entity<TicketHistory>()
                .HasOne(bc => bc.Status)
                .WithMany(c => c.TicketHistories)
                .HasForeignKey(bc => bc.IdStat);

        }
    }
}
