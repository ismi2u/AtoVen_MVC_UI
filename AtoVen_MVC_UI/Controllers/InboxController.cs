﻿using AtoVen_MVC_UI.Models;
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
    public class InboxController : Controller
    {
        // GET: InboxController
        private readonly IConfiguration _config;
        public InboxController(IConfiguration configuration)
        {
            _config = configuration;
        }
        public async Task<ActionResult> Index()
        {

            List<Inbox> _oVendorList = new List<Inbox>();
            var email = HttpContext.Session.GetString("Email");
            string apiBaseUrl = _config.GetValue<string>("WebAPIBaseUrl");
            string endpoint = apiBaseUrl + "/ApprovalFlows/GetApprovalFlowByEmailIdInPending?email="+ email;
            using (var httpclient = new HttpClient())
            {
                httpclient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", HttpContext.Session.GetString("Token"));
                using (var response = await httpclient.GetAsync(endpoint, HttpCompletionOption.ResponseHeadersRead))
                {

                    if (response.IsSuccessStatusCode)
                    {
                        var data = await response.Content.ReadAsStringAsync();
                        _oVendorList = JsonConvert.DeserializeObject<List<Inbox>>(data);
                    }
                }
            }

            return View(_oVendorList);
        }

        // GET: InboxController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: InboxController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: InboxController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: InboxController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: InboxController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }


        public ActionResult Proceed(string  id,string companyID)
        {
            ViewBag.ApprovalFlowId = id;
            TempData["id"] = id;
            ViewBag.CompanyId = companyID;

            return View();

        }


        public async Task<ActionResult> Duplicate(string id)
        {
            List<propVendorDTO> propVendorDTO = new List<propVendorDTO>();

            ViewData["Id"] = id;

            string apiBaseUrl = _config.GetValue<string>("WebAPIBaseUrl");
            string endpoint = apiBaseUrl + "/Companies/GetCompanyDuplicatesByCompId/" + id;

            using (var httpclient = new HttpClient())
            {
                httpclient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", HttpContext.Session.GetString("Token"));
                using (var response = await httpclient.GetAsync(endpoint, HttpCompletionOption.ResponseHeadersRead))
                {
                    var data = await response.Content.ReadAsStringAsync();
                    propVendorDTO = JsonConvert.DeserializeObject<List<propVendorDTO>>(data);
                }
            }


            return PartialView("Duplicate", propVendorDTO);
        }


        [HttpPost]
      
        public async Task<Jsonresult> Approve(propVendorDTO vendordtls, List<ListOfCompanyContactsDTO> vendorContactdtls, List<ListOfCompanyBanksDTO> vendorBankdtls)
        {

            var jsonresult = new Jsonresult
            {
                Status = "failed",
                Message = "Something went wrong",
            };

            propVendorDTO VendorDtls = new propVendorDTO();

            ApproveReject approveReject = new ApproveReject();

            //approveReject.id = int.Parse(TempData["id"].ToString());
            //approveReject.ApprovalStatus = 2;

            VendorDtls = vendordtls;
            VendorDtls.ListOfCompanyContacts = vendorContactdtls;
            VendorDtls.ListOfCompanyBanks = vendorBankdtls;


            string apiBaseUrl = _config.GetValue<string>("WebAPIBaseUrl");
            string endpoint = apiBaseUrl + "/Companies/UpdateCompany/" + vendordtls.Id;

            //string endpoint1 = apiBaseUrl + "/ApprovalFlows/PutApprovalFlow/" + TempData["id"].ToString();
           
            using (var httpclient = new HttpClient())
            {
                httpclient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", HttpContext.Session.GetString("Token"));
                
                var json = JsonConvert.SerializeObject(VendorDtls);
                var data = new StringContent(json, Encoding.UTF8, "application/json");

                HttpResponseMessage result = await httpclient.PutAsync(endpoint, data);
                var responsecode = (int)result.StatusCode;
                var responseBodyAsText = result.Content.ReadAsStringAsync().Result;
                if (result.IsSuccessStatusCode)
                {
                    //var json1 = JsonConvert.SerializeObject(approveReject);
                    //var data1 = new StringContent(json1, Encoding.UTF8, "application/json");
                    //HttpResponseMessage result1 = await httpclient.PutAsync(endpoint1, data1);
                    //var responsecode1 = (int)result1.StatusCode;
                    jsonresult.Status = "Success";
                    jsonresult.Message = "Successfully Approved";
                    return jsonresult;
                }
                else
                {
                    jsonresult = JsonConvert.DeserializeObject<Jsonresult>(responseBodyAsText);
                    return jsonresult;
                }
            }
            
        }

        public async Task<Jsonresult> Reject()
        {

            var jsonresult = new Jsonresult
            {
                Status = "failed",
                Message = "Something went wrong",
            };

            ApproveReject approveReject = new ApproveReject();

            approveReject.id = int.Parse(TempData["id"].ToString());
            approveReject.ApprovalStatus = 3;

            string apiBaseUrl = _config.GetValue<string>("WebAPIBaseUrl");

            string endpoint1 = apiBaseUrl + "/ApprovalFlows/PutApprovalFlow/" + TempData["id"].ToString();
            var response = string.Empty;

            using (var httpclient = new HttpClient())
            {
                httpclient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", HttpContext.Session.GetString("Token"));


                var json1 = JsonConvert.SerializeObject(approveReject);
                var data1 = new StringContent(json1, Encoding.UTF8, "application/json");
                HttpResponseMessage result1 = await httpclient.PutAsync(endpoint1, data1);
                var responsecode1 = (int)result1.StatusCode;
                var responseBodyAsText = result1.Content.ReadAsStringAsync().Result;

                if (result1.IsSuccessStatusCode)
                {
                    jsonresult.Status = "Success";
                    jsonresult.Message = "Successfully Rejected";
                    return jsonresult;
                }
                else
                {
                    jsonresult = JsonConvert.DeserializeObject<Jsonresult>(responseBodyAsText);
                    return jsonresult;
                }
               
            }

            
        }




        // GET: InboxController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: InboxController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
