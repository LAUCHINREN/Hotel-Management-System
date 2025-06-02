using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Mgmt_Sys_IOOP_CSharp
{
    public class CleaningSupplyManager
    {
        private string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\Teoh Peng Kee\\OneDrive - Asia Pacific University\\SE Course\\Y1S2\\IOOP\\Hotel_Mgmt_Sys_IOOP_CSharp\\Hotel_Mgmt_Sys_IOOP_CSharp\\DB\\myDB.mdf\";Integrated Security=True";
        public List<CleaningSupply> GetAllSupplies()
        {
            List<CleaningSupply> supplies = new List<CleaningSupply>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                // Ensure data is ordered by SuppliesID or another key field
                string query = "SELECT SuppliesID, ItemName, Brand, Quantity, CostPerUnit, Supplier FROM SuppliesTable ORDER BY SuppliesID ASC";
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    supplies.Add(new CleaningSupply
                    {
                        SuppliesID = reader["SuppliesID"].ToString(),
                        ItemName = reader["ItemName"].ToString(),
                        Brand = reader["Brand"].ToString(),
                        Quantity = Convert.ToInt32(reader["Quantity"]),
                        CostPerUnit = Convert.ToDecimal(reader["CostPerUnit"]),
                        Supplier = reader["Supplier"].ToString()
                    });
                }
            }
            return supplies;
        }

        public void AddSupply(CleaningSupply supply)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO SuppliesTable (SuppliesID, ItemName, Brand, Quantity, CostPerUnit, Supplier) VALUES (@SuppliesID, @ItemName, @Brand, @Quantity, @CostPerUnit, @Supplier)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@SuppliesID", supply.SuppliesID);
                cmd.Parameters.AddWithValue("@ItemName", supply.ItemName);
                cmd.Parameters.AddWithValue("@Brand", supply.Brand);
                cmd.Parameters.AddWithValue("@Quantity", supply.Quantity);
                cmd.Parameters.AddWithValue("@CostPerUnit", supply.CostPerUnit);
                cmd.Parameters.AddWithValue("@Supplier", supply.Supplier);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void UpdateSupply(string supplyId, string itemName, string brand, int quantity, decimal costPerUnit, string supplier)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "UPDATE SuppliesTable SET ItemName = @ItemName, Brand = @Brand, Quantity = @Quantity, CostPerUnit = @CostPerUnit, Supplier = @Supplier WHERE SuppliesID = @SuppliesID";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@SuppliesID", supplyId);
                cmd.Parameters.AddWithValue("@ItemName", itemName);
                cmd.Parameters.AddWithValue("@Brand", brand);
                cmd.Parameters.AddWithValue("@Quantity", quantity);
                cmd.Parameters.AddWithValue("@CostPerUnit", costPerUnit);
                cmd.Parameters.AddWithValue("@Supplier", supplier);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void DeleteSupply(string suppliesID)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM SuppliesTable WHERE SuppliesID = @SuppliesID";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@SuppliesID", suppliesID);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public List<CleaningSupply> SearchSupplies(string searchTerm)
        {
            List<CleaningSupply> supplies = new List<CleaningSupply>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT SuppliesID, ItemName, Brand, Quantity, CostPerUnit, Supplier FROM SuppliesTable WHERE ItemName LIKE '%' + @SearchTerm + '%'";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@SearchTerm", searchTerm);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    supplies.Add(new CleaningSupply
                    {
                        SuppliesID = reader["SuppliesID"].ToString(),
                        ItemName = reader["ItemName"].ToString(),
                        Brand = reader["Brand"].ToString(),
                        Quantity = Convert.ToInt32(reader["Quantity"]),
                        CostPerUnit = Convert.ToDecimal(reader["CostPerUnit"]),
                        Supplier = reader["Supplier"].ToString()
                    });
                }
            }
            return supplies;
        }

        public List<CleaningSupply> FilterSuppliesBySupplier(string supplier)
        {
            List<CleaningSupply> supplies = new List<CleaningSupply>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT SuppliesID, ItemName, Brand, Quantity, CostPerUnit, Supplier FROM SuppliesTable WHERE Supplier = @Supplier";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Supplier", supplier);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    supplies.Add(new CleaningSupply
                    {
                        SuppliesID = reader["SuppliesID"].ToString(),
                        ItemName = reader["ItemName"].ToString(),
                        Brand = reader["Brand"].ToString(),
                        Quantity = Convert.ToInt32(reader["Quantity"]),
                        CostPerUnit = Convert.ToDecimal(reader["CostPerUnit"]),
                        Supplier = reader["Supplier"].ToString()
                    });
                }
            }
            return supplies;
        }
    }
}
