using CHS.Client.API;
using CHS.Client.API.Helper_Classes;
using CHS.Client.API.Models;
using CHS.Client.API.Models.PatientsDiagnosis;
using CHS.Client.API.Models.Pharmacies;
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

namespace CHS_FrontEnd.Pharmacy
{
    public partial class PharmacyMainFrm : Form
    {
        private DockPanel dockPanel;

        public PharmacyMainFrm(DockPanel dockPanel)
        {
            InitializeComponent();
            this.dockPanel = dockPanel;
            guna2VScrollBar1.Scroll += Guna2VScrollBar1_Scroll;
        }

        private void PharmacyMainFrm_Load(object sender, EventArgs e)
        {
            SyncScrollbar();
            //PopulateData();
            medicineStateGridView.MouseWheel += medicineStateGridView_MouseWheel;
        }

        private void PopulateData()
        {
            medicineStateGridView.Rows.Add(false, "3", "01/02/2025", "Aspirin", "Tablet", "Esperin", "1");
            medicineStateGridView.Rows.Add(false, "5", "15/03/2025", "Paracetamol", "Tablet", "Panadol", "2");
            medicineStateGridView.Rows.Add(true, "2", "20/04/2025", "Ibuprofen", "Capsule", "Brufen", "3");
            medicineStateGridView.Rows.Add(false, "1", "10/05/2025", "Amoxicillin", "Capsule", "Amoxil", "4");
            medicineStateGridView.Rows.Add(true, "4", "25/06/2025", "Dextromethorphan", "Syrup", "Cough Syrup", "5");
            medicineStateGridView.Rows.Add(false, "6", "05/07/2025", "Vitamin C", "Tablet", "C-Vit", "6");
            medicineStateGridView.Rows.Add(false, "3", "12/08/2025", "Ciprofloxacin", "Tablet", "Cipro", "7");
            medicineStateGridView.Rows.Add(true, "7", "18/09/2025", "Morphine", "Injection", "Painkiller", "8");
            medicineStateGridView.Rows.Add(false, "2", "22/10/2025", "Loratadine", "Tablet", "Allergy Pills", "9");
            medicineStateGridView.Rows.Add(true, "5", "30/11/2025", "Insulin", "Injection", "Insulin", "10");
            medicineStateGridView.Rows.Add(false, "4", "15/12/2025", "Guaifenesin", "Syrup", "Cough Suppressant", "11");
            medicineStateGridView.Rows.Add(false, "8", "02/01/2025", "Azithromycin", "Tablet", "Zithromax", "12");
            medicineStateGridView.Rows.Add(true, "6", "10/01/2025", "Metformin", "Tablet", "Glucophage", "13");
            medicineStateGridView.Rows.Add(false, "5", "15/02/2025", "Omeprazole", "Capsule", "Losec", "14");
            medicineStateGridView.Rows.Add(true, "3", "28/02/2025", "Cetirizine", "Tablet", "Zyrtec", "15");
            medicineStateGridView.Rows.Add(false, "2", "07/03/2025", "Salbutamol", "Inhaler", "Ventolin", "16");
            medicineStateGridView.Rows.Add(false, "4", "13/04/2025", "Atorvastatin", "Tablet", "Lipitor", "17");
            medicineStateGridView.Rows.Add(true, "3", "21/04/2025", "Clopidogrel", "Tablet", "Plavix", "18");
            medicineStateGridView.Rows.Add(false, "9", "30/04/2025", "Hydrochlorothiazide", "Tablet", "Microzide", "19");
            medicineStateGridView.Rows.Add(false, "7", "06/05/2025", "Warfarin", "Tablet", "Coumadin", "20");
            medicineStateGridView.Rows.Add(true, "5", "15/06/2025", "Prednisone", "Tablet", "Deltasone", "21");
            medicineStateGridView.Rows.Add(false, "3", "27/06/2025", "Losartan", "Tablet", "Cozaar", "22");
            medicineStateGridView.Rows.Add(false, "4", "08/07/2025", "Furosemide", "Tablet", "Lasix", "23");
            medicineStateGridView.Rows.Add(true, "2", "14/08/2025", "Metoprolol", "Tablet", "Lopressor", "24");
            medicineStateGridView.Rows.Add(false, "6", "25/08/2025", "Ranitidine", "Tablet", "Zantac", "25");
            medicineStateGridView.Rows.Add(false, "7", "02/09/2025", "Doxycycline", "Capsule", "Vibramycin", "26");
            medicineStateGridView.Rows.Add(true, "8", "18/09/2025", "Amlodipine", "Tablet", "Norvasc", "27");
            medicineStateGridView.Rows.Add(false, "4", "28/09/2025", "Fluoxetine", "Capsule", "Prozac", "28");
            medicineStateGridView.Rows.Add(false, "5", "05/10/2025", "Alprazolam", "Tablet", "Xanax", "29");
            medicineStateGridView.Rows.Add(true, "3", "15/10/2025", "Diazepam", "Tablet", "Valium", "30");




            SyncScrollbar();
        }
            private void medicineStateGridView_MouseWheel(object sender, MouseEventArgs e)
        {
            // Adjust the scrollbar value based on the mouse wheel delta
            int newValue = guna2VScrollBar1.Value - (e.Delta / SystemInformation.MouseWheelScrollDelta) * guna2VScrollBar1.SmallChange;
            guna2VScrollBar1.Value = Math.Max(guna2VScrollBar1.Minimum, Math.Min(guna2VScrollBar1.Maximum, newValue));

            // Update the DataGridView's displayed row
            medicineStateGridView.FirstDisplayedScrollingRowIndex = guna2VScrollBar1.Value;
        }

