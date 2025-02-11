using CHS.Client.API.Models.Employees;
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
using Guna.UI2.WinForms;

namespace CHS_FrontEnd
{
    public partial class AddNewDoctorFrm : Form
    {
        public AddNewDoctorFrm(DockPanel dockPanel)
        {
            InitializeComponent();
            ConfigureComboBox();
            ConfigureComboBoxTile();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            ApplyEventsToTextBoxes(guna2ContainerControl2);
            ApplyEventsToTextBoxes(guna2ContainerControl4);
            ApplyEventsToTextBoxes(guna2ContainerControl1);
        }

        private void ConfigureComboBox()
        {
            var genderList = new List<KeyValuePair<string, int>>
{
               new KeyValuePair<string, int>("ذكر", 1),
              new KeyValuePair<string, int>("أنثى", 0)
};

            gendertxt.DataSource = genderList;
            gendertxt.DisplayMember = "Key"; 
            gendertxt.ValueMember = "Value";  
        }

        private async void createBtn_Click(object sender, EventArgs e)
        {
            List<(Guna.UI2.WinForms.Guna2TextBox, Label, string)> textFields = new List<(Guna.UI2.WinForms.Guna2TextBox, Label, string)>
    {
        (txtDoctorName, nameerror, "يرجى إدخال أسم الطبيب*"),
        (txtDoctorPhoneNumber, phoneError, "يرجى إدخال رقم الهاتف*"),
        (txtDoctorEmail, emailErorr, "يرجى إدخال البريد الالكتروني*"),
        (txtDoctorAddress, addressErorr, "يرجى تحديد عنوان الطبيب*"),
        (txtDoctorUserName, userErorr, "يرجى إدخال اسم المستخدم*"),
        (txtDoctorPassword, passswordErorr, "يرجى إدخال كلمة السر *"),
        (txtDoctorIDcard, IdError, "يرجى إدخال رقم الهوية *"),
        (txtMedicalSpecialization, MedicalSpecializationErorr, "يرجى إدخال أسم التخصص الطبي *"),
        (txtLicenc, label8, "يرجى إدخال رخصة المزاولة *"),
       
    };

            List<(Guna.UI2.WinForms.Guna2ComboBox, Label, string)> comboFields = new List<(Guna.UI2.WinForms.Guna2ComboBox, Label, string)>
    {
        (gendertxt, gendererrorlbl, "يرجى تحديد الجنس*"),
        (txtDoctorTitle, jobErorr, "يرجى تحديد المسمى الوظيفي*"),
    };

            List<(Guna.UI2.WinForms.Guna2DateTimePicker, Label, string)> dateFields = new List<(Guna.UI2.WinForms.Guna2DateTimePicker, Label, string)>
    {
        (txtDateLcinesExp, licenceExpErorr, "يرجى تحديد تاريخ الاصدار للرخصة*"),
        (txtDateLiceinsgiven, licenesErorrgev, "يرجى تحديد الانتهاء للرخصة*"),
                (txtBirthDate, nationallblerror, "يرجى تحديد تاريخ الميلاد*"),


    };


            if (!ValidateFields(textFields, comboFields,dateFields))
            {
                MessageBox.Show("يرجى ملء جميع الحقول المطلوبة.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }



            try
            {

                string DoctorName = txtDoctorName.Text;
                string DoctorPhones = txtDoctorPhoneNumber.Text;
                string DoctorEmail = txtDoctorEmail.Text;
                string DoctorIDCard = txtDoctorIDcard.Text;
                string DoctorBirthDay = txtBirthDate.Value.ToString("yyyy-MM-dd");
                string DoctorJobTile = txtDoctorTitle.Text;
                string DoctorEmpDate = txtDoctorEmpDate.Value.ToString("yyyy-MM-dd");
                bool DoctorIsMalee = gendertxt.SelectedItem?.ToString() == "1";
                string DoctorUserName = txtDoctorUserName.Text;
                string DoctorPassword = txtDoctorPassword.Text;
                string DoctorMedicalSp = txtMedicalSpecialization.Text;
                string DoctorLicenec = txtLicenc.Text;
                string DoctorLicencExp = txtDateLcinesExp.Value.ToString("yyyy-MM-dd");
                string DoctorLicencGev = txtDateLiceinsgiven.Value.ToString("yyyy-MM-dd");



                var request = new CreateDoctorRequest
                {
                    RequestID = Guid.NewGuid().ToString(),
                    DoctorName = DoctorName,
                    DoctorBirthData = DoctorBirthDay,
                    DoctorEmail = DoctorEmail,
                    DoctorEmployementDate = DoctorEmpDate,
                    DoctorIDCardNumber = DoctorIDCard,
                    DoctorJobTitle = DoctorJobTile,
                    DoctorLicenseNumber = DoctorLicenec,
                    DoctorUserName = DoctorUserName,
                    DoctorPassword = DoctorPassword,
                    DoctorPhoneNumber = DoctorPhones,
                    LicenseExpiryDate = DoctorLicencExp,    
                    LicenseReleaseDate = DoctorLicencGev,
                    MedicalSpecialization = DoctorMedicalSp,
                    DoctorIsMale = DoctorIsMalee,



                };


                var response = await Task.Run(() => RequestSender.SendRequest<CreateDoctorRequest, CreateDoctorResponse>(request));

                if (response.ResponseCode == "1")
                {
                  txtDoctorUserName.Text = response.DoctorUserName;
                    MessageBox.Show(response.MessageDescription, "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("فشل في إضافة الطبيب: " + response.MessageDescription, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"حدث خطأ أثناء إنشاء مستخدم للطبيب: {ex.Message}", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private bool ValidateFields(
     List<(Guna.UI2.WinForms.Guna2TextBox TextBox, Label ErrorLabel, string ErrorMessage)> textFields,
     List<(Guna.UI2.WinForms.Guna2ComboBox ComboBox, Label ErrorLabel, string ErrorMessage)> comboFields,
     List<(Guna.UI2.WinForms.Guna2DateTimePicker DataTime, Label ErrorLabel, string ErrorMessage)> dateFields)
        {
            bool isValid = true;

            // التحقق من الحقول النصية
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

            // التحقق من القوائم المنسدلة
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

            // التحقق من حقول التاريخ
            foreach (var field in dateFields)
            {
                var dateTimePicker = field.DataTime;
                var errorLabel = field.ErrorLabel;
                var errorMessage = field.ErrorMessage;

                // التحقق مما إذا كان التاريخ لم يتم تغييره من القيمة الافتراضية
                if (dateTimePicker.Value == dateTimePicker.MinDate)
                {
                    errorLabel.Text = errorMessage;
                    errorLabel.Visible = true;
                    dateTimePicker.BorderColor = Color.Red;
                    isValid = false;
                }
                else
                {
                    errorLabel.Visible = false;
                    dateTimePicker.BorderColor = Color.FromArgb(1, 87, 155);
                }
            }

            return isValid;
        }

        private readonly List<string> doctorTitles = new List<string>
        {
            "طبيب عام",
            "طبيب أسرة",
            "طبيب باطني",
            "طبيب طوارئ",
            "طبيب جراحة عامة",
            "طبيب جراحة العظام",
            "طبيب جراحة المخ والأعصاب",
            "طبيب أمراض النساء والتوليد",
            "طبيب أطفال",
            "طبيب أمراض القلب",
            "طبيب أمراض الجهاز الهضمي",
            "طبيب أمراض الجهاز التنفسي",
            "طبيب أمراض الكلى",
            "طبيب الغدد الصماء",
            "طبيب أمراض الدم",
            "طبيب الأورام",
            "طبيب أمراض الأعصاب",
            "طبيب التخدير",
            "طبيب العناية المركزة",
            "طبيب الأمراض المعدية",
            "طبيب أمراض الروماتيزم",
            "طبيب العيون",
            "طبيب الأنف والأذن والحنجرة",
            "طبيب الأمراض الجلدية",
            "طبيب الأشعة",
            "طبيب الأشعة التداخلية",
            "طبيب جراحة المسالك البولية",
            "طبيب الطب النفسي",
            "طبيب جراحة القلب والصدر",
            "طبيب الطب الطبيعي وإعادة التأهيل"
        };


        private void ConfigureComboBoxTile()
        {

            txtDoctorTitle.DataSource = doctorTitles;

            txtDoctorTitle.DropDownStyle = ComboBoxStyle.DropDownList;
            
          

            
            txtDoctorTitle.SelectedIndexChanged += txtDoctorTitle_SelectedIndexChanged;
            txtDoctorTitle.Leave += txtDoctorTitle_Leave;
        }



        private void txtDoctorTitle_Leave_1(object sender, EventArgs e)
        {
            if (!doctorTitles.Contains(txtDoctorTitle.Text))
            {
                MessageBox.Show("⚠️ الرجاء إدخال مسمى وظيفي صحيح من القائمة!", "تحذير", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDoctorTitle.Focus();
            }
        }

        private void txtDoctorTitle_SelectedValueChanged(object sender, EventArgs e)
        {

        }

        private void txtDoctorTitle_SelectedIndexChanged(object sender, EventArgs e)
        {
            ValidateDoctorTitle();
        }

        private void txtDoctorTitle_Leave(object sender, EventArgs e)
        {
            ValidateDoctorTitle();
        }
        private void ValidateDoctorTitle()
        {
            if (!doctorTitles.Contains(txtDoctorTitle.Text))
            {
                MessageBox.Show("⚠️ الرجاء اختيار مسمى وظيفي صحيح من القائمة!", "تحذير", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDoctorTitle.Focus();
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

        private void txtDoctorName_TextChanged(object sender, EventArgs e)
        {
            nameerror.Visible = false;
            txtDoctorName.BorderColor = System.Drawing.Color.FromArgb(1, 87, 155);
        }

        private void txtDoctorPhoneNumber_TextChanged(object sender, EventArgs e)
        {
            phoneError.Visible = false;
            txtDoctorPhoneNumber.BorderColor = System.Drawing.Color.FromArgb(1, 87, 155);
        }

        private void txtDoctorIDcard_TextChanged(object sender, EventArgs e)
        {
            IdError.Visible = false;
            txtDoctorIDcard.BorderColor = System.Drawing.Color.FromArgb(1, 87, 155);
        }

        private void txtDoctorAddress_TextChanged(object sender, EventArgs e)
        {
            addressErorr.Visible = false;
            txtDoctorAddress.BorderColor = System.Drawing.Color.FromArgb(1, 87, 155);
        }

        private void gendertxt_TextChanged(object sender, EventArgs e)
        {
            gendererrorlbl.Visible = false;
            gendertxt.BorderColor = System.Drawing.Color.FromArgb(1, 87, 155);
        }

        private void txtBirthDate_TextChanged(object sender, EventArgs e)
        {
            nationallblerror.Visible = false;
            txtBirthDate.BorderColor = System.Drawing.Color.FromArgb(1, 87, 155);
        }
    }

}

