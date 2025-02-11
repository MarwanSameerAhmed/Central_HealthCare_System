using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CHS.Client.API.Models.Employees
{
    public enum SearchEmployeesFilesType
    {
        EmployeeNumber = 1,
        EmployeeName = 2,
        EmployeePhone = 3
    }

    [ApiUri("/Employees/SearchEmployeeFile")]
    public class SearchEmployeesFilesRequest : CHSRequest

    {
        public int SearchType { get; set; }
        public string SearchValue { get; set; }

    }
}
