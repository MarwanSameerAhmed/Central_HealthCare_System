namespace CHS_FrontEnd
{
    partial class searchDoctor
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2ContainerControl2 = new Guna.UI2.WinForms.Guna2ContainerControl();
            this.guna2VScrollBar1 = new Guna.UI2.WinForms.Guna2VScrollBar();
            this.searchDoctorView = new Guna.UI2.WinForms.Guna2DataGridView();
            this.guna2ContainerControl1 = new Guna.UI2.WinForms.Guna2ContainerControl();
            this.IdNumber = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.phoneSearchtxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.NameSearchtxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2ContainerControl3 = new Guna.UI2.WinForms.Guna2ContainerControl();
            this.label10 = new System.Windows.Forms.Label();
            this.searchBtn = new Guna.UI2.WinForms.Guna2Button();
            this.doctorName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doctorPhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doctorMiagor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doctorNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guna2ContainerControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchDoctorView)).BeginInit();
            this.guna2ContainerControl1.SuspendLayout();
            this.guna2ContainerControl3.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2ContainerControl2
            // 
            this.guna2ContainerControl2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.guna2ContainerControl2.BorderRadius = 15;
            this.guna2ContainerControl2.Controls.Add(this.guna2VScrollBar1);
            this.guna2ContainerControl2.Controls.Add(this.searchDoctorView);
            this.guna2ContainerControl2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(77)))), ((int)(((byte)(146)))));
            this.guna2ContainerControl2.Location = new System.Drawing.Point(66, 204);
            this.guna2ContainerControl2.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.guna2ContainerControl2.Name = "guna2ContainerControl2";
            this.guna2ContainerControl2.Size = new System.Drawing.Size(1594, 470);
            this.guna2ContainerControl2.TabIndex = 40;
            this.guna2ContainerControl2.Text = "guna2ContainerControl2";
            // 
            // guna2VScrollBar1
            // 
            this.guna2VScrollBar1.InUpdate = false;
            this.guna2VScrollBar1.LargeChange = 10;
            this.guna2VScrollBar1.Location = new System.Drawing.Point(1560, 58);
            this.guna2VScrollBar1.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.guna2VScrollBar1.Maximum = 99;
            this.guna2VScrollBar1.Name = "guna2VScrollBar1";
            this.guna2VScrollBar1.ScrollbarSize = 18;
            this.guna2VScrollBar1.Size = new System.Drawing.Size(18, 393);
            this.guna2VScrollBar1.TabIndex = 6;
            this.guna2VScrollBar1.ThumbColor = System.Drawing.Color.DarkGray;
            this.guna2VScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.guna2VScrollBar1_Scroll);
            // 
            // searchDoctorView
            // 
            this.searchDoctorView.AllowUserToAddRows = false;
            this.searchDoctorView.AllowUserToDeleteRows = false;
            this.searchDoctorView.AllowUserToResizeColumns = false;
            this.searchDoctorView.AllowUserToResizeRows = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            this.searchDoctorView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.searchDoctorView.Anchor = System.Windows.Forms.AnchorStyles.Top;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(77)))), ((int)(((byte)(146)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(77)))), ((int)(((byte)(146)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.searchDoctorView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.searchDoctorView.ColumnHeadersHeight = 40;
            this.searchDoctorView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.doctorName,
            this.doctorPhoneNumber,
            this.doctorMiagor,
            this.doctorNumber});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.searchDoctorView.DefaultCellStyle = dataGridViewCellStyle8;
            this.searchDoctorView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.searchDoctorView.GridColor = System.Drawing.Color.Gray;
            this.searchDoctorView.Location = new System.Drawing.Point(17, 18);
            this.searchDoctorView.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.searchDoctorView.Name = "searchDoctorView";
            this.searchDoctorView.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.searchDoctorView.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.searchDoctorView.RowHeadersVisible = false;
            this.searchDoctorView.RowHeadersWidth = 51;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.searchDoctorView.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.searchDoctorView.RowTemplate.Height = 40;
            this.searchDoctorView.RowTemplate.ReadOnly = true;
            this.searchDoctorView.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.searchDoctorView.Size = new System.Drawing.Size(1561, 433);
            this.searchDoctorView.TabIndex = 0;
            this.searchDoctorView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.searchDoctorView.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("Traditional Arabic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchDoctorView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.searchDoctorView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.searchDoctorView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.searchDoctorView.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.searchDoctorView.ThemeStyle.GridColor = System.Drawing.Color.Gray;
            this.searchDoctorView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(77)))), ((int)(((byte)(146)))));
            this.searchDoctorView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.searchDoctorView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Snap ITC", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchDoctorView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.searchDoctorView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.searchDoctorView.ThemeStyle.HeaderStyle.Height = 40;
            this.searchDoctorView.ThemeStyle.ReadOnly = true;
            this.searchDoctorView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.searchDoctorView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.searchDoctorView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Tahoma", 8F);
            this.searchDoctorView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.searchDoctorView.ThemeStyle.RowsStyle.Height = 40;
            this.searchDoctorView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.searchDoctorView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.searchDoctorView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.searchDoctorView_CellDoubleClick);
            // 
            // guna2ContainerControl1
            // 
            this.guna2ContainerControl1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.guna2ContainerControl1.BackColor = System.Drawing.Color.White;
            this.guna2ContainerControl1.BorderRadius = 15;
            this.guna2ContainerControl1.Controls.Add(this.searchBtn);
            this.guna2ContainerControl1.Controls.Add(this.IdNumber);
            this.guna2ContainerControl1.Controls.Add(this.label3);
            this.guna2ContainerControl1.Controls.Add(this.phoneSearchtxt);
            this.guna2ContainerControl1.Controls.Add(this.label2);
            this.guna2ContainerControl1.Controls.Add(this.NameSearchtxt);
            this.guna2ContainerControl1.Controls.Add(this.label1);
            this.guna2ContainerControl1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(249)))));
            this.guna2ContainerControl1.Location = new System.Drawing.Point(66, 71);
            this.guna2ContainerControl1.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.guna2ContainerControl1.Name = "guna2ContainerControl1";
            this.guna2ContainerControl1.Size = new System.Drawing.Size(1594, 121);
            this.guna2ContainerControl1.TabIndex = 39;
            this.guna2ContainerControl1.Text = "guna2ContainerControl1";
            // 
            // IdNumber
            // 
            this.IdNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.IdNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(249)))));
            this.IdNumber.BorderRadius = 10;
            this.IdNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.IdNumber.DefaultText = "";
            this.IdNumber.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.IdNumber.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.IdNumber.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.IdNumber.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.IdNumber.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.IdNumber.Font = new System.Drawing.Font("Traditional Arabic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdNumber.ForeColor = System.Drawing.SystemColors.WindowText;
            this.IdNumber.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.IdNumber.Location = new System.Drawing.Point(386, 64);
            this.IdNumber.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.IdNumber.Name = "IdNumber";
            this.IdNumber.PasswordChar = '\0';
            this.IdNumber.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.IdNumber.PlaceholderText = "رقم الوظيفي";
            this.IdNumber.SelectedText = "";
            this.IdNumber.Size = new System.Drawing.Size(374, 40);
            this.IdNumber.TabIndex = 5;
            this.IdNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(249)))));
            this.label3.Font = new System.Drawing.Font("Traditional Arabic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(764, 77);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 27);
            this.label3.TabIndex = 4;
            this.label3.Text = "او";
            // 
            // phoneSearchtxt
            // 
            this.phoneSearchtxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.phoneSearchtxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(249)))));
            this.phoneSearchtxt.BorderRadius = 10;
            this.phoneSearchtxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.phoneSearchtxt.DefaultText = "";
            this.phoneSearchtxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.phoneSearchtxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.phoneSearchtxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.phoneSearchtxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.phoneSearchtxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.phoneSearchtxt.Font = new System.Drawing.Font("Traditional Arabic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneSearchtxt.ForeColor = System.Drawing.SystemColors.WindowText;
            this.phoneSearchtxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.phoneSearchtxt.Location = new System.Drawing.Point(794, 64);
            this.phoneSearchtxt.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.phoneSearchtxt.Name = "phoneSearchtxt";
            this.phoneSearchtxt.PasswordChar = '\0';
            this.phoneSearchtxt.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.phoneSearchtxt.PlaceholderText = "رقم الهاتف";
            this.phoneSearchtxt.SelectedText = "";
            this.phoneSearchtxt.Size = new System.Drawing.Size(374, 40);
            this.phoneSearchtxt.TabIndex = 3;
            this.phoneSearchtxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(249)))));
            this.label2.Font = new System.Drawing.Font("Traditional Arabic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(1172, 77);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 27);
            this.label2.TabIndex = 2;
            this.label2.Text = "او";
            // 
            // NameSearchtxt
            // 
            this.NameSearchtxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NameSearchtxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(249)))));
            this.NameSearchtxt.BorderRadius = 10;
            this.NameSearchtxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.NameSearchtxt.DefaultText = "";
            this.NameSearchtxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.NameSearchtxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.NameSearchtxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.NameSearchtxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.NameSearchtxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.NameSearchtxt.Font = new System.Drawing.Font("Traditional Arabic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameSearchtxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.NameSearchtxt.Location = new System.Drawing.Point(1204, 64);
            this.NameSearchtxt.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.NameSearchtxt.Name = "NameSearchtxt";
            this.NameSearchtxt.PasswordChar = '\0';
            this.NameSearchtxt.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.NameSearchtxt.PlaceholderText = "اسم الطبيب";
            this.NameSearchtxt.SelectedText = "";
            this.NameSearchtxt.Size = new System.Drawing.Size(374, 40);
            this.NameSearchtxt.TabIndex = 1;
            this.NameSearchtxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(249)))));
            this.label1.Font = new System.Drawing.Font("Traditional Arabic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(77)))), ((int)(((byte)(146)))));
            this.label1.Location = new System.Drawing.Point(1445, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(17, 15, 17, 15);
            this.label1.Size = new System.Drawing.Size(149, 66);
            this.label1.TabIndex = 0;
            this.label1.Text = "ابحث عن طبيب";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // guna2ContainerControl3
            // 
            this.guna2ContainerControl3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.guna2ContainerControl3.BorderRadius = 15;
            this.guna2ContainerControl3.Controls.Add(this.label10);
            this.guna2ContainerControl3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(77)))), ((int)(((byte)(146)))));
            this.guna2ContainerControl3.Location = new System.Drawing.Point(66, 5);
            this.guna2ContainerControl3.Name = "guna2ContainerControl3";
            this.guna2ContainerControl3.Size = new System.Drawing.Size(1594, 53);
            this.guna2ContainerControl3.TabIndex = 38;
            this.guna2ContainerControl3.Text = "guna2ContainerControl3";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(77)))), ((int)(((byte)(146)))));
            this.label10.Font = new System.Drawing.Font("Traditional Arabic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(699, 1);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(179, 52);
            this.label10.TabIndex = 0;
            this.label10.Text = "البحث عن طبيب";
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopCenter;
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
            this.searchBtn.Location = new System.Drawing.Point(106, 64);
            this.searchBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(199, 40);
            this.searchBtn.TabIndex = 40;
            this.searchBtn.Text = "بحث";
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // doctorName
            // 
            this.doctorName.HeaderText = "أسم الطبيب";
            this.doctorName.MinimumWidth = 6;
            this.doctorName.Name = "doctorName";
            this.doctorName.ReadOnly = true;
            // 
            // doctorPhoneNumber
            // 
            this.doctorPhoneNumber.HeaderText = "رقم الهاتف";
            this.doctorPhoneNumber.MinimumWidth = 6;
            this.doctorPhoneNumber.Name = "doctorPhoneNumber";
            this.doctorPhoneNumber.ReadOnly = true;
            // 
            // doctorMiagor
            // 
            this.doctorMiagor.HeaderText = "المسمى الوظيفي";
            this.doctorMiagor.MinimumWidth = 6;
            this.doctorMiagor.Name = "doctorMiagor";
            this.doctorMiagor.ReadOnly = true;
            // 
            // doctorNumber
            // 
            this.doctorNumber.HeaderText = "الرقم الوظيفي";
            this.doctorNumber.MinimumWidth = 6;
            this.doctorNumber.Name = "doctorNumber";
            this.doctorNumber.ReadOnly = true;
            // 
            // searchDoctor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1750, 698);
            this.Controls.Add(this.guna2ContainerControl2);
            this.Controls.Add(this.guna2ContainerControl1);
            this.Controls.Add(this.guna2ContainerControl3);
            this.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "searchDoctor";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.searchDoctor_Load);
            this.guna2ContainerControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.searchDoctorView)).EndInit();
            this.guna2ContainerControl1.ResumeLayout(false);
            this.guna2ContainerControl1.PerformLayout();
            this.guna2ContainerControl3.ResumeLayout(false);
            this.guna2ContainerControl3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ContainerControl guna2ContainerControl2;
        private Guna.UI2.WinForms.Guna2VScrollBar guna2VScrollBar1;
        private Guna.UI2.WinForms.Guna2DataGridView searchDoctorView;
        private Guna.UI2.WinForms.Guna2ContainerControl guna2ContainerControl1;
        private Guna.UI2.WinForms.Guna2TextBox phoneSearchtxt;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox NameSearchtxt;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ContainerControl guna2ContainerControl3;
        private System.Windows.Forms.Label label10;
        private Guna.UI2.WinForms.Guna2TextBox IdNumber;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2Button searchBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn doctorName;
        private System.Windows.Forms.DataGridViewTextBoxColumn doctorPhoneNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn doctorMiagor;
        private System.Windows.Forms.DataGridViewTextBoxColumn doctorNumber;
    }
}