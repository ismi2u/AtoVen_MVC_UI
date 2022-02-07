using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AtoVen_MVC_UI.Models
{
    public class User
    {
        public string Id {get; set;}
        public string UserName { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }
        public int ApproverLevel { get; set; }

        public string Role { get; set; }

    }

    public class UserDTO
    {
        public string Id { get; set; }
        public string UserName { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }
        public int ApproverLevel { get; set; }

        public string Role { get; set; } 
    }
}
