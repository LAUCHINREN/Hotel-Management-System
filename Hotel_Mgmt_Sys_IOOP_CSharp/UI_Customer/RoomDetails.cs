using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Hotel_Mgmt_Sys_IOOP_CSharp
{
    public partial class RoomDetails : Form
    {
        private string customerID; 
        private string roomId;
        private int currentImageIndex = 0;
        private Timer slideshowTimer;
        private DateTime checkInDate;
        private DateTime checkOutDate;
        private decimal finalPrice;

        public RoomDetails(string roomId, DateTime checkInDate, DateTime checkOutDate, decimal finalPrice, string customerID)
        {
            InitializeComponent();
            this.roomId = roomId;
            InitializeSlideshow();
            this.checkInDate = checkInDate;
            this.checkOutDate = checkOutDate;
            this.finalPrice = finalPrice;
            this.customerID = customerID; 
        }

        private void InitializeSlideshow()
        {
            // Initialize Timers
            initialTimer = new Timer();
            initialTimer.Interval = 1000; // Initial interval in milliseconds (1 second)
            initialTimer.Tick += InitialTimer_Tick;

            slideshowTimer = new Timer();
            slideshowTimer.Interval = 3000; // Regular interval in milliseconds (3 seconds)
            slideshowTimer.Tick += SlideshowTimer_Tick;
        }

        private void InitialTimer_Tick(object sender, EventArgs e)
        {
            // Show the first image immediately
            ShowCurrentImage();

            // Stop initial timer and start regular slideshow timer
            initialTimer.Stop();
            slideshowTimer.Start();
        }

        private void SlideshowTimer_Tick(object sender, EventArgs e)
        {
            // Show the current image and move to the next
            ShowCurrentImage();
            currentImageIndex++;
            if (currentImageIndex >= imageListRoom.Images.Count)
            {
                currentImageIndex = 0; // Loop back to the first image
            }
        }

        private void ShowCurrentImage()
        {
            if (imageListRoom.Images.Count > 0)
            {
                pictureBoxRoom.Image = imageListRoom.Images[currentImageIndex];
            }
        }
        
        private void LoadRoomDetails()
        {
            ClassReservation Details = new ClassReservation();
            if (Details.LoadDetails(roomId))
            {

                lblRoomType.Text = $"{Details.GetRoomType()}";
                lblGuest.Text = $"{Details.GetGuest()} Guest";
                lblBed.Text = $"{Details.GetBeds()}";
                lblBathroom.Text = $"{Details.GetBathroom()} Bathroom";
                lblTypeofBathroom.Text = $"{Details.GetTypeOfBathroom()}";
                lblAmenities.Text = $"{Details.GetAmenities()}";
                lblPrice.Text = $"RM {finalPrice:F2}";
                InitializeSlideshowForRoomType(Details.GetRoomType());
                initialTimer.Start();
            }
            else
            {
                MessageBox.Show("Error cannot show");
            }
        }

        private void InitializeSlideshowForRoomType(string roomType)
        {
            // Clear existing images
            imageListRoom.Images.Clear();

            // Add images to ImageList based on room type
            switch (roomType.Replace(" ", "").ToLower())
            {
                case "singleroom":
                    imageListRoom.Images.Add(Properties.Resources.singleroom);
                    imageListRoom.Images.Add(Properties.Resources.singleroom2);
                    imageListRoom.Images.Add(Properties.Resources.singleroom3);
                    imageListRoom.Images.Add(Properties.Resources.singleroom4);
                    imageListRoom.Images.Add(Properties.Resources.teapotall);
                    break;
                case "deluxeroom":
                    imageListRoom.Images.Add(Properties.Resources.deluxeroom);
                    imageListRoom.Images.Add(Properties.Resources.deluxeroom2);
                    imageListRoom.Images.Add(Properties.Resources.deluxeroom3);
                    imageListRoom.Images.Add(Properties.Resources.deluxeroom4);
                    imageListRoom.Images.Add(Properties.Resources.teapotall);
                    break;
                case "standardroom":
                    imageListRoom.Images.Add(Properties.Resources.standardroom);
                    imageListRoom.Images.Add(Properties.Resources.standardroom1);
                    imageListRoom.Images.Add(Properties.Resources.standardroom2);
                    imageListRoom.Images.Add(Properties.Resources.standardroom3);
                    imageListRoom.Images.Add(Properties.Resources.teapotall);
                    break;
                case "familyroom":
                    imageListRoom.Images.Add(Properties.Resources.familyroom);
                    imageListRoom.Images.Add(Properties.Resources.familyroom2);
                    imageListRoom.Images.Add(Properties.Resources.familyroom3);
                    imageListRoom.Images.Add(Properties.Resources.familyroom4);
                    imageListRoom.Images.Add(Properties.Resources.teapotall);
                    break;
                default:
                    MessageBox.Show("No images available for this room type.");
                    break;
            }

            // Start the slideshow
            slideshowTimer.Start();
        }


        private void Details_Load(object sender, EventArgs e)
        {
            LoadRoomDetails();
        }

        private void btnBookNow_Click(object sender, EventArgs e)
        {
            try
            {
                ClassReservation reservation = new ClassReservation();
                string customerId = customerID;  //ClassReservation.LoggedInCustomerID;
                bool reservationSuccess = reservation.AddReservation(roomId, checkInDate, checkOutDate, finalPrice, customerId, out string errorMessage);

                if (reservationSuccess)
                {
                    MessageBox.Show("Booking Successful.");
                    Reservation r1 = new Reservation(customerId);
                    r1.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show($"Failed to book: {errorMessage}");
                }
            }
            catch (Exception ex)
            {
                // Log unexpected errors
                //Console.WriteLine($"An error occurred in btnBookNow_Click: {ex.Message}");
                MessageBox.Show("An unexpected error occurred." + ex.Message);
            }
        }

        private void lblAmenities_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
