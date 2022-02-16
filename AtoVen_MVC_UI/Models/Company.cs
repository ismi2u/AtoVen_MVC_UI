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
        public string PoBox { get; set; } = "";
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
        public DateTime RecordDate { get; set; }
        public int ApprovalFlowID { get; set; }
        public bool IsApproved { get; set; }
        public DateTime? ApprovedDate { get; set; }

        public List<ListOfCompanyContacts> ListOfCompanyContacts { get; set; }
        public List<ListOfCompanyBanks> ListOfCompanyBanks { get; set; }
    }

    public class propVendorPostDTO
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
        public string PoBox { get; set; } = "";
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
        public List<ListOfCompanyContactsPostDTO> ListOfCompanyContacts { get; set; }
        public List<ListOfCompanyBanksPostDTO> ListOfCompanyBanks { get; set; }
    }


    public class propVendorPutDTO
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
        public string PoBox { get; set; } = "";
        public string PhoneNo { get; set; }
        public string FaxNumber { get; set; }
        public string MobileNo { get; set; }
        public string Website { get; set; }
        public string VendorType { get; set; }
        public string AccountGroup { get; set; }
        public string Notes { get; set; }
        public string VATNo { get; set; }
        public int ApprovalFlowID { get; set; }
        public bool? IsVendorInitiated { get; set; }        
        public List<ListOfCompanyContactsPutDTO> ListOfCompanyContacts { get; set; }
        public List<ListOfCompanyBanksPutDTO> ListOfCompanyBanks { get; set; }
    }


    public class propVendorVM
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
          

        public List<ListOfCompanyContacts> ListOfCompanyContacts { get; set; }
        public List<ListOfCompanyBanks> ListOfCompanyBanks { get; set; }
    }

}
