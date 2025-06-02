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
    public partial class manageCleaningScheduleFrm : Form
    {
        DatabaseUtility dbUtil;
        private DataTable _dataTable;
        private BindingSource _SBind;
        private List<string> dgVHeader_CleaningSchedule; 

        public manageCleaningScheduleFrm()
        {
            InitializeComponent();
            _dataTable = new DataTable();
            _SBind = new BindingSource(); 
            DataGridView_HeaderSetup("CleaningSchedule", dgvCleaningSchedule, out dgVHeader_CleaningSchedule); 
        }

        private void calSchedule_DateChanged(object sender, DateRangeEventArgs e)
        {
            txtDateRange.Text = $"{calSchedule.SelectionRange.Start.ToShortDateString()} - {calSchedule.SelectionRange.End.ToShortDateString()}";
            TimeSpan duration = calSchedule.SelectionRange.End - calSchedule.SelectionRange.Start;
            txtDuration.Text = $"{duration.TotalDays.ToString()} Days"; 
            //txtStartDate.Text = calSchedule.SelectionStart.ToShortDateString();
        }

        private void cboRoomToClean_DropDown(object sender, EventArgs e)
        {
            dbUtil = new DatabaseUtility("dbConnect");
            List<string> reservedRooms = dbUtil.GetColumnData("Room_Number", "Reservation");
            dbUtil.Close(); 
            cboRoomToClean.Items.Clear();
            cboRoomToClean.Items.AddRange(reservedRooms.ToArray());
        }

        private void cboRoomToClean_SelectedIndexChanged(object sender, EventArgs e)
        {
            dbUtil = new DatabaseUtility("dbConnect");
            string queryLoadDates = @"SELECT CheckInDate AS Date FROM Reservation 
                                    UNION 
                                    SELECT CheckOutDate AS Date FROM Reservation  
                                    WHERE Room_Number=@Room_Number";
            string reservedRoom = cboRoomToClean.SelectedItem.ToString();
            dbUtil.SqlCmdExecute(queryLoadDates, new Dictionary<string, string> { { "@Room_Number", reservedRoom } }, DatabaseUtility.cmdExeWriteMode.NonQuery, out object resultScalar);
            List<List<string>> results = dbUtil.SqlCmdReader();


            List<string> housekeepingDates = new List<string>();
            foreach (List<string> row in results)
            {
                DateTime date = DateTime.Parse(row[0]);
                housekeepingDates.Add(date.ToShortDateString());
            }
            lstDates.Items.Clear();
            lstDates.Items.AddRange(housekeepingDates.ToArray());


            string queryLoadHousekeepers = @"SELECT CONCAT(First_Name, ' ', Last_Name) AS FullName FROM Employee 
                                            WHERE Position=@position";
            dbUtil.SqlCmdExecute(queryLoadHousekeepers, new Dictionary<string, string> { { "@position", "Housekeeper" } }, DatabaseUtility.cmdExeWriteMode.NonQuery, out object resyltScalar);
            List<List<string>> results_hk = dbUtil.SqlCmdReader();

            List<string> housekeepers = new List<string>();
            foreach (List<string> row in results_hk)
            {
                housekeepers.Add(row[0]);
            }
            lstAssignee.Items.Clear();
            lstAssignee.Items.AddRange(housekeepers.ToArray());
            dbUtil.Close();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            
        }

        private void btnAddSchedule_Click(object sender, EventArgs e)
        {
            //DateTime.Parse(lstDates.SelectedItem.ToString()).ToShortDateString(); 


            if (lstDates.SelectedItem != null && lstAssignee.SelectedItem!= null)
            {
                

                lstDates.SelectedItem.ToString();
                lstAssignee.SelectedItem.ToString();
                cboRoomToClean.SelectedItem.ToString();

                CleaningSchedule newSchedule = new CleaningSchedule(cboRoomToClean.SelectedItem.ToString(), lstDates.SelectedItem.ToString());
                newSchedule.addSchedule(lstAssignee.SelectedItem.ToString());

                List<List<string>> dataRows;
                int status = newSchedule.viewAllSchedule(out dataRows);
                RefreshTable(dataRows, dgvCleaningSchedule, "CleaningSchedule", _dataTable);
            }


        }

        private void dgvCleaningSchedule_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                if (e.RowIndex >= 0 && dgvCleaningSchedule.Columns[e.ColumnIndex].Name == "btnDeleteColumn")
                {
                    DialogResult result = MessageBox.Show("Are you sure you want to delete this data permanently?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {

                        DataRowView rowView = dgvCleaningSchedule.Rows[e.RowIndex].DataBoundItem as DataRowView;
                        int status = 0; 

                        if (rowView != null)
                        {
                            DataRow row = rowView.Row;
                            string colName = _dataTable.Columns[0].ColumnName;
                            string scheduleID = row[colName].ToString();
                            /*string room_number = row[colName].ToString();
                            string scheduleID = row[colName].ToString();*/

                            CleaningSchedule schedule = new CleaningSchedule();
                            status = schedule.deleteSchedule(scheduleID);
                            if (status >= 0)
                                MessageBox.Show($"Schedule {scheduleID} - has been deleted successfully!\n", "SUCCESS - Delete Employee Records", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            else
                                MessageBox.Show($"Unable to delete schedule {scheduleID}.\n", "ERROR - Delete User Account", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                        List<List<string>> dataRows;
                        CleaningSchedule Schedule = new CleaningSchedule();
                        status = Schedule.viewAllSchedule(out dataRows);
                        RefreshTable(dataRows, dgvCleaningSchedule, "CleaningSchedule", _dataTable);
                        

                    }

                }
            }
        }

        private void btnShowSchedule_Click(object sender, EventArgs e)
        {
            List<List<string>> dataRows; 

            CleaningSchedule schedule = new CleaningSchedule();
            int status = schedule.viewAllSchedule(out dataRows);

            RefreshTable(dataRows, dgvCleaningSchedule, "CleaningSchedule", _dataTable);
        }

        private void btnClearSchedule_Click(object sender, EventArgs e)
        {
            _dataTable.Clear(); 

            dgvCleaningSchedule.AutoGenerateColumns = false;
            dgvCleaningSchedule.ReadOnly = true;
            _SBind.DataSource = _dataTable;
            dgvCleaningSchedule.DataSource = _SBind;
        }

        // ======================================= UTILITY FUNCTIONS ======================================= //
        private int DataGridView_HeaderSetup(string DbTableName, DataGridView dgvUser, out List<string> dgvHeader)
        {
            object cmdExeResult = null;
            List<List<string>> cmdReadResult = new List<List<string>>();
            dbUtil = new DatabaseUtility("dbConnect");
            dgvHeader = dbUtil.RetriveTableHeader(DbTableName);

            _dataTable.Clear();
            //_dataTable.Columns.Clear(); //Tricky 

            //DataGridViewButtonColumn btnDeleteColumn = new DataGridViewButtonColumn();
            //if (dgvUser.Columns.Contains(btnDeleteColumn.Name = "btnDeleteColumn"))
            //    dgvUser.Columns.Remove(btnDeleteColumn);

            foreach (string columnName in dgvHeader)
            {
                if (!_dataTable.Columns.Contains(columnName))
                    _dataTable.Columns.Add(columnName);
            }
            dgvUser.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            _SBind.DataSource = _dataTable;

            dgvUser.DataSource = _SBind;

            DataGridViewButtonColumn btnDeleteColumn = new DataGridViewButtonColumn();
            btnDeleteColumn.Name = "btnDeleteColumn";
            btnDeleteColumn.HeaderText = "Delete";
            btnDeleteColumn.Text = "Delete";
            btnDeleteColumn.UseColumnTextForButtonValue = true;
            if (!dgvUser.Columns.Contains(btnDeleteColumn.Name = "btnDeleteColumn"))
                dgvUser.Columns.Add(btnDeleteColumn);

            return dgvUser.ColumnCount;
        }

        private void RefreshTable(List<List<string>> dataRows, DataGridView dgvCurrentForm, string dBName, DataTable datatable)
        {
            //Update DataTable and Refresh DataGrid 

/*            Employee emp = new Employee();
            List<List<string>> dataRows = emp.viewAllEmployees();*/

            DataGridView_HeaderSetup(dBName, dgvCurrentForm, out dgVHeader_CleaningSchedule);
            datatable.Clear();

            for (int r = 0; r < dataRows.Count; r++)
            {
                DataRow row = datatable.NewRow();
                int indexData = 0;
                foreach (DataColumn col in datatable.Columns)
                {
                    row[col.ColumnName] = dataRows[r][indexData].ToString();
                    indexData++;
                }
                datatable.Rows.Add(row);
            }
            dgvCurrentForm.AutoGenerateColumns = false;
            dgvCurrentForm.ReadOnly = true;
            _SBind.DataSource = datatable;
            dgvCurrentForm.DataSource = _SBind;

            for (int i = 0; i < dgvCurrentForm.ColumnCount; ++i)
            {
                dgvCurrentForm.Columns[i].DataPropertyName = dgvCurrentForm.Columns[i].Name;
            }
        }

    }
}
