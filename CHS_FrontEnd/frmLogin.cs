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

namespace CHS_FrontEnd
{
    public partial class frmLogin : Form
    {
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
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Closebtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

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

        private void pictureBox3_Click(object sender, EventArgs e)
        {
           // textBox2.UseSystemPasswordChar = false;
        }
        private void pictureBox3_MouseDown(object sender, MouseEventArgs e)
        {
            passwordtxt.UseSystemPasswordChar = false;
        }

        private void pictureBox3_MouseUp(object sender, MouseEventArgs e)
        {
            passwordtxt .UseSystemPasswordChar = true;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            UserNametxt.Focus();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            UserNametxt.Focus();
        }

        private void loginbtn_Click(object sender, EventArgs e)
        {          
            DialogResult = DialogResult.OK;
        }

        private void button1_Click(object sender, EventArgs e)
        {
         //   patientAddingPage f = new patientAddingPage();
          //  f.ShowDialog();
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(UserNametxt.Text) || string.IsNullOrWhiteSpace(passwordtxt.Text))
            {
                labelError.Text = "يرجى إدخال اسم المستخدم وكلمة المرور.";
                labelError.ForeColor = Color.Red; 
                labelError.Visible = true;       
                return; 
            }
            try
            {
                LoginResponse response = RequestSender.Login(UserNametxt.Text, passwordtxt.Text);
                if (!(response is null) && !string.IsNullOrEmpty(response.Token))
                {
                    DialogResult = DialogResult.OK;
                    return;
                }
                labelError.Visible=false;
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
    }
}
