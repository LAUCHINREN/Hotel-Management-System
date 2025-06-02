using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Windows.Forms;

namespace Hotel_Mgmt_Sys_IOOP_CSharp
{
    internal class Employee
    {
        private DatabaseUtility dbUtil;

        private string _employeeID;
        private string _userID;
        private string _firstName;
        private string _lastName;
        private string _hireDate;
        private string _position;
        private string _contactNum;
        private string _ICNum;
        private string _age;
        private string _gender;
        private string _nationality;
        private string _residentialAdd;
        public string employeeID { get { return _employeeID; } set { _employeeID = value; } }
        public string userID { get { return _userID; } set { _userID = value; } }
        public string firstName { get { return _firstName; } set { _firstName = value; } }
        public string lastName { get { return _lastName; } set { _lastName = value; } }
        public string hireDate { get { return _hireDate; } set { _hireDate = value; } }
        public string position { get { return _position; } set { _position = value; } }
        public string contactNum { get { return _contactNum; } set { _contactNum = value; } }
        public string age { get { return _age; } set { _age = value; } }
        public string gender { get { return _gender; } set { _gender = value; } }
        public string nationality { get { return _nationality; } set { _nationality = value; } }
        public string residentialAdd { get { return _residentialAdd; } set { _residentialAdd = value; } }


        public Employee()
        { 
            
        }

        public Employee(string employeeID, string userID, string firstName, string lastName, string hireDate, string position, string contactNum, string ICNum, string age, string gender, string nationality, string resAdd)
        {
            _employeeID = employeeID;
            _userID = userID;
            _firstName = firstName;
            _lastName = lastName;
            _hireDate = hireDate;
            _position = position;
            _contactNum = contactNum;
            _ICNum = ICNum;
            _age = age;
            _gender = gender;
            _nationality = nationality;
            _residentialAdd = resAdd;
        }

        public int addEmployee()
        {
            int status = 0;
            try
            {
                string tableQuery = "Employee";
                dbUtil = new DatabaseUtility("dbConnect");
                string QuerySQL = $@"INSERT INTO [{tableQuery}] (EmployeeID, userID, First_Name, Last_Name, Hire_Date, Position, Contact_Num, IC_Num, Age, Gender, Nationality, Residential_Address) 
                                VALUES(@EmployeeID, @userID, @First_Name, @Last_Name, @Hire_Date, @Position, @Contact_Num, @IC_Num, @Age, @Gender, @Nationality, @Residential_Address)";

                List<string> tableHeader = dbUtil.RetriveTableHeader(tableQuery);
                Dictionary<string, string> cmdParams = new Dictionary<string, string>()
                {
                    { "@EmployeeID", _employeeID.ToString() },
                    { "@userID", _userID},
                    { "@First_Name", _firstName },
                    { "@Last_Name", _lastName},
                    { "@Hire_Date", _hireDate },
                    { "@Position", _position},
                    { "@Contact_Num", _contactNum },
                    { "@IC_Num", _ICNum },
                    { "@Age", _age.ToString()},
                    { "@Gender", _gender},
                    { "@Nationality", _nationality},
                    { "@Residential_Address", _residentialAdd},

                };

                status = dbUtil.SqlCmdExecute(QuerySQL, cmdParams, DatabaseUtility.cmdExeWriteMode.NonQuery, out object result);
                dbUtil.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                status = -1;
            }

            return status;
        }

        public int editEmployee()
        {
            int status = 0;
            try
            {
                string tableQuery = "Employee";
                dbUtil = new DatabaseUtility("dbConnect");
                string QuerySQL = $@"UPDATE [{tableQuery}] SET 
                                        userID = @userID,
                                        First_Name = @First_Name,
                                        Last_Name = @Last_Name,
                                        Hire_Date = @Hire_Date,
                                        Position = @Position,
                                        Contact_Num = @Contact_Num,
                                        IC_Num = @IC_Num,
                                        Age = @Age,
                                        Gender = @Gender,
                                        Nationality = @Nationality,
                                        Residential_Address = @Residential_Address
                                    WHERE EmployeeID = @EmployeeID";

                Dictionary<string, string> cmdParams = new Dictionary<string, string>()
                {
                    { "@EmployeeID", _employeeID },
                    { "@userID", _userID },
                    { "@First_Name", _firstName },
                    { "@Last_Name", _lastName },
                    { "@Hire_Date", _hireDate },
                    { "@Position", _position },
                    { "@Contact_Num", _contactNum },
                    { "@IC_Num", _ICNum },
                    { "@Age", _age },
                    { "@Gender", _gender },
                    { "@Nationality", _nationality },
                    { "@Residential_Address", _residentialAdd }
                };

                status = dbUtil.SqlCmdExecute(QuerySQL, cmdParams, DatabaseUtility.cmdExeWriteMode.NonQuery, out object result);
                dbUtil.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                status = -1;
            }

            return status;
        }

