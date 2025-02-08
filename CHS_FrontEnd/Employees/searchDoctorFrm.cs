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
    public partial class searchDoctor : Form
    {
        public searchDoctor(DockPanel dockPanel)
        {
            InitializeComponent();
        }

        private void LoadDemoData()
        {
            
            // إضافة البيانات (ديمو)
            searchDoctorView.Rows.Add("د. أحمد عبد الله", "0551234567", "طبيب قلب", "01/01/2020");
            searchDoctorView.Rows.Add("د. سارة علي", "0569876543", "طبيبة أطفال", "15/03/2021");
            searchDoctorView.Rows.Add("د. خالد محمد", "0542233445", "جراح عام", "10/07/2018");
            searchDoctorView.Rows.Add("د. ليلى إبراهيم", "0501122334", "أمراض جلدية", "22/09/2019");
            searchDoctorView.Rows.Add("د. يوسف العبد", "0533322110", "جراحة عظام", "05/11/2022");
            searchDoctorView.Rows.Add("د. يوسف العبد", "0533322110", "جراحة عظام", "05/11/2022");
            searchDoctorView.Rows.Add("د. ليلى إبراهيم", "0501122334", "أمراض جلدية", "22/09/2019");
            searchDoctorView.Rows.Add("د. أحمد عبد الله", "0551234567", "طبيب قلب", "01/01/2020");
            searchDoctorView.Rows.Add("د. أحمد عبد الله", "0551234567", "طبيب قلب", "01/01/2020");
            searchDoctorView.Rows.Add("د. سارة علي", "0569876543", "طبيبة أطفال", "15/03/2021");
            searchDoctorView.Rows.Add("د. خالد محمد", "0542233445", "جراح عام", "10/07/2018");
            searchDoctorView.Rows.Add("د. ليلى إبراهيم", "0501122334", "أمراض جلدية", "22/09/2019");
            searchDoctorView.Rows.Add("د. يوسف العبد", "0533322110", "جراحة عظام", "05/11/2022");
            searchDoctorView.Rows.Add("د. يوسف العبد", "0533322110", "جراحة عظام", "05/11/2022");
            searchDoctorView.Rows.Add("د. ليلى إبراهيم", "0501122334", "أمراض جلدية", "22/09/2019");
            searchDoctorView.Rows.Add("د. أحمد عبد الله", "0551234567", "طبيب قلب", "01/01/2020");
            searchDoctorView.Rows.Add("د. أحمد عبد الله", "0551234567", "طبيب قلب", "01/01/2020");
            searchDoctorView.Rows.Add("د. سارة علي", "0569876543", "طبيبة أطفال", "15/03/2021");
            searchDoctorView.Rows.Add("د. خالد محمد", "0542233445", "جراح عام", "10/07/2018");
            searchDoctorView.Rows.Add("د. ليلى إبراهيم", "0501122334", "أمراض جلدية", "22/09/2019");
            searchDoctorView.Rows.Add("د. يوسف العبد", "0533322110", "جراحة عظام", "05/11/2022");
            searchDoctorView.Rows.Add("د. يوسف العبد", "0533322110", "جراحة عظام", "05/11/2022");
            searchDoctorView.Rows.Add("د. ليلى إبراهيم", "0501122334", "أمراض جلدية", "22/09/2019");
            searchDoctorView.Rows.Add("د. أحمد عبد الله", "0551234567", "طبيب قلب", "01/01/2020");
        }

        private void guna2VScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void searchDoctor_Load(object sender, EventArgs e)
        {
            guna2VScrollBar1.ValueChanged += searchDoctorView_ValueChanged;
            guna2VScrollBar1.Maximum = searchDoctorView.RowCount - 1;
            guna2VScrollBar1.Minimum = 0;
            guna2VScrollBar1.Value = 0;
            searchDoctorView.MouseWheel += searchDoctorView_MouseWheel;
            LoadDemoData();
            UpdateScrollBar();

        }
        private void searchDoctorView_ValueChanged(object sender, EventArgs e)
        {

            if (guna2VScrollBar1.Value < 0)
                guna2VScrollBar1.Value = 0;
            else if (guna2VScrollBar1.Value > guna2VScrollBar1.Maximum)
                guna2VScrollBar1.Value = guna2VScrollBar1.Maximum;


            if (searchDoctorView.RowCount > 0)
            {

                int rowIndex = guna2VScrollBar1.Value;
                if (rowIndex >= searchDoctorView.RowCount)
                    rowIndex = searchDoctorView.RowCount - 1;

                searchDoctorView.FirstDisplayedScrollingRowIndex = rowIndex;
            }
        }
        private void UpdateScrollBar()
        {
            int totalRows = searchDoctorView.RowCount;


            guna2VScrollBar1.Maximum = totalRows - 1;


            guna2VScrollBar1.LargeChange = totalRows / 3;
            guna2VScrollBar1.SmallChange = 1;
        }
        private void searchDoctorView_MouseWheel(object sender, MouseEventArgs e)
        {

            if (e.Delta > 0)
            {

                if (guna2VScrollBar1.Value > 0)
                {
                    guna2VScrollBar1.Value -= 1;
                }
            }
            else if (e.Delta < 0)
            {

                if (guna2VScrollBar1.Value < guna2VScrollBar1.Maximum)
                {
                    guna2VScrollBar1.Value += 1;
                }
            }
        }

        private void searchDoctorView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                DoctorViewrFrmcs detailsForm = new DoctorViewrFrmcs();
                detailsForm.Show();
            }
        }
    }
    }

