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
    public partial class MainService : Form
    {

        private DockPanel dockPanel;
        private Form currentForm = null;
        public MainService(DockPanel dockPanel)
        {
            InitializeComponent();
            this.dockPanel = dockPanel;

        }


        private void OpenForm(Form childForm)
        {

            if (currentForm != null && currentForm.GetType() == childForm.GetType())
            {

                return;
            }
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

        private void guna2ContainerControl1_Click_1(object sender, EventArgs e)
        {
            addingPatientFrm fr = new addingPatientFrm(dockPanel);
            OpenForm(fr);
        }

        private void MainService_Load(object sender, EventArgs e)
        {
           
        }
    }

      
    }

