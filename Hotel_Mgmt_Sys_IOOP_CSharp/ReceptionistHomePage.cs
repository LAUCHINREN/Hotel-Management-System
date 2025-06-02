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
    public partial class ReceptionistHomePage : Form
    {
        public ReceptionistHomePage()
        {
            InitializeComponent();
        }

        private void cutomerdetailsbutton_Click(object sender, EventArgs e)
        {
            CustomerDetails f1 = new CustomerDetails();
            f1.Show();
        }

        private void roomconditionbutton_Click(object sender, EventArgs e)
        {
            RoomCondition f2 = new RoomCondition();
            f2.Show();
        }

        private void reservationbutton_Click(object sender, EventArgs e)
        {
            ReservationForm f3 = new ReservationForm();
            f3.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EmpProfileFrm f4 = new EmpProfileFrm();
            f4.Show();
        }
    }
}
