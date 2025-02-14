using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CHS.Client.API.Models.PatientsDiagnosis
{
    public class SearchPatientDiagnosisResponse : CHSResponse
    {
        public long PatientNumber { get; set; }

        public List<PatientsDiagnosisFile> PatientsDiagnosisFiles { get; set; }
    }
}