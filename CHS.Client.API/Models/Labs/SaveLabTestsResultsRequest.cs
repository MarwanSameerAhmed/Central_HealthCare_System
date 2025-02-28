using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CHS.Client.API.Models.Labs
{
    [ApiUri("/Labs/SaveLabTestsResults")]
    public class SaveLabTestsResultsRequest : CHSRequest
    {
        public long PatientDiagnosisNumber { get; set; }
        public List<ResultLabTest> Results { get; set; }

        public SaveLabTestsResultsRequest()
        {
            Results = new List<ResultLabTest>();
        }
    }
}