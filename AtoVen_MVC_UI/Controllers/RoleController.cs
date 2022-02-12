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
    public class RoleController : Controller
    {
        private readonly IConfiguration _config;
        public RoleController(IConfiguration configuration)
        {
            _config = configuration;
        }


        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<List<Roles>> GetList()
        {
            List<Roles> roleList = new List<Roles>();

            string apiBaseUrl = _config.GetValue<string>("WebAPIBaseUrl");
            string endpoint = apiBaseUrl + "/Administration/ListRoles";

            using (var httpclient = new HttpClient())
            {
                httpclient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", HttpContext.Session.GetString("Token"));
                
                using (var response = await httpclient.GetAsync(endpoint, HttpCompletionOption.ResponseHeadersRead))
                {
                    var data = await response.Content.ReadAsStringAsync();
                    roleList = JsonConvert.DeserializeObject<List<Roles>>(data);
                }
            }
            return roleList;
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<string> Create(RolesDTO roledtls)
        {
            RolesDTO RoleDtls = new RolesDTO();
            RoleDtls = roledtls;

            string apiBaseUrl = _config.GetValue<string>("WebAPIBaseUrl");
            string endpoint = apiBaseUrl + "/Administration/CreateRole";
            using (var httpclient = new HttpClient())
            {
                httpclient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", HttpContext.Session.GetString("Token"));
                
                var json = JsonConvert.SerializeObject(RoleDtls);
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


        [HttpGet]
        public IActionResult Edit(string Id)
        {
            ViewBag.roleId = Id;
            return View();
        }

        [HttpPost]
        public async Task<string> Get(RolesDTO _roledtls)
        {
            var data = "";
            string apiBaseUrl = _config.GetValue<string>("WebAPIBaseUrl");
            string endpoint = apiBaseUrl + "/Administration/GetRoleByRoleId/" + _roledtls.RoleId ; 

            using (var httpclient = new HttpClient())
            {
                httpclient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", HttpContext.Session.GetString("Token"));
                
                HttpResponseMessage response = await httpclient.GetAsync(endpoint, HttpCompletionOption.ResponseHeadersRead);
                data = response.ToString();
                var responsecode = (int)response.StatusCode;
                if (response.IsSuccessStatusCode)
                {
                    data = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                    return data;
                    //Roledtls = JsonConvert.DeserializeObject<RolesDTO>(data);
                }
                else
                {
                    return responsecode + " " + response.ReasonPhrase;
                }
            }
        }

        [HttpPost]
        public async Task<string> Update(RolesDTO roledtls)
        {
            RolesDTO RoleDtls = new RolesDTO();
            RoleDtls = roledtls;

            string apiBaseUrl = _config.GetValue<string>("WebAPIBaseUrl");
            string endpoint = apiBaseUrl + "/Administration/EditRole";
            using (var httpclient = new HttpClient())
            {
                httpclient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", HttpContext.Session.GetString("Token"));
                
                var json = JsonConvert.SerializeObject(RoleDtls);
                var data = new StringContent(json, Encoding.UTF8, "application/json");

                HttpResponseMessage result = await httpclient.PutAsync(endpoint, data);
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
