using CHS.Client.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CHS.Client.API.Models.Patients
{
    [ApiUri("/Patients/CreatePatientFile")]
    public class CreatePatientFileRequest : CHSRequest
    {

        public string PatientName { get; set; }
        public List<string> PatientPhones { get; set; }
        public string IDCardNumber { get; set; }
        public string BirthDate { get; set; }
        public bool IsMale { get; set; }
        public string PatientAddress { get; set; }
        public string BloodType { get; set; }
    }
}