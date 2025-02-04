using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text.RegularExpressions;

namespace CHS.Client.API.Models.Employees
{
    [ApiUri("/Employees/Create")]
    public class CreateEmployeeRequest : CHSRequest
    {

        public string EmployeeName { get; set; }
        public string EmployeeIDCardNumber { get; set; }
        public string EmployeePhoneNumber { get; set; }
        public string EmployeeBirthData { get; set; }
        public bool EmployeeIsMale { get; set; }
        public string EmployeeEmployementDate { get; set; }
        public string EmployeeEmail { get; set; }
        public string EmployeeJobTitle { get; set; }
        public string EmployeeUserName { get; set; }
        public string EmployeePassword { get; set; }
    }
}