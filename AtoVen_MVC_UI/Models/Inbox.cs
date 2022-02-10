using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AtoVen_MVC_UI.Models
{
    public class Inbox
    {
        public int id { get; set; }
        public int companyID { get; set; }
        public string companyName { get; set; }
        public string companyRegisterNo { get; set; }
        public DateTime recordDate { get; set; }
        public string approvalStatus { get; set; }
        public bool isDuplicateEntry { get; set; }
    }
}
