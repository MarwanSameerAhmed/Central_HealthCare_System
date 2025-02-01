using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CHS.Client.API.Models
{
    public class LoginResponse: CHSResponse
    {
        public string Token { get; set; }

        public string TwoFactorAuthenticationUrl { get; set; }

    }
}