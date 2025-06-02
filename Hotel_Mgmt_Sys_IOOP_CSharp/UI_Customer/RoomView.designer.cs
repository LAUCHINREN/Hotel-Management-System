namespace Hotel_Mgmt_Sys_IOOP_CSharp
{
    partial class RoomView
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
            this.panellist = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.lblDays = new System.Windows.Forms.Label();
            this.btnFilter = new System.Windows.Forms.Button();
            this.lblCheckout = new System.Windows.Forms.Label();
            this.lblCheckin = new System.Windows.Forms.Label();
            this.dateTimeCheckout = new System.Windows.Forms.DateTimePicker();
            this.dateTimeCheckin = new System.Windows.Forms.DateTimePicker();
            this.btnProfile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panellist
            // 
            this.panellist.BackColor = System.Drawing.Color.Teal;
            this.panellist.Location = new System.Drawing.Point(0, 1);
            this.panellist.Name = "panellist";
            this.panellist.Size = new System.Drawing.Size(351, 195);
            this.panellist.TabIndex = 2;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(351, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1111, 944);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // lblDays
            // 
            this.lblDays.AutoSize = true;
            this.lblDays.BackColor = System.Drawing.SystemColors.Control;
            this.lblDays.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDays.Location = new System.Drawing.Point(69, 429);
            this.lblDays.Name = "lblDays";
            this.lblDays.Size = new System.Drawing.Size(2, 18);
            this.lblDays.TabIndex = 31;
            // 
            // btnFilter
            // 
            this.btnFilter.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnFilter.Location = new System.Drawing.Point(123, 390);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(75, 23);
            this.btnFilter.TabIndex = 30;
            this.btnFilter.Text = "Filter";
            this.btnFilter.UseVisualStyleBackColor = false;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // lblCheckout
            // 
            this.lblCheckout.AutoSize = true;
            this.lblCheckout.Location = new System.Drawing.Point(129, 321);
            this.lblCheckout.Name = "lblCheckout";
            this.lblCheckout.Size = new System.Drawing.Size(69, 16);
            this.lblCheckout.TabIndex = 29;
            this.lblCheckout.Text = "Check-Out";
            // 
            // lblCheckin
            // 
            this.lblCheckin.AutoSize = true;
            this.lblCheckin.Location = new System.Drawing.Point(129, 249);
            this.lblCheckin.Name = "lblCheckin";
            this.lblCheckin.Size = new System.Drawing.Size(59, 16);
            this.lblCheckin.TabIndex = 28;
            this.lblCheckin.Text = "Check-In";
            // 
            // dateTimeCheckout
            // 
            this.dateTimeCheckout.Location = new System.Drawing.Point(69, 351);
            this.dateTimeCheckout.Name = "dateTimeCheckout";
            this.dateTimeCheckout.Size = new System.Drawing.Size(187, 22);
            this.dateTimeCheckout.TabIndex = 27;
            // 
            // dateTimeCheckin
            // 
            this.dateTimeCheckin.Location = new System.Drawing.Point(69, 281);
            this.dateTimeCheckin.Name = "dateTimeCheckin";
            this.dateTimeCheckin.Size = new System.Drawing.Size(187, 22);
            this.dateTimeCheckin.TabIndex = 26;
            this.dateTimeCheckin.Value = new System.DateTime(2024, 7, 4, 0, 0, 0, 0);
            // 
            // btnProfile
            // 
            this.btnProfile.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnProfile.Location = new System.Drawing.Point(21, 489);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(108, 39);
            this.btnProfile.TabIndex = 0;
            this.btnProfile.Text = "Profile";
            this.btnProfile.UseVisualStyleBackColor = false;
            this.btnProfile.Click += new System.EventHandler(this.btnProfile_Click);
            // 
            // RoomView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1462, 944);
            this.Controls.Add(this.btnProfile);
            this.Controls.Add(this.lblDays);
            this.Controls.Add(this.btnFilter);
            this.Controls.Add(this.lblCheckout);
            this.Controls.Add(this.lblCheckin);
            this.Controls.Add(this.dateTimeCheckout);
            this.Controls.Add(this.dateTimeCheckin);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panellist);
            this.Name = "RoomView";
            this.Text = "Room View";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panellist;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label lblDays;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.Label lblCheckout;
        private System.Windows.Forms.Label lblCheckin;
        private System.Windows.Forms.DateTimePicker dateTimeCheckout;
        private System.Windows.Forms.DateTimePicker dateTimeCheckin;
        private System.Windows.Forms.Button btnProfile;
    }
}