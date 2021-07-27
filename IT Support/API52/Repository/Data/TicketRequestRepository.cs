using API52.Context;
using API52.Models;
using API52.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API52.Repository.Data
{
    public class TicketRequestRepository : GeneralRepository<MyContext, TicketRequest, int>
    {
        private readonly MyContext context;
        public TicketRequestRepository(MyContext myContext) : base(myContext)
        {
            this.context = myContext;
        }

        public int Request(TicketRequestVM ticketRequestVM)
        {
            var stat1 = context.Statuses.Single(a => a.IDStat == 1);
            var stat2 = context.Statuses.Single(a => a.IDStat == 2);
            var stat3 = context.Statuses.Single(a => a.IDStat == 3);
            //TicketRequest
            var request = new TicketRequest();
            request.IDTicket = ticketRequestVM.IDTicket;
            request.Title = ticketRequestVM.Title;
            request.Message = ticketRequestVM.Message;
            request.IDStat = 1;
            request.IDPriority = 1;
            request.StartDate = ticketRequestVM.StartDate;
            request.UpdateDate = ticketRequestVM.UpdateDate;
            request.NIK = ticketRequestVM.NIK;
            context.TicketRequests.Add(request);
            context.SaveChanges();
            return 1;
        }

        public IQueryable ViewRequest()
        {
            var request = (from tr in MyContext.TicketRequests
                           join emp in MyContext.Employees on tr.NIK equals emp.NIK
                           join st in MyContext.Statuses on tr.IDStat equals st.IDStat
                           join pr in MyContext.Priorities on tr.IDPriority equals pr.IDPriority
                           where tr.IDStat == 1 || tr.IDStat == 2
                           orderby tr.IDTicket descending
                           select new
                           {
                               tr.IDTicket,
                               tr.Title,
                               tr.Message,
                               st.Detail,
                               tr.StartDate,
                               tr.UpdateDate,
                               emp.NIK,
                               emp.Email,
                               emp.PhoneNumber,
                               emp.FirstName,
                               emp.LastName,
                               pr.PriorityName,
                           });
            return request;
        }

        public IQueryable ViewRequestJunior()
        {
            var request = (from tr in MyContext.TicketRequests
                           join emp in MyContext.Employees on tr.NIK equals emp.NIK
                           join st in MyContext.Statuses on tr.IDStat equals st.IDStat
                           join pr in MyContext.Priorities on tr.IDPriority equals pr.IDPriority
                           where (tr.IDStat == 1 || tr.IDStat == 2) && tr.IDPriority == 1
                           orderby tr.IDTicket descending
                           select new
                           {
                               tr.IDTicket,
                               tr.Title,
                               tr.Message,
                               st.Detail,
                               tr.StartDate,
                               tr.UpdateDate,
                               emp.NIK,
                               emp.Email,
                               emp.PhoneNumber,
                               emp.FirstName,
                               emp.LastName,
                               pr.PriorityName,
                           });
            return request;
        }

        public IQueryable ViewRequestHelpdesk()
        {
            var request = (from tr in MyContext.TicketRequests
                           join emp in MyContext.Employees on tr.NIK equals emp.NIK
                           join st in MyContext.Statuses on tr.IDStat equals st.IDStat
                           join pr in MyContext.Priorities on tr.IDPriority equals pr.IDPriority
                           where (tr.IDStat == 1 || tr.IDStat == 2) && tr.IDPriority == 2
                           orderby tr.IDTicket descending
                           select new
                           {
                               tr.IDTicket,
                               tr.Title,
                               tr.Message,
                               st.Detail,
                               tr.StartDate,
                               tr.UpdateDate,
                               emp.NIK,
                               emp.Email,
                               emp.PhoneNumber,
                               emp.FirstName,
                               emp.LastName,
                               pr.PriorityName,
                           });
            return request;
        }

        public IQueryable ViewRequestEngineer()
        {
            var request = (from tr in MyContext.TicketRequests
                           join emp in MyContext.Employees on tr.NIK equals emp.NIK
                           join st in MyContext.Statuses on tr.IDStat equals st.IDStat
                           join pr in MyContext.Priorities on tr.IDPriority equals pr.IDPriority
                           where (tr.IDStat == 1 || tr.IDStat == 2) && tr.IDPriority == 3
                           orderby tr.IDTicket descending
                           select new
                           {
                               tr.IDTicket,
                               tr.Title,
                               tr.Message,
                               st.Detail,
                               tr.StartDate,
                               tr.UpdateDate,
                               emp.NIK,
                               emp.Email,
                               emp.PhoneNumber,
                               emp.FirstName,
                               emp.LastName,
                               pr.PriorityName,
                           });
            return request;
        }

        public IQueryable ViewComplete()
        {
            var request = (from tr in MyContext.TicketRequests
                           join emp in MyContext.Employees on tr.NIK equals emp.NIK
                           join st in MyContext.Statuses on tr.IDStat equals st.IDStat
                           join pr in MyContext.Priorities on tr.IDPriority equals pr.IDPriority
                           where tr.IDStat == 3
                           orderby tr.IDTicket descending
                           select new
                           {
                               tr.IDTicket,
                               tr.Title,
                               tr.Message,
                               st.Detail,
                               tr.StartDate,
                               tr.UpdateDate,
                               emp.NIK,
                               emp.Email,
                               emp.PhoneNumber,
                               emp.FirstName,
                               emp.LastName,
                               pr.PriorityName,
                           });
            return request;
        }

        public IQueryable FindComplete(string nik)
        {
            var request = (from tr in MyContext.TicketRequests
                           join emp in MyContext.Employees on tr.NIK equals emp.NIK
                           join st in MyContext.Statuses on tr.IDStat equals st.IDStat
                           join pr in MyContext.Priorities on tr.IDPriority equals pr.IDPriority
                           where tr.IDStat == 3 && tr.NIK == nik
                           orderby tr.IDTicket descending
                           select new
                           {
                               tr.IDTicket,
                               tr.Title,
                               tr.Message,
                               st.Detail,
                               tr.StartDate,
                               tr.UpdateDate,
                               emp.NIK,
                               emp.Email,
                               emp.PhoneNumber,
                               emp.FirstName,
                               emp.LastName,
                               pr.PriorityName,
                           });
            return request;
        }

        public IQueryable FindRequest(string nik)
        {
            var request = (from tr in MyContext.TicketRequests
                           join emp in MyContext.Employees on tr.NIK equals emp.NIK
                           join st in MyContext.Statuses on tr.IDStat equals st.IDStat
                           join pr in MyContext.Priorities on tr.IDPriority equals pr.IDPriority
                           where (tr.IDStat == 1 || tr.IDStat == 2) && tr.NIK == nik
                           orderby tr.IDTicket descending
                           select new
                           {
                               tr.IDTicket,
                               tr.Title,
                               tr.Message,
                               st.Detail,
                               tr.StartDate,
                               tr.UpdateDate,
                               emp.NIK,
                               emp.Email,
                               pr.PriorityName,
                           });
            return request;
        }

        public IQueryable ViewChart()
        {
            var request = (from tr in MyContext.TicketRequests
                           join emp in MyContext.Employees on tr.NIK equals emp.NIK
                           join st in MyContext.Statuses on tr.IDStat equals st.IDStat
                           join pr in MyContext.Priorities on tr.IDPriority equals pr.IDPriority
                           select new
                           {
                               tr.IDTicket,
                               tr.Title,
                               tr.Message,
                               st.Detail,
                               tr.StartDate,
                               tr.UpdateDate,
                               emp.NIK,
                               pr.PriorityName,
                           });
            return request;
        }
    }
}