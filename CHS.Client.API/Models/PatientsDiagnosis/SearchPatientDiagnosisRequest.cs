using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CHS.Client.API.Models.PatientsDiagnosis
{
    [ApiUri("/PatientsDiagnosis/SearchPatientsDiagnosis")]
    public class SearchPatientDiagnosisRequest : CHSRequest
    {
        public long PatientNumber { get; set; }
    }
}