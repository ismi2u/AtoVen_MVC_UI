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
    }
}
