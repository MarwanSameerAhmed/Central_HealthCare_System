using CHS.Client.API.Models;
using CHS.Client.API;
using CHS.Client.API.Models.Facilities;
using CHS.Client.API.Models.Patients;
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

namespace CHS_FrontEnd
{
    public partial class addingPatientFrm : Form
    {
        private DockPanel dockPanel;
        private List<string> diseasesList = new List<string>();
        private List<string> allergiesList = new List<string>();
        private List<string> medicationsList = new List<string>();

        private int currentX = 10;
        private int currentY = 10;
        private int chipSpacing = 10;



        public addingPatientFrm(DockPanel dockPanel)
        {
            InitializeComponent();
            this.dockPanel = dockPanel;


            InitializeAutoComplete(sensitivitiesTxt, new[] { "السكري", "الربو", "ارتفاع ضغط الدم", "حساسية القمح" });
            InitializeAutoComplete(diseasesTxt, new[] { "مرض السكري", "الضغط", "السرطان" });
            InitializeAutoComplete(medicinesTxt, new[] { "أسبيرين", "أموكسيسيلين", "باراسيتامول" });

            sensitivitiesTxt.KeyDown += (sender, e) => OnKeyDownHandler(sender, e, "الحساسية");
            diseasesTxt.KeyDown += (sender, e) => OnKeyDownHandler(sender, e, "المرض");
            medicinesTxt.KeyDown += (sender, e) => OnKeyDownHandler(sender, e, "الدواء");



        }



        private void InitializeAutoComplete(Guna2TextBox textBox, string[] suggestions)
        {
            textBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            textBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
            var autoComplete = new AutoCompleteStringCollection();
            autoComplete.AddRange(suggestions);
            textBox.AutoCompleteCustomSource = autoComplete;
        }


