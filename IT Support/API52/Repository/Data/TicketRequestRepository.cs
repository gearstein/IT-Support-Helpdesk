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

        public int Request (TicketRequestVM ticketRequestVM)
        {
            //TicketRequest
            var request = new TicketRequest();
            request.IDTicket = ticketRequestVM.IDTicket;
            request.Title = ticketRequestVM.Title;
            request.Message = ticketRequestVM.Message;
            request.IDStat = 1;
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
                           join th in MyContext.TicketHistories on tr.IDTicket equals th.IDTicket
                           join st in MyContext.Statuses on th.IDStat equals st.IDStat
                           select new
                           {
                               tr.IDTicket,
                               tr.Title,
                               tr.Message,
                               st.Detail,
                               tr.StartDate,
                               tr.UpdateDate,
                               emp.NIK
                           });
            return request;
        }
    }
}
