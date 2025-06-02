using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Mgmt_Sys_IOOP_CSharp
{
    public partial class RoomView : Form
    {
        private string _customerID;

        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["dBConnect"].ToString());

        public RoomView()
        {
            InitializeComponent();
        }

        public RoomView(string customerID)
        {
            InitializeComponent();
            this._customerID = customerID; 
        }

        public string customerID { get => customerID; set => customerID = value; }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            DateTime checkInDate = dateTimeCheckin.Value;
            DateTime checkOutDate = dateTimeCheckout.Value;
            if (checkInDate <= checkOutDate)
            {
                TimeSpan ts = checkOutDate.Subtract(checkInDate);
                int days = Convert.ToInt32(ts.Days);
                lblDays.Text = "Number of night stay :" + days;

                using (SqlConnection conn2 = new SqlConnection(conn.ConnectionString))
                {
                    string sqlQuery = @"
            SELECT r.Room_Number, r.Room_Type, r.Price_Per_Night, r.Occupancy_Status 
            FROM [dbo].[Room] r
            WHERE NOT EXISTS (
                SELECT 1 
                FROM [dbo].[Reservation] rr 
                WHERE rr.Room_Number = r.Room_Number 
                AND rr.CheckInDate <= @CheckOutDate 
                AND rr.CheckOutDate >= @CheckInDate)";

                    SqlCommand mainCmd = new SqlCommand(sqlQuery, conn2);
                    mainCmd.Parameters.AddWithValue("@CheckInDate", checkInDate);
                    mainCmd.Parameters.AddWithValue("@CheckOutDate", checkOutDate);

                    conn2.Open();
                    DataTable dt = new DataTable();
                    using (SqlDataReader reader = mainCmd.ExecuteReader())
                    {
                        dt.Load(reader);
                    }

                    flowLayoutPanel1.Controls.Clear();
                    foreach (DataRow row in dt.Rows)
                    {
                        RoomList roomList = new RoomList(_customerID);
                        roomList.Title = row["Room_Type"].ToString();
                        roomList.Message = $"Status: {row["Occupancy_Status"]} \nRoom Number: {row["Room_Number"]}";
                        roomList.Price = Convert.ToDecimal(row["Price_Per_Night"]);
                        roomList.RoomID = row["Room_Number"].ToString();
                        roomList.CheckInDate = checkInDate;  // Set check-in date
                        roomList.CheckOutDate = checkOutDate;  // Set check-out date
                        roomList.Nights = days;

                        // Set image based on RoomType
                        Image roomImage = null;
                        string imageName = row["Room_Type"].ToString().ToLower().Replace(" ", "");

                        switch (imageName)
                        {
                            case "singleroom":
                                roomImage = Properties.Resources.singleroom;
                                break;
                            case "deluxeroom":
                                roomImage = Properties.Resources.deluxeroom;
                                break;
                            case "standardroom":
                                roomImage = Properties.Resources.standardroom;
                                break;
                            case "familyroom":
                                roomImage = Properties.Resources.familyroom;
                                break;
                            // Add more cases for other room types if necessary
                            default:
                                MessageBox.Show("Image not found for the specified room type.");
                                break;
                        }

                        if (roomImage != null)
                        {
                            roomList.Icon = roomImage;
                        }

                        flowLayoutPanel1.Controls.Add(roomList);
                    }

                    conn2.Close();
                }
            }
            else
            {
                MessageBox.Show("Check-in date must be lesser than check-out date. Please try again.");
            }
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            //Profile profileForm = new Profile();
            //profileForm.Show();
        }
    }
}
