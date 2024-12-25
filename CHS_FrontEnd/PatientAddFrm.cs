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
    public partial class addingPatientFrm : Form
    {
        private DockPanel dockPanel;
        public addingPatientFrm(DockPanel dockPanel)
        {
            InitializeComponent();
            this.dockPanel = dockPanel;
        }

        

       
        

       

       

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private bool ValidateFields()
        {
            bool isValid = true;

            
            if (string.IsNullOrWhiteSpace(fullNametxt.Text))
            {
                labelError.Text = "هذا الحقل مطلوب*";
                labelError.Visible = true;
                fullNametxt.BorderColor = Color.Red; 
                isValid = false;
            }
            else
            {
                labelError.Visible = false; 
                fullNametxt.BorderColor = System.Drawing.Color.FromArgb(1, 87, 155); 
            }

            
            if (string.IsNullOrWhiteSpace(PhoneNumbertxt.Text))
            {
                labelerrorPhone.Text = "هذا الحقل مطلوب*" ;
                labelerrorPhone.Visible = true;
                PhoneNumbertxt.BorderColor = Color.Red;
                isValid = false;
            }
            else
            {
                labelerrorPhone.Visible = false;
                PhoneNumbertxt.BorderColor = System.Drawing.Color.FromArgb(1, 87, 155);
            }

           

            return isValid;
        }


        private void createBtn_Click(object sender, EventArgs e)
        {
                if (ValidateFields())
                {
                   
                    MessageBox.Show("تمت الإضافة بنجاح");
                   
                }
                else
                {
                    MessageBox.Show("يرجى تصحيح الأخطاء قبل المتابعة");
                }
            }

        private void fullNametxt_TextChanged(object sender, EventArgs e)
        {
            labelError.Visible = false;
            fullNametxt.BorderColor = System.Drawing.Color.FromArgb(1, 87, 155);
        }

     
    }
    }

