using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CHS.Client.API.Models.Labs
{
    public class ResultLabTestRequest : CHSRequest
    {
        public long PatientDiagnosisNumber { get; set; }
    }
}