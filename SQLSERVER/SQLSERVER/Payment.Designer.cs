
namespace SQLSERVER
{
    partial class Payment
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtTotalAmount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDisPrice = new System.Windows.Forms.TextBox();
            this.combo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPayment = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCashRec = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCashReturn = new System.Windows.Forms.TextBox();
            this.btnPaymenr = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtTotalAmount
            // 
            this.txtTotalAmount.Location = new System.Drawing.Point(199, 12);
            this.txtTotalAmount.Name = "txtTotalAmount";
            this.txtTotalAmount.ReadOnly = true;
            this.txtTotalAmount.Size = new System.Drawing.Size(245, 29);
            this.txtTotalAmount.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "TotalAmount";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(110, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Discount";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(67, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "DiscountPrice";
            // 
            // txtDisPrice
            // 
            this.txtDisPrice.Location = new System.Drawing.Point(199, 94);
            this.txtDisPrice.Name = "txtDisPrice";
            this.txtDisPrice.ReadOnly = true;
            this.txtDisPrice.Size = new System.Drawing.Size(245, 29);
            this.txtDisPrice.TabIndex = 4;
            // 
            // combo
            // 
            this.combo.FormattingEnabled = true;
            this.combo.Items.AddRange(new object[] {
            "5%",
            "10%",
            "15%",
            "20%"});
            this.combo.Location = new System.Drawing.Point(199, 52);
            this.combo.Name = "combo";
            this.combo.Size = new System.Drawing.Size(244, 32);
            this.combo.TabIndex = 6;
            this.combo.SelectedIndexChanged += new System.EventHandler(this.combo_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(110, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 24);
            this.label4.TabIndex = 8;
            this.label4.Text = "Payment";
            // 
            // txtPayment
            // 
            this.txtPayment.Location = new System.Drawing.Point(199, 138);
            this.txtPayment.Name = "txtPayment";
            this.txtPayment.ReadOnly = true;
            this.txtPayment.Size = new System.Drawing.Size(245, 29);
            this.txtPayment.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(55, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 24);
            this.label5.TabIndex = 10;
            this.label5.Text = "Cash Received";
            // 
            // txtCashRec
            // 
            this.txtCashRec.Location = new System.Drawing.Point(199, 175);
            this.txtCashRec.Name = "txtCashRec";
            this.txtCashRec.Size = new System.Drawing.Size(245, 29);
            this.txtCashRec.TabIndex = 9;
            this.txtCashRec.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCashRec_KeyPress);
            this.txtCashRec.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtCashRec_KeyUp);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(55, 218);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 24);
            this.label6.TabIndex = 12;
            this.label6.Text = "Cash Returned";
            // 
            // txtCashReturn
            // 
            this.txtCashReturn.Location = new System.Drawing.Point(199, 215);
            this.txtCashReturn.Name = "txtCashReturn";
            this.txtCashReturn.ReadOnly = true;
            this.txtCashReturn.Size = new System.Drawing.Size(245, 29);
            this.txtCashReturn.TabIndex = 11;
            // 
            // btnPaymenr
            // 
            this.btnPaymenr.Enabled = false;
            this.btnPaymenr.Location = new System.Drawing.Point(199, 277);
            this.btnPaymenr.Name = "btnPaymenr";
            this.btnPaymenr.Size = new System.Drawing.Size(244, 41);
            this.btnPaymenr.TabIndex = 13;
            this.btnPaymenr.Text = "Check Out";
            this.btnPaymenr.UseVisualStyleBackColor = true;
            this.btnPaymenr.Click += new System.EventHandler(this.btnPaymenr_Click);
            // 
            // Payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 351);
            this.Controls.Add(this.btnPaymenr);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtCashReturn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtCashRec);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPayment);
            this.Controls.Add(this.combo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDisPrice);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTotalAmount);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Payment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Payment";
            this.Load += new System.EventHandler(this.Payment_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTotalAmount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDisPrice;
        private System.Windows.Forms.ComboBox combo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPayment;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCashRec;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCashReturn;
        private System.Windows.Forms.Button btnPaymenr;
    }
}