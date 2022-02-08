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

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<List<User>> GetList()
        {
            List<User> userList = new List<User>();

            string apiBaseUrl = _config.GetValue<string>("WebAPIBaseUrl");
            string endpoint = apiBaseUrl + "/Administration/ListUsers";
            using (var httpclient = new HttpClient())
            {
                using (var response = await httpclient.GetAsync(endpoint, HttpCompletionOption.ResponseHeadersRead))
                {
                    var data = await response.Content.ReadAsStringAsync();
                    userList = JsonConvert.DeserializeObject<List<User>>(data);
                }
            }
            return userList;
        }


        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<List<Roles>> getUserRole()
        {
            List<Roles> roleList = new List<Roles>();

            string apiBaseUrl = _config.GetValue<string>("WebAPIBaseUrl");
            string endpoint = apiBaseUrl + "/Administration/ListRoles";

            using (var httpclient = new HttpClient())
            {
                using (var response = await httpclient.GetAsync(endpoint, HttpCompletionOption.ResponseHeadersRead))
                {
                    var data = await response.Content.ReadAsStringAsync();
                    roleList = JsonConvert.DeserializeObject<List<Roles>>(data);
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

        [HttpGet]
        public IActionResult Edit(string Id)
        {
            ViewBag.userId = Id;
            return View();
        }

        [HttpPost]
        public async Task<string> Get(UserDTO _userdtls)
        {
            var data = "";
            string apiBaseUrl = _config.GetValue<string>("WebAPIBaseUrl");
            string endpoint = apiBaseUrl + "/Administration/GetUserByUserId/" + _userdtls.Id;

            using (var httpclient = new HttpClient())
            {
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
        public async Task<string> Update(UserDTO userdtls)
        {
            UserDTO UserDtls = new UserDTO();
            UserDtls = userdtls;

            string apiBaseUrl = _config.GetValue<string>("WebAPIBaseUrl");
            string endpoint = apiBaseUrl + "/Administration/EditUser";
            using (var httpclient = new HttpClient())
            {
                var json = JsonConvert.SerializeObject(UserDtls);
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
