using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CHS.Client.API.Models;

namespace CHS.Client.API.Models.Patients
{
    public enum SearchPatientsFilesType
    {
        PatientNumber = 1,
        PatientName = 2,
        PatientPhone = 3
    }

    [ApiUri("/Patients/SearchPatientFile")]
    public class SearchPatientsFilesRequest : CHSRequest
    {
        public int SearchType { get; set; }
        public string SearchValue { get; set; }

    }
}