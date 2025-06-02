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
    public partial class CheckOutForm : Form
    {
        public CheckOutForm()
        {
            InitializeComponent();
        }

        private void Confirm_Click(object sender, EventArgs e)
        {
            int RoomID = int.Parse(txtRoomID.Text);
            int ReservationID = int.Parse(txtReservationID.Text);
            decimal AdditionalFee;
            if (!decimal.TryParse(txtAdditionalFee.Text, out AdditionalFee))
            {
                MessageBox.Show("Invalid additional fee entered. Please enter a valid number.", "Error");
                return;
            }
            Room obj2 = new Room(RoomID, ReservationID);

            string checkOutStatus = obj2.CustomerCheckOut();
            if (checkOutStatus != "CheckOut Successful.")
            {
                MessageBox.Show(checkOutStatus, "Checkout Status");
                return;
            }

            string price = obj2.ShowPrice();

            decimal PriceValue;
            decimal.TryParse(price, out PriceValue);
            decimal finalBill = PriceValue + AdditionalFee;

            string message = $"{checkOutStatus}\nInitial Bill: {price}\nAdditional Value: {AdditionalFee:C}\nFinal Bill: {finalBill:C}";
            MessageBox.Show(message, "Checkout and Final Bill Information");
        }
    }
}
