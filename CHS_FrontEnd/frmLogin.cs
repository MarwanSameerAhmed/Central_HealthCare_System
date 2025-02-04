using CHS.Client.API.Models;
using CHS.Client.API;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CHS.Client.API.Models.Facilities;
using Guna.UI2.WinForms;

namespace CHS_FrontEnd
{
    public partial class frmLogin : Form
    {
        public static string EmployeeName { get; private set; }
        public static string FacilityName { get; private set; }
        public string JobTitle { get; private set; }
        public int UserRole { get; private set; }


        public frmLogin()
        {
            InitializeComponent();
        }
        private void Form1_load(object sender, EventArgs e)
        {
            UserNametxt.RightToLeft = RightToLeft.Yes;
            passwordtxt.RightToLeft = RightToLeft.Yes;
            UserNametxt.Focus();
        }
       
        private void Closebtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }



        private void textBox1_Click(object sender, EventArgs e)
        {
            UserNametxt.BackColor = Color.White;
           
            
            passwordtxt.BackColor = SystemColors.Control;
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            passwordtxt.BackColor= Color.White;
           
            UserNametxt .BackColor = SystemColors.Control;
          

        }

        
        private void pictureBox3_MouseDown(object sender, MouseEventArgs e)
        {
            passwordtxt.UseSystemPasswordChar = false;
        }

        private void pictureBox3_MouseUp(object sender, MouseEventArgs e)
        {
            passwordtxt .UseSystemPasswordChar = true;
        }


        private void BindEventsToChildTextBoxes(Control container)
        {
            foreach (Control child in container.Controls)
            {
                if (child is Guna.UI2.WinForms.Guna2TextBox textBox)
                {
                    textBox.Enter += Guna2TextBox_Enter;
                    textBox.Leave += Guna2TextBox_Leave;
                }
                else if (child.HasChildren)
                {
                    BindEventsToChildTextBoxes(child);
                }
            }
        }


        private void Form1_Load_1(object sender, EventArgs e)
        {
            //  UserNametxt.Focus();
            facilityTxt.Text = Properties.Settings.Default.FacilityName;
            foreach (Control control in this.Controls)
            {
                // التحقق إذا كان الحقل من النوع TextBox
                if (control is Guna.UI2.WinForms.Guna2TextBox textBox)
                {
                    textBox.Enter += Guna2TextBox_Enter;
                    textBox.Leave += Guna2TextBox_Leave;
                }
                // التحقق من الحاويات الداخلية
                else if (control is Panel || control is GroupBox || control is FlowLayoutPanel)
                {
                    BindEventsToChildTextBoxes(control);
                }

             
            }
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            //UserNametxt.Focus();
        }

        private void validationsCodeTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            // السماح فقط للأرقام
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8) // (char)8 هو الكود الخاص بمفتاح Backspace
            {
                e.Handled = true; // إذا كانت الحرف ليس رقماً ولا مفتاح العودة، يتم منع الإدخال
            }
        }

        private void validationsCodeTxt_TextChanged(object sender, EventArgs e)
        {
            // التحقق من أن النص لا يحتوي على أكثر من 9 أرقام
            if (validationsCodeTxt.Text.Length > 9)
            {
                validationsCodeTxt.Text = validationsCodeTxt.Text.Substring(0, 9); // اقتصار النص على 9 أرقام
                validationsCodeTxt.SelectionStart = validationsCodeTxt.Text.Length; // إبقاء مؤشر الكتابة في نهاية النص
            }
        }


        private Font normalFont = new Font("Traditional Arabic", 12.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));


        private Font largeFont = new Font("Traditional Arabic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));


        private void Guna2TextBox_Enter(object sender, EventArgs e)
        {
            Guna2TextBox textBox = sender as Guna2TextBox;
            if (textBox != null)
            {
                textBox.Font = largeFont;
            }
        }


        private void Guna2TextBox_Leave(object sender, EventArgs e)
        {
            Guna2TextBox textBox = sender as Guna2TextBox;
            if (textBox != null)
            {
                textBox.Font = normalFont;
            }
        }
        bool hasError = false;  

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(UserNametxt.Text) || string.IsNullOrWhiteSpace(passwordtxt.Text))
            {
                labelError.Text = "يرجى إدخال اسم المستخدم وكلمة المرور";
                labelError.ForeColor = Color.Red; 
                labelError.Visible = true;
                UserNametxt.BorderColor = Color.Red;
                passwordtxt.BorderColor = Color.Red;
                return;
              
            }
            if (string.IsNullOrWhiteSpace(facilityTxt.Text))
            {
                label5.Text = "يرجى إدخال اسم المنشأة";
                label5.ForeColor = Color.Red;
                label5.Visible = true;
                facilityTxt.BorderColor = Color.Red;
                return ;
             


            }
            string otp = validationsCodeTxt.Text;
            if (!string.IsNullOrEmpty(otp) && (otp.Length != 6 || !int.TryParse(otp, out _)))
            {
                label3.Text = "يجب أن يكون الرمز من 6 ارقام";
                label3.ForeColor = Color.Red;
                label3.Visible = true;
                validationsCodeTxt.BorderColor = Color.Red;
                return;
            


            }
          
            try
            {
                LoginResponse response = RequestSender.Login(UserNametxt.Text, passwordtxt.Text, facilityTxt.Text, validationsCodeTxt.Text);
                if (!(response is null) && response.ResponseCode == "1")
                {
                    Properties.Settings.Default.FacilityName = facilityTxt.Text;
                    Properties.Settings.Default.Save();
                    EmployeeName = response.EmployeeName;
                    FacilityName = facilityTxt.Text;
                    JobTitle = response.JobTitle;
                    UserRole = response.UserRole;

                    DialogResult = DialogResult.OK;
                    return;
                }
                else if (!(response is null) && response.ResponseCode == "2")
                {
                    ShowTwoFactorAuthenticationQr(response.TwoFactorAuthenticationUrl);
                    return;
                }
                labelError.Visible = false;
                label2.Text = "حصل خطأ أثناء تسجيل الدخول";
                label2.ForeColor = Color.Red;
                label2.Visible = true;
            }
            catch (Exception ex)
            {
                labelError.Visible = false;
                label2.Text = ex.InnerException is null ? ex.Message : ex.InnerException.Message;
                label2.ForeColor = Color.Red;
                label2.Visible = true;
            }
        }

        private void ShowTwoFactorAuthenticationQr(string twoFactorAuthenticationUrl)
        {
            QrFrm frm = new QrFrm(twoFactorAuthenticationUrl);
            frm.ShowDialog();
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UserNametxt_TextChanged(object sender, EventArgs e)
        {
            labelError.Visible = false;
            UserNametxt.BorderColor = System.Drawing.Color.FromArgb(1, 87, 155);
        }

        private void passwordtxt_TextChanged(object sender, EventArgs e)
        {
            labelError.Visible = false;
            passwordtxt.BorderColor = System.Drawing.Color.FromArgb(1, 87, 155);
        }

        private void validationsCodeTxt_TextChanged_1(object sender, EventArgs e)
        {

            label3.Visible = false;
            validationsCodeTxt.BorderColor = System.Drawing.Color.FromArgb(1, 87, 155);
        }

        private void facilityTxt_TextChanged(object sender, EventArgs e)
        {
            label5.Visible = false;
            facilityTxt.BorderColor = System.Drawing.Color.FromArgb(1, 87, 155);
        }
    }
}
