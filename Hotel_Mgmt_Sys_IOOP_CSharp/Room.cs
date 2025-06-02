using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Hotel_Mgmt_Sys_IOOP_CSharp
{
    internal class Room
    {
        static SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["dbConnect"].ToString());
        private int _roomID;
        private string _venue;
        private string _roomType;
        private int _guest;
        private string _bedNum;
        private int _bathroomNum;
        private string _typeOfBathroom;
        private string _amenities;
        private double _pricePerNight;
        private string _OccupancyStatus;
        private int _ReservationID;

        public int roomID { get { return _roomID; } set { _roomID = value; } }
        public string venue { get { return _venue; } set { _venue = value; } }
        public string roomType { get { return _roomType; } set { _roomType = value; } }
        public int guest { get { return _guest; } set { _guest = value; } }
        public string bedNum { get { return _bedNum; } set { _bedNum = value; } }
        public int bathroomNum { get { return _bathroomNum; } set { _bathroomNum = value; } }
        public string typeOfBathroom { get { return _typeOfBathroom; } set { _typeOfBathroom = value; } }
        public string amenities { get { return _amenities; } set { _amenities = value; } }
        public double pricePerNight { get { return _pricePerNight; } set { _pricePerNight = value; } }
        public string OccupancyStatus { get { return _OccupancyStatus; } set { _OccupancyStatus = value; } }

        public int ReservationID { get => _ReservationID; set => _ReservationID = value; }

        DatabaseUtility dbUtil; 

        public Room(int room_id, string OccupancyStatus, int ReservationID)
        {
            _roomID = room_id;
            _OccupancyStatus = OccupancyStatus;
            _ReservationID = ReservationID;
        }

        public Room(int room_id,int ReservationID)
        {
            _roomID = room_id;
            _ReservationID = ReservationID;
        }

        public Room()
        { 
        
        }


        public Room(int room_id)
        {
            _roomID = room_id;
        }

        //public Room(string o, string r, string f, string p, string R)
        //{
        //    _OccupancyStatus = o;
        //    _ReservationID = r;
        //    _FinalBill = f;
        //    _Price = p;
        //    _roomID = int.Parse(R);
        //}

        public Room(int room_id, string location, string roomType, int guest, string beds, int bathroom, string bathroomType, string amenities, double pricePerNight, string OccupancyStatus)
        {
            _roomID = room_id;
            _venue = location; 
            _roomType = roomType; 
            _guest = guest; 
            _bedNum = beds; 
            _bathroomNum = bathroom; 
            _typeOfBathroom = bathroomType;
            _amenities = amenities; 
            _pricePerNight = pricePerNight;
            _OccupancyStatus = OccupancyStatus;
        }


        public void getDetails(string room_id, out Room obj)
        {
            obj = new Room(int.Parse(room_id)); 

            dbUtil = new DatabaseUtility("dbConnect");
            Dictionary <string, string> dictOutput = dbUtil.GetRowData("Room", "Room_Number", room_id);
            List<string> header = dbUtil.RetriveTableHeader("Room");
            obj._roomID = int.Parse(room_id); 
            obj._venue = dictOutput[header[1]];
            obj._roomType = dictOutput[header[2]];
            obj._guest = int.Parse(dictOutput[header[3]]);
            obj._bedNum = dictOutput[header[4]];
            obj._bathroomNum = int.Parse(dictOutput[header[5]]);
            obj._typeOfBathroom = dictOutput[header[6]];
            obj._amenities = dictOutput[header[7]];
            obj._pricePerNight = double.Parse(dictOutput[header[8]]);
            obj._OccupancyStatus = dictOutput[header[9]];


            //dbUtil.SqlCmdExecute(""); ; 
        }

        public List<List<string>> searchKeywords(string searchTerm = "")
        {
            string tableQuery = "Room";
            string Search = $"%{searchTerm.TrimStart().TrimEnd().ToLower()}%"; 
            dbUtil = new DatabaseUtility("dbConnect");
            string QuerySQL = @"SELECT * FROM Room
                WHERE
                Room_Number LIKE @Search OR 
                Venue LIKE @Search OR 
                Room_Type LIKE @Search OR 
                CAST(guest AS VARCHAR) LIKE @Search OR 
                beds LIKE @Search OR
                CAST(bathroom AS VARCHAR) LIKE @Search OR
                Bathroom_Type LIKE @Search OR
                amenities LIKE @Search OR
                CAST(Price_Per_Night AS VARCHAR) LIKE @Search OR
                Occupancy_Status LIKE @Search";
            dbUtil.SqlCmdExecute(QuerySQL, new Dictionary<string, string>() { { "@Search", Search } }, DatabaseUtility.cmdExeWriteMode.NonQuery, out object result);           
            List<List<string>> searchResults = dbUtil.SqlCmdReader();
            dbUtil.Close();

            return searchResults;
        }

        public List<List<string>> viewAllRooms()
        {
            string tableQuery = "Room";
            dbUtil = new DatabaseUtility("dbConnect");
            string QuerySQL = @"SELECT * FROM Room";

            dbUtil.SqlCmdExecute(QuerySQL, new Dictionary<string, string>() {}, DatabaseUtility.cmdExeWriteMode.NonQuery, out object result);
            List<List<string>> allRooms = dbUtil.SqlCmdReader();
            dbUtil.Close();

            return allRooms;        
        }

        public int deleteRoom(string roomNum)
        {
            int status = 0;

            string tableQuery = "Room";
            dbUtil = new DatabaseUtility("dbConnect");
            string QuerySQL = $@"DELETE FROM [{tableQuery}] 
                            WHERE Room_Number = @Room_Number";
            status = dbUtil.SqlCmdExecute(QuerySQL, new Dictionary<string, string>() { { "@Room_Number", roomNum.ToString() } }, DatabaseUtility.cmdExeWriteMode.NonQuery, out object result);
            dbUtil.Close();
            return status; 
        }

        public int addRoom()
        {
            int status = 0; 
            string tableQuery = "Room";
            dbUtil = new DatabaseUtility("dbConnect");
            string QuerySQL = $@"INSERT INTO [Room] (Room_Number, Venue, Room_type, guest, beds, bathroom, Bathroom_Type, amenities, Price_Per_Night, Occupancy_Status) 
                                VALUES(@Room_Number, @Venue, @Room_type, @guest, @beds, @bathroom, @Bathroom_Type, @amenities, @Price_Per_Night, @Occupancy_Status)";

            List<string> tableHeader = dbUtil.RetriveTableHeader(tableQuery);
            Dictionary<string,string> cmdParams = new Dictionary<string, string>() 
            { 
                { "@Room_Number", _roomID.ToString() },
                { "@Venue", _venue},
                { "@Room_type", _roomType },
                { "@guest", _guest.ToString() },
                { "@beds", _bedNum.ToString() },
                { "@bathroom", _bathroomNum.ToString() },
                { "@Bathroom_Type", _typeOfBathroom },
                { "@amenities", _amenities },
                { "@Price_Per_Night", _pricePerNight.ToString()},
                { "@Occupancy_Status", _OccupancyStatus}
            };

            status = dbUtil.SqlCmdExecute(QuerySQL, cmdParams, DatabaseUtility.cmdExeWriteMode.NonQuery, out object result);
            dbUtil.Close();
            return status; 
        }

        public int editRoom()
        {
            int status = 0;
            string tableQuery = "Room";
            dbUtil = new DatabaseUtility("dbConnect");
            string QuerySQL = $@"UPDATE [Room] SET Room_Number = @Room_Number, Venue = @Venue, Room_Type = @Room_Type, " + 
                                "guest = @guest, beds = @beds, bathroom = @bathroom, Bathroom_Type = @Bathroom_Type, " +
                                "amenities = @amenities, Price_Per_Night = @Price_Per_Night, Occupancy_Status = @Occupancy_Status " +
                                "WHERE Room_Number = @Room_Number";

            List<string> tableHeader = dbUtil.RetriveTableHeader(tableQuery);
            Dictionary<string, string> cmdParams = new Dictionary<string, string>()
            {
                { "@Room_Number", _roomID.ToString() },
                { "@Venue", _venue.ToString()},
                { "@Room_Type", _roomType.ToString() },
                { "@guest", _guest.ToString() },
                { "@beds", _bedNum.ToString() },
                { "@bathroom", _bathroomNum.ToString() },
                { "@Bathroom_Type", _typeOfBathroom.ToString() },
                { "@amenities", _amenities.ToString() },
                { "@Price_Per_Night", _pricePerNight.ToString()},
                { "@Occupancy_Status", _OccupancyStatus}
            };

            status = dbUtil.SqlCmdExecute(QuerySQL, cmdParams, DatabaseUtility.cmdExeWriteMode.NonQuery, out object result);
            dbUtil.Close();
            return status;
        }

        public int generateRoomID(int floorNum, int roomNum)
        {
            int levelVal = floorNum;
            int digitCount = 0;
            string formatString = "";
            while (levelVal > 0)
            {
                levelVal /= 10;
                digitCount++;
            }
            switch (digitCount)
            {
                case 1: formatString = "{0:0}{1:000}"; break;
                case 2: formatString = "{0:00}{1:00}"; break;
            }

            string id_str = string.Format(formatString, floorNum, roomNum);
            int roomID = int.Parse(id_str);

            return roomID;
        }

        public string CustomerCheckIn()
        {
            string status;
            {
                try
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand("UPDATE Room set OccupancyStatus = @status WHERE _roomID = @RoomID", con))
                    {
                        cmd.Parameters.AddWithValue("@RoomID", _roomID);
                        cmd.Parameters.AddWithValue("@status", OccupancyStatus);


                        int i = cmd.ExecuteNonQuery();
                        if (i > 0)
                            status = "CheckIn Successful.";
                        else
                            status = "Unable to CheckIn.";
                    }
                }
                catch (Exception ex)
                {
                    status = "Error: " + ex.Message;
                }
                finally
                {
                    con.Close();
                }
            }
            return status;
        }

        public string CustomerCheckOut()
        {
            string status;
            {
                try
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand("SELECT OccupancyStatus FROM Room WHERE _roomID = @RoomID", con))
                    {
                        cmd.Parameters.AddWithValue("@RoomID", _roomID);

                        object result = cmd.ExecuteScalar();

                        if (result == null)
                        {
                            status = "RoomID not found.";
                        }
                        else if (result.ToString() != "Check In")
                        {
                            status = "Room is not currently checked in.";
                        }
                        else
                        {
                            string updateStatusQuery = "UPDATE Room SET OccupancyStatus = 'Checked Out' WHERE _roomID = @RoomID";
                            using (SqlCommand updateCmd = new SqlCommand(updateStatusQuery, con))
                            {
                                updateCmd.Parameters.AddWithValue("@RoomID", _roomID);

                                int i = updateCmd.ExecuteNonQuery();
                                if (i > 0)
                                    status = "CheckOut Successful.";
                                else
                                    status = "Unable to CheckOut.";
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    status = "Error: " + ex.Message;
                }
                finally
                {
                    con.Close();
                }
            }
            return status;
        }

        public string ShowPrice()
        {
            string Price = "";

            {
                try
                {
                    con.Open();
                    string query = "SELECT Price FROM Reservation WHERE ReservationID = @reservationid";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@reservationid", ReservationID);
                        object result = cmd.ExecuteScalar();

                        if (result != null)
                        {
                            Price = result.ToString();
                        }
                        else
                        {
                            Price = "No data found for the specified ReservationID.";
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
                finally
                {
                    con.Close();
                }
            }
            return Price;
        }
    }
}
