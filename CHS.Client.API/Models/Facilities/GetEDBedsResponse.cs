using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CHS.Client.API.Models.Facilities
{
    [ApiUri("/Facilities/GetEDBeds", RequestMethod.Get)]
    public class GetEDBedsResponse : CHSResponse
    {

        public int TotalGeneralBeds {get; set;}
        public int AvailableGeneralBeds {get; set;}
        public int TotalPediatricBeds {get; set;}
        public int AvailablePediatricBeds {get; set;}
        public int TotalTraumaBeds {get; set;}
        public int AvailableTraumaBeds {get; set;}
        public int TotalIsolationBeds {get; set;}
        public int AvailableIsolationBeds {get; set;}
        public int TotalCriticalCareBeds {get; set;}
        public int AvailableCriticalCareBeds {get; set;}
        public int TotalVIPBeds {get; set;}
        public int AvailableVIPBeds { get; set; }

        public GetEDBedsResponse()
        {
            TotalGeneralBeds = 0;
            AvailableGeneralBeds = 0;
            TotalPediatricBeds = 0;
            AvailablePediatricBeds = 0;
            TotalTraumaBeds = 0;
            AvailableTraumaBeds = 0;
            TotalIsolationBeds = 0;
            AvailableIsolationBeds = 0;
            TotalCriticalCareBeds = 0;
            AvailableCriticalCareBeds = 0;
            TotalVIPBeds = 0;
            AvailableVIPBeds = 0;
        }
    }
}
