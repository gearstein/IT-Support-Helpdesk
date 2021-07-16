using API52.Models;
using API52.ViewModel;
using Client.Base;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace Client.Repositories.Data
{
    public class TicketRequestRepository : GeneralRepository<TicketRequest, int>
    {
        private readonly Address address;
        private readonly string request;
        private readonly IHttpContextAccessor _contextAccessor;
        private readonly HttpClient httpClient;

        public TicketRequestRepository(Address address, string request = "TicketRequests/") : base(address, request)
        {
            this.address = address;
            this.request = request;
            _contextAccessor = new HttpContextAccessor();
            httpClient = new HttpClient
            {
                BaseAddress = new Uri(address.link)
            };
        }

        public async Task<List<AllTicketRequestVM>> GetRequestView()
        {
            List<AllTicketRequestVM> entities = new List<AllTicketRequestVM>();

            using (var response = await httpClient.GetAsync(request + "ViewRequest/"))
            {
                string apiResponse = await response.Content.ReadAsStringAsync();
                entities = JsonConvert.DeserializeObject<List<AllTicketRequestVM>>(apiResponse);
            }
            return entities;
        }

    }
}
