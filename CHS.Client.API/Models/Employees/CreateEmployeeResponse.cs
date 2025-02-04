using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CHS.Client.API.Models.Employees
{
    public class CreateEmployeeResponse : CHSResponse
    {
        public string EmployeeUserName { get; set; }
    }
}