using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CHS.Client.API.Models.Facilities
{
    public enum SearchFacilitiesFilesType
    {
        FacilitiesName = 1,
        FacilitiesPhoneNumber = 2,

    }
    [ApiUri("/Facilities/SearchFacilitiesFile")]
    public class SearchFacilitiesFilesRequest : CHSRequest
    {
        public int SearchType { get; set; }
        public string SearchValue { get; set; }
    }
}
