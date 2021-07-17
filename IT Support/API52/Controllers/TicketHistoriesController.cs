using API52.Base;
using API52.Models;
using API52.Repository.Data;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace API52.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("AllowOrigin")]
    public class TicketHistoriesController : BaseController<TicketHistory, TicketHistoryRepository, int>
    {
        private readonly TicketHistoryRepository tickethistoryRepository;
        public TicketHistoriesController(TicketHistoryRepository tickethistoryRepository) : base(tickethistoryRepository)
        {
            this.tickethistoryRepository = tickethistoryRepository;
        }

        [HttpGet("ViewHistory")]
        public ActionResult ViewRequest()
        {
            try
            {
                var get = tickethistoryRepository.ViewHistory();
                if (get == null)
                    return NotFound(new { status = HttpStatusCode.NotFound, result = get, messasge = "Not Found" });
                return Ok(get);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
    }
}
