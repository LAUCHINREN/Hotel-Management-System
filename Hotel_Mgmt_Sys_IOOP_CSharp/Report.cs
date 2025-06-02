using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Windows.Forms;

namespace Hotel_Mgmt_Sys_IOOP_CSharp
{
    internal class Report
    {
        private DatabaseUtility dbUtil;


        // ======================================= UTILITY FUNCTIONS ======================================= //
        public int viewAllRoomOccupancy(out List<List<string>> allRooms)
        {
            int status = 0;
            allRooms = new List<List<string>>(); 

            try
            {
                string tableQuery = "Room";
                dbUtil = new DatabaseUtility("dbConnect");
                string QuerySQL = @"SELECT * FROM Room"; 

                dbUtil.SqlCmdExecute(QuerySQL, new Dictionary<string, string>() { }, DatabaseUtility.cmdExeWriteMode.NonQuery, out object result);
                allRooms = dbUtil.SqlCmdReader();
                dbUtil.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                status = -1;
            }

            return status; 
        }

        public int viewAllProfit(out List<List<string>> allRooms)
        {
            int status = 0;
            allRooms = new List<List<string>>();

            try
            {
                string tableQuery = "Reservation";
                dbUtil = new DatabaseUtility("dbConnect");
                string QuerySQL = @"SELECT * FROM Reservation";

                dbUtil.SqlCmdExecute(QuerySQL, new Dictionary<string, string>() { }, DatabaseUtility.cmdExeWriteMode.NonQuery, out object result);
                allRooms = dbUtil.SqlCmdReader();
                dbUtil.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                status = -1;
            }

            return status;
        }

        public int viewAllRatings(out List<List<string>> allRatingOutputs)
        {
            int status = 0;
            allRatingOutputs = new List<List<string>>();

            try
            {
                string tableQuery = "Reservation";
                dbUtil = new DatabaseUtility("dbConnect");
                string QuerySQL = @"SELECT * FROM Reservation";

                dbUtil.SqlCmdExecute(QuerySQL, new Dictionary<string, string>() { }, DatabaseUtility.cmdExeWriteMode.NonQuery, out object result);
                allRatingOutputs = dbUtil.SqlCmdReader();
                dbUtil.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                status = -1;
            }

            return status;
        }

    }
}
