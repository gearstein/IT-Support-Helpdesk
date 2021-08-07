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
using System.Net.Http.Headers;
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
            httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("bearer", _contextAccessor.HttpContext.Session.GetString("JWToken"));
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

        public async Task<List<AllTicketRequestVM>> FindComplete(string nik)
        {
            List<AllTicketRequestVM> entities = new List<AllTicketRequestVM>();

            using (var response = await httpClient.GetAsync(request + "FindComplete/" + nik))
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

        public async Task<string> getJWT()
        {
            //var content = new JWTokenVM();
            var token = _contextAccessor.HttpContext.Session.GetString("JWToken");
            //var result = new JwtSecurityTokenHandler().ReadJwtToken(token);

            //content.Token = result.Claims.First(claim => claim.Type == "nik").Value;

            var result = token;
            return token;
        }

        // Chart
        public async Task<List<AllTicketRequestVM>> FindChart(string nik)
        {
            List<AllTicketRequestVM> entities = new List<AllTicketRequestVM>();

            using (var response = await httpClient.GetAsync(request + "FindChart/" + nik))
            {
                string apiResponse = await response.Content.ReadAsStringAsync();
                entities = JsonConvert.DeserializeObject<List<AllTicketRequestVM>>(apiResponse);
            }
            return entities;
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
