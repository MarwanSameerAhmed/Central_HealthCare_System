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
    public partial class CustomMassages : Form
    {
        private Guna2Panel panel;
        private Guna2PictureBox pictureBox;
        private Guna2HtmlLabel titleLabel;
        private Guna2HtmlLabel messageLabel;
        private Guna2Button button1;
        private Guna2Button button2;

        public CustomMassages(string title, string message, string button1Text, string button2Text, EventHandler button1Click = null, EventHandler button2Click = null, string imagePath = null)
        {
            // إعدادات النموذج
            this.FormBorderStyle = FormBorderStyle.None;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Size = new System.Drawing.Size(350, 250);
            this.BackColor = System.Drawing.Color.White;

            // الحاوية الرئيسية
            panel = new Guna2Panel
            {
                Dock = DockStyle.Fill,
                BorderRadius = 10,
                ShadowDecoration = { Parent = this }
            };
            this.Controls.Add(panel);

            // PictureBox للصورة أو الأيقونة
            pictureBox = new Guna2PictureBox
            {
                Size = new System.Drawing.Size(60, 60),
                Location = new System.Drawing.Point(145, 10),
                SizeMode = PictureBoxSizeMode.Zoom
            };
            if (!string.IsNullOrEmpty(imagePath))
                pictureBox.Image = System.Drawing.Image.FromFile(imagePath);
            panel.Controls.Add(pictureBox);

            // عنوان الرسالة
            titleLabel = new Guna2HtmlLabel
            {
                Text = title,
                AutoSize = false,
                Location = new System.Drawing.Point(20, 80),
                Size = new System.Drawing.Size(310, 25),
                TextAlignment = System.Drawing.ContentAlignment.MiddleCenter,
                Font = new System.Drawing.Font("Arial", 12, System.Drawing.FontStyle.Bold)
            };
            panel.Controls.Add(titleLabel);

            // النص الفرعي
            messageLabel = new Guna2HtmlLabel
            {
                Text = message,
                AutoSize = false,
                Location = new System.Drawing.Point(20, 110),
                Size = new System.Drawing.Size(310, 40),
                TextAlignment = System.Drawing.ContentAlignment.MiddleCenter,
                Font = new System.Drawing.Font("Arial", 10)
            };
            panel.Controls.Add(messageLabel);

            // زر 1
            button1 = new Guna2Button
            {
                Text = button1Text,
                Size = new System.Drawing.Size(120, 35),
                Location = new System.Drawing.Point(30, 180),
                BorderRadius = 5,
                DialogResult = DialogResult.OK
            };
            if (button1Click != null) button1.Click += button1Click;
            button1.Click += (s, e) => this.Close();
            panel.Controls.Add(button1);

            // زر 2
            button2 = new Guna2Button
            {
                Text = button2Text,
                Size = new System.Drawing.Size(120, 35),
                Location = new System.Drawing.Point(190, 180),
                BorderRadius = 5,
                DialogResult = DialogResult.Cancel
            };
            if (button2Click != null) button2.Click += button2Click;
            button2.Click += (s, e) => this.Close();
            panel.Controls.Add(button2);
        }

     
        public static DialogResult Show(string title, string message, string button1Text = "OK", string button2Text = "Cancel", EventHandler button1Click = null, EventHandler button2Click = null, string imagePath = null)
        {
            using (CustomMassages msgBox = new CustomMassages(title, message, button1Text, button2Text, button1Click, button2Click, imagePath))
            {
                return msgBox.ShowDialog();
            }
        }
    }
}