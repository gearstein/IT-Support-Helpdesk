﻿using API52.Context;
using API52.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API52.Repository.Data
{
    public class TicketHistoryRepository : GeneralRepository<MyContext, Status, string>
    {
        public TicketHistoryRepository(MyContext myContext) : base(myContext)
        {

        }
    }
}
