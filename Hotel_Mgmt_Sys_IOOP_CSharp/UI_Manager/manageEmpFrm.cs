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

namespace Hotel_Mgmt_Sys_IOOP_CSharp
{
    public partial class manageEmpFrm : Form
    {
        private DataTable _dataTable;
        private BindingSource _SBind;
        private DatabaseUtility dbUtil;
        private List<string> fieldsFilter;

        public manageEmpFrm()
        {
            InitializeComponent();
            _dataTable = new DataTable();
            _SBind = new BindingSource(); 
            dgvEmployee.DataSource = _dataTable;

            List<string> TableHeaderNames = new List<string>();
            //DataGridView_HeaderSetup("Employee", dgvUser, out TableHeaderNames);
            //DataGridView_ViewAll(TableHeaderNames);
        }



        // ======================================= FORM - CORE FUNCTIONS ======================================= //
        // >>>>>>>>>> ADD USER - EMPLOYEE PROFILE FORM <<<<<<<<<< //
        private void btnAddEmp_Click(object sender, EventArgs e)
        {
            EmpProfileFrm addEmpFrm = new EmpProfileFrm();
            addEmpFrm.ShowDialog();
        }

        // >>>>>>>>>> DELETE USER - DATAGRID BUTTON <<<<<<<<<< //
        private void dgvUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                if (e.RowIndex >= 0 && dgvEmployee.Columns[e.ColumnIndex].Name == "btnDeleteColumn")
                {
                    DialogResult result = MessageBox.Show("Are you sure you want to delete this data permanently?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        DataRowView rowView = dgvEmployee.Rows[e.RowIndex].DataBoundItem as DataRowView;

                        if (rowView != null)
                        {
                            DataRow row = rowView.Row;
                            string colName = _dataTable.Columns[0].ColumnName;

                            string empID = row[colName].ToString();
                            string firstName = row[_dataTable.Columns[2].ColumnName].ToString();
                            string lastName = row[_dataTable.Columns[3].ColumnName].ToString();

                            Employee employeeToDel = new Employee();
                            int status = employeeToDel.deleteEmployee(empID);
                            if (status >= 0)
                            {
                                MessageBox.Show($"Employee {empID} - {firstName} {lastName} has been deleted successfully!\n", "SUCCESS - Delete Employee Records", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                colName = _dataTable.Columns[1].ColumnName;
                                string userID = row[colName].ToString();

                                User user = new User();
                                status = user.deleteUser(userID);
                                if (status >= 0)
                                    MessageBox.Show("User deleted successfully!\n", "SUCCESS - Delete User Account", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                else
                                    MessageBox.Show("Unable to delete user.\n", "ERROR - Delete User Account", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            }

                            RefreshTable(dgvEmployee, "Employee", _dataTable);
                            //dataTable.Rows.Remove(row);
                        }

                        /*                        SBind.DataSource = dataTable;
                                                dgvEmployee.DataSource = SBind;*/
                    }

                }
                else if (e.RowIndex >= 0 && dgvEmployee.Columns[e.ColumnIndex].Name == "btnEditColumn")
                {
                    DataRowView rowView = dgvEmployee.Rows[e.RowIndex].DataBoundItem as DataRowView;

                    if (rowView != null)
                    {
                        //EmpProfileFrm editEmpFrm = new EmpProfileFrm(rowView, _dataTable);
                        //editEmpFrm.ShowDialog(); 
                    }
                }
            }
        }


        // ======================================= FORM - SIDE FUNCTIONS ======================================= //
        private void btnLoadEmp_Click(object sender, EventArgs e)
        {
            RefreshTable(dgvEmployee, "Employee", _dataTable);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            _dataTable.Clear();
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
            /*DataGridViewButtonColumn btnEditColumn = new DataGridViewButtonColumn();
            btnEditColumn.Name = "btnEditColumn";
            btnEditColumn.HeaderText = "Edit";
            btnEditColumn.Text = "Edit";
            btnEditColumn.UseColumnTextForButtonValue = true;
            if (!dgvUser.Columns.Contains(btnEditColumn.Name = "btnEditColumn"))
                dgvUser.Columns.Add(btnEditColumn);*/

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

            Employee emp = new Employee(); 
            List<List<string>> dataRows = emp.viewAllEmployees();

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
