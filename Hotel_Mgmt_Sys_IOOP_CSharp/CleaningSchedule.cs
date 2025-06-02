using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Mgmt_Sys_IOOP_CSharp
{
    internal class CleaningSchedule
    {
        private DatabaseUtility dbUtil;

        private string _employeeID;
        private string _roomNum;
        private string _roomType;
        private string _date;
        private string _time;
        private string _venue;
        private string _addRequest;
        private string _issueReport;

        public string employeeID { get { return _employeeID; } set { _employeeID = value; } } 
        public string roomNum { get { return _roomNum; } set { _roomNum = value; } }
        public string roomType { get { return _roomType; } set { _roomType = value; } }
        public string date { get { return _date; } set { _date = value; } }
        public string time { get { return _time; } set { _time = value; } }
        public string venue { get { return _venue; } set { _venue = value; } }
        public string addRequest { get { return _addRequest; } set { _addRequest = value; } }
        public string issueReport { get { return _issueReport; } set { _issueReport = value; } }


        public CleaningSchedule()
        {

        }

        public CleaningSchedule(string roomNum, string date)
        {
            _roomNum = roomNum;
            _date = date; 
        }

        public int addSchedule(string fullNameAssignee)
        {
            int status = 0;

            try
            {
                string tableQuery = "CleaningSchedule";
                dbUtil = new DatabaseUtility("dbConnect");
                string QuerySQL = $@"INSERT INTO [CleaningSchedule] (ScheduleID, EmployeeID, Room_Number, Room_Type, Date, Time, Venue, Additional_Requests) 
                                VALUES(@ScheduleID, @EmployeeID, @Room_Number, @Room_Type, @Date, @Time, @Venue, @Additional_Requests)";

                //ScheduleID Gen 
                string scheduleIDGen = "";
                status = generateScheduleID(out scheduleIDGen); 

                //
                string empID = ""; 
                Employee emp = new Employee();
                status = emp.getEmployeeID(fullNameAssignee, "Housekeeper", out empID);

                //Room 
                Room roomAccess = new Room();
                Room room = new Room();
                roomAccess.getDetails(_roomNum, out room);

                //Reservation
                ClassReservation reservation = new ClassReservation();
                string addRequest = reservation.GetAdditionalRequests(roomNum); 

                Dictionary<string, string> cmdParams = new Dictionary<string, string>()
                {
                    { "ScheduleID", scheduleIDGen},
                    { "@EmployeeID", empID.ToString() },
                    { "@Room_Number", _roomNum.ToString()},
                    { "@Room_Type", room.roomType },
                    { "@Date", _date.ToString() },
                    { "@Time", "12pm - 3pm" },
                    { "@Venue", room.venue },
                    { "@Additional_Requests", addRequest.ToString() }
                };

                status = dbUtil.SqlCmdExecute(QuerySQL, cmdParams, DatabaseUtility.cmdExeWriteMode.NonQuery, out object result);
                dbUtil.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                status = -1;
            }

            return status;
        }

        public int deleteSchedule(string scheduleID)
        {
            int status = 0;

            try
            {
                string tableQuery = "CleaningSchedule";
                dbUtil = new DatabaseUtility("dbConnect");
                string QuerySQL = $@"DELETE FROM [{tableQuery}] 
                            WHERE ScheduleID = @ScheduleID";
                status = dbUtil.SqlCmdExecute(QuerySQL, new Dictionary<string, string>() { { "@ScheduleID", scheduleID.ToString() } }, DatabaseUtility.cmdExeWriteMode.NonQuery, out object result);
                dbUtil.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                status = -1;
            }

            return status;
        }

        public int viewAllSchedule(out List<List<string>> allSchedule)
        {
            int status = 0;
            allSchedule = new List<List<string>>(); 

            try
            {
                string tableQuery = "CleaningSchedule";
                dbUtil = new DatabaseUtility("dbConnect");
                string QuerySQL = $@"SELECT * FROM {tableQuery}";

                dbUtil.SqlCmdExecute(QuerySQL, new Dictionary<string, string>() { }, DatabaseUtility.cmdExeWriteMode.NonQuery, out object result);
                allSchedule = dbUtil.SqlCmdReader();
                dbUtil.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                status = -1;
            }

            return status;
        }


        public int generateScheduleID(out string scheduleID)
        {
            int status = 0;
            scheduleID = "";

            try
            {
                string tableQuery = "CleaningSchedule";
                dbUtil = new DatabaseUtility("dbConnect");
                string QuerySQL = $@"SELECT TOP 1 * FROM [{tableQuery}] ORDER BY ScheduleID DESC";
                status = dbUtil.SqlCmdExecute(QuerySQL, new Dictionary<string, string>(), DatabaseUtility.cmdExeWriteMode.NonQuery, out object result);
                List<List<string>> lastID = dbUtil.SqlCmdReader();

                int ID_int = -1;
                if (lastID.Count <= 0)
                {
                    ID_int = 1;
                }
                else
                {
                    string ID_str_temp = lastID[0][0].ToLower().Replace("sc", "");
                    ID_int = int.Parse(ID_str_temp);

                    ID_int += 1;

                }

                scheduleID = "SC" + string.Format("{0:000}", ID_int);
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
