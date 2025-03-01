using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CHS.Client.API.Models.PatientsDiagnosis;

namespace CHS.Client.API.Models.Pharmacies
{
    public class GetPatientsDiagnosisMedicinesResponse : CHSResponse
    {
        public List<MedicineDose> Medicines;
        public GetPatientsDiagnosisMedicinesResponse()
        {
            Medicines = new List<MedicineDose>();
        }
    }
}