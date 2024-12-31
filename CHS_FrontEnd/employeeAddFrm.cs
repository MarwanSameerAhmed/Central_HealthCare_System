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
        private DockPanel dockPanel;
        public employeeAddFrm(DockPanel dockPanel)
        {
            InitializeComponent();
            this.dockPanel = dockPanel;

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

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void guna2ContainerControl1_Click(object sender, EventArgs e)
        {


        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void empNationalIDtxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void guna2ContainerControl4_Click(object sender, EventArgs e)
        {

        }


        private bool ValidateFields(
    List<(Guna.UI2.WinForms.Guna2TextBox TextBox, Label ErrorLabel, string ErrorMessage)> textFields,
    List<(Guna.UI2.WinForms.Guna2ComboBox ComboBox, Label ErrorLabel, string ErrorMessage)> comboFields)
        {
            bool isValid = true;

            foreach (var field in textFields)
            {
                var textBox = field.TextBox;
                var errorLabel = field.ErrorLabel;
                var errorMessage = field.ErrorMessage;

                if (string.IsNullOrWhiteSpace(textBox.Text))
                {
                    errorLabel.Text = errorMessage;
                    errorLabel.Visible = true;
                    textBox.BorderColor = Color.Red;
                    isValid = false;
                }
                else
                {
                    errorLabel.Visible = false;
                    textBox.BorderColor = Color.FromArgb(1, 87, 155);
                }
            }


            foreach (var field in comboFields)
            {
                var comboBox = field.ComboBox;
                var errorLabel = field.ErrorLabel;
                var errorMessage = field.ErrorMessage;

                if (comboBox.SelectedIndex == -1)
                {
                    errorLabel.Text = errorMessage;
                    errorLabel.Visible = true;
                    comboBox.BorderColor = Color.Red;
                    isValid = false;
                }
                else
                {
                    errorLabel.Visible = false;
                    comboBox.BorderColor = Color.FromArgb(1, 87, 155); // اللون الافتراضي
                }
            }

            return isValid;
        }

        private void createBtn_Click(object sender, EventArgs e)
        {
            List<(Guna.UI2.WinForms.Guna2TextBox, Label, string)> textFields = new List<(Guna.UI2.WinForms.Guna2TextBox, Label, string)>
{
    (empFullNametxt, labelError, "هذا الحقل مطلوب*"),
    (empPhoneNumbertxt, labelerrorPhone, "يرجى إدخال رقم الهاتف*"),
    (empAgetxt, errorlblage, "يرجى إدخال العمر*"),

    (empNationalIDtxt, nationallblerror, "يرجى إدخال رقم الهوية*"),
     (empAddressTxt, addresslblerror, "يرجى إدخال العنوان للمريض*"),
     (empEmailTxt, emaillbl, "يرجى إدخال الايميل للموظف*"),
     

};

            List<(Guna.UI2.WinForms.Guna2ComboBox, Label, string)> comboFields = new List<(Guna.UI2.WinForms.Guna2ComboBox, Label, string)>
{
    (empGendertxt, gendererrorlbl, "يرجى اختيار الجنس*"),
    (empDegreeCombo, degreelbl, "يرجى اختيار المؤهل الاكاديمي للموظف*"),
    (empTypeCombo, emptypelbl, "يرجى اختيار نوع الموظف*"),
    (empStatetxt, countryErrorLabel, "يرجى اختيار المحافظة*"),


};

            if (ValidateFields(textFields, comboFields))
            {
                MessageBox.Show("تم ملء جميع الحقول بنجاح!", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("يرجى ملء جميع الحقول المطلوبة.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
