using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace AtoVen_MVC_UI.Models
{
    public class propVendor
    {
        public int Id { get; set; }
        public string CompanyName { get; set; }
        public string CommercialRegistrationNo { get; set; }
        public string Language { get; set; }
        public string Country { get; set; }
        public string Region { get; set; }
        public string District { get; set; }
        public string PostalCode { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string HouseNo { get; set; }
        public string Building { get; set; }
        public string Floor { get; set; }
        public string Room { get; set; }
        public string PoBox { get; set; }
        public string PhoneNo { get; set; }
        public string FaxNumber { get; set; }
        public string Email { get; set; }
        public string MobileNo { get; set; }
        public string Website { get; set; }
        public string VendorType { get; set; }
        public string AccountGroup { get; set; }
        public string Notes { get; set; }
        public string VATNo { get; set; }       

        public bool IsVendorInitiated { get; set; }
        public List<ListOfCompanyContacts> ListOfCompanyContacts { get; set; }
        public List<ListOfCompanyBanks> ListOfCompanyBanks { get; set; }
    }

    public class propVendorDTO
    {
        public int Id { get; set; }
        public string CompanyName { get; set; }
        public string CommercialRegistrationNo { get; set; }
        public string Language { get; set; }
        public string Country { get; set; }
        public string Region { get; set; }
        public string District { get; set; }
        public string PostalCode { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string HouseNo { get; set; }
        public string Building { get; set; }
        public string Floor { get; set; }
        public string Room { get; set; }
        public string PoBox { get; set; }
        public string PhoneNo { get; set; }
        public string FaxNumber { get; set; }
        public string Email { get; set; }
        public string MobileNo { get; set; }
        public string Website { get; set; }
        public string VendorType { get; set; }
        
        public string AccountGroup { get; set; }
        public string Notes { get; set; }        
        public string VATNo { get; set; }

        public bool IsVendorInitiated { get; set; }
        public List<ListOfCompanyContactsDTO> ListOfCompanyContacts { get; set; }
        public List<ListOfCompanyBanksDTO> ListOfCompanyBanks { get; set; }
    }


}
