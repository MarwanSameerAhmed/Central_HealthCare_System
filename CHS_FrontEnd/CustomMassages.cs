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

namespace CHS_FrontEnd
{
    public partial class CustomMessageBox : Form
    {
        private Guna2PictureBox iconPictureBox;
        private Label mainTextLabel;
        private Label subTextLabel;
        private Guna2Button okButton;
        private Guna2Panel borderPanel;
        private Guna2BorderlessForm gunaBorderlessForm;

        public enum MessageType
        {
            Warning, // تحذير
            Error,   // خطأ
            Success  // نجاح
        }

        public CustomMessageBox(MessageType type, string mainText, string subText)
        {
            // 🔹 إعدادات النافذة
            this.Size = new Size(420, 260);
            this.FormBorderStyle = FormBorderStyle.None;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = Color.White;

            // 🔹 تفعيل Guna2BorderlessForm
            gunaBorderlessForm = new Guna2BorderlessForm
            {
                ContainerControl = this,
                BorderRadius = 20
            };

            // 🔹 إنشاء Panel كإطار خارجي
            borderPanel = new Guna2Panel
            {
                Size = new Size(418, 258),
                Location = new Point(1, 1),
                BackColor = Color.White,
              
                BorderColor = Color.LightGray
            };
            this.Controls.Add(borderPanel); // 🟢 أضف Panel أولًا

            // 🔹 اختيار الأيقونة
            Image icon = GetIcon(type);

            // 🔹 أيقونة الرسالة
            iconPictureBox = new Guna2PictureBox
            {
                Image = icon,
                SizeMode = PictureBoxSizeMode.Zoom,
                Location = new Point(160, 20),
                Size = new Size(100, 100),
                BackColor = Color.Transparent
            };
            borderPanel.Controls.Add(iconPictureBox);

            // 🔹 نص العنوان الرئيسي
            mainTextLabel = new Label
            {
                Text = mainText,
                Font = new Font("Traditional Arabic", 14, FontStyle.Bold),
                ForeColor = Color.Black,
                TextAlign = ContentAlignment.MiddleCenter,
                AutoSize = false,
                Location = new Point(20, 130),
                Size = new Size(378, 30)
            };
            borderPanel.Controls.Add(mainTextLabel);

            // 🔹 نص العنوان الفرعي
            subTextLabel = new Label
            {
                Text = subText,
                Font = new Font("Traditional Arabic", 12, FontStyle.Regular),
                ForeColor = Color.Gray,
                TextAlign = ContentAlignment.MiddleCenter,
                AutoSize = false,
                Location = new Point(20, 160),
                Size = new Size(378, 30)
            };
            borderPanel.Controls.Add(subTextLabel);

            // 🔹 زر "موافق"
            okButton = new Guna2Button
            {
                Text = "موافق",
                Font = new Font("Traditional Arabic", 12, FontStyle.Bold),
                ForeColor = Color.White,
                Location = new Point(160, 200),
                Size = new Size(100, 35),
                BorderRadius = 10
            };

            // 🔹 تغيير لون الزر حسب نوع الرسالة
            switch (type)
            {
                case MessageType.Warning:
                    okButton.FillColor = Color.Orange;
                    break;
                case MessageType.Error:
                    okButton.FillColor = Color.Red;
                    break;
                case MessageType.Success:
                    okButton.FillColor = Color.Green;
                    break;
            }

            okButton.Click += (s, e) => this.Close();
            borderPanel.Controls.Add(okButton);
        }

        private Image GetIcon(MessageType type)
        {
            try
            {
                switch (type)
                {
                    case MessageType.Warning:
                        return Image.FromFile("C:\\Users\\aa048\\source\\repos\\CHS_FrontEnd\\CHS_FrontEnd\\Resources\\Animation - 1740172800555.gif"); // استبدل بصورة التحذير
                    case MessageType.Error:
                        return Image.FromFile("C:\\Users\\aa048\\source\\repos\\CHS_FrontEnd\\CHS_FrontEnd\\Resources\\Animation - 1740170391295.gif");   // استبدل بصورة الخطأ
                    case MessageType.Success:
                        return Image.FromFile("C:\\Users\\aa048\\source\\repos\\CHS_FrontEnd\\CHS_FrontEnd\\Resources\\Animation - 1740170294033.gif"); // استبدل بصورة النجاح
                    default:
                        return null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"خطأ في تحميل الأيقونة: {ex.Message}");
                return null;
            }
        }

        public static void Show(MessageType type, string mainText, string subText)
        {
            CustomMessageBox msgBox = new CustomMessageBox(type, mainText, subText);
            msgBox.ShowDialog();
        }
    }
}