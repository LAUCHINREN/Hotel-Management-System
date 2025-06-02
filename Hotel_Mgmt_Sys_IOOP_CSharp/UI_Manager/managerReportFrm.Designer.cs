namespace Hotel_Mgmt_Sys_IOOP_CSharp
{
    partial class managerReportFrm
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
            this.tabReport = new System.Windows.Forms.TabControl();
            this.tabOccupancy = new System.Windows.Forms.TabPage();
            this.dgvRoomOccupancy = new System.Windows.Forms.DataGridView();
            this.tabProfit = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.tabReviews = new System.Windows.Forms.TabPage();
            this.dgvReviews = new System.Windows.Forms.DataGridView();
            this.tabReportControls = new System.Windows.Forms.TabControl();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.pnlOccupancyControls = new System.Windows.Forms.Panel();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.chkOccupied = new System.Windows.Forms.CheckBox();
            this.chkReserved = new System.Windows.Forms.CheckBox();
            this.chkAll = new System.Windows.Forms.CheckBox();
            this.chkVacant = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label16 = new System.Windows.Forms.Label();
            this.btnGenerateReport_RoomOccupancy = new System.Windows.Forms.Button();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnGenerateReport_Profit = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.groupBox12 = new System.Windows.Forms.GroupBox();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnGenerateReport_Ratings = new System.Windows.Forms.Button();
            this.tabReport.SuspendLayout();
            this.tabOccupancy.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoomOccupancy)).BeginInit();
            this.tabProfit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tabReviews.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReviews)).BeginInit();
            this.tabReportControls.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.pnlOccupancyControls.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox12.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabReport
            // 
            this.tabReport.Controls.Add(this.tabOccupancy);
            this.tabReport.Controls.Add(this.tabProfit);
            this.tabReport.Controls.Add(this.tabReviews);
            this.tabReport.Location = new System.Drawing.Point(26, 289);
            this.tabReport.Name = "tabReport";
            this.tabReport.SelectedIndex = 0;
            this.tabReport.Size = new System.Drawing.Size(1561, 516);
            this.tabReport.TabIndex = 3;
            this.tabReport.Tag = "";
            this.tabReport.SelectedIndexChanged += new System.EventHandler(this.tabReport_SelectedIndexChanged);
            this.tabReport.Click += new System.EventHandler(this.tabRating_Click);
            // 
            // tabOccupancy
            // 
            this.tabOccupancy.Controls.Add(this.dgvRoomOccupancy);
            this.tabOccupancy.Location = new System.Drawing.Point(4, 25);
            this.tabOccupancy.Name = "tabOccupancy";
            this.tabOccupancy.Padding = new System.Windows.Forms.Padding(3);
            this.tabOccupancy.Size = new System.Drawing.Size(1553, 487);
            this.tabOccupancy.TabIndex = 0;
            this.tabOccupancy.Text = "Room Occupancy Report";
            this.tabOccupancy.UseVisualStyleBackColor = true;
            // 
            // dgvRoomOccupancy
            // 
            this.dgvRoomOccupancy.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRoomOccupancy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRoomOccupancy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRoomOccupancy.Location = new System.Drawing.Point(3, 3);
            this.dgvRoomOccupancy.Name = "dgvRoomOccupancy";
            this.dgvRoomOccupancy.RowHeadersWidth = 51;
            this.dgvRoomOccupancy.RowTemplate.Height = 24;
            this.dgvRoomOccupancy.Size = new System.Drawing.Size(1547, 481);
            this.dgvRoomOccupancy.TabIndex = 0;
            // 
            // tabProfit
            // 
            this.tabProfit.Controls.Add(this.dataGridView2);
            this.tabProfit.Location = new System.Drawing.Point(4, 25);
            this.tabProfit.Name = "tabProfit";
            this.tabProfit.Padding = new System.Windows.Forms.Padding(3);
            this.tabProfit.Size = new System.Drawing.Size(1553, 487);
            this.tabProfit.TabIndex = 1;
            this.tabProfit.Text = "Profit Report";
            this.tabProfit.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(3, 3);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(1547, 481);
            this.dataGridView2.TabIndex = 0;
            // 
            // tabReviews
            // 
            this.tabReviews.Controls.Add(this.dgvReviews);
            this.tabReviews.Location = new System.Drawing.Point(4, 25);
            this.tabReviews.Name = "tabReviews";
            this.tabReviews.Padding = new System.Windows.Forms.Padding(3);
            this.tabReviews.Size = new System.Drawing.Size(1553, 487);
            this.tabReviews.TabIndex = 2;
            this.tabReviews.Text = "Customer Reviews";
            this.tabReviews.UseVisualStyleBackColor = true;
            // 
            // dgvReviews
            // 
            this.dgvReviews.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvReviews.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReviews.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvReviews.Location = new System.Drawing.Point(3, 3);
            this.dgvReviews.Name = "dgvReviews";
            this.dgvReviews.RowHeadersWidth = 51;
            this.dgvReviews.RowTemplate.Height = 24;
            this.dgvReviews.Size = new System.Drawing.Size(1547, 481);
            this.dgvReviews.TabIndex = 0;
            // 
            // tabReportControls
            // 
            this.tabReportControls.Controls.Add(this.tabPage4);
            this.tabReportControls.Controls.Add(this.tabPage5);
            this.tabReportControls.Controls.Add(this.tabPage1);
            this.tabReportControls.Location = new System.Drawing.Point(26, 12);
            this.tabReportControls.Name = "tabReportControls";
            this.tabReportControls.SelectedIndex = 0;
            this.tabReportControls.Size = new System.Drawing.Size(1565, 271);
            this.tabReportControls.TabIndex = 4;
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(13)))), ((int)(((byte)(38)))));
            this.tabPage4.Controls.Add(this.pnlOccupancyControls);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1557, 242);
            this.tabPage4.TabIndex = 0;
            this.tabPage4.Text = "C1";
            // 
            // pnlOccupancyControls
            // 
            this.pnlOccupancyControls.BackColor = System.Drawing.Color.White;
            this.pnlOccupancyControls.Controls.Add(this.groupBox6);
            this.pnlOccupancyControls.Controls.Add(this.groupBox1);
            this.pnlOccupancyControls.Controls.Add(this.btnGenerateReport_RoomOccupancy);
            this.pnlOccupancyControls.Location = new System.Drawing.Point(17, 17);
            this.pnlOccupancyControls.Name = "pnlOccupancyControls";
            this.pnlOccupancyControls.Size = new System.Drawing.Size(1516, 208);
            this.pnlOccupancyControls.TabIndex = 5;
            // 
            // groupBox6
            // 
            this.groupBox6.BackColor = System.Drawing.Color.White;
            this.groupBox6.Controls.Add(this.chkOccupied);
            this.groupBox6.Controls.Add(this.chkReserved);
            this.groupBox6.Controls.Add(this.chkAll);
            this.groupBox6.Controls.Add(this.chkVacant);
            this.groupBox6.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.Location = new System.Drawing.Point(811, 20);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(360, 167);
            this.groupBox6.TabIndex = 6;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Filter";
            // 
            // chkOccupied
            // 
            this.chkOccupied.AutoSize = true;
            this.chkOccupied.Location = new System.Drawing.Point(188, 71);
            this.chkOccupied.Name = "chkOccupied";
            this.chkOccupied.Size = new System.Drawing.Size(119, 32);
            this.chkOccupied.TabIndex = 7;
            this.chkOccupied.Text = "Occupied";
            this.chkOccupied.UseVisualStyleBackColor = true;
            // 
            // chkReserved
            // 
            this.chkReserved.AutoSize = true;
            this.chkReserved.Location = new System.Drawing.Point(188, 109);
            this.chkReserved.Name = "chkReserved";
            this.chkReserved.Size = new System.Drawing.Size(117, 32);
            this.chkReserved.TabIndex = 6;
            this.chkReserved.Text = "Reserved";
            this.chkReserved.UseVisualStyleBackColor = true;
            // 
            // chkAll
            // 
            this.chkAll.AutoSize = true;
            this.chkAll.Location = new System.Drawing.Point(20, 33);
            this.chkAll.Name = "chkAll";
            this.chkAll.Size = new System.Drawing.Size(112, 32);
            this.chkAll.TabIndex = 5;
            this.chkAll.Text = "CheckAll";
            this.chkAll.UseVisualStyleBackColor = true;
            // 
            // chkVacant
            // 
            this.chkVacant.AutoSize = true;
            this.chkVacant.Location = new System.Drawing.Point(188, 33);
            this.chkVacant.Name = "chkVacant";
            this.chkVacant.Size = new System.Drawing.Size(94, 32);
            this.chkVacant.TabIndex = 4;
            this.chkVacant.Text = "Vacant";
            this.chkVacant.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox5);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(19, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(747, 153);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Occupancy Overview Info";
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.groupBox5.Controls.Add(this.label2);
            this.groupBox5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(508, 33);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(197, 100);
            this.groupBox5.TabIndex = 11;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Reserved";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Teal;
            this.label2.Location = new System.Drawing.Point(75, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "--";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(266, 33);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(197, 100);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Occupied";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(75, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "--";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(29, 33);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(197, 100);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Vacant";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Teal;
            this.label16.Location = new System.Drawing.Point(75, 41);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(26, 25);
            this.label16.TabIndex = 4;
            this.label16.Text = "--";
            // 
            // btnGenerateReport_RoomOccupancy
            // 
            this.btnGenerateReport_RoomOccupancy.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerateReport_RoomOccupancy.Location = new System.Drawing.Point(1318, 147);
            this.btnGenerateReport_RoomOccupancy.Name = "btnGenerateReport_RoomOccupancy";
            this.btnGenerateReport_RoomOccupancy.Size = new System.Drawing.Size(168, 40);
            this.btnGenerateReport_RoomOccupancy.TabIndex = 2;
            this.btnGenerateReport_RoomOccupancy.Text = "Generate Report";
            this.btnGenerateReport_RoomOccupancy.UseVisualStyleBackColor = true;
            this.btnGenerateReport_RoomOccupancy.Click += new System.EventHandler(this.btnGenerateReport_RoomOccupancy_Click);
            // 
            // tabPage5
            // 
            this.tabPage5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(13)))), ((int)(((byte)(38)))));
            this.tabPage5.Controls.Add(this.panel1);
            this.tabPage5.Location = new System.Drawing.Point(4, 25);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(1557, 242);
            this.tabPage5.TabIndex = 1;
            this.tabPage5.Text = "C2";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.groupBox4);
            this.panel1.Controls.Add(this.groupBox7);
            this.panel1.Controls.Add(this.btnGenerateReport_Profit);
            this.panel1.Location = new System.Drawing.Point(17, 17);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1516, 208);
            this.panel1.TabIndex = 6;
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.White;
            this.groupBox4.Controls.Add(this.comboBox1);
            this.groupBox4.Controls.Add(this.radioButton2);
            this.groupBox4.Controls.Add(this.radioButton1);
            this.groupBox4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(754, 20);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(529, 167);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Filter";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(248, 67);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(252, 36);
            this.comboBox1.TabIndex = 2;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(14, 92);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(152, 32);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "radioButton2";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(17, 54);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(149, 32);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "radioButton1";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.groupBox10);
            this.groupBox7.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox7.Location = new System.Drawing.Point(19, 20);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(689, 153);
            this.groupBox7.TabIndex = 0;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Profit Overview Info";
            // 
            // groupBox10
            // 
            this.groupBox10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.groupBox10.Controls.Add(this.label5);
            this.groupBox10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox10.Location = new System.Drawing.Point(29, 33);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(591, 100);
            this.groupBox10.TabIndex = 10;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Total Profits";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Teal;
            this.label5.Location = new System.Drawing.Point(103, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "--";
            // 
            // btnGenerateReport_Profit
            // 
            this.btnGenerateReport_Profit.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerateReport_Profit.Location = new System.Drawing.Point(1318, 147);
            this.btnGenerateReport_Profit.Name = "btnGenerateReport_Profit";
            this.btnGenerateReport_Profit.Size = new System.Drawing.Size(168, 40);
            this.btnGenerateReport_Profit.TabIndex = 2;
            this.btnGenerateReport_Profit.Text = "Generate Report";
            this.btnGenerateReport_Profit.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(13)))), ((int)(((byte)(38)))));
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(1557, 242);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "C3";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.groupBox11);
            this.panel2.Controls.Add(this.groupBox12);
            this.panel2.Controls.Add(this.btnGenerateReport_Ratings);
            this.panel2.Location = new System.Drawing.Point(17, 17);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1516, 208);
            this.panel2.TabIndex = 7;
            // 
            // groupBox11
            // 
            this.groupBox11.BackColor = System.Drawing.Color.White;
            this.groupBox11.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox11.Location = new System.Drawing.Point(811, 20);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(360, 167);
            this.groupBox11.TabIndex = 6;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "Filter";
            // 
            // groupBox12
            // 
            this.groupBox12.Controls.Add(this.groupBox9);
            this.groupBox12.Controls.Add(this.groupBox8);
            this.groupBox12.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox12.Location = new System.Drawing.Point(19, 20);
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.Size = new System.Drawing.Size(747, 153);
            this.groupBox12.TabIndex = 0;
            this.groupBox12.TabStop = false;
            this.groupBox12.Text = "Review Overview Info";
            // 
            // groupBox9
            // 
            this.groupBox9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.groupBox9.Controls.Add(this.label4);
            this.groupBox9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox9.Location = new System.Drawing.Point(315, 33);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(307, 100);
            this.groupBox9.TabIndex = 13;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Specific RoomType Ratings";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Teal;
            this.label4.Location = new System.Drawing.Point(103, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "--";
            // 
            // groupBox8
            // 
            this.groupBox8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.groupBox8.Controls.Add(this.label3);
            this.groupBox8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox8.Location = new System.Drawing.Point(29, 33);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(235, 100);
            this.groupBox8.TabIndex = 12;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Average Ratings";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Teal;
            this.label3.Location = new System.Drawing.Point(103, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "--";
            // 
            // btnGenerateReport_Ratings
            // 
            this.btnGenerateReport_Ratings.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerateReport_Ratings.Location = new System.Drawing.Point(1318, 147);
            this.btnGenerateReport_Ratings.Name = "btnGenerateReport_Ratings";
            this.btnGenerateReport_Ratings.Size = new System.Drawing.Size(168, 40);
            this.btnGenerateReport_Ratings.TabIndex = 2;
            this.btnGenerateReport_Ratings.Text = "Generate Report";
            this.btnGenerateReport_Ratings.UseVisualStyleBackColor = true;
            this.btnGenerateReport_Ratings.Click += new System.EventHandler(this.btnGenerateReport_Ratings_Click);
            // 
            // managerReportFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1616, 817);
            this.Controls.Add(this.tabReportControls);
            this.Controls.Add(this.tabReport);
            this.Name = "managerReportFrm";
            this.Text = "managerReportFrm";
            this.tabReport.ResumeLayout(false);
            this.tabOccupancy.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoomOccupancy)).EndInit();
            this.tabProfit.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.tabReviews.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReviews)).EndInit();
            this.tabReportControls.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.pnlOccupancyControls.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.groupBox12.ResumeLayout(false);
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabReport;
        private System.Windows.Forms.TabPage tabOccupancy;
        private System.Windows.Forms.DataGridView dgvRoomOccupancy;
        private System.Windows.Forms.TabPage tabProfit;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TabPage tabReviews;
        private System.Windows.Forms.DataGridView dgvReviews;
        private System.Windows.Forms.TabControl tabReportControls;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Panel pnlOccupancyControls;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnGenerateReport_RoomOccupancy;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.CheckBox chkOccupied;
        private System.Windows.Forms.CheckBox chkReserved;
        private System.Windows.Forms.CheckBox chkAll;
        private System.Windows.Forms.CheckBox chkVacant;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnGenerateReport_Profit;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.GroupBox groupBox12;
        private System.Windows.Forms.Button btnGenerateReport_Ratings;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
    }
}