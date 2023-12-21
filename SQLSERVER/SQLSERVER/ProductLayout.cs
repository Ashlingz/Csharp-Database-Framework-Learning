using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQLSERVER
{
    public partial class ProductLayout : UserControl
    {
        public ProductLayout()
        {
            InitializeComponent();
        }
        public ProductLayout(int iD, string pNname, string price, int qty, Image im)
        {
            InitializeComponent();
            ID = iD;
            PNname = pNname;
            Price = price;
            Qty = qty;
            Pic = im;
        }
        public int ID { get; set; }
        public string PNname
        {
            get => txtPname.Text;
            set => txtPname.Text = value;
        }
        public string Price
        {
            get => txtPrice.Text;
            set => txtPrice.Text = value;
        }
        public int Qty
        {
            get => int.Parse(txtQty.Text);
            set => txtQty.Text = value + "";
        }
        public Image Pic
        {
            get => picture.Image;
            set => picture.Image = value;
        }
        public int BQty { get; set; }



        private void btnAdd_Click(object sender, EventArgs e)
        {

        }
    }


}