        private void SyncScrollbar()
        {
            int totalRows = medicineStateGridView.Rows.Count;
            int displayedRows = medicineStateGridView.DisplayedRowCount(true);

            if (totalRows > 0 && displayedRows > 0)
            {
                guna2VScrollBar1.Minimum = 0;
                guna2VScrollBar1.Maximum = totalRows - 1;
                guna2VScrollBar1.LargeChange = displayedRows; // Number of rows visible at once
                guna2VScrollBar1.SmallChange = 1; // Scroll one row at a time
                guna2VScrollBar1.Enabled = totalRows > displayedRows;
            }
            else
            {
                // Disable the scrollbar if there's nothing to scroll
                guna2VScrollBar1.Enabled = false;
            }
        }

        private void Guna2VScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            try
            {
                medicineStateGridView.FirstDisplayedScrollingRowIndex = Math.Max(0, e.NewValue);
            }
            catch (Exception ex)
            {
                // Handle out of range exceptions (when there are no rows)
                Console.WriteLine($"Scroll error: {ex.Message}");
            }
        }
        private void medicineStateGridView_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            // Ensure a valid row is clicked (not the header row)
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Get the exchangeStatus cell in the clicked row
                DataGridViewCell exchangeStatusCell = medicineStateGridView.Rows[e.RowIndex].Cells["exchangeStatus"];

                // Ensure the cell exists and is of type checkbox
                if (exchangeStatusCell != null && exchangeStatusCell is DataGridViewCheckBoxCell)
                {
                    // Get the current checkbox value
                    bool isChecked = Convert.ToBoolean(exchangeStatusCell.Value);

                    if (!isChecked) // If the checkbox is false
                    {
                        DialogResult result = MessageBox.Show("هل تود أن تقوم بصرف الدواء؟",
                                                              "تأكيد",
                                                              MessageBoxButtons.YesNo,
                                                              MessageBoxIcon.Question);

                        if (result == DialogResult.Yes)
                        {
                            // Update the checkbox value to true
                            exchangeStatusCell.Value = true;
                        }
                    }
                    else
                    {
                        // If already checked, show a message
                        MessageBox.Show("لقد تم صرف الدواء بالفعل", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void setTranslation()
        {
            
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            try
            {
                medicineStateGridView.Rows.Clear();
                GetPatientsDiagnosisMedicinesRequest request = new GetPatientsDiagnosisMedicinesRequest
                {
                    RequestID = Guid.NewGuid().ToString(),
                    PatientDiagnosisNumber = long.Parse(midSearchtxt.Text)
                };
                GetPatientsDiagnosisMedicinesResponse response = RequestSender.SendRequest<GetPatientsDiagnosisMedicinesRequest, GetPatientsDiagnosisMedicinesResponse>(request);
                if (response.ResponseCode != "1")
                {
                    MessageBox.Show(response.MessageDescription);
                    return;
                }
                searchBtn.Enabled = false;
                btnSave.Enabled = true;
                foreach (var md in response.Medicines)
                {
                    Medicine medicine = Cache.Medicines.FirstOrDefault(m => m.ID == md.MedicineID);
                    if (medicine is default(Medicine))
                    {
                        MessageBox.Show("Erorr");
                        return;
                    }
                    int index = medicineStateGridView.Rows.Add(md.Dispensed, md.DoseTime, md.PeriodUse, md.Dose, medicine.DosageFom, medicine.ActiveIngredients, medicine.Name, md.MedicineID);
                    medicineStateGridView.Rows[index].Tag = md;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            List<MedicineDose> medicineDoses = new List<MedicineDose>();
            foreach (DataGridViewRow row in medicineStateGridView.Rows)
            {
                MedicineDose md = (MedicineDose)row.Tag;
                if (md.Dispensed) continue;
                if (!(bool)row.Cells["exchangeStatus"].Value) continue;
                medicineDoses.Add(md);
            }
            if (medicineDoses.Count == 0)
            {
                MessageBox.Show("لم يتم صرف ادوية");
                return;
            }

            DispensedMedicinesRequest request = new DispensedMedicinesRequest
            {
                PatientDiagnosisNumber = long.Parse(midSearchtxt.Text),
                MedicineDoseIDs = medicineDoses.Select(md => md.ID).ToList(),
                RequestID = Guid.NewGuid().ToString()
            };

            CHSResponse response = RequestSender.SendRequest<DispensedMedicinesRequest, CHSResponse>(request);
            MessageBox.Show(response.MessageDescription);
        }

        private void midSearchtxt_TextChanged(object sender, EventArgs e)
        {
            searchBtn.Enabled = true;
            btnSave.Enabled = false;
            medicineStateGridView.Rows.Clear();
        }
    }
}
