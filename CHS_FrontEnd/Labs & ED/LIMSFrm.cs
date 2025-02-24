//using CHS_FrontEnd.Translation;
using Guna.UI2.WinForms;
using Guna.UI2.WinForms.Enums;
using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Globalization;
using System.Threading;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;
using CHS_FrontEnd.Properties;
using System.ComponentModel;
using CHS_FrontEnd;
using CHS_FrontEnd.Labs___ED; 

namespace CHS.Client
{
    public partial class LIMSFrm : Form
    {
        private DockPanel dockPanel;
        private Form currentForm = null;
        public LIMSFrm(DockPanel dockPanel)
        {
            InitializeComponent();
            this.dockPanel = dockPanel;
            guna2VScrollBar1.Scroll += Guna2VScrollBar1_Scroll;
            setTranslation();
        }

        private void LIMBsFrm_Load(object sender, EventArgs e)
        {
            SyncScrollbar();
            PopulateData();
            testsGridView.MouseWheel += testsGridView_MouseWheel;
        }

        private void testsGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Ensure the clicked cell is in the button column
            if (e.RowIndex >= 0 && e.ColumnIndex == testsGridView.Columns["testResults"].Index)
            {
                // Access data from the clicked row
                var clickedRow = testsGridView.Rows[e.RowIndex];
                string id = clickedRow.Cells["testNum"].Value?.ToString() ?? "Unknown";
                string category = clickedRow.Cells["category"].Value?.ToString() ?? "Unknown";
                string testName = clickedRow.Cells["testName"].Value?.ToString() ?? "Unknown";

                // Display details
                MessageBox.Show($"ID: {id}\nCategory: {category}\nTest Name: {testName}", "Details");
            }
        }

        private void PopulateData()
        {
            testsGridView.Rows.Add(null, "20/1/2025", "Blood", "Hemoglobin", "1");
            testsGridView.Rows.Add(null, "21/1/2025", "Urine", "Glucose", "2");
            testsGridView.Rows.Add(null, "22/1/2025", "Blood", "WBC Count", "3");
            testsGridView.Rows.Add(null, "23/1/2025", "Blood", "Platelet Count", "4");
            testsGridView.Rows.Add(null, "24/1/2025", "Urine", "Protein", "5");
            testsGridView.Rows.Add(null, "25/1/2025", "Blood", "Cholesterol", "6");
            testsGridView.Rows.Add(null, "26/1/2025", "Urine", "Ketones", "7");
            testsGridView.Rows.Add(null, "27/1/2025", "Blood", "RBC Count", "8");
            testsGridView.Rows.Add(null, "28/1/2025", "Blood", "Triglycerides", "9");
            testsGridView.Rows.Add(null, "29/1/2025", "Urine", "pH Level", "10");
            testsGridView.Rows.Add(null, "30/1/2025", "Blood", "Creatinine", "11");
            testsGridView.Rows.Add(null, "31/1/2025", "Blood", "Bilirubin", "12");
            testsGridView.Rows.Add(null, "1/2/2025", "Urine", "Uric Acid", "13");
            testsGridView.Rows.Add(null, "2/2/2025", "Blood", "Electrolytes", "14");
            testsGridView.Rows.Add(null, "3/2/2025", "Blood", "Thyroid Function", "15");
            testsGridView.Rows.Add(null, "4/2/2025", "Urine", "Specific Gravity", "16");
            testsGridView.Rows.Add(null, "5/2/2025", "Blood", "Glucose Fasting", "17");
            testsGridView.Rows.Add(null, "6/2/2025", "Urine", "Leukocytes", "18");
            testsGridView.Rows.Add(null, "7/2/2025", "Blood", "Liver Function", "19");
            testsGridView.Rows.Add(null, "8/2/2025", "Blood", "C-Reactive Protein", "20");




            // Sync scrollbar after data update
            SyncScrollbar();
        }



        private void testsGridView_MouseWheel(object sender, MouseEventArgs e)
        {
            // Adjust the scrollbar value based on the mouse wheel delta
            int newValue = guna2VScrollBar1.Value - (e.Delta / SystemInformation.MouseWheelScrollDelta) * guna2VScrollBar1.SmallChange;
            guna2VScrollBar1.Value = Math.Max(guna2VScrollBar1.Minimum, Math.Min(guna2VScrollBar1.Maximum, newValue));

            // Update the DataGridView's displayed row
            testsGridView.FirstDisplayedScrollingRowIndex = guna2VScrollBar1.Value;
        }

        private void SyncScrollbar()
        {
            int totalRows = testsGridView.Rows.Count;
            int displayedRows = testsGridView.DisplayedRowCount(true);

            if (totalRows > 0 && displayedRows > 0)
            {
                guna2VScrollBar1.Minimum = 0;
                guna2VScrollBar1.Maximum = totalRows - 1;
                guna2VScrollBar1.LargeChange = displayedRows; // Number of rows visible at once
                guna2VScrollBar1.SmallChange = 1; // Scroll one row at a time
                guna2VScrollBar1.Enabled = totalRows > displayedRows;
            }
            else
            {
                // Disable the scrollbar if there's nothing to scroll
                guna2VScrollBar1.Enabled = false;
            }
        }

        private void Guna2VScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            try
            {
                testsGridView.FirstDisplayedScrollingRowIndex = Math.Max(0, e.NewValue);
            }
            catch (Exception ex)
            {
                // Handle out of range exceptions (when there are no rows)
                Console.WriteLine($"Scroll error: {ex.Message}");
            }
        }

        // open new test popup 
        private void newTestButton_Click(object sender, EventArgs e)
        {
            OpenForm(new AddNewTest(dockPanel));
        }

        private void OpenForm(Form childForm)
        {

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

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void setTranslation()
        {
            //limbsHeader.Text = Resource.limbsHeader;
            //searchForpatientLabel.Text = Resource.searchForpatientLabel;
            //midSearchtxt.PlaceholderText = Resource.medicalNumber;
            //phoneSearchtxt.PlaceholderText = Resource.phoneNumber;
            //nationalSearchtxt.PlaceholderText = Resource.idNumber;
            //orLabel.Text = Resource.or;
            //orLabel2.Text = Resource.or;
            //patientDataLabel.Text = Resource.patientData;
            //patientNameLabel.Text = Resource.patientName;
            //patientGenderLabel.Text = Resource.gender;
            //patientAgeLabel.Text = Resource.age;
            //newTestButton.Text = Resource.addNewTest;

            //// grid view columns
            //testsGridView.Columns["testNum"].HeaderText = Resource.testNum;
            //testsGridView.Columns["category"].HeaderText = Resource.category;
            //testsGridView.Columns["testName"].HeaderText = Resource.testName;
            //testsGridView.Columns["testResults"].HeaderText = Resource.testResults;

        }

        
    }

}
