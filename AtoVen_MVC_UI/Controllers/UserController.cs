using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AtoVen_MVC_UI.Models;
using System.Text;
using Microsoft.Extensions.Configuration;
using System.Net.Http;
using Newtonsoft.Json;

namespace AtoVen_MVC_UI.Controllers
{

    public class UserController : Controller
    {

        private readonly IConfiguration _config;
        public UserController(IConfiguration configuration)
        {
            _config = configuration;
        }
        
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<List<Role>> getUserRole()
        {
            List<Role> roleList = new List<Role>();

            string apiBaseUrl = _config.GetValue<string>("WebAPIBaseUrl");
            string endpoint = apiBaseUrl + "/Administration/ListRoles";

            using (var httpclient = new HttpClient())
            {
                using (var response = await httpclient.GetAsync(endpoint, HttpCompletionOption.ResponseHeadersRead))
                {
                    var data = await response.Content.ReadAsStringAsync();
                    roleList = JsonConvert.DeserializeObject<List<Role>>(data);
                }
            }

            return roleList;
        }

        [HttpPost]
        public async Task<string> Create(UserDTO userdtls)
        {
            
            string apiBaseUrl = _config.GetValue<string>("WebAPIBaseUrl");
            string endpoint = apiBaseUrl + "/Administration/CreateUser";
            var response = string.Empty;
            using (var httpclient = new HttpClient())
            {
                var json = JsonConvert.SerializeObject(userdtls);
                var data = new StringContent(json, Encoding.UTF8, "application/json");

                HttpResponseMessage result = await httpclient.PostAsync(endpoint, data);
                var responsecode = (int)result.StatusCode;

                if (result.IsSuccessStatusCode)
                {
                    var responseBodyAsText = await result.Content.ReadAsStringAsync().ConfigureAwait(false);
                    return responseBodyAsText;
                }
                else
                {
                    return responsecode + " " + result.ReasonPhrase;
                }
            }
        }
    }
}
