
namespace SQLSERVER
{
    partial class AddProduct
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtBarCode = new System.Windows.Forms.TextBox();
            this.txtProName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboCategory = new System.Windows.Forms.ComboBox();
            this.btnSumit = new System.Windows.Forms.Button();
            this.picture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "BarCode";
            // 
            // txtBarCode
            // 
            this.txtBarCode.Location = new System.Drawing.Point(151, 28);
            this.txtBarCode.Name = "txtBarCode";
            this.txtBarCode.Size = new System.Drawing.Size(244, 24);
            this.txtBarCode.TabIndex = 1;
            this.txtBarCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBarCode_KeyPress);
            // 
            // txtProName
            // 
            this.txtProName.Location = new System.Drawing.Point(151, 62);
            this.txtProName.Name = "txtProName";
            this.txtProName.Size = new System.Drawing.Size(244, 24);
            this.txtProName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "ProductName";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(151, 96);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(244, 24);
            this.txtPrice.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(88, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Price";
            // 
            // txtQty
            // 
            this.txtQty.Location = new System.Drawing.Point(151, 129);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(244, 24);
            this.txtQty.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(99, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "Qty";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(62, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 18);
            this.label5.TabIndex = 8;
            this.label5.Text = "Category";
            // 
            // comboCategory
            // 
            this.comboCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboCategory.FormattingEnabled = true;
            this.comboCategory.Location = new System.Drawing.Point(151, 165);
            this.comboCategory.Name = "comboCategory";
            this.comboCategory.Size = new System.Drawing.Size(244, 26);
            this.comboCategory.TabIndex = 10;
            // 
            // btnSumit
            // 
            this.btnSumit.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSumit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSumit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSumit.Location = new System.Drawing.Point(151, 223);
            this.btnSumit.Name = "btnSumit";
            this.btnSumit.Size = new System.Drawing.Size(244, 38);
            this.btnSumit.TabIndex = 11;
            this.btnSumit.Text = "Sumit";
            this.btnSumit.UseVisualStyleBackColor = false;
            this.btnSumit.Click += new System.EventHandler(this.btnSumit_Click);
            // 
            // picture
            // 
            this.picture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picture.Image = global::SQLSERVER.Properties.Resources.noImage;
            this.picture.Location = new System.Drawing.Point(427, 28);
            this.picture.Name = "picture";
            this.picture.Size = new System.Drawing.Size(236, 233);
            this.picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picture.TabIndex = 12;
            this.picture.TabStop = false;
            this.picture.Click += new System.EventHandler(this.picture_Click_1);
            // 
            // AddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 283);
            this.Controls.Add(this.picture);
            this.Controls.Add(this.btnSumit);
            this.Controls.Add(this.comboCategory);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtQty);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtProName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBarCode);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddProduct";
            this.Load += new System.EventHandler(this.AddProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBarCode;
        private System.Windows.Forms.TextBox txtProName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboCategory;
        private System.Windows.Forms.Button btnSumit;
        private System.Windows.Forms.PictureBox picture;
    }
}