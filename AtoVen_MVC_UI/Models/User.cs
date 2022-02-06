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

        public string email { get; set; }

        public string password { get; set; }
        public int approverLevel { get; set; }

        public string role { get; set; }
    }

    public class UserDTO
    {
        public string Id { get; set; }
        public string UserName { get; set; }

        public string email { get; set; }

        public string password { get; set; }
        public int approverLevel { get; set; }

        public string role { get; set; }
    }
}
