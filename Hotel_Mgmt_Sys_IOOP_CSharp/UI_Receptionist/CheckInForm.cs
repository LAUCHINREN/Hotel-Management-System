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
using System.Xml.Linq;

namespace Hotel_Mgmt_Sys_IOOP_CSharp
{
    public partial class CheckInForm : Form
    {
        static SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["dbConnect"].ToString());
        public CheckInForm()
        {
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            int RoomID = int.Parse(txtRoomID.Text);
            string OccupancyStatus = "Check In";
            int ReservationID = int.Parse(txtReservationID.Text);
            Room obj1 = new Room(RoomID,OccupancyStatus, ReservationID);
            string checkInStatus = obj1.CustomerCheckIn();
            string Price = obj1.ShowPrice();
            string combinedMessage = $"{checkInStatus}\nInitialBill:{Price}";
            MessageBox.Show(combinedMessage, "Check-In and Price Information");
        }
        
    }
}