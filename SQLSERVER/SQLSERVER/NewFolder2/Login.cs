using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQLSERVER
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            comboAuthenticaation.SelectedIndex = 1;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string ip = txtIP.Text.Trim();
                int index = comboAuthenticaation.SelectedIndex;
                string dbName = txtDatdaBas.Text.Trim();
                string user = txtUserName.Text.Trim();
                string password = txtPassword.Text.Trim();
                if (index == 0)
                    ConnectionDB.Connection(ip, dbName);
                else
                    ConnectionDB.Connection(ip, dbName, user, password);
                DialogResult = DialogResult.OK;
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

          
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void comboAuthenticaation_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = comboAuthenticaation.SelectedIndex;
            if (index == 0)
            {
                txtUserName.Enabled = false;
                txtPassword.Enabled = false;
            }
            else
            {
                txtUserName.Enabled = true;
                txtPassword.Enabled = true;
            }
        }

        private void txtIP_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
