using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Configuration;

namespace Hotel_Mgmt_Sys_IOOP_CSharp
{
    public partial class CleaningDutyFrm : Form
    {
        private Dictionary<string, StatusReportDetails> statusReports;
        //private string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\Teoh Peng Kee\\OneDrive - Asia Pacific University\\SE Course\\Y1S2\\IOOP\\Hotel_Mgmt_Sys_IOOP_CSharp\\Hotel_Mgmt_Sys_IOOP_CSharp\\DB\\myDB.mdf\";Integrated Security=True";
        public CleaningDutyFrm()
        {
            InitializeComponent();

            //// TODO: This line of code loads data into the 'upcomingPrepDataSet.Reservation' table. You can move, or remove it, as needed.
            //this.reservationTableAdapter.Fill(this.upcomingPrepDataSet.Reservation);
            //// TODO: This line of code loads data into the 'myScheduleDataSet.CleaningSchedule' table. You can move, or remove it, as needed.
            //this.cleaningScheduleTableAdapter.Fill(this.myScheduleDataSet.CleaningSchedule);
            //// TODO: This line of code loads data into the 'myDBDataSet2.CleaningSchedule' table. You can move, or remove it, as needed.

            LoadCurrentWeekSchedule();
            LoadScheduleData();
            btnFilterSchedule.Click += new EventHandler(btnFilterSchedule_Click);
            statusReports = new Dictionary<string, StatusReportDetails>();

        }
        private void LoadCurrentWeekSchedule()
        {
            DateTime today = DateTime.Today;
            dateTimePickerStart.Value = today.AddDays(-(int)today.DayOfWeek + (int)DayOfWeek.Monday);
            dateTimePickerEnd.Value = dateTimePickerStart.Value.AddDays(6);

            LoadMySchedule(dateTimePickerStart.Value, dateTimePickerEnd.Value);
            LoadUpcomingPreparation(dateTimePickerStart.Value, dateTimePickerEnd.Value);
        }

