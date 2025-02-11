using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CHS.Client.API.Models.Employees
{
    public enum SearchDoctorsFilesType
    {
        DoctorNumber = 1,
        DoctorName = 2,
        DoctorPhone = 3
    }

    [ApiUri("/Employees/SearchDoctorFile")]
    public class SearchDoctorsFilesRequest : CHSRequest
    {

        public int SearchType { get; set; }
        public string SearchValue { get; set; }
    }
}
