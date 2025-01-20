using CHS.Client.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CHS.Client.API.Models.Facilities
{
    [ApiUri("/Facilities/GetFacilitiesTypes", RequestMethod.Get)]
    public class GetFacilitiesTypesResponse: CHSResponse
    {
        public List<FacilityType> facilityTypes { get; set; }

        public GetFacilitiesTypesResponse()
        {
            facilityTypes = new List<FacilityType>();
        }
    }

    public class FacilityType
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }
}