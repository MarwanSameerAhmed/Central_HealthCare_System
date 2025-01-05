using CHS.Client;
using Guna.UI2.WinForms.Enums;
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
    
    public partial class LocalEDManagementFrm : Form 
    {

        private DockPanel dockPanel;
        public LocalEDManagementFrm(DockPanel dockPanel)
        {
            InitializeComponent();
            this.dockPanel = dockPanel;
            
        }

        private void LocalEDManagementFrm_Load(object sender, EventArgs e)
        {
            StyleDataGridView();
            UpdateScrollBar();
            demoData();
        }

        

        private void StyleDataGridView()
        {
            // Apply Guna2 visual themes to the DataGridView
            edLocalBedsStatue.Theme = DataGridViewPresetThemes.Default;
            edLocalBedsStatue.EnableHeadersVisualStyles = false;

            // Customize header style
            edLocalBedsStatue.ColumnHeadersDefaultCellStyle.BackColor = Color.RoyalBlue;
            edLocalBedsStatue.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            edLocalBedsStatue.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            edLocalBedsStatue.ColumnHeadersHeight = 50;

            // Customize cell style
            edLocalBedsStatue.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            edLocalBedsStatue.DefaultCellStyle.ForeColor = Color.Black;
            edLocalBedsStatue.DefaultCellStyle.BackColor = Color.WhiteSmoke;
            edLocalBedsStatue.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;

            // Disable default scrollbar
            edLocalBedsStatue.ScrollBars = ScrollBars.None;

            // Set the rows height & alignment
            edLocalBedsStatue.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            edLocalBedsStatue.RowTemplate.Height = 100;

            // Apply height to existing rows
            foreach (DataGridViewRow row in edLocalBedsStatue.Rows)
            {
                row.Height = 40;
            }

            // Make the grid view scroll with the mouse wheel
            edLocalBedsStatue.MouseWheel += edLocalBedsStatuew_MouseWheel;
        }

        private void edLocalBedsStatuew_MouseWheel(object sender, MouseEventArgs e)
        {
            if (edLocalBedsStatue.RowCount > 0)
            {
                int scrollAmount = e.Delta > 0 ? -1 : 1;
                int newValue = guna2VScrollBar1.Value + scrollAmount;

                if (newValue >= guna2VScrollBar1.Minimum && newValue <= guna2VScrollBar1.Maximum)
                {
                    guna2VScrollBar1.Value = newValue;
                    // Ensure the value is within the valid range of rows
                    if (guna2VScrollBar1.Value >= 0 && guna2VScrollBar1.Value < edLocalBedsStatue.RowCount)
                    {
                        edLocalBedsStatue.FirstDisplayedScrollingRowIndex = guna2VScrollBar1.Value;
                    }
                }
            }
        }

        private void UpdateScrollBar()
        {
            int totalRows = edLocalBedsStatue.Rows.Count; // Total number of rows
            int displayedRows = edLocalBedsStatue.DisplayedRowCount(true); // Number of visible rows

            // Enable or disable the scrollbar based on the number of rows
            guna2VScrollBar1.Enabled = totalRows > displayedRows;

            if (totalRows > 0)
            {
                // Calculate the maximum value the scrollbar can take
                guna2VScrollBar1.Maximum = totalRows - 1;

                // Adjust LargeChange to match the displayed rows
                guna2VScrollBar1.LargeChange = displayedRows > 0 ? displayedRows : 1;

                // Adjust Maximum to account for LargeChange to prevent over-scrolling
                guna2VScrollBar1.Maximum = Math.Max(0, totalRows - guna2VScrollBar1.LargeChange);

                // Ensure the scrollbar's value stays within the valid range
                guna2VScrollBar1.Value = Math.Min(guna2VScrollBar1.Value, guna2VScrollBar1.Maximum);
            }
            else
            {
                // No rows: reset scrollbar properties
                guna2VScrollBar1.Maximum = 0;
                guna2VScrollBar1.LargeChange = 0;
                guna2VScrollBar1.SmallChange = 0;
                guna2VScrollBar1.Value = 0;
            }
        }


        private void demoData()
        {
            edLocalBedsStatue.Rows.Add(null, null, "26//26", "1");
            edLocalBedsStatue.Rows.Add(null, null, "26//26", "2");
            edLocalBedsStatue.Rows.Add(null, null, "26//26", "3");
            edLocalBedsStatue.Rows.Add(null, null, "26//26", "4");
            edLocalBedsStatue.Rows.Add(null, null, "26//26", "5");
            edLocalBedsStatue.Rows.Add(null, null, "26//26", "6");
            edLocalBedsStatue.Rows.Add(null, null, "26//26", "7");
            edLocalBedsStatue.Rows.Add(null, null, "26//26", "8");
            edLocalBedsStatue.Rows.Add(null, null, "26//26", "9");
            edLocalBedsStatue.Rows.Add(null, null, "26//26", "10");
            edLocalBedsStatue.Rows.Add(null, null, "26//26", "11");
            edLocalBedsStatue.Rows.Add(null, null, "26//26", "12");
            edLocalBedsStatue.Rows.Add(null, null, "26//26", "13");
            edLocalBedsStatue.Rows.Add(null, null, "26//26", "14");
            edLocalBedsStatue.Rows.Add(null, null, "26//26", "15");
            edLocalBedsStatue.Rows.Add(null, null, "26//26", "16");
            edLocalBedsStatue.Rows.Add(null, null, "26//26", "17");
            edLocalBedsStatue.Rows.Add(null, null, "26//26", "18");
        }

        private void changeColor()
        {

            string targetColumn = "availableBeds"; 

            foreach (DataGridViewRow row in edLocalBedsStatue.Rows)
            {
                if (!row.IsNewRow) // Skip the new row placeholder
                {
                    DataGridViewCell cell = row.Cells[targetColumn];

                    
                    if (cell.Value != null && cell.Value.ToString() == "Important")
                    {
                        cell.Style.ForeColor = Color.Red; // Change text color
                        cell.Style.BackColor = Color.LightYellow; // Optional: Change background color
                    }
                    else
                    {
                        cell.Style.ForeColor = Color.Black; // Default text color
                        cell.Style.BackColor = Color.White; // Default background color
                    }
                }
            }

        }

        private void addRoomButton_Click(object sender, EventArgs e)
        {
            var popup = new AddEDRoomFrm();
            popup.ShowDialog();
        }

        private void demoDIsplayRooms_Click(object sender, EventArgs e)
        {
            //EDRoom 
        }
    }
}
