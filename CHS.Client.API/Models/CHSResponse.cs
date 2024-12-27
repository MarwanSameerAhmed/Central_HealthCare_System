using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CHS.Client.API.Models
{
    public class CHSResponse
    {
        public string RequestID { get; set; }
        public string ResponseCode { get; set; }
        public string MessageDescription { get; set; }
    }
}