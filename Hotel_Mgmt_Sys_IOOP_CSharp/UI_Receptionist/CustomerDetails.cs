using System;
using System.CodeDom;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Mgmt_Sys_IOOP_CSharp
{
    public partial class CustomerDetails : Form
    {
        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\Teoh Peng Kee\\OneDrive - Asia Pacific University\\SE Course\\Y1S2\\IOOP\\Hotel_Mgmt_Sys_IOOP_CSharp\\Hotel_Mgmt_Sys_IOOP_CSharp\\DB\\myDB.mdf\";Integrated Security=True");
        public CustomerDetails()
        {
            InitializeComponent();
        }

        public void Grid()
        {
            con.Open();
            string query = "select * from Customer";
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder();
            var ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            con.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //Add f1 = new Add();
            CustomerProfileFrm f1 = new CustomerProfileFrm("Add"); 
            f1.Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //Delete f2 = new Delete();
            CustomerProfileFrm f2 = new CustomerProfileFrm("Delete");
            f2.Show();
            Grid(); 
        }

        private void CustomerDetails_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'customerDetailsDataSet.Customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter.Fill(this.customerDetailsDataSet.Customer);
            // TODO: This line of code loads data into the 'dBDataSet.Customer' table. You can move, or remove it, as needed.
            //this.customerTableAdapter.Fill(this.dBDataSet.Customer);
            Grid();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void Filter()
        {
            con.Open();
            string query = "select * from Customer where CustomerID = '"+txtCustomerID.Text+"'";
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder();
            var ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            con.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Grid();
        }


        private void field_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Filter();
        }

        private void txtValue_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            if (field.Text == "CustomerID")
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT CustomerID, FirstName, LastName, Job, ICNumber, Email, ContactNumber, ResidentialAddress FROM Customer where CustomerID = '" + txtValue.Text + "'", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            else if (field.Text == "FirstName")
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT CustomerID, FirstName, LastName, Job, ICNumber, Email, ContactNumber, ResidentialAddress FROM Customer where FirstName = '" + txtValue.Text + "'", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            else if (field.Text == "LastName")
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT CustomerID, FirstName, LastName, Job, ICNumber, Email, ContactNumber, ResidentialAddress FROM Customer where LastName = '" + txtValue.Text + "'", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            else if (field.Text == "Job")
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT CustomerID, FirstName, LastName, Job, ICNumber, Email, ContactNumber, ResidentialAddress FROM Customer where Job = '" + txtValue.Text + "'", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            else if (field.Text == "ICNumber")
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT CustomerID, FirstName, LastName, Job, ICNumber, Email, ContactNumber, ResidentialAddress FROM Customer where ICNumber = '" + txtValue.Text + "'", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            else if (field.Text == "Email")
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT CustomerID, FirstName, LastName, Job, ICNumber, Email, ContactNumber, ResidentialAddress FROM Customer where Email = '" + txtValue.Text + "'", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            else if (field.Text == "ContactNumber")
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT CustomerID, FirstName, LastName, Job, ICNumber, Email, ContactNumber, ResidentialAddress FROM Customer where ContactNumber = '" + txtValue.Text + "'", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            else if (field.Text == "ResidentialAddress")
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT CustomerID, FirstName, LastName, Job, ICNumber, Email, ContactNumber, ResidentialAddress FROM Customer where ResidentialAddress = '" + txtValue.Text + "'", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            else
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT CustomerID, FirstName, LastName, Job, ICNumber, Email, ContactNumber, ResidentialAddress FROM Customer", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }
    }
}