        // Delete an employee from the database
        public int deleteEmployee(string employeeID)
        {
            int status = 0;
            try
            {
                string tableQuery = "Employee";
                dbUtil = new DatabaseUtility("dbConnect");
                string QuerySQL = $@"DELETE FROM [{tableQuery}] WHERE EmployeeID = @EmployeeID";

                Dictionary<string, string> cmdParams = new Dictionary<string, string>()
                {
                    { "@EmployeeID", employeeID }
                };

                status = dbUtil.SqlCmdExecute(QuerySQL, cmdParams, DatabaseUtility.cmdExeWriteMode.NonQuery, out object result);
                dbUtil.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                status = -1;
            }

            return status;
        }

        // View all employees
        public List<List<string>> viewAllEmployees()
        {
            List<List<string>> allEmployees = new List<List<string>>();
            try
            {
                string tableQuery = "Employee";
                dbUtil = new DatabaseUtility("dbConnect");
                string QuerySQL = $@"SELECT * FROM [{tableQuery}]";

                dbUtil.SqlCmdExecute(QuerySQL, new Dictionary<string, string>(), DatabaseUtility.cmdExeWriteMode.NonQuery, out object result);
                allEmployees = dbUtil.SqlCmdReader();
                dbUtil.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

            return allEmployees;
        }

        public int getEmployeeID(string fullNameAssignee, string position, out string employeeID)
        {
            int status = 0;
            object empID = null;
            employeeID = "";

            try
            {
                string tableQuery = "Employee";
                dbUtil = new DatabaseUtility("dbConnect");
                string QuerySQL = $@"SELECT EmployeeID FROM [{tableQuery}] WHERE CONCAT(First_Name, ' ', Last_Name) = @name AND Position = @position;";

                dbUtil.SqlCmdExecute(QuerySQL, new Dictionary<string, string>() { { "@name", fullNameAssignee }, { "@position", position } }, DatabaseUtility.cmdExeWriteMode.Scalar, out empID);
                dbUtil.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            employeeID = empID.ToString(); 
            return status;
        }

        // Search employees by keywords
        public List<List<string>> searchEmployees(string searchTerm = "")
        {
            List<List<string>> searchResults = new List<List<string>>();
            try
            {
                string tableQuery = "Employee";
                string searchPattern = $"%{searchTerm.Trim()}%";
                dbUtil = new DatabaseUtility("dbConnect");
                string QuerySQL = $@"SELECT * FROM [{tableQuery}]
                                     WHERE EmployeeID LIKE @Search OR
                                           userID LIKE @Search OR
                                           First_Name LIKE @Search OR
                                           Last_Name LIKE @Search OR
                                           Hire_Date LIKE @Search OR
                                           Position LIKE @Search OR
                                           Contact_Num LIKE @Search OR
                                           IC_Num LIKE @Search OR
                                           Age LIKE @Search OR
                                           Gender LIKE @Search OR
                                           Nationality LIKE @Search OR
                                           Residential_Address LIKE @Search";

                Dictionary<string, string> cmdParams = new Dictionary<string, string>()
                {
                    { "@Search", searchPattern }
                };

                dbUtil.SqlCmdExecute(QuerySQL, cmdParams, DatabaseUtility.cmdExeWriteMode.NonQuery, out object result);
                searchResults = dbUtil.SqlCmdReader();
                dbUtil.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

            return searchResults;
        }


        public int generateEmpID(out string EmpID)
        {
            int status = 0;
            EmpID = ""; 

            try
            {
                string tableQuery = "Employee";
                dbUtil = new DatabaseUtility("dbConnect");
                string QuerySQL = $@"SELECT TOP 1 * FROM [{tableQuery}] ORDER BY EmployeeID DESC";
                status = dbUtil.SqlCmdExecute(QuerySQL, new Dictionary<string, string>(), DatabaseUtility.cmdExeWriteMode.NonQuery, out object result);
                List<List<string>> lastEmpID = dbUtil.SqlCmdReader();

                int EmpID_int = -1;
                if (lastEmpID.Count <= 0)
                {
                    EmpID_int = 1;
                }
                else
                {
                    string EmpID_str_temp = lastEmpID[0][0].ToLower().Replace("e", "");
                    EmpID_int = int.Parse(EmpID_str_temp);

                    EmpID_int += 1;

                }

                EmpID = "E" + string.Format("{0:000}", EmpID_int);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                status = -1;
            }

            return status; 
        }
    }
}
