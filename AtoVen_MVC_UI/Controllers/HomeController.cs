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
        public async Task<ActionResult> List()
        {
            List<propVendor> _oVendorList = new List<propVendor>();

            string apiBaseUrl = _config.GetValue<string>("WebAPIBaseUrl");
            //string endpoint = apiBaseUrl + "/Companies/GetCompanies";
            string endpoint = apiBaseUrl + "/Companies/GetCompaniesApproved";
            using (var httpclient = new HttpClient())
            {
                httpclient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", HttpContext.Session.GetString("Token"));
                using (var response = await httpclient.GetAsync(endpoint, HttpCompletionOption.ResponseHeadersRead))
                {
                    var data = await response.Content.ReadAsStringAsync();
                    _oVendorList = JsonConvert.DeserializeObject<List<propVendor>>(data);
                }
            }

            return View(_oVendorList); 
            //return View();
        }

        [HttpPost]
        public async Task<List<propVendor>> GetList()
        {
            List<propVendor> _oVendorList = new List<propVendor>();

            string apiBaseUrl = _config.GetValue<string>("WebAPIBaseUrl");
            //string endpoint = apiBaseUrl + "/Companies/GetCompanies";
            string endpoint = apiBaseUrl + "/Companies/GetCompaniesApproved";
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

        public async Task<string> EMAILValidate(Validators email)
        {
            var Jsonresult = "";

            string apiBaseUrl = _config.GetValue<string>("WebAPIBaseUrl");
            string endpoint = apiBaseUrl + "/Validation/EmailValidator?EmailAddress=" + email.EmailAddress;

            //var values = new Dictionary<string, string>();
            using (var httpclient = new HttpClient())
            {
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

        public async Task<string> VATValidate(Validators VATNo)
        {
            var Jsonresult = "";
            
            string apiBaseUrl = _config.GetValue<string>("WebAPIBaseUrl");
            string endpoint = apiBaseUrl + "/Validation/VATValidator?VATNumber="+ VATNo.VATNumber;

            //var values = new Dictionary<string, string>();
            using (var httpclient = new HttpClient())
            {
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


        public async Task<string> IBANValidate(Validators IBANNo)
        {
            var Jsonresult = "";

            string apiBaseUrl = _config.GetValue<string>("WebAPIBaseUrl");
            string endpoint = apiBaseUrl + "/Validation/IBANValidator?IbanNumber=" + IBANNo.IbanNumber;
            
            using (var httpclient = new HttpClient())
            {
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
        public async Task<string> Register(propVendorPostDTO vendordtls, List<ListOfCompanyContactsPostDTO> vendorContactdtls, List<ListOfCompanyBanksPostDTO> vendorBankdtls)
        {
            propVendorPostDTO VendorDtls = new propVendorPostDTO();
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
                string Jsonresult = "{\"status\":\"failed\",\"message\":\"Something went wrong!\"}";

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
                    return Jsonresult;
                }
            }
        }

        [HttpGet]
        public IActionResult Edit(string Id)
        {
            ViewBag.CompanyId = Id;
            return View();
        }

        [HttpGet]
        public IActionResult Detail(string Id)
        {
            ViewBag.CompanyId = Id;
            return View();
        }

        [HttpPost]
        public async Task<propVendor> Get(propVendor _vendordtls)
        {
             
            string apiBaseUrl = _config.GetValue<string>("WebAPIBaseUrl");
            string endpoint = apiBaseUrl + "/Companies/GetCompanyById/" + _vendordtls.Id;
            propVendor VendorDtls = new propVendor();

            using (var httpclient = new HttpClient())
            {
                httpclient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", HttpContext.Session.GetString("Token"));
                using (var response = await httpclient.GetAsync(endpoint, HttpCompletionOption.ResponseHeadersRead))
                {
                    var data = await response.Content.ReadAsStringAsync();
                    VendorDtls = JsonConvert.DeserializeObject<propVendor>(data);
                }
            }

            return VendorDtls;

        }


        [HttpPost]
        public async Task<string> Update(propVendorPutDTO vendordtls, List<ListOfCompanyContactsPutDTO> vendorContactdtls, List<ListOfCompanyBanksPutDTO> vendorBankdtls)
        {
            propVendorPutDTO VendorDtls = new propVendorPutDTO();
            VendorDtls = vendordtls;
            VendorDtls.ListOfCompanyContacts = vendorContactdtls;
            VendorDtls.ListOfCompanyBanks = vendorBankdtls;


            string apiBaseUrl = _config.GetValue<string>("WebAPIBaseUrl");
            string endpoint = apiBaseUrl + "/Companies/UpdateCompany/"+ vendordtls.Id;
            var response = string.Empty;

            using (var httpclient = new HttpClient())
            {
                httpclient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", HttpContext.Session.GetString("Token"));

                var json = JsonConvert.SerializeObject(VendorDtls);
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
