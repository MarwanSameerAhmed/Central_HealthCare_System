using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CHS.Client.API.Models.Pharmacies
{
    [ApiUri("/Pharmacies/GetLabMedicines", RequestMethod.Get)]
    public class GetMedicinesResponse : CHSResponse
    {
        public List<Medicine> Medicines { get; set; }
        public GetMedicinesResponse()
        {
            Medicines = new List<Medicine>();
        }
    }

    public class Medicine
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string DosageFom { get; set; }
        public string ActiveIngredients { get; set; }
    }
}