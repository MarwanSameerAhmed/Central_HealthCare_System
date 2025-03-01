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
    public partial class PatientFileViewrFrm : Form
    {

        public PatientFileViewrFrm(string fullName, int age, string phoneNumber, long medicalNumber,
                              string idCardNumber, string birthDate, bool isMale,
                              string patientAddress, string bloodType, string maritalStatus, string companionName, string birthPlace, string allergies)
        {
            InitializeComponent();
            fullNametxt.Text = fullName;
            agetxt.Text = age.ToString();
            birthdaytxt.Text = birthDate;
            statetxt.Text = birthPlace;
            comuintystateCombo.Text = maritalStatus;
            PhoneNumbertxt.Text = phoneNumber;
            bloodtxt.Text = bloodType;
            gendertxt.Text = isMale ? "ذكر" : "أنثى";
            addresstxt.Text = patientAddress;
            parenttxt.Text = companionName;
            string allergiesData = allergies;
            if (!string.IsNullOrEmpty(allergiesData))
            {
                string[] allergiesArray = allergiesData.Split(';');
                flowLayoutPanel2.Controls.Clear();

                foreach (var allergy in allergiesArray)
                {
                    AddChip(allergy);
                }

            }
        }
        void AddChip(string allergy)
        {
            Label chip = new Label();
            chip.Text = allergy;
            chip.Font = new Font("Traditional Arabic", 15, FontStyle.Bold);  // تغيير الخط
            chip.AutoSize = true;
            chip.BackColor = Color.WhiteSmoke;  // تغيير الخلفية
            chip.ForeColor = Color.Black;  // تغيير لون النص
            chip.Padding = new Padding(5);
            chip.Margin = new Padding(3);
            chip.BorderStyle = BorderStyle.FixedSingle;
            chip.TextAlign = System.Drawing.ContentAlignment.TopRight;

            flowLayoutPanel2.Controls.Add(chip);
        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void guna2ContainerControl1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
