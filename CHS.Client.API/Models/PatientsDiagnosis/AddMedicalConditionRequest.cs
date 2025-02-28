using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CHS.Client.API.Models.PatientsDiagnosis
{
    [ApiUri("/PatientsDiagnosis/AddMedicalCondition")]
    public class AddMedicalConditionRequest : CHSRequest
    {
        public long PatientDiagnosisNumber { get; set; }
        public List<string> MedicalConditions { get; set; }
        public bool IsChronic { get; set; }
        public List<MedicineDose> Medicines { get; set; }
    }
    public class MedicineDose
    {
        public long ID { get; set; }
        public long MedicineID { get; set; }
        public string Dose { get; set; }
        public string DoseTime { get; set; }
        public string PeriodUse { get; set; }
        public bool Dispensed { get; set; }

    }
}
