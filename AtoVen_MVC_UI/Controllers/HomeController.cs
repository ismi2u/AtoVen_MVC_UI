using Microsoft.AspNetCore.Mvc;
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


namespace AtoVen_MVC_UI.Controllers
{
   
    public class HomeController : Controller
    {

        private readonly IConfiguration _config;
        public HomeController(IConfiguration configuration)
        {
            _config = configuration;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult List()
        {
            return View();
        }

        [HttpPost]
        public async Task<List<propVendor>> GetList()
        {
            List<propVendor> _oVendorList = new List<propVendor>();

            string apiBaseUrl = _config.GetValue<string>("WebAPIBaseUrl");
            string endpoint = apiBaseUrl + "/Companies/GetCompanies";
            using (var httpclient = new HttpClient())
            {
                using (var response = await httpclient.GetAsync(endpoint, HttpCompletionOption.ResponseHeadersRead))
                {
                    var data = await response.Content.ReadAsStringAsync();
                    _oVendorList = JsonConvert.DeserializeObject<List<propVendor>>(data);
                }
            }

            return _oVendorList; 
        }

        public async Task<string> VATValidate(VATValidatorDTO VATNo)
        {
            var Jsonresult = "";
            
            string apiBaseUrl = _config.GetValue<string>("WebAPIBaseUrl");
            string endpoint = apiBaseUrl + "/Validation/VATValidator?VATNumber="+ VATNo.VATNumber;
            
            //var values = new Dictionary<string, string>();
            //values.Add("VATNumber", VATNumber);
            //HttpContent content = new FormUrlEncodedContent(values);
            
            using (var httpclient = new HttpClient())
            {
                //string jsonContent = HttpContent.ReadAsStringAsync().Result; 
                HttpResponseMessage result = await httpclient.PostAsync(endpoint, null);

                Jsonresult = result.ToString();
                var responsecode = (int)result.StatusCode;
                if (result.IsSuccessStatusCode)
                {
                    Jsonresult = await result.Content.ReadAsStringAsync().ConfigureAwait(false);
                    return Jsonresult;
                }
                else
                {
                    return responsecode + " " + result.ReasonPhrase;
                }

            }
            
        }

        [HttpPost]
        public async Task<string> Register(propVendorDTO vendordtls, List<ListOfCompanyContactsDTO> vendorContactdtls, List<ListOfCompanyBanksDTO> vendorBankdtls)
        {
            propVendorDTO VendorDtls = new propVendorDTO();
            VendorDtls = vendordtls;
            VendorDtls.ListOfCompanyContacts = vendorContactdtls;
            VendorDtls.ListOfCompanyBanks = vendorBankdtls;
            

            string apiBaseUrl = _config.GetValue<string>("WebAPIBaseUrl");
            string endpoint = apiBaseUrl + "/Companies/RegisterCompany";
            var response = string.Empty;
            using (var httpclient = new HttpClient())
            {
                var json = JsonConvert.SerializeObject(VendorDtls);
                var data = new StringContent(json, Encoding.UTF8, "application/json");

                //HttpContent httpContent = new StringContent(json, Encoding.UTF8, "application/x-www-form-urlencoded");
                //string jsonContent = httpContent.ReadAsStringAsync().Result;

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

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
