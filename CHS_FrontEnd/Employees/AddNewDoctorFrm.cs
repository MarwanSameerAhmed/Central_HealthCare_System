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
            SetupEmailAutocomplete();
            ConfigureComboBoxTileMedSpe();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            ApplyEventsToTextBoxes(guna2ContainerControl2);
            ApplyEventsToTextBoxes(guna2ContainerControl4);
            ApplyEventsToTextBoxes(guna2ContainerControl1);

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

            txtDoctorEmail.AutoCompleteCustomSource = emailSuggestions;
            txtDoctorEmail.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtDoctorEmail.AutoCompleteSource = AutoCompleteSource.CustomSource;
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

        (txtLicenc, label8, "يرجى إدخال رخصة المزاولة *"),

    };

            List<(Guna.UI2.WinForms.Guna2ComboBox, Label, string)> comboFields = new List<(Guna.UI2.WinForms.Guna2ComboBox, Label, string)>
    {
        (gendertxt, gendererrorlbl, "يرجى تحديد الجنس*"),
        (txtDoctorTitle, jobErorr, "يرجى تحديد المسمى الوظيفي*"),
          (medicalSpeCom, MedicalSpecializationErorr, "يرجى إدخال أسم التخصص الطبي *"),
    };

            List<(Guna.UI2.WinForms.Guna2DateTimePicker, Label, string)> dateFields = new List<(Guna.UI2.WinForms.Guna2DateTimePicker, Label, string)>
    {
        (txtDateLcinesExp, licenceExpErorr, "يرجى تحديد تاريخ الاصدار للرخصة*"),
        (txtDateLiceinsgiven, licenesErorrgev, "يرجى تحديد الانتهاء للرخصة*"),
                (txtBirthDate, nationallblerror, "يرجى تحديد تاريخ الميلاد*"),


    };


            if (!ValidateFields(textFields, comboFields, dateFields))
            {
                CustomMessageBox.Show(CustomMessageBox.MessageType.Warning, "تحذير!", "يرجى التحقق من إدخال البيانات قبل المتابعة.");
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
                string DoctorMedicalSp = medicalSpeCom.Text;
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
                  CustomMessageBox.Show(CustomMessageBox.MessageType.Success, "نجاح!", response.MessageDescription);

                }
                else
                {
                    CustomMessageBox.Show(CustomMessageBox.MessageType.Error, "!خطأ", "فشل في إضافة الطبيب: " + response.MessageDescription);
                }
            }
            catch (Exception ex)
            {
                CustomMessageBox.Show(CustomMessageBox.MessageType.Error, "خطأ!", $"حدث خطأ أثناء إنشاء مستخدم للطبيب: {ex.Message}");

            }
        }



        private bool ValidateFields(
     List<(Guna.UI2.WinForms.Guna2TextBox TextBox, Label ErrorLabel, string ErrorMessage)> textFields,
     List<(Guna.UI2.WinForms.Guna2ComboBox ComboBox, Label ErrorLabel, string ErrorMessage)> comboFields,
     List<(Guna.UI2.WinForms.Guna2DateTimePicker DataTime, Label ErrorLabel, string ErrorMessage)> dateFields)
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


            foreach (var field in dateFields)
            {
                var dateTimePicker = field.DataTime;
                var errorLabel = field.ErrorLabel;
                var errorMessage = field.ErrorMessage;


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
        private readonly List<string> doctorJobTitles = new List<string>
        {
            "طبيب",
            " ممرض",
            "صيدلي",
            "فني مختبر",
            " اخصائي علاج طبيعي",
            "مسعف",


        };


        private void ConfigureComboBoxTile()
        {

            txtDoctorTitle.DataSource = doctorJobTitles;

            txtDoctorTitle.DropDownStyle = ComboBoxStyle.DropDownList;




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

        private void txtDoctorEmail_TextChanged(object sender, EventArgs e)
        {
            string text = txtDoctorEmail.Text;
            if (!text.Contains("@") && text.Length > 1)
            {
                txtDoctorEmail.AutoCompleteCustomSource.Clear();
                txtDoctorEmail.AutoCompleteCustomSource.Add(text + "@gmail.com");
                txtDoctorEmail.AutoCompleteCustomSource.Add(text + "@yahoo.com");
                txtDoctorEmail.AutoCompleteCustomSource.Add(text + "@outlook.com");
                txtDoctorEmail.AutoCompleteCustomSource.Add(text + "@hotmail.com");
            }
        }
        private void ConfigureComboBoxTileMedSpe()
        {

            medicalSpeCom.DataSource = doctorTitles;

            medicalSpeCom.DropDownStyle = ComboBoxStyle.DropDownList;





        }
        private void ClearFields()
        {
            txtDoctorName.Text = string.Empty;
            txtDoctorIDcard.Text = string.Empty;
            gendertxt.SelectedIndex = -1;
            txtDoctorTitle.SelectedIndex = -1;
            medicalSpeCom.SelectedIndex = -1;
            txtDoctorPassword.Text = string.Empty;
            txtDoctorUserName.Text = string.Empty;
            txtDoctorEmpDate.Value = DateTime.Today;
            txtDoctorAddress.Text = string.Empty;
            txtDoctorPhoneNumber.Text = string.Empty;
            txtDoctorEmail.Text = string.Empty;
            txtLicenc.Text = string.Empty;
            txtDateLcinesExp.Value = DateTime.Today;
            txtDateLiceinsgiven.Value = DateTime.Today;
            txtBirthDate.Value = DateTime.Today;




        }

        private void txtLicenc_TextChanged(object sender, EventArgs e)
        {
            label8.Visible = false;
            txtLicenc.BorderColor = System.Drawing.Color.FromArgb(1, 87, 155);
        }

        private void txtDateLiceinsgiven_TextChanged(object sender, EventArgs e)
        {
            licenesErorrgev.Visible = false;
            txtDateLiceinsgiven.BorderColor = System.Drawing.Color.FromArgb(1, 87, 155);
        }

        private void txtDateLcinesExp_TextChanged(object sender, EventArgs e)
        {
            licenceExpErorr.Visible = false;
            txtDateLcinesExp.BorderColor = System.Drawing.Color.FromArgb(1, 87, 155);
        }

        private void medicalSpeCom_TextChanged(object sender, EventArgs e)
        {
            MedicalSpecializationErorr.Visible = false;
            medicalSpeCom.BorderColor = System.Drawing.Color.FromArgb(1, 87, 155);
        }

        private void txtDoctorUserName_TextChanged(object sender, EventArgs e)
        {
            userErorr.Visible = false;
            txtDoctorUserName.BorderColor = System.Drawing.Color.FromArgb(1, 87, 155);
        }

        private void txtDoctorPassword_TextChanged(object sender, EventArgs e)
        {
            passswordErorr.Visible = false;
            txtDoctorPassword.BorderColor = System.Drawing.Color.FromArgb(1, 87, 155);
        }

        private void txtDoctorEmpDate_TextChanged(object sender, EventArgs e)
        {
            label12.Visible = false;
            txtDoctorEmpDate.BorderColor = System.Drawing.Color.FromArgb(1, 87, 155);
        }

        private void txtDoctorTitle_TextChanged(object sender, EventArgs e)
        {
            jobErorr.Visible = false;
            txtDoctorTitle.BorderColor = System.Drawing.Color.FromArgb(1, 87, 155);
        }
    }
}

