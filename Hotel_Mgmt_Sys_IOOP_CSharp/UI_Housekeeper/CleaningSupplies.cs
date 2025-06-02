using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Mgmt_Sys_IOOP_CSharp
{
    public partial class CleaningSuppliesForm : Form
    {
        private CleaningSupplyManager manager = new CleaningSupplyManager();
        //private string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\Teoh Peng Kee\\OneDrive - Asia Pacific University\\SE Course\\Y1S2\\IOOP\\Hotel_Mgmt_Sys_IOOP_CSharp\\Hotel_Mgmt_Sys_IOOP_CSharp\\DB\\myDB.mdf\";Integrated Security=True";
        public CleaningSuppliesForm()
        {
            InitializeComponent();
            // TODO: This line of code loads data into the 'cleaningSuppliesDataSet.SuppliesTable' table. You can move, or remove it, as needed.
            this.suppliesTableTableAdapter1.Fill(this.cleaningSuppliesDataSet.SuppliesTable);
            LoadDataGrid();
            RefreshDataGrid();
            manager = new CleaningSupplyManager(); // Ensure manager is initialized
            btnSearchSupply.Click += btnSearchSupply_Click;
            btnFilterSupplier.Click += btnFilterSupplier_Click;
            LoadSuppliersIntoComboBox();
            this.dataGridViewSupplies.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSupplies_CellClick);
        }
        public void LoadDataGrid()
        {
            // Fetch all supplies
            List<CleaningSupply> allSupplies = manager.GetAllSupplies();

            // Sort supplies by SuppliesID or another appropriate field
            allSupplies = allSupplies.OrderBy(s => s.SuppliesID).ToList();

            // Bind the sorted list to the DataGridView
            dataGridViewSupplies.DataSource = null; // Clear existing data binding
            dataGridViewSupplies.DataSource = allSupplies; // Set new data source

        }
        public void RefreshDataGrid()
        {
            LoadDataGrid();
        }
        private void btnSearchSupply_Click(object sender, EventArgs e)
        {
            string searchTerm = txtSearchSupply.Text;
            dataGridViewSupplies.DataSource = manager.SearchSupplies(searchTerm);
        }
        private void LoadSuppliersIntoComboBox()
        {
            try
            {               
                string query = "SELECT DISTINCT Supplier FROM SuppliesTable";

                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["dbConnect"].ToString()))
                {
                    connection.Open();
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            cboSupplierInfo.Items.Clear();
                            while (reader.Read())
                            {
                                cboSupplierInfo.Items.Add(reader["Supplier"].ToString());
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }
        private void btnFilterSupplier_Click(object sender, EventArgs e)
        {
            string supplier = cboSupplierInfo.SelectedItem.ToString();
            dataGridViewSupplies.DataSource = manager.FilterSuppliesBySupplier(supplier);
        }
        private void dataGridViewSupplies_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            Console.WriteLine($"Cell clicked at Row: {e.RowIndex}, Column: {e.ColumnIndex}");

            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow row = dataGridViewSupplies.Rows[e.RowIndex];
                CleaningSupply selectedSupply = (CleaningSupply)row.DataBoundItem;

                Console.WriteLine($"Selected supply ID: {selectedSupply.SuppliesID}");

                if (dataGridViewSupplies.Columns[e.ColumnIndex].Name == "Edit")
                {
                    Console.WriteLine("Edit button clicked");
                    EditSupplyForm editForm = new EditSupplyForm(selectedSupply, manager);
                    editForm.ShowDialog();
                    LoadDataGrid(); // Refresh the grid after editing
                }
                else if (dataGridViewSupplies.Columns[e.ColumnIndex].Name == "Delete")
                {
                    Console.WriteLine("Delete button clicked");
                    DialogResult result = MessageBox.Show("Are you sure you want to delete this supply?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        manager.DeleteSupply(selectedSupply.SuppliesID);
                        LoadDataGrid(); // Refresh the DataGridView
                    }
                }
            }
        }
        private void CleaningSuppliesForm_Load(object sender, EventArgs e)
        {


        }
    }
}
