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
    public partial class EmpProfileFrm : Form
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


        public EmpProfileFrm()
        {
            InitializeComponent();
            cboRole.Items.AddRange(new List<string> { "Manager", "Receptionist", "Housekeeper"} .ToArray() );          
        }

        public EmpProfileFrm(DataRowView rowView, DataTable dt)
        {
            InitializeComponent();
            cboRole.Items.AddRange(new List<string> { "Manager", "Receptionist", "Housekeeper" }.ToArray());
            this.dataTable = dt;
            this.rowView = rowView;
        }


        private void btnAddEmp_Click(object sender, EventArgs e)
        {
            //Validation 
            string employeeID = "";
            string username = "";
            string email = ""; 
            string userID = "";
            string gender = "";
            string password = ""; 
            
            //Adding User Table 
            Employee empObj = new Employee();
            empObj.generateEmpID(out employeeID);


            if (!string.IsNullOrEmpty(txtLastName.Text) && !string.IsNullOrEmpty(txtICNum.Text) && cboRole.SelectedItem != null)
            {
                User userObj = new User();
                userObj.generateUsername(txtLastName.Text, txtICNum.Text, out username);
                userObj.generatePassword(txtLastName.Text, txtICNum.Text, out password);
                email = username + lblEmailDomain.Text;
                userObj.addUser(username, email, password, cboRole.SelectedItem.ToString());
            }


            //Adding Employee Table 
            if (radMale.Enabled || radFemale.Enabled)
            {
                if (radMale.Enabled == true)
                    gender = "Male";
                else
                    gender = "Female"; 
            }

            User newUser = new User();
            newUser.getUserID(username, email, newUser);
            userID = newUser.userID; 

            Employee emp = new Employee(
                employeeID,
                userID,
                txtFirstName.Text, 
                txtLastName.Text, 
                dtpHireDate.Value.ToShortDateString(),
                cboRole.SelectedItem.ToString(),
                txtContact.Text, 
                txtICNum.Text, 
                txtAge.Text, 
                gender, 
                txtNationality.Text, 
                txtResAddr.Text
            );

            emp.addEmployee();

            newUser.addUser(username, email, password, emp.position); 
        }

        private void btnEditEmp_Click(object sender, EventArgs e)
        {

        }

        private void RetrieveAutoFillFrm_EditRowValues()
        {
            try
            {
                DataRow row = _rowView.Row;
                DatabaseUtility dBUtil = new DatabaseUtility("dBConnect");

                Dictionary<string, string> rowDictEmp = dBUtil.GetRowData("Employee", _dataTable.Columns[0].ColumnName, row[_dataTable.Columns[0].ColumnName].ToString());
                List<string> headerEmp = dBUtil.RetriveTableHeader("Employee");

                lblEmpNum.Text = rowDictEmp[headerEmp[0]];
                txtFirstName.Text = rowDictEmp[headerEmp[2]];
                txtLastName.Text = rowDictEmp[headerEmp[3]];
                dtpHireDate.Value = DateTime.Parse(rowDictEmp[headerEmp[4]]);
                cboRole.SelectedItem = rowDictEmp[headerEmp[5]];
                txtContact.Text = rowDictEmp[headerEmp[6]]; ;
                txtICNum.Text = rowDictEmp[headerEmp[7]]; ;
                txtAge.Text = rowDictEmp[headerEmp[8]]; ;

                //gender 
                if (rowDictEmp[headerEmp[9]].ToLower().Trim() == "male")
                    radMale.Enabled = true;
                else
                    radFemale.Enabled = false; 

                txtNationality.Text = rowDictEmp[headerEmp[10]]; 
                txtResAddr.Text = rowDictEmp[headerEmp[11]]; ;

                Dictionary<string, string> rowDictUser = dBUtil.GetRowData("Users", "UserID", row[_dataTable.Columns[1].ColumnName].ToString());
                List<string> headerUser = dBUtil.RetriveTableHeader("Users");

                lblUsername.Text = rowDictUser[headerUser[1]];
                lblEmailDomain.Text = rowDictUser[headerUser[2]].Split('@')[0];
            }
            catch (Exception e)
            { 
            
            }




            /*            txtRoomID.Text = rowDict[header[0]];
                        nudLevel.Value = decimal.Parse(rowDict[header[1]].Split('|')[0].Replace("Level", ""));
                        nudRoom.Value = decimal.Parse(rowDict[header[1]].Split('|')[1].Replace("Room", ""));
                        cboRoomType.SelectedItem = rowDict[header[2]];
                        nudGuest.Value = decimal.Parse(rowDict[header[3]]);
                        nudBeds.Value = decimal.Parse(rowDict[header[4]].Split(' ')[0]);
                        string[] bedStrs = rowDict[header[4]].Split(' ');
                        string bedType = "";
                        for (int i = 0; i < bedStrs.Length; i++)
                        {
                            if (i == 0)
                                continue;
                            else
                            {
                                bedType += bedStrs[i];
                                bedType += " ";
                            }
                        }
                        cboBedType.SelectedItem = bedType.TrimStart().TrimEnd();
                        nudBathroom.Value = decimal.Parse(rowDict[header[5]]);

                        if (rowDict[header[6]].ToLower() == "bathtub")
                            radBathtub.Checked = true;
                        else
                            radStandingShower.Checked = true;
                        string[] stringSeparators = new string[] { "sets" };
                        nudAmenities.Value = decimal.Parse(rowDict[header[7]].Split('\n')[0].Split(stringSeparators, StringSplitOptions.None)[0]);
                        txtAmenities.Text = rowDict[header[7]].Split('\n')[1];
                        txtPrice.Text = rowDict[header[8]];*/
        }

        private void EmpProfileFrm_Load(object sender, EventArgs e)
        {

        }
    }
}
