using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Windows.Forms;
using System.Configuration;
using System.Runtime.InteropServices.WindowsRuntime;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Data;

namespace Hotel_Mgmt_Sys_IOOP_CSharp
{
    internal class User
    {
        DatabaseUtility dbUtil; 
        private string _username;
        private string _password;
        private string _userID; 

        public string userID { get { return _userID; } set { _userID = value; } }

        public User()
        { 
        }

        public User(string username, string password)
        {
            _username = username;
            _password = password; 
        }

        public void login(Form userLoginForm)
        {
            string status = null; 
            if (string.IsNullOrEmpty(_username) || string.IsNullOrEmpty(_password))
            {
                MessageBox.Show("Please enter both username and password.");
            }

            try
            {
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["dbConnect"].ToString()))
                {
                    connection.Open();
                    string query = "SELECT Role FROM Users WHERE Username = @Username AND Password = @Password";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Username", _username);
                        command.Parameters.AddWithValue("@Password", _password);

                        object result = command.ExecuteScalar();
                        if (result != null)
                        {
                            string role = result.ToString();
                            Form targetForm = RedirectUser(role);
                            if (targetForm != null)
                            {
                                userLoginForm.Hide();  // Hide the login form
                                targetForm.FormClosed += (s, args) => userLoginForm.Show();  // Show the login form again after the target form is closed
                                targetForm.Show();  // Show the target form
                            }
                        }
                        else
                        {
                            MessageBox.Show("Invalid username or email.");
                        }
                    }                  
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }
        public int deleteUser(string userID)
        {
            int status = 0;

            string tableQuery = "Users";
            dbUtil = new DatabaseUtility("dbConnect");
            string QuerySQL = $@"DELETE FROM [{tableQuery}] 
                            WHERE UserID = @UserID";
            status = dbUtil.SqlCmdExecute(QuerySQL, new Dictionary<string, string>() { { "@UserID", userID.ToString() } }, DatabaseUtility.cmdExeWriteMode.NonQuery, out object result);
            dbUtil.Close();
            return status;
        }

        public int addUser(string username, string email, string password, string role)
        {
            int status = 0;
            string tableQuery = "Users";
            dbUtil = new DatabaseUtility("dbConnect");
            string QuerySQL = $@"INSERT INTO [{tableQuery}] (Username, Email, Password, Role) 
                                VALUES(@Username, @Email, @Password, @Role)";

            List<string> tableHeader = dbUtil.RetriveTableHeader(tableQuery);
            Dictionary<string, string> cmdParams = new Dictionary<string, string>()
            {
                { "@Username", username},
                { "@Email", email },
                { "@Password", password},
                { "@Role", role }
            };

            status = dbUtil.SqlCmdExecute(QuerySQL, cmdParams, DatabaseUtility.cmdExeWriteMode.NonQuery, out object result);
            dbUtil.Close();

            return status;
        }

        public int editUser()
        {
            return 0; 
        }

        private Form RedirectUser(string role)
        {
            Form targetForm = null; 
            switch (role)
            {
                case "Manager":
                    targetForm = new ManagerHomePage();
                    break;
                case "Receptionist":
                    targetForm = new ReceptionistHomePage();
                    break;
                case "Housekeeper":
                    targetForm = new HousekeeperHomePage();
                    break;
                case "Customer":
                    Customer cust = new Customer();
                    targetForm = new CustomerHomePage("");
                    break;
                default:
                    MessageBox.Show("Unknown user role.");
                    break; 
            }
            return targetForm; 
        }

        public int generateUsername(string lastName, string ICNum, out string username)
        {
            int status = 0;
            username = "";

            try
            {
                string ln = lastName.ToLower().Trim().Replace(" ", "");
                string num = ICNum.Substring(2, 4);
                username = ln + num; 
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                status = -1;
            }

            return status;
        }

        public int generatePassword(string lastName, string ICNum, out string password)
        {
            int status = 0;
            password = "";

            try
            {
                string ln = lastName.ToLower().Trim().Replace(" ", "");
                string num = ICNum.Substring(0, 6);
                password = ln + num;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                status = -1;
            }

            return status;
        }

        public int getUserID(string username, string email, User user)
        {
            int status = 0;

            string tableQuery = "Users";
            dbUtil = new DatabaseUtility("dbConnect");
            string QuerySQL = $@"SELECT UserID FROM [{tableQuery}] WHERE Username = @Username AND Email = @Email";

            List<string> tableHeader = dbUtil.RetriveTableHeader(tableQuery);
            Dictionary<string, string> cmdParams = new Dictionary<string, string>()
            {
                { "@Username", username},
                { "@Email", email }
            };

            status = dbUtil.SqlCmdExecute(QuerySQL, cmdParams, DatabaseUtility.cmdExeWriteMode.Scalar, out object resultObj);
            dbUtil.Close();

            user.userID = resultObj.ToString(); 

            return status;
        }

    }
}
