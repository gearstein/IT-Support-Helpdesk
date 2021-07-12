﻿using API52.Context;
using API52.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API52.Repository.Data
{
    public class EducationRepository : GeneralRepository<MyContext, TicketRequest, int>
    {
        public EducationRepository(MyContext myContext) : base(myContext)
        {

        }
    }
}
