using API52.Context;
using API52.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API52.Repository.Data
{
    public class TicketHistoryRepository : GeneralRepository<MyContext, TicketHistory, int>
    {
        private readonly MyContext context;
        public TicketHistoryRepository(MyContext myContext) : base(myContext)
        {
            this.context = myContext;
        }
        public IQueryable ViewHistory()
        {
            var request = (from th in MyContext.TicketHistories
                           join tr in MyContext.TicketRequests on th.IDTicket equals tr.IDTicket
                           join st in MyContext.Statuses on tr.IDStat equals st.IDStat
                           where th.IDStat == 3
                           select new
                           {
                               th.IDHistory,
                               tr.IDTicket,
                               tr.Title,
                               st.Detail,
                               tr.StartDate,
                               tr.UpdateDate,
                           });
            return request;
        }
    }
}
