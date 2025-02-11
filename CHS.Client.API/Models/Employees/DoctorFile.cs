using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CHS.Client.API.Models.Employees
{
    public class DoctorFile
    {
        public long DoctorNumber { get; set; }
        public string DoctorName { get; set; }
        public string DoctorIDCardNumber { get; set; }
        public List<string> DoctorPhoneNumber { get; set; }
        public string DoctorBirthData { get; set; }
        public bool DoctorIsMale { get; set; }
        public string DoctorEmployementDate { get; set; }
        public string DoctorEmail { get; set; }
        public string DoctorJobTitle { get; set; }
        public string DoctorUserName { get; set; }
        public string DoctorPassword { get; set; }
        public string DoctorLicenseNumber { get; set; }
        public string LicenseReleaseDate { get; set; }
        public string LicenseExpiryDate { get; set; }
        public string MedicalSpecialization { get; set; }
    }
}
