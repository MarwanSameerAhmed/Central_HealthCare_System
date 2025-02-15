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

namespace CHS_FrontEnd
{
    public partial class addNewDaignosis : Form
    {
        private int selectedRowIndex = -1;
        private List<string> symptomsList = new List<string>();
        private List<string> testsList = new List<string>();

        private List<string> demoMedicineNames = new List<string>
{
    "أسبيرين", "باراسيتامول", "إيبوبروفين", "أموكسيسيلين", "كلاريثروميسين"
};

        private List<string> demoDosages = new List<string>
{
    "500 ملجم", "250 ملجم", "1 جم", "5 مل", "10 مل"
};
        private List<string> demoDurations = new List<string>
{
    "5 أيام", "7 أيام", "10 أيام", "2 أسابيع", "شهر"
        };
        List<string> MidTimes = new List<string>
        {
            "08:00 صباحًا",
            "12:00 ظهرًا",
            "04:00 مساءً",
            "08:00 مساءً",
            "06:00 صباحًا"
        };

        public addNewDaignosis()
        {
            InitializeComponent();

            InitializeAutoComplete(testsTxt, new[] { "فحص الدم", "فحص السكري", "فحص الأشعة", "فحص البول" });


            symptomsTxt.KeyDown += (sender, e) => OnKeyDownHandler(sender, e, "العَرَض");
            testsTxt.KeyDown += (sender, e) => OnKeyDownHandler(sender, e, "الفحص");

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

            if (e.KeyCode == Keys.Enter && !string.IsNullOrWhiteSpace(textBox.Text))
            {
                string inputText = textBox.Text.Trim();

                if (type == "الفحص" && !IsValidInput(textBox, inputText))
                {
                    MessageBox.Show("الفحص غير موجود بالقائمة.", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBox.Clear();
                    return;
                }

                if (!IsDuplicate(inputText, type))
                {
                    switch (type)
                    {
                        case "العَرَض":
                            symptomsList.Add(inputText);
                            AddChip(inputText, type, flowLayoutPanel3);
                            break;
                        case "الفحص":
                            testsList.Add(inputText);
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
            // التحقق من أن النص موجود في قائمة الإكمال التلقائي
            return textBox.AutoCompleteCustomSource.Contains(inputText);
        }

        private bool IsDuplicate(string inputText, string type)
        {
            switch (type)
            {
                case "العَرَض":
                    return symptomsList.Contains(inputText);
                case "الفحص":
                    return testsList.Contains(inputText);
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
                case "العَرَض":
                    return Color.DarkOrange;
                case "الفحص":
                    return Color.Teal;
                default:
                    return Color.Gray;
            }
        }

        private void RemoveFromList(string text, string type)
        {
            switch (type)
            {
                case "العَرَض":
                    symptomsList.Remove(text);
                    break;
                case "الفحص":
                    testsList.Remove(text);
                    break;
            }
        }
        private void InitializeAutoCompleteTextbox(Guna.UI2.WinForms.Guna2TextBox textBox, List<string> demoData)
        {
           
            var autoComplete = new AutoCompleteStringCollection();
            autoComplete.AddRange(demoData.ToArray());

            
            textBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            textBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
            textBox.AutoCompleteCustomSource = autoComplete;

            
            textBox.KeyDown += (sender, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                {
                    
                    if (!autoComplete.Contains(textBox.Text.Trim()))
                    {
                        MessageBox.Show("القيمة المدخلة غير موجودة في القائمة. الرجاء اختيار قيمة من الاقتراحات.", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBox.Clear();
                    }
                }
            };
        }
        private bool IsValidInputTextBox(Guna.UI2.WinForms.Guna2TextBox textBox, List<string> demoData)
        {
           
            return demoData.Contains(textBox.Text.Trim(), StringComparer.OrdinalIgnoreCase);
        }
        private void UpdateAutoCompleteData()
        {

            InitializeAutoCompleteTextbox(medicineNameTxt, demoMedicineNames);
            InitializeAutoCompleteTextbox(dosageTxt, demoDosages);
            InitializeAutoCompleteTextbox(MidTimeTxt, MidTimes);
            InitializeAutoCompleteTextbox(midDratxt, demoDurations);

        }

        private void addNewDaignosis_Load(object sender, EventArgs e)
        {
            UpdateAutoCompleteData();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

            if (IsValidInputTextBox(medicineNameTxt, demoMedicineNames) &&
               IsValidInputTextBox(dosageTxt, demoDosages) &&
                IsValidInputTextBox(MidTimeTxt, MidTimes) &&
                IsValidInputTextBox(midDratxt, demoDurations))
            {
              
                string medicineName = medicineNameTxt.Text.Trim();
                string dosage = dosageTxt.Text.Trim();
                string Time = MidTimeTxt.Text.Trim();
                string duration = midDratxt.Text.Trim();


                gunaDataGridView1.Rows.Add(medicineName, dosage,Time, duration);

                medicineNameTxt.Clear();
                dosageTxt.Clear();
                MidTimeTxt.Clear();
                midDratxt.Clear();

                MessageBox.Show("تم إضافة البيانات بنجاح إلى الجدول.", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("الرجاء إدخال قيمة صحيحة من القائمة المعروضة.", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        


        private void gunaDataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {

                selectedRowIndex = e.RowIndex;


                DataGridViewRow row = gunaDataGridView1.Rows[selectedRowIndex];


                medicineNameTxt.Text = row.Cells["medName"].Value.ToString();
                dosageTxt.Text = row.Cells["medDOS"].Value.ToString();
                MidTimeTxt.Text = row.Cells["MedTime"].Value.ToString();
                midDratxt.Text = row.Cells["midDra"].Value.ToString();
                midDratxt.Text = row.Cells.ToString();
            }
        }

        private void guna2Button2_Click_1(object sender, EventArgs e)
        {
            if (selectedRowIndex >= 0)
            {
              
                string updatedMedicineName = medicineNameTxt.Text.Trim();
                string updatedDosage = dosageTxt.Text.Trim();
                string updatedMidTime = MidTimeTxt.Text.Trim();
                string updatedDuration = midDratxt.Text.Trim();


                DataGridViewRow row = gunaDataGridView1.Rows[selectedRowIndex];
                row.Cells["medName"].Value = updatedMedicineName;
                row.Cells["medDOS"].Value = updatedDosage;
                row.Cells["MedTime"].Value = updatedMidTime;
                row.Cells["midDra"].Value = updatedDuration;


                medicineNameTxt.Clear();
                dosageTxt.Clear();
                MidTimeTxt.Clear();
                midDratxt.Clear();

                
                selectedRowIndex = -1;

                MessageBox.Show("تم تحديث البيانات بنجاح.", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("لم يتم اختيار صف للتعديل.", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {

        }
    }
    }



    
