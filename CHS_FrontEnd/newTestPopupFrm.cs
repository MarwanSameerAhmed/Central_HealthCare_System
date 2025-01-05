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

namespace CHS.Client
{
    public partial class newTestPopupFrm : Form
    {

        public newTestPopupFrm()
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.None;

            // Disable resizing and other unnecessary features
            //this.FormBorderStyle = FormBorderStyle.FixedDialog;

            this.ControlBox = false;
            this.StartPosition = FormStartPosition.CenterParent;
        }

        private void newTestPopupFrm_Load(object sender, EventArgs e)
        {

        }

        private void statetxt_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void mainTestLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
