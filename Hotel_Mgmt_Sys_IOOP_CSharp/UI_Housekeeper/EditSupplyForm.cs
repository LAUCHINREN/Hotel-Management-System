using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Mgmt_Sys_IOOP_CSharp
{
    public partial class EditSupplyForm : Form
    {
        private CleaningSupplyManager manager;
        private CleaningSupply currentSupply;
        public EditSupplyForm(CleaningSupply supply, CleaningSupplyManager manager)
        {
            InitializeComponent();
            GenerateNewSuppliesID();
            this.manager = manager ?? new CleaningSupplyManager(); // Ensure manager is not null
            this.currentSupply = supply;
            this.btnUpdateSupplies.Click += new System.EventHandler(this.btnUpdateSupplies_Click);
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            this.linkClearAll.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkClearAll_LinkClicked);
            // Load supply details into form fields
            LoadSupplyDetails();
        }
        private void LoadSupplyDetails()
        {
            if (currentSupply != null)
            {
                txtSuppliesID.Text = currentSupply.SuppliesID;
                txtItemName.Text = currentSupply.ItemName;
                txtBrand.Text = currentSupply.Brand;
                txtQty.Text = currentSupply.Quantity.ToString();
                txtCostPerUnit.Text = currentSupply.CostPerUnit.ToString("F2");
                txtSupplier.Text = currentSupply.Supplier;
            }
        }
        private void btnUpdateSupplies_Click(object sender, EventArgs e)
        {
            // Update the current supply with new values from the form fields
            string suppliesID = txtSuppliesID.Text;
            string itemName = txtItemName.Text;
            string brand = txtBrand.Text;
            int quantity = int.Parse(txtQty.Text);
            decimal costPerUnit = decimal.Parse(txtCostPerUnit.Text);
            string supplier = txtSupplier.Text;

            // Call the manager to update the supply in the database
            manager.UpdateSupply(suppliesID, itemName, brand, quantity, costPerUnit, supplier);
            MessageBox.Show("Supplies updated successfully!");

            // Close the form
            this.Close();

        }
        private void btnAddNew_Click(object sender, EventArgs e)
        {
            try
            {
                // Gather data and add new supply
                string suppliesID = txtSuppliesID.Text;
                string itemName = txtItemName.Text;
                string brand = txtBrand.Text;
                int quantity = int.Parse(txtQty.Text);
                decimal costPerUnit = decimal.Parse(txtCostPerUnit.Text);
                string supplier = txtSupplier.Text;

                CleaningSupply newSupply = new CleaningSupply
                {
                    SuppliesID = suppliesID,
                    ItemName = itemName,
                    Brand = brand,
                    Quantity = quantity,
                    CostPerUnit = costPerUnit,
                    Supplier = supplier
                };

                manager.AddSupply(newSupply);
                MessageBox.Show("New supply added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Refresh the data grid in the parent form
                if (this.Owner is CleaningSuppliesForm parentForm)
                {
                    parentForm.LoadDataGrid();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding new supply: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private string GenerateNewSuppliesID()
        {
            // Ensure manager is initialized
            if (manager == null)
            {
                manager = new CleaningSupplyManager();
            }

            // Fetch all existing supplies to find the highest existing ID
            var allSupplies = manager.GetAllSupplies();
            int maxId = 0;

            foreach (var supply in allSupplies)
            {
                if (supply.SuppliesID.StartsWith("CS") && int.TryParse(supply.SuppliesID.Substring(2), out int id))
                {
                    if (id > maxId)
                        maxId = id;
                }
            }

            // Ensure to always return a value
            return $"CS{(maxId + 1):D3}";
        }
        private void ClearFormFields()
        {
            txtSuppliesID.Clear();
            txtItemName.Clear();
            txtBrand.Clear();
            txtQty.Clear();
            txtCostPerUnit.Clear();
            txtSupplier.Clear();
        }

        private void linkClearAll_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ClearFormFields();
            // Check if manager is initialized before calling GetAllSupplies
            if (manager != null)
            {
                // Generate and assign a unique SuppliesID
                string newSuppliesID = GenerateNewSuppliesID();
                txtSuppliesID.Text = newSuppliesID;
            }
            else
            {
                MessageBox.Show("Error: CleaningSupplyManager is not initialized.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
