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
    public partial class PatientFileView : Form
    {
        private DockPanel dockPanel;
        public PatientFileView(DockPanel dockPanel)
        {
            InitializeComponent();
            this.dockPanel = dockPanel;
          
            CustomizeRowsAppearance();
         
            this.AutoScrollPosition = new Point(0, 0);
            foreach (DataGridViewRow row in Viewdaig.Rows)
            {
                var buttonCell = row.Cells["edit"] as DataGridViewButtonCell;
                if (buttonCell != null)
                {
                    buttonCell.Style.BackColor = Color.FromArgb(1, 87, 155);
                    buttonCell.Style.ForeColor = Color.White;// تغيير لون الخلفية هنا
                }
            }
          
        }

      
      
        private void CustomizeRowsAppearance()
        {
            
            Viewdaig.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray; 
            Viewdaig.RowsDefaultCellStyle.BackColor = Color.White; 
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

            Viewdaig.DefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            Viewdaig.DefaultCellStyle.ForeColor = Color.Black; 
            Viewdaig.DefaultCellStyle.SelectionForeColor = Color.Black; 
           
            Viewdaig.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            Viewdaig.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
         


         
        }
        private void PopulatePatientCardData()
        {
            
            string fullName = "علي محمد علي صالح المرجاني";
            string age = "35";
            string birthDate = "1989-04-25";
            string city = "ذمار";
            string maritalStatus = "متزوج";
            string phoneNumber = "01234567890";
            string bloodType = "O+";

           
            veiwtNamelbl.Text = fullName; 
            viewAgelbl.Text = age; 
            veiwBirthDaylbl.Text = birthDate;
            viewStatelbl.Text = city; 
            viewCumlbl.Text = maritalStatus; 
            viewPhonelbl.Text = phoneNumber; 
            viewbloodlbl.Text = bloodType; 

            string allergies = "غبار, فول سوداني, سمك";
            alg.Text = allergies;
            string medications = "دواء A, دواء B, دواء C";
            medlbl.Text = medications;
            string chronicDiseases = "سكري, ضغط دم مرتفع, كوليسترول";
            dislbl.Text = chronicDiseases; 
          

           
        }


        private void guna2VScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            Viewdaig.FirstDisplayedScrollingRowIndex = guna2VScrollBar1.Value;
        }
        private void UpdateScrollBar()
        {
            if (Viewdaig.RowCount > 0)
            {
                guna2VScrollBar1.Maximum = Viewdaig.RowCount - 1;
                guna2VScrollBar1.LargeChange = Viewdaig.DisplayedRowCount(false);
                guna2VScrollBar1.SmallChange = 1;


                if (guna2VScrollBar1.Value > guna2VScrollBar1.Maximum)
                {
                    guna2VScrollBar1.Value = guna2VScrollBar1.Maximum;
                }
            }
            else
            {
                guna2VScrollBar1.Maximum = 0;
                guna2VScrollBar1.LargeChange = 0;
                guna2VScrollBar1.SmallChange = 0;
            }
        }


        private void RemoveData()
        {
            if (Viewdaig.Rows.Count > 0)
            {
                Viewdaig.Rows.RemoveAt(0);
                UpdateScrollBar();
            }
        }
        private void Viewdaig_MouseWheel(object sender, MouseEventArgs e)
        {
            if (Viewdaig.RowCount > 0)
            {
                int scrollAmount = e.Delta > 0 ? -1 : 1;
                int newValue = guna2VScrollBar1.Value + scrollAmount;

                if (newValue >= guna2VScrollBar1.Minimum && newValue <= guna2VScrollBar1.Maximum)
                {
                    guna2VScrollBar1.Value = newValue;
                    Viewdaig.FirstDisplayedScrollingRowIndex = guna2VScrollBar1.Value;
                }
            }
        }



        private void AddDemoData()
        {
            Viewdaig.Rows.Add("حالة مرضية 1", "2024-12-01", "فحص دم كامل", "دواء A, دواء B", "دكتور أحمد");
            Viewdaig.Rows.Add("حالة مرضية 2", "2024-11-15", "فحص بول", "دواء C", "دكتور محمد");
            Viewdaig.Rows.Add("حالة مرضية 3", "2024-10-10", "أشعة سينية", "دواء D, دواء E", "دكتورة ليلى");
            Viewdaig.Rows.Add("حالة مرضية 1", "2024-12-01", "فحص دم كامل", "دواء A, دواء B", "دكتور أحمد");
            Viewdaig.Rows.Add("حالة مرضية 2", "2024-11-15", "فحص بول", "دواء C", "دكتور محمد");
            Viewdaig.Rows.Add("حالة مرضية 3", "2024-10-10", "أشعة سينية", "دواء D, دواء E", "دكتورة ليلى");



        }

        private void Form1_Load(object sender, EventArgs e)
        {
         
            Viewdaig.MouseWheel += Viewdaig_MouseWheel;
            PopulatePatientCardData();
            AddDemoData();
            UpdateScrollBar();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            addNewDaignosis newform = new addNewDaignosis();
            newform.StartPosition = FormStartPosition.CenterScreen;
            newform.Show();
            
        }
    }
}


