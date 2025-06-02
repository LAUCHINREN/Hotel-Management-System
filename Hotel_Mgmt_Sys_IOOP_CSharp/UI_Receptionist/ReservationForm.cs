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
    public partial class ReservationForm : Form
    {
        static SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["dbConnect"].ToString());
        public ReservationForm()
        {
            InitializeComponent();
        }

        private void ReservationForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'reservationReceptionistDataSet.Reservation' table. You can move, or remove it, as needed.
            this.reservationTableAdapter.Fill(this.reservationReceptionistDataSet.Reservation);
            Grid(); 
            // TODO: This line of code loads data into the 'dBDataSet1.Reservation' table. You can move, or remove it, as needed.
            //this.reservationTableAdapter.Fill(this.dBDataSet1.Reservation);

        }

        private void txtValue_TextChanged(object sender, EventArgs e)
        {
            if (field.Text == "CustomerID")
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT ReservationID, CustomerID, RoomID, CheckInDate, CheckOutDate, AdditionalRequests, Price, Finalbill, Rating, Comment FROM Reservation where CustomerID = '" + txtValue.Text + "'", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            else
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT ReservationID, CustomerID, RoomID, CheckInDate, CheckOutDate, AdditionalRequests, Price, Finalbill, Rating, Comment FROM Reservation where RoomID = '" + txtValue.Text + "'", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        public void Grid()
        {
            con.Open();
            string query = "select * from Reservation";
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder();
            var ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Grid();
        }
    }
}
