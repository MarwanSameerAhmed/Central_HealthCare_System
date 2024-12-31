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
    public partial class employeeSearchFrm : Form
    {
        private DockPanel dockPanel;
        public employeeSearchFrm(DockPanel dockPanel)
        {
            InitializeComponent();
            this.dockPanel = dockPanel;
        }

        private void employeeSearchFrm_Load(object sender, EventArgs e)
        {

        }
    }
}
