namespace Hotel_Mgmt_Sys_IOOP_CSharp
{
    partial class ManagerHomePage
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
            this.btnManageRoom = new System.Windows.Forms.Button();
            this.btnManageUser = new System.Windows.Forms.Button();
            this.btnManageHousekeeping = new System.Windows.Forms.Button();
            this.btnViewReports = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnManageRoom
            // 
            this.btnManageRoom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(13)))), ((int)(((byte)(38)))));
            this.btnManageRoom.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageRoom.ForeColor = System.Drawing.Color.White;
            this.btnManageRoom.Location = new System.Drawing.Point(276, 140);
            this.btnManageRoom.Name = "btnManageRoom";
            this.btnManageRoom.Size = new System.Drawing.Size(240, 71);
            this.btnManageRoom.TabIndex = 0;
            this.btnManageRoom.Text = "Manage Room";
            this.btnManageRoom.UseVisualStyleBackColor = false;
            this.btnManageRoom.Click += new System.EventHandler(this.btnManageRoom_Click);
            // 
            // btnManageUser
            // 
            this.btnManageUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(13)))), ((int)(((byte)(38)))));
            this.btnManageUser.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageUser.ForeColor = System.Drawing.Color.White;
            this.btnManageUser.Location = new System.Drawing.Point(276, 48);
            this.btnManageUser.Name = "btnManageUser";
            this.btnManageUser.Size = new System.Drawing.Size(240, 70);
            this.btnManageUser.TabIndex = 1;
            this.btnManageUser.Text = "Manage User";
            this.btnManageUser.UseVisualStyleBackColor = false;
            this.btnManageUser.Click += new System.EventHandler(this.btnManageUser_Click);
            // 
            // btnManageHousekeeping
            // 
            this.btnManageHousekeeping.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(13)))), ((int)(((byte)(38)))));
            this.btnManageHousekeeping.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageHousekeeping.ForeColor = System.Drawing.Color.White;
            this.btnManageHousekeeping.Location = new System.Drawing.Point(276, 232);
            this.btnManageHousekeeping.Name = "btnManageHousekeeping";
            this.btnManageHousekeeping.Size = new System.Drawing.Size(240, 70);
            this.btnManageHousekeeping.TabIndex = 3;
            this.btnManageHousekeeping.Text = "Manage Housekeeping";
            this.btnManageHousekeeping.UseVisualStyleBackColor = false;
            this.btnManageHousekeeping.Click += new System.EventHandler(this.btnManageHousekeeping_Click);
            // 
            // btnViewReports
            // 
            this.btnViewReports.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(13)))), ((int)(((byte)(38)))));
            this.btnViewReports.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewReports.ForeColor = System.Drawing.Color.White;
            this.btnViewReports.Location = new System.Drawing.Point(276, 324);
            this.btnViewReports.Name = "btnViewReports";
            this.btnViewReports.Size = new System.Drawing.Size(240, 71);
            this.btnViewReports.TabIndex = 2;
            this.btnViewReports.Text = "View Reports";
            this.btnViewReports.UseVisualStyleBackColor = false;
            this.btnViewReports.Click += new System.EventHandler(this.btnViewReports_Click);
            // 
            // ManagerHomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnManageHousekeeping);
            this.Controls.Add(this.btnViewReports);
            this.Controls.Add(this.btnManageUser);
            this.Controls.Add(this.btnManageRoom);
            this.Name = "ManagerHomePage";
            this.Text = "ManagerHomePage";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnManageRoom;
        private System.Windows.Forms.Button btnManageUser;
        private System.Windows.Forms.Button btnManageHousekeeping;
        private System.Windows.Forms.Button btnViewReports;
    }
}