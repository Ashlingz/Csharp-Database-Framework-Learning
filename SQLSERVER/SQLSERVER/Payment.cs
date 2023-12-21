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
    public partial class Payment : Form
    {
        public Payment()
        {
            InitializeComponent();
        }

        public Payment( double totalAmount)
        {
            InitializeComponent();
            TotalAmount = totalAmount;
        }

        private void Payment_Load(object sender, EventArgs e)
        {
            
            combo.SelectedIndex = 0;
            txtTotalAmount.Text = TotalAmount.ToString("$#,##0.00");
        }

        public double TotalAmount { get; set; }
        public double Discount { get; set; }
        public double DisPrices { get; set; }
        public double PayM { get; set; }
        public double CashReceived { get; set; }
        public double CashReturneed { get; set; }


        private void combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string dis = (combo.SelectedItem + "");
            dis = dis.Substring(0, dis.Length - 1);
            Discount = double.Parse(dis);
            DisPrices = TotalAmount * Discount / 100;
            PayM = TotalAmount - DisPrices;

            txtDisPrice.Text = DisPrices.ToString("$#,##0.00");
            txtPayment.Text = PayM.ToString("$#,##0.00");
        }

        private void btnPaymenr_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            this.Dispose();

        }

        private void txtCashRec_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void txtCashRec_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter)
            {
                try
                {
                    string recive = txtCashRec.Text.Trim();
                    CashReceived = double.Parse(recive);
                    CashReturneed = CashReceived - PayM;
                    txtCashReturn.Text = CashReturneed.ToString("$#,##0.00");
                    if (CashReceived >= PayM)
                    {
                        btnPaymenr.Enabled = true;
                    }
                    else
                    {
                        btnPaymenr.Enabled = false;
                    }

                }
                catch
                {
                    txtCashReturn.Text = "$0.00";
                    btnPaymenr.Enabled = false;
                }

            }
            else
            {
                btnPaymenr_Click(sender, e);
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            


        }
    }
}
