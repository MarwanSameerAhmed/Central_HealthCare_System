using CHS.Client.API;
using CHS.Client.API.Models.Labs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CHS_FrontEnd.Labs___ED
{
    public partial class FillResultsLabTestsFrm : Form
    {
        public FillResultsLabTestsFrm()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            ResultLabTestRequest request = new ResultLabTestRequest
            {
                PatientDiagnosisNumber = long.Parse(patientDiagnosisNumber.Text),
                RequestID = Guid.NewGuid().ToString()
            };
            ResultLabTestTemplateResponse response = RequestSender.SendRequest<ResultLabTestRequest, ResultLabTestTemplateResponse>(request);
            TreeNode root = new TreeNode("Lab tests");
            FillTree(response.Results, root);
            treLabTests.Nodes.Add(root);
            treLabTests.ExpandAll();
        }

        private void FillTree(List<ResultLabTest> results, TreeNode parent)
        {
            if (results is null || results.Count == 0) return;

            foreach (ResultLabTest result in results)
            {
                TreeNode node = new TreeNode(result.Name);
                node.Tag = result;
                FillTree(result.SubResults, node);
                parent.Nodes.Add(node);
            }
        }

        private void treLabTests_AfterSelect(object sender, TreeViewEventArgs e)
        {
            txtResult.Enabled = false;
            if (e.Node.Tag is null)
            {
                return;
            }

            ResultLabTest result = (ResultLabTest)e.Node.Tag;
            if (result.SubResults is null || result.SubResults.Count == 0)
            {
                txtResult.Enabled = true;

            }
        }
    }
}
