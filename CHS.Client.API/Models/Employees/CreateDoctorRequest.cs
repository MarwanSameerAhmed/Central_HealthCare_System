using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text.RegularExpressions;

namespace CHS.Client.API.Models.Employees
{
    [ApiUri("/Employees/CreateDoctor")]
    public class CreateDoctorRequest : CHSRequest
    {

        public string DoctorName { get; set; }
        public string DoctorIDCardNumber { get; set; }
        public string DoctorPhoneNumber { get; set; }
        public string DoctorBirthData { get; set; }
        public bool DoctorIsMale { get; set; }
        public string DoctorEmployementDate { get; set; }
        public string DoctorEmail { get; set; }
        public string DoctorJobTitle { get; set; }
        public string DoctorUserName { get; set; }
        public string DoctorPassword { get; set; }
    }
}