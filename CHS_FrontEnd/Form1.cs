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
    public partial class Form1 : Form
    {
        private DockPanel dockPanel;
        public Form1(DockPanel dockPanel)
        {
            InitializeComponent();
            this.dockPanel = dockPanel;

            Viewdaig.Columns["diagnosisName"].Width = 150;
            Viewdaig.Columns["diagnosisDate"].Width = 120;
            Viewdaig.Columns["requiredTests"].Width = 200;
            Viewdaig.Columns["prescribedMedications"].Width = 200;
            Viewdaig.Columns["doctorName"].Width = 150;
            AddDemoData();
            CustomizeRowsAppearance();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
        private void AddDemoData()
        {
            // إضافة بعض السجلات التجريبية إلى DataGridView
            object[] row1 = new object[] { "دكتور محمد", "دواء A, دواء B", "فحص دم كامل", "2024-12-01", "حالة مرضية 1" };
            object[] row2 = new object[] { "دكتور أحمد", "دواء C, دواء D", "فحص صورة أشعة", "2024-12-05", "حالة مرضية 2" };
            object[] row3 = new object[] { "دكتور علي", "دواء E, دواء F", "فحص تخطيط قلب", "2024-12-10", "حالة مرضية 3" };

            // إضافة البيانات إلى DataGridView
            Viewdaig.Rows.Add(row1);
            Viewdaig.Rows.Add(row2);
            Viewdaig.Rows.Add(row3);
        }
        private void CustomizeRowsAppearance()
        {
            // تخصيص مظهر الصفوف عند التمرير
            Viewdaig.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray; // لون الصفوف المتبادلة
            Viewdaig.RowsDefaultCellStyle.BackColor = Color.White; // لون الصفوف العادية

            // تخصيص تأثير Hover
            Viewdaig.CellMouseEnter += (sender, e) =>
            {
                if (e.RowIndex >= 0)
                {
                    Viewdaig.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightBlue; 
                }
            };

            Viewdaig.CellMouseLeave += (sender, e) =>
            {
                if (e.RowIndex >= 0)
                {
                    Viewdaig.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White; 
                }
            };

            // تخصيص الحدود للصفوف
           

            // تخصيص خط البيانات
            Viewdaig.DefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Regular);
            Viewdaig.DefaultCellStyle.ForeColor = Color.Black; // لون النص
            Viewdaig.DefaultCellStyle.SelectionBackColor = Color.DarkBlue; // لون الخلفية عند التحديد
            Viewdaig.DefaultCellStyle.SelectionForeColor = Color.White; // لون النص عند التحديد

            // تخصيص رأس الجدول
            Viewdaig.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(77)))), ((int)(((byte)(146)))));
            Viewdaig.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            Viewdaig.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
         


         
        }
    }
}
