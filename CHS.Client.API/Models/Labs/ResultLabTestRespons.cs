using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CHS.Client.API.Models.Labs
{
    [ApiUri("/Labs/ResultLabTest")]
    public class ResultLabTestRespons : CHSResponse
    {
        public List<ResultLabTest> Results { get; set; }

        public ResultLabTestRespons()
        {
            Results = new List<ResultLabTest>();
        }
    }
}