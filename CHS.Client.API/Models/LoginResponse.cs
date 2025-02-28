using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CHS.Client.API.Models
{
    public  class LoginResponse: CHSResponse
    {
        public string Token { get; set; }
        public string TwoFactorAuthenticationUrl { get; set; }
        public string EmployeeName { get; set; }
        public string JobTitle { get; set; }
        public int UserRole { get; set; }

    }
}