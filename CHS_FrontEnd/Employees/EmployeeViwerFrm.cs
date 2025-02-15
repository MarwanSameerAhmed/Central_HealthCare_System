using CHS.Client.API.Models.Employees;
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
    public partial class EmployeeViwerFrm : Form
    {
        public EmployeeViwerFrm()
        {
            InitializeComponent();
           

        }

       
        private void ConfigureComboBox()
        {
            var genderList = new List<KeyValuePair<string, int>>
        {
            new KeyValuePair<string, int>("ذكر", 1),
            new KeyValuePair<string, int>("أنثى", 0)
        };

            empGendertxt.DataSource = genderList;
            empGendertxt.DisplayMember = "Key";
            empGendertxt.ValueMember = "Value";
        }

        
        public void LoadEmployeeData(EmployeeFile employee)
        {

            empFullNametxt.Text = employee.EmployeeName;
            empDegreeCombo.SelectedItem = employee.EmployeeJobTitle;
            empPhoneNumbertxt.Text = string.Join(", ", employee.EmployeePhoneNumber);
            empNationalIDtxt.Text = employee.EmployeeIDCardNumber;
            empEmailTxt.Text = employee.EmployeeEmail;


            if (!string.IsNullOrWhiteSpace(employee.EmployeeBirthData) && DateTime.TryParse(employee.EmployeeBirthData, out DateTime birthDate))
            {
                empBirthdaytxt.Value = birthDate;
            }
            else
            {
                empBirthdaytxt.Value = DateTime.Now; 
            }

           
            if (!string.IsNullOrWhiteSpace(employee.EmployeeEmployementDate) && DateTime.TryParse(employee.EmployeeEmployementDate, out DateTime employDate))
            {
                employmentDate.Value = employDate;
            }
            else
            {
                employmentDate.Value = DateTime.Now; 
            }


            empGendertxt.SelectedValue = employee.EmployeeIsMale ? 1 : 0;

            
            //userNameTxt.Text = employee.EmployeeUserName;
            //passwordTxt.Text = employee.EmployeePassword;
        }

        private void EmployeeViwerFrm_Load(object sender, EventArgs e)
        {
            ConfigureComboBox();
        }
    }
}
