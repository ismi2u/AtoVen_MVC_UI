using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
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
    public class LoginController : Controller
    {
        private readonly IConfiguration _config;

        public LoginController(IConfiguration configuration)
        {
            _config = configuration;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<string> Login(LoginDTO userlogindtls)
        {
            string apiBaseUrl = _config.GetValue<string>("WebAPIBaseUrl");
            string endpoint = apiBaseUrl + "/Account/Login";
            var tokenBased = string.Empty;
            string Jsonresult = "{\"status\":\"failed\",\"message\":\"Unauthorized\"}";

            using (var httpclient = new HttpClient())
            {
                var json = JsonConvert.SerializeObject(userlogindtls);
                var data = new StringContent(json, Encoding.UTF8, "application/json");
                Login Logged = new Login();
               
                HttpResponseMessage result = await httpclient.PostAsync(endpoint, data);
                var responsecode = (int)result.StatusCode;

                if (result.IsSuccessStatusCode)
                {
                    var responseBodyAsText = result.Content.ReadAsStringAsync().Result;
                    Logged = JsonConvert.DeserializeObject<Login>(responseBodyAsText);
                    HttpContext.Session.SetString("Token", Logged.Token);
                    HttpContext.Session.SetString("Role", Logged.Role[0]);
                    HttpContext.Session.SetString("Email", Logged.Email);
                    Jsonresult = await result.Content.ReadAsStringAsync().ConfigureAwait(false);

                    return Jsonresult;
                }
            }

            return Jsonresult;

        }

    }
}
