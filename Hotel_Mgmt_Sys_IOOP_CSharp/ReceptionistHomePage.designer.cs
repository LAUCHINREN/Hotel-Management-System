namespace Hotel_Mgmt_Sys_IOOP_CSharp
{
    partial class ReceptionistHomePage
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
            this.cutomerdetailsbutton = new System.Windows.Forms.Button();
            this.roomconditionbutton = new System.Windows.Forms.Button();
            this.reservationbutton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cutomerdetailsbutton
            // 
            this.cutomerdetailsbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(13)))), ((int)(((byte)(38)))));
            this.cutomerdetailsbutton.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold);
            this.cutomerdetailsbutton.ForeColor = System.Drawing.Color.White;
            this.cutomerdetailsbutton.Location = new System.Drawing.Point(271, 50);
            this.cutomerdetailsbutton.Name = "cutomerdetailsbutton";
            this.cutomerdetailsbutton.Size = new System.Drawing.Size(240, 71);
            this.cutomerdetailsbutton.TabIndex = 0;
            this.cutomerdetailsbutton.Text = "CuctomerDetails";
            this.cutomerdetailsbutton.UseVisualStyleBackColor = false;
            this.cutomerdetailsbutton.Click += new System.EventHandler(this.cutomerdetailsbutton_Click);
            // 
            // roomconditionbutton
            // 
            this.roomconditionbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(13)))), ((int)(((byte)(38)))));
            this.roomconditionbutton.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold);
            this.roomconditionbutton.ForeColor = System.Drawing.Color.White;
            this.roomconditionbutton.Location = new System.Drawing.Point(271, 151);
            this.roomconditionbutton.Name = "roomconditionbutton";
            this.roomconditionbutton.Size = new System.Drawing.Size(240, 70);
            this.roomconditionbutton.TabIndex = 1;
            this.roomconditionbutton.Text = "RoomCondition";
            this.roomconditionbutton.UseVisualStyleBackColor = false;
            this.roomconditionbutton.Click += new System.EventHandler(this.roomconditionbutton_Click);
            // 
            // reservationbutton
            // 
            this.reservationbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(13)))), ((int)(((byte)(38)))));
            this.reservationbutton.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold);
            this.reservationbutton.ForeColor = System.Drawing.Color.White;
            this.reservationbutton.Location = new System.Drawing.Point(271, 250);
            this.reservationbutton.Name = "reservationbutton";
            this.reservationbutton.Size = new System.Drawing.Size(240, 78);
            this.reservationbutton.TabIndex = 2;
            this.reservationbutton.Text = "Reservation";
            this.reservationbutton.UseVisualStyleBackColor = false;
            this.reservationbutton.Click += new System.EventHandler(this.reservationbutton_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(13)))), ((int)(((byte)(38)))));
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(271, 344);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(240, 78);
            this.button1.TabIndex = 3;
            this.button1.Text = "Update My Profile";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ReceptionistHomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.reservationbutton);
            this.Controls.Add(this.roomconditionbutton);
            this.Controls.Add(this.cutomerdetailsbutton);
            this.Name = "ReceptionistHomePage";
            this.Text = "ReceptionistMainPage";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cutomerdetailsbutton;
        private System.Windows.Forms.Button roomconditionbutton;
        private System.Windows.Forms.Button reservationbutton;
        private System.Windows.Forms.Button button1;
    }
}