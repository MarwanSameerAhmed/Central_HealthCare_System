using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;

namespace CHS.Client.API.Models
{
    public class CHSResponse
    {
        public string RequestID { get; set; }
        public string ResponseCode { get; set; }
        public string MessageDescription { get; set; }

        public static bool TryParse(string responseBody, out CHSResponse chsResponse)
        {
            try
            {
                chsResponse = JsonConvert.DeserializeObject<CHSResponse>(responseBody);
                return true;
            }
            catch { }
            chsResponse = null;
            return false;
        }
    }
}