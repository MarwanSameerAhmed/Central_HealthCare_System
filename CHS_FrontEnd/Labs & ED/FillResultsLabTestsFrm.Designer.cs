
namespace CHS_FrontEnd.Labs___ED
{
    partial class FillResultsLabTestsFrm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.treLabTests = new System.Windows.Forms.TreeView();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.patientDiagnosisNumber = new System.Windows.Forms.TextBox();
            this.lbl = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // treLabTests
            // 
            this.treLabTests.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.treLabTests.Location = new System.Drawing.Point(0, 143);
            this.treLabTests.Name = "treLabTests";
            this.treLabTests.Size = new System.Drawing.Size(800, 307);
            this.treLabTests.TabIndex = 0;
            this.treLabTests.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treLabTests_AfterSelect);
            // 
            // txtResult
            // 
            this.txtResult.Enabled = false;
            this.txtResult.Location = new System.Drawing.Point(62, 121);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(119, 20);
            this.txtResult.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "result";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Turquoise;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(800, 47);
            this.label2.TabIndex = 3;
            this.label2.Text = "تعبئة نتائج الفحص";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // patientDiagnosisNumber
            // 
            this.patientDiagnosisNumber.Location = new System.Drawing.Point(198, 64);
            this.patientDiagnosisNumber.Name = "patientDiagnosisNumber";
            this.patientDiagnosisNumber.Size = new System.Drawing.Size(119, 20);
            this.patientDiagnosisNumber.TabIndex = 1;
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.Location = new System.Drawing.Point(1, 65);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(191, 17);
            this.lbl.TabIndex = 2;
            this.lbl.Text = "patient diagnosis number";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(339, 60);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // FillResultsLabTestsFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.patientDiagnosisNumber);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.treLabTests);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FillResultsLabTestsFrm";
            this.Text = "تعبئة نتائج الفحص";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treLabTests;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox patientDiagnosisNumber;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Button btnSearch;
    }
}