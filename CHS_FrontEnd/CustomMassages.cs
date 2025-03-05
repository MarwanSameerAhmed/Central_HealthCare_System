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


        public enum MessageType
        {
            Warning, // تحذير
            Error,   // خطأ
            Success  // نجاح
        }

        private Guna2BorderlessForm gunaBorderlessForm;
        private Guna2ShadowForm shadowForm;
        private Guna2GradientPanel borderPanel;
        private Guna2PictureBox iconPictureBox;
        private Guna2HtmlLabel mainTextLabel, subTextLabel;
        private Guna2Button okButton, closeButton;

        public CustomMessageBox(MessageType type, string mainText, string subText)
        {
            // 🔹 تصغير حجم النافذة مع الحفاظ على الحواف
            this.Size = new Size(400, 250);
            this.FormBorderStyle = FormBorderStyle.None;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = Color.White;
            this.Opacity = 0; // **تأثير التلاشي عند الفتح**
            this.ControlBox = false; // إزالة زر الإغلاق العلوي
            this.RightToLeft = RightToLeft.Yes; // 📌 **تمكين دعم الاتجاه من اليمين إلى اليسار**
            this.RightToLeftLayout = true;
            // 📌
            this.Load += (s, e) =>
            {
                this.Top += 30; // يمكنك تغيير الرقم لتعديل المسافة
            };
            // 🔹 إضافة تأثير الظل المحترف
            shadowForm = new Guna2ShadowForm
            {
                TargetForm = this,
                ShadowColor = Color.FromArgb(50, 0, 0, 0)
            };

            // 🔹 تأثير التلاشي عند الفتح
            var fadeInTimer = new Timer { Interval = 10 };
            fadeInTimer.Tick += (s, e) =>
            {
                if (Opacity < 1) Opacity += 0.1;
                else fadeInTimer.Stop();
            };
            fadeInTimer.Start();

            // 🔹 إطار خارجي مع حواف واضحة من الأعلى
            borderPanel = new Guna2GradientPanel
            {
                Size = new Size(400, 250),
                Location = new Point(0, 0), // تعديل الموضع لإظهار الحواف
                BorderRadius = 15,
                FillColor = Color.FromArgb(245, 245, 245),
                FillColor2 = Color.WhiteSmoke
            };
            this.Controls.Add(borderPanel);

            // 🔹 أيقونة الرسالة (تم رفعها قليلاً للأعلى)
            Image icon = GetIcon(type);
            iconPictureBox = new Guna2PictureBox
            {
                Image = icon,
                SizeMode = PictureBoxSizeMode.Zoom,
                Location = new Point(150, 20), // تم رفع الأيقونة للأعلى
                Size = new Size(100, 100),
                BackColor = Color.Transparent
            };
            borderPanel.Controls.Add(iconPictureBox);

            // 🔹 تحسين نص العنوان الرئيسي (تم رفعه للأعلى)
            Label mainTextLabel = new Label
            {
                Text = mainText,
                Font = new Font("Traditional Arabic", 20, FontStyle.Bold),
                ForeColor = Color.Black,
                AutoSize = false,
                Location = new Point(20, 125),
                Size = new Size(358, 30),
                TextAlign = ContentAlignment.MiddleCenter, // ✅ النص في المنتصف
                RightToLeft = RightToLeft.Yes,
                 BackColor = Color.Transparent // ✅ دعم العربية

            };
            borderPanel.Controls.Add(mainTextLabel);

            Label subTextLabel = new Label
            {
                Text = subText,
                Font = new Font("Traditional Arabic", 16, FontStyle.Bold),
                ForeColor = Color.DarkGray,
                AutoSize = false,
                Location = new Point(20, 160),
                Size = new Size(358, 30),
                TextAlign = ContentAlignment.MiddleCenter, // ✅ النص في المنتصف
                RightToLeft = RightToLeft.Yes,
                                 BackColor = Color.Transparent // ✅ دعم العربية
                                                               // ✅ دعم العربية
            };
            borderPanel.Controls.Add(subTextLabel);



            // 🔹 تحسين زر "موافق" مع تأثيرات أنيقة (تم رفعه للأعلى)
            okButton = new Guna2Button
            {
                Text = "موافق",
                Font = new Font("Traditional Arabic", 12, FontStyle.Bold),
                ForeColor = Color.White,
                Size = new Size(120, 35),
                BackColor = Color.WhiteSmoke,
                Location = new Point(140, 200), // رفع الزر للأعلى
                BorderRadius = 12,
                FillColor = Color.DarkGray,
                Cursor = Cursors.Hand,
                ShadowDecoration = { Depth = 10 },
                HoverState = { FillColor = Color.DarkGray },
                PressedDepth = 5
            };
            okButton.Click += (s, e) =>
            {
                var fadeOutTimer = new Timer { Interval = 10 };
                fadeOutTimer.Tick += (s1, e1) =>
                {
                    if (Opacity > 0) Opacity -= 0.1;
                    else { fadeOutTimer.Stop(); this.Close(); }
                };
                fadeOutTimer.Start();
            };
            borderPanel.Controls.Add(okButton);



            // 🔹 تغيير لون الزر حسب نوع الرسالة
            switch (type)
            {
                case MessageType.Warning:
                    okButton.FillColor = Color.FromArgb(145, 166, 254);
                    break;
                case MessageType.Error:
                    okButton.FillColor = Color.FromArgb(86, 115, 234);
                    break;
                case MessageType.Success:
                    okButton.FillColor = Color.FromArgb(24, 68, 215);
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
                        return Image.FromFile("C:\\Users\\aa048\\source\\repos\\CHS_FrontEnd\\CHS_FrontEnd\\Resources\\Animation - 1740733988765.gif"); // استبدل بصورة التحذير
                    case MessageType.Error:
                        return Image.FromFile("C:\\Users\\aa048\\source\\repos\\CHS_FrontEnd\\CHS_FrontEnd\\Resources\\Animation - 1740734750635.gif");   // استبدل بصورة الخطأ
                    case MessageType.Success:
                        return Image.FromFile("C:\\Users\\aa048\\source\\repos\\CHS_FrontEnd\\CHS_FrontEnd\\Resources\\Animation - 1740735571693.gif"); // استبدل بصورة النجاح
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