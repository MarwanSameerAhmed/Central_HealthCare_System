using CHS.Client.API.Models;
using CHS.Client.API;
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
using System.Security.Principal;
using CHS.Client.API.Models.Facilities;

namespace CHS_FrontEnd
{
    public partial class AddNewFacilityFrm : Form
    {
        public AddNewFacilityFrm(DockPanel dockPanel)
        {
            InitializeComponent();
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                // استدعاء API لاسترجاع أنواع المنشآت
                var response = RequestSender.SendRequest<CHSRequest, GetFacilitiesTypesResponse>(new CHSRequest());

                if (response.ResponseCode == "1")
                {
                    // ملء ComboBox بالأنواع المسترجعة
                    cmbFacilityType.DataSource = response.facilityTypes;
                    cmbFacilityType.DisplayMember = "Name"; // الحقل الذي يحتوي على اسم النوع
                    cmbFacilityType.ValueMember = "ID";   // الحقل الذي يحتوي على معرف النوع
                }
                else
                {
                    MessageBox.Show("فشل في استرجاع أنواع المنشآت: " + response.MessageDescription, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"حدث خطأ أثناء استرجاع أنواع المنشآت: {ex.Message}", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void guna2TextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private async void createBtn_Click(object sender, EventArgs e)
        {
            try
            {
                // جمع البيانات من الحقول
                string facilityName = txtFacilityName.Text;
                string facilityAddress = txtFacilityAddress.Text;
                string facilityPhones = txtFacilityPhones.Text; // افصل الأرقام بفاصلة
                string facilityEmail = txtFacilityEmail.Text;
                int facilityType = (int)cmbFacilityType.SelectedValue; // الحصول على النوع المحدد

                // إعداد الطلب
                var request = new CreateFacilityRequest
                {
                    FacilityName = facilityName,
                    FacilityAddress = facilityAddress,
                    FacilityPhones = facilityPhones.Split(',').ToList(),
                    FacilityEmail = facilityEmail,
                    FacilityType = facilityType
                };

                // إرسال الطلب باستخدام RequestSender
                var response = RequestSender.SendRequest<CreateFacilityRequest, CHSResponse>(request);

                if (response.ResponseCode == "1")
                {
                    MessageBox.Show(response.MessageDescription, "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("فشل في إضافة المنشأة: " + response.MessageDescription, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"حدث خطأ أثناء إنشاء المنشأة: {ex.Message}", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
    }

