using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AtoVen_MVC_UI.Models
{
    public class Login
    {
        public string Token { get; set; }
        public string[] Role { get; set; }

        public string Email { get; set; }
    }

    public class LoginDTO
    {
        public string email { get; set; }

        public string password { get; set; }

        public bool remmeber { get; set; }
    }
}
