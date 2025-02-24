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

namespace CHS_FrontEnd.Labs___ED
{
    public partial class AddNewTest : Form
    {
        private DockPanel dockPanel;

        public AddNewTest(DockPanel dockPanel)
        {
            this.dockPanel = dockPanel;
            InitializeComponent();
            requestedTestsScrollBar.Scroll += requestedTestsScrollBar_Scroll;
            newTestsScrollBar.Scroll += newTestsScrollBar_Scroll;
        }

        private void AddNewTest_Load(object sender, EventArgs e)
        {
            SyncScrollbar();
            PopulateData();
            requestedTestsGridView.MouseWheel += requestedTestsGridView_MouseWheel;
        }

        private void PopulateData()
        {
            requestedTestsGridView.Rows.Add(false, "20/1/2025", "Blood", "Hemoglobin", "1");
            requestedTestsGridView.Rows.Add(true, "21/1/2025", "Urine", "Glucose", "2");
            requestedTestsGridView.Rows.Add(false, "22/1/2025", "Blood", "WBC Count", "3");
            requestedTestsGridView.Rows.Add(true, "23/1/2025", "Blood", "Platelet Count", "4");
            requestedTestsGridView.Rows.Add(false, "24/1/2025", "Urine", "Protein", "5");
            requestedTestsGridView.Rows.Add(true, "25/1/2025", "Blood", "Cholesterol", "6");
            requestedTestsGridView.Rows.Add(false, "26/1/2025", "Urine", "Ketones", "7");
            requestedTestsGridView.Rows.Add(true, "27/1/2025", "Blood", "RBC Count", "8");
            requestedTestsGridView.Rows.Add(false, "28/1/2025", "Blood", "Triglycerides", "9");
            requestedTestsGridView.Rows.Add(true, "29/1/2025", "Urine", "pH Level", "10");
            requestedTestsGridView.Rows.Add(false, "30/1/2025", "Blood", "Creatinine", "11");
            requestedTestsGridView.Rows.Add(true, "31/1/2025", "Blood", "Bilirubin", "12");
            requestedTestsGridView.Rows.Add(false, "1/2/2025", "Urine", "Uric Acid", "13");
            requestedTestsGridView.Rows.Add(true, "2/2/2025", "Blood", "Electrolytes", "14");
            requestedTestsGridView.Rows.Add(false, "3/2/2025", "Blood", "Thyroid Function", "15");
            requestedTestsGridView.Rows.Add(true, "4/2/2025", "Urine", "Specific Gravity", "16");
            requestedTestsGridView.Rows.Add(false, "5/2/2025", "Blood", "Glucose Fasting", "17");
            requestedTestsGridView.Rows.Add(true, "6/2/2025", "Urine", "Leukocytes", "18");
            requestedTestsGridView.Rows.Add(false, "7/2/2025", "Blood", "Liver Function", "19");
            requestedTestsGridView.Rows.Add(true, "8/2/2025", "Blood", "C-Reactive Protein", "20");


            // Sync scrollbar after data update
            SyncScrollbar();
        }

        private void requestedTestsGridView_MouseWheel(object sender, MouseEventArgs e)
        {
            // Adjust the scrollbar value based on the mouse wheel delta
            int newValue = requestedTestsScrollBar.Value - (e.Delta / SystemInformation.MouseWheelScrollDelta) * requestedTestsScrollBar.SmallChange;
            requestedTestsScrollBar.Value = Math.Max(requestedTestsScrollBar.Minimum, Math.Min(requestedTestsScrollBar.Maximum, newValue));

            // Update the DataGridView's displayed row
            requestedTestsGridView.FirstDisplayedScrollingRowIndex = requestedTestsScrollBar.Value;
        }

        private void SyncScrollbar()
        {
            int totalRows = requestedTestsGridView.Rows.Count;
            int displayedRows = requestedTestsGridView.DisplayedRowCount(true);

            if (totalRows > 0 && displayedRows > 0)
            {
                requestedTestsScrollBar.Minimum = 0;
                requestedTestsScrollBar.Maximum = totalRows - 1;
                requestedTestsScrollBar.LargeChange = displayedRows; // Number of rows visible at once
                requestedTestsScrollBar.SmallChange = 1; // Scroll one row at a time
                requestedTestsScrollBar.Enabled = totalRows > displayedRows;
            }
            else
            {
                // Disable the scrollbar if there's nothing to scroll
                requestedTestsScrollBar.Enabled = false;
            }
        }

        private void requestedTestsScrollBar_Scroll(object sender, ScrollEventArgs e)
        {
            try
            {
                requestedTestsGridView.FirstDisplayedScrollingRowIndex = Math.Max(0, e.NewValue);
            }
            catch (Exception ex)
            {
                // Handle out of range exceptions (when there are no rows)
                Console.WriteLine($"Scroll error: {ex.Message}");
            }
        }

        private void newTestsScrollBar_Scroll(object sender, ScrollEventArgs e)
        {
            try
            {
                newTestresultsGridView.FirstDisplayedScrollingRowIndex = Math.Max(0, e.NewValue);
            }
            catch (Exception ex)
            {
                // Handle out of range exceptions (when there are no rows)
                Console.WriteLine($"Scroll error: {ex.Message}");
            }
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

        private void requestedTestsGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Ensure a valid row is clicked (not the header row)
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Get the exchangeStatus cell in the clicked row
                DataGridViewCell testDoneCell = requestedTestsGridView.Rows[e.RowIndex].Cells["testDone"];

                // Ensure the cell exists and is of type checkbox
                if (testDoneCell != null && testDoneCell is DataGridViewCheckBoxCell)
                {
                    // Get the current checkbox value
                    bool isChecked = Convert.ToBoolean(testDoneCell.Value);

                    if (!isChecked) // If the checkbox is false
                    {
                        DialogResult result = MessageBox.Show("هل تم الانتهاء من عمل الفحص؟",
                                                              "تأكيد",
                                                              MessageBoxButtons.YesNo,
                                                              MessageBoxIcon.Question);

                        if (result == DialogResult.Yes)
                        {
                            // Update the checkbox value to true
                            testDoneCell.Value = true;
                        }
                    }
                    else
                    {
                        // If already checked, show a message
                        MessageBox.Show("لقد تم عمل الفحص بالفعل", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }
    }
}
