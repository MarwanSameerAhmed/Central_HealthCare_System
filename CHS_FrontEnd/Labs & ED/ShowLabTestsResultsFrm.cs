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
    public partial class ShowLabTestsResultsFrm : Form
    {
        public ShowLabTestsResultsFrm(long PatientDiagnosisNumber)
        {
            InitializeComponent();

            try
            {
                ResultLabTestRequest request = new ResultLabTestRequest
                {
                    PatientDiagnosisNumber = PatientDiagnosisNumber,
                    RequestID = Guid.NewGuid().ToString()
                };
                ResultLabTestRespons response = RequestSender.SendRequest<ResultLabTestRequest, ResultLabTestRespons>(request);
                TreeNode root = new TreeNode("Lab tests");
                FillTree(response.Results, root);
                labTestResultsTre.Nodes.Add(root);
                labTestResultsTre.ExpandAll();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FillTree(List<ResultLabTest> results, TreeNode parent)
        {
            if (results is null || results.Count == 0) return;

            foreach (ResultLabTest result in results)
            {
                string nodeText = result.Name;
                if (result.SubResults is null)
                {
                    nodeText += ": " + result.Value;
                }
                TreeNode node = new TreeNode(nodeText);
                node.Tag = result;
                FillTree(result.SubResults, node);
                parent.Nodes.Add(node);
            }
        }
    }
}
