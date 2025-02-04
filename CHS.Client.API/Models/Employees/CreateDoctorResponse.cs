using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CHS.Client.API.Models.Employees
{
    public class CreateDoctorResponse : CHSResponse
    {
        public string DoctorUserName { get; set; }
    }
}