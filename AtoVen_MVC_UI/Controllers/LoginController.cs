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
            HttpContext.Session.Remove("Token");
            HttpContext.Session.Remove("Email");
            HttpContext.Session.Remove("Role");
            HttpContext.Session.Clear(); 
            return View();
        }

        [HttpPost]
        public async Task<Jsonresult> Login(LoginDTO userlogindtls)
        {
            string apiBaseUrl = _config.GetValue<string>("WebAPIBaseUrl");
            string endpoint = apiBaseUrl + "/Account/Login";
            var tokenBased = string.Empty;
            var jsonresult = new Jsonresult {
                Status = "failed",
                Message = "Something went wrong",
            };

            using (var httpclient = new HttpClient())
            {
                var json = JsonConvert.SerializeObject(userlogindtls);
                var data = new StringContent(json, Encoding.UTF8, "application/json");
                Login Logged = new Login();
               
                HttpResponseMessage result = await httpclient.PostAsync(endpoint, data);
                var responsecode = (int)result.StatusCode;
                var responseBodyAsText = result.Content.ReadAsStringAsync().Result;
                
                if (result.IsSuccessStatusCode)
                {
                    
                    Logged = JsonConvert.DeserializeObject<Login>(responseBodyAsText);
                    var strRole = Logged.Role[0];
                    HttpContext.Session.SetString("Token", Logged.Token);
                    HttpContext.Session.SetString("Role", strRole);
                    HttpContext.Session.SetString("Email", Logged.Email);

                    jsonresult = JsonConvert.DeserializeObject<Jsonresult>(responseBodyAsText);

                    jsonresult.Status = "Success";
                    jsonresult.Message = "Successfully Logged In";
                    jsonresult.UserRole = strRole;
                    return jsonresult;
                }
                else
                {
                    jsonresult = JsonConvert.DeserializeObject<Jsonresult>(responseBodyAsText);
                    return jsonresult;
                }
            }

        }


        [HttpPost]
        public async Task<string> ForgotPassword(LoginDTO userlogindtls)
        {
            string apiBaseUrl = _config.GetValue<string>("WebAPIBaseUrl");
            string endpoint = apiBaseUrl + "/Account/ForgotPassword";
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
                   Jsonresult = await result.Content.ReadAsStringAsync().ConfigureAwait(false);
                   return Jsonresult;
                }
            }

            return Jsonresult;

        }


        [HttpGet]
        public ActionResult Logout()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Logout1()
        {
            HttpContext.Session.Remove("Token");
            HttpContext.Session.Remove("Email");
            HttpContext.Session.Remove("Role");
            HttpContext.Session.Clear();
            return RedirectToAction("/Login/Index");
        }

    }
}
