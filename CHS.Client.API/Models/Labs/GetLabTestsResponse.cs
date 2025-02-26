using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CHS.Client.API.Models.Labs
{
    [ApiUri("/Labs/GetLabTests", RequestMethod.Get)]
    public class GetLabTestsResponse : CHSResponse
    {
        public List<LabTest> LabTests { get; set; }

        public GetLabTestsResponse()
        {
            LabTests = new List<LabTest>();
        }
    }


    public class LabTest
    {
        public long ID { get; set; }
        public string Name { get; set; }
    }
}