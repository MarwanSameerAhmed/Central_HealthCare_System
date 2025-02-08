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
    public partial class searchPlacemenet : Form
    {
        public searchPlacemenet(DockPanel dockPanel)
        {
            InitializeComponent();


            guna2VScrollBar1.ValueChanged += guna2VScrollBar1_ValueChanged;
            guna2VScrollBar1.Maximum = searchFacilityView.RowCount - 1;
            guna2VScrollBar1.Minimum = 0;
            guna2VScrollBar1.Value = 0;
            searchFacilityView.MouseWheel += dataGridView1_MouseWheel;
            searchFacilityView.Rows.Add("مستشفى الأمل", "تعليمي", "الرياض - شارع الملك فهد", "info@alamalhospital.sa");
            searchFacilityView.Rows.Add("مستشفى المستقبل", "خاص", "جدة - حي النعيم", "contact@almustaqbalhospital.com");
            searchFacilityView.Rows.Add("مستشفى الصحة العامة", "حكومي", "مكة المكرمة - طريق الحرم", "publichealth@moh.gov.sa");
            searchFacilityView.Rows.Add("مستشفى النور", "تعليمي", "الدمام - حي الفيصلية", "info@alnoorhospital.edu.sa");
            searchFacilityView.Rows.Add("مستشفى البركة", "خاص", "الخبر - شارع الأمير تركي", "info@albarakahospital.com");
            searchFacilityView.Rows.Add("مستشفى الأمل", "تعليمي", "الرياض - شارع الملك فهد", "info@alamalhospital.sa");
            searchFacilityView.Rows.Add("مستشفى المستقبل", "خاص", "جدة - حي النعيم", "contact@almustaqbalhospital.com");
            searchFacilityView.Rows.Add("مستشفى الصحة العامة", "حكومي", "مكة المكرمة - طريق الحرم", "publichealth@moh.gov.sa");
            searchFacilityView.Rows.Add("مستشفى النور", "تعليمي", "الدمام - حي الفيصلية", "info@alnoorhospital.edu.sa");
            searchFacilityView.Rows.Add("مستشفى البركة", "خاص", "الخبر - شارع الأمير تركي", "info@albarakahospital.com");
            searchFacilityView.Rows.Add("مستشفى الأمل", "تعليمي", "الرياض - شارع الملك فهد", "info@alamalhospital.sa");
            searchFacilityView.Rows.Add("مستشفى المستقبل", "خاص", "جدة - حي النعيم", "contact@almustaqbalhospital.com");
            searchFacilityView.Rows.Add("مستشفى الصحة العامة", "حكومي", "مكة المكرمة - طريق الحرم", "publichealth@moh.gov.sa");
            searchFacilityView.Rows.Add("مستشفى النور", "تعليمي", "الدمام - حي الفيصلية", "info@alnoorhospital.edu.sa");
            searchFacilityView.Rows.Add("مستشفى البركة", "خاص", "الخبر - شارع الأمير تركي", "info@albarakahospital.com");
            UpdateScrollBar();
        }
        private void dataGridView1_MouseWheel(object sender, MouseEventArgs e)
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
        private void guna2VScrollBar1_ValueChanged(object sender, EventArgs e)
        {

            if (guna2VScrollBar1.Value < 0)
                guna2VScrollBar1.Value = 0;
            else if (guna2VScrollBar1.Value > guna2VScrollBar1.Maximum)
                guna2VScrollBar1.Value = guna2VScrollBar1.Maximum;


            if (searchFacilityView.RowCount > 0)
            {

                int rowIndex = guna2VScrollBar1.Value;
                if (rowIndex >= searchFacilityView.RowCount)
                    rowIndex = searchFacilityView.RowCount - 1;

                searchFacilityView.FirstDisplayedScrollingRowIndex = rowIndex;
            }
        }
        private void UpdateScrollBar()
        {
            int totalRows = searchFacilityView.RowCount;


            guna2VScrollBar1.Maximum = totalRows - 1;


            guna2VScrollBar1.LargeChange = totalRows / 3;
            guna2VScrollBar1.SmallChange = 1;
        }
      
        private void searchFacilityView_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {

                FacilityViewrFrm detailsForm = new FacilityViewrFrm();
                detailsForm.Show();
            }
        }
    }
}
