using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SQLSERVER
{
    public partial class Lottery : Form
    {
        public Lottery()
        {
            InitializeComponent();
        }
        private List<Employee> employees;
        private void Lottery_Load(object sender, EventArgs e)
        {
            try
            {
                string sql = @"
                                    select 
                                      tbl_Employee.ID,
                                      tbl_Employee.FirstName,
                                      tbl_Employee.LastName,
                                      tbl_Employee.DateOfBirth,
	                                    tbl_Employee.PhoneNumber,
                                      tbl_Employee.Photo
                                    from 
                                       ss3.dbo.tbl_Employee";
                SqlCommand s = new SqlCommand(sql, ConnectionDB.Datacon);
                SqlDataReader r = s.ExecuteReader();
                employees = Employee.GetEmployees(r);
                r.Close();

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        int index;
        private void timer_Tick(object sender, EventArgs e)
        {
            Random random = new Random();
            index = random.Next(employees.Count);
            txt.Text = employees[index].PhoneNumber;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            string text = btnStart.Text;
            if(text == "Start")
            {
                timer.Start();
                btnStart.Text = "Stop";

            }
            else
            {
                timer.Stop();
                btnStart.Text = "Start";
                list.Items.Add(employees[index]);
                employees.RemoveAt(index);
            }
        }

        private void list_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (list.SelectedItems.Count > 0)
            {
                Employee employee = list.SelectedItem as Employee;
                lbID.Text = employee.ID.ToString("0000");
                lbFistname.Text = employee.FirstName;
                lbLastName.Text = employee.LastName;
                lbDateOfBirth.Text = employee.DateOfBirth.ToString();
                lbPhoneNumber.Text = employee.PhoneNumber;
                picture.Image = employee.Img;
                
            }
        }
    }
}
