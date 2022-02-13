using System;

namespace AtoVen_MVC_UI.Models
{
    public class ErrorViewModel
    {
        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }

    public class Jsonresult
    {
        public string Status { get; set; }
        public string Message { get; set; }
        public string UserRole { get; set; }
    }
}
