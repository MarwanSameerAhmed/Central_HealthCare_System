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

namespace CHS_FrontEnd.Pharmacy
{
    public partial class PharmacyMainFrm : Form
    {
        private DockPanel dockPanel;

        public PharmacyMainFrm(DockPanel dockPanel)
        {
            InitializeComponent();
            this.dockPanel = dockPanel;
            guna2VScrollBar1.Scroll += Guna2VScrollBar1_Scroll;
        }

        private void PharmacyMainFrm_Load(object sender, EventArgs e)
        {
            SyncScrollbar();
            PopulateData();
            medicineStateGridView.MouseWheel += medicineStateGridView_MouseWheel;
        }

        private void PopulateData()
        {
            medicineStateGridView.Rows.Add("1", "asd", "1/2/2025", "3");
            medicineStateGridView.Rows.Add("1", "asd", "1/2/2025", "3");
            medicineStateGridView.Rows.Add("1", "asd", "1/2/2025", "3");
            medicineStateGridView.Rows.Add("1", "asd", "1/2/2025", "3");
            medicineStateGridView.Rows.Add("1", "asd", "1/2/2025", "3");
            SyncScrollbar();
        }
            private void medicineStateGridView_MouseWheel(object sender, MouseEventArgs e)
        {
            // Adjust the scrollbar value based on the mouse wheel delta
            int newValue = guna2VScrollBar1.Value - (e.Delta / SystemInformation.MouseWheelScrollDelta) * guna2VScrollBar1.SmallChange;
            guna2VScrollBar1.Value = Math.Max(guna2VScrollBar1.Minimum, Math.Min(guna2VScrollBar1.Maximum, newValue));

            // Update the DataGridView's displayed row
            medicineStateGridView.FirstDisplayedScrollingRowIndex = guna2VScrollBar1.Value;
        }

        private void SyncScrollbar()
        {
            int totalRows = medicineStateGridView.Rows.Count;
            int displayedRows = medicineStateGridView.DisplayedRowCount(true);

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
                medicineStateGridView.FirstDisplayedScrollingRowIndex = Math.Max(0, e.NewValue);
            }
            catch (Exception ex)
            {
                // Handle out of range exceptions (when there are no rows)
                Console.WriteLine($"Scroll error: {ex.Message}");
            }
        }

        private void setTranslation()
        {

        }
    }
}
