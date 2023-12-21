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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            new Login().ShowDialog(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ConnectionDB.Datacon.Close();
            new Login().ShowDialog(this);
        }

        private void btnShowemployee_Click(object sender, EventArgs e)
        {
            new ShowEmployee().ShowDialog(this);
        }

        private void btnLottery_Click(object sender, EventArgs e)
        {
            new Lottery().ShowDialog(this);
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            new AddProduct().ShowDialog(this);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            new ShowProduct().ShowDialog(this);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new OrderProduct().ShowDialog(this);
        }
    }
}
