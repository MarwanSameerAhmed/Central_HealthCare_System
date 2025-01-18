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
    public partial class searchEmployees_praivte_ : Form
    {
        public searchEmployees_praivte_(DockPanel dockPanel)
        {
            InitializeComponent();
        }
        private void LoadDemoData()
        {






            searchEmpView.Rows.Add("أحمد علي", "موظف دائم", "0123456789", "101");
            searchEmpView.Rows.Add("سارة محمد", "موظف عقد", "0112233445", "102");
            searchEmpView.Rows.Add("محمد سمير", "موظف مؤقت", "0109876543", "103");
            searchEmpView.Rows.Add("ريم خالد", "موظف دائم", "0125678901", "104");
            searchEmpView.Rows.Add("خالد عبد الله", "موظف عقد", "0113344556", "105");
            searchEmpView.Rows.Add("أحمد علي", "موظف دائم", "0123456789", "101");
            searchEmpView.Rows.Add("سارة محمد", "موظف عقد", "0112233445", "102");
            searchEmpView.Rows.Add("محمد سمير", "موظف مؤقت", "0109876543", "103");
            searchEmpView.Rows.Add("ريم خالد", "موظف دائم", "0125678901", "104");
            searchEmpView.Rows.Add("خالد عبد الله", "موظف عقد", "0113344556", "105");
            searchEmpView.Rows.Add("أحمد علي", "موظف دائم", "0123456789", "101");
            searchEmpView.Rows.Add("سارة محمد", "موظف عقد", "0112233445", "102");
            searchEmpView.Rows.Add("محمد سمير", "موظف مؤقت", "0109876543", "103");
            searchEmpView.Rows.Add("ريم خالد", "موظف دائم", "0125678901", "104");
            searchEmpView.Rows.Add("خالد عبد الله", "موظف عقد", "0113344556", "105");



        }

        private void searchEmpView_ValueChanged(object sender, EventArgs e)
        {

            if (guna2VScrollBar1.Value < 0)
                guna2VScrollBar1.Value = 0;
            else if (guna2VScrollBar1.Value > guna2VScrollBar1.Maximum)
                guna2VScrollBar1.Value = guna2VScrollBar1.Maximum;


            if (searchEmpView.RowCount > 0)
            {

                int rowIndex = guna2VScrollBar1.Value;
                if (rowIndex >= searchEmpView.RowCount)
                    rowIndex = searchEmpView.RowCount - 1;

                searchEmpView.FirstDisplayedScrollingRowIndex = rowIndex;
            }
        }
        private void UpdateScrollBar()
        {
            int totalRows = searchEmpView.RowCount;


            guna2VScrollBar1.Maximum = totalRows - 1;


            guna2VScrollBar1.LargeChange = totalRows / 3;
            guna2VScrollBar1.SmallChange = 1;
        }
        private void searchEmpView_MouseWheel(object sender, MouseEventArgs e)
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

   

        private void searchEmployees_praivte__Load(object sender, EventArgs e)
        {
            guna2VScrollBar1.ValueChanged += searchEmpView_ValueChanged;
            guna2VScrollBar1.Maximum = searchEmpView.RowCount - 1;
            guna2VScrollBar1.Minimum = 0;
            guna2VScrollBar1.Value = 0;
            searchEmpView.MouseWheel += searchEmpView_MouseWheel;
            LoadDemoData();
            UpdateScrollBar();
        }

        private void searchEmpView_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                EmployeeViwerFrm fr = new EmployeeViwerFrm();
                fr.Show();
            }
        }
    }
}
