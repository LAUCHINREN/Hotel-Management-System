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
    public partial class HousekeeperHomePage : Form
    {
        private string _CustomerID; 
        public HousekeeperHomePage()
        {
            InitializeComponent();
            //_CustomerID = CustomerID; 
        }

        private void btnSchedule_Click(object sender, EventArgs e)
        {
            CleaningDutyFrm scheduleCleaningFrm = new CleaningDutyFrm();
            scheduleCleaningFrm.ShowDialog(); 
        }

        private void roomconditionbutton_Click(object sender, EventArgs e)
        {
            RoomCondition f2 = new RoomCondition();
            f2.Show();
        }

        private void btnSupplies_Click(object sender, EventArgs e)
        {
            CleaningSuppliesForm suppliesFrm = new CleaningSuppliesForm();
            suppliesFrm.ShowDialog();
        }


    }
}
