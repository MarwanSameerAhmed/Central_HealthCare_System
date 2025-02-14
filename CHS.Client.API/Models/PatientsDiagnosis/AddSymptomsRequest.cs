using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CHS.Client.API.Models.PatientsDiagnosis
{
    [ApiUri("/PatientsDiagnosis/AddSymptoms")]
    public class AddSymptomsRequest : CHSRequest
    {
        public long PatientDiagnosisNumber { get; set; }
        public List<string> Symptoms { get; set; }
    }
}