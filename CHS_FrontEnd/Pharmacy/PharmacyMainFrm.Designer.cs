namespace CHS_FrontEnd.Pharmacy
{
    partial class PharmacyMainFrm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2ContainerControl3 = new Guna.UI2.WinForms.Guna2ContainerControl();
            this.pharmacyHeader = new System.Windows.Forms.Label();
            this.guna2ContainerControl1 = new Guna.UI2.WinForms.Guna2ContainerControl();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.searchBtn = new Guna.UI2.WinForms.Guna2Button();
            this.midSearchtxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.searchForpatientLabel = new System.Windows.Forms.Label();
            this.guna2ContainerControl4 = new Guna.UI2.WinForms.Guna2ContainerControl();
            this.guna2VScrollBar1 = new Guna.UI2.WinForms.Guna2VScrollBar();
            this.medicineStateGridView = new Guna.UI2.WinForms.Guna2DataGridView();
            this.exchangeStatus = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dosageTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dosageDuration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dose = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dosageForm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.activeIngredient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medicineName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medicineID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guna2ContainerControl3.SuspendLayout();
            this.guna2ContainerControl1.SuspendLayout();
            this.guna2ContainerControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.medicineStateGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2ContainerControl3
            // 
            this.guna2ContainerControl3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.guna2ContainerControl3.BorderRadius = 15;
            this.guna2ContainerControl3.Controls.Add(this.pharmacyHeader);
            this.guna2ContainerControl3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(77)))), ((int)(((byte)(146)))));
            this.guna2ContainerControl3.Location = new System.Drawing.Point(14, 15);
            this.guna2ContainerControl3.Name = "guna2ContainerControl3";
            this.guna2ContainerControl3.Size = new System.Drawing.Size(1411, 51);
            this.guna2ContainerControl3.TabIndex = 7;
            this.guna2ContainerControl3.Text = "guna2ContainerControl3";
            // 
            // pharmacyHeader
            // 
            this.pharmacyHeader.AutoSize = true;
            this.pharmacyHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(77)))), ((int)(((byte)(146)))));
            this.pharmacyHeader.Font = new System.Drawing.Font("Traditional Arabic", 19.8F, System.Drawing.FontStyle.Bold);
            this.pharmacyHeader.ForeColor = System.Drawing.Color.White;
            this.pharmacyHeader.Location = new System.Drawing.Point(586, 1);
            this.pharmacyHeader.Name = "pharmacyHeader";
            this.pharmacyHeader.Size = new System.Drawing.Size(240, 52);
            this.pharmacyHeader.TabIndex = 0;
            this.pharmacyHeader.Text = "البحث عن أدوية مريض ";
            this.pharmacyHeader.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // guna2ContainerControl1
            // 
            this.guna2ContainerControl1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.guna2ContainerControl1.BackColor = System.Drawing.Color.White;
            this.guna2ContainerControl1.BorderRadius = 15;
            this.guna2ContainerControl1.Controls.Add(this.btnSave);
            this.guna2ContainerControl1.Controls.Add(this.searchBtn);
            this.guna2ContainerControl1.Controls.Add(this.midSearchtxt);
            this.guna2ContainerControl1.Controls.Add(this.searchForpatientLabel);
            this.guna2ContainerControl1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(249)))));
            this.guna2ContainerControl1.Location = new System.Drawing.Point(14, 74);
            this.guna2ContainerControl1.Name = "guna2ContainerControl1";
            this.guna2ContainerControl1.Size = new System.Drawing.Size(1411, 120);
            this.guna2ContainerControl1.TabIndex = 37;
            this.guna2ContainerControl1.Text = "guna2ContainerControl1";
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSave.BorderRadius = 15;
            this.btnSave.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSave.Enabled = false;
            this.btnSave.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(77)))), ((int)(((byte)(146)))));
            this.btnSave.Font = new System.Drawing.Font("Traditional Arabic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(571, 56);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(232, 49);
            this.btnSave.TabIndex = 41;
            this.btnSave.Text = "حفظ";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // searchBtn
            // 
            this.searchBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.searchBtn.BorderRadius = 15;
            this.searchBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.searchBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.searchBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.searchBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.searchBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(77)))), ((int)(((byte)(146)))));
            this.searchBtn.Font = new System.Drawing.Font("Traditional Arabic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBtn.ForeColor = System.Drawing.Color.White;
            this.searchBtn.Location = new System.Drawing.Point(810, 58);
            this.searchBtn.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(232, 49);
            this.searchBtn.TabIndex = 41;
            this.searchBtn.Text = "بحث";
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // midSearchtxt
            // 
            this.midSearchtxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.midSearchtxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(249)))));
            this.midSearchtxt.BorderRadius = 10;
            this.midSearchtxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.midSearchtxt.DefaultText = "";
            this.midSearchtxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.midSearchtxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.midSearchtxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.midSearchtxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.midSearchtxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.midSearchtxt.Font = new System.Drawing.Font("Traditional Arabic", 10.8F, System.Drawing.FontStyle.Bold);
            this.midSearchtxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.midSearchtxt.Location = new System.Drawing.Point(1076, 58);
            this.midSearchtxt.Margin = new System.Windows.Forms.Padding(5);
            this.midSearchtxt.Name = "midSearchtxt";
            this.midSearchtxt.PasswordChar = '\0';
            this.midSearchtxt.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.midSearchtxt.PlaceholderText = "رقم التشخيص";
            this.midSearchtxt.SelectedText = "";
            this.midSearchtxt.Size = new System.Drawing.Size(319, 48);
            this.midSearchtxt.TabIndex = 1;
            this.midSearchtxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.midSearchtxt.TextChanged += new System.EventHandler(this.midSearchtxt_TextChanged);
            // 
            // searchForpatientLabel
            // 
            this.searchForpatientLabel.AutoSize = true;
            this.searchForpatientLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(249)))));
            this.searchForpatientLabel.Dock = System.Windows.Forms.DockStyle.Right;
            this.searchForpatientLabel.Font = new System.Drawing.Font("Traditional Arabic", 13.8F, System.Drawing.FontStyle.Bold);
            this.searchForpatientLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(77)))), ((int)(((byte)(146)))));
            this.searchForpatientLabel.Location = new System.Drawing.Point(1264, 0);
            this.searchForpatientLabel.Name = "searchForpatientLabel";
            this.searchForpatientLabel.Padding = new System.Windows.Forms.Padding(16, 15, 16, 15);
            this.searchForpatientLabel.Size = new System.Drawing.Size(147, 66);
            this.searchForpatientLabel.TabIndex = 0;
            this.searchForpatientLabel.Text = "ابحث عن مريض";
            this.searchForpatientLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // guna2ContainerControl4
            // 
            this.guna2ContainerControl4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.guna2ContainerControl4.BorderRadius = 15;
            this.guna2ContainerControl4.Controls.Add(this.guna2VScrollBar1);
            this.guna2ContainerControl4.Controls.Add(this.medicineStateGridView);
            this.guna2ContainerControl4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(77)))), ((int)(((byte)(146)))));
            this.guna2ContainerControl4.Location = new System.Drawing.Point(16, 355);
            this.guna2ContainerControl4.Name = "guna2ContainerControl4";
            this.guna2ContainerControl4.Size = new System.Drawing.Size(1412, 399);
            this.guna2ContainerControl4.TabIndex = 40;
            this.guna2ContainerControl4.Text = "guna2ContainerControl4";
            // 
            // guna2VScrollBar1
            // 
            this.guna2VScrollBar1.InUpdate = false;
            this.guna2VScrollBar1.LargeChange = 10;
            this.guna2VScrollBar1.Location = new System.Drawing.Point(1380, 51);
            this.guna2VScrollBar1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.guna2VScrollBar1.Name = "guna2VScrollBar1";
            this.guna2VScrollBar1.ScrollbarSize = 16;
            this.guna2VScrollBar1.Size = new System.Drawing.Size(16, 333);
            this.guna2VScrollBar1.TabIndex = 8;
            // 
            // medicineStateGridView
            // 
            this.medicineStateGridView.AllowUserToAddRows = false;
            this.medicineStateGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.medicineStateGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.medicineStateGridView.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.medicineStateGridView.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(77)))), ((int)(((byte)(146)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(77)))), ((int)(((byte)(146)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.medicineStateGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.medicineStateGridView.ColumnHeadersHeight = 40;
            this.medicineStateGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.medicineStateGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.exchangeStatus,
            this.dosageTime,
            this.dosageDuration,
            this.dose,
            this.dosageForm,
            this.activeIngredient,
            this.medicineName,
            this.medicineID});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.medicineStateGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.medicineStateGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.medicineStateGridView.Location = new System.Drawing.Point(17, 16);
            this.medicineStateGridView.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.medicineStateGridView.Name = "medicineStateGridView";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Traditional Arabic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.medicineStateGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.medicineStateGridView.RowHeadersVisible = false;
            this.medicineStateGridView.RowHeadersWidth = 62;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.medicineStateGridView.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.medicineStateGridView.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.medicineStateGridView.RowTemplate.Height = 29;
            this.medicineStateGridView.RowTemplate.ReadOnly = true;
            this.medicineStateGridView.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.medicineStateGridView.Size = new System.Drawing.Size(1379, 368);
            this.medicineStateGridView.TabIndex = 7;
            this.medicineStateGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.medicineStateGridView.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.medicineStateGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.medicineStateGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.medicineStateGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.medicineStateGridView.ThemeStyle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.medicineStateGridView.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.medicineStateGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.medicineStateGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.medicineStateGridView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Tahoma", 8F);
            this.medicineStateGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.medicineStateGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.medicineStateGridView.ThemeStyle.HeaderStyle.Height = 40;
            this.medicineStateGridView.ThemeStyle.ReadOnly = false;
            this.medicineStateGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.medicineStateGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.medicineStateGridView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Tahoma", 8F);
            this.medicineStateGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.medicineStateGridView.ThemeStyle.RowsStyle.Height = 29;
            this.medicineStateGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.medicineStateGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.medicineStateGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.medicineStateGridView_CellDoubleClick_1);
            // 
            // exchangeStatus
            // 
            this.exchangeStatus.HeaderText = "حالة الصرف";
            this.exchangeStatus.MinimumWidth = 2;
            this.exchangeStatus.Name = "exchangeStatus";
            this.exchangeStatus.ReadOnly = true;
            // 
            // dosageTime
            // 
            this.dosageTime.HeaderText = "وقت الجرعة";
            this.dosageTime.MinimumWidth = 8;
            this.dosageTime.Name = "dosageTime";
            // 
            // dosageDuration
            // 
            this.dosageDuration.HeaderText = "مدة الاستخدام";
            this.dosageDuration.MinimumWidth = 8;
            this.dosageDuration.Name = "dosageDuration";
            // 
            // dose
            // 
            this.dose.HeaderText = "الجرعة";
            this.dose.MinimumWidth = 6;
            this.dose.Name = "dose";
            this.dose.ReadOnly = true;
            // 
            // dosageForm
            // 
            this.dosageForm.HeaderText = "شكل الجرعة";
            this.dosageForm.MinimumWidth = 6;
            this.dosageForm.Name = "dosageForm";
            // 
            // activeIngredient
            // 
            this.activeIngredient.HeaderText = "المادة الفعالة";
            this.activeIngredient.MinimumWidth = 6;
            this.activeIngredient.Name = "activeIngredient";
            this.activeIngredient.ReadOnly = true;
            // 
            // medicineName
            // 
            this.medicineName.HeaderText = "اسم الدواء";
            this.medicineName.MinimumWidth = 8;
            this.medicineName.Name = "medicineName";
            this.medicineName.ReadOnly = true;
            // 
            // medicineID
            // 
            this.medicineID.HeaderText = "رقم الدواء";
            this.medicineID.MinimumWidth = 4;
            this.medicineID.Name = "medicineID";
            // 
            // PharmacyMainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1459, 890);
            this.Controls.Add(this.guna2ContainerControl4);
            this.Controls.Add(this.guna2ContainerControl1);
            this.Controls.Add(this.guna2ContainerControl3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "PharmacyMainFrm";
            this.Text = "PharmacyMainFrm";
            this.Load += new System.EventHandler(this.PharmacyMainFrm_Load);
            this.guna2ContainerControl3.ResumeLayout(false);
            this.guna2ContainerControl3.PerformLayout();
            this.guna2ContainerControl1.ResumeLayout(false);
            this.guna2ContainerControl1.PerformLayout();
            this.guna2ContainerControl4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.medicineStateGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ContainerControl guna2ContainerControl3;
        private System.Windows.Forms.Label pharmacyHeader;
        private Guna.UI2.WinForms.Guna2ContainerControl guna2ContainerControl1;
        private Guna.UI2.WinForms.Guna2TextBox midSearchtxt;
        private System.Windows.Forms.Label searchForpatientLabel;
        private Guna.UI2.WinForms.Guna2ContainerControl guna2ContainerControl4;
        private Guna.UI2.WinForms.Guna2VScrollBar guna2VScrollBar1;
        private Guna.UI2.WinForms.Guna2DataGridView medicineStateGridView;
        private Guna.UI2.WinForms.Guna2Button searchBtn;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private System.Windows.Forms.DataGridViewCheckBoxColumn exchangeStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn dosageTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn dosageDuration;
        private System.Windows.Forms.DataGridViewTextBoxColumn dose;
        private System.Windows.Forms.DataGridViewTextBoxColumn dosageForm;
        private System.Windows.Forms.DataGridViewTextBoxColumn activeIngredient;
        private System.Windows.Forms.DataGridViewTextBoxColumn medicineName;
        private System.Windows.Forms.DataGridViewTextBoxColumn medicineID;
    }
}