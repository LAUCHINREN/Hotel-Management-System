using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Hotel_Mgmt_Sys_IOOP_CSharp
{
    public partial class reservationroomdetails : Form
    {
        private string roomId;
        public reservationroomdetails(string roomId)
        {
            InitializeComponent();
            this.roomId = roomId;
            LoadReservationDetails();
        }

        private void LoadReservationDetails()
        {
            ClassReservation reservation = new ClassReservation();
            DataTable dt = reservation.GetReservationDetailsRoomByID(roomId);

            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                lblReservationID.Text = row["ReservationID"].ToString();
                lblRoomID.Text = row["Room_Number"].ToString();
                lblRoomType.Text = row["Room_Type"].ToString();
                lblGuest.Text = $"{row["guest"].ToString()} Guest";
                lblBed.Text = row["Beds"].ToString();
                lblBathroom.Text = $"{row["Bathroom"].ToString()} Bathroom";
                lblTypeofBathroom.Text = row["Bathroom_Type"].ToString();
                lblAmenities.Text = row["amenities"].ToString();
                lblRoomPrice.Text = $"RM {row["TotalPrice"].ToString()}";

                DisplayRoomImage(row["Room_Type"].ToString());
            }
            else
            {
                MessageBox.Show("No reservation details found.");
            }
        }

        private void DisplayRoomImage(string roomType)
        {
            switch (roomType.Replace(" ", "").ToLower())
            {
                case "singleroom":
                    pictureBoxRoom.Image = Properties.Resources.singleroom;
                    break;
                case "standardroom":
                    pictureBoxRoom.Image = Properties.Resources.standardroom;
                    break;
                case "deluxeroom":
                    pictureBoxRoom.Image = Properties.Resources.deluxeroom;
                    break;
                case "familyroom":
                    pictureBoxRoom.Image = Properties.Resources.familyroom;
                    break;
                // Add more cases as needed
                default:
                    MessageBox.Show("No images available for this room type.");
                    break;
            }
        }
    }
}
