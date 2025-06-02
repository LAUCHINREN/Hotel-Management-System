namespace Hotel_Mgmt_Sys_IOOP_CSharp
{
    partial class CustomerHomePage
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
            this.btnRoomReservation = new System.Windows.Forms.Button();
            this.btnManageReservation = new System.Windows.Forms.Button();
            this.btnUpdateProfile_Customer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRoomReservation
            // 
            this.btnRoomReservation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(13)))), ((int)(((byte)(38)))));
            this.btnRoomReservation.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold);
            this.btnRoomReservation.ForeColor = System.Drawing.Color.White;
            this.btnRoomReservation.Location = new System.Drawing.Point(273, 84);
            this.btnRoomReservation.Name = "btnRoomReservation";
            this.btnRoomReservation.Size = new System.Drawing.Size(240, 71);
            this.btnRoomReservation.TabIndex = 0;
            this.btnRoomReservation.Text = "Room Reservation";
            this.btnRoomReservation.UseVisualStyleBackColor = false;
            this.btnRoomReservation.Click += new System.EventHandler(this.btnRoomReservation_Click);
            // 
            // btnManageReservation
            // 
            this.btnManageReservation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(13)))), ((int)(((byte)(38)))));
            this.btnManageReservation.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold);
            this.btnManageReservation.ForeColor = System.Drawing.Color.White;
            this.btnManageReservation.Location = new System.Drawing.Point(273, 185);
            this.btnManageReservation.Name = "btnManageReservation";
            this.btnManageReservation.Size = new System.Drawing.Size(240, 70);
            this.btnManageReservation.TabIndex = 1;
            this.btnManageReservation.Text = "Manage Reservation";
            this.btnManageReservation.UseVisualStyleBackColor = false;
            this.btnManageReservation.Click += new System.EventHandler(this.btnManageReservation_Click);
            // 
            // btnUpdateProfile_Customer
            // 
            this.btnUpdateProfile_Customer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(13)))), ((int)(((byte)(38)))));
            this.btnUpdateProfile_Customer.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold);
            this.btnUpdateProfile_Customer.ForeColor = System.Drawing.Color.White;
            this.btnUpdateProfile_Customer.Location = new System.Drawing.Point(273, 284);
            this.btnUpdateProfile_Customer.Name = "btnUpdateProfile_Customer";
            this.btnUpdateProfile_Customer.Size = new System.Drawing.Size(240, 78);
            this.btnUpdateProfile_Customer.TabIndex = 2;
            this.btnUpdateProfile_Customer.Text = "Update My Profile";
            this.btnUpdateProfile_Customer.UseVisualStyleBackColor = false;
            this.btnUpdateProfile_Customer.Click += new System.EventHandler(this.btnUpdateProfile_Customer_Click);
            // 
            // CustomerHomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnUpdateProfile_Customer);
            this.Controls.Add(this.btnManageReservation);
            this.Controls.Add(this.btnRoomReservation);
            this.Name = "CustomerHomePage";
            this.Text = "CustomerHomePage";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRoomReservation;
        private System.Windows.Forms.Button btnManageReservation;
        private System.Windows.Forms.Button btnUpdateProfile_Customer;
    }
}