using CHS.Client.API.Models.Patients;
using CHS.Client.API;
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
using CHS.Client.API.Models.Employees;


namespace CHS_FrontEnd
{
    public partial class employeeSearchFrm : Form
    {
        private DockPanel dockPanel;
        public employeeSearchFrm(DockPanel dockPanel)
        {
            InitializeComponent();
            this.dockPanel = dockPanel;
        }

        private void employeeSearchFrm_Load(object sender, EventArgs e)
        {
            guna2VScrollBar1.ValueChanged += searchEmpView_ValueChanged;
            guna2VScrollBar1.Maximum = searchEmpView.RowCount - 1;
            guna2VScrollBar1.Minimum = 0;
            guna2VScrollBar1.Value = 0;
            searchEmpView.MouseWheel += searchEmpView_MouseWheel;
            empNametxt.TextChanged += SearchFields_TextChanged;
            empEmployeeIDtxt.TextChanged += SearchFields_TextChanged;
            empPhoneSearchtxt.TextChanged += SearchFields_TextChanged;
            ApplyEventsToTextBoxes(guna2ContainerControl1);
            UpdateScrollBar();
           

        }


        private void searchEmpView_ValueChanged(object sender, EventArgs e)
        {

            if (guna2VScrollBar1.Value < 0)
                guna2VScrollBar1.Value = 0;
            else if (guna2VScrollBar1.Value > guna2VScrollBar1.Maximum)
                guna2VScrollBar1.Value = guna2VScrollBar1.Maximum;


            if (searchEmpView.RowCount > 0)
            {

                int rowIndex = guna2VScrollBar1.Value;
                if (rowIndex >= searchEmpView.RowCount)
                    rowIndex = searchEmpView.RowCount - 1;

                searchEmpView.FirstDisplayedScrollingRowIndex = rowIndex;
            }
        }
        private void UpdateScrollBar()
        {
            int totalRows = searchEmpView.RowCount;


            guna2VScrollBar1.Maximum = totalRows - 1;


            guna2VScrollBar1.LargeChange = totalRows / 3;
            guna2VScrollBar1.SmallChange = 1;
        }
        private void searchEmpView_MouseWheel(object sender, MouseEventArgs e)
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



        private void searchBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string EmployeeNumber = empEmployeeIDtxt.Text.Trim();
                string EmployeeName = empNametxt.Text.Trim();
                string Employeephone = empPhoneSearchtxt.Text.Trim();

                int searchType;
                string searchValue;

                if (!string.IsNullOrWhiteSpace(EmployeeNumber))
                {
                    searchType = (int)SearchEmployeesFilesType.EmployeeNumber;
                    searchValue = EmployeeNumber;
                }
                else if (!string.IsNullOrWhiteSpace(EmployeeName))
                {
                    searchType = (int)SearchEmployeesFilesType.EmployeeName;
                    searchValue = EmployeeName;
                }
                else if (!string.IsNullOrWhiteSpace(Employeephone))
                {
                    searchType = (int)SearchEmployeesFilesType.EmployeePhone;
                    searchValue = Employeephone;
                }
                else
                {
                    MessageBox.Show("يرجى إدخال قيمة البحث!", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                SearchEmployeesFilesRequest request = new SearchEmployeesFilesRequest
                {
                    SearchType = searchType,
                    SearchValue = searchValue,
                    RequestID = Guid.NewGuid().ToString()
                };

                SearchEmployeesFilesResponse response = RequestSender.SendRequest<SearchEmployeesFilesRequest, SearchEmployeesFilesResponse>(request);

                if (response.EmployeeFiles != null && response.EmployeeFiles.Count > 0)
                {
                    searchEmpView.Rows.Clear();

                    foreach (var employee in response.EmployeeFiles)
                    {
                        int rowIndex = searchEmpView.Rows.Add();
                        searchEmpView.Rows[rowIndex].Cells["empName"].Value = employee.EmployeeName;
                        searchEmpView.Rows[rowIndex].Cells["empType"].Value = employee.EmployeeJobTitle;
                        searchEmpView.Rows[rowIndex].Cells["empNumber"].Value = string.Join(", ", employee.EmployeePhoneNumber);
                        searchEmpView.Rows[rowIndex].Cells["empIDNumber"].Value = employee.EmployeeNumber;

                        // ✅ تخزين بيانات الموظف بالكامل في Tag
                        searchEmpView.Rows[rowIndex].Tag = employee;
                    }
                }
                else
                {
                    MessageBox.Show("لم يتم العثور على أي موظف.", "نتيجة البحث", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    searchEmpView.Rows.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"خطأ أثناء البحث: {ex.Message}", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SearchFields_TextChanged(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(empNametxt.Text) &&
                string.IsNullOrWhiteSpace(empEmployeeIDtxt.Text) &&
                string.IsNullOrWhiteSpace(empPhoneSearchtxt.Text))
            {
                searchEmpView.Rows.Clear();
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


        private EmployeeViwerFrm editForm;
        private void searchEmpView_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && searchEmpView.Rows[e.RowIndex].Tag is EmployeeFile employee)
            {
                if (editForm == null || editForm.IsDisposed)
                {
                    editForm = new EmployeeViwerFrm();
                    editForm.LoadEmployeeData(employee);
                    editForm.Show();
                }
                else
                {
                    editForm.Focus();
                }
            }
        }
    }
    }

