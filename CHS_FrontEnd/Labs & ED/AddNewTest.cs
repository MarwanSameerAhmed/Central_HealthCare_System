using CHS.Client.API;
using CHS.Client.API.Models;
using CHS.Client.API.Models.Labs;
using OpenTK.Graphics.OpenGL;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Web.Management;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace CHS_FrontEnd.Labs___ED
{
    public partial class AddNewTest : Form
    {
        private DockPanel dockPanel;
        // Track the currently selected custom node panel.
        private Guna.UI2.WinForms.Guna2Panel currentSelectedPanel;

        public AddNewTest(DockPanel dockPanel)
        {
            InitializeComponent();
            this.dockPanel = dockPanel;
        }

        private void AddNewTest_Load(object sender, EventArgs e)
        {
            treLabTests.Location = new Point(715, 455);

            // Set default view: TreeView visible, CustomTree hidden.
            treLabTests.Visible = true;
            CustomTree.Visible = false;
            switchView.Text = "Switch to Custom View";

            // Configure the Guna2VScrollBar for the CustomTree.
            guna2VScrollBar1.Dock = DockStyle.Right;
            guna2VScrollBar1.Scroll += guna2VScrollBar1_Scroll;
        }

        /// <summary>
        /// Updates the custom scrollbar maximum based on CustomTree content.
        /// </summary>
        private void UpdateCustomTreeScrollBar()
        {
            // Calculate the total scrollable height.
            int scrollableHeight = CustomTree.DisplayRectangle.Height - CustomTree.ClientSize.Height;
            if (scrollableHeight < 0)
                scrollableHeight = 0;
            guna2VScrollBar1.Maximum = scrollableHeight;
        }

        private void guna2VScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            // Update the vertical scroll position of the CustomTree.
            CustomTree.AutoScrollPosition = new Point(0, guna2VScrollBar1.Value);
        }

        /// <summary>
        /// Recursively fills the TreeView with lab test results.
        /// </summary>
        private void FillTree(List<ResultLabTest> results, TreeNode parent)
        {
            if (results == null || results.Count == 0)
                return;

            foreach (var result in results)
            {
                TreeNode node = new TreeNode(result.Name)
                {
                    Tag = result
                };
                FillTree(result.SubResults, node);
                parent.Nodes.Add(node);
            }
        }

        /// <summary>
        /// Recursively creates a custom tree using Guna2 panels.
        /// </summary>
        /// <param name="results">List of lab test results</param>
        /// <param name="parent">Parent container (CustomTree or a child panel)</param>
        /// <param name="indent">Indentation level (in pixels) for hierarchical display</param>
        private void PopulateCustomTree(List<ResultLabTest> results, Control parent, int indent)
        {
            if (results == null || results.Count == 0)
                return;

            foreach (var result in results)
            {
                // Create a panel for this node.
                var nodePanel = new Guna.UI2.WinForms.Guna2Panel
                {
                    Size = new Size(350 - indent, 40),
                    BorderRadius = 10,
                    FillColor = Color.White,
                    Margin = new Padding(indent, 5, 5, 5)
                };

                // Create a label to display the test name.
                var lblName = new Guna.UI2.WinForms.Guna2HtmlLabel
                {
                    Text = result.Name,
                    Font = new Font("Traditional Arabic", 10.8F, FontStyle.Bold),
                    Location = new Point(10, 10),
                    AutoSize = true
                };
                nodePanel.Controls.Add(lblName);

                // Add click event to mimic TreeView selection logic.
                nodePanel.Click += (s, e) =>
                {
                    // Reset previous selection if any.
                    if (currentSelectedPanel != null)
                        currentSelectedPanel.FillColor = Color.White;

                    // Set this node as the current selection.
                    currentSelectedPanel = nodePanel;
                    nodePanel.FillColor = Color.FromArgb(21, 77, 146);

                    // Mimic TreeView behavior: disable txtResult and enable if no subresults.
                    txtResult.Enabled = false;
                    if (result.SubResults == null || result.SubResults.Count == 0)
                        txtResult.Enabled = true;

                    txtResult.Tag = result;
                    txtResult.Text = ""; // Optionally, load an existing value if available.
                };

                // Add the node panel to the parent container.
                parent.Controls.Add(nodePanel);

                // If there are subresults, create a child container and populate it recursively.
                if (result.SubResults != null && result.SubResults.Count > 0)
                {
                    FlowLayoutPanel childPanel = new FlowLayoutPanel
                    {
                        FlowDirection = FlowDirection.TopDown,
                        AutoSize = true,
                        Margin = new Padding(indent + 20, 0, 0, 0)
                    };
                    parent.Controls.Add(childPanel);
                    PopulateCustomTree(result.SubResults, childPanel, indent + 20);
                }
            }
        }

        private void treLabTests_AfterSelect(object sender, TreeViewEventArgs e)
        {
            txtResult.Enabled = false;
            if (e.Node.Tag == null)
                return;

            ResultLabTest result = (ResultLabTest)e.Node.Tag;
            if (result.SubResults == null || result.SubResults.Count == 0)
            {
                txtResult.Enabled = true;
                txtResult.Text = result.Value;
                resultLabel.Text = $"النتيجة: {result.Name}";
            }
            else resultLabel.Text = "النتيجة";
        }

        private void btnSearch_Click_1(object sender, EventArgs e)
        {
            ResultLabTestRequest request = new ResultLabTestRequest
            {
                PatientDiagnosisNumber = long.Parse(patientDiagnosisNumber.Text),
                RequestID = Guid.NewGuid().ToString()
            };
            try
            {

                ResultLabTestTemplateResponse response = RequestSender.SendRequest<ResultLabTestRequest, ResultLabTestTemplateResponse>(request);
                if (response.ResponseCode != "1")
                {
                    MessageBox.Show(response.MessageDescription);
                    return;
                }
                btnSearch.Enabled = false;
                addResultButton.Enabled = true;
                // Populate the TreeView.
                treLabTests.Nodes.Clear();
                TreeNode root = new TreeNode("Lab tests");
                FillTree(response.Results, root);
                treLabTests.Nodes.Add(root);
                treLabTests.ExpandAll();

                // Populate the CustomTree view.
                CustomTree.Controls.Clear();
                currentSelectedPanel = null;
                PopulateCustomTree(response.Results, CustomTree, 0);

                // Update the custom scrollbar maximum.
                UpdateCustomTreeScrollBar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void switchView_Click(object sender, EventArgs e)
        {
            if (treLabTests.Visible)
            {
                treLabTests.Visible = false;
                CustomTree.Visible = true;
                switchView.Text = "Switch to Tree View";
            }
            else
            {
                CustomTree.Visible = false;
                treLabTests.Visible = true;
                switchView.Text = "Switch to Custom View";
            }
        }

        private void addResultButton_Click(object sender, EventArgs e)
        {
            if (treLabTests.SelectedNode is null) return;
            ResultLabTest labTest = (ResultLabTest)treLabTests.SelectedNode.Tag;
            if (string.IsNullOrEmpty(txtResult.Text)) return;

            labTest.Value = txtResult.Text;
            txtResult.Clear();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            List<ResultLabTest> resultLabTests = new List<ResultLabTest>();
            foreach (TreeNode node  in treLabTests.Nodes[0].Nodes)
            {
                if (hasValue((ResultLabTest)node.Tag)) 
                {
                    resultLabTests.Add((ResultLabTest)node.Tag);
                }
            }
            if (resultLabTests.Count == 0)
            {
                MessageBox.Show("Error");
                return;
            }

            try
            {
                SaveLabTestsResultsRequest request = new SaveLabTestsResultsRequest()
                {
                    RequestID = Guid.NewGuid().ToString(),
                    PatientDiagnosisNumber = long.Parse(patientDiagnosisNumber.Text),
                    Results = resultLabTests
                };
                CHSResponse response = RequestSender.SendRequest<SaveLabTestsResultsRequest, CHSResponse>(request);
                MessageBox.Show(response.MessageDescription);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private bool hasValue(ResultLabTest result)
        {
            if ((result.SubResults == null || result.SubResults.Count == 0)) return !string.IsNullOrEmpty(result.Value);
            foreach(ResultLabTest subResults in result.SubResults)
            {
                if (hasValue(subResults)) return true;
            }
            return false;
        }

        private void patientDiagnosisNumber_TextChanged(object sender, EventArgs e)
        {
            btnSearch.Enabled = true;
            addResultButton.Enabled = false;
            treLabTests.Nodes.Clear();
        }
    }
}
