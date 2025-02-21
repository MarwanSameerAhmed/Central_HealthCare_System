using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CHS.Client.API.Models.PatientsDiagnosis
{
    public class PatientsDiagnosisFile
    {
        public long PatientDiagnosisNumber { get; set; }
        public string CreatedAt { get; set; }
        public List<string> Symptoms { get; set; }
        public string LastUpdateTimeSymptoms { get; set; }
        public List<string> MedicalConditions { get; set; }
        public string EnterTimeMedicalCondition { get; set; }
        public bool CreatedByCurrentDoctor { get; set; }
        public bool IsChronic { get; set; }
    }
}