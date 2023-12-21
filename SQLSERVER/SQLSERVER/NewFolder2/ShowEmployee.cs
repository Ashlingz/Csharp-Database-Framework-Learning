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
using System.IO;
namespace SQLSERVER
{
    public partial class ShowEmployee : Form
    {
        public ShowEmployee()
        {
            InitializeComponent();
        }



        private void ShowEmployee_Load(object sender, EventArgs e)
        {
            try
            {
                string sql = "SELECT * From ss3.dbo.tbl_Employee";
                SqlCommand s = new SqlCommand(sql, ConnectionDB.Datacon);
                SqlDataReader r = s.ExecuteReader();

                while (r.Read())
                {
                    string id = r[0].ToString();
                    string first = r[1].ToString();
                    string last = r[2].ToString();
                    string gender = r[3].ToString();
                    if (gender == "M")
                        gender = "Male";
                    else
                        gender = "Female";
                    DateTime dob = DateTime.Parse(r[4].ToString());
                    int age = (int)((DateTime.Now - dob).TotalDays / 365.25);
                    string city = r[5].ToString();
                    string country = r[6].ToString();
                    string phone = r[7].ToString();

                    //Stream Iamge Format into Table.
                    MemoryStream memoryStream = new MemoryStream((Byte[])r[8]);
                    Image img = Image.FromStream(memoryStream);


                    data.Rows.Add(id, first, last, gender, $"{dob:D}", phone, city, country,img);


                }
                r.Close();
                s.Dispose();
            }catch
             (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void data_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            int col = e.ColumnIndex;
            if (row >= 0 && col == 8)
            {
                picture.Image = data.Rows[row].Cells[8].Value as Image;
            }
        }

        private void data_Click(object sender, EventArgs e)
        {

        }
    }
}
