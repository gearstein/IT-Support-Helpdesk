using API52.Models;
using API52.ViewModel;
using Client.Base;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
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
        public async Task<List<AllTicketRequestVM>> FindRequest(string nik)
        {
            List<AllTicketRequestVM> entities = new List<AllTicketRequestVM>();

            using (var response = await httpClient.GetAsync(request + "FindRequest/" + nik))
            {
                string apiResponse = await response.Content.ReadAsStringAsync();
                entities = JsonConvert.DeserializeObject<List<AllTicketRequestVM>>(apiResponse);
            }
            return entities;
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

        public string JwtNIK(string token)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            JwtSecurityToken result = tokenHandler.ReadJwtToken(token);

            return result.Claims.FirstOrDefault(claim => claim.Type.Equals("nik")).Value;
        }

        //public HttpStatusCode Put(Coba entity)
        //{
        //    StringContent content = new StringContent(JsonConvert.SerializeObject(entity), Encoding.UTF8, "application/json");
        //    var result = httpClient.PutAsync(request, content).Result;
        //    if (result.IsSuccessStatusCode)
        //    {

        //    }
        //    return result.StatusCode;
        //}

    }
}
