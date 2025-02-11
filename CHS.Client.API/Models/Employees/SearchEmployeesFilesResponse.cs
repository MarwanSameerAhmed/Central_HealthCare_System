using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CHS.Client.API.Models.Employees
{
    public class SearchEmployeesFilesResponse : CHSResponse
    {
        public List<EmployeeFile> EmployeeFiles { get; set; }
    }
}
