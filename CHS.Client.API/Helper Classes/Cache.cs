using CHS.Client.API.Models;
using CHS.Client.API.Models.Labs;
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

        public static void InitialCache()
        {
            InitialLabTests();
        }

        private static void InitialLabTests()
        {
            if (!(LabTests is null)) return;
                
            GetLabTestsResponse response = RequestSender.SendRequest<CHSRequest, GetLabTestsResponse>(null);
            if (response is null) return;
            LabTests = response.LabTests;
        }
    }
}
