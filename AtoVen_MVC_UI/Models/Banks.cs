using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AtoVen_MVC_UI.Models
{
    public class ListOfCompanyBanks
    {
        public int id { get; set; }
        public int CompanyID { get; set; }
        public string Country { get; set; }
        public string BankKey { get; set; }
        public string BankName { get; set; }
        public string SwiftCode { get; set; }
        public string BankAccount { get; set; }
        public string AccountHolderName { get; set; }
        public string Iban { get; set; }
        public string Currency { get; set; }
    }

    public class ListOfCompanyBanksDTO
    {
        public int Id { get; set; }
        public int CompanyID { get; set; }
        public string Country { get; set; }
        public string CompanyName { get; set; }
        public string BankKey { get; set; }
        public string BankName { get; set; }
        public string SwiftCode { get; set; }
        public string BankAccount { get; set; }
        public string AccountHolderName { get; set; }
        public string Iban { get; set; }
        public string Currency { get; set; }
    }

    
}
