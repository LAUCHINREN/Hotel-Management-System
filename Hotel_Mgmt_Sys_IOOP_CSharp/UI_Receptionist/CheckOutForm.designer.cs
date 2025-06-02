namespace Hotel_Mgmt_Sys_IOOP_CSharp
{
    partial class CheckOutForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtReservationID = new System.Windows.Forms.TextBox();
            this.txtRoomID = new System.Windows.Forms.TextBox();
            this.txtAdditionalFee = new System.Windows.Forms.TextBox();
            this.Confirm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(194, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "RoomID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(194, 202);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "ReservationID:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(194, 271);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "AdditionalFee:";
            // 
            // txtReservationID
            // 
            this.txtReservationID.Location = new System.Drawing.Point(409, 196);
            this.txtReservationID.Name = "txtReservationID";
            this.txtReservationID.Size = new System.Drawing.Size(100, 22);
            this.txtReservationID.TabIndex = 4;
            // 
            // txtRoomID
            // 
            this.txtRoomID.Location = new System.Drawing.Point(409, 120);
            this.txtRoomID.Name = "txtRoomID";
            this.txtRoomID.Size = new System.Drawing.Size(100, 22);
            this.txtRoomID.TabIndex = 5;
            // 
            // txtAdditionalFee
            // 
            this.txtAdditionalFee.Location = new System.Drawing.Point(409, 265);
            this.txtAdditionalFee.Name = "txtAdditionalFee";
            this.txtAdditionalFee.Size = new System.Drawing.Size(100, 22);
            this.txtAdditionalFee.TabIndex = 6;
            // 
            // Confirm
            // 
            this.Confirm.Location = new System.Drawing.Point(630, 195);
            this.Confirm.Name = "Confirm";
            this.Confirm.Size = new System.Drawing.Size(106, 52);
            this.Confirm.TabIndex = 7;
            this.Confirm.Text = "Confirm";
            this.Confirm.UseVisualStyleBackColor = true;
            this.Confirm.Click += new System.EventHandler(this.Confirm_Click);
            // 
            // CheckOutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Confirm);
            this.Controls.Add(this.txtAdditionalFee);
            this.Controls.Add(this.txtRoomID);
            this.Controls.Add(this.txtReservationID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CheckOutForm";
            this.Text = "CheckOutForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtReservationID;
        private System.Windows.Forms.TextBox txtRoomID;
        private System.Windows.Forms.TextBox txtAdditionalFee;
        private System.Windows.Forms.Button Confirm;
    }
}