using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Hotel_Mgmt_Sys_IOOP_CSharp
{
    public partial class Review : Form
    {
        private string reservationId;
        public Review(string reservationId)
        {
            InitializeComponent();
            this.reservationId = reservationId;
        }

        private int GetSelectedRating()
        {
            // Assume rating is between 1 and 5
            if (radbtnRating1.Checked) return 1;
            if (radbtnRating2.Checked) return 2;
            if (radbtnRating3.Checked) return 3;
            if (radbtnRating4.Checked) return 4;
            if (radbtnRating5.Checked) return 5;
            return 0;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int rating = GetSelectedRating();
            string comment = txtComment.Text;

            if (rating == 0)
            {
                MessageBox.Show("Please select a rating.");
                return;
            }

            ClassReservation reservation = new ClassReservation();
            string errorMessage;
            bool success = reservation.AddRating(reservationId, rating, comment, out errorMessage);

            if (success)
            {
                MessageBox.Show("Rating added successfully.");
                this.Close();
            }
            else
            {
                MessageBox.Show($"Error adding rating: {errorMessage}");
            }
        }
    }
}
