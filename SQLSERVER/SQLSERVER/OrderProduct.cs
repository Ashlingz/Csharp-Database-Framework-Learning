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
    public partial class OrderProduct : Form
    {
        public OrderProduct()
        {
            InitializeComponent();
        }
        private void UpdateStock()
        {
            foreach(OrderDetail temp in order)
            {
                
                string pid = temp.PID + "";
                string qty = temp.Qty + "";
                
                
                string sql = "Update tbl_Product set Qty = Qty - '"+qty+"' where ID = '"+pid+"'";
                SqlCommand s = new SqlCommand(sql, ConnectionDB.Datacon);
                s.ExecuteNonQuery();
                s.Dispose();
                
            }
            

        }

        private void OrderProduct_Load(object sender, EventArgs e)
        {
            try
            {
                string sql = "select * from tbl_Product";
                SqlCommand s = new SqlCommand(sql, ConnectionDB.Datacon);
                SqlDataReader r = s.ExecuteReader();
                int x = 1, y = 1;
                while (r.Read())
                {
                    int id = int.Parse(r[0] + "");
                    string pname = "" + r[2];
                    string price = double.Parse(r[3] + "").ToString("c2");
                    int qty = int.Parse(r[4] + "");
                    MemoryStream memoryStream = new MemoryStream((Byte[])r[5]);
                    Image img = Image.FromStream(memoryStream);


                    ProductLayout obj = new ProductLayout(id, pname, price, qty, img);

                    tableLayoutPanel1.Controls.Add(obj, y, x);
                    y = 1;
                    if (y >= 1)
                    {
                        x++;
                    }


                }
                r.Close();
                s.Clone();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private List<OrderDetail> order = new List<OrderDetail>();
        private int CheckID(int id)
        {
            for(int i = 0; i < order.Count; i++)
            {
                OrderDetail obj = order[i];
                if (obj.PID == id)
                    return i;
            }
            return -1;
        }
        
        private bool ordProduct(string barcode)
        {
            string sql = "select * from tbl_Product where barcode='" + barcode + "'  ";
            SqlCommand sq = new SqlCommand(sql, ConnectionDB.Datacon);
            SqlDataReader r = sq.ExecuteReader();



            if (r.Read())
            {
                string id = r[0]+"";
                string ppNAme = r[2] +"";
                double pri = double.Parse("" + r[3]);
                //int qty = int.Parse("" + r[4]);
                int qtty = 1;
                double amount = qtty * pri;

                int index = CheckID(int.Parse(id));
                if ( index >= 0)
                {
                    qtty = order[index].Qty + 1;
                    amount = qtty * pri;
                    data.Rows[index].Cells[3].Value = qtty;
                    data.Rows[index].Cells[4].Value = amount.ToString("c2");

                    order[index].Qty = qtty;

                }
                else
                {
                    int no = data.Rows.Count;
                    data.Rows.Add(no, ppNAme, pri.ToString("c2"), qtty,amount.ToString("c2"));
                    OrderDetail obj = new OrderDetail(int.Parse(id), qtty, pri);
                    order.Add(obj);
                }
                r.Close();
                sq.Dispose();
                return true;
            }
            else
            {
                r.Close();
                sq.Dispose();
                return false;
            }
        }

        private void data_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {

                
            }
        }

        private void data_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 13)
            {
                string barcode = txtBarcode.Text.Trim();
                if (ordProduct(barcode))
                {
                    txtBarcode.Clear();
                }
                else
                {
                    MessageBox.Show("This Product not in Stock");
                }
            }
        }


        private double TotalAmount()
        {
            double t = 0;
            foreach (OrderDetail temp in order)
            {
                t += temp.Qty * temp.Price;
            }
            return t;
        }

        private void txtBarcode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                string barcode = txtBarcode.Text.Trim();
                if (ordProduct(barcode))
                {
                    txtTotal.Text = TotalAmount().ToString("c2");
                }
                else
                {
                    MessageBox.Show("This Product not in Stock");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Payment p = new Payment(TotalAmount());
            if (p.ShowDialog() == DialogResult.OK)
            {
                
                //Update Stock
                UpdateStock();

                //Print Report
                printPreviewDialog1.Document = printDocument1;
                printPreviewDialog1.ShowDialog();

                order = new List<OrderDetail>();
                data.Rows.Clear();
                txtBarcode.Clear();
                txtTotal.Text = "$0.00";
            }

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

            int y = 410;
            List<OrderDetail> orderDetails = new List<OrderDetail>();
            
            foreach (DataGridViewRow temp in data.Rows)
            {
                //Limit the name Length
                string name = temp.Cells[1].Value + "";
                if (name.Length > 15)
                    name = name.Substring(0, 15);
                //Logo
                Image image = Image.FromFile("D:\\C#\\Image\\Logo.png");

                //Header
                e.Graphics.DrawImage(image, 60, 0, 200, 200);
                e.Graphics.DrawString("Bee Coffee", new Font("", 16, FontStyle.Bold), Brushes.Black, 100, 180);
                e.Graphics.DrawString("Tel: 088 443 234", new Font("", 10), Brushes.Black, 230, 248);
                e.Graphics.DrawString("___________________________", new Font("", 16), Brushes.Black, 0, 240);
                e.Graphics.DrawString("|", new Font("", 15, FontStyle.Bold), Brushes.Black, 95, 259);
                e.Graphics.DrawString("RECEIPT", new Font("", 12, FontStyle.Bold), Brushes.Black, 110, 264);
                e.Graphics.DrawString("|", new Font("", 15, FontStyle.Bold), Brushes.Black, 195, 259);
                e.Graphics.DrawString("___________________________", new Font("", 16), Brushes.Black, 0, 260);
                e.Graphics.DrawString("Total:", new Font("Mongolian Baiti", 13), Brushes.Black, 5, 290);
               

                //Total
                e.Graphics.DrawString($"{txtTotal.Text.Trim()}", new Font("Mongolian Baiti", 13), Brushes.Black, 220, 290);
             

                e.Graphics.DrawString("___________________________", new Font("", 16), Brushes.Black, 0, 350);
                e.Graphics.DrawString("Description", new Font("Mongolian Baiti", 13), Brushes.Black, 5, 380);

                //Lable Text
                e.Graphics.DrawString("Qty", new Font("Mongolian Baiti", 10), Brushes.Black, 170, 380);
                e.Graphics.DrawString("Price", new Font("Mongolian Baiti", 10), Brushes.Black, 230, 380);
                e.Graphics.DrawString("Amount", new Font("Mongolian Baiti", 10), Brushes.Black, 290, 380);
                e.Graphics.DrawString("___________________________", new Font("", 16), Brushes.Black, 0, 380);

                //Valuble
                e.Graphics.DrawString($"{name}", new Font("Mongolian Baiti", 10), Brushes.Black, 5, y);
                e.Graphics.DrawString($"{temp.Cells[3].Value}", new Font("Mongolian Baiti", 10), Brushes.Black, 170, y);
                e.Graphics.DrawString($"{temp.Cells[2].Value}", new Font("Mongolian Baiti", 10), Brushes.Black, 230, y);
                e.Graphics.DrawString($"{temp.Cells[4].Value}", new Font("Mongolian Baiti", 10), Brushes.Black, 290, y);
                y += 50;
            }
        }
    }
}
