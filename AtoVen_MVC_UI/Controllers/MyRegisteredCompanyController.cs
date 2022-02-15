using AtoVen_MVC_UI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Data;
using System.Globalization;
using System.IO;
using System.Net;
using System.Web;
using System.Text;


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

        
        public async Task<propVendorVM> GetList()
        {
            propVendorVM _oVendorList = new propVendorVM();

            string apiBaseUrl = _config.GetValue<string>("WebAPIBaseUrl");
            //string endpoint = apiBaseUrl + "/Companies/GetCompanies";
            string endpoint = apiBaseUrl + "/Companies/GetCompanyForVendor";
            using (var httpclient = new HttpClient())
            {
                httpclient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", HttpContext.Session.GetString("Token"));
                using (var response = await httpclient.GetAsync(endpoint, HttpCompletionOption.ResponseHeadersRead))
                {
                   
                    var data = await response.Content.ReadAsStringAsync();
                    _oVendorList = JsonConvert.DeserializeObject<propVendorVM>(data);

                }
            }            
            return _oVendorList;
        }


        [HttpGet]
        public IActionResult Edit(string Id)
        {
            ViewBag.CompanyId = Id;
            return View();
        }

        [HttpPost]
        public async Task<string> Update(propVendorDTO vendordtls, List<ListOfCompanyContactsDTO> vendorContactdtls, List<ListOfCompanyBanksDTO> vendorBankdtls)
        {
            propVendorDTO VendorDtls = new propVendorDTO();
            VendorDtls = vendordtls;
            VendorDtls.ListOfCompanyContacts = vendorContactdtls;
            VendorDtls.ListOfCompanyBanks = vendorBankdtls;


            string apiBaseUrl = _config.GetValue<string>("WebAPIBaseUrl");
            string endpoint = apiBaseUrl + "/Companies/UpdateCompany/" + vendordtls.Id;
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


    }
}
