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

namespace Hotel_Mgmt_Sys_IOOP_CSharp
{
    public partial class CustomerProfileFrm : Form
    {
        private DataTable _dataTable;
        private BindingSource _SBind;
        private DatabaseUtility dbUtil;

        private DataRowView _rowView;
        //private List<string> fieldsFilter;
        ////private string[] fieldsValue;
        ////private bool isCboFieldFilled = false;

        public DataTable dataTable { get { return _dataTable; } set { _dataTable = value; } }
        public DataRowView rowView { get { return _rowView; } set { _rowView = value; } }


        public CustomerProfileFrm()
        {
            InitializeComponent();
            //cboRole.Items.AddRange(new List<string> { "Manager", "Receptionist", "Housekeeper"} .ToArray() );          
        }

        public CustomerProfileFrm(string mode)
        {
            InitializeComponent();

            switch (mode.ToLower())
            {
                case "add": 
                    btnUpdateCustomer.Visible = false;
                    btnDeleteCustomer.Visible = false;

                    txtCustomerID.ReadOnly = false;
                    txtUsername.ReadOnly = true;
                    txtPassword.ReadOnly = true;
                    break;

                case "delete":
                    grpCustomerDetails.Visible = false;
                    grpGenerativeInfo.Visible = false;
                    btnAddCustomer.Visible = false;
                    btnUpdateCustomer.Visible = false;
                    break;

                case "update":
                    btnAddCustomer.Visible = false;
                    btnDeleteCustomer.Visible = false;

                    txtCustomerID.ReadOnly = true;
                    txtUsername.ReadOnly = false;
                    txtPassword.ReadOnly = false;
                    break;
            }
                    
        }


        public CustomerProfileFrm(DataRowView rowView, DataTable dt)
        {
            InitializeComponent();
            this.dataTable = dt;
            this.rowView = rowView;
        }


        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            string username;
            string password; 

            User obj0 = new User();
            obj0.generateUsername(txtLastName.Text, txtICNumber.Text, out username);
            obj0.generatePassword(txtLastName.Text, txtICNumber.Text, out password);
            obj0.addUser(username, txtEmail.Text, password, "Customer");
            obj0.getUserID(username, txtEmail.Text, obj0);

            Customer obj1 = new Customer(txtCustomerID.Text, obj0.userID, txtFirstName.Text, txtLastName.Text, txtJob.Text, txtICNumber.Text, txtEmail.Text, txtContactNumber.Text, txtResidentialAddress.Text);
            MessageBox.Show(obj1.addCustomer());

            lblUserID.Text = obj0.userID;
            txtUsername.Text = username;
            txtPassword.Text = password; 
        }

        private void btnUpdateCustomer_Click(object sender, EventArgs e)
        {

        }

        private void btnDeleteCustomer_Click(object sender, EventArgs e)
        {
            Customer obj1 = new Customer(txtCustomerID.Text);
            MessageBox.Show(obj1.deleteCustomer());
        }

        private void RetrieveAutoFillFrm_EditRowValues()
        {
            try
            {
                DataRow row = _rowView.Row;
                DatabaseUtility dBUtil = new DatabaseUtility("dBConnect");

                Dictionary<string, string> rowDictEmp = dBUtil.GetRowData("Employee", _dataTable.Columns[0].ColumnName, row[_dataTable.Columns[0].ColumnName].ToString());
                List<string> headerEmp = dBUtil.RetriveTableHeader("Employee");

                /*lblEmpNum.Text = rowDictEmp[headerEmp[0]];
                txtFirstName.Text = rowDictEmp[headerEmp[2]];
                txtLastName.Text = rowDictEmp[headerEmp[3]];
                dtpHireDate.Value = DateTime.Parse(rowDictEmp[headerEmp[4]]);
                cboRole.SelectedItem = rowDictEmp[headerEmp[5]];
                txtContactNumber.Text = rowDictEmp[headerEmp[6]]; ;
                txtICNumber.Text = rowDictEmp[headerEmp[7]]; ;
                txtAge.Text = rowDictEmp[headerEmp[8]]; ;

                //gender 
                if (rowDictEmp[headerEmp[9]].ToLower().Trim() == "male")
                    radMale.Enabled = true;
                else
                    radFemale.Enabled = false; 

                txtNationality.Text = rowDictEmp[headerEmp[10]]; 
                txtResidentialAddress.Text = rowDictEmp[headerEmp[11]]; ;

                Dictionary<string, string> rowDictUser = dBUtil.GetRowData("Users", "UserID", row[_dataTable.Columns[1].ColumnName].ToString());
                List<string> headerUser = dBUtil.RetriveTableHeader("Users");

                lblUserID.Text = rowDictUser[headerUser[1]];
                lblEmailDomain.Text = rowDictUser[headerUser[2]].Split('@')[0];*/
            }
            catch (Exception e)
            { 
            
            }
        }
    }
}
