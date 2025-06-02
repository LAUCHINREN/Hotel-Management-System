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
    public partial class RoomList : UserControl
    {
        private string customerID; 
        public RoomList(string customerID)
        {
            InitializeComponent();
            this.customerID = customerID; 
        }

        #region Properties
        private string _title;
        private string _message;
        private Image _icon;
        private string roomId;
        private decimal _price;
        private DateTime checkInDate;
        private DateTime checkOutDate;
        private int _nights;

        [Category("Custom Props")]
        public string Title
        {
            get { return _title; }
            set { _title = value; lblTitle.Text = value; }
        }

        [Category("Custom Props")]
        public string Message
        {
            get { return _message; }
            set { _message = value; lblMessage.Text = value; }
        }

        [Category("Custom Props")]
        public decimal Price
        {
            get { return _price; }
            set { _price = value; lblPrice.Text = $"RM {GetFinalPrice():F2}"; }
        }

        [Category("Custom Props")]
        public Image Icon
        {
            get { return _icon; }
            set { _icon = value; pictureRoom.Image = value; }
        }

        [Category("Custom Props")]
        public DateTime CheckInDate
        {
            get { return checkInDate; }
            set { checkInDate = value; } // Store or use as needed
        }

        [Category("Custom Props")]
        public DateTime CheckOutDate
        {
            get { return checkOutDate; }
            set { checkOutDate = value; }
        }
        public int Nights
        {
            get { return _nights; }
            set
            {
                _nights = value;
                lblPrice.Text = $"RM {GetFinalPrice():F2}";
            }
        }
        public string RoomID
        {
            get { return roomId; }
            set { roomId = value; }
        }

        private decimal GetFinalPrice()
        {
            return _price * _nights;
        }
        #endregion

        private void btnMoreInfo_Click(object sender, EventArgs e)
        {
            decimal finalPrice = GetFinalPrice();
            RoomDetails detailsForm = new RoomDetails(roomId,checkInDate,checkOutDate,finalPrice,customerID);
            detailsForm.Show();
        }
    }
}
