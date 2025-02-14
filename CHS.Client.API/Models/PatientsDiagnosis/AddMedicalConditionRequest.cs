using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CHS.Client.API.Models.PatientsDiagnosis
{
    [ApiUri("/PatientsDiagnosis/AddMedicalCondition")]
    public class AddMedicalConditionRequest : CHSRequest
    {
        public long PatientDiagnosisNumber { get; set; }
        public List<string> MedicalConditions { get; set; }
    }
}