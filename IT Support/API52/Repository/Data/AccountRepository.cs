using API52.Context;
using API52.Models;
using API52.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Threading.Tasks;
using System.Security.Claims;
using Microsoft.IdentityModel.Tokens;
using Microsoft.Extensions.Configuration;
using System.Text;
using System.IdentityModel.Tokens.Jwt;
using Microsoft.Graph;

namespace API52.Repository.Data
{
    public class AccountRepository : GeneralRepository<MyContext, Account, string>
    {
        public IConfiguration configuration;
        private readonly MyContext context;
        public AccountRepository(IConfiguration config, MyContext myContext) : base(myContext)
        {
            this.configuration = config;
            this.context = myContext;
        }
        //public int Login(LoginVM loginVM)
        //{
        //    var employee = new Employee();
        //    var account = new Account();
        //    var alternatif = context.Accounts.Find(loginVM.NIK);
        //    if (alternatif != null)
        //    {
        //        var test = context.Accounts.FirstOrDefault(a => a.NIK == loginVM.NIK && a.Password == loginVM.Password);
        //        if (test != null)
        //        {
        //            return 1;
        //        }
        //        else
        //        {
        //            return 0;
        //        }
        //    }
        //    else
        //    {
        //        var cekEmail = context.Employees.FirstOrDefault(a => a.Email == loginVM.Email);
        //        var cekNIK = context.Employees.Find(cekEmail.NIK);
        //        var hasedpassword = context.Accounts.Find(cekNIK.NIK);
        //        var validate = BCrypt.Net.BCrypt.Verify(loginVM.Password, hasedpassword.Password);
        //        var cekPass = context.Accounts.FirstOrDefault(a => a.NIK == cekNIK.NIK && a.Password == loginVM.Password);
        //        if (cekEmail != null && validate)
        //        {
        //            return 1;
        //        }
        //        else
        //        {
        //            return 0;
        //        }
        //    }
        //}
        public int Login(LoginVM loginVM)
        {
            var employee = new Employee();
            var account = new Account();
            var alternatif = context.Accounts.Find(loginVM.NIK);
            if (alternatif != null)
            {
                var test = context.Accounts.FirstOrDefault(a => a.NIK == loginVM.NIK && a.Password == loginVM.Password);
                if (test != null)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
            else
            {
                var cekEmail = context.Employees.FirstOrDefault(a => a.Email == loginVM.Email);
                var cekNIK = context.Employees.Find(cekEmail.NIK);
                var hasedpassword = context.Accounts.Find(cekNIK.NIK);
                var validate = BCrypt.Net.BCrypt.Verify(loginVM.Password, hasedpassword.Password);
                var cekPass = context.Accounts.FirstOrDefault(a => a.NIK == cekNIK.NIK && a.Password == loginVM.Password);
                if (cekEmail != null && validate)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }
        public int ChangePassword(ChangeVM changeVM)
        {
            var employee = new Employee();
            var account = new Account();
            var cekEmail = context.Employees.FirstOrDefault(a => a.NIK == changeVM.NIK);
            //var cekNIK = context.Employees.Find(cekEmail.NIK);
            var hasedpassword = context.Accounts.Find(cekEmail.NIK);
            if (cekEmail != null)
            {
                var cekpass = BCrypt.Net.BCrypt.Verify(changeVM.PasswordLama, hasedpassword.Password);
                if (cekpass)
                {
                    var change = MyContext.Accounts.Find(cekEmail.NIK);
                    change.Password = BCrypt.Net.BCrypt.HashPassword(changeVM.PasswordBaru);
                    MyContext.SaveChanges();
                    return 2;
                }
                else
                {
                    return 1;
                }
            }
            return 0;
        }
        public int ResetPassword(ForgotVM forgotVM)
        {
            //var oldpassword = context.Accounts.FirstOrDefault(a => a.Password == loginVM.Password);
            try
            {
                var employee = new Employee();
                var account = new Account();
                Guid obj = Guid.NewGuid();
                var cekEmail = context.Employees.FirstOrDefault(a => a.Email == forgotVM.Email);
                if(cekEmail != null)
                {
                    //var cekNIK = context.Employees.Find(cekEmail.NIK);
                    //var email = context.Employees.FirstOrDefault(a => a.Email == forgotVM.Email);
                    account.NIK = cekEmail.NIK;
                    forgotVM.PasswordLama = account.Password;
                    account.Password = BCrypt.Net.BCrypt.HashPassword(obj.ToString());
                    using (MailMessage mail = new MailMessage())
                    {
                        var placeholder = obj.ToString();
                        mail.From = new MailAddress("ithelpdesk.official@gmail.com");
                        mail.To.Add(forgotVM.Email);
                        mail.Subject = $"Reset Password {forgotVM.PasswordLama}";
                        mail.Body = $"Halo {cekEmail.FirstName} , ini adalah password baru anda note bahwa ini password sementara {obj.ToString()}";

                        using (SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com", 587))
                        {
                            SmtpServer.Credentials = new System.Net.NetworkCredential("ithelpdesk.official@gmail.com", "BootcampMCC52");
                            SmtpServer.EnableSsl = true;
                            SmtpServer.Send(mail);
                            MyContext.Update(account);
                            MyContext.SaveChanges();
                            return 1;
                        }
                    }
                }
                else
                {
                    return 2;
                }
            }
            catch (Exception)
            {

                return 0;
            }
        }

        public string GenerateTokenLogin(LoginVM loginVM)
        {
            var data = (from account in MyContext.Accounts
                        join employee in MyContext.Employees
                        on account.NIK equals employee.NIK
                        join accountroles in MyContext.AccountRoles
                        on account.NIK equals accountroles.NIK
                        join role in MyContext.Roles
                        on accountroles.IDRole equals role.IDRole
                        where account.NIK == $"{loginVM.NIK}" || employee.Email == $"{loginVM.Email}"
                        select new
                        {
                            NIK = employee.NIK,
                            Email = employee.Email,
                            RoleName = role.RoleName
                        }).ToList();
            var claims = new List<Claim>();
            foreach (var item in data)
            {
                claims.Add(new Claim("nik", item.NIK));
                claims.Add(new Claim("email", item.Email));
                claims.Add(new Claim("role", item.RoleName));
            }
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration["Jwt:Key"]));
            var sigin = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
            var token = new JwtSecurityToken(configuration["Jwt:Issuer"], configuration["Jwt:Audience"],
                        claims, expires: DateTime.UtcNow.AddDays(1), signingCredentials: sigin);
            return new JwtSecurityTokenHandler().WriteToken(token);
        }

        public int NotifSend(int IDTicket, string roleName)
        {
            var data = (from employee in MyContext.Employees
                        join account in MyContext.Accounts
                        on employee.NIK equals account.NIK
                        join accountroles in MyContext.AccountRoles
                        on account.NIK equals accountroles.NIK
                        join role in MyContext.Roles
                        on accountroles.IDRole equals role.IDRole
                        where role.RoleName == roleName
                        select new
                        {
                            Email = employee.Email,
                            FirstName = employee.FirstName
                        }).ToList();
            int count = 0;
            foreach(var item in data)
            {
                using (MailMessage message = new MailMessage())
                {
                    message.From = new MailAddress("ithelpdesk.official@gmail.com");
                    message.To.Add(item.Email);
                    message.Subject = $"[No Reply] Incoming Ticket Request TR{IDTicket}MCC {DateTime.Now}";
                    message.Body = $"Hey there {item.FirstName}, There is an incoming ticket request";


                    using (SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com", 587))
                    {
                        SmtpServer.Credentials = new System.Net.NetworkCredential("ithelpdesk.official@gmail.com", "BootcampMCC52");
                        SmtpServer.EnableSsl = true;
                        SmtpServer.Send(message);
                        count++;
                    }
                }
            }
            return count;
            //var accmatch = MyContext.Employees.FirstOrDefault(e => e.Email == ticket.Email);
            //    if (accmatch != null)
            //    {
            //        using (MailMessage message = new MailMessage())
            //        {
            //            message.From = new MailAddress("Riri330902@gmail.com");
            //            message.To.Add(ticket.Email);
            //            message.Subject = "[No Reply] Incoming Ticket Request";
            //            message.Body = $"Hey there {accmatch.FirstName}, There is an incoming ticket request";

            //            using (SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com", 587))
            //            {
            //                SmtpServer.Credentials = new System.Net.NetworkCredential("Riri330902@gmail.com", "Henshin222");
            //                SmtpServer.EnableSsl = true;
            //                SmtpServer.Send(message);
            //                return 1;
            //            }
            //        }
            //    }
            //    else
            //    {
            //        return 2;
            //    }
        }
    }
}
