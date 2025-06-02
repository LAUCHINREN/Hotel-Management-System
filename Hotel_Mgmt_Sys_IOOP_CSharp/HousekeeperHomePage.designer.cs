namespace Hotel_Mgmt_Sys_IOOP_CSharp
{
    partial class HousekeeperHomePage
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
            this.btnSchedule = new System.Windows.Forms.Button();
            this.btn = new System.Windows.Forms.Button();
            this.btnSupplies = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSchedule
            // 
            this.btnSchedule.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(13)))), ((int)(((byte)(38)))));
            this.btnSchedule.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold);
            this.btnSchedule.ForeColor = System.Drawing.Color.White;
            this.btnSchedule.Location = new System.Drawing.Point(271, 50);
            this.btnSchedule.Name = "btnSchedule";
            this.btnSchedule.Size = new System.Drawing.Size(240, 71);
            this.btnSchedule.TabIndex = 0;
            this.btnSchedule.Text = "My Cleaning Schedule";
            this.btnSchedule.UseVisualStyleBackColor = false;
            this.btnSchedule.Click += new System.EventHandler(this.btnSchedule_Click);
            // 
            // btn
            // 
            this.btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(13)))), ((int)(((byte)(38)))));
            this.btn.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold);
            this.btn.ForeColor = System.Drawing.Color.White;
            this.btn.Location = new System.Drawing.Point(271, 151);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(240, 70);
            this.btn.TabIndex = 1;
            this.btn.Text = "btn";
            this.btn.UseVisualStyleBackColor = false;
            this.btn.Click += new System.EventHandler(this.roomconditionbutton_Click);
            // 
            // btnSupplies
            // 
            this.btnSupplies.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(13)))), ((int)(((byte)(38)))));
            this.btnSupplies.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold);
            this.btnSupplies.ForeColor = System.Drawing.Color.White;
            this.btnSupplies.Location = new System.Drawing.Point(271, 250);
            this.btnSupplies.Name = "btnSupplies";
            this.btnSupplies.Size = new System.Drawing.Size(240, 78);
            this.btnSupplies.TabIndex = 2;
            this.btnSupplies.Text = "Manage Cleaning Supplies";
            this.btnSupplies.UseVisualStyleBackColor = false;
            this.btnSupplies.Click += new System.EventHandler(this.btnSupplies_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(13)))), ((int)(((byte)(38)))));
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(271, 368);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(240, 70);
            this.button1.TabIndex = 3;
            this.button1.Text = "Update My Profile";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // HousekeeperHomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 508);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnSupplies);
            this.Controls.Add(this.btn);
            this.Controls.Add(this.btnSchedule);
            this.Name = "HousekeeperHomePage";
            this.Text = "HousekeeperHomePage";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSchedule;
        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.Button btnSupplies;
        private System.Windows.Forms.Button button1;
    }
}