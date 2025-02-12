using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CHS.Client.API.Models.Facilities
{
    public class FacilitiesFile
    {
        public long FaciltiesNumber { get; set; }
        public string FacilityName { get; set; }
        public string FacilityAddress { get; set; }
        public List<string> FacilityPhones { get; set; }
        public string FacilityEmail { get; set; }
        public int FacilityType { get; set; }
        public string AdminName { get; set; }
        public string AdminIDCardNumber { get; set; }
        public string AdminPhoneNumber { get; set; }
        public string AdminBirthData { get; set; }
        public bool AdminIsMale { get; set; }
        public string AdminEmployementDate { get; set; }
        public string AdminEmail { get; set; }
        public string AdminJobTitle { get; set; }
        public string AdminUserName { get; set; }
        public string AdminPassword { get; set; }
    }
}
