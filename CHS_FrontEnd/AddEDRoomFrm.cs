using CHS_FrontEnd.Entities;
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
    public partial class AddEDRoomFrm : Form
    {
        private int roomNum;
        private int bedsNum;
        
        public AddEDRoomFrm()
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.None;

            // Disable resizing and other unnecessary features
            this.ControlBox = false;
            this.StartPosition = FormStartPosition.CenterParent;

            // Initialize controls and event handlers
            InitializeControls();
        }

        private void AddEDRoomFrm_Load(object sender, EventArgs e)
        {
        }

        private void numberBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow only digits and control keys (like backspace)
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Prevent the character from being entered
            }
        }

        private void numberBox_TextChanged(object sender, EventArgs e)
        {
            // Cast sender to Guna2TextBox
            var textBox = sender as Guna.UI2.WinForms.Guna2TextBox;
            if (textBox == null) return;

            // Retrieve the Tag property to store the associated integer value
            if (!(textBox.Tag is int currentValue)) return;

            // Try parsing the Guna2TextBox text to an integer
            if (!int.TryParse(textBox.Text, out int value))
            {
                // If parsing fails, reset to the last valid value
                textBox.Text = currentValue.ToString();
            }
            else
            {
                // Only update the value if the input is valid and not negative
                if (value < 0)
                {
                    textBox.Text = "0";
                    textBox.Tag = 0;
                }
                else
                {
                    textBox.Tag = value; // Update the Tag with the valid value
                }
            }

            // Ensure the cursor remains at the end of the text
            textBox.SelectionStart = textBox.Text.Length;
        }

        private void InitializeControls()
        {
            // Setup roomNumBox
            roomNumBox.KeyPress += numberBox_KeyPress;
            roomNumBox.TextChanged += numberBox_TextChanged;
            roomNumBox.Tag = roomNum; // Initialize the Tag with the roomNum variable

            increaseRoomNum.Click += AdjustValue_Click;
            increaseRoomNum.Tag = new Tuple<Guna.UI2.WinForms.Guna2TextBox, int>(roomNumBox, 1); // Increment by 1

            decreaseRoomNum.Click += AdjustValue_Click;
            decreaseRoomNum.Tag = new Tuple<Guna.UI2.WinForms.Guna2TextBox, int>(roomNumBox, -1); // Decrement by 1

            // Setup bedsNumBox
            bedsNumBox.KeyPress += numberBox_KeyPress;
            bedsNumBox.TextChanged += numberBox_TextChanged;
            bedsNumBox.Tag = bedsNum; // Initialize the Tag with the bedsNum variable

            increaseBedsNum.Click += AdjustValue_Click;
            increaseBedsNum.Tag = new Tuple<Guna.UI2.WinForms.Guna2TextBox, int>(bedsNumBox, 1); // Increment by 1

            decreaseBedsNum.Click += AdjustValue_Click;
            decreaseBedsNum.Tag = new Tuple<Guna.UI2.WinForms.Guna2TextBox, int>(bedsNumBox, -1); // Decrement by 1
        }

        private void AdjustValue_Click(object sender, EventArgs e)
        {
            // Cast sender to Guna2Button and retrieve its Tag property
            var button = sender as Guna.UI2.WinForms.Guna2Button;
            if (button == null || button.Tag == null) return;

            // Retrieve the associated Guna2TextBox and adjustment value
            var tag = button.Tag as Tuple<Guna.UI2.WinForms.Guna2TextBox, int>;
            if (tag == null) return;

            var targetBox = tag.Item1;
            int adjustment = tag.Item2;

            if (targetBox == null || !(targetBox.Tag is int currentValue)) return;

            // Adjust the value
            int newValue = currentValue + adjustment;

            // Ensure the value doesn't go below 0
            newValue = Math.Max(newValue, 0);

            // Update the Guna2TextBox and its Tag property
            targetBox.Text = newValue.ToString();
            targetBox.Tag = newValue;
        }

        private void addRoomButton_Click(object sender, EventArgs e)
        {
            string roomTxtBox = roomNumBox.Text;
            string bedsTxtBox = bedsNumBox.Text;
            if (int.TryParse(roomTxtBox, out int roomNumValue) && int.TryParse(bedsTxtBox, out int bedsNumValue))
            {
               EDRoom edRoom = new EDRoom(roomNumValue, bedsNumValue);
               //edRoom.initializeBedsState();
            }

            else
            {
                MessageBox.Show(".تأكد من إدخال رقم صحيح");
            }
        }
    }
}