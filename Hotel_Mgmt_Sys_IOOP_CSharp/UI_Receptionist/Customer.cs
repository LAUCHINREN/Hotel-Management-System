using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Hotel_Mgmt_Sys_IOOP_CSharp
{
    internal class Customer
    {
        private string CustomerID;
        private string UserID;
        private string FirstName;
        private string LastName;
        private string ICNumber;
        private string ContactNumber;
        private string Email;
        private string Job;
        private string ResidentialAddress;
        //static SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\User\Desktop\APU\sem2\IOOP\IOOP assgn\Recerptionist\Recerptionist\DB.mdf"";Integrated Security=True");
        static SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["dbConnect"].ToString());

        public string currentCustomerID;

        public string FirstName1 { get => FirstName; set => FirstName = value; }
        public string LastName1 { get => LastName; set => LastName = value; }
        public string Job1 { get => Job; set => Job = value; }
        public string ICNumber1 { get => ICNumber; set => ICNumber = value; }
        public string Email1 { get => Email; set => Email = value; }
        public string ContactNumber1 { get => ContactNumber; set => ContactNumber = value; }
        public string ResidentialAddress1 { get => ResidentialAddress; set => ResidentialAddress = value; }
        public string CustomerID1 { get => CustomerID; set => CustomerID = value; }
        public string UserID1 { get => UserID; set => UserID = value; }

        public Customer(string i, string u, string f, string l, string j, string ic, string e, string num, string r)
        {
            CustomerID = i;
            UserID = u; 
            FirstName = f;
            LastName = l;
            Job = j;
            ICNumber = ic;
            Email = e;
            ContactNumber = num;
            ResidentialAddress = r;
        }

        public Customer(string i)
        {
            CustomerID = i;
        }

        public Customer()
        { 
        
        }

        public string addCustomer()
        {
            string status;
            {
                try
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand("INSERT INTO customer (CustomerID, UserID, First_Name, Last_Name, IC_Number, Contact_Number, Email, Job, Residential_Address) VALUES (@CustomerID, @userID, @firstname, @lastname, @ICnum, @num, @em, @job, @address)", con))
                    {
                        cmd.Parameters.AddWithValue("@CustomerID", CustomerID);
                        cmd.Parameters.AddWithValue("@userID", UserID);
                        cmd.Parameters.AddWithValue("@firstname", FirstName);
                        cmd.Parameters.AddWithValue("@lastname", LastName);
                        cmd.Parameters.AddWithValue("@job", Job);
                        cmd.Parameters.AddWithValue("@ICnum", ICNumber);
                        cmd.Parameters.AddWithValue("@em", Email);
                        cmd.Parameters.AddWithValue("@num", ContactNumber);
                        cmd.Parameters.AddWithValue("@address", ResidentialAddress);

                        int i = cmd.ExecuteNonQuery();
                        if (i > 0)
                            status = "Add Successful.";
                        else
                            status = "Unable to Add.";
                    }
                }
                catch (Exception ex)
                {
                    status = "Error: " + ex.Message;
                }
                finally
                {
                    con.Close();
                }
            }
            return status;
        }

        public string deleteCustomer()
        {
            string status;
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("DELETE FROM customer WHERE CustomerID = @CustomerID", con);
                    cmd.Parameters.AddWithValue("@CustomerID", CustomerID);

                    int i = cmd.ExecuteNonQuery();
                    if (i > 0)
                        status = "Delete Successful.";
                    else
                        status = "Unable to Delete.";
                }
                catch (Exception ex)
                {
                    status = "Error: " + ex.Message;
                }
                finally
                {
                    con.Close();
                }
            }
            return status;
        }

        

    }
}
