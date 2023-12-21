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
    public partial class AddProduct : Form
    {
        public AddProduct()
        {
            InitializeComponent();
        }

        private void AddProduct_Load(object sender, EventArgs e)
        {
            try
            {

                string sql = "SELECT * FROM ss3.dbo.tbl_Category";
                SqlCommand s = new SqlCommand(sql, ConnectionDB.Datacon);
                SqlDataReader r = s.ExecuteReader();
                List<Category> categories = Category.GetCategories(r);
                r.Close();
                s.Dispose();

                foreach (var c in categories)
                    comboCategory.Items.Add(c);

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                DialogResult = DialogResult.Cancel;
            }
        }

        private void txtBarCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if(e.KeyChar == 13)
                {
                    txtProName.Focus();
                }

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        private void picture_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image(JPG) *.jpg|*.jpg|Image(PNG) *.PNG|*.png|All Files *.*|*.*";
            DialogResult result = openFileDialog.ShowDialog();
            if (result >= DialogResult)
            {
                picture.Image = Image.FromFile(openFileDialog.FileName);
            }
        }

        private void btnSumit_Click(object sender, EventArgs e)
        {
            try
            {
                string barcode = txtBarCode.Text.Trim();
                string pname = txtProName.Text.Trim();
                double pricce = Convert.ToDouble(txtPrice.Text.Trim());
                int qty = Convert.ToInt32(txtQty.Text.Trim());
                Category category = comboCategory.SelectedItem as Category;
                string cid = category.ID;

                // Convert Image Into Stream Iamge Becuz in DataBase only knew Stream as Image.
                MemoryStream memoryStream = new MemoryStream();
                Image image = picture.Image;
                image.Save(memoryStream, image.RawFormat);
                //

                string sql = $"INSERT INTO ss3.dbo.tbl_Product(tbl_Product.Barcode, tbl_Product.Pname, tbl_Product.Price, tbl_Product.Qty, tbl_Product.CID, tbl_Product.Photo) " +
                    $"VALUES('{barcode}', '{pname}', {pricce}, {qty}, {cid}, @img)";
                SqlCommand s = new SqlCommand(sql, ConnectionDB.Datacon);
                
                // Declare Image Becuz in Value Image can't put with Other.
                s.Parameters.AddWithValue("img", memoryStream.ToArray());

                s.ExecuteNonQuery();
                s.Dispose();
                MessageBox.Show("New Product has been Submitted");
                txtBarCode.Clear();
                txtProName.Clear();
                txtPrice.Clear();
                txtQty.Clear();
                comboCategory.SelectedIndex = -1;
                picture.Image = Properties.Resources.noImage;


            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
