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
    public partial class RoomAmenitiesForm : Form
    {
        public RoomAmenitiesForm(string roomType, string beds, string bathroom, string typeOfBathroom, string amenities)
        {
            InitializeComponent();
            // Set the label texts
            labelRoomType.Text = roomType;
            labelBed.Text = beds;
            labelTypeBathroom.Text = typeOfBathroom;
            labelBathroom.Text = bathroom;
            labelAmenities.Text = amenities;
        }
    }
}
