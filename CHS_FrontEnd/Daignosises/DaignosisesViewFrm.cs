using CHS.Client.API.Models.Labs;
using CHS.Client.API;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CHS.Client.API.Models.Pharmacies;
using CHS_FrontEnd.Labs___ED;

namespace CHS_FrontEnd
{

    public partial class DaignosisesViewFrm : Form

    {
        long PatientDiagnosisNumber;
        public DaignosisesViewFrm(long PatientDiagnosisNumber, string CreateAt, string Symptoms, string lastUpdateTimeSysmptoms, string medicalConditions, string enterTimeMedicalConditions,  bool createByCurrentDoctor , bool isChronic 
                              )
        {
            InitializeComponent();
            this.PatientDiagnosisNumber = PatientDiagnosisNumber;
            MedicalCondlbl.Text = medicalConditions;
            daignosisNumberlbl.Text = PatientDiagnosisNumber.ToString();
            dateOfMedlbl.Text = enterTimeMedicalConditions;
            chislbl.Text = isChronic ? "مزمن" : "عير مزمن";
            try
            {
                // 1️⃣ إنشاء الطلب (Request) وإرساله إلى الـ API
                GetPatientsDiagnosisMedicinesRequest request = new GetPatientsDiagnosisMedicinesRequest
                {
                    PatientDiagnosisNumber = PatientDiagnosisNumber,
                    RequestID = Guid.NewGuid().ToString()
                };

                // 2️⃣ إرسال الطلب واستلام الاستجابة
                GetPatientsDiagnosisMedicinesResponse response =
                    RequestSender.SendRequest<GetPatientsDiagnosisMedicinesRequest, GetPatientsDiagnosisMedicinesResponse>(request);

                // 3️⃣ التحقق من صحة الاستجابة
                if (response != null && response.Medicines != null && response.Medicines.Count > 0)
                {
                    // 4️⃣ عرض البيانات في DataGridView أو ListBox أو ComboBox
                    gunaDataGridView1.DataSource = response.Medicines;
                }
                else
                {
                    MessageBox.Show("لم يتم العثور على أي أدوية لهذا التشخيص.", "معلومة", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("حدث خطأ أثناء جلب الأدوية: " + ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void guna2ContainerControl1_Click(object sender, EventArgs e)
        {

        }



        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (PatientDiagnosisNumber <= 0) return;
            ShowLabTestsResultsFrm frm = new ShowLabTestsResultsFrm(PatientDiagnosisNumber);
            frm.ShowDialog();
        }
    }
}
