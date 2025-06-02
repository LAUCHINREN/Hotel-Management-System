namespace Hotel_Mgmt_Sys_IOOP_CSharp
{
    partial class EditRoomFrm
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
            this.btnUpdate = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnGenerateID = new System.Windows.Forms.Button();
            this.nudGuest = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.nudRoom = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.nudLevel = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.txtRoomID = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cboRoomType = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.radBathtub = new System.Windows.Forms.RadioButton();
            this.radStandingShower = new System.Windows.Forms.RadioButton();
            this.grpAmenities = new System.Windows.Forms.GroupBox();
            this.txtAmenities = new System.Windows.Forms.TextBox();
            this.lblAmenities = new System.Windows.Forms.Label();
            this.nudAmenities = new System.Windows.Forms.NumericUpDown();
            this.cboBedType = new System.Windows.Forms.ComboBox();
            this.nudBathroom = new System.Windows.Forms.NumericUpDown();
            this.nudBeds = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudGuest)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRoom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLevel)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.grpAmenities.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAmenities)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBathroom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBeds)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(1177, 706);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(138, 40);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdateRoom_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnGenerateID);
            this.groupBox1.Controls.Add(this.nudGuest);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.nudRoom);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.nudLevel);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txtRoomID);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.cboRoomType);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(33, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(673, 234);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Room Information";
            // 
            // btnGenerateID
            // 
            this.btnGenerateID.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerateID.Location = new System.Drawing.Point(539, 36);
            this.btnGenerateID.Name = "btnGenerateID";
            this.btnGenerateID.Size = new System.Drawing.Size(112, 40);
            this.btnGenerateID.TabIndex = 18;
            this.btnGenerateID.Text = "Generate";
            this.btnGenerateID.UseVisualStyleBackColor = true;
            this.btnGenerateID.Click += new System.EventHandler(this.btnGenerateID_Click);
            // 
            // nudGuest
            // 
            this.nudGuest.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudGuest.Location = new System.Drawing.Point(227, 188);
            this.nudGuest.Name = "nudGuest";
            this.nudGuest.Size = new System.Drawing.Size(75, 31);
            this.nudGuest.TabIndex = 33;
            this.nudGuest.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(384, 98);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(61, 23);
            this.label13.TabIndex = 36;
            this.label13.Text = "Room";
            // 
            // nudRoom
            // 
            this.nudRoom.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudRoom.Location = new System.Drawing.Point(446, 96);
            this.nudRoom.Name = "nudRoom";
            this.nudRoom.Size = new System.Drawing.Size(75, 31);
            this.nudRoom.TabIndex = 35;
            this.nudRoom.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(223, 96);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(56, 23);
            this.label12.TabIndex = 34;
            this.label12.Text = "Level";
            // 
            // nudLevel
            // 
            this.nudLevel.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudLevel.Location = new System.Drawing.Point(285, 94);
            this.nudLevel.Name = "nudLevel";
            this.nudLevel.Size = new System.Drawing.Size(75, 31);
            this.nudLevel.TabIndex = 33;
            this.nudLevel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(24, 89);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(119, 25);
            this.label11.TabIndex = 17;
            this.label11.Text = "Room Venue";
            // 
            // txtRoomID
            // 
            this.txtRoomID.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRoomID.Location = new System.Drawing.Point(227, 42);
            this.txtRoomID.Name = "txtRoomID";
            this.txtRoomID.ReadOnly = true;
            this.txtRoomID.Size = new System.Drawing.Size(294, 31);
            this.txtRoomID.TabIndex = 13;
            this.txtRoomID.Text = "-";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(24, 188);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 25);
            this.label9.TabIndex = 15;
            this.label9.Text = "Guest(s)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Room ID";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(24, 139);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(105, 25);
            this.label10.TabIndex = 14;
            this.label10.Text = "Room Type";
            // 
            // cboRoomType
            // 
            this.cboRoomType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRoomType.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboRoomType.FormattingEnabled = true;
            this.cboRoomType.Location = new System.Drawing.Point(227, 139);
            this.cboRoomType.Name = "cboRoomType";
            this.cboRoomType.Size = new System.Drawing.Size(371, 31);
            this.cboRoomType.TabIndex = 13;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.groupBox5);
            this.groupBox2.Controls.Add(this.grpAmenities);
            this.groupBox2.Controls.Add(this.lblAmenities);
            this.groupBox2.Controls.Add(this.nudAmenities);
            this.groupBox2.Controls.Add(this.cboBedType);
            this.groupBox2.Controls.Add(this.nudBathroom);
            this.groupBox2.Controls.Add(this.nudBeds);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(33, 283);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1285, 406);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Room Feature(s)";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(664, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(205, 31);
            this.label4.TabIndex = 34;
            this.label4.Text = "Amenities Add-On(s)";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.radBathtub);
            this.groupBox5.Controls.Add(this.radStandingShower);
            this.groupBox5.Location = new System.Drawing.Point(227, 83);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(371, 94);
            this.groupBox5.TabIndex = 33;
            this.groupBox5.TabStop = false;
            // 
            // radBathtub
            // 
            this.radBathtub.AutoSize = true;
            this.radBathtub.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radBathtub.Location = new System.Drawing.Point(16, 57);
            this.radBathtub.Name = "radBathtub";
            this.radBathtub.Size = new System.Drawing.Size(100, 27);
            this.radBathtub.TabIndex = 17;
            this.radBathtub.TabStop = true;
            this.radBathtub.Text = "Bathtub";
            this.radBathtub.UseVisualStyleBackColor = true;
            // 
            // radStandingShower
            // 
            this.radStandingShower.AutoSize = true;
            this.radStandingShower.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radStandingShower.Location = new System.Drawing.Point(16, 24);
            this.radStandingShower.Name = "radStandingShower";
            this.radStandingShower.Size = new System.Drawing.Size(176, 27);
            this.radStandingShower.TabIndex = 15;
            this.radStandingShower.TabStop = true;
            this.radStandingShower.Text = "Standing Shower";
            this.radStandingShower.UseVisualStyleBackColor = true;
            // 
            // grpAmenities
            // 
            this.grpAmenities.Controls.Add(this.txtAmenities);
            this.grpAmenities.Location = new System.Drawing.Point(699, 168);
            this.grpAmenities.Name = "grpAmenities";
            this.grpAmenities.Size = new System.Drawing.Size(583, 212);
            this.grpAmenities.TabIndex = 32;
            this.grpAmenities.TabStop = false;
            // 
            // txtAmenities
            // 
            this.txtAmenities.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmenities.Location = new System.Drawing.Point(14, 25);
            this.txtAmenities.Multiline = true;
            this.txtAmenities.Name = "txtAmenities";
            this.txtAmenities.Size = new System.Drawing.Size(563, 181);
            this.txtAmenities.TabIndex = 21;
            // 
            // lblAmenities
            // 
            this.lblAmenities.AutoSize = true;
            this.lblAmenities.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmenities.Location = new System.Drawing.Point(801, 95);
            this.lblAmenities.Name = "lblAmenities";
            this.lblAmenities.Size = new System.Drawing.Size(469, 29);
            this.lblAmenities.TabIndex = 31;
            this.lblAmenities.Text = "set(s) of Slippers, Bathrobes and Toiletries";
            // 
            // nudAmenities
            // 
            this.nudAmenities.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudAmenities.Location = new System.Drawing.Point(711, 92);
            this.nudAmenities.Name = "nudAmenities";
            this.nudAmenities.Size = new System.Drawing.Size(75, 31);
            this.nudAmenities.TabIndex = 30;
            this.nudAmenities.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cboBedType
            // 
            this.cboBedType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBedType.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboBedType.FormattingEnabled = true;
            this.cboBedType.Location = new System.Drawing.Point(324, 46);
            this.cboBedType.Name = "cboBedType";
            this.cboBedType.Size = new System.Drawing.Size(274, 31);
            this.cboBedType.TabIndex = 17;
            // 
            // nudBathroom
            // 
            this.nudBathroom.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudBathroom.Location = new System.Drawing.Point(227, 191);
            this.nudBathroom.Name = "nudBathroom";
            this.nudBathroom.Size = new System.Drawing.Size(75, 31);
            this.nudBathroom.TabIndex = 16;
            this.nudBathroom.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // nudBeds
            // 
            this.nudBeds.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudBeds.Location = new System.Drawing.Point(227, 46);
            this.nudBeds.Name = "nudBeds";
            this.nudBeds.Size = new System.Drawing.Size(75, 31);
            this.nudBeds.TabIndex = 14;
            this.nudBeds.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(664, 46);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(148, 31);
            this.label7.TabIndex = 11;
            this.label7.Text = "Amenities";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(24, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(138, 25);
            this.label6.TabIndex = 10;
            this.label6.Text = "Bathroom Type";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(24, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "Bathroom(s)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Bed(s)";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtPrice);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(732, 25);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(586, 234);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Room Rate";
            // 
            // txtPrice
            // 
            this.txtPrice.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.Location = new System.Drawing.Point(260, 50);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(225, 31);
            this.txtPrice.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(211, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 31);
            this.label3.TabIndex = 20;
            this.label3.Text = "RM";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(13, 50);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(137, 25);
            this.label8.TabIndex = 12;
            this.label8.Text = "Price Per Night";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Controls.Add(this.btnUpdate);
            this.panel2.Controls.Add(this.groupBox3);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1365, 777);
            this.panel2.TabIndex = 3;
            // 
            // EditRoomFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1389, 806);
            this.Controls.Add(this.panel2);
            this.Name = "EditRoomFrm";
            this.Text = "EditRoom";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudGuest)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRoom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLevel)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.grpAmenities.ResumeLayout(false);
            this.grpAmenities.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAmenities)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBathroom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBeds)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtRoomID;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cboRoomType;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblAmenities;
        private System.Windows.Forms.NumericUpDown nudAmenities;
        private System.Windows.Forms.ComboBox cboBedType;
        private System.Windows.Forms.RadioButton radBathtub;
        private System.Windows.Forms.NumericUpDown nudBathroom;
        private System.Windows.Forms.RadioButton radStandingShower;
        private System.Windows.Forms.NumericUpDown nudBeds;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox grpAmenities;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.NumericUpDown nudRoom;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown nudLevel;
        private System.Windows.Forms.NumericUpDown nudGuest;
        private System.Windows.Forms.Button btnGenerateID;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAmenities;
    }
}