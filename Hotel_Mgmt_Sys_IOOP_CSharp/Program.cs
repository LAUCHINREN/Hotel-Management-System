using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Mgmt_Sys_IOOP_CSharp
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            GlobalVars GlobalVars = new GlobalVars();
            Application.Run(new ReceptionistHomePage()); //mainFrm //manageUserFrm //manageRoomFrm //manageRoomFrm //manageCleaningScheduleFrm

            //UserLoginForm


            //HousekeeperHomePage
            //CustomerHomePage("CU001")
            //RoomView("CU001")
            //UserLoginForm();
        }
    }
}
