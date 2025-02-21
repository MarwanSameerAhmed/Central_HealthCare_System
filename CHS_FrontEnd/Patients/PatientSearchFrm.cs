using CHS.Client.API;
using CHS.Client.API.Models.Patients;
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
    public partial class searchPatientFrm : Form
    {
        private DockPanel dockPanel;

        private Form currentForm = null;
        public searchPatientFrm(DockPanel dockPanel)
        {
            InitializeComponent();
            this.dockPanel = dockPanel;
        }

        private void OpenForm(Form childForm)
        {

            if (currentForm != null && currentForm.GetType() == childForm.GetType())
            {

                return;
            }
            currentForm = childForm;


            childForm.TopLevel = false;

            var dockContent = new DockContent()
            {
                Text = childForm.Text
            };

            childForm.Dock = DockStyle.Fill;
            dockContent.Controls.Add(childForm);
            childForm.Show();
            dockContent.Show(dockPanel);

        }

        private void guna2ContainerControl3_Click(object sender, EventArgs e)
        {

        }

        private void guna2ContainerControl1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
           
            UpdateScrollBar();
            nationalSearchtxt.TextChanged += SearchFields_TextChanged;
            midSearchtxt.TextChanged += SearchFields_TextChanged;
            phoneSearchtxt.TextChanged += SearchFields_TextChanged;
            ApplyEventsToTextBoxes(guna2ContainerControl1);


        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void guna2VScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            searchPatientView.FirstDisplayedScrollingRowIndex = guna2VScrollBar1.Value;
        }
        private void UpdateScrollBar()
        {
            if (searchPatientView.RowCount > 0)
            {
                guna2VScrollBar1.Maximum = searchPatientView.RowCount - 1;
                guna2VScrollBar1.LargeChange = searchPatientView.DisplayedRowCount(false);
                guna2VScrollBar1.SmallChange = 1;


                if (guna2VScrollBar1.Value > guna2VScrollBar1.Maximum)
                {
                    guna2VScrollBar1.Value = guna2VScrollBar1.Maximum;
                }
            }
            else
            {
                guna2VScrollBar1.Maximum = 0;
                guna2VScrollBar1.LargeChange = 0;
                guna2VScrollBar1.SmallChange = 0;
            }
        }


        private void RemoveData()
        {
            if (searchPatientView.Rows.Count > 0)
            {
                searchPatientView.Rows.RemoveAt(0);
                UpdateScrollBar();
            }
        }
        private void searchPatientView_MouseWheel(object sender, MouseEventArgs e)
        {
            if (searchPatientView.RowCount > 0)
            {
                int scrollAmount = e.Delta > 0 ? -1 : 1;
                int newValue = guna2VScrollBar1.Value + scrollAmount;

                if (newValue >= guna2VScrollBar1.Minimum && newValue <= guna2VScrollBar1.Maximum)
                {
                    guna2VScrollBar1.Value = newValue;
                    searchPatientView.FirstDisplayedScrollingRowIndex = guna2VScrollBar1.Value;
                }
            }
        }



        private void searchPatientView_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0) 
            {
               
                DataGridViewRow selectedRow = searchPatientView.Rows[e.RowIndex];
              
                var patientData = selectedRow.Tag as dynamic;
                if (patientData != null)
                {
                    
                    var patientDetailsPage = new PatientFileView(
                        dockPanel,
                        patientData.FullName,
                        patientData.Age,
                        patientData.PhoneNumber,
                        patientData.MedicalNumber,
                        patientData.IDCardNumber,
                        patientData.BirthDate,
                        patientData.IsMale,
                        patientData.PatientAddress,
                        patientData.BloodType,
                        patientData.maritalStatus,
                        patientData.companionName,
                        patientData.birthPlace



                    );


                    OpenForm(patientDetailsPage);
                }
            }
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            try
            {

                string patientNumber = nationalSearchtxt.Text.Trim();
                string patientName = midSearchtxt.Text.Trim();
                string phoneNumber = phoneSearchtxt.Text.Trim();


                int searchType;
                string searchValue;

                if (!string.IsNullOrWhiteSpace(patientNumber))
                {
                    searchType = (int)SearchPatientsFilesType.PatientNumber;
                    searchValue = patientNumber;
                }
                else if (!string.IsNullOrWhiteSpace(patientName))
                {
                    searchType = (int)SearchPatientsFilesType.PatientName;
                    searchValue = patientName;
                }
                else if (!string.IsNullOrWhiteSpace(phoneNumber))
                {
                    searchType = (int)SearchPatientsFilesType.PatientPhone;
                    searchValue = phoneNumber;
                }
                else
                {
                    MessageBox.Show("يرجى إدخال قيمة البحث!", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }


                SearchPatientsFilesRequest request = new SearchPatientsFilesRequest
                {
                    SearchType = searchType,
                    SearchValue = searchValue,
                    RequestID = Guid.NewGuid().ToString()
                };


                SearchPatientsFilesResponse response = RequestSender.SendRequest<SearchPatientsFilesRequest, SearchPatientsFilesResponse>(request);

                if (response.PaitientsFiles != null && response.PaitientsFiles.Count > 0)
                {
                    var formattedData = response.PaitientsFiles.Select(p => new
                    {
                        FullName = p.PatientName,
                        Age = CalculateAge(p.BirthDate),
                        PhoneNumber = string.Join(", ", p.PatientPhones),
                        MedicalNumber = p.PatientNumber,

                     
                        IDCardNumber = p.IDCardNumber,
                        BirthDate = p.BirthDate,
                        IsMale = p.IsMale,
                        PatientAddress = p.PatientAddress,
                        BloodType = p.BloodType,
                        maritalStatus = p.maritalStatus,
                        birthPlace= p.birthPlace,
                        companionName = p.companionName,

                    }).ToList();

                   
                    searchPatientView.Rows.Clear();

                    foreach (var item in formattedData)
                    {
                        int rowIndex = searchPatientView.Rows.Add();
                        searchPatientView.Rows[rowIndex].Cells["Column_FullName"].Value = item.FullName;
                        searchPatientView.Rows[rowIndex].Cells["Column_Age"].Value = item.Age;
                        searchPatientView.Rows[rowIndex].Cells["Column_PhoneNumber"].Value = item.PhoneNumber;
                        searchPatientView.Rows[rowIndex].Cells["Column_MedicalNumber"].Value = item.MedicalNumber;
                        searchPatientView.Rows[rowIndex].Cells["Column_State"].Value = item.birthPlace;




                        searchPatientView.Rows[rowIndex].Tag = item;
                    }

                }

                else
                {
                    MessageBox.Show("لم يتم العثور على أي مريض.", "نتيجة البحث", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    searchPatientView.DataSource = null;
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show($"خطأ أثناء البحث: {ex.Message}", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void SearchFields_TextChanged(object sender, EventArgs e)
        {
           
            if (string.IsNullOrWhiteSpace(nationalSearchtxt.Text) &&
                string.IsNullOrWhiteSpace(midSearchtxt.Text) &&
                string.IsNullOrWhiteSpace(phoneSearchtxt.Text))
            {
                searchPatientView.Rows.Clear(); 
            }
        }

        private int CalculateAge(string birthDateString)
        {
            if (DateTime.TryParse(birthDateString, out DateTime birthDate))
            {
                int age = DateTime.Today.Year - birthDate.Year;
                if (birthDate > DateTime.Today.AddYears(-age)) age--; 
                return age;
            }
            return 0;
        }
        private void ApplyEventsToTextBoxes(Control parentControl)
        {
            foreach (Control control in parentControl.Controls)
            {
                if (control is Guna.UI2.WinForms.Guna2TextBox textBox)
                {
                    textBox.Enter += Guna2TextBox_Enter;
                    textBox.Leave += Guna2TextBox_Leave;
                }
                else if (control.HasChildren)
                {

                    ApplyEventsToTextBoxes(control);
                }
            }
        }

        private Font normalFont = new Font("Traditional Arabic", 12.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));


        private Font largeFont = new Font("Traditional Arabic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));


        private void Guna2TextBox_Enter(object sender, EventArgs e)
        {
            Guna2TextBox textBox = sender as Guna2TextBox;
            if (textBox != null)
            {
                textBox.Font = largeFont;
            }
        }


        private void Guna2TextBox_Leave(object sender, EventArgs e)
        {
            Guna2TextBox textBox = sender as Guna2TextBox;
            if (textBox != null)
            {
                textBox.Font = normalFont;
            }
        }
    }
}

