using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CHS.Client.API.Models.PatientsDiagnosis
{
    [ApiUri("/PatientsDiagnosis/CreatePatientDiagnosis")]
    public class CreatePatientDiagnosisRequest : CHSRequest
    {
        public long PatientNumber { get; set; }
        public List<string> Symptoms { get; set; }
        public List<int> LabTests { get; set; }
    }
}