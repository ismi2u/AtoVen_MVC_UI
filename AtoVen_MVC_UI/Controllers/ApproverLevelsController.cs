using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using AtoVen_MVC_UI.Models;
using System.Net.Http;
using Newtonsoft.Json;


namespace AtoVen_MVC_UI.Controllers
{
    public class ApproverLevelsController : Controller
    {
        private readonly IConfiguration _config;
        public ApproverLevelsController(IConfiguration configuration)
        {
            _config = configuration;
        }

        [HttpGet]
        public async Task<ActionResult> Index()
        {
            List<ApproverLevels> _oApproverLevels = new List<ApproverLevels>();

            string apiBaseUrl = _config.GetValue<string>("WebAPIBaseUrl");
            string endpoint = apiBaseUrl + "/ApproverLevels";
            using (var httpclient = new HttpClient())
            {
                using (var response = await httpclient.GetAsync(endpoint, HttpCompletionOption.ResponseHeadersRead))
                {
                    var data = await response.Content.ReadAsStringAsync();
                    _oApproverLevels = JsonConvert.DeserializeObject<List<ApproverLevels>>(data);
                }               
            }

            return View(_oApproverLevels);
        }
    }
}
