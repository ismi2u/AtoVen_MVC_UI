using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using AtoVen_MVC_UI.Models;
using System.Text;
using Microsoft.Extensions.Configuration;
using System.Net.Http;
using Newtonsoft.Json;
using System.Data;
using Microsoft.AspNetCore.Authorization;

namespace AtoVen_MVC_UI.Controllers
{
   
    public class MyRegisteredCompanyController : Controller
    {
        private readonly IConfiguration _config;
        public MyRegisteredCompanyController(IConfiguration configuration)
        {
            _config = configuration;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<List<propVendor>> GetList()
        {
            List<propVendor> _oVendorList = new List<propVendor>();

            string apiBaseUrl = _config.GetValue<string>("WebAPIBaseUrl");
            //string endpoint = apiBaseUrl + "/Companies/GetCompanies";
            string endpoint = apiBaseUrl + "/Companies/GetCompanyForVendor";
            using (var httpclient = new HttpClient())
            {
                httpclient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", HttpContext.Session.GetString("Token"));
                using (var response = await httpclient.GetAsync(endpoint, HttpCompletionOption.ResponseHeadersRead))
                {
                    var data = await response.Content.ReadAsStringAsync();
                    _oVendorList = JsonConvert.DeserializeObject<List<propVendor>>(data);
                }
            }

            return _oVendorList;
        }

    }
}
