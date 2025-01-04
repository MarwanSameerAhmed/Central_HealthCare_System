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
        public addNewDaignosis()
        {
            InitializeComponent();
        }



        private void SetupDataGridView()
        {
            // إعداد الأعمدة
            gunaDataGridView1.Columns.Clear();

            gunaDataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "DrugId", HeaderText = "رقم الدواء" });
            gunaDataGridView1.Columns.Add(new DataGridViewComboBoxColumn() { Name = "DrugName", HeaderText = "اسم الدواء" });
            gunaDataGridView1.Columns.Add(new DataGridViewComboBoxColumn() { Name = "Dosage", HeaderText = "الجرعة" });
            gunaDataGridView1.Columns.Add(new DataGridViewComboBoxColumn() { Name = "Time", HeaderText = "وقت الجرعة" });
            gunaDataGridView1.Columns.Add(new DataGridViewComboBoxColumn() { Name = "Period", HeaderText = "الفترة" });

            // إعداد عمود التعديل
            DataGridViewButtonColumn editButtonColumn = new DataGridViewButtonColumn
            {
                Name = "Edit",
                HeaderText = "",
                Text = "تعديل",
                UseColumnTextForButtonValue = true,
                FlatStyle = FlatStyle.Flat,
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    BackColor = System.Drawing.Color.LightGray,
                    ForeColor = System.Drawing.Color.Black,
                    Alignment = DataGridViewContentAlignment.MiddleCenter,
                    Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold),
                },
                Width = 60 
            };
            gunaDataGridView1.Columns.Add(editButtonColumn);

            // إعداد عمود الحذف
            DataGridViewButtonColumn deleteButtonColumn = new DataGridViewButtonColumn
            {
                Name = "Delete",
                HeaderText = "",
                Text = "حذف",
                UseColumnTextForButtonValue = true,
                FlatStyle = FlatStyle.Flat,
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    BackColor = System.Drawing.Color.LightGray,
                    ForeColor = System.Drawing.Color.Black,
                    Alignment = DataGridViewContentAlignment.MiddleCenter,
                    Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold), 
                },
                Width = 60 // عرض العمود
            };
            gunaDataGridView1.Columns.Add(deleteButtonColumn);
            
            gunaDataGridView1.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular);
            gunaDataGridView1.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            gunaDataGridView1.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            gunaDataGridView1.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.LightBlue;
            gunaDataGridView1.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            gunaDataGridView1.RowTemplate.Height = 30;
            gunaDataGridView1.AlternatingRowsDefaultCellStyle = gunaDataGridView1.DefaultCellStyle;
          
            gunaDataGridView1.EditingControlShowing += gunaDataGridView1_EditingControlShowing;
            gunaDataGridView1.CellClick += gunaDataGridView1_CellClick;
            gunaDataGridView1.RowValidating += gunaDataGridView1_RowValidating;
        }


        // إعداد DataSource للأعمدة
        private void SetupComboBoxData()
        {

            var drugNames = new List<string> { "Paracetamol", "Ibuprofen", "Aspirin" };
            var dosages = new List<string> { "5mg", "10mg", "15mg", "20mg" };
            var times = new List<string> { "صباحًا", "ظهرًا", "مساءً" };
            var periods = new List<string> { "3 أيام", "5 أيام", "7 أيام", "شهر" };

            (gunaDataGridView1.Columns["DrugName"] as DataGridViewComboBoxColumn).DataSource = drugNames;
            (gunaDataGridView1.Columns["Dosage"] as DataGridViewComboBoxColumn).DataSource = dosages;
            (gunaDataGridView1.Columns["Time"] as DataGridViewComboBoxColumn).DataSource = times;
            (gunaDataGridView1.Columns["Period"] as DataGridViewComboBoxColumn).DataSource = periods;
        }


        private void AddInitialEmptyRow()
        {

            gunaDataGridView1.Rows.Add();
        }

        private void AddNewRowIfNeeded()
        {

            DataGridViewRow lastRow = gunaDataGridView1.Rows[gunaDataGridView1.Rows.Count - 1];
            if (lastRow.Cells["DrugId"].Value != null && lastRow.Cells["DrugName"].Value != null &&
                lastRow.Cells["Dosage"].Value != null && lastRow.Cells["Time"].Value != null &&
                lastRow.Cells["Period"].Value != null)
            {
               
                gunaDataGridView1.Rows.Add();
            }
        }


        private void Form3_Load(object sender, EventArgs e)
        {
            gunaDataGridView1.EditMode = DataGridViewEditMode.EditOnKeystrokeOrF2;
            SetupDataGridView();
            SetupComboBoxData();
            AddInitialEmptyRow();

        }

        private void gunaDataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                var clickedColumn = gunaDataGridView1.Columns[e.ColumnIndex].Name;
                var currentRow = gunaDataGridView1.Rows[e.RowIndex];

                if (clickedColumn == "Edit")
                {
                    foreach (DataGridViewCell cell in currentRow.Cells)
                    {
                        if (gunaDataGridView1.Columns[cell.ColumnIndex].Name != "Edit" &&
                            gunaDataGridView1.Columns[cell.ColumnIndex].Name != "Delete")
                        {
                            cell.ReadOnly = false; 
                        }
                    }
                    MessageBox.Show($"الآن يمكنك تعديل الصف رقم {e.RowIndex + 1}.", "تعديل", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (clickedColumn == "Delete")
                {
                   
                    var confirmResult = MessageBox.Show("هل أنت متأكد من حذف هذا الصف؟", "تأكيد الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (confirmResult == DialogResult.Yes)
                    {
                        gunaDataGridView1.Rows.RemoveAt(e.RowIndex);
                    }
                }
            }
        }
        private void gunaDataGridView1_CellValueChanged_1(object sender, DataGridViewCellEventArgs e)
        {
            AddNewRowIfNeeded();
        }

        private void gunaDataGridView1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (gunaDataGridView1.CurrentCell.OwningColumn is DataGridViewComboBoxColumn)
            {
                ComboBox comboBox = e.Control as ComboBox;
                if (comboBox != null)
                {

                    comboBox.DropDownStyle = ComboBoxStyle.DropDown;
                    comboBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                    comboBox.AutoCompleteSource = AutoCompleteSource.ListItems;


                    comboBox.KeyDown -= ComboBox_KeyDown;
                    comboBox.KeyDown += ComboBox_KeyDown;
                }
            }
        }

        private void ComboBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                gunaDataGridView1.EndEdit();
                e.Handled = true;
            }
        }


        private void gunaDataGridView1_RowValidating(object sender, DataGridViewCellCancelEventArgs e)
        {


            DataGridViewRow row = gunaDataGridView1.Rows[e.RowIndex];

         
            if (row.IsNewRow) return;

          
            bool isRowFullyFilled = true;
            foreach (DataGridViewCell cell in row.Cells)
            {
                if (cell.ColumnIndex < 5 && (cell.Value == null || string.IsNullOrWhiteSpace(cell.Value.ToString())))
                {
                    isRowFullyFilled = false;
                    break;
                }
            }

            if (!isRowFullyFilled)
            {
                MessageBox.Show("يرجى إكمال جميع الحقول المطلوبة قبل المتابعة.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Cancel = true;
                return;
            }

          
            if (!e.Cancel)
            {
                row.Cells["Edit"].Style.BackColor = System.Drawing.Color.LightGreen;
                row.Cells["Edit"].Style.ForeColor = System.Drawing.Color.White;

                row.Cells["Delete"].Style.BackColor = System.Drawing.Color.Red;
                row.Cells["Delete"].Style.ForeColor = System.Drawing.Color.White;
            }
        }
    }
    }
