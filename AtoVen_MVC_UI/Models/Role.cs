using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AtoVen_MVC_UI.Models
{
    public class Roles
    {
        public string Id { get; set; }
        public string Name { get; set; }

        public string NormalizedName { get; set; }

        public string ConcurrencyStamp { get; set; }
    }

    public class RolesDTO
    {
        public string Id { get; set; }
        public string RoleId { get; set; }
        public string RoleName { get; set; }
    }
}
