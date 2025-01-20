using CHS.Client.API.Models;
using System;
using System.Collections.Generic;

namespace CHS.Client.API.Models.Patients
{
    public class SearchPatientsFilesResponse : CHSResponse
    {
        public List<PaitientFile> PaitientsFiles { get; set; }
    }
}