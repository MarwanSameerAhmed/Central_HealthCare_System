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
using WeifenLuo.WinFormsUI.Docking;
using System.Security.Principal;
using CHS.Client.API.Models.Facilities;
using Guna.UI2.WinForms;
using static System.Net.Mime.MediaTypeNames;

namespace CHS_FrontEnd
{
    public partial class AddNewFacilityFrm : Form
    {
        public AddNewFacilityFrm(DockPanel dockPanel)
        {
            InitializeComponent();
            SetupEmailAutocomplete();
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

        private void SetupEmailAutocomplete()
        {
            AutoCompleteStringCollection emailSuggestions = new AutoCompleteStringCollection();
            emailSuggestions.AddRange(new string[]
            {
  "@gmail.com",
  "@yahoo.com",
  "@outlook.com",
  "@hotmail.com",
  "@icloud.com"
            });

            txtFacilityEmail.AutoCompleteCustomSource = emailSuggestions;
            txtFacilityEmail.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtFacilityEmail.AutoCompleteSource = AutoCompleteSource.CustomSource;
           
        }
        private void SetupEmailAutocompleteAdmin()
        {
            AutoCompleteStringCollection emailSuggestions = new AutoCompleteStringCollection();
            emailSuggestions.AddRange(new string[]
            {
  "@gmail.com",
  "@yahoo.com",
  "@outlook.com",
  "@hotmail.com",
  "@icloud.com"
            });

            adminEmail.AutoCompleteCustomSource = emailSuggestions;
            adminEmail.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            adminEmail.AutoCompleteSource = AutoCompleteSource.CustomSource;

        }




        private void Form1_Load(object sender, EventArgs e)
        {
            ApplyEventsToTextBoxes(guna2ContainerControl1);
            ApplyEventsToTextBoxes(guna2ContainerControl2);
            try
            {
               
                var response = RequestSender.SendRequest<CHSRequest, GetFacilitiesTypesResponse>(new CHSRequest());

                if (response.ResponseCode == "1")
                {
                   
                    cmbFacilityType.DataSource = response.facilityTypes;
                    cmbFacilityType.DisplayMember = "Name"; 
                    cmbFacilityType.ValueMember = "ID";   
                }
                else
                {
                    MessageBox.Show("فشل في استرجاع أنواع المنشآت: " + response.MessageDescription, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"حدث خطأ أثناء استرجاع أنواع المنشآت: {ex.Message}", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            ConfigureComboBox();

        }

        private void ConfigureComboBox()
        {
            var genderList = new List<KeyValuePair<string, int>>
{
               new KeyValuePair<string, int>("ذكر", 1),
              new KeyValuePair<string, int>("أنثى", 0)
};

            adminGender.DataSource = genderList;
            adminGender.DisplayMember = "Key";
            adminGender.ValueMember = "Value";
        }

        private void ClearFields()
        {
            txtFacilityName.Text = string.Empty;
            txtFacilityPhones.Text = string.Empty;
            adminGender.SelectedIndex = -1;
            cmbFacilityType.SelectedIndex = -1;
            adminNationalIDcard.Text = string.Empty;
            txtFacilityAddress.Text = string.Empty;
            AdminbirthDate.Value = DateTime.Today;
            adminPassword.Text = string.Empty;
            adminUserName.Text = string.Empty;
            adminTileJob.Text = string.Empty;
            adminPhoneNumber.Text = string.Empty;
            adminName.Text = string.Empty;
            txtFacilityEmail.Text = string.Empty;
            adminEmail.Text = string.Empty;
            adminEmployeementDate.Value = DateTime.Today;
            


        }



        private async void createBtn_Click(object sender, EventArgs e)
        {


  
    List<(Guna.UI2.WinForms.Guna2TextBox, Label, string)> textFields = new List<(Guna.UI2.WinForms.Guna2TextBox, Label, string)>
    {
        (txtFacilityName, FacilityNameError, "يرجى إدخال أسم المنشأة*"),
        (txtFacilityPhones, PhoneFacilityErrorLabel, "يرجى إدخال رقم الهاتف*"),
        (txtFacilityEmail, EmailErrorlbl, "يرجى إدخال البريد الالكتروني*"),
        (txtFacilityAddress, errorlblAddress, "يرجى تحديد موقع المنشأة*"),
        (adminName, adminNameError, "يرجى إدخال الاسم*"),
        (adminPhoneNumber, adminPhoneError, "يرجى إدخال رقم الهاتف *"),
        (adminNationalIDcard, NationalNumberErorr, "يرجى إدخال رقم الهوية *"),
        (adminUserName, adminUserError, "يرجى إدخال أسم المستخدم *"),
        (adminPassword, adminPasswordError, "يرجى إدخال  كلمة المرور *"),
        (adminEmail, adminEmailErorr, "يرجى إدخال البريد الالكتروني  *"),
    };

    List<(Guna.UI2.WinForms.Guna2ComboBox, Label, string)> comboFields = new List<(Guna.UI2.WinForms.Guna2ComboBox, Label, string)>
    {
        (cmbFacilityType, facilityTypeErrorCmp, "يرجى اختيار نوع المنشأة*"),
        (adminGender, gendererrorCmp, "يرجى اختيار الجنس*"),
    };

    
    if (!ValidateFields(textFields, comboFields))
    {
        MessageBox.Show("يرجى ملء جميع الحقول المطلوبة.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        return;
    }


            try
            {

                string facilityName = txtFacilityName.Text;
                string facilityAddress = txtFacilityAddress.Text;
                string facilityPhones = txtFacilityPhones.Text;
                string facilityEmail = txtFacilityEmail.Text;
                int facilityType = (int)cmbFacilityType.SelectedValue;
                string dminName = adminName.Text;
                string AdminPhoneNumber = adminPhoneNumber.Text;
                string AdminEmail = adminEmail.Text;
                string AdminJobTile = adminTileJob.Text;
                string AdminBirthDate = AdminbirthDate.Value.ToString("yyyy-MM-dd");
                string AdminEmployeementDate = adminEmployeementDate.Value.ToString("yyyy-MM-dd");
                string AdminUserName = adminUserName.Text;
                string AdminPassword = adminPassword.Text;
                string AdminIDCard = adminNationalIDcard.Text;
                bool AdminGender = adminGender.SelectedItem?.ToString() == "1";

                var request = new CreateFacilityRequest
                {
                    RequestID = Guid.NewGuid().ToString(),
                    FacilityName = facilityName,
                    FacilityAddress = facilityAddress,
                    FacilityPhones = facilityPhones.Split(',').ToList(),
                    FacilityEmail = facilityEmail,
                    FacilityType = facilityType,
                    AdminName = dminName,
                    AdminIDCardNumber = AdminPhoneNumber,
                    AdminPhoneNumber = AdminPhoneNumber,
                    AdminBirthData = AdminBirthDate,
                    AdminIsMale = AdminGender,
                    AdminEmail = AdminEmail,
                    AdminEmployementDate = AdminEmployeementDate,
                    AdminUserName = AdminUserName,
                    AdminPassword = AdminPassword,
                    AdminJobTitle = AdminJobTile,


                };


                var response = await Task.Run(() => RequestSender.SendRequest < CreateFacilityRequest, CreateFacilityResponse>(request));


        if (response.ResponseCode == "1")
        {
                    adminUserName.Text = response.AdminUserName;
            MessageBox.Show(response.MessageDescription, "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearFields();
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

        private void AdminbirthDate_TextChanged(object sender, EventArgs e)
        {
            dateerror.Visible = true;
        }

        private void adminEmployeementDate_TextChanged(object sender, EventArgs e)
        {
            label8.Visible = true;
        }

        private void adminTileJob_TextChanged(object sender, EventArgs e)
        {
            label9.Visible = true;
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

     
        private void txtFacilityEmail_TextChanged(object sender, EventArgs e)
        {

            string text = txtFacilityEmail.Text;
            if (!text.Contains("@") && text.Length > 1)
            {
                txtFacilityEmail.AutoCompleteCustomSource.Clear();
                txtFacilityEmail.AutoCompleteCustomSource.Add(text + "@gmail.com");
                txtFacilityEmail.AutoCompleteCustomSource.Add(text + "@yahoo.com");
                txtFacilityEmail.AutoCompleteCustomSource.Add(text + "@outlook.com");
                txtFacilityEmail.AutoCompleteCustomSource.Add(text + "@hotmail.com");
            }
        }

        private void adminEmail_TextChanged(object sender, EventArgs e)
        {
            string text = adminEmail.Text;
            if (!text.Contains("@") && text.Length > 1)
            {
                adminEmail.AutoCompleteCustomSource.Clear();
                adminEmail.AutoCompleteCustomSource.Add(text + "@gmail.com");
                adminEmail.AutoCompleteCustomSource.Add(text + "@yahoo.com");
                adminEmail.AutoCompleteCustomSource.Add(text + "@outlook.com");
                adminEmail.AutoCompleteCustomSource.Add(text + "@hotmail.com");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void txtFacilityName_TextChanged(object sender, EventArgs e)
        {
            FacilityNameError.Visible = false;
            txtFacilityName.BorderColor = System.Drawing.Color.FromArgb(1, 87, 155);

        }

        private void txtFacilityPhones_TextChanged(object sender, EventArgs e)
        {
            PhoneFacilityErrorLabel.Visible = false;
            txtFacilityPhones.BorderColor = System.Drawing.Color.FromArgb(1, 87, 155);
        }

        private void txtFacilityAddress_TextChanged(object sender, EventArgs e)
        {
            errorlblAddress.Visible = false;
            txtFacilityAddress.BorderColor = System.Drawing.Color.FromArgb(1, 87, 155);
        }

        private void adminName_TextChanged(object sender, EventArgs e)
        {
            adminNameError.Visible = false;
            adminName.BorderColor = System.Drawing.Color.FromArgb(1, 87, 155);
        }

        private void adminPhoneNumber_TextChanged(object sender, EventArgs e)
        {
            adminPhoneError.Visible = false;
            adminPhoneNumber.BorderColor = System.Drawing.Color.FromArgb(1, 87, 155);
        }

        private void adminUserName_TextChanged(object sender, EventArgs e)
        {
            adminUserError.Visible = false;
            adminUserName.BorderColor = System.Drawing.Color.FromArgb(1, 87, 155);
        }

        private void adminNationalIDcard_TextChanged(object sender, EventArgs e)
        {
            NationalNumberErorr.Visible = false;
            adminNationalIDcard.BorderColor = System.Drawing.Color.FromArgb(1, 87, 155);
        }

        private void adminPassword_TextChanged(object sender, EventArgs e)
        {
            adminPasswordError.Visible = false;
            adminPassword.BorderColor = System.Drawing.Color.FromArgb(1, 87, 155);
        }
    }
    }

