using System;
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
    public partial class UserLoginForm : Form
    {
        private string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\Teoh Peng Kee\\OneDrive - Asia Pacific University\\SE Course\\Y1S2\\IOOP\\Hotel_Mgmt_Sys_IOOP_CSharp\\Hotel_Mgmt_Sys_IOOP_CSharp\\DB\\myDB.mdf\";Integrated Security=True";
        public UserLoginForm()
        {
            InitializeComponent();
            buttonLogin.Click -= buttonLogin_Click; // Ensure no duplicate event handlers
            buttonLogin.Click += buttonLogin_Click;
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            Form targetForm = null;

            string username = textBoxUsername.Text;
            string password = textBoxPassword.Text;
            User user = new User(username, password);
            user.login(this);            
        }
    }
}
