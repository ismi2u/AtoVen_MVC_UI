using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AtoVen_MVC_UI.Models
{
    public class ListOfCompanyContacts
    {
        public string Id { get; set; }
        public string companyID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string Designation { get; set; }
        public string Department { get; set; }
        public string PhoneNo { get; set; }
        public string MobileNo { get; set; }
        public string FaxNo { get; set; }
        public string Email { get; set; }
        public string Language { get; set; }
        public string Country { get; set; }
    }

    public class ListOfCompanyContactsDTO
    {
        public string CompanyName { get; set; }        
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string Designation { get; set; }
        public string Department { get; set; }
        public string PhoneNo { get; set; }
        public string MobileNo { get; set; }

        public string FaxNo { get; set; }
        public string Email { get; set; }
        public string Language { get; set; }
        public string Country { get; set; }
    }
}
