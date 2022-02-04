using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AtoVen_MVC_UI.Models
{
    public class ApproverLevels
    {
        public int Id { get; set; }
        public int Level { get; set; }
        public bool isEnabled { get; set; }
    }

    public class ApproverLevelsDTO
    {
        public int Level { get; set; }
        public bool isEnabled { get; set; }
    }
}
