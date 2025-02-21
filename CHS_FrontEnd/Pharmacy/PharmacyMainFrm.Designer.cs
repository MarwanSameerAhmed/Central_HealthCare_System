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
            this.guna2ContainerControl5 = new Guna.UI2.WinForms.Guna2ContainerControl();
            this.patientAgeLabel = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.patientGenderLabel = new System.Windows.Forms.Label();
            this.patientNameLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.patientDataLabel = new System.Windows.Forms.Label();
            this.guna2ContainerControl1 = new Guna.UI2.WinForms.Guna2ContainerControl();
            this.nationalSearchtxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.orLabel2 = new System.Windows.Forms.Label();
            this.phoneSearchtxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.orLabel = new System.Windows.Forms.Label();
            this.midSearchtxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.searchForpatientLabel = new System.Windows.Forms.Label();
            this.guna2ContainerControl4 = new Guna.UI2.WinForms.Guna2ContainerControl();
            this.guna2VScrollBar1 = new Guna.UI2.WinForms.Guna2VScrollBar();
            this.medicineStateGridView = new Guna.UI2.WinForms.Guna2DataGridView();
            this.exchangeStatus = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.numberOfDoses = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medicineName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medicineID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guna2ContainerControl3.SuspendLayout();
            this.guna2ContainerControl5.SuspendLayout();
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
            this.guna2ContainerControl3.Location = new System.Drawing.Point(19, 12);
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
            // guna2ContainerControl5
            // 
            this.guna2ContainerControl5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.guna2ContainerControl5.BorderRadius = 15;
            this.guna2ContainerControl5.Controls.Add(this.patientAgeLabel);
            this.guna2ContainerControl5.Controls.Add(this.label17);
            this.guna2ContainerControl5.Controls.Add(this.patientGenderLabel);
            this.guna2ContainerControl5.Controls.Add(this.patientNameLabel);
            this.guna2ContainerControl5.Controls.Add(this.label4);
            this.guna2ContainerControl5.Controls.Add(this.label19);
            this.guna2ContainerControl5.Controls.Add(this.patientDataLabel);
            this.guna2ContainerControl5.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(249)))));
            this.guna2ContainerControl5.Location = new System.Drawing.Point(16, 202);
            this.guna2ContainerControl5.Name = "guna2ContainerControl5";
            this.guna2ContainerControl5.Size = new System.Drawing.Size(1411, 147);
            this.guna2ContainerControl5.TabIndex = 38;
            this.guna2ContainerControl5.Text = "الاسم الكامل ";
            // 
            // patientAgeLabel
            // 
            this.patientAgeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.patientAgeLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(249)))));
            this.patientAgeLabel.Font = new System.Drawing.Font("Traditional Arabic", 10.8F, System.Drawing.FontStyle.Bold);
            this.patientAgeLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.patientAgeLabel.Location = new System.Drawing.Point(1230, 109);
            this.patientAgeLabel.Name = "patientAgeLabel";
            this.patientAgeLabel.Size = new System.Drawing.Size(156, 40);
            this.patientAgeLabel.TabIndex = 37;
            this.patientAgeLabel.Text = "العمر";
            this.patientAgeLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(249)))));
            this.label17.Font = new System.Drawing.Font("Traditional Arabic", 10.8F, System.Drawing.FontStyle.Bold);
            this.label17.ForeColor = System.Drawing.Color.Black;
            this.label17.Location = new System.Drawing.Point(133, 58);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(22, 27);
            this.label17.TabIndex = 36;
            this.label17.Text = "\"\"";
            // 
            // patientGenderLabel
            // 
            this.patientGenderLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.patientGenderLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(249)))));
            this.patientGenderLabel.Font = new System.Drawing.Font("Traditional Arabic", 10.8F, System.Drawing.FontStyle.Bold);
            this.patientGenderLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.patientGenderLabel.Location = new System.Drawing.Point(525, 58);
            this.patientGenderLabel.Name = "patientGenderLabel";
            this.patientGenderLabel.Size = new System.Drawing.Size(151, 43);
            this.patientGenderLabel.TabIndex = 35;
            this.patientGenderLabel.Text = "الجنس";
            this.patientGenderLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // patientNameLabel
            // 
            this.patientNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.patientNameLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(249)))));
            this.patientNameLabel.Font = new System.Drawing.Font("Traditional Arabic", 10.8F, System.Drawing.FontStyle.Bold);
            this.patientNameLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.patientNameLabel.Location = new System.Drawing.Point(1244, 63);
            this.patientNameLabel.Name = "patientNameLabel";
            this.patientNameLabel.Size = new System.Drawing.Size(142, 33);
            this.patientNameLabel.TabIndex = 34;
            this.patientNameLabel.Text = "اسم المريض";
            this.patientNameLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(249)))));
            this.label4.Font = new System.Drawing.Font("Traditional Arabic", 10.8F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(885, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 27);
            this.label4.TabIndex = 32;
            this.label4.Text = "\"\"";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(249)))));
            this.label19.Font = new System.Drawing.Font("Traditional Arabic", 10.8F, System.Drawing.FontStyle.Bold);
            this.label19.ForeColor = System.Drawing.Color.Black;
            this.label19.Location = new System.Drawing.Point(885, 109);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(22, 27);
            this.label19.TabIndex = 32;
            this.label19.Text = "\"\"";
            // 
            // patientDataLabel
            // 
            this.patientDataLabel.AutoSize = true;
            this.patientDataLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(249)))));
            this.patientDataLabel.Dock = System.Windows.Forms.DockStyle.Right;
            this.patientDataLabel.Font = new System.Drawing.Font("Traditional Arabic", 13.8F, System.Drawing.FontStyle.Bold);
            this.patientDataLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(87)))), ((int)(((byte)(155)))));
            this.patientDataLabel.Location = new System.Drawing.Point(1278, 0);
            this.patientDataLabel.Name = "patientDataLabel";
            this.patientDataLabel.Padding = new System.Windows.Forms.Padding(16, 22, 16, 22);
            this.patientDataLabel.Size = new System.Drawing.Size(133, 80);
            this.patientDataLabel.TabIndex = 6;
            this.patientDataLabel.Text = "بيانات المريض";
            // 
            // guna2ContainerControl1
            // 
            this.guna2ContainerControl1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.guna2ContainerControl1.BackColor = System.Drawing.Color.White;
            this.guna2ContainerControl1.BorderRadius = 15;
            this.guna2ContainerControl1.Controls.Add(this.nationalSearchtxt);
            this.guna2ContainerControl1.Controls.Add(this.orLabel2);
            this.guna2ContainerControl1.Controls.Add(this.phoneSearchtxt);
            this.guna2ContainerControl1.Controls.Add(this.orLabel);
            this.guna2ContainerControl1.Controls.Add(this.midSearchtxt);
            this.guna2ContainerControl1.Controls.Add(this.searchForpatientLabel);
            this.guna2ContainerControl1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(249)))));
            this.guna2ContainerControl1.Location = new System.Drawing.Point(14, 74);
            this.guna2ContainerControl1.Name = "guna2ContainerControl1";
            this.guna2ContainerControl1.Size = new System.Drawing.Size(1411, 120);
            this.guna2ContainerControl1.TabIndex = 37;
            this.guna2ContainerControl1.Text = "guna2ContainerControl1";
            // 
            // nationalSearchtxt
            // 
            this.nationalSearchtxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nationalSearchtxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(249)))));
            this.nationalSearchtxt.BorderRadius = 10;
            this.nationalSearchtxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nationalSearchtxt.DefaultText = "رقم الهوية";
            this.nationalSearchtxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.nationalSearchtxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.nationalSearchtxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.nationalSearchtxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.nationalSearchtxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.nationalSearchtxt.Font = new System.Drawing.Font("Traditional Arabic", 12F, System.Drawing.FontStyle.Bold);
            this.nationalSearchtxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.nationalSearchtxt.Location = new System.Drawing.Point(344, 58);
            this.nationalSearchtxt.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.nationalSearchtxt.Name = "nationalSearchtxt";
            this.nationalSearchtxt.PasswordChar = '\0';
            this.nationalSearchtxt.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.nationalSearchtxt.PlaceholderText = "";
            this.nationalSearchtxt.SelectedText = "";
            this.nationalSearchtxt.Size = new System.Drawing.Size(319, 48);
            this.nationalSearchtxt.TabIndex = 5;
            this.nationalSearchtxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // orLabel2
            // 
            this.orLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.orLabel2.AutoSize = true;
            this.orLabel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(249)))));
            this.orLabel2.Font = new System.Drawing.Font("Traditional Arabic", 12F);
            this.orLabel2.ForeColor = System.Drawing.Color.Black;
            this.orLabel2.Location = new System.Drawing.Point(674, 70);
            this.orLabel2.Name = "orLabel2";
            this.orLabel2.Size = new System.Drawing.Size(24, 32);
            this.orLabel2.TabIndex = 4;
            this.orLabel2.Text = "او";
            // 
            // phoneSearchtxt
            // 
            this.phoneSearchtxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.phoneSearchtxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(249)))));
            this.phoneSearchtxt.BorderRadius = 10;
            this.phoneSearchtxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.phoneSearchtxt.DefaultText = "رقم الهاتف";
            this.phoneSearchtxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.phoneSearchtxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.phoneSearchtxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.phoneSearchtxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.phoneSearchtxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.phoneSearchtxt.Font = new System.Drawing.Font("Traditional Arabic", 12F, System.Drawing.FontStyle.Bold);
            this.phoneSearchtxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.phoneSearchtxt.Location = new System.Drawing.Point(709, 58);
            this.phoneSearchtxt.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.phoneSearchtxt.Name = "phoneSearchtxt";
            this.phoneSearchtxt.PasswordChar = '\0';
            this.phoneSearchtxt.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.phoneSearchtxt.PlaceholderText = "";
            this.phoneSearchtxt.SelectedText = "";
            this.phoneSearchtxt.Size = new System.Drawing.Size(319, 48);
            this.phoneSearchtxt.TabIndex = 3;
            this.phoneSearchtxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // orLabel
            // 
            this.orLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.orLabel.AutoSize = true;
            this.orLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(249)))));
            this.orLabel.Font = new System.Drawing.Font("Traditional Arabic", 12F);
            this.orLabel.ForeColor = System.Drawing.Color.Black;
            this.orLabel.Location = new System.Drawing.Point(1041, 67);
            this.orLabel.Name = "orLabel";
            this.orLabel.Size = new System.Drawing.Size(24, 32);
            this.orLabel.TabIndex = 2;
            this.orLabel.Text = "او";
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
            this.midSearchtxt.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.midSearchtxt.Name = "midSearchtxt";
            this.midSearchtxt.PasswordChar = '\0';
            this.midSearchtxt.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.midSearchtxt.PlaceholderText = "الرقم الطبي";
            this.midSearchtxt.SelectedText = "";
            this.midSearchtxt.Size = new System.Drawing.Size(319, 48);
            this.midSearchtxt.TabIndex = 1;
            this.midSearchtxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
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
            this.guna2ContainerControl4.Location = new System.Drawing.Point(16, 358);
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
            this.numberOfDoses,
            this.orderDate,
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
            // 
            // exchangeStatus
            // 
            this.exchangeStatus.HeaderText = "حالة الصرف";
            this.exchangeStatus.MinimumWidth = 8;
            this.exchangeStatus.Name = "exchangeStatus";
            this.exchangeStatus.ReadOnly = true;
            // 
            // numberOfDoses
            // 
            this.numberOfDoses.HeaderText = "عدد الجرع";
            this.numberOfDoses.MinimumWidth = 8;
            this.numberOfDoses.Name = "numberOfDoses";
            this.numberOfDoses.ReadOnly = true;
            // 
            // orderDate
            // 
            this.orderDate.HeaderText = "تاريخ الطلب";
            this.orderDate.MinimumWidth = 8;
            this.orderDate.Name = "orderDate";
            this.orderDate.ReadOnly = true;
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
            this.medicineID.MinimumWidth = 8;
            this.medicineID.Name = "medicineID";
            // 
            // PharmacyMainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1509, 890);
            this.Controls.Add(this.guna2ContainerControl4);
            this.Controls.Add(this.guna2ContainerControl5);
            this.Controls.Add(this.guna2ContainerControl1);
            this.Controls.Add(this.guna2ContainerControl3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "PharmacyMainFrm";
            this.Text = "PharmacyMainFrm";
            this.Load += new System.EventHandler(this.PharmacyMainFrm_Load);
            this.guna2ContainerControl3.ResumeLayout(false);
            this.guna2ContainerControl3.PerformLayout();
            this.guna2ContainerControl5.ResumeLayout(false);
            this.guna2ContainerControl5.PerformLayout();
            this.guna2ContainerControl1.ResumeLayout(false);
            this.guna2ContainerControl1.PerformLayout();
            this.guna2ContainerControl4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.medicineStateGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ContainerControl guna2ContainerControl3;
        private System.Windows.Forms.Label pharmacyHeader;
        private Guna.UI2.WinForms.Guna2ContainerControl guna2ContainerControl5;
        private System.Windows.Forms.Label patientAgeLabel;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label patientGenderLabel;
        private System.Windows.Forms.Label patientNameLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label patientDataLabel;
        private Guna.UI2.WinForms.Guna2ContainerControl guna2ContainerControl1;
        private Guna.UI2.WinForms.Guna2TextBox nationalSearchtxt;
        private System.Windows.Forms.Label orLabel2;
        private Guna.UI2.WinForms.Guna2TextBox phoneSearchtxt;
        private System.Windows.Forms.Label orLabel;
        private Guna.UI2.WinForms.Guna2TextBox midSearchtxt;
        private System.Windows.Forms.Label searchForpatientLabel;
        private Guna.UI2.WinForms.Guna2ContainerControl guna2ContainerControl4;
        private Guna.UI2.WinForms.Guna2VScrollBar guna2VScrollBar1;
        private Guna.UI2.WinForms.Guna2DataGridView medicineStateGridView;
        private System.Windows.Forms.DataGridViewCheckBoxColumn exchangeStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberOfDoses;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn medicineName;
        private System.Windows.Forms.DataGridViewTextBoxColumn medicineID;
    }
}