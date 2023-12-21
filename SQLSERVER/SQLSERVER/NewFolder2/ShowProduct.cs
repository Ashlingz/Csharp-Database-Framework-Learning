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
    public partial class ShowProduct : Form
    {
        public ShowProduct()
        {
            InitializeComponent();
        }

        private void ShowProduct_Load(object sender, EventArgs e)
        {
            try
            {
                string sql = "SELECT * From ss3.dbo.tbl_Product";
                SqlCommand s = new SqlCommand(sql, ConnectionDB.Datacon);
                SqlDataReader r = s.ExecuteReader();

                while (r.Read())
                {
                    string id = r[0].ToString();
                    string barcode = r[1].ToString();
                    string pname = r[2].ToString();
                    string price = r[3].ToString();
                    string qty = r[4].ToString();

                    //Stream Iamge Format into Table.
                    MemoryStream memoryStream = new MemoryStream((Byte[])r[5]);
                    Image img = Image.FromStream(memoryStream);

                    string cid = r[6].ToString();

                    data.Rows.Add(id, barcode, pname, $"{price:c2}", qty, img, cid);
                }

                r.Close();
                s.Dispose();


            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void data_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            int col = e.ColumnIndex;
            if (row >= 0 && col == 5)
            {
                picture.Image = data.Rows[row].Cells[5].Value as Image;
            }
        }
    }
}
