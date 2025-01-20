using CHS.Client.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CHS.Client.API.Models.Facilities
{
    [ApiUri("/Facilities/Create")]
    public class CreateFacilityRequest : CHSRequest
    {

        public string FacilityName { get; set; }
        public string FacilityAddress { get; set; }
        public List<string> FacilityPhones { get; set; }
        public string FacilityEmail { get; set; }
        public int FacilityType { get; set; }
    }
}