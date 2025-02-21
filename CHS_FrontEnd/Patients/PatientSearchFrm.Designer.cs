using Guna.UI2.WinForms;

namespace CHS_FrontEnd
{
    partial class searchPatientFrm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2ContainerControl1 = new Guna.UI2.WinForms.Guna2ContainerControl();
            this.searchBtn = new Guna.UI2.WinForms.Guna2Button();
            this.nationalSearchtxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.phoneSearchtxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.midSearchtxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2ContainerControl2 = new Guna.UI2.WinForms.Guna2ContainerControl();
            this.guna2VScrollBar1 = new Guna.UI2.WinForms.Guna2VScrollBar();
            this.searchPatientView = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Column_FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_PhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_State = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_MedicalNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guna2ContainerControl3 = new Guna.UI2.WinForms.Guna2ContainerControl();
            this.label10 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.guna2ContainerControl1.SuspendLayout();
            this.guna2ContainerControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchPatientView)).BeginInit();
            this.guna2ContainerControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2ContainerControl1
            // 
            this.guna2ContainerControl1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.guna2ContainerControl1.BackColor = System.Drawing.Color.White;
            this.guna2ContainerControl1.BorderRadius = 15;
            this.guna2ContainerControl1.Controls.Add(this.searchBtn);
            this.guna2ContainerControl1.Controls.Add(this.nationalSearchtxt);
            this.guna2ContainerControl1.Controls.Add(this.label3);
            this.guna2ContainerControl1.Controls.Add(this.phoneSearchtxt);
            this.guna2ContainerControl1.Controls.Add(this.label2);
            this.guna2ContainerControl1.Controls.Add(this.midSearchtxt);
            this.guna2ContainerControl1.Controls.Add(this.label1);
            this.guna2ContainerControl1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(249)))));
            this.guna2ContainerControl1.Location = new System.Drawing.Point(14, 74);
            this.guna2ContainerControl1.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.guna2ContainerControl1.Name = "guna2ContainerControl1";
            this.guna2ContainerControl1.Size = new System.Drawing.Size(1567, 121);
            this.guna2ContainerControl1.TabIndex = 0;
            this.guna2ContainerControl1.Text = "guna2ContainerControl1";
            this.guna2ContainerControl1.Click += new System.EventHandler(this.guna2ContainerControl1_Click);
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
            this.searchBtn.Location = new System.Drawing.Point(77, 50);
            this.searchBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(197, 40);
            this.searchBtn.TabIndex = 38;
            this.searchBtn.Text = "بحث";
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // nationalSearchtxt
            // 
            this.nationalSearchtxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nationalSearchtxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(249)))));
            this.nationalSearchtxt.BorderRadius = 10;
            this.nationalSearchtxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nationalSearchtxt.DefaultText = "";
            this.nationalSearchtxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.nationalSearchtxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.nationalSearchtxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.nationalSearchtxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.nationalSearchtxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.nationalSearchtxt.FocusedState.PlaceholderForeColor = System.Drawing.Color.White;
            this.nationalSearchtxt.Font = new System.Drawing.Font("Traditional Arabic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nationalSearchtxt.ForeColor = System.Drawing.SystemColors.WindowText;
            this.nationalSearchtxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.nationalSearchtxt.Location = new System.Drawing.Point(349, 50);
            this.nationalSearchtxt.Margin = new System.Windows.Forms.Padding(5);
            this.nationalSearchtxt.Name = "nationalSearchtxt";
            this.nationalSearchtxt.PasswordChar = '\0';
            this.nationalSearchtxt.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.nationalSearchtxt.PlaceholderText = "الرقم الطبي";
            this.nationalSearchtxt.SelectedText = "";
            this.nationalSearchtxt.Size = new System.Drawing.Size(363, 40);
            this.nationalSearchtxt.TabIndex = 5;
            this.nationalSearchtxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(249)))));
            this.label3.Font = new System.Drawing.Font("Traditional Arabic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(726, 63);
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
            this.phoneSearchtxt.FocusedState.PlaceholderForeColor = System.Drawing.Color.White;
            this.phoneSearchtxt.Font = new System.Drawing.Font("Traditional Arabic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneSearchtxt.ForeColor = System.Drawing.SystemColors.WindowText;
            this.phoneSearchtxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.phoneSearchtxt.Location = new System.Drawing.Point(766, 50);
            this.phoneSearchtxt.Margin = new System.Windows.Forms.Padding(5);
            this.phoneSearchtxt.Name = "phoneSearchtxt";
            this.phoneSearchtxt.PasswordChar = '\0';
            this.phoneSearchtxt.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.phoneSearchtxt.PlaceholderText = "رقم الهاتف";
            this.phoneSearchtxt.SelectedText = "";
            this.phoneSearchtxt.Size = new System.Drawing.Size(363, 40);
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
            this.label2.Location = new System.Drawing.Point(1145, 62);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 27);
            this.label2.TabIndex = 2;
            this.label2.Text = "او";
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
            this.midSearchtxt.FocusedState.PlaceholderForeColor = System.Drawing.Color.White;
            this.midSearchtxt.Font = new System.Drawing.Font("Traditional Arabic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.midSearchtxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.midSearchtxt.Location = new System.Drawing.Point(1187, 50);
            this.midSearchtxt.Margin = new System.Windows.Forms.Padding(5);
            this.midSearchtxt.Name = "midSearchtxt";
            this.midSearchtxt.PasswordChar = '\0';
            this.midSearchtxt.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.midSearchtxt.PlaceholderText = "أسم المريض";
            this.midSearchtxt.SelectedText = "";
            this.midSearchtxt.Size = new System.Drawing.Size(363, 40);
            this.midSearchtxt.TabIndex = 1;
            this.midSearchtxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(249)))));
            this.label1.Font = new System.Drawing.Font("Traditional Arabic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(77)))), ((int)(((byte)(146)))));
            this.label1.Location = new System.Drawing.Point(1398, -12);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(17, 15, 17, 15);
            this.label1.Size = new System.Drawing.Size(174, 66);
            this.label1.TabIndex = 0;
            this.label1.Text = "ابحث عن مريض";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // guna2ContainerControl2
            // 
            this.guna2ContainerControl2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.guna2ContainerControl2.BorderRadius = 15;
            this.guna2ContainerControl2.Controls.Add(this.guna2VScrollBar1);
            this.guna2ContainerControl2.Controls.Add(this.searchPatientView);
            this.guna2ContainerControl2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(77)))), ((int)(((byte)(146)))));
            this.guna2ContainerControl2.Location = new System.Drawing.Point(14, 206);
            this.guna2ContainerControl2.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.guna2ContainerControl2.Name = "guna2ContainerControl2";
            this.guna2ContainerControl2.Size = new System.Drawing.Size(1570, 484);
            this.guna2ContainerControl2.TabIndex = 4;
            this.guna2ContainerControl2.Text = "guna2ContainerControl2";
            // 
            // guna2VScrollBar1
            // 
            this.guna2VScrollBar1.InUpdate = false;
            this.guna2VScrollBar1.LargeChange = 10;
            this.guna2VScrollBar1.Location = new System.Drawing.Point(1533, 58);
            this.guna2VScrollBar1.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.guna2VScrollBar1.Maximum = 99;
            this.guna2VScrollBar1.Name = "guna2VScrollBar1";
            this.guna2VScrollBar1.ScrollbarSize = 18;
            this.guna2VScrollBar1.Size = new System.Drawing.Size(18, 407);
            this.guna2VScrollBar1.TabIndex = 6;
            this.guna2VScrollBar1.ThumbColor = System.Drawing.Color.DarkGray;
            this.guna2VScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.guna2VScrollBar1_Scroll);
            // 
            // searchPatientView
            // 
            this.searchPatientView.AllowUserToAddRows = false;
            this.searchPatientView.AllowUserToDeleteRows = false;
            this.searchPatientView.AllowUserToResizeColumns = false;
            this.searchPatientView.AllowUserToResizeRows = false;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Traditional Arabic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.Black;
            this.searchPatientView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle11;
            this.searchPatientView.Anchor = System.Windows.Forms.AnchorStyles.Top;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(77)))), ((int)(((byte)(146)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(77)))), ((int)(((byte)(146)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.searchPatientView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.searchPatientView.ColumnHeadersHeight = 40;
            this.searchPatientView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_FullName,
            this.Column_PhoneNumber,
            this.Column_Age,
            this.Column_State,
            this.Column_MedicalNumber});
            this.searchPatientView.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.searchPatientView.DefaultCellStyle = dataGridViewCellStyle18;
            this.searchPatientView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.searchPatientView.GridColor = System.Drawing.Color.Gray;
            this.searchPatientView.Location = new System.Drawing.Point(19, 18);
            this.searchPatientView.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.searchPatientView.MultiSelect = false;
            this.searchPatientView.Name = "searchPatientView";
            this.searchPatientView.ReadOnly = true;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle19.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.searchPatientView.RowHeadersDefaultCellStyle = dataGridViewCellStyle19;
            this.searchPatientView.RowHeadersVisible = false;
            this.searchPatientView.RowHeadersWidth = 51;
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.searchPatientView.RowsDefaultCellStyle = dataGridViewCellStyle20;
            this.searchPatientView.RowTemplate.Height = 40;
            this.searchPatientView.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.searchPatientView.Size = new System.Drawing.Size(1532, 447);
            this.searchPatientView.TabIndex = 0;
            this.searchPatientView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.searchPatientView.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchPatientView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.searchPatientView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.searchPatientView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.searchPatientView.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.searchPatientView.ThemeStyle.GridColor = System.Drawing.Color.Gray;
            this.searchPatientView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(77)))), ((int)(((byte)(146)))));
            this.searchPatientView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.searchPatientView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchPatientView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.searchPatientView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.searchPatientView.ThemeStyle.HeaderStyle.Height = 40;
            this.searchPatientView.ThemeStyle.ReadOnly = true;
            this.searchPatientView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.searchPatientView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.searchPatientView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Tahoma", 8F);
            this.searchPatientView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.searchPatientView.ThemeStyle.RowsStyle.Height = 40;
            this.searchPatientView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.searchPatientView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.searchPatientView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.searchPatientView_CellDoubleClick_1);
            // 
            // Column_FullName
            // 
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Column_FullName.DefaultCellStyle = dataGridViewCellStyle13;
            this.Column_FullName.HeaderText = "اسم المريض";
            this.Column_FullName.MinimumWidth = 10;
            this.Column_FullName.Name = "Column_FullName";
            this.Column_FullName.ReadOnly = true;
            // 
            // Column_PhoneNumber
            // 
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Column_PhoneNumber.DefaultCellStyle = dataGridViewCellStyle14;
            this.Column_PhoneNumber.HeaderText = "رقم الهاتف";
            this.Column_PhoneNumber.MinimumWidth = 6;
            this.Column_PhoneNumber.Name = "Column_PhoneNumber";
            this.Column_PhoneNumber.ReadOnly = true;
            // 
            // Column_Age
            // 
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Column_Age.DefaultCellStyle = dataGridViewCellStyle15;
            this.Column_Age.HeaderText = "العمر";
            this.Column_Age.MinimumWidth = 6;
            this.Column_Age.Name = "Column_Age";
            this.Column_Age.ReadOnly = true;
            // 
            // Column_State
            // 
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Column_State.DefaultCellStyle = dataGridViewCellStyle16;
            this.Column_State.HeaderText = "المحافظة";
            this.Column_State.MinimumWidth = 6;
            this.Column_State.Name = "Column_State";
            this.Column_State.ReadOnly = true;
            // 
            // Column_MedicalNumber
            // 
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Column_MedicalNumber.DefaultCellStyle = dataGridViewCellStyle17;
            this.Column_MedicalNumber.HeaderText = "الرقم الطبي";
            this.Column_MedicalNumber.MinimumWidth = 6;
            this.Column_MedicalNumber.Name = "Column_MedicalNumber";
            this.Column_MedicalNumber.ReadOnly = true;
            // 
            // guna2ContainerControl3
            // 
            this.guna2ContainerControl3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.guna2ContainerControl3.BorderRadius = 15;
            this.guna2ContainerControl3.Controls.Add(this.pictureBox1);
            this.guna2ContainerControl3.Controls.Add(this.label10);
            this.guna2ContainerControl3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(77)))), ((int)(((byte)(146)))));
            this.guna2ContainerControl3.Location = new System.Drawing.Point(14, 6);
            this.guna2ContainerControl3.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.guna2ContainerControl3.Name = "guna2ContainerControl3";
            this.guna2ContainerControl3.Size = new System.Drawing.Size(1569, 58);
            this.guna2ContainerControl3.TabIndex = 5;
            this.guna2ContainerControl3.Text = "guna2ContainerControl3";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(77)))), ((int)(((byte)(146)))));
            this.label10.Font = new System.Drawing.Font("Traditional Arabic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(687, 2);
            this.label10.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(211, 52);
            this.label10.TabIndex = 0;
            this.label10.Text = "البحث عن ملف طبي";
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::CHS_FrontEnd.Properties.Resources.Animation___1740156272160;
            this.pictureBox1.Location = new System.Drawing.Point(611, -9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(77, 72);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // searchPatientFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1598, 802);
            this.Controls.Add(this.guna2ContainerControl3);
            this.Controls.Add(this.guna2ContainerControl2);
            this.Controls.Add(this.guna2ContainerControl1);
            this.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.Name = "searchPatientFrm";
            this.Text = "البحث عن ملف طبي";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.guna2ContainerControl1.ResumeLayout(false);
            this.guna2ContainerControl1.PerformLayout();
            this.guna2ContainerControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.searchPatientView)).EndInit();
            this.guna2ContainerControl3.ResumeLayout(false);
            this.guna2ContainerControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ContainerControl guna2ContainerControl1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox midSearchtxt;
        private Guna.UI2.WinForms.Guna2TextBox nationalSearchtxt;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox phoneSearchtxt;
        private Guna.UI2.WinForms.Guna2ContainerControl guna2ContainerControl2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_FullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_PhoneNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Age;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_State;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_MedicalNumber;
        private Guna.UI2.WinForms.Guna2ContainerControl guna2ContainerControl3;
        private System.Windows.Forms.Label label10;
        private Guna.UI2.WinForms.Guna2VScrollBar guna2VScrollBar1;
        private Guna2Button searchBtn;
        internal Guna2DataGridView searchPatientView;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}