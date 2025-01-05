using Guna.UI2.WinForms;
using Guna.UI2.WinForms.Enums;
using System;
using System.Drawing;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace CHS.Client
{
    public partial class LIMBsFrm : Form
    {
        private DockPanel dockPanel;

        public LIMBsFrm(DockPanel dockPanel)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.dockPanel = dockPanel;

            guna2VScrollBar1.Scroll += Guna2VScrollBar1_Scroll;
        }

        private void LIMBsFrm_Load(object sender, EventArgs e)
        {
            StyleDataGridView();
            SyncScrollbar();
            PopulateData();
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
            testsGridView.Rows.Add("1", "Blood", "Hemoglobin");
            testsGridView.Rows.Add("2", "Skin", "Melanin");
            testsGridView.Rows.Add("3", "Urine", "Creatinine");
            testsGridView.Rows.Add("4", "Blood", "White Blood Cell Count");
            testsGridView.Rows.Add("1", "Blood", "Hemoglobin");
            testsGridView.Rows.Add("2", "Skin", "Melanin");
            testsGridView.Rows.Add("3", "Urine", "Creatinine");
            testsGridView.Rows.Add("4", "Blood", "White Blood Cell Count");
            testsGridView.Rows.Add("1", "Blood", "Hemoglobin");
            testsGridView.Rows.Add("2", "Skin", "Melanin");
            testsGridView.Rows.Add("3", "Urine", "Creatinine");
            testsGridView.Rows.Add("4", "Blood", "White Blood Cell Count");
            testsGridView.Rows.Add("1", "Blood", "Hemoglobin");
            testsGridView.Rows.Add("2", "Skin", "Melanin");
            testsGridView.Rows.Add("3", "Urine", "Creatinine");
            testsGridView.Rows.Add("4", "Blood", "White Blood Cell Count");
            testsGridView.Rows.Add("1", "Blood", "Hemoglobin");
            testsGridView.Rows.Add("2", "Skin", "Melanin");
            testsGridView.Rows.Add("3", "Urine", "Creatinine");
            testsGridView.Rows.Add("4", "Blood", "White Blood Cell Count");
            testsGridView.Rows.Add("1", "Blood", "Hemoglobin");
            testsGridView.Rows.Add("2", "Skin", "Melanin");
            testsGridView.Rows.Add("3", "Urine", "Creatinine");
            testsGridView.Rows.Add("4", "Blood", "White Blood Cell Count");
            testsGridView.Rows.Add("1", "Blood", "Hemoglobin");
            testsGridView.Rows.Add("2", "Skin", "Melanin");
            testsGridView.Rows.Add("3", "Urine", "Creatinine");
            testsGridView.Rows.Add("4", "Blood", "White Blood Cell Count");

            // Sync scrollbar after data update
            SyncScrollbar();
        }

        private void StyleDataGridView()
        {
            // Apply Guna2 visual themes to the DataGridView
            testsGridView.Theme = DataGridViewPresetThemes.Default;
            testsGridView.EnableHeadersVisualStyles = false;

            // Customize header style
            testsGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.RoyalBlue;
            testsGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            testsGridView.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            testsGridView.ColumnHeadersHeight = 50;

            // Customize cell style
            testsGridView.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            testsGridView.DefaultCellStyle.ForeColor = Color.Black;
            testsGridView.DefaultCellStyle.BackColor = Color.WhiteSmoke;
            testsGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;

            // Disable default scrollbar
            testsGridView.ScrollBars = ScrollBars.None;

            // Set the rows height & alignment
            testsGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            testsGridView.RowTemplate.Height = 100;

            // Apply height to existing rows
            foreach (DataGridViewRow row in testsGridView.Rows)
            {
                row.Height = 40;
            }

            testsGridView.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Make the grid view scroll with the mouse wheel
            testsGridView.MouseWheel += testsGridView_MouseWheel;
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
            var popup = new newTestPopupFrm();
            popup.ShowDialog();
        }
    }
}
