using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CHS.Client.API.Models.PatientsDiagnosis
{
    public class CreatePatientDiagnosisResponse : CHSResponse
    {
        public long PatientDiagnosisNumber { get; set; }
    }
}