﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API52.ViewModel
{
    public class TicketRequestVM
    {
        public int IDTicket { get; set; }
        public string Title { get; set; }
        public string Message { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime UpdateDate { get; set; }
        public int IDStat { get; set; }
        public string Detail { get; set; }
        public string NIK { get; set; }
    }
}
