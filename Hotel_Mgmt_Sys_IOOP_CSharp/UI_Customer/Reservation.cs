using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Mgmt_Sys_IOOP_CSharp
{
    public partial class Reservation : Form
    {
        private string _CustomerID;
        public Reservation( string CustomerID)
        {
            _CustomerID = CustomerID;
            InitializeComponent();
            LoadReservations(_CustomerID);
        }

        private void LoadReservations(string CustomerID)
        {
            ClassReservation reservation = new ClassReservation();
            string customerId = CustomerID; //ClassReservation.//LoggedInCustomerID; // Get the logged-in CustomerID
            DataTable dt = reservation.GetReservationsByCustomerId(customerId);

            if (!dt.Columns.Contains("NightsStayed"))
            {
                dt.Columns.Add("NightsStayed", typeof(int));
            }

            // Calculate the number of nights stayed for each row
            foreach (DataRow row in dt.Rows)
            {
                DateTime checkInDate = Convert.ToDateTime(row["CheckInDate"]);
                DateTime checkOutDate = Convert.ToDateTime(row["CheckOutDate"]);
                int nightsStayed = (checkOutDate - checkInDate).Days;
                row["NightsStayed"] = nightsStayed;
            }

            // Set the DataSource of DataGridView
            dataGridReservations.DataSource = dt;

            // Optionally, set up columns if needed
            if (dataGridReservations.Columns.Count < 1)
            {
                dataGridReservations.Columns.Clear(); 
                dataGridReservations.Columns.Add("ReservationID", "Reservation ID");
                dataGridReservations.Columns.Add("Room_Number", "Room_Number");
                dataGridReservations.Columns.Add("CheckInDate", "Check-In Date");
                dataGridReservations.Columns.Add("CheckOutDate", "Check-Out Date");
                dataGridReservations.Columns.Add("TotalPrice", "Price");
                dataGridReservations.Columns.Add("AdditionalRequests", "Additional Requests");
                dataGridReservations.Columns.Add("Rating", "Rating");
                dataGridReservations.Columns.Add("Comment", "Comment");

                //dataGridReservations.Columns["Room_Number"].HeaderText = "Room_Number";
                //dataGridReservations.Columns["CheckInDate"].HeaderText = "Check-In Date";
                //dataGridReservations.Columns["CheckOutDate"].HeaderText = "Check-Out Date";
                //dataGridReservations.Columns["TotalPrice"].HeaderText = "Price";
                //dataGridReservations.Columns["AdditionalRequests"].HeaderText = "Additional Requests";
                //dataGridReservations.Columns["Rating"].HeaderText = "Rating";
                //dataGridReservations.Columns["Comment"].HeaderText = "Comment";
            }
            

            if (!dataGridReservations.Columns.Contains("Details"))
            {
                DataGridViewButtonColumn detailsButtonColumn = new DataGridViewButtonColumn
                {
                    Name = "Details",
                    HeaderText = "View Details",
                    Text = "View",
                    UseColumnTextForButtonValue = true
                };
                dataGridReservations.Columns.Add(detailsButtonColumn);
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (dataGridReservations.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridReservations.SelectedRows[0];
                string reservationId = selectedRow.Cells["ReservationID"].Value.ToString(); // Changed to string

                DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this record?", "Confirm Delete", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    string errorMessage;
                    bool success = ClassReservation.DeleteReservation(reservationId, out errorMessage);

                    if (success)
                    {
                        MessageBox.Show("Reservation deleted successfully.");
                        LoadReservations(_CustomerID); // Reload reservations after deletion
                    }
                    else
                    {
                        MessageBox.Show($"Error deleting reservation: {errorMessage}");
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a reservation to delete.");
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string reservationId = txtReservationID.Text;
            DateTime? checkInDate = null;
            DateTime? checkOutDate = null;

            // Validate Reservation ID
            if (string.IsNullOrWhiteSpace(reservationId))
            {
                MessageBox.Show("Please enter a valid Reservation ID.");
                return;
            }

            // Parse Check-In Date
            try
            {
                if (!string.IsNullOrWhiteSpace(txtCheckin.Text))
                {
                    checkInDate = DateTime.Parse(txtCheckin.Text);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter a valid Check-In Date.");
                return;
            }

            // Parse Check-Out Date
            try
            {
                if (!string.IsNullOrWhiteSpace(txtCheckout.Text))
                {
                    checkOutDate = DateTime.Parse(txtCheckout.Text);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter a valid Check-Out Date.");
                return;
            }

            string additionalRequests = txtAdditionalRequest.Text;

            // Check if both dates are provided
            if (checkInDate.HasValue != checkOutDate.HasValue)
            {
                MessageBox.Show("Please enter both Check-In and Check-Out dates to confirm your reservation.");
                return;
            }

            ClassReservation reservation = new ClassReservation();
            string errorMessage;
            bool success = reservation.UpdateReservation(reservationId, checkInDate, checkOutDate, additionalRequests, out errorMessage);

            if (success)
            {
                MessageBox.Show("Reservation updated successfully.");
                LoadReservations(_CustomerID); // Reload reservations after update
            }
            else
            {
                MessageBox.Show($"Error updating reservation: {errorMessage}");
            }
        }

        private void btnAddRating_Click(object sender, EventArgs e)
        {
            string reservationId = GetSelectedReservationId();

            if (!string.IsNullOrEmpty(reservationId))
            {
                // Pass the selected ReservationID directly to the Review form
                Review reviewForm = new Review(reservationId);
                reviewForm.ShowDialog(); // Use ShowDialog to ensure the user completes the form before continuing
                LoadReservations(_CustomerID);
            }
        }

        private string GetSelectedReservationId()
        {
            if (dataGridReservations.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridReservations.SelectedRows[0];
                return selectedRow.Cells["ReservationID"].Value.ToString(); // Return as string
            }
            else
            {
                MessageBox.Show("Please select a reservation.");
                return string.Empty; // Indicate that no valid selection was made
            }
        }

        private void btnAddReservation_Click(object sender, EventArgs e)
        {
            RoomView l1 = new RoomView();
            l1.ShowDialog();
        }

        private void dataGridReservations_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == dataGridReservations.Columns["Details"].Index)
            {
                // Ensure that the clicked row index is valid
                if (e.RowIndex >= 0 && e.RowIndex < dataGridReservations.Rows.Count)
                {
                    DataGridViewRow row = dataGridReservations.Rows[e.RowIndex];

                    // Access the RoomID from the clicked row
                    string roomId = row.Cells["Room_Number"].Value?.ToString();

                    if (!string.IsNullOrEmpty(roomId))
                    {
                        // Create and show the ReservationRoomDetails form
                        reservationroomdetails detailsForm = new reservationroomdetails(roomId);
                        detailsForm.ShowDialog(); // Show as a dialog to pause execution until it's closed
                    }
                    else
                    {
                        MessageBox.Show("RoomID is not available.");
                    }
                }
                else
                {
                    MessageBox.Show("Invalid row index.");
                }
            }
        }
    }
}
