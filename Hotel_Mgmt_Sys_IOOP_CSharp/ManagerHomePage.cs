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
    public partial class ManagerHomePage : Form
    {
        public ManagerHomePage()
        {
            InitializeComponent();
            //_CustomerID = CustomerID; 
        }

        private void btnManageUser_Click(object sender, EventArgs e)
        {
            manageEmpFrm form = new manageEmpFrm();
            form.ShowDialog();
        }

        private void btnManageRoom_Click(object sender, EventArgs e)
        {
            manageRoomFrm form = new manageRoomFrm();
            form.ShowDialog();
        }

        private void btnManageHousekeeping_Click(object sender, EventArgs e)
        {
            manageCleaningScheduleFrm form = new manageCleaningScheduleFrm();
            form.ShowDialog();
        }

        private void btnViewReports_Click(object sender, EventArgs e)
        {
            managerReportFrm form = new managerReportFrm();
            form.ShowDialog();
        }
    }
}
