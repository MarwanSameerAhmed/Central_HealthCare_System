using CHS.Client;
using FontAwesome.Sharp;
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
    public partial class Mainfrm : Form
    {
        private DockPanel dockPanel;



        private Form currentForm = null;
        private bool isCollapsed = false;



        public Mainfrm(string username)
        {
            InitializeComponent();

            customDes();
            this.WindowState = FormWindowState.Maximized;
            dockPanel = new DockPanel() { Dock = DockStyle.Fill };
            var theme = new VS2015BlueTheme();
            theme.Skin.DockPaneStripSkin.TextFont = new System.Drawing.Font("Castellar", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dockPanel.Theme = theme;
            this.Controls.Add(dockPanel);
            dockPanel.BringToFront();

            labUserName.Text =  $"{username}";


        }





        private void Form1_Load(object sender, EventArgs e)
        {
            MainPage.PerformClick();
            MainPageSubBtn.Visible = true;
            pharmacysunbtn.Visible = false;
            emergrncysubBtn.Visible = false;
            EmployeeSubBtn.Visible = false;
            Patientman2SubBtn.Visible = false;
            patientManagementSubBtn.Visible = false;
            LabSubBtn.Visible = false;
            facilitySubBtn.Visible = false;
            doctorsSubBtn.Visible = false;

            BindButtonToButton(MainPage,MainPageSubBtn);
            BindButtonToButton(PatientManagementBtn,patientManagementSubBtn);
            BindButtonToButton(EmployeesManagementBtn, EmployeeSubBtn);
            BindButtonToButton(LabDepBtn, LabSubBtn);
            BindButtonToButton(PharmacyDepBtn, pharmacysunbtn);
            BindButtonToButton(EmergncyDepBtn, emergrncysubBtn);
            BindButtonToButton(FacilityManagementBtn, facilitySubBtn);
            BindButtonToButton(DoctorsDepBtn, doctorsSubBtn);
            BindButtonToButton(PatientFileManagementBtn, Patientman2SubBtn);


        }




        private void OpenForm(Form childForm)
        {

            if (currentForm != null && currentForm.GetType() == childForm.GetType())
            {

                return;
            }
            currentForm = childForm;


            childForm.TopLevel = false;

            var dockContent = new DockContent()
            {
                Text = childForm.Text
            };

            childForm.Dock = DockStyle.Fill;
            dockContent.Controls.Add(childForm);
            childForm.Show();
            dockContent.Show(dockPanel);

        }


        private void show()
        {
            MainService fr = new MainService(dockPanel);
            OpenForm(fr);
        }

        private void customDes()
        {
            PatientsubMenuPanel.Visible = false;
            EmployeesSubMenu.Visible = false;
            LabDepSubMenu.Visible = false;
            EmergncySubMenu.Visible = false;
            PharmacySubmenu.Visible = false;
            FacilitySubMenu.Visible = false;
            DoctorsDepSubMenu.Visible = false;
            PatientManagment2SubMenu.Visible = false;
        }

        private void hideSub()
        {
            if (PatientsubMenuPanel.Visible == true)
                PatientsubMenuPanel.Visible = false;
            if (EmployeesSubMenu.Visible == true)
                EmployeesSubMenu.Visible = false;
            if (LabDepSubMenu.Visible == true)
                LabDepSubMenu.Visible = false;
            if (EmergncySubMenu.Visible == true)
                EmergncySubMenu.Visible = false;
            if (PharmacySubmenu.Visible == true)
                PharmacySubmenu.Visible = false;
            if (FacilitySubMenu.Visible == true)
                FacilitySubMenu.Visible = false;
            if (DoctorsDepSubMenu.Visible == true)
                DoctorsDepSubMenu.Visible = false;
            if (PatientManagment2SubMenu.Visible == true)
                PatientManagment2SubMenu.Visible = false;



        }



        private void showSub(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSub();
                subMenu.Visible = true;
               



            }
            else
            {
                subMenu.Visible = false;
                patientManagementSubBtn.Image = Properties.Resources.icons8_expand_arrow_64__2_;

            }

        }
        private void LabDepBtn_Click(object sender, EventArgs e)
        {
            showSub(LabDepSubMenu);
            pharmacysunbtn.Visible = false;
            MainPageSubBtn.Visible = false;
            emergrncysubBtn.Visible = false;
            EmployeeSubBtn.Visible = false;
            Patientman2SubBtn.Visible = false;
            patientManagementSubBtn.Visible = false;
            LabSubBtn.Visible = true;
            facilitySubBtn.Visible = false;
            doctorsSubBtn.Visible = false;
        }

        private void PatientManagementBtn_Click(object sender, EventArgs e)
        {

            showSub(PatientsubMenuPanel);
            pharmacysunbtn.Visible = false;
            MainPageSubBtn.Visible = false;
            emergrncysubBtn.Visible = false;
            EmployeeSubBtn.Visible = false;
            Patientman2SubBtn.Visible = false;
            patientManagementSubBtn.Visible = true;
            LabSubBtn.Visible = false;
            facilitySubBtn.Visible = false;
            doctorsSubBtn.Visible = false;
        }

        private void patientAddFrmBtn_Click(object sender, EventArgs e)
        {
            OpenForm(new addingPatientFrm(dockPanel));
            patientManagementSubBtn.Image = Properties.Resources.icons8_expand_arrow_64__2_;
            

        }

        private void PatientSearchFrmBtn_Click(object sender, EventArgs e)
        {
            OpenForm(new searchPatientFrm(dockPanel));
         

        }


        private void EmployeesManagementBtn_Click(object sender, EventArgs e)
        {
            showSub(EmployeesSubMenu);
            pharmacysunbtn.Visible = false;
            MainPageSubBtn.Visible = false;
            emergrncysubBtn.Visible = false;
            EmployeeSubBtn.Visible = true;
            Patientman2SubBtn.Visible = false;
            patientManagementSubBtn.Visible = false;
            LabSubBtn.Visible = false;
            facilitySubBtn.Visible = false;
            doctorsSubBtn.Visible = false;

        }


        private void HmbSizeBtn_Click(object sender, EventArgs e)
        {

            if (isCollapsed)
            {

                SideMenuPanel.Width = 250;
                foreach (Control control in SideMenuPanel.Controls)
                {
                    if (control is Button button)
                    {
                        button.Text = button.Tag?.ToString();
                    }
                }
                isCollapsed = false;
            }
            else
            {
                // تصغير القائمة
                SideMenuPanel.Width = 59;
                foreach (Control control in SideMenuPanel.Controls)
                {
                    if (control is Button button)
                    {
                        button.Tag = button.Text;
                        button.Text = "";
                        hideSub();
                    }
                }
                isCollapsed = true;
            }
        }
        private void BindButtonToButton(Control baseButton, Control overlayButton)
        {

            overlayButton.Location = new Point(
                baseButton.Left + 60,
                baseButton.Top + 5
            );


            baseButton.LocationChanged += (s, e) =>
            {
                overlayButton.Location = new Point(
                    baseButton.Left + 60,
                    baseButton.Top + 5
                );
            };

        }

        private void MainPage_Click(object sender, EventArgs e)
        {
            show();
            pharmacysunbtn.Visible = false;
            MainPageSubBtn.Visible = true;
            emergrncysubBtn.Visible = false;
            EmployeeSubBtn.Visible = false;
            Patientman2SubBtn.Visible = false;
            patientManagementSubBtn.Visible = false;
            LabSubBtn.Visible = false;
            facilitySubBtn.Visible = false;
            doctorsSubBtn.Visible = false;
            hideSub();
        }


        private void EmployessAddBtn_Click(object sender, EventArgs e)
        {
            OpenForm(new employeeAddFrm(dockPanel));
           
        }

        private void EmployessSearchBtn_Click(object sender, EventArgs e)
        {
            OpenForm(new employeeSearchFrm(dockPanel));
           
        }

        private void PharmacyDepBtn_Click(object sender, EventArgs e)
        {

            showSub(PharmacySubmenu);
            pharmacysunbtn.Visible = true ;
            MainPageSubBtn.Visible=false;
            emergrncysubBtn.Visible=false;
            EmployeeSubBtn.Visible=false;
            Patientman2SubBtn.Visible=false;
            patientManagementSubBtn.Visible=false;
            LabSubBtn.Visible= false;
           
            facilitySubBtn.Visible=false;

        }

        private void EmergncyDepBtn_Click(object sender, EventArgs e)
        {
            showSub(EmergncySubMenu);
            pharmacysunbtn.Visible = false;
            MainPageSubBtn.Visible = false;
            emergrncysubBtn.Visible = true;
            EmployeeSubBtn.Visible = false;
            Patientman2SubBtn.Visible = false;
            patientManagementSubBtn.Visible = false;
            LabSubBtn.Visible = false;
           
            facilitySubBtn.Visible = false;
            doctorsSubBtn.Visible=false;
        }

        private void FacilityManagementBtn_Click(object sender, EventArgs e)
        {
            showSub(FacilitySubMenu);
            pharmacysunbtn.Visible = false;
            MainPageSubBtn.Visible = false;
            emergrncysubBtn.Visible = false;
            EmployeeSubBtn.Visible = false;
            Patientman2SubBtn.Visible = false;
            patientManagementSubBtn.Visible = false;
            LabSubBtn.Visible = false;
         
            facilitySubBtn.Visible = true;
            doctorsSubBtn.Visible = false;
        }

        private void DoctorsDepBtn_Click(object sender, EventArgs e)
        {
            showSub(DoctorsDepSubMenu);
            pharmacysunbtn.Visible = false;
            MainPageSubBtn.Visible = false;
            emergrncysubBtn.Visible = false;
            EmployeeSubBtn.Visible = false;
            Patientman2SubBtn.Visible = false;
            patientManagementSubBtn.Visible = false;
            LabSubBtn.Visible = false;
          
            facilitySubBtn.Visible = false;
            doctorsSubBtn.Visible = true;
        }

        private void PatientFileManagementBtn_Click(object sender, EventArgs e)
        {
            showSub(PatientManagment2SubMenu);
            pharmacysunbtn.Visible = false;
            MainPageSubBtn.Visible = false;
            emergrncysubBtn.Visible = false;
            EmployeeSubBtn.Visible = false;
            Patientman2SubBtn.Visible = true;
            patientManagementSubBtn.Visible = false;
            LabSubBtn.Visible = false;
            facilitySubBtn.Visible = false;
            doctorsSubBtn.Visible = false;
        }

        private void LogOutBtn_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("هل تريد تسجيل الخروج؟", "تأكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {

                frmLogin loginForm = new frmLogin();
                loginForm.Show();


                this.Close();
            }
        }

        private void AddNewDoctorBtn_Click(object sender, EventArgs e)
        {
            AddNewDoctorFrm fr = new AddNewDoctorFrm(dockPanel);
            OpenForm(fr);
        }

        private void AddNewFacilityBtn_Click(object sender, EventArgs e)
        {
            AddNewFacilityFrm fr = new AddNewFacilityFrm(dockPanel);
            OpenForm(fr);
        }

        private void SearchFacilityBtn_Click(object sender, EventArgs e)
        {
            searchPlacemenet fr = new searchPlacemenet(dockPanel);
            OpenForm(fr);
        }

        private void SearchDoctorBtn_Click(object sender, EventArgs e)
        {
            searchDoctor fr = new searchDoctor(dockPanel);
            OpenForm(fr);
        }

        private void SearchPatientFileBtn_Click(object sender, EventArgs e)
        {
            searchPatient_praivte_cs fr = new searchPatient_praivte_cs(dockPanel);
            OpenForm(fr);
        }

        private void demoButton_Click(object sender, EventArgs e)
        {
            OpenForm(new LocalEDManagementFrm(dockPanel));
        }

        private void LabDepSearchBtn_Click(object sender, EventArgs e)
        {
            OpenForm(new LIMBsFrm(dockPanel));
        }

        private void patientManagementSubBtn_Click(object sender, EventArgs e)
        {

        }

        private void iconButton12_Click(object sender, EventArgs e)
        {
            searchEmployees_praivte_ fr = new searchEmployees_praivte_(dockPanel);
            OpenForm(fr);
        }
    }
}





