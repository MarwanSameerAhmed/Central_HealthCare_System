using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CHS.Client.API.Models.Labs
{
    [ApiUri("/Labs/ResultLabTestTemplate")]
    public class ResultLabTestTemplateResponse : CHSResponse
    {
        public List<ResultLabTest> Results { get; set; }

        public ResultLabTestTemplateResponse()
        {
            Results = new List<ResultLabTest>();
        }
    }

    public class ResultLabTest
    {
        public string Name { get; set; }
        public string Value { get; set; }
        public List<ResultLabTest> SubResults { get; set; }
    }
}