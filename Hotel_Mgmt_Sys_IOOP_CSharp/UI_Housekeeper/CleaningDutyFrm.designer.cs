namespace Hotel_Mgmt_Sys_IOOP_CSharp
{
    partial class CleaningDutyFrm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControlCleaningSchedule = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridViewMySchedule = new System.Windows.Forms.DataGridView();
            this.cleaningScheduleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cleaningScheduleDataSet = new Hotel_Mgmt_Sys_IOOP_CSharp.CleaningScheduleDataSet();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridViewUpcomingPreparation = new System.Windows.Forms.DataGridView();
            this.cleaningScheduleBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.upcomingPrepDataSet = new Hotel_Mgmt_Sys_IOOP_CSharp.UpcomingPrepDataSet();
            this.lblSchedule = new System.Windows.Forms.Label();
            this.dateTimePickerEnd = new System.Windows.Forms.DateTimePicker();
            this.btnFilterSchedule = new System.Windows.Forms.Button();
            this.dateTimePickerStart = new System.Windows.Forms.DateTimePicker();
            this.labelChooseStartDate = new System.Windows.Forms.Label();
            this.labelChooseEndDate = new System.Windows.Forms.Label();
            this.cleaningScheduleTableAdapter = new Hotel_Mgmt_Sys_IOOP_CSharp.CleaningScheduleDataSetTableAdapters.CleaningScheduleTableAdapter();
            this.cleaningScheduleTableAdapter1 = new Hotel_Mgmt_Sys_IOOP_CSharp.UpcomingPrepDataSetTableAdapters.CleaningScheduleTableAdapter();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.additionalRequestsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cleaningStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.issueReportDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoomAmenities = new System.Windows.Forms.DataGridViewButtonColumn();
            this.upcomingPrepDataSet2 = new Hotel_Mgmt_Sys_IOOP_CSharp.UpcomingPrepDataSet2();
            this.cleaningScheduleBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.cleaningScheduleTableAdapter2 = new Hotel_Mgmt_Sys_IOOP_CSharp.UpcomingPrepDataSet2TableAdapters.CleaningScheduleTableAdapter();
            this.ScheduleID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Room_Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Room_Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Venue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cleaning_Status = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tabControlCleaningSchedule.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMySchedule)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cleaningScheduleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cleaningScheduleDataSet)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUpcomingPreparation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cleaningScheduleBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.upcomingPrepDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.upcomingPrepDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cleaningScheduleBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlCleaningSchedule
            // 
            this.tabControlCleaningSchedule.Controls.Add(this.tabPage1);
            this.tabControlCleaningSchedule.Controls.Add(this.tabPage2);
            this.tabControlCleaningSchedule.Location = new System.Drawing.Point(129, 236);
            this.tabControlCleaningSchedule.Name = "tabControlCleaningSchedule";
            this.tabControlCleaningSchedule.SelectedIndex = 0;
            this.tabControlCleaningSchedule.Size = new System.Drawing.Size(913, 353);
            this.tabControlCleaningSchedule.TabIndex = 46;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridViewMySchedule);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(905, 324);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "My Schedule";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridViewMySchedule
            // 
            this.dataGridViewMySchedule.AutoGenerateColumns = false;
            this.dataGridViewMySchedule.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.SkyBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewMySchedule.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewMySchedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMySchedule.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ScheduleID,
            this.Room_Number,
            this.Room_Type,
            this.Date,
            this.Time,
            this.Venue,
            this.Cleaning_Status});
            this.dataGridViewMySchedule.DataSource = this.cleaningScheduleBindingSource;
            this.dataGridViewMySchedule.EnableHeadersVisualStyles = false;
            this.dataGridViewMySchedule.Location = new System.Drawing.Point(24, 29);
            this.dataGridViewMySchedule.Name = "dataGridViewMySchedule";
            this.dataGridViewMySchedule.RowHeadersWidth = 51;
            this.dataGridViewMySchedule.RowTemplate.Height = 24;
            this.dataGridViewMySchedule.Size = new System.Drawing.Size(855, 267);
            this.dataGridViewMySchedule.TabIndex = 0;
            this.dataGridViewMySchedule.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewMySchedule_CellClick);
            // 
            // cleaningScheduleBindingSource
            // 
            this.cleaningScheduleBindingSource.DataMember = "CleaningSchedule";
            this.cleaningScheduleBindingSource.DataSource = this.cleaningScheduleDataSet;
            // 
            // cleaningScheduleDataSet
            // 
            this.cleaningScheduleDataSet.DataSetName = "CleaningScheduleDataSet";
            this.cleaningScheduleDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridViewUpcomingPreparation);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(905, 324);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Upcoming Preparation";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridViewUpcomingPreparation
            // 
            this.dataGridViewUpcomingPreparation.AutoGenerateColumns = false;
            this.dataGridViewUpcomingPreparation.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SkyBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewUpcomingPreparation.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewUpcomingPreparation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUpcomingPreparation.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn15,
            this.dataGridViewTextBoxColumn16,
            this.dataGridViewTextBoxColumn17,
            this.additionalRequestsDataGridViewTextBoxColumn,
            this.cleaningStatusDataGridViewTextBoxColumn,
            this.issueReportDataGridViewTextBoxColumn,
            this.RoomAmenities});
            this.dataGridViewUpcomingPreparation.DataSource = this.cleaningScheduleBindingSource2;
            this.dataGridViewUpcomingPreparation.EnableHeadersVisualStyles = false;
            this.dataGridViewUpcomingPreparation.Location = new System.Drawing.Point(24, 29);
            this.dataGridViewUpcomingPreparation.Name = "dataGridViewUpcomingPreparation";
            this.dataGridViewUpcomingPreparation.RowHeadersWidth = 51;
            this.dataGridViewUpcomingPreparation.RowTemplate.Height = 24;
            this.dataGridViewUpcomingPreparation.Size = new System.Drawing.Size(856, 267);
            this.dataGridViewUpcomingPreparation.TabIndex = 1;
            this.dataGridViewUpcomingPreparation.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewUpcomingPreparation_CellClick);
            // 
            // cleaningScheduleBindingSource1
            // 
            this.cleaningScheduleBindingSource1.DataMember = "CleaningSchedule";
            this.cleaningScheduleBindingSource1.DataSource = this.upcomingPrepDataSet;
            // 
            // upcomingPrepDataSet
            // 
            this.upcomingPrepDataSet.DataSetName = "UpcomingPrepDataSet";
            this.upcomingPrepDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblSchedule
            // 
            this.lblSchedule.AutoSize = true;
            this.lblSchedule.Font = new System.Drawing.Font("Trebuchet MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSchedule.Location = new System.Drawing.Point(503, 59);
            this.lblSchedule.Name = "lblSchedule";
            this.lblSchedule.Size = new System.Drawing.Size(210, 28);
            this.lblSchedule.TabIndex = 45;
            this.lblSchedule.Text = "Cleaning Schedule";
            // 
            // dateTimePickerEnd
            // 
            this.dateTimePickerEnd.Location = new System.Drawing.Point(495, 192);
            this.dateTimePickerEnd.Name = "dateTimePickerEnd";
            this.dateTimePickerEnd.Size = new System.Drawing.Size(244, 22);
            this.dateTimePickerEnd.TabIndex = 47;
            // 
            // btnFilterSchedule
            // 
            this.btnFilterSchedule.BackColor = System.Drawing.Color.Teal;
            this.btnFilterSchedule.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnFilterSchedule.Location = new System.Drawing.Point(781, 188);
            this.btnFilterSchedule.Name = "btnFilterSchedule";
            this.btnFilterSchedule.Size = new System.Drawing.Size(90, 29);
            this.btnFilterSchedule.TabIndex = 48;
            this.btnFilterSchedule.Text = "Filter ";
            this.btnFilterSchedule.UseVisualStyleBackColor = false;
            this.btnFilterSchedule.Click += new System.EventHandler(this.btnFilterSchedule_Click);
            // 
            // dateTimePickerStart
            // 
            this.dateTimePickerStart.Location = new System.Drawing.Point(495, 146);
            this.dateTimePickerStart.Name = "dateTimePickerStart";
            this.dateTimePickerStart.Size = new System.Drawing.Size(244, 22);
            this.dateTimePickerStart.TabIndex = 49;
            // 
            // labelChooseStartDate
            // 
            this.labelChooseStartDate.AutoSize = true;
            this.labelChooseStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelChooseStartDate.Location = new System.Drawing.Point(349, 149);
            this.labelChooseStartDate.Name = "labelChooseStartDate";
            this.labelChooseStartDate.Size = new System.Drawing.Size(135, 18);
            this.labelChooseStartDate.TabIndex = 50;
            this.labelChooseStartDate.Text = "Choose Start Date:";
            // 
            // labelChooseEndDate
            // 
            this.labelChooseEndDate.AutoSize = true;
            this.labelChooseEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelChooseEndDate.Location = new System.Drawing.Point(350, 192);
            this.labelChooseEndDate.Name = "labelChooseEndDate";
            this.labelChooseEndDate.Size = new System.Drawing.Size(130, 18);
            this.labelChooseEndDate.TabIndex = 51;
            this.labelChooseEndDate.Text = "Choose End Date:";
            // 
            // cleaningScheduleTableAdapter
            // 
            this.cleaningScheduleTableAdapter.ClearBeforeFill = true;
            // 
            // cleaningScheduleTableAdapter1
            // 
            this.cleaningScheduleTableAdapter1.ClearBeforeFill = true;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "ScheduleID";
            this.dataGridViewTextBoxColumn12.HeaderText = "ScheduleID";
            this.dataGridViewTextBoxColumn12.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.Width = 125;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "Room_Number";
            this.dataGridViewTextBoxColumn13.HeaderText = "Room_Number";
            this.dataGridViewTextBoxColumn13.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.Width = 125;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "Room_Type";
            this.dataGridViewTextBoxColumn14.HeaderText = "Room_Type";
            this.dataGridViewTextBoxColumn14.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.Width = 125;
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "Date";
            this.dataGridViewTextBoxColumn15.HeaderText = "Date";
            this.dataGridViewTextBoxColumn15.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn15.Width = 125;
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.DataPropertyName = "Time";
            this.dataGridViewTextBoxColumn16.HeaderText = "Time";
            this.dataGridViewTextBoxColumn16.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            this.dataGridViewTextBoxColumn16.Width = 125;
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.DataPropertyName = "Venue";
            this.dataGridViewTextBoxColumn17.HeaderText = "Venue";
            this.dataGridViewTextBoxColumn17.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            this.dataGridViewTextBoxColumn17.Width = 125;
            // 
            // additionalRequestsDataGridViewTextBoxColumn
            // 
            this.additionalRequestsDataGridViewTextBoxColumn.DataPropertyName = "Additional_Requests";
            this.additionalRequestsDataGridViewTextBoxColumn.HeaderText = "Additional_Requests";
            this.additionalRequestsDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.additionalRequestsDataGridViewTextBoxColumn.Name = "additionalRequestsDataGridViewTextBoxColumn";
            this.additionalRequestsDataGridViewTextBoxColumn.Width = 125;
            // 
            // cleaningStatusDataGridViewTextBoxColumn
            // 
            this.cleaningStatusDataGridViewTextBoxColumn.DataPropertyName = "Cleaning_Status";
            this.cleaningStatusDataGridViewTextBoxColumn.HeaderText = "Cleaning_Status";
            this.cleaningStatusDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cleaningStatusDataGridViewTextBoxColumn.Name = "cleaningStatusDataGridViewTextBoxColumn";
            this.cleaningStatusDataGridViewTextBoxColumn.Width = 125;
            // 
            // issueReportDataGridViewTextBoxColumn
            // 
            this.issueReportDataGridViewTextBoxColumn.DataPropertyName = "Issue_Report";
            this.issueReportDataGridViewTextBoxColumn.HeaderText = "Issue_Report";
            this.issueReportDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.issueReportDataGridViewTextBoxColumn.Name = "issueReportDataGridViewTextBoxColumn";
            this.issueReportDataGridViewTextBoxColumn.Width = 125;
            // 
            // RoomAmenities
            // 
            this.RoomAmenities.HeaderText = "Room Amenities";
            this.RoomAmenities.MinimumWidth = 6;
            this.RoomAmenities.Name = "RoomAmenities";
            this.RoomAmenities.Text = "More Info";
            this.RoomAmenities.UseColumnTextForButtonValue = true;
            this.RoomAmenities.Width = 125;
            // 
            // upcomingPrepDataSet2
            // 
            this.upcomingPrepDataSet2.DataSetName = "UpcomingPrepDataSet2";
            this.upcomingPrepDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cleaningScheduleBindingSource2
            // 
            this.cleaningScheduleBindingSource2.DataMember = "CleaningSchedule";
            this.cleaningScheduleBindingSource2.DataSource = this.upcomingPrepDataSet2;
            // 
            // cleaningScheduleTableAdapter2
            // 
            this.cleaningScheduleTableAdapter2.ClearBeforeFill = true;
            // 
            // ScheduleID
            // 
            this.ScheduleID.DataPropertyName = "ScheduleID";
            this.ScheduleID.HeaderText = "ScheduleID";
            this.ScheduleID.MinimumWidth = 6;
            this.ScheduleID.Name = "ScheduleID";
            this.ScheduleID.Width = 125;
            // 
            // Room_Number
            // 
            this.Room_Number.DataPropertyName = "Room_Number";
            this.Room_Number.HeaderText = "Room_Number";
            this.Room_Number.MinimumWidth = 6;
            this.Room_Number.Name = "Room_Number";
            this.Room_Number.Width = 125;
            // 
            // Room_Type
            // 
            this.Room_Type.DataPropertyName = "Room_Type";
            this.Room_Type.HeaderText = "Room_Type";
            this.Room_Type.MinimumWidth = 6;
            this.Room_Type.Name = "Room_Type";
            this.Room_Type.Width = 125;
            // 
            // Date
            // 
            this.Date.DataPropertyName = "Date";
            this.Date.HeaderText = "Date";
            this.Date.MinimumWidth = 6;
            this.Date.Name = "Date";
            this.Date.Width = 125;
            // 
            // Time
            // 
            this.Time.DataPropertyName = "Time";
            this.Time.HeaderText = "Time";
            this.Time.MinimumWidth = 6;
            this.Time.Name = "Time";
            this.Time.Width = 125;
            // 
            // Venue
            // 
            this.Venue.DataPropertyName = "Venue";
            this.Venue.HeaderText = "Venue";
            this.Venue.MinimumWidth = 6;
            this.Venue.Name = "Venue";
            this.Venue.Width = 125;
            // 
            // Cleaning_Status
            // 
            this.Cleaning_Status.DataPropertyName = "Cleaning_Status";
            this.Cleaning_Status.HeaderText = "Cleaning_Status";
            this.Cleaning_Status.MinimumWidth = 6;
            this.Cleaning_Status.Name = "Cleaning_Status";
            this.Cleaning_Status.Text = "Update Status";
            this.Cleaning_Status.Width = 125;
            // 
            // CleaningDutyFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1163, 682);
            this.Controls.Add(this.labelChooseEndDate);
            this.Controls.Add(this.labelChooseStartDate);
            this.Controls.Add(this.dateTimePickerStart);
            this.Controls.Add(this.btnFilterSchedule);
            this.Controls.Add(this.dateTimePickerEnd);
            this.Controls.Add(this.tabControlCleaningSchedule);
            this.Controls.Add(this.lblSchedule);
            this.Name = "CleaningDutyFrm";
            this.Text = "CleaningSchedule";
            this.Load += new System.EventHandler(this.CleaningSchedule_Load);
            this.tabControlCleaningSchedule.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMySchedule)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cleaningScheduleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cleaningScheduleDataSet)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUpcomingPreparation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cleaningScheduleBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.upcomingPrepDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.upcomingPrepDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cleaningScheduleBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TabControl tabControlCleaningSchedule;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataGridViewMySchedule;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridViewUpcomingPreparation;
        private System.Windows.Forms.Label lblSchedule;
        private System.Windows.Forms.DateTimePicker dateTimePickerEnd;
        private System.Windows.Forms.Button btnFilterSchedule;
        private System.Windows.Forms.DateTimePicker dateTimePickerStart;
        private System.Windows.Forms.Label labelChooseStartDate;
        private System.Windows.Forms.Label labelChooseEndDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn scheduleIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn venueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private CleaningScheduleDataSet cleaningScheduleDataSet;
        private System.Windows.Forms.BindingSource cleaningScheduleBindingSource;
        private CleaningScheduleDataSetTableAdapters.CleaningScheduleTableAdapter cleaningScheduleTableAdapter;
        private UpcomingPrepDataSet upcomingPrepDataSet;
        private System.Windows.Forms.BindingSource cleaningScheduleBindingSource1;
        private UpcomingPrepDataSetTableAdapters.CleaningScheduleTableAdapter cleaningScheduleTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private System.Windows.Forms.DataGridViewTextBoxColumn additionalRequestsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cleaningStatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn issueReportDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn RoomAmenities;
        private UpcomingPrepDataSet2 upcomingPrepDataSet2;
        private System.Windows.Forms.BindingSource cleaningScheduleBindingSource2;
        private UpcomingPrepDataSet2TableAdapters.CleaningScheduleTableAdapter cleaningScheduleTableAdapter2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ScheduleID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Room_Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn Room_Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time;
        private System.Windows.Forms.DataGridViewTextBoxColumn Venue;
        private System.Windows.Forms.DataGridViewButtonColumn Cleaning_Status;
    }
}