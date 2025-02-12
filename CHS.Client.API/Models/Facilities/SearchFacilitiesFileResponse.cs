using CHS.Client.API.Models.Employees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CHS.Client.API.Models.Facilities
{
    public class SearchFacilitiesFileResponse :CHSResponse
    {
        public List<FacilitiesFile> FacilitiesFiles { get; set; }
    }
}
