namespace Hotel_Mgmt_Sys_IOOP_CSharp
{
    partial class CleaningStatusForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CleaningStatusForm));
            this.btnReport = new System.Windows.Forms.Button();
            this.txtReportIssues = new System.Windows.Forms.TextBox();
            this.labelIssues = new System.Windows.Forms.Label();
            this.grpBoxStatus = new System.Windows.Forms.GroupBox();
            this.labelDeclare = new System.Windows.Forms.Label();
            this.checkBoxDirty = new System.Windows.Forms.CheckBox();
            this.checkBoxCleaned = new System.Windows.Forms.CheckBox();
            this.grpBoxScheduleDetails = new System.Windows.Forms.GroupBox();
            this.lblVenue = new System.Windows.Forms.Label();
            this.lblScheduleTime = new System.Windows.Forms.Label();
            this.lblScheduleDate = new System.Windows.Forms.Label();
            this.lblRoomType = new System.Windows.Forms.Label();
            this.pictureBoxRoomType = new System.Windows.Forms.PictureBox();
            this.pictureBoxDate = new System.Windows.Forms.PictureBox();
            this.pictureBoxTime = new System.Windows.Forms.PictureBox();
            this.pictureBoxVenue = new System.Windows.Forms.PictureBox();
            this.lblRoomID = new System.Windows.Forms.Label();
            this.labelCleaningStatusTitle = new System.Windows.Forms.Label();
            this.labelShowStatus = new System.Windows.Forms.Label();
            this.grpBoxStatus.SuspendLayout();
            this.grpBoxScheduleDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRoomType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVenue)).BeginInit();
            this.SuspendLayout();
            // 
            // btnReport
            // 
            this.btnReport.BackColor = System.Drawing.Color.Teal;
            this.btnReport.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnReport.Location = new System.Drawing.Point(716, 458);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(85, 31);
            this.btnReport.TabIndex = 46;
            this.btnReport.Text = "Report";
            this.btnReport.UseVisualStyleBackColor = false;
            // 
            // txtReportIssues
            // 
            this.txtReportIssues.Location = new System.Drawing.Point(468, 369);
            this.txtReportIssues.Multiline = true;
            this.txtReportIssues.Name = "txtReportIssues";
            this.txtReportIssues.Size = new System.Drawing.Size(333, 60);
            this.txtReportIssues.TabIndex = 45;
            // 
            // labelIssues
            // 
            this.labelIssues.AutoSize = true;
            this.labelIssues.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIssues.Location = new System.Drawing.Point(477, 334);
            this.labelIssues.Name = "labelIssues";
            this.labelIssues.Size = new System.Drawing.Size(63, 20);
            this.labelIssues.TabIndex = 44;
            this.labelIssues.Text = "Issues:";
            // 
            // grpBoxStatus
            // 
            this.grpBoxStatus.Controls.Add(this.labelDeclare);
            this.grpBoxStatus.Controls.Add(this.checkBoxDirty);
            this.grpBoxStatus.Controls.Add(this.checkBoxCleaned);
            this.grpBoxStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBoxStatus.Location = new System.Drawing.Point(468, 139);
            this.grpBoxStatus.Name = "grpBoxStatus";
            this.grpBoxStatus.Size = new System.Drawing.Size(333, 151);
            this.grpBoxStatus.TabIndex = 43;
            this.grpBoxStatus.TabStop = false;
            this.grpBoxStatus.Text = "Cleaning Status";
            // 
            // labelDeclare
            // 
            this.labelDeclare.AutoSize = true;
            this.labelDeclare.Location = new System.Drawing.Point(19, 30);
            this.labelDeclare.Name = "labelDeclare";
            this.labelDeclare.Size = new System.Drawing.Size(276, 54);
            this.labelDeclare.TabIndex = 2;
            this.labelDeclare.Text = "The status of Bedrooms and Beds, \r\nBathrooms, Windows, Doors, Furniture, \r\nand Fl" +
    "oors.";
            // 
            // checkBoxDirty
            // 
            this.checkBoxDirty.AutoSize = true;
            this.checkBoxDirty.Location = new System.Drawing.Point(182, 107);
            this.checkBoxDirty.Name = "checkBoxDirty";
            this.checkBoxDirty.Size = new System.Drawing.Size(60, 22);
            this.checkBoxDirty.TabIndex = 1;
            this.checkBoxDirty.Text = "Dirty";
            this.checkBoxDirty.UseVisualStyleBackColor = true;
            // 
            // checkBoxCleaned
            // 
            this.checkBoxCleaned.AutoSize = true;
            this.checkBoxCleaned.Location = new System.Drawing.Point(23, 107);
            this.checkBoxCleaned.Name = "checkBoxCleaned";
            this.checkBoxCleaned.Size = new System.Drawing.Size(84, 22);
            this.checkBoxCleaned.TabIndex = 0;
            this.checkBoxCleaned.Text = "Cleaned";
            this.checkBoxCleaned.UseVisualStyleBackColor = true;
            // 
            // grpBoxScheduleDetails
            // 
            this.grpBoxScheduleDetails.Controls.Add(this.lblVenue);
            this.grpBoxScheduleDetails.Controls.Add(this.lblScheduleTime);
            this.grpBoxScheduleDetails.Controls.Add(this.lblScheduleDate);
            this.grpBoxScheduleDetails.Controls.Add(this.lblRoomType);
            this.grpBoxScheduleDetails.Controls.Add(this.pictureBoxRoomType);
            this.grpBoxScheduleDetails.Controls.Add(this.pictureBoxDate);
            this.grpBoxScheduleDetails.Controls.Add(this.pictureBoxTime);
            this.grpBoxScheduleDetails.Controls.Add(this.pictureBoxVenue);
            this.grpBoxScheduleDetails.Controls.Add(this.lblRoomID);
            this.grpBoxScheduleDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBoxScheduleDetails.Location = new System.Drawing.Point(93, 139);
            this.grpBoxScheduleDetails.Name = "grpBoxScheduleDetails";
            this.grpBoxScheduleDetails.Size = new System.Drawing.Size(337, 350);
            this.grpBoxScheduleDetails.TabIndex = 42;
            this.grpBoxScheduleDetails.TabStop = false;
            this.grpBoxScheduleDetails.Text = "Schedule Details";
            // 
            // lblVenue
            // 
            this.lblVenue.AutoSize = true;
            this.lblVenue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblVenue.Location = new System.Drawing.Point(56, 280);
            this.lblVenue.Name = "lblVenue";
            this.lblVenue.Size = new System.Drawing.Size(2, 20);
            this.lblVenue.TabIndex = 65;
            // 
            // lblScheduleTime
            // 
            this.lblScheduleTime.AutoSize = true;
            this.lblScheduleTime.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblScheduleTime.Location = new System.Drawing.Point(56, 218);
            this.lblScheduleTime.Name = "lblScheduleTime";
            this.lblScheduleTime.Size = new System.Drawing.Size(2, 20);
            this.lblScheduleTime.TabIndex = 64;
            // 
            // lblScheduleDate
            // 
            this.lblScheduleDate.AutoSize = true;
            this.lblScheduleDate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblScheduleDate.Location = new System.Drawing.Point(56, 159);
            this.lblScheduleDate.Name = "lblScheduleDate";
            this.lblScheduleDate.Size = new System.Drawing.Size(2, 20);
            this.lblScheduleDate.TabIndex = 63;
            // 
            // lblRoomType
            // 
            this.lblRoomType.AutoSize = true;
            this.lblRoomType.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblRoomType.Location = new System.Drawing.Point(56, 98);
            this.lblRoomType.Name = "lblRoomType";
            this.lblRoomType.Size = new System.Drawing.Size(2, 20);
            this.lblRoomType.TabIndex = 62;
            // 
            // pictureBoxRoomType
            // 
            this.pictureBoxRoomType.Image = global::Hotel_Mgmt_Sys_IOOP_CSharp.Properties.Resources.roomType_HK;
            this.pictureBoxRoomType.Location = new System.Drawing.Point(22, 94);
            this.pictureBoxRoomType.Name = "pictureBoxRoomType";
            this.pictureBoxRoomType.Size = new System.Drawing.Size(28, 25);
            this.pictureBoxRoomType.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxRoomType.TabIndex = 61;
            this.pictureBoxRoomType.TabStop = false;
            // 
            // pictureBoxDate
            // 
            this.pictureBoxDate.Image = global::Hotel_Mgmt_Sys_IOOP_CSharp.Properties.Resources.calendar_HK;
            this.pictureBoxDate.Location = new System.Drawing.Point(22, 154);
            this.pictureBoxDate.Name = "pictureBoxDate";
            this.pictureBoxDate.Size = new System.Drawing.Size(28, 25);
            this.pictureBoxDate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxDate.TabIndex = 60;
            this.pictureBoxDate.TabStop = false;
            // 
            // pictureBoxTime
            // 
            this.pictureBoxTime.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxTime.ErrorImage")));
            this.pictureBoxTime.Image = global::Hotel_Mgmt_Sys_IOOP_CSharp.Properties.Resources.Time_HK;
            this.pictureBoxTime.Location = new System.Drawing.Point(22, 213);
            this.pictureBoxTime.Name = "pictureBoxTime";
            this.pictureBoxTime.Size = new System.Drawing.Size(28, 25);
            this.pictureBoxTime.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxTime.TabIndex = 58;
            this.pictureBoxTime.TabStop = false;
            // 
            // pictureBoxVenue
            // 
            this.pictureBoxVenue.Image = global::Hotel_Mgmt_Sys_IOOP_CSharp.Properties.Resources.venue_HK;
            this.pictureBoxVenue.Location = new System.Drawing.Point(22, 274);
            this.pictureBoxVenue.Name = "pictureBoxVenue";
            this.pictureBoxVenue.Size = new System.Drawing.Size(28, 26);
            this.pictureBoxVenue.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxVenue.TabIndex = 59;
            this.pictureBoxVenue.TabStop = false;
            // 
            // lblRoomID
            // 
            this.lblRoomID.AutoSize = true;
            this.lblRoomID.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblRoomID.Location = new System.Drawing.Point(22, 44);
            this.lblRoomID.Name = "lblRoomID";
            this.lblRoomID.Size = new System.Drawing.Size(2, 20);
            this.lblRoomID.TabIndex = 0;
            // 
            // labelCleaningStatusTitle
            // 
            this.labelCleaningStatusTitle.AutoSize = true;
            this.labelCleaningStatusTitle.Font = new System.Drawing.Font("Trebuchet MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCleaningStatusTitle.Location = new System.Drawing.Point(335, 66);
            this.labelCleaningStatusTitle.Name = "labelCleaningStatusTitle";
            this.labelCleaningStatusTitle.Size = new System.Drawing.Size(240, 28);
            this.labelCleaningStatusTitle.TabIndex = 41;
            this.labelCleaningStatusTitle.Text = "Cleaning Status Form";
            // 
            // labelShowStatus
            // 
            this.labelShowStatus.AutoSize = true;
            this.labelShowStatus.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelShowStatus.Location = new System.Drawing.Point(294, 513);
            this.labelShowStatus.Name = "labelShowStatus";
            this.labelShowStatus.Size = new System.Drawing.Size(2, 18);
            this.labelShowStatus.TabIndex = 47;
            this.labelShowStatus.Click += new System.EventHandler(this.labelShowStatus_Click);
            // 
            // CleaningStatusForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 554);
            this.Controls.Add(this.labelShowStatus);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.txtReportIssues);
            this.Controls.Add(this.labelIssues);
            this.Controls.Add(this.grpBoxStatus);
            this.Controls.Add(this.grpBoxScheduleDetails);
            this.Controls.Add(this.labelCleaningStatusTitle);
            this.Name = "CleaningStatusForm";
            this.Text = "CleaningStatusForm";
            this.grpBoxStatus.ResumeLayout(false);
            this.grpBoxStatus.PerformLayout();
            this.grpBoxScheduleDetails.ResumeLayout(false);
            this.grpBoxScheduleDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRoomType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVenue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.TextBox txtReportIssues;
        private System.Windows.Forms.Label labelIssues;
        private System.Windows.Forms.GroupBox grpBoxStatus;
        private System.Windows.Forms.Label labelDeclare;
        private System.Windows.Forms.CheckBox checkBoxDirty;
        private System.Windows.Forms.CheckBox checkBoxCleaned;
        private System.Windows.Forms.GroupBox grpBoxScheduleDetails;
        private System.Windows.Forms.Label lblVenue;
        private System.Windows.Forms.Label lblScheduleTime;
        private System.Windows.Forms.Label lblScheduleDate;
        private System.Windows.Forms.Label lblRoomType;
        private System.Windows.Forms.PictureBox pictureBoxRoomType;
        private System.Windows.Forms.PictureBox pictureBoxDate;
        private System.Windows.Forms.PictureBox pictureBoxTime;
        private System.Windows.Forms.PictureBox pictureBoxVenue;
        private System.Windows.Forms.Label lblRoomID;
        private System.Windows.Forms.Label labelCleaningStatusTitle;
        private System.Windows.Forms.Label labelShowStatus;
    }
}