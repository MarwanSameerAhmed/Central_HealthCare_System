//using ClosedXML.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace CHS_FrontEnd.Pharmacy
{
    public partial class AddNewMedicines : Form
    {
        private string connectionString = "Server=.\\; Database=CHS_O; Integrated Security= True;";
        private DockPanel dockPanel;
        public AddNewMedicines(DockPanel dockPanel)
        {
            InitializeComponent();
            this.dockPanel = dockPanel;
            ConfigureComboBox();
            InitializeCategoryComboBox();
            activeIngredientsCategoryComboBox.SelectedIndexChanged += activeIngredientsCategoryComboBox_SelectedIndexChanged;
            activeIngredientsResultsComboBox.SelectedIndexChanged += activeIngredientsResultsComboBox_SelectedIndexChanged;

        }

        private void AddNewMedicines_Load(object sender, EventArgs e)
        {

        }

        // Dictionary to hold results for each category
        private Dictionary<string, List<string>> categoryResults = new Dictionary<string, List<string>>()
        {
            { "Small-Molecule Compounds", new List<string> { "Aspirin", "Ibuprofen", "Paracetamol" } },
            { "Biologic/Biotechnology-Derived Molecules", new List<string> { "Insulin", "Monoclonal Antibodies" } },
            { "Peptides", new List<string> { "Desmopressin", "Oxytocin" } },
            { "Analgesics (Pain Relievers)", new List<string> { "Acetaminophen", "Ibuprofen", "Morphine" } },
            { "Antibiotics (Antimicrobials)", new List<string> { "Penicillin", "Amoxicillin", "Cephalosporins" } },
            { "Antivirals", new List<string> { "Oseltamivir", "Acyclovir" } },
            { "Antifungals", new List<string> { "Fluconazole", "Amphotericin B" } },
            { "Antiparasitics", new List<string> { "Chloroquine", "Ivermectin" } },
            { "Antihypertensives", new List<string> { "ACE Inhibitors", "Beta-blockers" } },
            { "Antidiabetics", new List<string> { "Metformin", "Insulin" } },
            { "Anticancer (Oncologics)", new List<string> { "Doxorubicin", "Imatinib" } },
            { "Immunomodulators", new List<string> { "Corticosteroids", "TNF Inhibitors" } },
            { "Vaccines", new List<string> { "COVID-19 Vaccines", "Influenza Vaccines" } }
        };

        // Dosage Form Combo Box Initialisation
        private void ConfigureComboBox()
        {
            var genderList = new List<KeyValuePair<string, int>>
            {              new KeyValuePair<string, int>("Capsule", 0),
                new KeyValuePair<string, int>("Tablet", 1),
                new KeyValuePair<string, int>("Syrup", 2),
                new KeyValuePair<string, int>("Injection", 3),
                new KeyValuePair<string, int>("Inhaler", 4),
            };

            dosageFormComboBox.DataSource = genderList;
            dosageFormComboBox.DisplayMember = "Key";
            dosageFormComboBox.ValueMember = "Value";
        }

        private void InitializeCategoryComboBox()
        {
            // Clear existing items
            activeIngredientsResultsComboBox.Items.Clear();

            // Add categories to Guna2ComboBox
            foreach (var category in categoryResults.Keys)
            {
                activeIngredientsCategoryComboBox.Items.Add(category);
            }

            // Set the default selected item (optional)
            activeIngredientsCategoryComboBox.SelectedIndex = 0;
        }

        private void activeIngredientsCategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Get selected category
            string selectedCategory = activeIngredientsCategoryComboBox.SelectedItem.ToString();

            // Clear previous results in Results ComboBox
            activeIngredientsResultsComboBox.Items.Clear();

            // If the selected category exists in the dictionary, add its results
            if (categoryResults.ContainsKey(selectedCategory))
            {
                foreach (var result in categoryResults[selectedCategory])
                {
                    activeIngredientsResultsComboBox.Items.Add(result);
                }
            }
        }


        private void activeIngredientsResultsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Check if an item is actually selected
            if (activeIngredientsResultsComboBox.SelectedItem == null)
            {
                return; // Exit the method if nothing is selected
            }

            // Get selected item safely
            string selectedItem = activeIngredientsResultsComboBox.SelectedItem.ToString();

            // Check if the item is already selected
            foreach (Control ctrl in activeIngredientsFlowLayoutPanel.Controls)
            {
                if (ctrl is Label label && label.Text == selectedItem)
                {
                    MessageBox.Show("Item already selected.");
                    return;
                }
            }

            // Create a Label as a "Tag" or "Chip"
            Label tagLabel = new Label
            {
                Text = selectedItem,
                AutoSize = true,
                Padding = new Padding(5),
                Margin = new Padding(3),
                BackColor = Color.LightBlue,
                ForeColor = Color.Black,
                BorderStyle = BorderStyle.FixedSingle,
                Cursor = Cursors.Hand
            };

            // Add click event to remove the tag
            tagLabel.Click += (s, args) =>
            {
                activeIngredientsFlowLayoutPanel.Controls.Remove(tagLabel);
            };

            // Add the tag to the FlowLayoutPanel
            activeIngredientsFlowLayoutPanel.Controls.Add(tagLabel);

            // Clear the ComboBox selection after adding the tag
            activeIngredientsResultsComboBox.SelectedIndex = -1;
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Excel Files|*.xlsx;*.xls",
                Title = "Select an Excel File"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;

                try
                {
                    ImportFromExcel(filePath);
                    MessageBox.Show("Data imported successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error importing data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ImportFromExcel(string filePath)
        {
            //using (var workbook = new XLWorkbook(filePath))
            //{
            //    var worksheet = workbook.Worksheet("Medicine Data");  // Use the sheet name from the Excel file
            //    var rows = worksheet.RangeUsed().RowsUsed().Skip(1);  // Skip header row

            //    using (var connection = new SqlConnection(connectionString))
            //    {
            //        connection.Open();

            //        foreach (var row in rows)
            //        {
            //            string medicineName = row.Cell(1).GetValue<string>().Trim();
            //            string medicineNumber = row.Cell(2).GetValue<string>().Trim();
            //            string dosageForm = row.Cell(3).GetValue<string>().Trim();
            //            string activeIngredients = row.Cell(4).GetValue<string>().Trim();

            //            // Skip row if any field is empty
            //            if (string.IsNullOrEmpty(medicineName) ||
            //                string.IsNullOrEmpty(medicineNumber) ||
            //                string.IsNullOrEmpty(dosageForm) ||
            //                string.IsNullOrEmpty(activeIngredients))
            //            {
            //                continue; // Skip this row
            //            }

            //            // Insert data into the database
            //            string insertQuery = @"
            //            INSERT INTO medicines_table (medicineName, medicineNumber, dosageForm, activeIngredients)
            //            VALUES (@MedicineName, @MedicineNumber, @DosageForm, @ActiveIngredients)";
            //            using (SqlCommand command = new SqlCommand(insertQuery, connection))
            //            {
            //                command.Parameters.AddWithValue("@MedicineName", medicineName);
            //                command.Parameters.AddWithValue("@MedicineNumber", medicineNumber);
            //                command.Parameters.AddWithValue("@DosageForm", dosageForm);
            //                command.Parameters.AddWithValue("@ActiveIngredients", activeIngredients);
            //                int i = command.ExecuteNonQuery();
            //            }
            //        }
            //    }
            //}
        }

        private void createBtn_Click(object sender, EventArgs e)
        {

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.ShowDialog();

            ImportFromExcel(openFileDialog.FileName);
        }
    }
}
