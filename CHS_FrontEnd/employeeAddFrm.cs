using CHS.Client.API.Models.Facilities;
using CHS.Client.API.Models;
using CHS.Client.API;
using Guna.UI2.WinForms;
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
using CHS.Client.API.Models.Employees;


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
            ApplyEventsToTextBoxes(guna2ContainerControl2);
            ApplyEventsToTextBoxes(guna2ContainerControl4);
            ApplyEventsToTextBoxes(guna2ContainerControl1);
            empTypeCombo.Items.Add("شاقي");
            ConfigureComboBox();

        }
        private void ConfigureComboBox()
        {
            var genderList = new List<KeyValuePair<string, int>>
{
               new KeyValuePair<string, int>("ذكر", 1),
              new KeyValuePair<string, int>("أنثى", 0)
};

            empGendertxt.DataSource = genderList;
            empGendertxt.DisplayMember = "Key";
            empGendertxt.ValueMember = "Value";
        }

        private void empAgetxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }


        private void ApplyEventsToTextBoxes(Control parentControl)
        {
            foreach (Control control in parentControl.Controls)
            {
                if (control is Guna.UI2.WinForms.Guna2TextBox textBox)
                {
                    textBox.Enter += Guna2TextBox_Enter;
                    textBox.Leave += Guna2TextBox_Leave;
                }
                else if (control.HasChildren)
                {

                    ApplyEventsToTextBoxes(control);
                }
            }
        }

        private Font normalFont = new Font("Traditional Arabic", 12.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));


        private Font largeFont = new Font("Traditional Arabic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));


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
                    comboBox.BorderColor = Color.FromArgb(1, 87, 155); 
                }
            }

            return isValid;
        }

        private async void createBtn_Click(object sender, EventArgs e)
        {
            List<(Guna.UI2.WinForms.Guna2TextBox, Label, string)> textFields = new List<(Guna.UI2.WinForms.Guna2TextBox, Label, string)>
{
    (empFullNametxt, labelError, "يرجى ادخال الأسم كاملا*"),
    (empPhoneNumbertxt, labelerrorPhone, "يرجى إدخال رقم الهاتف*"),

    (userNametxt, label11, "يرجى إدخال أسم المستخدم *"),
    (passwordtxt, label13, "يرجى إدخال كلمة المرور *"),
 
     (empEmailTxt, emaillbl, "يرجى إدخال الايميل للموظف*"),
     

};

            List<(Guna.UI2.WinForms.Guna2ComboBox, Label, string)> comboFields = new List<(Guna.UI2.WinForms.Guna2ComboBox, Label, string)>
{
    (empGendertxt, gendererrorlbl, "يرجى اختيار الجنس*"),
   
    (empTypeCombo, emptypelbl, "يرجى اختيار نوع الموظف*"),
 


};
            if (!ValidateFields(textFields, comboFields))
            {
                MessageBox.Show("يرجى ملء جميع الحقول المطلوبة.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {

                string EmployeeName = empFullNametxt.Text;
                string EmployeePhones = empPhoneNumbertxt.Text;
                string EmployeeEmail = empEmailTxt.Text;
                string EmployeeIDCard = empNationalIDtxt.Text;
                string EmployeeBirthDay = empBirthdaytxt.Value.ToString("yyyy-MM-dd");
                string EmployeeJobTile = emptypelbl.Text;
                string EmployementDate = employmentDate.Value.ToString("yyyy-MM-dd");
                bool EmployeeIsMale = empGendertxt.SelectedItem?.ToString() == "";
                string EmployeeUserName = userNametxt.Text;
                string EmployeePassword = passwordtxt.Text;
               
                var request = new CreateEmployeeRequest
                {
                    RequestID = Guid.NewGuid().ToString(),
                    EmployeeName = EmployeeName,
                    EmployeeIDCardNumber = EmployeeIDCard,
                    EmployeePhoneNumber = EmployeePhones,
                    EmployeeBirthData = EmployeeBirthDay,
                    EmployeeIsMale = EmployeeIsMale,
                    EmployeeEmployementDate = EmployementDate,
                    EmployeeEmail = EmployeeEmail,
                    EmployeeJobTitle = EmployeeJobTile,
                    EmployeeUserName = EmployeeUserName,
                    EmployeePassword = EmployeePassword,
                   

                };


                var response = await Task.Run(() => RequestSender.SendRequest<CreateEmployeeRequest, CreateEmployeeResponse>(request));

                if (response.ResponseCode == "1")

                {
                    userNametxt.Text = response.EmployeeUserName;
                    MessageBox.Show(response.MessageDescription, "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("فشل في إضافة المنشأة: " + response.MessageDescription, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"حدث خطأ أثناء إنشاء المنشأة: {ex.Message}", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
