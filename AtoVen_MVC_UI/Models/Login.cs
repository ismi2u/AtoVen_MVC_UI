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
        public string Email { get; set; }

        public string Password { get; set; }

        public bool Remmeber { get; set; }
    }
}
