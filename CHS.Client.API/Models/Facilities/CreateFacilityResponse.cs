using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CHS.Client.API.Models.Facilities
{
    public class CreateFacilityResponse : CHSResponse
    {
        public string AdminUserName { get; set; }
    }
}