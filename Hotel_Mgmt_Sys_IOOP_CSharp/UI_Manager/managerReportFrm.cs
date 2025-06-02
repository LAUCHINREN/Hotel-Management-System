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
    public partial class managerReportFrm : Form
    {
        private DataTable _dataTable;
        private BindingSource _SBind;
        private DatabaseUtility dbUtil;
        private List<string> fieldsFilter;


        public managerReportFrm()
        {
            InitializeComponent();
            _dataTable = new DataTable();
            _SBind = new BindingSource();
            dgvRoomOccupancy.DataSource = _dataTable;
        }

        private void tabRating_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Walao");
            switch (tabReport.SelectedIndex)
            {
                case 0:
                    tabReportControls.SelectedIndex = 0;

                    pnlOccupancyControls.Show(); 
                    break;
                case 1:
                    tabReportControls.SelectedIndex = 1;

                    pnlOccupancyControls.Hide();
                    break;
                case 2:
                    tabReportControls.SelectedIndex = 2;

                    pnlOccupancyControls.Hide();
                    break;
            }
        }

        private void tabReport_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnGenerateReport_RoomOccupancy_Click(object sender, EventArgs e)
        {
            List<List<string>> dataRows = new List<List<string>>();
            List<string> colNameHide = new List<string>() { "guest", "beds", "bathroom","Bathroom_Type", "amenities" }; 

            Report reportOccupancy = new Report();
            reportOccupancy.viewAllRoomOccupancy(out dataRows);
            //RefreshTable(dataRows, dgvRoomOccupancy, "Room", _dataTable);
            RefreshTable_dgvSelectedCol(dataRows, colNameHide, dgvRoomOccupancy, "Room", _dataTable);

            //Room_Number, Venue, Room_Type,Price_Per_Night,Occupancy_Status


        }

        // ======================================= UTILITY FUNCTIONS ======================================= //
        private int DataGridView_HeaderSetup(string DbTableName, DataGridView dgvUser, out List<string> dgvHeader)
        {
            object cmdExeResult = null;
            List<List<string>> cmdReadResult = new List<List<string>>();
            dbUtil = new DatabaseUtility("dbConnect");
            dgvHeader = dbUtil.RetriveTableHeader(DbTableName);

            _dataTable.Clear();
            _dataTable.Columns.Clear();

            foreach (string columnName in dgvHeader)
            {
                if (!_dataTable.Columns.Contains(columnName))
                    _dataTable.Columns.Add(columnName);
            }
            dgvUser.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            _SBind.DataSource = _dataTable;

            dgvUser.DataSource = _SBind;

            return dgvUser.ColumnCount;
        }

        private void RefreshTable(List<List<string>> dataRows, DataGridView dgvCurrentForm, string dBName, DataTable datatable)
        {
            //Update DataTable and Refresh DataGrid 

            /*            Employee emp = new Employee();
                        List<List<string>> dataRows = emp.viewAllEmployees();*/
            //dgvCurrentForm.Columns.Clear();
            //dgvCurrentForm.Rows.Clear(); 
            DataGridView_HeaderSetup(dBName, dgvCurrentForm, out fieldsFilter);
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
            //_SBind.DataSource = null; 
            _SBind.DataSource = datatable;
            dgvCurrentForm.DataSource = _SBind;

            for (int i = 0; i < dgvCurrentForm.ColumnCount; ++i)
            {
                dgvCurrentForm.Columns[i].DataPropertyName = dgvCurrentForm.Columns[i].Name;
            }
        }

        private void RefreshTable_dgvSelectedCol(List<List<string>> dataRows, List<string> dgvHideCol, DataGridView dgvCurrentForm, string dBName, DataTable datatable)
        {
            DataGridView_HeaderSetup(dBName, dgvCurrentForm, out fieldsFilter);
            datatable.Clear(); //only clear rows
            //datatable.Columns.Clear(); //only clear datatable columns 

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

            foreach (string colNameHide in dgvHideCol)
            {
                dgvCurrentForm.Columns[colNameHide].Visible = false;
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

        private void btnGenerateReport_Ratings_Click(object sender, EventArgs e)
        {
            List<List<string>> dataRows = new List<List<string>>();
            List<string> colNameHide = new List<string>() { "CheckInDate", "Clean_Status", "Additional_Requests", "TotalPrice", "FinalBill" };

            Report reportReservation = new Report();
            reportReservation.viewAllRatings(out dataRows);
            RefreshTable_dgvSelectedCol(dataRows, colNameHide, dgvReviews, "Reservation", _dataTable);
        }
    }
}
