namespace Hotel_Mgmt_Sys_IOOP_CSharp
{
    partial class manageCleaningScheduleFrm
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
            this.dgvCleaningSchedule = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDuration = new System.Windows.Forms.TextBox();
            this.calSchedule = new System.Windows.Forms.MonthCalendar();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.cboRoomToClean = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lstAssignee = new System.Windows.Forms.ListBox();
            this.txtDateRange = new System.Windows.Forms.TextBox();
            this.btnAddSchedule = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lstDates = new System.Windows.Forms.ListBox();
            this.btnShowSchedule = new System.Windows.Forms.Button();
            this.btnClearSchedule = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCleaningSchedule)).BeginInit();
            this.panel3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvCleaningSchedule
            // 
            this.dgvCleaningSchedule.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCleaningSchedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCleaningSchedule.Location = new System.Drawing.Point(703, 23);
            this.dgvCleaningSchedule.Name = "dgvCleaningSchedule";
            this.dgvCleaningSchedule.RowHeadersWidth = 51;
            this.dgvCleaningSchedule.RowTemplate.Height = 24;
            this.dgvCleaningSchedule.Size = new System.Drawing.Size(841, 665);
            this.dgvCleaningSchedule.TabIndex = 24;
            this.dgvCleaningSchedule.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCleaningSchedule_CellContentClick);
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(333, 124);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 25);
            this.label6.TabIndex = 17;
            this.label6.Text = "Duration ";
            // 
            // txtDuration
            // 
            this.txtDuration.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDuration.Location = new System.Drawing.Point(338, 152);
            this.txtDuration.Multiline = true;
            this.txtDuration.Name = "txtDuration";
            this.txtDuration.ReadOnly = true;
            this.txtDuration.Size = new System.Drawing.Size(279, 31);
            this.txtDuration.TabIndex = 15;
            // 
            // calSchedule
            // 
            this.calSchedule.Location = new System.Drawing.Point(24, 57);
            this.calSchedule.MaxSelectionCount = 31;
            this.calSchedule.Name = "calSchedule";
            this.calSchedule.TabIndex = 10;
            this.calSchedule.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.calSchedule_DateChanged);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.groupBox4);
            this.panel3.Location = new System.Drawing.Point(28, 23);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(669, 665);
            this.panel3.TabIndex = 22;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnReset);
            this.groupBox4.Controls.Add(this.cboRoomToClean);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.lstAssignee);
            this.groupBox4.Controls.Add(this.calSchedule);
            this.groupBox4.Controls.Add(this.txtDuration);
            this.groupBox4.Controls.Add(this.txtDateRange);
            this.groupBox4.Controls.Add(this.btnAddSchedule);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.lstDates);
            this.groupBox4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(14, 15);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(642, 634);
            this.groupBox4.TabIndex = 19;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Housekeeping Resource Management";
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(516, 432);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(110, 40);
            this.btnReset.TabIndex = 26;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // cboRoomToClean
            // 
            this.cboRoomToClean.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRoomToClean.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboRoomToClean.FormattingEnabled = true;
            this.cboRoomToClean.Location = new System.Drawing.Point(338, 224);
            this.cboRoomToClean.Name = "cboRoomToClean";
            this.cboRoomToClean.Size = new System.Drawing.Size(277, 31);
            this.cboRoomToClean.TabIndex = 8;
            this.cboRoomToClean.DropDown += new System.EventHandler(this.cboRoomToClean_DropDown);
            this.cboRoomToClean.SelectedIndexChanged += new System.EventHandler(this.cboRoomToClean_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(333, 191);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 25);
            this.label1.TabIndex = 25;
            this.label1.Text = "Room Assigned";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(333, 56);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 25);
            this.label7.TabIndex = 19;
            this.label7.Text = "Date Range";
            // 
            // lstAssignee
            // 
            this.lstAssignee.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstAssignee.FormattingEnabled = true;
            this.lstAssignee.ItemHeight = 23;
            this.lstAssignee.Location = new System.Drawing.Point(267, 337);
            this.lstAssignee.Name = "lstAssignee";
            this.lstAssignee.Size = new System.Drawing.Size(232, 234);
            this.lstAssignee.TabIndex = 20;
            // 
            // txtDateRange
            // 
            this.txtDateRange.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDateRange.Location = new System.Drawing.Point(336, 84);
            this.txtDateRange.Multiline = true;
            this.txtDateRange.Name = "txtDateRange";
            this.txtDateRange.ReadOnly = true;
            this.txtDateRange.Size = new System.Drawing.Size(279, 31);
            this.txtDateRange.TabIndex = 18;
            this.txtDateRange.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnAddSchedule
            // 
            this.btnAddSchedule.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddSchedule.Location = new System.Drawing.Point(516, 376);
            this.btnAddSchedule.Name = "btnAddSchedule";
            this.btnAddSchedule.Size = new System.Drawing.Size(110, 40);
            this.btnAddSchedule.TabIndex = 5;
            this.btnAddSchedule.Text = "Add >";
            this.btnAddSchedule.UseVisualStyleBackColor = true;
            this.btnAddSchedule.Click += new System.EventHandler(this.btnAddSchedule_Click);
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.LightGray;
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(24, 300);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(202, 34);
            this.label8.TabIndex = 16;
            this.label8.Text = "Housekeeping Dates";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.LightGray;
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(267, 300);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(232, 34);
            this.label9.TabIndex = 18;
            this.label9.Text = "Housekeeping Assignee";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lstDates
            // 
            this.lstDates.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstDates.FormattingEnabled = true;
            this.lstDates.ItemHeight = 23;
            this.lstDates.Location = new System.Drawing.Point(24, 337);
            this.lstDates.Name = "lstDates";
            this.lstDates.Size = new System.Drawing.Size(202, 234);
            this.lstDates.TabIndex = 0;
            // 
            // btnShowSchedule
            // 
            this.btnShowSchedule.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowSchedule.Location = new System.Drawing.Point(1559, 23);
            this.btnShowSchedule.Name = "btnShowSchedule";
            this.btnShowSchedule.Size = new System.Drawing.Size(110, 40);
            this.btnShowSchedule.TabIndex = 27;
            this.btnShowSchedule.Text = "Show";
            this.btnShowSchedule.UseVisualStyleBackColor = true;
            this.btnShowSchedule.Click += new System.EventHandler(this.btnShowSchedule_Click);
            // 
            // btnClearSchedule
            // 
            this.btnClearSchedule.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearSchedule.Location = new System.Drawing.Point(1559, 86);
            this.btnClearSchedule.Name = "btnClearSchedule";
            this.btnClearSchedule.Size = new System.Drawing.Size(110, 40);
            this.btnClearSchedule.TabIndex = 27;
            this.btnClearSchedule.Text = "Clear";
            this.btnClearSchedule.UseVisualStyleBackColor = true;
            this.btnClearSchedule.Click += new System.EventHandler(this.btnClearSchedule_Click);
            // 
            // manageCleaningScheduleFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1681, 717);
            this.Controls.Add(this.btnClearSchedule);
            this.Controls.Add(this.dgvCleaningSchedule);
            this.Controls.Add(this.btnShowSchedule);
            this.Controls.Add(this.panel3);
            this.Name = "manageCleaningScheduleFrm";
            this.Text = "manageCleaningSchedule";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCleaningSchedule)).EndInit();
            this.panel3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCleaningSchedule;
        private System.Windows.Forms.TextBox txtDuration;
        private System.Windows.Forms.MonthCalendar calSchedule;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ListBox lstAssignee;
        private System.Windows.Forms.Button btnAddSchedule;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ListBox lstDates;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDateRange;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboRoomToClean;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnShowSchedule;
        private System.Windows.Forms.Button btnClearSchedule;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}