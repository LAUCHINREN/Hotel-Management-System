using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace Hotel_Mgmt_Sys_IOOP_CSharp
{
    public partial class manageRoomFrm : Form
    {
        private DataTable _dataTable;
        private BindingSource _SBind; 
        private DatabaseUtility dbUtil;
        private List<string> fieldsFilter;
        private bool isCboFieldFilled = false; 

        //Room room = new Room();  
        public manageRoomFrm()
        {
            InitializeComponent();
            _dataTable = new DataTable();
            _SBind = new BindingSource(); 
            dgvManageRoom.DataSource = _dataTable;



            //DataGridView_HeaderSetup("Room", dgvManageRoom, out List<string> dgvHeaderRoom);
            //FetchData(dgvManageRoom, "Room", dataTable);

        }


        // ======================================= FORM - CORE FUNCTIONS ======================================= //
        // >>>>>>>>>> ADD ROOM - AddRoomFrm <<<<<<<<<< //
        private void btnAddRoom_Click(object sender, EventArgs e)
        {
            AddRoomFrm addRoomFrm = new AddRoomFrm(_dataTable);
            addRoomFrm.ShowDialog();

            dgvManageRoom.AutoGenerateColumns = false;
            dgvManageRoom.ReadOnly = true;
            _SBind.DataSource = _dataTable;
            dgvManageRoom.DataSource = _SBind;

            //var row = dataTable.Rows[1];
            //dataTable.Rows.Add(row.ItemArray.Clone() as object[]);
            //SBind.DataSource = dataTable;
            //dgvManageRoom.DataSource = SBind;
        }

        // >>>>>>>>>> EDIT + DELETE USER - DATAGRID BUTTON <<<<<<<<<< //
        private void dgvManageRoom_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                if (e.RowIndex >= 0 && dgvManageRoom.Columns[e.ColumnIndex].Name == "btnDeleteColumn")
                {
                    DialogResult result = MessageBox.Show("Are you sure you want to delete this data permanently?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {

                        DataRowView rowView = dgvManageRoom.Rows[e.RowIndex].DataBoundItem as DataRowView;

                        if (rowView != null)
                        {
                            DataRow row = rowView.Row;
                            string colName = _dataTable.Columns[0].ColumnName;
                            string roomNum = row[colName].ToString();
                            string roomType = row[_dataTable.Columns[2].ColumnName].ToString(); 

                            Room room = new Room();
                            int status = room.deleteRoom(roomNum);
                            if(status >= 0)
                                MessageBox.Show($"Room {roomNum} - {roomType} has been deleted successfully!\n", "SUCCESS - Delete Employee Records", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            else
                                MessageBox.Show($"Unable to delete room {roomNum} - {roomType}.\n", "ERROR - Delete User Account", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                        RefreshTable(dgvManageRoom, "Room", _dataTable);

                    }

                }
                else if (e.RowIndex >= 0 && dgvManageRoom.Columns[e.ColumnIndex].Name == "btnEditColumn")
                {
                    DataRowView rowView = dgvManageRoom.Rows[e.RowIndex].DataBoundItem as DataRowView;

                    if (rowView != null)
                    {
                        EditRoomFrm editRoomFrm = new EditRoomFrm(rowView, _dataTable);
                        editRoomFrm.ShowDialog();

                        dgvManageRoom.AutoGenerateColumns = false;
                        dgvManageRoom.ReadOnly = true;
                        _SBind.DataSource = _dataTable;
                        dgvManageRoom.DataSource = _SBind;

                        //if (rowDict.Count == header.Count)
                        //{
                        //    Room room = new Room(roomID,location, roomType, guest, beds, bathroom, bathroomType, amenities, pricePerNight);
                        //    room.editRoom();
                        //    dataTable.Rows.Remove(row);
                        //}
                    }

                }

            }
        }





        // ======================================= FORM - SIDE FUNCTIONS ======================================= //
        private void btnShowRooms_Click(object sender, EventArgs e)
        {
            RefreshTable(dgvManageRoom, "Room", _dataTable);
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            _dataTable.Clear();
            _SBind.DataSource = _dataTable;
            dgvManageRoom.DataSource = _SBind;
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            ////string searchKeywords = txtSearch.Text.Trim().ToLower();


            ////var filteredSupplies = room.Where(r => r)//ItemName.Contains(searchTerm)).ToList();
            ////dataGridViewSupplies.DataSource = filteredSupplies;

            //List<List<string>> dataRows = room.searchKeywords(txtSearch.Text); //var rooms =
            DataGridView_HeaderSetup("Room", dgvManageRoom, out List<string> dgvHeaderRoom);
            _dataTable.Clear();
            List<List<string>> dataRows = new List<List<string>>();
            for (int r = 0; r < dataRows.Count; r++)
            {
                DataRow row = _dataTable.NewRow();
                int indexData = 0;
                foreach (DataColumn col in _dataTable.Columns)
                {
                    row[col.ColumnName] = dataRows[r][indexData].ToString();
                    indexData++;
                }
                _dataTable.Rows.Add(row);
            }
            dgvManageRoom.AutoGenerateColumns = false;
            dgvManageRoom.ReadOnly = true;
            _SBind.DataSource = _dataTable;
            dgvManageRoom.DataSource = _SBind;

            for (int i = 0; i < dgvManageRoom.ColumnCount; ++i)
            {
                //dataTable.Columns.Add(new DataColumn(dgvUser.Columns[i].Name));
                dgvManageRoom.Columns[i].DataPropertyName = dgvManageRoom.Columns[i].Name;
            }
        }

        private void btnResetAllFields_Click(object sender, EventArgs e)
        {
            txtSearch.Text = String.Empty;
            cboField.SelectedItem = null;
            cboValue.SelectedItem = null;
        }

        private void cboField_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboField.SelectedItem != null)
            {
                string selectedField = cboField.SelectedItem.ToString();
                cboField.Text = selectedField;
            }
        }

        private void cboValue_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void cboField_DropDown(object sender, EventArgs e)
        {
            dbUtil = new DatabaseUtility("dbConnect");
            fieldsFilter = dbUtil.RetriveTableHeader("Room");

            cboField.Items.Clear();
            cboField.Items.AddRange(fieldsFilter.ToArray());
            if (!isCboFieldFilled)
            {

                isCboFieldFilled = true;
            }
        }
        private void cboValue_DropDown(object sender, EventArgs e)
        {
            if (cboField.SelectedItem != null)
            {
                string selectedField = cboField.SelectedItem.ToString();
                int rowCount = _dataTable.Columns.Count; //column = 9; rows = 0 

                //DataRow[] matchRow = dataTable.Select($@"{selectedField} = {}").ToArray();
                //matchRow

                //List<string> matchingRow = matchingRow.Select(row => row[])
                dbUtil = new DatabaseUtility("dbConnect");
                dbUtil.SqlCmdExecute($@"SELECT {selectedField} FROM Room", new Dictionary<string, string>(), DatabaseUtility.cmdExeWriteMode.NonQuery, out object result);
                List<List<string>> dataRows = dbUtil.SqlCmdReader();

                List<string> columnData = new List<string>();
                foreach (List<string> row in dataRows)
                {
                    foreach (string data in row)
                    {
                        columnData.Add(data);
                    }
                }

                cboValue.Items.Clear();
                cboValue.Items.AddRange(columnData.ToArray());
            }
            else { }

        }
        private void btnFilter_Click(object sender, EventArgs e)
        {

        }


        // ======================================= UTILITY FUNCTIONS ======================================= //
        private int DataGridView_HeaderSetup(string DbTableName, DataGridView dgvUser, out List<string> dgvHeader)
        {
            object cmdExeResult = null;
            List<List<string>> cmdReadResult = new List<List<string>>();
            dbUtil = new DatabaseUtility("dbConnect");
            dgvHeader = dbUtil.RetriveTableHeader(DbTableName);

            _dataTable.Clear();


            foreach (string columnName in dgvHeader)
            {
                if (!_dataTable.Columns.Contains(columnName))
                    _dataTable.Columns.Add(columnName);
            }
            dgvUser.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            _SBind.DataSource = _dataTable;

            dgvUser.DataSource = _SBind;

            // Create and add the button column
            DataGridViewButtonColumn btnEditColumn = new DataGridViewButtonColumn();
            btnEditColumn.Name = "btnEditColumn";
            btnEditColumn.HeaderText = "Edit";
            btnEditColumn.Text = "Edit";
            btnEditColumn.UseColumnTextForButtonValue = true;
            if (!dgvUser.Columns.Contains(btnEditColumn.Name = "btnEditColumn"))
                dgvUser.Columns.Add(btnEditColumn);

            DataGridViewButtonColumn btnDeleteColumn = new DataGridViewButtonColumn();
            btnDeleteColumn.Name = "btnDeleteColumn";
            btnDeleteColumn.HeaderText = "Delete";
            btnDeleteColumn.Text = "Delete";
            btnDeleteColumn.UseColumnTextForButtonValue = true;
            if (!dgvUser.Columns.Contains(btnDeleteColumn.Name = "btnDeleteColumn"))
                dgvUser.Columns.Add(btnDeleteColumn);

            return dgvUser.ColumnCount;
        }

        private void RefreshTable(DataGridView dgvCurrentForm, string dBName, DataTable datatable)
        {
            //Update DataTable and Refresh DataGrid 

            Room room = new Room();
            List<List<string>> dataRows = room.viewAllRooms();

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
            _SBind.DataSource = datatable;
            dgvCurrentForm.DataSource = _SBind;

            for (int i = 0; i < dgvCurrentForm.ColumnCount; ++i)
            {
                dgvCurrentForm.Columns[i].DataPropertyName = dgvCurrentForm.Columns[i].Name;
            }
        }
    }
}
