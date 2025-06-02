using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Mgmt_Sys_IOOP_CSharp
{
    internal class ClassReservation
    {
        private DatabaseUtility dbUtil; 
        public string RoomID { get; set; }
        public string RoomType { get; set; }
        public int Guest { get; set; }
        public string Beds { get; set; }
        public int Bathroom { get; set; }
        public string TypeOfBathroom { get; set; }
        public string Amenities { get; set; }
        public decimal Price { get; set; }

        //public static string LoggedInCustomerID { get; set; }

        private string connectionString;

        public ClassReservation()
        {
            connectionString = ConfigurationManager.ConnectionStrings["dBConnect"].ToString();
        }

        public bool LoadDetails(string roomId)
        {
            bool success = false;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string sqlQuery = @"
                    SELECT Room_Number, Room_Type, Guest, Beds, Bathroom, Bathroom_Type, Amenities, Price_Per_Night
                    FROM [dbo].[Room]
                    WHERE Room_Number = @Room_Number";
                SqlCommand cmd = new SqlCommand(sqlQuery, conn);
                cmd.Parameters.AddWithValue("@Room_Number", roomId);

                try
                {
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        RoomID = reader["Room_Number"].ToString();
                        RoomType = reader["Room_Type"].ToString();
                        Guest = Convert.ToInt32(reader["Guest"]);
                        Beds = reader["Beds"].ToString();
                        Bathroom = Convert.ToInt32(reader["Bathroom"]);
                        TypeOfBathroom = reader["Bathroom_Type"].ToString();
                        Amenities = reader["Amenities"].ToString();
                        Price = Convert.ToDecimal(reader["Price_Per_Night"]);
                        success = true;
                    }
                    conn.Close();
                }

                catch (Exception ex)
                {
                    Console.WriteLine($"An error occurred while fetching room details: {ex.Message}");
                }
            }
            return success;
        }

        public string GetRoomType() => RoomType;
        public string GetGuest() => Guest.ToString();
        public string GetBeds() => Beds;
        public string GetBathroom() => Bathroom.ToString();
        public string GetTypeOfBathroom() => TypeOfBathroom;
        public string GetAmenities() => Amenities;
        public string GetPrice() => Price.ToString("C");


        public bool AddReservation(string roomId, DateTime checkInDate, DateTime checkOutDate, decimal finalPrice, string customerID, out string errorMessage)
        {
            bool success = false;
            errorMessage = string.Empty;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlTransaction transaction = conn.BeginTransaction();

                try
                {
                    string reservationIDGen = GenerateReservationID();
                    // Insert into Reservation table
                    string insertReservationQuery = @"
                    INSERT INTO [dbo].[Reservation] (ReservationID, Room_Number, CheckInDate, CheckOutDate, TotalPrice, CustomerID)
                    VALUES (@ReservationID, @Room_Number, @CheckInDate, @CheckOutDate, @TotalPrice, @CustomerID)";

                    using (SqlCommand insertReservationCmd = new SqlCommand(insertReservationQuery, conn, transaction))
                    {
                        insertReservationCmd.Parameters.Add("@ReservationID", SqlDbType.VarChar).Value = reservationIDGen;
                        insertReservationCmd.Parameters.Add("@Room_Number", SqlDbType.VarChar).Value = roomId;
                        insertReservationCmd.Parameters.Add("@CheckInDate", SqlDbType.Date).Value = checkInDate;
                        insertReservationCmd.Parameters.Add("@CheckOutDate", SqlDbType.Date).Value = checkOutDate;
                        insertReservationCmd.Parameters.Add("@TotalPrice", SqlDbType.Decimal).Value = finalPrice;
                        insertReservationCmd.Parameters.Add("@CustomerID", SqlDbType.VarChar).Value = customerID;

                        insertReservationCmd.ExecuteNonQuery();
                    }

                    transaction.Commit();
                    success = true;
                }
                catch (Exception ex)
                {
                    errorMessage = ex.Message;
                    transaction.Rollback();
                }
                finally
                {
                    conn.Close();
                }
            }
            return success;
        }


        public DataTable GetReservationsByCustomerId(string customerId)
        {           
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string sqlQuery = @"
        SELECT ReservationID, Room_Number, CheckInDate, CheckOutDate, TotalPrice, 
           ISNULL([Additional_Requests], '') AS [AdditionalRequests], 
           ISNULL(Rating, '') AS Rating, 
           ISNULL(Comment, '') AS Comment
        FROM [dbo].[Reservation]
        WHERE CustomerID = @CustomerID";
                SqlCommand cmd = new SqlCommand(sqlQuery, conn);
                cmd.Parameters.Add("@CustomerID", SqlDbType.VarChar).Value = customerId;

                try
                {
                    conn.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(dt);
                    conn.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"An error occurred while loading reservations: {ex.Message}");
                }
            }
            return dt;
        }

        public Dictionary<string, string> GetReservationsDetailRow(string reservationId)
        {
            Dictionary<string, string> dict = new Dictionary<string, string>() ; 
            try
            {
                dbUtil = new DatabaseUtility("dbConnect");
                dict = dbUtil.GetRowData("Reservation", "ReservationID", reservationId);
                dbUtil.Close(); 
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred while GetReservationsDetailRow(): {ex.Message}");
            }
            
            return dict;
        }

        private string GenerateReservationID()
        {
            string reservationIDStr;
            DatabaseUtility dbUtil = new DatabaseUtility("dBConnect");

            // Retrieve the ReservationID column data
            List<string> reservationIDs = dbUtil.GetColumnData("ReservationID", "Reservation");

            if (reservationIDs.Count > 0)
            {
                // Get the last reservation ID
                string lastReservationID = reservationIDs.Last();
                int id = int.Parse(lastReservationID.Replace("RS", ""));
                id += 1;
                reservationIDStr = "RS" + string.Format("{0:000}", id);
            }
            else
            {
                // If there are no existing reservations, start with RS001
                reservationIDStr = "RS001";
            }

            return reservationIDStr;
        }

        public string GetAdditionalRequests(string room_id)
        {
            string addRequest = "";
            Dictionary<string, string> rDict; 
            try
            {
                DatabaseUtility dbUtil = new DatabaseUtility("dBConnect");
                rDict = new Dictionary<string, string>(); 
                rDict = dbUtil.GetRowData("Reservation", "Room_Number", room_id);
                addRequest = rDict["Additional_Requests"];
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred while GetReservationsDetailRow(): {ex.Message}");
            }
           
            return addRequest;
        }

        public int GetNumNightsStay(string reservation_id)
        {
            DateTime CheckInDate = new DateTime();
            DateTime CheckOutDate = new DateTime();
            int days = -1; 
            try
            {
                DatabaseUtility dbUtil = new DatabaseUtility("dBConnect");
                Dictionary<string, string> rDict = dbUtil.GetRowData("Reservation", "ReservationID", reservation_id);
                if (DateTime.TryParse(rDict["CheckInDate"], out CheckInDate) && DateTime.TryParse(rDict["CheckOutDate"], out CheckOutDate))
                {
                    TimeSpan ts = CheckOutDate.Subtract(CheckInDate);
                    days = Convert.ToInt32(ts.Days);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while GetReservationsDetailRow(): {ex.Message}");
            }

            return days;
        }


        public static bool DeleteReservation(string reservationId, out string errorMessage)
        {
            errorMessage = string.Empty;
            try
            {
                using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["dBConnect"].ToString()))
                {
                    string query = "DELETE FROM [dbo].[Reservation] WHERE ReservationID = @ReservationID";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.Add("@ReservationID", SqlDbType.VarChar).Value = reservationId;
                        conn.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();
                        conn.Close();
                        return rowsAffected > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                errorMessage = ex.Message;
                return false;
            }
        }
        public bool UpdateReservation(string reservationId, DateTime? checkInDate, DateTime? checkOutDate, string additionalRequests, out string errorMessage)
        {
            bool success = false;
            errorMessage = string.Empty;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string roomId = GetRoomIdFromReservation(reservationId);

                if (checkInDate.HasValue && checkOutDate.HasValue)
                {
                    string overlapQuery = @"
                    SELECT COUNT(*)
                    FROM [dbo].[Reservation]
                    WHERE Room_Number = @Room_Number
                      AND ReservationID != @ReservationID
                      AND ((@CheckInDate >= CheckInDate AND @CheckInDate < CheckOutDate) 
                        OR (@CheckOutDate > CheckInDate AND @CheckOutDate <= CheckOutDate)
                        OR (@CheckInDate <= CheckInDate AND @CheckOutDate >= CheckOutDate))";

                    SqlCommand overlapCmd = new SqlCommand(overlapQuery, conn);
                    overlapCmd.Parameters.Add("@Room_Number", SqlDbType.VarChar).Value = roomId;
                    overlapCmd.Parameters.Add("@ReservationID", SqlDbType.VarChar).Value = reservationId;
                    overlapCmd.Parameters.Add("@CheckInDate", SqlDbType.DateTime).Value = checkInDate.Value;
                    overlapCmd.Parameters.Add("@CheckOutDate", SqlDbType.DateTime).Value = checkOutDate.Value;

                    int overlapCount = Convert.ToInt32(overlapCmd.ExecuteScalar());
                    if (overlapCount > 0)
                    {
                        errorMessage = "Failed to update: The room is booked in these dates.";
                        return false;
                    }
                }

                StringBuilder queryBuilder = new StringBuilder("UPDATE [dbo].[Reservation] SET ");
                List<SqlParameter> parameters = new List<SqlParameter>();

                decimal pricePerDay = GetPricePerDay(roomId);

                if (checkInDate.HasValue)
                {
                    queryBuilder.Append("CheckInDate = @CheckInDate, ");
                    parameters.Add(new SqlParameter("@CheckInDate", SqlDbType.DateTime) { Value = checkInDate.Value });
                }

                if (checkOutDate.HasValue)
                {
                    queryBuilder.Append("CheckOutDate = @CheckOutDate, ");
                    parameters.Add(new SqlParameter("@CheckOutDate", SqlDbType.DateTime) { Value = checkOutDate.Value });

                    if (checkInDate.HasValue)
                    {
                        int numberOfNights = (checkOutDate.Value - checkInDate.Value).Days;
                        decimal newPrice = numberOfNights * pricePerDay;

                        queryBuilder.Append("TotalPrice = @Price, ");
                        parameters.Add(new SqlParameter("@Price", SqlDbType.Decimal) { Value = newPrice });
                    }
                }

                if (!string.IsNullOrEmpty(additionalRequests))
                {
                    queryBuilder.Append("Additional_Requests = @AdditionalRequests, ");
                    parameters.Add(new SqlParameter("@AdditionalRequests", SqlDbType.VarChar) { Value = additionalRequests });
                }

                if (parameters.Count > 0)
                {
                    queryBuilder.Length -= 2;
                    queryBuilder.Append(" WHERE ReservationID = @ReservationID");
                    parameters.Add(new SqlParameter("@ReservationID", SqlDbType.VarChar) { Value = reservationId });

                    string updateQuery = queryBuilder.ToString();

                    try
                    {
                        using (SqlCommand cmd = new SqlCommand(updateQuery, conn))
                        {
                            cmd.Parameters.AddRange(parameters.ToArray());
                            int rowsAffected = cmd.ExecuteNonQuery();
                            success = rowsAffected > 0;
                        }
                    }
                    catch (Exception ex)
                    {
                        errorMessage = ex.Message;
                    }
                    finally
                    {
                        conn.Close();
                    }
                }
                else
                {
                    errorMessage = "No fields to update.";
                }
            }

            return success;
        }


        private string GetRoomIdFromReservation(string reservationId)
        {
            string roomId = string.Empty;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string sqlQuery = "SELECT Room_Number FROM [dbo].[Reservation] WHERE ReservationID = @ReservationID";
                SqlCommand cmd = new SqlCommand(sqlQuery, conn);
                cmd.Parameters.AddWithValue("@ReservationID", reservationId);

                try
                {
                    conn.Open();
                    object result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        roomId = result.ToString();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"An error occurred while fetching room ID: {ex.Message}");
                }
                finally
                {
                    conn.Close();
                }
            }

            return roomId;
        }


        public decimal GetPricePerDay(string roomId)
        {
            decimal pricePerDay = 0.0m;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string sqlQuery = "SELECT Price_Per_Night FROM [dbo].[Room] WHERE Room_Number = @Room_Number";
                SqlCommand cmd = new SqlCommand(sqlQuery, conn);
                cmd.Parameters.AddWithValue("@Room_Number", roomId);

                try
                {
                    conn.Open();
                    object result = cmd.ExecuteScalar();
                    if (result != null && decimal.TryParse(result.ToString(), out pricePerDay))
                    {
                        return pricePerDay;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"An error occurred while fetching room price: {ex.Message}");
                }
                finally
                {
                    conn.Close();
                }
            }

            return pricePerDay;
        }

        public bool AddRating(string reservationId, int rating, string comment, out string errorMessage)
        {
            bool success = false;
            errorMessage = string.Empty;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string query = @"
            UPDATE [dbo].[Reservation]
            SET Rating = @Rating,
                Comment = @Comment
            WHERE ReservationID = @ReservationID";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Rating", rating);
                    cmd.Parameters.AddWithValue("@Comment", comment ?? (object)DBNull.Value); // Handle null comments
                    cmd.Parameters.AddWithValue("@ReservationID", reservationId);

                    try
                    {
                        int rowsAffected = cmd.ExecuteNonQuery();
                        success = rowsAffected > 0;
                    }
                    catch (Exception ex)
                    {
                        errorMessage = ex.Message;
                    }
                    finally
                    {
                        conn.Close();
                    }
                }
            }

            return success;
        }

        public bool AddTotalPrice(string reservationId, decimal totalPrice, out string errorMessage)
        {
            bool success = false;
            errorMessage = string.Empty;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string query = @"
            UPDATE [dbo].[Reservation]
            SET TotalPrice = @TotalPrice
            WHERE ReservationID = @ReservationID";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@TotalPrice", totalPrice);
                    cmd.Parameters.AddWithValue("@ReservationID", reservationId);

                    try
                    {
                        int rowsAffected = cmd.ExecuteNonQuery();
                        success = rowsAffected > 0;
                    }
                    catch (Exception ex)
                    {
                        errorMessage = ex.Message;
                    }
                    finally
                    {
                        conn.Close();
                    }
                }
            }

            return success;
        }

        public bool AddFinalBill(string reservationId, decimal finalBill, out string errorMessage)
        {
            bool success = false;
            errorMessage = string.Empty;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string query = @"
            UPDATE [dbo].[Reservation]
            SET FinalBill = @FinalBill
            WHERE ReservationID = @ReservationID";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@FinalBill", finalBill);
                    cmd.Parameters.AddWithValue("@ReservationID", reservationId);

                    try
                    {
                        int rowsAffected = cmd.ExecuteNonQuery();
                        success = rowsAffected > 0;
                    }
                    catch (Exception ex)
                    {
                        errorMessage = ex.Message;
                    }
                    finally
                    {
                        conn.Close();
                    }
                }
            }

            return success;
        }


        public DataTable GetCustomerProfileById(int customerId)
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string sqlQuery = @"
            SELECT CustomerID, FirstName, LastName, Job, ICNumber, ContactNumber, Email
            FROM [dbo].[Customer]
            WHERE CustomerID = @CustomerID";
                SqlCommand cmd = new SqlCommand(sqlQuery, conn);
                cmd.Parameters.Add("@CustomerID", SqlDbType.VarChar).Value = customerId;

                try
                {
                    conn.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(dt);
                    conn.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"An error occurred while loading customer profile: {ex.Message}");
                }
            }
            return dt;
        }

        public bool UpdateCustomerProfile(int customerId, string newJob, string newEmail, string newContactNumber, out string errorMessage)
        {
            bool success = false;
            errorMessage = string.Empty;
            List<string> updates = new List<string>();

            if (!string.IsNullOrEmpty(newJob))
            {
                updates.Add("Job = @Job");
            }
            if (!string.IsNullOrEmpty(newEmail))
            {
                updates.Add("Email = @Email");
            }
            if (!string.IsNullOrEmpty(newContactNumber))
            {
                updates.Add("ContactNumber = @ContactNumber");
            }

            if (updates.Count > 0)
            {
                string updateQuery = $"UPDATE [dbo].[Customer] SET {string.Join(", ", updates)} WHERE CustomerID = @CustomerID";

                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["myDB"].ToString()))
                {
                    SqlCommand command = new SqlCommand(updateQuery, connection);

                    if (!string.IsNullOrEmpty(newJob))
                    {
                        command.Parameters.AddWithValue("@Job", newJob);
                    }
                    if (!string.IsNullOrEmpty(newEmail))
                    {
                        command.Parameters.AddWithValue("@Email", newEmail);
                    }
                    if (!string.IsNullOrEmpty(newContactNumber))
                    {
                        command.Parameters.AddWithValue("@ContactNumber", newContactNumber);
                    }
                    command.Parameters.AddWithValue("@CustomerID", customerId);

                    try
                    {
                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();
                        success = rowsAffected > 0;
                    }
                    catch (Exception ex)
                    {
                        errorMessage = ex.Message;
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }
            else
            {
                errorMessage = "No fields to update.";
            }

            return success;
        }

        public DataTable GetReservationDetailsRoomByID(string roomId)
        {
            DataTable dt = new DataTable();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string sqlQuery = @"
            SELECT re.ReservationID, r.Room_Number, r.Room_Type, r.guest, r.Beds, r.bathroom, r.Bathroom_Type, r.amenities, 
                   re.TotalPrice
            FROM [dbo].[Room] r
            INNER JOIN [dbo].[Reservation] re ON r.Room_Number = re.Room_Number
            WHERE r.Room_Number = @Room_Number";

                SqlCommand cmd = new SqlCommand(sqlQuery, conn);
                cmd.Parameters.AddWithValue("@Room_Number", roomId);

                try
                {
                    conn.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(dt);
                    conn.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"An error occurred while fetching reservation details: {ex.Message}");
                }
            }

            return dt;
        }


    }
}
