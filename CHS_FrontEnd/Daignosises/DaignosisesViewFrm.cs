using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CHS_FrontEnd
{
    public partial class DaignosisesViewFrm : Form
    {
        public DaignosisesViewFrm(long PatientDiagnosisNumber, string CreateAt, string Symptoms, string lastUpdateTimeSysmptoms, string medicalConditions, string enterTimeMedicalConditions,  bool createByCurrentDoctor , bool isChronic 
                              )
        {
            InitializeComponent();
            MedicalCondlbl.Text = medicalConditions;
            daignosisNumberlbl.Text = PatientDiagnosisNumber.ToString();
            dateOfMedlbl.Text = enterTimeMedicalConditions;
            chislbl.Text = isChronic ? "مزمن" : "عير مزمن";
        }

        private void guna2ContainerControl1_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }
    }
}
