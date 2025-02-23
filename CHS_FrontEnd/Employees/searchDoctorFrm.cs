using CHS.Client.API.Models.Employees;
using CHS.Client.API;
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
    public partial class searchDoctor : Form
    {
        public searchDoctor(DockPanel dockPanel)
        {
            InitializeComponent();
        }

       

        private void guna2VScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void searchDoctor_Load(object sender, EventArgs e)
        {
            guna2VScrollBar1.ValueChanged += searchDoctorView_ValueChanged;
            guna2VScrollBar1.Maximum = searchDoctorView.RowCount - 1;
            guna2VScrollBar1.Minimum = 0;
            guna2VScrollBar1.Value = 0;
            searchDoctorView.MouseWheel += searchDoctorView_MouseWheel;
            ApplyEventsToTextBoxes(guna2ContainerControl1);


            UpdateScrollBar();

        }
        private void searchDoctorView_ValueChanged(object sender, EventArgs e)
        {

            if (guna2VScrollBar1.Value < 0)
                guna2VScrollBar1.Value = 0;
            else if (guna2VScrollBar1.Value > guna2VScrollBar1.Maximum)
                guna2VScrollBar1.Value = guna2VScrollBar1.Maximum;


            if (searchDoctorView.RowCount > 0)
            {

                int rowIndex = guna2VScrollBar1.Value;
                if (rowIndex >= searchDoctorView.RowCount)
                    rowIndex = searchDoctorView.RowCount - 1;

                searchDoctorView.FirstDisplayedScrollingRowIndex = rowIndex;
            }
        }
        private void UpdateScrollBar()
        {
            int totalRows = searchDoctorView.RowCount;


            guna2VScrollBar1.Maximum = totalRows - 1;


            guna2VScrollBar1.LargeChange = totalRows / 3;
            guna2VScrollBar1.SmallChange = 1;
        }
        private void searchDoctorView_MouseWheel(object sender, MouseEventArgs e)
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

        private void searchDoctorView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                DoctorViewrFrmcs detailsForm = new DoctorViewrFrmcs();
                detailsForm.Show();
            }


        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            try
            {

                string DoctorNumber = IdNumber.Text.Trim();
                string DoctorName = NameSearchtxt.Text.Trim();
                string Doctorphone = phoneSearchtxt.Text.Trim();


                int searchType;
                string searchValue;

                if (!string.IsNullOrWhiteSpace(DoctorNumber))
                {
                    searchType = (int)SearchDoctorsFilesType.DoctorNumber;
                    searchValue = DoctorNumber;
                }
                else if (!string.IsNullOrWhiteSpace(DoctorName))
                {
                    searchType = (int)SearchDoctorsFilesType.DoctorName;
                    searchValue = DoctorName;
                }
                else if (!string.IsNullOrWhiteSpace(Doctorphone))
                {
                    searchType = (int)SearchDoctorsFilesType.DoctorPhone;
                    searchValue = Doctorphone;
                }
                else
                {
                    MessageBox.Show("يرجى إدخال قيمة البحث!", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }


                SearchDoctorsFilesRequest request = new SearchDoctorsFilesRequest
                {
                    SearchType = searchType,
                    SearchValue = searchValue,
                    RequestID = Guid.NewGuid().ToString()
                };


                SearchDoctorFilesResponse response = RequestSender.SendRequest<SearchDoctorsFilesRequest, SearchDoctorFilesResponse>(request);

                if (response.DoctorFile != null && response.DoctorFile.Count > 0)
                {
                    var formattedData = response.DoctorFile.Select(p => new
                    {
                        DoctorName = p.DoctorName,
                        DoctorJobTitle = p.DoctorJobTitle,
                        DoctorPhoneNumber = string.Join(", ", p.DoctorPhoneNumber),
                        DoctorEmployementDate = p.DoctorEmployementDate,


                        IDCardNumber = p.DoctorIDCardNumber,
                        BirthDate = p.DoctorBirthData,
                        IsMale = p.DoctorIsMale,
                        DoctorNumber = p.DoctorNumber,
                        DoctorEmails = p.DoctorEmail,
                        DoctorLice = p.DoctorLicenseNumber,
                        DoctorLiceExp = p.LicenseExpiryDate,
                        DoctorLiceRele = p.LicenseReleaseDate,
                        DoctorMedicalSep = p.MedicalSpecialization,


                    }).ToList();


                    searchDoctorView.Rows.Clear();

                    foreach (var item in formattedData)
                    {
                        int rowIndex = searchDoctorView.Rows.Add();
                        searchDoctorView.Rows[rowIndex].Cells["doctorName"].Value = item.DoctorName;
                        searchDoctorView.Rows[rowIndex].Cells["doctorPhoneNumber"].Value = item.DoctorPhoneNumber;
                        searchDoctorView.Rows[rowIndex].Cells["doctorMiagor"].Value = item.DoctorJobTitle;
                        searchDoctorView.Rows[rowIndex].Cells["doctorNumber"].Value = item.DoctorNumber;


                        searchDoctorView.Rows[rowIndex].Tag = item;
                    }

                }

                else
                {
                    MessageBox.Show("لم يتم العثور على أي مريض.", "نتيجة البحث", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    searchDoctorView.DataSource = null;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"خطأ أثناء البحث: {ex.Message}", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void SearchFields_TextChanged(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(NameSearchtxt.Text) &&
                string.IsNullOrWhiteSpace(IdNumber.Text) &&
                string.IsNullOrWhiteSpace(phoneSearchtxt.Text))
            {
                searchDoctorView.Rows.Clear();
            }
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

        private void IdNumber_TextChanged(object sender, EventArgs e)
        {

        }
    }
    }

