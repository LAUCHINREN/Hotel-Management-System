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
    public partial class CustomerHomePage : Form
    {
        private string _CustomerID; 
        public CustomerHomePage(string CustomerID)
        {
            InitializeComponent();
            _CustomerID = CustomerID; 
        }

        private void btnRoomReservation_Click(object sender, EventArgs e)
        {
            RoomView roomView = new RoomView(_CustomerID);
            roomView.ShowDialog(); 
        }

        private void btnManageReservation_Click(object sender, EventArgs e)
        {
            Reservation reservationFrm = new Reservation(_CustomerID);
            reservationFrm.Show();
        }

        private void btnUpdateProfile_Customer_Click(object sender, EventArgs e)
        {

        }


    }
}
