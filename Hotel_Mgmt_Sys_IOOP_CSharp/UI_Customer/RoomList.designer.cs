namespace Hotel_Mgmt_Sys_IOOP_CSharp
{
    partial class RoomList
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelRoom = new System.Windows.Forms.Panel();
            this.pictureRoom = new System.Windows.Forms.PictureBox();
            this.lblMessage = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnMoreInfo = new System.Windows.Forms.Button();
            this.lblPrice = new System.Windows.Forms.Label();
            this.panelRoom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureRoom)).BeginInit();
            this.SuspendLayout();
            // 
            // panelRoom
            // 
            this.panelRoom.BackColor = System.Drawing.Color.Teal;
            this.panelRoom.Controls.Add(this.pictureRoom);
            this.panelRoom.Location = new System.Drawing.Point(0, 0);
            this.panelRoom.Name = "panelRoom";
            this.panelRoom.Size = new System.Drawing.Size(283, 222);
            this.panelRoom.TabIndex = 4;
            // 
            // pictureRoom
            // 
            this.pictureRoom.BackColor = System.Drawing.Color.Transparent;
            this.pictureRoom.ErrorImage = null;
            this.pictureRoom.Location = new System.Drawing.Point(15, 19);
            this.pictureRoom.Name = "pictureRoom";
            this.pictureRoom.Size = new System.Drawing.Size(249, 182);
            this.pictureRoom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureRoom.TabIndex = 0;
            this.pictureRoom.TabStop = false;
            // 
            // lblMessage
            // 
            this.lblMessage.AutoEllipsis = true;
            this.lblMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.Location = new System.Drawing.Point(322, 71);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(579, 88);
            this.lblMessage.TabIndex = 6;
            this.lblMessage.Text = "111";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoEllipsis = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(320, 19);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(606, 52);
            this.lblTitle.TabIndex = 5;
            this.lblTitle.Text = "Title";
            // 
            // btnMoreInfo
            // 
            this.btnMoreInfo.BackColor = System.Drawing.Color.DarkCyan;
            this.btnMoreInfo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnMoreInfo.Location = new System.Drawing.Point(854, 163);
            this.btnMoreInfo.Name = "btnMoreInfo";
            this.btnMoreInfo.Size = new System.Drawing.Size(104, 38);
            this.btnMoreInfo.TabIndex = 7;
            this.btnMoreInfo.Text = "More Info";
            this.btnMoreInfo.UseVisualStyleBackColor = false;
            this.btnMoreInfo.Click += new System.EventHandler(this.btnMoreInfo_Click);
            // 
            // lblPrice
            // 
            this.lblPrice.AutoEllipsis = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(661, 159);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(171, 42);
            this.lblPrice.TabIndex = 8;
            this.lblPrice.Text = "111";
            this.lblPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // roomlist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.btnMoreInfo);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.panelRoom);
            this.Name = "roomlist";
            this.Size = new System.Drawing.Size(994, 220);
            this.panelRoom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureRoom)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelRoom;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox pictureRoom;
        private System.Windows.Forms.Button btnMoreInfo;
        private System.Windows.Forms.Label lblPrice;
    }
}
