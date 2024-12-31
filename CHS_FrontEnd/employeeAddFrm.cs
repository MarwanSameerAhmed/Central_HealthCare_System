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
    public partial class employeeAddFrm : Form
    {
        public employeeAddFrm(DockPanel dockPanel)
        {
            InitializeComponent();
        }

        private void employeeAddFrm_Load(object sender, EventArgs e)
        {
            empBirthdaytxt.Value = DateTime.Now;    
            employmentDate.Value = DateTime.Now;
        }

        private void empAgetxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
