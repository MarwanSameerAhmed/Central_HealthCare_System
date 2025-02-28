using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CHS.Client.API.Models.Pharmacies
{
    [ApiUri("/Pharmacies/DispensedMedicines")]
    public class DispensedMedicinesRequest : CHSRequest
    {
        public long PatientDiagnosisNumber { get; set; }
        public List<long> MedicineDoseIDs { get; set; }
    }
}