using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;


namespace Purchase_Order_System
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void L_B_OK_Click(object sender, EventArgs e)
        {
            string name = L_TB_User.Text;
            string pw = L_TB_Password.Text;


            POConn L_Conn = new POConn();
            DataTable cred = L_Conn.SelectQuery("SELECT USER_NAME, PASSWORD FROM USERS WHERE USER_NAME=LOWER('" + name + "') AND PASSWORD=('" + pw + "')");


            if (cred.Rows.Count > 0)
            {
                
                POSystem POSystem = new POSystem(name);
                POSystem.Show();
                this.Hide();
                POSystem.FormClosing += POSystem_Closing;


            }
            else MessageBox.Show("Incorrect User Name and/or Password");

        }
        private void POSystem_Closing(object sender, FormClosingEventArgs e)
        {
            this.Show();
        }

        private void L_B_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
