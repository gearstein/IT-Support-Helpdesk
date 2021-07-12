﻿using API52.Base;
using API52.Models;
using API52.Repository.Data;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API52.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("AllowOrigin")]
    public class TicketHistoriesController : BaseController<TicketHistory, TicketHistoryRepository, int>
    {
        public TicketHistoriesController(TicketHistoryRepository tickethistoryRepository) : base(tickethistoryRepository)
        {

        }
    }
}
