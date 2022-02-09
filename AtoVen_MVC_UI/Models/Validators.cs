using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AtoVen_MVC_UI.Models
{
    public class Validators
    {
        public string VATNumber { get; set; }
        public string IbanNumber { get; set; }
    }

    public class ValidatorsDTO
    {
        public string VATNumber { get; set; }
        public string IbanNumber { get; set; }
    }
}