        private void OnKeyDownHandler(object sender, KeyEventArgs e, string type)
        {
            var textBox = sender as Guna2TextBox;
            Label errorLabel = null;


            switch (type)
            {
                case "المرض":
                    errorLabel = label22;
                    break;
                case "الحساسية":
                    errorLabel = label23;
                    break;
                case "الدواء":
                    errorLabel = label24;
                    break;
            }

            if (e.KeyCode == Keys.Enter && !string.IsNullOrWhiteSpace(textBox.Text))
            {
                string inputText = textBox.Text.Trim();


                if (!IsValidInput(textBox, inputText))
                {
                    errorLabel.Visible = true;
                    errorLabel.Text = $"{type} غير موجود بالقائمة*";
                    textBox.Clear();
                    return;
                }


                errorLabel.Visible = false;


                if (!IsDuplicate(inputText, type))
                {

                    switch (type)
                    {
                        case "المرض":
                            diseasesList.Add(inputText);
                            AddChip(inputText, type, flowLayoutPanel3);
                            break;
                        case "الحساسية":
                            allergiesList.Add(inputText);
                            AddChip(inputText, type, flowLayoutPanel2);
                            break;
                        case "الدواء":
                            medicationsList.Add(inputText);
                            AddChip(inputText, type, flowLayoutPanel1);
                            break;
                    }
                    textBox.Clear();
                }
                else
                {
                    MessageBox.Show("العنصر مضاف بالفعل.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private bool IsValidInput(Guna2TextBox textBox, string inputText)
        {

            return textBox.AutoCompleteCustomSource.Contains(inputText);
        }
        private bool IsDuplicate(string inputText, string type)
        {
            switch (type)
            {
                case "المرض":
                    return diseasesList.Contains(inputText);
                case "الحساسية":
                    return allergiesList.Contains(inputText);
                case "الدواء":
                    return medicationsList.Contains(inputText);
                default:
                    return false;
            }
        }


        private void AddChip(string text, string type, FlowLayoutPanel container)
        {
            var chip = new Guna2Chip
            {
                Text = text,
                FillColor = GetChipColor(type),
                ForeColor = System.Drawing.Color.White,
                BorderRadius = 15,

                Padding = new Padding(2),
                AutoSize = true,
            };

            chip.Location = new Point(currentX, currentY);


            currentX += chip.Width + chipSpacing;
            if (currentX + chip.Width > container.Width)
            {
                currentX = 10;
                currentY += chip.Height + chipSpacing;
            }


            chip.DoubleClick += (s, e) =>
            {
                container.Controls.Remove(chip);
                RemoveFromList(text, type);
            };

            container.Controls.Add(chip);
        }


        private Color GetChipColor(string type)
        {
            switch (type)
            {
                case "المرض":
                    return Color.DarkBlue;
                case "الحساسية":
                    return Color.Green;
                case "الدواء":
                    return Color.Purple;
                default:
                    return Color.Gray;
            }
        }
        private void RemoveFromList(string text, string type)
        {
            switch (type)
            {
                case "المرض":
                    diseasesList.Remove(text);
                    break;
                case "الحساسية":
                    allergiesList.Remove(text);
                    break;
                case "الدواء":
                    medicationsList.Remove(text);
                    break;
            }
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            string[] bloodTypes = { "AB+", "AB-", "A+", "A-", "B+", "B-", "O+", "O-" };
            bloodtxt.Items.AddRange(bloodTypes);
            string[] maritalStatus = { "أعزب", "متزوج", "أرمل", "مطلق", "منفصل" };
            comuintystateCombo.Items.AddRange(maritalStatus);
            string[] yemenProvinces = 
    {
        "أمانة العاصمة",
        "عدن",
        "تعز",
        "إب",
        "حضرموت",
        "مأرب",
        "الحديدة",
        "صعدة",
        "البيضاء",
        "شبوة",
        "الضالع",
        "لحج",
        "عمران",
        "الجوف",
        "ذمار",
        "المهرة",
        "سقطرى",
        "أبين",
        "صنعاء"
    };
            statetxt.Items.AddRange(yemenProvinces);
            ConfigureComboBox();
            ApplyEventsToTextBoxes(guna2ContainerControl1);
            ApplyEventsToTextBoxes(guna2ContainerControl2);
            ApplyEventsToTextBoxes(guna2ContainerControl3);
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

        private void ClearFields()
        {
            fullNametxt.Text = string.Empty;
            PhoneNumbertxt.Text = string.Empty;
            gendertxt.SelectedIndex = -1;
            nationalIDtxt.Text = string.Empty;
            addresstxt.Text = string.Empty;
            bloodtxt.SelectedIndex = -1;
            birthdaytxt.Value = DateTime.Today;
            statetxt.Text = string.Empty;
            comuintystateCombo.SelectedIndex = -1;
            parenttxt.Text = string.Empty;


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
            //            List<(Guna.UI2.WinForms.Guna2TextBox, Label, string)> textFields = new List<(Guna.UI2.WinForms.Guna2TextBox, Label, string)>
            //{
            //    (fullNametxt, labelError, "هذا الحقل مطلوب*"),
            //    (PhoneNumbertxt, labelerrorPhone, "يرجى إدخال رقم الهاتف*"),
            //    (agetxt, errorlblage, "يرجى إدخال العمر*"),

            //    (nationalIDtxt, nationallblerror, "يرجى إدخال رقم الهوية*"),
            //     (addresstxt, addresslblerror, "يرجى إدخال العنوان للمريض*"),
            //      (parenttxt, parentlblerror, "يرجى إدخال اسم ولي الامر *")
            //};

            //            List<(Guna.UI2.WinForms.Guna2ComboBox, Label, string)> comboFields = new List<(Guna.UI2.WinForms.Guna2ComboBox, Label, string)>
            //{
            //    (gendertxt, gendererrorlbl, "يرجى اختيار الجنس*"),
            //    (statetxt, countryErrorLabel, "يرجى اختيار المحافظة*"),
            //     (bloodtxt, bloodlbl, "يرجى اختيار فصيلة الدم*"),
            //      (comuintystateCombo, cumintystatelblerror, "يرجى اختيار الحالة الاجتماعية*"),
            //};

            //            if (!ValidateFields(textFields, comboFields))
            //            {

            //                MessageBox.Show("يرجى ملء جميع الحقول المطلوبة.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //                return;

            //            }

            try
            {

                string patientName = fullNametxt.Text;
                var patientPhones = PhoneNumbertxt.Text.Trim().Split(',').ToList();
                string patientIDcard = nationalIDtxt.Text;
                string patientBirthdate = birthdaytxt.Value.ToString("yyyy-MM-dd");
                bool patientIsMale = gendertxt.SelectedItem?.ToString() == "1";
                string patientAddress = addresstxt.Text;
                string bloodtype = bloodtxt.Text;
                string maritalStatus = comuintystateCombo.Text;
                string birthPlace = statetxt.Text;
                string companionName = parenttxt.Text;

                var request = new CreatePatientFileRequest
                {
                    RequestID = Guid.NewGuid().ToString(),
                    PatientName = patientName,
                    PatientAddress = patientAddress,
                    PatientPhones = patientPhones,
                    IDCardNumber = patientIDcard,
                    IsMale = patientIsMale,
                    BirthDate = patientBirthdate,
                    BloodType = bloodtype,
                    maritalStatus = maritalStatus,
                    birthPlace = birthPlace,
                    companionName = companionName,



                };

                var response = await Task.Run(() => RequestSender.SendRequest<CreatePatientFileRequest, CHSResponse>(request));

                if (response.ResponseCode == "1")
                {
                    MessageBox.Show(response.MessageDescription, "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearFields();
                }
                else
                {
                    MessageBox.Show("فشل في إضافة المريض: " + response.MessageDescription, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"حدث خطأ أثناء إنشاء المريض: {ex.Message}", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
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



        private Font normalFont = new Font("Traditional Arabic", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));


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



        private void fullNametxt_TextChanged(object sender, EventArgs e)
        {
            labelError.Visible = false;
            fullNametxt.BorderColor = System.Drawing.Color.FromArgb(1, 87, 155);
        }





        private void gendertxt_TextChanged(object sender, EventArgs e)
        {
            gendererrorlbl.Visible = false;
            gendertxt.BorderColor = System.Drawing.Color.FromArgb(1, 87, 155);
        }

        private void nationalIDtxt_TextChanged(object sender, EventArgs e)
        {
            nationallblerror.Visible = false;
            nationalIDtxt.BorderColor = System.Drawing.Color.FromArgb(1, 87, 155);
        }

        private void statetxt_TextChanged(object sender, EventArgs e)
        {
            countryErrorLabel.Visible = false;
            statetxt.BorderColor = System.Drawing.Color.FromArgb(1, 87, 155);
        }

        private void bloodtxt_TextChanged(object sender, EventArgs e)
        {
            bloodlbl.Visible = false;
            bloodtxt.BorderColor = System.Drawing.Color.FromArgb(1, 87, 155);
        }

        private void PhoneNumbertxt_TextChanged(object sender, EventArgs e)
        {
            labelerrorPhone.Visible = false;
            PhoneNumbertxt.BorderColor = System.Drawing.Color.FromArgb(1, 87, 155);
        }

        private void addresstxt_TextChanged(object sender, EventArgs e)
        {
            addresslblerror.Visible = false;
            addresstxt.BorderColor = System.Drawing.Color.FromArgb(1, 87, 155);
        }

        private void parenttxt_TextChanged(object sender, EventArgs e)
        {
            parentlblerror.Visible = false;
            parenttxt.BorderColor = System.Drawing.Color.FromArgb(1, 87, 155);
        }

        private void comuintystateCombo_TextChanged(object sender, EventArgs e)
        {

            comuintystateCombo.BorderColor = System.Drawing.Color.FromArgb(1, 87, 155);
        }



        private void diseasesTxt_TextChanged_1(object sender, EventArgs e)
        {
            label17.Visible = true;
        }

        private void sensitivitiesTxt_TextChanged_1(object sender, EventArgs e)
        {
            label20.Visible = true;
        }

        private void medicinesTxt_TextChanged_1(object sender, EventArgs e)
        {
            label21.Visible = true;
        }

        private void guna2ContainerControl1_Click(object sender, EventArgs e)
        {

        }

        private void birthdaytxt_ValueChanged(object sender, EventArgs e)
        {
            DateTime birthDate = birthdaytxt.Value;
            int age = DateTime.Now.Year - birthDate.Year;


            if (DateTime.Now < birthDate.AddYears(age))
            {
                age--;
            }
            Agetxt.Text = age.ToString();
        }

        private void Agetxt_TextChanged(object sender, EventArgs e)
        {
            int age;
            if (int.TryParse(Agetxt.Text, out age) && age > 0)
            {
                int currentYear = DateTime.Now.Year;
                int estimatedBirthYear = currentYear - age;
                birthdaytxt.Value = new DateTime(estimatedBirthYear, 1, 1);
            }
        }
    }
}

