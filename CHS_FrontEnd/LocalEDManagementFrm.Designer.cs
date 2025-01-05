namespace CHS_FrontEnd
{
    partial class LocalEDManagementFrm
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
            this.guna2ContainerControl3 = new Guna.UI2.WinForms.Guna2ContainerControl();
            this.label10 = new System.Windows.Forms.Label();
            this.guna2ContainerControl2 = new Guna.UI2.WinForms.Guna2ContainerControl();
            this.guna2VScrollBar1 = new Guna.UI2.WinForms.Guna2VScrollBar();
            this.edLocalBedsStatue = new Guna.UI2.WinForms.Guna2DataGridView();
            this.editBedsCount = new System.Windows.Forms.DataGridViewButtonColumn();
            this.editBedsStatues = new System.Windows.Forms.DataGridViewButtonColumn();
            this.availableBeds = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addRoomButton = new Guna.UI2.WinForms.Guna2Button();
            this.demoDIsplayRooms = new Guna.UI2.WinForms.Guna2Button();
            this.guna2ContainerControl3.SuspendLayout();
            this.guna2ContainerControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edLocalBedsStatue)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2ContainerControl3
            // 
            this.guna2ContainerControl3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ContainerControl3.BorderRadius = 15;
            this.guna2ContainerControl3.Controls.Add(this.label10);
            this.guna2ContainerControl3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(77)))), ((int)(((byte)(146)))));
            this.guna2ContainerControl3.Location = new System.Drawing.Point(110, 9);
            this.guna2ContainerControl3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.guna2ContainerControl3.Name = "guna2ContainerControl3";
            this.guna2ContainerControl3.Size = new System.Drawing.Size(1594, 61);
            this.guna2ContainerControl3.TabIndex = 6;
            this.guna2ContainerControl3.Text = "guna2ContainerControl3";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(77)))), ((int)(((byte)(146)))));
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(670, 10);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(254, 40);
            this.label10.TabIndex = 0;
            this.label10.Text = "إدارة قسم الطوارئ";
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // guna2ContainerControl2
            // 
            this.guna2ContainerControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ContainerControl2.BorderRadius = 15;
            this.guna2ContainerControl2.Controls.Add(this.guna2VScrollBar1);
            this.guna2ContainerControl2.Controls.Add(this.edLocalBedsStatue);
            this.guna2ContainerControl2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(77)))), ((int)(((byte)(146)))));
            this.guna2ContainerControl2.Location = new System.Drawing.Point(119, 107);
            this.guna2ContainerControl2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.guna2ContainerControl2.Name = "guna2ContainerControl2";
            this.guna2ContainerControl2.Size = new System.Drawing.Size(1568, 503);
            this.guna2ContainerControl2.TabIndex = 7;
            this.guna2ContainerControl2.Text = "guna2ContainerControl2";
            // 
            // guna2VScrollBar1
            // 
            this.guna2VScrollBar1.InUpdate = false;
            this.guna2VScrollBar1.LargeChange = 10;
            this.guna2VScrollBar1.Location = new System.Drawing.Point(1527, 74);
            this.guna2VScrollBar1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.guna2VScrollBar1.Maximum = 99;
            this.guna2VScrollBar1.Name = "guna2VScrollBar1";
            this.guna2VScrollBar1.ScrollbarSize = 22;
            this.guna2VScrollBar1.Size = new System.Drawing.Size(22, 405);
            this.guna2VScrollBar1.TabIndex = 6;
            this.guna2VScrollBar1.ThumbColor = System.Drawing.Color.DarkGray;
            // 
            // edLocalBedsStatue
            // 
            this.edLocalBedsStatue.AllowUserToAddRows = false;
            this.edLocalBedsStatue.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.edLocalBedsStatue.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.edLocalBedsStatue.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(77)))), ((int)(((byte)(146)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.edLocalBedsStatue.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.edLocalBedsStatue.ColumnHeadersHeight = 25;
            this.edLocalBedsStatue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.edLocalBedsStatue.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.editBedsCount,
            this.editBedsStatues,
            this.availableBeds,
            this.roomNum});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.edLocalBedsStatue.DefaultCellStyle = dataGridViewCellStyle3;
            this.edLocalBedsStatue.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.edLocalBedsStatue.GridColor = System.Drawing.Color.Gray;
            this.edLocalBedsStatue.Location = new System.Drawing.Point(21, 22);
            this.edLocalBedsStatue.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.edLocalBedsStatue.Name = "edLocalBedsStatue";
            this.edLocalBedsStatue.ReadOnly = true;
            this.edLocalBedsStatue.RowHeadersVisible = false;
            this.edLocalBedsStatue.RowHeadersWidth = 51;
            this.edLocalBedsStatue.RowTemplate.Height = 40;
            this.edLocalBedsStatue.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.edLocalBedsStatue.Size = new System.Drawing.Size(1528, 457);
            this.edLocalBedsStatue.TabIndex = 0;
            this.edLocalBedsStatue.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.edLocalBedsStatue.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edLocalBedsStatue.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.edLocalBedsStatue.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.edLocalBedsStatue.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.edLocalBedsStatue.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.edLocalBedsStatue.ThemeStyle.GridColor = System.Drawing.Color.Gray;
            this.edLocalBedsStatue.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(77)))), ((int)(((byte)(146)))));
            this.edLocalBedsStatue.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.edLocalBedsStatue.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edLocalBedsStatue.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.edLocalBedsStatue.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.edLocalBedsStatue.ThemeStyle.HeaderStyle.Height = 25;
            this.edLocalBedsStatue.ThemeStyle.ReadOnly = true;
            this.edLocalBedsStatue.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.edLocalBedsStatue.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.edLocalBedsStatue.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Tahoma", 8F);
            this.edLocalBedsStatue.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.edLocalBedsStatue.ThemeStyle.RowsStyle.Height = 40;
            this.edLocalBedsStatue.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.edLocalBedsStatue.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // editBedsCount
            // 
            this.editBedsCount.HeaderText = "تعديل عدد الأسرّة";
            this.editBedsCount.MinimumWidth = 8;
            this.editBedsCount.Name = "editBedsCount";
            this.editBedsCount.ReadOnly = true;
            this.editBedsCount.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.editBedsCount.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.editBedsCount.Text = "تعديل";
            this.editBedsCount.UseColumnTextForButtonValue = true;
            // 
            // editBedsStatues
            // 
            this.editBedsStatues.HeaderText = "تعديل حالة الأسرّة";
            this.editBedsStatues.MinimumWidth = 8;
            this.editBedsStatues.Name = "editBedsStatues";
            this.editBedsStatues.ReadOnly = true;
            this.editBedsStatues.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.editBedsStatues.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.editBedsStatues.Text = "تعديل";
            this.editBedsStatues.UseColumnTextForButtonValue = true;
            // 
            // availableBeds
            // 
            this.availableBeds.HeaderText = "عدد الأسرّة المتاحة";
            this.availableBeds.MinimumWidth = 8;
            this.availableBeds.Name = "availableBeds";
            this.availableBeds.ReadOnly = true;
            // 
            // roomNum
            // 
            this.roomNum.HeaderText = "رقم الغرفة";
            this.roomNum.MinimumWidth = 8;
            this.roomNum.Name = "roomNum";
            this.roomNum.ReadOnly = true;
            // 
            // addRoomButton
            // 
            this.addRoomButton.BorderRadius = 20;
            this.addRoomButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.addRoomButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.addRoomButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.addRoomButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.addRoomButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.addRoomButton.ForeColor = System.Drawing.Color.White;
            this.addRoomButton.Location = new System.Drawing.Point(1379, 674);
            this.addRoomButton.Name = "addRoomButton";
            this.addRoomButton.Size = new System.Drawing.Size(308, 86);
            this.addRoomButton.TabIndex = 8;
            this.addRoomButton.Text = "إضافة غرفة جديدة";
            this.addRoomButton.Click += new System.EventHandler(this.addRoomButton_Click);
            // 
            // demoDIsplayRooms
            // 
            this.demoDIsplayRooms.BorderRadius = 20;
            this.demoDIsplayRooms.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.demoDIsplayRooms.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.demoDIsplayRooms.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.demoDIsplayRooms.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.demoDIsplayRooms.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.demoDIsplayRooms.ForeColor = System.Drawing.Color.White;
            this.demoDIsplayRooms.Location = new System.Drawing.Point(985, 674);
            this.demoDIsplayRooms.Name = "demoDIsplayRooms";
            this.demoDIsplayRooms.Size = new System.Drawing.Size(308, 86);
            this.demoDIsplayRooms.TabIndex = 9;
            this.demoDIsplayRooms.Text = "عرض الغرف";
            this.demoDIsplayRooms.Click += new System.EventHandler(this.demoDIsplayRooms_Click);
            // 
            // LocalEDManagementFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1861, 1052);
            this.Controls.Add(this.demoDIsplayRooms);
            this.Controls.Add(this.addRoomButton);
            this.Controls.Add(this.guna2ContainerControl2);
            this.Controls.Add(this.guna2ContainerControl3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LocalEDManagementFrm";
            this.Text = "EDfrm";
            this.Load += new System.EventHandler(this.LocalEDManagementFrm_Load);
            this.guna2ContainerControl3.ResumeLayout(false);
            this.guna2ContainerControl3.PerformLayout();
            this.guna2ContainerControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.edLocalBedsStatue)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ContainerControl guna2ContainerControl3;
        private System.Windows.Forms.Label label10;
        private Guna.UI2.WinForms.Guna2ContainerControl guna2ContainerControl2;
        private Guna.UI2.WinForms.Guna2VScrollBar guna2VScrollBar1;
        private Guna.UI2.WinForms.Guna2DataGridView edLocalBedsStatue;
        private System.Windows.Forms.DataGridViewButtonColumn editBedsCount;
        private System.Windows.Forms.DataGridViewButtonColumn editBedsStatues;
        private System.Windows.Forms.DataGridViewTextBoxColumn availableBeds;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomNum;
        private Guna.UI2.WinForms.Guna2Button addRoomButton;
        private Guna.UI2.WinForms.Guna2Button demoDIsplayRooms;
    }
}