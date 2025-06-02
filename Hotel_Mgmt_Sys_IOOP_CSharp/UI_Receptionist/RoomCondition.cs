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
    public partial class RoomCondition : Form
    {
        static SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["dbConnect"].ToString());

        public RoomCondition()
        {
            InitializeComponent();
        }

        private void RoomCondition_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'roomConnditionDataSet.Room' table. You can move, or remove it, as needed.
            this.roomTableAdapter.Fill(this.roomConnditionDataSet.Room);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
                    
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Grid();
        }

        public void Grid()
        {
            con.Open();
            string query = "select * from Room";
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder();
            var ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            con.Close();
        }

        private void btnCheckIn_Click(object sender, EventArgs e)
        {
            CheckInForm f3 = new CheckInForm();
            f3.Show();
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            CheckOutForm f4 = new CheckOutForm();
            f4.Show();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (field.Text == "Room_Number")
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT Room_Number, Venue, Room_Type, guest, beds, bathroom, Bathroom_Type, amenities, Price_Per_Night, Occupancy_Status FROM Room where Room_Number = '" + txtValue.Text + "'", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            else if (field.Text == "Venue")
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT Room_Number, Venue, Room_Type, guest, beds, bathroom, Bathroom_Type, amenities, Price_Per_Night, Occupancy_Status FROM Room where Venue = '" + txtValue.Text + "'", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            else if (field.Text == "Room_Type")
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT Room_Number, Venue, Room_Type, guest, beds, bathroom, Bathroom_Type, amenities, Price_Per_Night, Occupancy_Status FROM Room where Room_Type = '" + txtValue.Text + "'", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            else if (field.Text == "guest")
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT Room_Number, Venue, Room_Type, guest, beds, bathroom, Bathroom_Type, amenities, Price_Per_Night, Occupancy_Status FROM Room where guest = '" + txtValue.Text + "'", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            else if (field.Text == "beds")
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT Room_Number, Venue, Room_Type, guest, beds, bathroom, Bathroom_Type, amenities, Price_Per_Night, Occupancy_Status FROM Room where beds = '" + txtValue.Text + "'", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            else if (field.Text == "bathroom")
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT Room_Number, Venue, Room_Type, guest, beds, bathroom, Bathroom_Type, amenities, Price_Per_Night, Occupancy_Status FROM Room where bathroom = '" + txtValue.Text + "'", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            else if (field.Text == "Bathroom_Type")
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT Room_Number, Venue, Room_Type, guest, beds, bathroom, Bathroom_Type, amenities, Price_Per_Night, Occupancy_Status FROM Room where Bathroom_Type = '" + txtValue.Text + "'", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            else if (field.Text == "amenities")
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT Room_Number, Venue, Room_Type, guest, beds, bathroom, Bathroom_Type, amenities, Price_Per_Night, Occupancy_Status FROM Room where amenities = '" + txtValue.Text + "'", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            else if (field.Text == "Price_Per_Night")
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT Room_Number, Venue, Room_Type, guest, beds, bathroom, Bathroom_Type, amenities, Price_Per_Night, Occupancy_Status FROM Room where Price_Per_Night = '" + txtValue.Text + "'", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            else
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT Room_Number, Venue, Room_Type, guest, beds, bathroom, Bathroom_Type, amenities, Price_Per_Night, Occupancy_Status FROM Room where Occupancy_Status = '" + txtValue.Text + "'", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }
    }
}
