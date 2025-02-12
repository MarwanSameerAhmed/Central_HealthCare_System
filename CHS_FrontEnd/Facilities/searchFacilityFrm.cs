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
using CHS.Client.API.Models.Facilities;

namespace CHS_FrontEnd
{
    public partial class searchPlacemenet : Form
    {
        public searchPlacemenet(DockPanel dockPanel)
        {
            InitializeComponent();


            guna2VScrollBar1.ValueChanged += guna2VScrollBar1_ValueChanged;
            guna2VScrollBar1.Maximum = searchFacilityView.RowCount - 1;
            guna2VScrollBar1.Minimum = 0;
            guna2VScrollBar1.Value = 0;
            searchFacilityView.MouseWheel += dataGridView1_MouseWheel;
            UpdateScrollBar();
            ApplyEventsToTextBoxes(guna2ContainerControl1);
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
        private void guna2VScrollBar1_ValueChanged(object sender, EventArgs e)
        {

            if (guna2VScrollBar1.Value < 0)
                guna2VScrollBar1.Value = 0;
            else if (guna2VScrollBar1.Value > guna2VScrollBar1.Maximum)
                guna2VScrollBar1.Value = guna2VScrollBar1.Maximum;


            if (searchFacilityView.RowCount > 0)
            {

                int rowIndex = guna2VScrollBar1.Value;
                if (rowIndex >= searchFacilityView.RowCount)
                    rowIndex = searchFacilityView.RowCount - 1;

                searchFacilityView.FirstDisplayedScrollingRowIndex = rowIndex;
            }
        }
        private void UpdateScrollBar()
        {
            int totalRows = searchFacilityView.RowCount;


            guna2VScrollBar1.Maximum = totalRows - 1;


            guna2VScrollBar1.LargeChange = totalRows / 3;
            guna2VScrollBar1.SmallChange = 1;
        }

        private void searchFacilityView_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {

                FacilityViewrFrm detailsForm = new FacilityViewrFrm();
                detailsForm.Show();
            }
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            try
            {

             
                string FacilitiesName = midSearchtxt.Text.Trim();
                string FacilitiesPhoneNumber = phoneSearchtxt.Text.Trim();


                int searchType;
                string searchValue;

                if (!string.IsNullOrWhiteSpace(FacilitiesName))
                {
                    searchType = (int)SearchFacilitiesFilesType.FacilitiesName;
                    searchValue = FacilitiesName;
                }
               
                else if (!string.IsNullOrWhiteSpace(FacilitiesPhoneNumber))
                {
                    searchType = (int)SearchFacilitiesFilesType.FacilitiesPhoneNumber;
                    searchValue = FacilitiesPhoneNumber;
                }
                else
                {
                    MessageBox.Show("يرجى إدخال قيمة البحث!", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }


                SearchFacilitiesFilesRequest request = new SearchFacilitiesFilesRequest
                {
                    SearchType = searchType,
                    SearchValue = searchValue,
                    RequestID = Guid.NewGuid().ToString()
                };


                SearchFacilitiesFileResponse response = RequestSender.SendRequest<SearchFacilitiesFilesRequest, SearchFacilitiesFileResponse>(request);

                if (response.FacilitiesFiles != null && response.FacilitiesFiles.Count > 0)
                {
                    var formattedData = response.FacilitiesFiles.Select(p => new
                    {
                        FacilitiesName = p.FacilityName,
                        FacilityAddress = p.FacilityAddress,
                        FacilitiesPhoneNumber = string.Join(", ", p.FacilityPhones),
                        FacilityEmail = p.FacilityEmail,
                        FacilityType = p.FacilityType,
                       


                    }).ToList();


                    searchFacilityView.Rows.Clear();

                    foreach (var item in formattedData)
                    {
                        int rowIndex = searchFacilityView.Rows.Add();
                        searchFacilityView.Rows[rowIndex].Cells["FacilityName"].Value = item.FacilitiesName;
                        searchFacilityView.Rows[rowIndex].Cells["FacilityType"].Value = item.FacilityType;
                        searchFacilityView.Rows[rowIndex].Cells["FacilityAddress"].Value = item.FacilityAddress;
                        searchFacilityView.Rows[rowIndex].Cells["FacilityEmail"].Value = item.FacilityEmail;


                        searchFacilityView.Rows[rowIndex].Tag = item;
                    }

                }

                else
                {
                    MessageBox.Show("لم يتم العثور على أي مريض.", "نتيجة البحث", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    searchFacilityView.DataSource = null;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"خطأ أثناء البحث: {ex.Message}", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    
        private void SearchFields_TextChanged(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(midSearchtxt.Text) &&
               
                string.IsNullOrWhiteSpace(phoneSearchtxt.Text))
            {
                searchFacilityView.Rows.Clear();
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
    }
    }