        private void LoadScheduleData()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["dbConnect"].ToString()))
                {
                    string query = "SELECT ScheduleID, Room_Number, Room_Type, Date, Time, Venue, Additional_Requests FROM CleaningSchedule";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable scheduleTable = new DataTable();
                    adapter.Fill(scheduleTable);

                    dataGridViewMySchedule.DataSource = scheduleTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading data: {ex.Message}");
            }
        }

        private void LoadMySchedule(DateTime startDate, DateTime endDate)
        {
            //string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\USER\\source\\repos\\IOOP_Assignment\\IOOP_Assignment\\DBofCleaningSupplies.mdf;Integrated Security=True";
            // SQL query to select necessary columns and sort by Date for 'My Schedule' tab


            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["dbConnect"].ToString()))
            {
                connection.Open();

                string query = "SELECT ScheduleID, Room_Number, Room_Type, Date, Time, Venue " +
                           "FROM CleaningSchedule " +
                           "WHERE Date >= @StartDate AND Date <= @EndDate";
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@StartDate", startDate);
                    cmd.Parameters.AddWithValue("@EndDate", endDate);

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    if (table.Rows.Count > 0)
                    {
                        dataGridViewMySchedule.DataSource = table;
                    }
                    else
                    {
                        dataGridViewMySchedule.DataSource = null;
                    }
                }
            }
        }

        private void LoadUpcomingPreparation(DateTime startDate, DateTime endDate)
        {
            //string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\USER\\source\\repos\\IOOP_Assignment\\IOOP_Assignment\\DBofCleaningSupplies.mdf;Integrated Security=True";
            // SQL query to select necessary columns and sort by Date for 'My Schedule' tab


            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["dbConnect"].ToString()))
            {
                connection.Open();

                // SQL query to select necessary columns and sort by Date for 'Upcoming Preparation' tab
                string query = "SELECT ScheduleID, Room_Number, Room_Type, Date, Time, Venue, Additional_Requests " +
                               "FROM CleaningSchedule " +
                               "WHERE Date >= @StartDate AND Date <= @EndDate";
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@StartDate", startDate);
                    cmd.Parameters.AddWithValue("@EndDate", endDate);

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    if (table.Rows.Count > 0)
                    {
                        dataGridViewUpcomingPreparation.DataSource = table;
                    }
                    else
                    {
                        dataGridViewUpcomingPreparation.DataSource = null;
                    }
                }
            }
        }


        private void btnFilterSchedule_Click(object sender, EventArgs e)
        {
            DateTime startDate = dateTimePickerStart.Value.Date;
            DateTime endDate = dateTimePickerEnd.Value.Date;

            LoadMySchedule(startDate, endDate);
            LoadUpcomingPreparation(startDate, endDate);
        }

        private void dataGridViewMySchedule_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridViewMySchedule.Columns["Cleaning_Status"].Index)
            {
                // Assuming columns are named appropriately
                string roomID = dataGridViewMySchedule.Rows[e.RowIndex].Cells["Room_Number"].Value.ToString();
                string roomType = dataGridViewMySchedule.Rows[e.RowIndex].Cells["Room_Type"].Value.ToString();
                string date = dataGridViewMySchedule.Rows[e.RowIndex].Cells["Date"].Value.ToString();
                string time = dataGridViewMySchedule.Rows[e.RowIndex].Cells["Time"].Value.ToString();
                string venue = dataGridViewMySchedule.Rows[e.RowIndex].Cells["Venue"].Value.ToString();

                StatusReportDetails existingDetails = statusReports.ContainsKey(roomID) ? statusReports[roomID] : new StatusReportDetails();

                CleaningStatusForm statusForm = new CleaningStatusForm(
                    roomID,
                    roomType,
                    date,
                    time,
                    venue,
                    existingDetails.StatusReport ?? "",
                    existingDetails.IsCleaned,
                    existingDetails.IsDirty,
                    existingDetails.ReportIssues ?? ""
                );

                statusForm.ShowDialog();

                // Retrieve the updated status report
                var updatedStatusDetails = statusForm.GetStatusDetails();

                // Save the updated status report details
                statusReports[roomID] = new StatusReportDetails
                {
                    StatusReport = updatedStatusDetails.StatusReport,
                    IsCleaned = updatedStatusDetails.IsCleaned,
                    IsDirty = updatedStatusDetails.IsDirty,
                    ReportIssues = updatedStatusDetails.ReportIssues
                };
            }
        }

        private void dataGridViewUpcomingPreparation_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Check if the clicked cell is in the "More Info" column
            if (e.RowIndex >= 0 && e.ColumnIndex == dataGridViewUpcomingPreparation.Columns["RoomAmenities"].Index)
            {
                try
                {
                    // Ensure that the selected row has data
                    //"Room_Number"
                    int roomNumIndex = 1; 
                    if (dataGridViewUpcomingPreparation.Rows[e.RowIndex].Cells[roomNumIndex].Value != null) 
                    {
                        DataGridViewRow selectedRow = dataGridViewUpcomingPreparation.Rows[e.RowIndex];
                        string roomId = selectedRow.Cells[roomNumIndex].Value.ToString();

                        using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["dbConnect"].ToString()))
                        {
                            string query = "SELECT Room_Type, beds, bathroom, Bathroom_Type, amenities FROM Room WHERE Room_Number = @Room_Number";
                            SqlCommand command = new SqlCommand(query, connection);
                            command.Parameters.AddWithValue("@Room_Number", roomId);
                            connection.Open();
                            SqlDataReader reader = command.ExecuteReader();

                            if (reader.Read())
                            {
                                string roomType = reader["Room_Type"].ToString();
                                string bed = reader["beds"].ToString();
                                string bathroom = reader["bathroom"].ToString();
                                string typeOfBathroom = reader["Bathroom_Type"].ToString();
                                string amenities = reader["amenities"].ToString();

                                RoomAmenitiesForm amenitiesForm = new RoomAmenitiesForm(roomType, bed, bathroom, typeOfBathroom, amenities);
                                amenitiesForm.Show();
                            }
                            reader.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("The selected row does not contain RoomID data.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred while opening the amenities form: {ex.Message}");
                }
            }
        }
        


        private DataTable GetDataTable(string query)
        {
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["dbConnect"].ToString()))
            {
                using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    return dataTable;
                }
            }
        }

        private void CleaningSchedule_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'upcomingPrepDataSet2.CleaningSchedule' table. You can move, or remove it, as needed.
            this.cleaningScheduleTableAdapter2.Fill(this.upcomingPrepDataSet2.CleaningSchedule);
            // TODO: This line of code loads data into the 'upcomingPrepDataSet.CleaningSchedule' table. You can move, or remove it, as needed.
            this.cleaningScheduleTableAdapter1.Fill(this.upcomingPrepDataSet.CleaningSchedule);
            // TODO: This line of code loads data into the 'cleaningScheduleDataSet.CleaningSchedule' table. You can move, or remove it, as needed.
            this.cleaningScheduleTableAdapter.Fill(this.cleaningScheduleDataSet.CleaningSchedule);

        }

    }
}
