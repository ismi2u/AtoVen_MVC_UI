﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AtoVen_MVC_UI.Models
{
    public class Role
    {
        public string Id { get; set; }
        public string name { get; set; }
    }

    public class RoleDTO
    {
        public string RoleName { get; set; }
    }
}
