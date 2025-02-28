using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CHS.Client.API.Models.Patients
{
    public class PaitientFile
    {
        public long PatientNumber { get; set; }
        public string PatientName { get; set; }
        public List<string> PatientPhones { get; set; }
        public string IDCardNumber { get; set; }
        public string BirthDate { get; set; }
        public bool IsMale { get; set; }
        public string PatientAddress { get; set; }
        public string BloodType { get; set; }
        public string birthPlace { get; set; }
        public string maritalStatus { get; set; }
        public string companionName { get; set; }
        public List<string> allergies { get; set; }

    }
}