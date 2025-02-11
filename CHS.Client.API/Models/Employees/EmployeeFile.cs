using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CHS.Client.API.Models.Employees
{
    public class EmployeeFile
    {
        public long EmployeeNumber { get; set; }
        public string EmployeeName { get; set; }
        public string EmployeeIDCardNumber { get; set; }
        public List<string> EmployeePhoneNumber { get; set; }
        public string EmployeeBirthData { get; set; }
        public bool EmployeeIsMale { get; set; }
        public string EmployeeEmployementDate { get; set; }
        public string EmployeeEmail { get; set; }
        public string EmployeeJobTitle { get; set; }
        public string EmployeeUserName { get; set; }
        public string EmployeePassword { get; set; }
    }
}
