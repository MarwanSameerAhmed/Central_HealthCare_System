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
                              string patientAddress, string bloodType, string maritalStatus, string companionName, string birthPlace,string allergies)
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
            

            
            string allergiesData = allergies;
            if (!string.IsNullOrEmpty(allergiesData))
            {
                string[] allergiesArray = allergiesData.Split(';');
                flowLayoutPanel1.Controls.Clear();

                foreach (var allergy in allergiesArray)
                {
                    AddChip(allergy);
                }

            }
            else
            {
                ShowNoDataMessage();
            }
        

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
        void AddChip(string allergy)
        {
            Label chip = new Label();
            chip.Text = allergy;
            chip.Font = new Font("Traditional Arabic", 15, FontStyle.Bold);  // تغيير الخط
            chip.AutoSize = true;
            chip.BackColor = Color.WhiteSmoke;  // تغيير الخلفية
            chip.ForeColor = Color.Black;  // تغيير لون النص
            chip.Padding = new Padding(5);
            chip.Margin = new Padding(3);
            chip.BorderStyle = BorderStyle.FixedSingle;
            chip.TextAlign = System.Drawing.ContentAlignment.TopRight;

            flowLayoutPanel1.Controls.Add(chip);
        }

        void ShowNoDataMessage()
        {
            Label noDataLabel = new Label();
            noDataLabel.Text = " لا يوجد اي حساسيات";
            noDataLabel.Font = new Font("Traditional Arabic", 15, FontStyle.Bold);
            noDataLabel.AutoSize = true;
            noDataLabel.ForeColor = Color.Gray;
            noDataLabel.Padding = new Padding(5);
            flowLayoutPanel1.Controls.Add(noDataLabel);
        }

        void ShowNoDataMessagesdes()
        {
            Label noDataLabel = new Label();
            noDataLabel.Text = " لا يوجد أمراض مزمنة";
            noDataLabel.Font = new Font("Traditional Arabic", 15, FontStyle.Bold);
            noDataLabel.AutoSize = true;
            noDataLabel.ForeColor = Color.Gray;
            noDataLabel.Padding = new Padding(5);
            flowLayoutPanel2.Controls.Add(noDataLabel);
        }

      

        private void ShowNoDataMessage(FlowLayoutPanel panel, string message)
        {
            Label noDataLabel = new Label
            {
                Text = message,
                Font = new Font("Traditional Arabic", 15, FontStyle.Bold),
                AutoSize = true,
                ForeColor = Color.Gray,
                Padding = new Padding(5)
            };

            panel.Controls.Add(noDataLabel);
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
                    isChronic = p.IsChronic
                }).ToList();

                Viewdaig.Rows.Clear(); // مسح أي بيانات سابقة في الجدول

                List<string> chronicConditionsList = new List<string>();

                foreach (var item in formattedData)
                {
                    int rowIndex = Viewdaig.Rows.Add();
                    Viewdaig.Rows[rowIndex].Cells["diagnosisName"].Value = item.Symptoms;
                    Viewdaig.Rows[rowIndex].Cells["finalDiagnosis"].Value = item.medicalConditions;
                    Viewdaig.Rows[rowIndex].Cells["DaigonsisDate"].Value = item.CreateAt;
                    Viewdaig.Rows[rowIndex].Cells["daignosisNumber"].Value = item.PatientDiagnosisNumber;



                    Viewdaig.Rows[rowIndex].Tag = item;

                    // ✅ استخراج الأمراض المزمنة فقط
                    if (item.isChronic && !string.IsNullOrWhiteSpace(item.medicalConditions))
                    {
                        chronicConditionsList.Add(item.medicalConditions);
                    }
                }

                // ✅ عرض الأمراض المزمنة في `FlowLayoutPanel`
                DisplayChronicConditions(chronicConditionsList);
            }
        }


        private void DisplayChronicConditions(List<string> chronicConditions)
        {
            flowLayoutPanel2.Controls.Clear(); // مسح البيانات السابقة

            if (chronicConditions.Any())
            {
                foreach (var condition in chronicConditions)
                {
                    AddChip(condition, flowLayoutPanel2);
                }
            }
            else
            {
                ShowNoDataMessage(flowLayoutPanel2, "لا يوجد أمراض مزمنة");
            }
        }








        private void Form1_Load(object sender, EventArgs e)
        {


            guna2VScrollBar1.ValueChanged += guna2VScrollBar1_ValueChanged;
            guna2VScrollBar1.Maximum = Viewdaig.RowCount - 1;
            guna2VScrollBar1.Minimum = 0;
            guna2VScrollBar1.Value = 0;
            Viewdaig.MouseWheel += dataGridView1_MouseWheel;
     
           
            UpdateScrollBar();

        }
        private void LoadPatientDiagnosisData(long medicalNumber)
        {
            try
            {
                SearchPatientDiagnosisRequest request = new SearchPatientDiagnosisRequest()
                {
                    PatientNumber = medicalNumber,
                    RequestID = Guid.NewGuid().ToString()
                };

                var response = RequestSender.SendRequest<SearchPatientDiagnosisRequest, SearchPatientDiagnosisResponse>(request);
                if (response is null) return;

                FillDiagnosis(response.PatientsDiagnosisFiles);
            }
            catch (Exception ex)
            {
                CustomMessageBox.Show(CustomMessageBox.MessageType.Error, "خطأ", ex.Message);
            }
        }



        private void guna2Button1_Click(object sender, EventArgs e)
        {

            addNewDaignosis newform = new addNewDaignosis(long.Parse(medicalNum.Text), -1);
            newform.StartPosition = FormStartPosition.CenterScreen;

            newform.DiagnosisAdded += () =>
            {
                Viewdaig.Rows.Clear(); 
                LoadPatientDiagnosisData(long.Parse(medicalNum.Text)); 
            };

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
                    var patientDetailsPage = new DaignosisesViewFrm(

                       rowData.PatientDiagnosisNumber,
                       rowData.CreateAt,
                       rowData.Symptoms,
                       rowData.lastUpdateTimeSysmptoms,
                        rowData.medicalConditions,
                         rowData.enterTimeMedicalConditions,
                       rowData.createByCurrentDoctor,
                       rowData.isChronic
                     
                          
                        
                          

                       );
                    patientDetailsPage.Show();
                }
                }
            }




        private void AddChip(string text, FlowLayoutPanel panel, bool isMessage = false)
        {
            Label chip = new Label
            {
                Text = text,
                Font = new Font("Traditional Arabic", 14, FontStyle.Bold),
                AutoSize = true,
                ForeColor = isMessage ? Color.Gray : Color.Black,
                BackColor = isMessage ? Color.Transparent : Color.WhiteSmoke,
                Padding = new Padding(5),
                Margin = new Padding(3),
                BorderStyle = isMessage ? BorderStyle.None : BorderStyle.FixedSingle,
                TextAlign = ContentAlignment.MiddleCenter
            };

            panel.Controls.Add(chip);
        }

        private void fathlbl_Click(object sender, EventArgs e)
        {

        }
    }
}


