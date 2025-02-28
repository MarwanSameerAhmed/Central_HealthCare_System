using CHS.Client.API.Models;
using CHS.Client.API.Models.Labs;
using CHS.Client.API.Models.Pharmacies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CHS.Client.API.Helper_Classes
{
    public static class Cache
    {
        public static List<LabTest> LabTests { get; set; }
        public static List<Medicine> Medicines { get; set; }

        public static void InitialCache()
        {
            InitialLabTests();
            InitialMedicines();
        }

        private static void InitialLabTests()
        {
            if (!(LabTests is null)) return;
                
            GetLabTestsResponse response = RequestSender.SendRequest<CHSRequest, GetLabTestsResponse>(null);
            if (response is null) return;
            LabTests = response.LabTests;
        }

        private static void InitialMedicines()
        {
            if (!(Medicines is null)) return;

            GetMedicinesResponse response = RequestSender.SendRequest<CHSRequest, GetMedicinesResponse>(null);
            if (response is null) return;
            Medicines = response.Medicines;
        }
    }
}
