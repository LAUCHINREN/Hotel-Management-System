namespace Hotel_Mgmt_Sys_IOOP_CSharp
{
    partial class CleaningSuppliesForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnFilterSupplier = new System.Windows.Forms.Button();
            this.dataGridViewSupplies = new System.Windows.Forms.DataGridView();
            this.cboSupplierInfo = new System.Windows.Forms.ComboBox();
            this.lblFilterSupplier = new System.Windows.Forms.Label();
            this.btnSearchSupply = new System.Windows.Forms.Button();
            this.txtSearchSupply = new System.Windows.Forms.TextBox();
            this.labelCleaningSuppliesTitle = new System.Windows.Forms.Label();
            this.cleaningSuppliesDataSet = new Hotel_Mgmt_Sys_IOOP_CSharp.CleaningSuppliesDataSet();
            this.suppliesTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.suppliesTableTableAdapter1 = new Hotel_Mgmt_Sys_IOOP_CSharp.CleaningSuppliesDataSetTableAdapters.SuppliesTableTableAdapter();
            this.suppliesIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brandDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costPerUnitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplierDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSupplies)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cleaningSuppliesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.suppliesTableBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFilterSupplier
            // 
            this.btnFilterSupplier.BackColor = System.Drawing.Color.Teal;
            this.btnFilterSupplier.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnFilterSupplier.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnFilterSupplier.Location = new System.Drawing.Point(1056, 94);
            this.btnFilterSupplier.Name = "btnFilterSupplier";
            this.btnFilterSupplier.Size = new System.Drawing.Size(75, 30);
            this.btnFilterSupplier.TabIndex = 55;
            this.btnFilterSupplier.Text = "Filter";
            this.btnFilterSupplier.UseVisualStyleBackColor = false;
            // 
            // dataGridViewSupplies
            // 
            this.dataGridViewSupplies.AutoGenerateColumns = false;
            this.dataGridViewSupplies.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewSupplies.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.dataGridViewSupplies.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SkyBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewSupplies.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewSupplies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSupplies.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.suppliesIDDataGridViewTextBoxColumn,
            this.itemNameDataGridViewTextBoxColumn,
            this.brandDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.costPerUnitDataGridViewTextBoxColumn,
            this.supplierDataGridViewTextBoxColumn,
            this.Edit,
            this.Delete});
            this.dataGridViewSupplies.DataSource = this.suppliesTableBindingSource;
            this.dataGridViewSupplies.EnableHeadersVisualStyles = false;
            this.dataGridViewSupplies.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridViewSupplies.Location = new System.Drawing.Point(59, 153);
            this.dataGridViewSupplies.Name = "dataGridViewSupplies";
            this.dataGridViewSupplies.RowHeadersWidth = 51;
            this.dataGridViewSupplies.RowTemplate.Height = 24;
            this.dataGridViewSupplies.Size = new System.Drawing.Size(1076, 333);
            this.dataGridViewSupplies.TabIndex = 54;
            // 
            // cboSupplierInfo
            // 
            this.cboSupplierInfo.FormattingEnabled = true;
            this.cboSupplierInfo.Location = new System.Drawing.Point(850, 97);
            this.cboSupplierInfo.Name = "cboSupplierInfo";
            this.cboSupplierInfo.Size = new System.Drawing.Size(168, 24);
            this.cboSupplierInfo.TabIndex = 53;
            // 
            // lblFilterSupplier
            // 
            this.lblFilterSupplier.AutoSize = true;
            this.lblFilterSupplier.Location = new System.Drawing.Point(729, 100);
            this.lblFilterSupplier.Name = "lblFilterSupplier";
            this.lblFilterSupplier.Size = new System.Drawing.Size(92, 16);
            this.lblFilterSupplier.TabIndex = 52;
            this.lblFilterSupplier.Text = "Filter Supplier:";
            // 
            // btnSearchSupply
            // 
            this.btnSearchSupply.BackColor = System.Drawing.Color.Teal;
            this.btnSearchSupply.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSearchSupply.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSearchSupply.Location = new System.Drawing.Point(247, 97);
            this.btnSearchSupply.Name = "btnSearchSupply";
            this.btnSearchSupply.Size = new System.Drawing.Size(81, 30);
            this.btnSearchSupply.TabIndex = 51;
            this.btnSearchSupply.Text = "Search";
            this.btnSearchSupply.UseVisualStyleBackColor = false;
            // 
            // txtSearchSupply
            // 
            this.txtSearchSupply.Location = new System.Drawing.Point(59, 100);
            this.txtSearchSupply.Name = "txtSearchSupply";
            this.txtSearchSupply.Size = new System.Drawing.Size(166, 22);
            this.txtSearchSupply.TabIndex = 50;
            this.txtSearchSupply.Text = "Search...";
            // 
            // labelCleaningSuppliesTitle
            // 
            this.labelCleaningSuppliesTitle.AutoSize = true;
            this.labelCleaningSuppliesTitle.Font = new System.Drawing.Font("Trebuchet MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCleaningSuppliesTitle.Location = new System.Drawing.Point(529, 36);
            this.labelCleaningSuppliesTitle.Name = "labelCleaningSuppliesTitle";
            this.labelCleaningSuppliesTitle.Size = new System.Drawing.Size(201, 28);
            this.labelCleaningSuppliesTitle.TabIndex = 49;
            this.labelCleaningSuppliesTitle.Text = "Cleaning Supplies";
            // 
            // cleaningSuppliesDataSet
            // 
            this.cleaningSuppliesDataSet.DataSetName = "CleaningSuppliesDataSet";
            this.cleaningSuppliesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // suppliesTableBindingSource
            // 
            this.suppliesTableBindingSource.DataMember = "SuppliesTable";
            this.suppliesTableBindingSource.DataSource = this.cleaningSuppliesDataSet;
            // 
            // suppliesTableTableAdapter1
            // 
            this.suppliesTableTableAdapter1.ClearBeforeFill = true;
            // 
            // suppliesIDDataGridViewTextBoxColumn
            // 
            this.suppliesIDDataGridViewTextBoxColumn.DataPropertyName = "SuppliesID";
            this.suppliesIDDataGridViewTextBoxColumn.HeaderText = "SuppliesID";
            this.suppliesIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.suppliesIDDataGridViewTextBoxColumn.Name = "suppliesIDDataGridViewTextBoxColumn";
            // 
            // itemNameDataGridViewTextBoxColumn
            // 
            this.itemNameDataGridViewTextBoxColumn.DataPropertyName = "ItemName";
            this.itemNameDataGridViewTextBoxColumn.HeaderText = "ItemName";
            this.itemNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.itemNameDataGridViewTextBoxColumn.Name = "itemNameDataGridViewTextBoxColumn";
            // 
            // brandDataGridViewTextBoxColumn
            // 
            this.brandDataGridViewTextBoxColumn.DataPropertyName = "Brand";
            this.brandDataGridViewTextBoxColumn.HeaderText = "Brand";
            this.brandDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.brandDataGridViewTextBoxColumn.Name = "brandDataGridViewTextBoxColumn";
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            this.quantityDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            // 
            // costPerUnitDataGridViewTextBoxColumn
            // 
            this.costPerUnitDataGridViewTextBoxColumn.DataPropertyName = "CostPerUnit";
            this.costPerUnitDataGridViewTextBoxColumn.HeaderText = "CostPerUnit";
            this.costPerUnitDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.costPerUnitDataGridViewTextBoxColumn.Name = "costPerUnitDataGridViewTextBoxColumn";
            // 
            // supplierDataGridViewTextBoxColumn
            // 
            this.supplierDataGridViewTextBoxColumn.DataPropertyName = "Supplier";
            this.supplierDataGridViewTextBoxColumn.HeaderText = "Supplier";
            this.supplierDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.supplierDataGridViewTextBoxColumn.Name = "supplierDataGridViewTextBoxColumn";
            // 
            // Edit
            // 
            this.Edit.HeaderText = "Edit";
            this.Edit.MinimumWidth = 6;
            this.Edit.Name = "Edit";
            this.Edit.Text = "Edit";
            this.Edit.UseColumnTextForButtonValue = true;
            // 
            // Delete
            // 
            this.Delete.HeaderText = "Delete";
            this.Delete.MinimumWidth = 6;
            this.Delete.Name = "Delete";
            this.Delete.Text = "Delete";
            this.Delete.UseColumnTextForButtonValue = true;
            // 
            // CleaningSuppliesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1175, 573);
            this.Controls.Add(this.btnFilterSupplier);
            this.Controls.Add(this.dataGridViewSupplies);
            this.Controls.Add(this.cboSupplierInfo);
            this.Controls.Add(this.lblFilterSupplier);
            this.Controls.Add(this.btnSearchSupply);
            this.Controls.Add(this.txtSearchSupply);
            this.Controls.Add(this.labelCleaningSuppliesTitle);
            this.Name = "CleaningSuppliesForm";
            this.Text = "Cleaning Supplies Form";
            this.Load += new System.EventHandler(this.CleaningSuppliesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSupplies)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cleaningSuppliesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.suppliesTableBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFilterSupplier;
        private System.Windows.Forms.DataGridView dataGridViewSupplies;
        private System.Windows.Forms.ComboBox cboSupplierInfo;
        private System.Windows.Forms.Label lblFilterSupplier;
        private System.Windows.Forms.Button btnSearchSupply;
        private System.Windows.Forms.TextBox txtSearchSupply;
        private System.Windows.Forms.Label labelCleaningSuppliesTitle;
        //private DBofCleaningSuppliesDataSet dBofCleaningSuppliesDataSet;
        //private DBofCleaningSuppliesDataSetTableAdapters.SuppliesTableTableAdapter suppliesTableTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn SuppliesID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Brand;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn CostPerUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Supplier;
        private CleaningSuppliesDataSet cleaningSuppliesDataSet;
        private System.Windows.Forms.BindingSource suppliesTableBindingSource;
        private CleaningSuppliesDataSetTableAdapters.SuppliesTableTableAdapter suppliesTableTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn suppliesIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn brandDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costPerUnitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplierDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Edit;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
    }
}

