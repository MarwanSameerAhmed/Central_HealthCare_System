using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CHS.Client.API.Models.Pharmacies
{
    [ApiUri("/Pharmacies/GetPatientsDiagnosisMedicines")]
    public class GetPatientsDiagnosisMedicinesRequest : CHSRequest
    {
        public long PatientDiagnosisNumber { get; set; }
    }
}