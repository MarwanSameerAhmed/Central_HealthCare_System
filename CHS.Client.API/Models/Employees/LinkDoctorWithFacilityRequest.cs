using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CHS.Client.API.Models.Employees
{
    [ApiUri("/Employees/LinkDoctorWithFacility")]
    public class LinkDoctorWithFacilityRequest : CHSRequest
    {
        public long DoctorNumber { get; set; }
    }
}