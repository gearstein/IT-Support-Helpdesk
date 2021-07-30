using API52.Base;
using API52.Models;
using API52.Repository.Data;
using API52.ViewModel;
using Microsoft.AspNetCore.Authorization;
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
    public class TicketRequestsController : BaseController<TicketRequest, TicketRequestRepository, int>
    {
        private readonly TicketRequestRepository ticketrequestRepository;
        public TicketRequestsController(TicketRequestRepository ticketrequestRepository) : base(ticketrequestRepository)
        {
            this.ticketrequestRepository = ticketrequestRepository;
        }

        [AllowAnonymous]
        [HttpPost]
        [Route("Request")]
        public ActionResult Request(TicketRequestVM ticketrequestVM)
        {
            try
            {
                var insert = ticketrequestRepository.Request(ticketrequestVM);
                if (insert == 1)
                {
                    var get = Ok(new { status = HttpStatusCode.OK, result = insert, messasge = "Request Success" });
                    return get;
                }
                else
                {
                    var get = BadRequest(new { status = HttpStatusCode.BadRequest, result = insert, messasge = "Gagal Request" });
                    return get;
                }
            }
            catch (Exception)
            {
                var get = BadRequest(new { status = HttpStatusCode.BadRequest, result = 0, messasge = "Gagal Request" });
                return get;
            }
        }

        //[Authorize]
        [HttpGet("ViewRequest")]
        public ActionResult ViewRequest()
        {
            try
            {
                var get = ticketrequestRepository.ViewRequest();
                if (get == null)
                    return NotFound(new { status = HttpStatusCode.NotFound, result = get, messasge = "Not Found" });
                return Ok(get);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        //[Authorize]
        [HttpGet("ViewComplete")]
        public ActionResult ViewComplete()
        {
            try
            {
                var get = ticketrequestRepository.ViewComplete();
                if (get == null)
                    return NotFound(new { status = HttpStatusCode.NotFound, result = get, messasge = "Not Found" });
                return Ok(get);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpGet("FindRequest/{nik}")]
        public ActionResult FindRequest(string NIK)
        {
            var response = ticketrequestRepository.FindRequest(NIK);
            if (NIK == null)
            {
                var get = NotFound(new { status = HttpStatusCode.NotFound, result = response, messasge = "Not Found" });
                return get;
            }
            else
            {
                var get = Ok(response);
                return get;
            }
        }

        [HttpGet("FindComplete/{nik}")]
        public ActionResult FindComplete(string NIK)
        {
            var response = ticketrequestRepository.FindComplete(NIK);
            if (NIK == null)
            {
                var get = NotFound(new { status = HttpStatusCode.NotFound, result = response, messasge = "Not Found" });
                return get;
            }
            else
            {
                var get = Ok(response);
                return get;
            }
        }

        [HttpGet("ViewChart")]
        public ActionResult ViewChart()
        {
            try
            {
                var get = ticketrequestRepository.ViewChart();
                if (get == null)
                    return NotFound(new { status = HttpStatusCode.NotFound, result = get, messasge = "Not Found" });
                return Ok(get);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpGet("ViewRequestJunior")]
        public ActionResult ViewRequestJunior()
        {
            try
            {
                var get = ticketrequestRepository.ViewRequestJunior();
                if (get == null)
                    return NotFound(new { status = HttpStatusCode.NotFound, result = get, messasge = "Not Found" });
                return Ok(get);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpGet("ViewRequestHelpdesk")]
        public ActionResult ViewRequestHelpdesk()
        {
            try
            {
                var get = ticketrequestRepository.ViewRequestHelpdesk();
                if (get == null)
                    return NotFound(new { status = HttpStatusCode.NotFound, result = get, messasge = "Not Found" });
                return Ok(get);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpGet("ViewRequestEngineer")]
        public ActionResult ViewRequestEngineer()
        {
            try
            {
                var get = ticketrequestRepository.ViewRequestEngineer();
                if (get == null)
                    return NotFound(new { status = HttpStatusCode.NotFound, result = get, messasge = "Not Found" });
                return Ok(get);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpGet("ViewRequestDetail")]
        public ActionResult ViewRequestDetail()
        {
            try
            {
                var get = ticketrequestRepository.ViewRequestDetail();
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
