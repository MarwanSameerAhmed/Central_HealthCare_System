
namespace CHS_FrontEnd
{
    partial class QrFrm
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
            this.pcb = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pcb)).BeginInit();
            this.SuspendLayout();
            // 
            // pcb
            // 
            this.pcb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pcb.Location = new System.Drawing.Point(0, 0);
            this.pcb.Margin = new System.Windows.Forms.Padding(4);
            this.pcb.Name = "pcb";
            this.pcb.Size = new System.Drawing.Size(377, 351);
            this.pcb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcb.TabIndex = 0;
            this.pcb.TabStop = false;
            // 
            // QrFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 351);
            this.Controls.Add(this.pcb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "QrFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Deactivate += new System.EventHandler(this.QrFrm_Deactivate);
            this.Load += new System.EventHandler(this.QrFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcb)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pcb;
    }
}