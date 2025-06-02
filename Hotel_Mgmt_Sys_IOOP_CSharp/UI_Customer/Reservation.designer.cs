namespace Hotel_Mgmt_Sys_IOOP_CSharp
{
    partial class Reservation
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
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.dataGridReservations = new System.Windows.Forms.DataGridView();
            this.lblTitleReservation = new System.Windows.Forms.Label();
            this.btnAddRating = new System.Windows.Forms.Button();
            this.lblCheckin = new System.Windows.Forms.Label();
            this.txtCheckin = new System.Windows.Forms.TextBox();
            this.grpEdit = new System.Windows.Forms.GroupBox();
            this.txtReservationID = new System.Windows.Forms.TextBox();
            this.lblReservationID = new System.Windows.Forms.Label();
            this.txtAdditionalRequest = new System.Windows.Forms.TextBox();
            this.txtCheckout = new System.Windows.Forms.TextBox();
            this.lblAdditionalRequest = new System.Windows.Forms.Label();
            this.lblCheckout = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridReservations)).BeginInit();
            this.grpEdit.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(286, 107);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(159, 39);
            this.btnEdit.TabIndex = 7;
            this.btnEdit.Text = "Edit Reservation";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(38, 309);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(145, 39);
            this.btnDel.TabIndex = 6;
            this.btnDel.Text = "Delete Reservation";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // dataGridReservations
            // 
            this.dataGridReservations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridReservations.Location = new System.Drawing.Point(38, 72);
            this.dataGridReservations.Name = "dataGridReservations";
            this.dataGridReservations.RowHeadersWidth = 51;
            this.dataGridReservations.RowTemplate.Height = 24;
            this.dataGridReservations.Size = new System.Drawing.Size(719, 188);
            this.dataGridReservations.TabIndex = 5;
            this.dataGridReservations.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridReservations_CellContentClick);
            // 
            // lblTitleReservation
            // 
            this.lblTitleReservation.AutoSize = true;
            this.lblTitleReservation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleReservation.Location = new System.Drawing.Point(35, 41);
            this.lblTitleReservation.Name = "lblTitleReservation";
            this.lblTitleReservation.Size = new System.Drawing.Size(98, 18);
            this.lblTitleReservation.TabIndex = 4;
            this.lblTitleReservation.Text = "Reservation";
            // 
            // btnAddRating
            // 
            this.btnAddRating.Location = new System.Drawing.Point(38, 367);
            this.btnAddRating.Name = "btnAddRating";
            this.btnAddRating.Size = new System.Drawing.Size(215, 34);
            this.btnAddRating.TabIndex = 8;
            this.btnAddRating.Text = "Add Rating and Comment";
            this.btnAddRating.UseVisualStyleBackColor = true;
            this.btnAddRating.Click += new System.EventHandler(this.btnAddRating_Click);
            // 
            // lblCheckin
            // 
            this.lblCheckin.AutoSize = true;
            this.lblCheckin.Location = new System.Drawing.Point(29, 72);
            this.lblCheckin.Name = "lblCheckin";
            this.lblCheckin.Size = new System.Drawing.Size(94, 16);
            this.lblCheckin.TabIndex = 9;
            this.lblCheckin.Text = "Check-in Date:";
            // 
            // txtCheckin
            // 
            this.txtCheckin.Location = new System.Drawing.Point(131, 70);
            this.txtCheckin.Name = "txtCheckin";
            this.txtCheckin.Size = new System.Drawing.Size(114, 22);
            this.txtCheckin.TabIndex = 10;
            // 
            // grpEdit
            // 
            this.grpEdit.Controls.Add(this.txtReservationID);
            this.grpEdit.Controls.Add(this.lblReservationID);
            this.grpEdit.Controls.Add(this.txtAdditionalRequest);
            this.grpEdit.Controls.Add(this.txtCheckout);
            this.grpEdit.Controls.Add(this.lblAdditionalRequest);
            this.grpEdit.Controls.Add(this.lblCheckout);
            this.grpEdit.Controls.Add(this.lblCheckin);
            this.grpEdit.Controls.Add(this.txtCheckin);
            this.grpEdit.Controls.Add(this.btnEdit);
            this.grpEdit.Location = new System.Drawing.Point(274, 277);
            this.grpEdit.Name = "grpEdit";
            this.grpEdit.Size = new System.Drawing.Size(483, 161);
            this.grpEdit.TabIndex = 11;
            this.grpEdit.TabStop = false;
            // 
            // txtReservationID
            // 
            this.txtReservationID.Location = new System.Drawing.Point(131, 40);
            this.txtReservationID.Name = "txtReservationID";
            this.txtReservationID.Size = new System.Drawing.Size(114, 22);
            this.txtReservationID.TabIndex = 16;
            // 
            // lblReservationID
            // 
            this.lblReservationID.AutoSize = true;
            this.lblReservationID.Location = new System.Drawing.Point(29, 40);
            this.lblReservationID.Name = "lblReservationID";
            this.lblReservationID.Size = new System.Drawing.Size(96, 16);
            this.lblReservationID.TabIndex = 15;
            this.lblReservationID.Text = "ReservationID:";
            // 
            // txtAdditionalRequest
            // 
            this.txtAdditionalRequest.Location = new System.Drawing.Point(266, 56);
            this.txtAdditionalRequest.Multiline = true;
            this.txtAdditionalRequest.Name = "txtAdditionalRequest";
            this.txtAdditionalRequest.Size = new System.Drawing.Size(200, 45);
            this.txtAdditionalRequest.TabIndex = 14;
            // 
            // txtCheckout
            // 
            this.txtCheckout.Location = new System.Drawing.Point(131, 102);
            this.txtCheckout.Name = "txtCheckout";
            this.txtCheckout.Size = new System.Drawing.Size(114, 22);
            this.txtCheckout.TabIndex = 13;
            // 
            // lblAdditionalRequest
            // 
            this.lblAdditionalRequest.AutoSize = true;
            this.lblAdditionalRequest.Location = new System.Drawing.Point(263, 28);
            this.lblAdditionalRequest.Name = "lblAdditionalRequest";
            this.lblAdditionalRequest.Size = new System.Drawing.Size(131, 16);
            this.lblAdditionalRequest.TabIndex = 12;
            this.lblAdditionalRequest.Text = "Additional Requests:";
            // 
            // lblCheckout
            // 
            this.lblCheckout.AutoSize = true;
            this.lblCheckout.Location = new System.Drawing.Point(23, 105);
            this.lblCheckout.Name = "lblCheckout";
            this.lblCheckout.Size = new System.Drawing.Size(102, 16);
            this.lblCheckout.TabIndex = 11;
            this.lblCheckout.Text = "Check-out Date:";
            // 
            // Reservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grpEdit);
            this.Controls.Add(this.btnAddRating);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.dataGridReservations);
            this.Controls.Add(this.lblTitleReservation);
            this.Name = "Reservation";
            this.Text = "Reservation";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridReservations)).EndInit();
            this.grpEdit.ResumeLayout(false);
            this.grpEdit.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.DataGridView dataGridReservations;
        private System.Windows.Forms.Label lblTitleReservation;
        private System.Windows.Forms.Button btnAddRating;
        private System.Windows.Forms.Label lblCheckin;
        private System.Windows.Forms.TextBox txtCheckin;
        private System.Windows.Forms.GroupBox grpEdit;
        private System.Windows.Forms.TextBox txtAdditionalRequest;
        private System.Windows.Forms.TextBox txtCheckout;
        private System.Windows.Forms.Label lblAdditionalRequest;
        private System.Windows.Forms.Label lblCheckout;
        private System.Windows.Forms.TextBox txtReservationID;
        private System.Windows.Forms.Label lblReservationID;
    }
}