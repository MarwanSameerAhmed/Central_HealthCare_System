using CHS.Client.API;
using CHS.Client.API.Models.PatientsDiagnosis;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace CHS_FrontEnd
{
    public partial class PatientFileView : Form
    {
        private DockPanel dockPanel;
        public PatientFileView(DockPanel dockPanel, string fullName, int age, string phoneNumber, long medicalNumber,
                              string idCardNumber, string birthDate, bool isMale,
                              string patientAddress, string bloodType, string maritalStatus, string companionName, string birthPlace)
        {
            InitializeComponent();
            this.dockPanel = dockPanel;

            medicalNum.Text = medicalNumber.ToString();
            veiwtNamelbl.Text = fullName;
            viewAgelbl.Text = age.ToString();
            veiwBirthDaylbl.Text = birthDate;
            viewStatelbl.Text = birthPlace;
            viewCumlbl.Text = maritalStatus;
            viewPhonelbl.Text = phoneNumber;
            viewbloodlbl.Text = bloodType;
            typeLbl.Text = isMale ? "ذكر" : "أنثى";
            addresslbl.Text = patientAddress;
            fathlbl.Text = companionName;

            try
            {
                SearchPatientDiagnosisRequest request = new SearchPatientDiagnosisRequest() { PatientNumber = medicalNumber, RequestID = Guid.NewGuid().ToString() };
                var response = RequestSender.SendRequest<SearchPatientDiagnosisRequest, SearchPatientDiagnosisResponse>(request);
                if (response is null) return;
                if (response.PatientsDiagnosisFiles != null && response.PatientsDiagnosisFiles.Count > 0)
                    FillDiagnosis(response.PatientsDiagnosisFiles);
            }
            catch (Exception ex)
            {
                CustomMessageBox.Show(CustomMessageBox.MessageType.Error, "خطأ", ex.Message);
            }


        }

        private void FillDiagnosis(List<PatientsDiagnosisFile> patientsDiagnosisFiles)
        {
            if (patientsDiagnosisFiles != null && patientsDiagnosisFiles.Count > 0)
            {
                var formattedData = patientsDiagnosisFiles.Select(p => new
                {
                    PatientDiagnosisNumber = p.PatientDiagnosisNumber,
                    CreateAt = p.CreatedAt,
                    Symptoms = string.Join(", ", p.Symptoms),
                    lastUpdateTimeSysmptoms = p.LastUpdateTimeSymptoms,


                    medicalConditions = string.Join(", ", p.MedicalConditions),
                    enterTimeMedicalConditions = p.EnterTimeMedicalCondition,
                    createByCurrentDoctor = p.CreatedByCurrentDoctor,
                    isChronic = p.IsChronic,


                }).ToList();


                //   Viewdaig.Rows.Clear();

                foreach (var item in formattedData)
                {
                    int rowIndex = Viewdaig.Rows.Add();
                    Viewdaig.Rows[rowIndex].Cells["diagnosisName"].Value = item.Symptoms;
                    Viewdaig.Rows[rowIndex].Cells["finalDiagnosis"].Value = item.medicalConditions;
                    Viewdaig.Rows[rowIndex].Cells["DaigonsisDate"].Value = item.CreateAt;




                    Viewdaig.Rows[rowIndex].Tag = item;
                }

            }
        }

        private void PopulatePatientCardData()
        {



            string allergies = "غبار, فول سوداني, سمك";
            alg.Text = allergies;
            string medications = "دواء A, دواء B, دواء C";
            medlbl.Text = medications;
            string chronicDiseases = "سكري, ضغط دم مرتفع, كوليسترول";
            dislbl.Text = chronicDiseases;



        }





        private void AddDemoData()
        {
            Viewdaig.Rows.Add("حالة مرضية 1", "2024-12-01", "فحص دم كامل", "دواء A, دواء B", "دكتور أحمد");
            Viewdaig.Rows.Add("حالة مرضية 2", "2024-11-15", "فحص بول", "دواء C", "دكتور محمد");
            Viewdaig.Rows.Add("حالة مرضية 3", "2024-10-10", "أشعة سينية", "دواء D, دواء E", "دكتورة ليلى");
            Viewdaig.Rows.Add("حالة مرضية 1", "2024-12-01", "فحص دم كامل", "دواء A, دواء B", "دكتور أحمد");
            Viewdaig.Rows.Add("حالة مرضية 2", "2024-11-15", "فحص بول", "دواء C", "دكتور محمد");
            Viewdaig.Rows.Add("حالة مرضية 3", "2024-10-10", "أشعة سينية", "دواء D, دواء E", "دكتورة ليلى");



        }

        private void Form1_Load(object sender, EventArgs e)
        {


            guna2VScrollBar1.ValueChanged += guna2VScrollBar1_ValueChanged;
            guna2VScrollBar1.Maximum = Viewdaig.RowCount - 1;
            guna2VScrollBar1.Minimum = 0;
            guna2VScrollBar1.Value = 0;
            Viewdaig.MouseWheel += dataGridView1_MouseWheel;
            PopulatePatientCardData();
            //  AddDemoData();
            UpdateScrollBar();

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

            addNewDaignosis newform = new addNewDaignosis(long.Parse(medicalNum.Text),-1);
            newform.StartPosition = FormStartPosition.CenterScreen;
            newform.Show();

        }
        private void guna2VScrollBar1_ValueChanged(object sender, EventArgs e)
        {

            if (guna2VScrollBar1.Value < 0)
                guna2VScrollBar1.Value = 0;
            else if (guna2VScrollBar1.Value > guna2VScrollBar1.Maximum)
                guna2VScrollBar1.Value = guna2VScrollBar1.Maximum;


            if (Viewdaig.RowCount > 0)
            {

                int rowIndex = guna2VScrollBar1.Value;
                if (rowIndex >= Viewdaig.RowCount)
                    rowIndex = Viewdaig.RowCount - 1;

                Viewdaig.FirstDisplayedScrollingRowIndex = rowIndex;
            }
        }
        private void UpdateScrollBar()
        {
            int totalRows = Viewdaig.RowCount;


            guna2VScrollBar1.Maximum = totalRows - 1;


            guna2VScrollBar1.LargeChange = totalRows / 3;
            guna2VScrollBar1.SmallChange = 1;
        }

        private void dataGridView1_MouseWheel(object sender, MouseEventArgs e)
        {

            if (e.Delta > 0)
            {

                if (guna2VScrollBar1.Value > 0)
                {
                    guna2VScrollBar1.Value -= 1;
                }
            }
            else if (e.Delta < 0)
            {

                if (guna2VScrollBar1.Value < guna2VScrollBar1.Maximum)
                {
                    guna2VScrollBar1.Value += 1;
                }
            }
        }

      
            private void Viewdaig_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
            {
                if (e.RowIndex >= 0)
                {
                    var selectedRow = Viewdaig.Rows[e.RowIndex];
               
                    var rowData = selectedRow.Tag as dynamic;

                    if (string.IsNullOrWhiteSpace(rowData.medicalConditions) && rowData.createByCurrentDoctor)
                    {
                        long patientDiagnosisNumber = rowData.PatientDiagnosisNumber; 
                        long medicalNumber = long.Parse(medicalNum.Text); 

                      
                        addNewDaignosis addForm = new addNewDaignosis(medicalNumber, patientDiagnosisNumber);
                        addForm.Show();
                }
                else
                {
                    DaignosisesViewFrm addForm = new DaignosisesViewFrm();
                    addForm.Show();
                }
                }
            }

        


        private void guna2ContainerControl5_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Viewdaig_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Viewdaig_DoubleClick(object sender, EventArgs e)
        {


        }
    }
}


