using CHS.Client.API;
using CHS.Client.API.Models;
using CHS.Client.API.Models.Facilities;
//using DocumentFormat.OpenXml.Office2016.Excel;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace CHS_FrontEnd
{
    public partial class EDBedsManagement : Form
    {

        // Dictionary to store bed types and their associated controls
        private Dictionary<string, (Guna.UI2.WinForms.Guna2TextBox total, Guna.UI2.WinForms.Guna2TextBox available,
                                     Guna.UI2.WinForms.Guna2Button incTotal, Guna.UI2.WinForms.Guna2Button decTotal,
                                     Guna.UI2.WinForms.Guna2Button incAvailable, Guna.UI2.WinForms.Guna2Button decAvailable)> bedTypes;

        public EDBedsManagement()
        {
            InitializeComponent();
            InitializeControls();
        }

        private void EDBedsManagement_Load(object sender, EventArgs e)
        {
            try
            {
                GetEDBedsResponse response = RequestSender.SendRequest<CHSRequest, GetEDBedsResponse>(null);
                if (response != null ) 
                {
                    totalGeneralBedsNumBox.Text = response.TotalGeneralBeds.ToString();
                    availableGeneralBedsNumBox.Text = response.AvailableGeneralBeds.ToString();
                    totalPediatricBedsNumBox.Text = response.TotalPediatricBeds.ToString();
                    availablePediatricBedsNumBox.Text = response.AvailablePediatricBeds.ToString();
                    totalTraumaBedsNumBox.Text = response.TotalTraumaBeds.ToString();
                    availableTraumaBedsNumBox.Text = response.AvailableTraumaBeds.ToString();
                    totalIsolationBedsNumBox.Text = response.TotalIsolationBeds.ToString();
                    availableIsolationBedsNumBox.Text = response.AvailableIsolationBeds.ToString();
                    totalCriticalCareBedsNumBox.Text = response.TotalCriticalCareBeds.ToString();
                    availableCriticalCareBedsNumBox.Text = response.AvailableCriticalCareBeds.ToString();
                    totalVIPBedsNumBox.Text = response.TotalVIPBeds.ToString();
                    availableVIPBedsNumBox.Text = response.AvailableVIPBeds.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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

        private void InitializeBedTypes()
        {
            // Initialize the dictionary with bed types and associated controls
            bedTypes = new Dictionary<string, (Guna.UI2.WinForms.Guna2TextBox, Guna.UI2.WinForms.Guna2TextBox,
                                               Guna.UI2.WinForms.Guna2Button, Guna.UI2.WinForms.Guna2Button,
                                               Guna.UI2.WinForms.Guna2Button, Guna.UI2.WinForms.Guna2Button)>
            {
                ["General"] = (totalGeneralBedsNumBox, availableGeneralBedsNumBox,
                               increaseTotalGeneralBedsNum, decreaseTotalGeneralBedsNum,
                               increaseAvailableGeneralBedsNum, deacreaseAvailableGeneralBedsNum),
                ["Pediatric"] = (totalPediatricBedsNumBox, availablePediatricBedsNumBox,
                                 increaseTotalPediatricBedsNum, decreaseTotalPediatricBedsNum,
                                 increaseAvailablePediatricBedsNum, decreaseAvailablePediatricBedsNum),
                ["Trauma"] = (totalTraumaBedsNumBox, availableTraumaBedsNumBox,
                              increaseTotalTraumaBedsNum, decreaseTotalTraumaBedsNum,
                              increaseAvailableTraumaBedsNum, decreaseAvailableTraumaBedsNum),
                ["Isolation"] = (totalIsolationBedsNumBox, availableIsolationBedsNumBox,
                                 increaseTotalIsolationBedsNum, decreaseTotalIsolationBedsNum,
                                 increaseAvailableIsolationBedsNum, decreaseAvailableIsolationBedsNum),
                ["CriticalCare"] = (totalCriticalCareBedsNumBox, availableCriticalCareBedsNumBox,
                                    increaseTotalCriticalCareBedsNum, decreaseTotalCriticalCareBedsNum,
                                    increaseAvailableCriticalCareBedsNum, decreaseAvailableCriticalCareBedsNum),
                ["VIP"] = (totalVIPBedsNumBox, availableVIPBedsNumBox,
                           increaseTotalVIPBedsNum, decreaseTotalVIPBedsNum,
                           increaseAvailableVIPBedsNum, decreaseAvailableVIPBedsNum)
            };
        }

        private void InitializeControls()
        {
            InitializeBedTypes(); // Initialize the mapping

            foreach (var bedType in bedTypes)
            {
                var (totalBox, availableBox, incTotal, decTotal, incAvailable, decAvailable) = bedType.Value;

                // Set up total beds box
                totalBox.KeyPress += numberBox_KeyPress;
                totalBox.TextChanged += numberBox_TextChanged;
                totalBox.Tag = 0; // Initialize Tag with 0

                // Set up available beds box
                availableBox.KeyPress += numberBox_KeyPress;
                availableBox.TextChanged += numberBox_TextChanged;
                availableBox.Tag = 0; // Initialize Tag with 0

                // Set up buttons
                incTotal.Click += AdjustValue_Click;
                incTotal.Tag = new Tuple<Guna.UI2.WinForms.Guna2TextBox, int>(totalBox, 1);

                decTotal.Click += AdjustValue_Click;
                decTotal.Tag = new Tuple<Guna.UI2.WinForms.Guna2TextBox, int>(totalBox, -1);

                incAvailable.Click += AdjustValue_Click;
                incAvailable.Tag = new Tuple<Guna.UI2.WinForms.Guna2TextBox, int>(availableBox, 1);

                decAvailable.Click += AdjustValue_Click;
                decAvailable.Tag = new Tuple<Guna.UI2.WinForms.Guna2TextBox, int>(availableBox, -1);
            }
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

        private void confirmButton_Click(object sender, EventArgs e)
        {
            foreach (var bedType in bedTypes.Keys)
            {
                if (!CompareTextBoxValues(bedType))
                {
                    return; // Stop on the first invalid entry
                }
            }

            UpdateEDBedsRequest request = new UpdateEDBedsRequest();

            request.TotalGeneralBeds = int.Parse(totalGeneralBedsNumBox.Text);
            request.AvailableGeneralBeds = int.Parse(availableGeneralBedsNumBox.Text);
            request.TotalPediatricBeds = int.Parse(totalPediatricBedsNumBox.Text);
            request.AvailablePediatricBeds = int.Parse(availablePediatricBedsNumBox.Text);
            request.TotalTraumaBeds = int.Parse(totalTraumaBedsNumBox.Text);
            request.AvailableTraumaBeds = int.Parse(availableTraumaBedsNumBox.Text);
            request.TotalIsolationBeds = int.Parse(totalIsolationBedsNumBox.Text);
            request.AvailableIsolationBeds = int.Parse(availableIsolationBedsNumBox.Text);
            request.TotalCriticalCareBeds = int.Parse(totalCriticalCareBedsNumBox.Text);
            request.AvailableCriticalCareBeds = int.Parse(availableCriticalCareBedsNumBox.Text);
            request.TotalVIPBeds = int.Parse(totalVIPBedsNumBox.Text);
            request.AvailableVIPBeds = int.Parse(availableVIPBedsNumBox.Text);


            try
            {
                CHSResponse response = RequestSender.SendRequest<UpdateEDBedsRequest, CHSResponse>(request);
                if (response != null)
                {
                    MessageBox.Show(response.MessageDescription);
                }
                else
                {
                    MessageBox.Show("failed");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private bool CompareTextBoxValues(string bedType)
        {
            if (bedTypes.TryGetValue(bedType, out var controls))
            {
                var (totalBox, availableBox, _, _, _, _) = controls;

                if (int.TryParse(availableBox.Text, out int availableBeds) &&
                    int.TryParse(totalBox.Text, out int totalBeds))
                {
                    if (availableBeds > totalBeds)
                    {
                        MessageBox.Show($"The available {bedType} beds cannot exceed the total {bedType} beds.",
                                        "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        availableBox.Text = totalBeds.ToString();
                        return false;
                    }
                    return true;
                }
                else
                {
                    MessageBox.Show($"Invalid input in {bedType} beds fields.",
                                    "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }

            MessageBox.Show($"Unknown bed type: {bedType}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }
    }
}
