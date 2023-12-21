namespace SQLSERVER
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnLottery = new System.Windows.Forms.Button();
            this.btnShowemployee = new System.Windows.Forms.Button();
            this.btnlogout = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.btnLottery);
            this.groupBox1.Controls.Add(this.btnShowemployee);
            this.groupBox1.Controls.Add(this.btnlogout);
            this.groupBox1.Location = new System.Drawing.Point(9, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(223, 346);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "People";
            // 
            // btnLottery
            // 
            this.btnLottery.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnLottery.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnLottery.Location = new System.Drawing.Point(4, 56);
            this.btnLottery.Margin = new System.Windows.Forms.Padding(2);
            this.btnLottery.Name = "btnLottery";
            this.btnLottery.Size = new System.Drawing.Size(214, 27);
            this.btnLottery.TabIndex = 2;
            this.btnLottery.Text = "Employee Lottery";
            this.btnLottery.UseVisualStyleBackColor = false;
            this.btnLottery.Click += new System.EventHandler(this.btnLottery_Click);
            // 
            // btnShowemployee
            // 
            this.btnShowemployee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnShowemployee.Location = new System.Drawing.Point(4, 17);
            this.btnShowemployee.Margin = new System.Windows.Forms.Padding(2);
            this.btnShowemployee.Name = "btnShowemployee";
            this.btnShowemployee.Size = new System.Drawing.Size(214, 27);
            this.btnShowemployee.TabIndex = 1;
            this.btnShowemployee.Text = "Show Employee";
            this.btnShowemployee.UseVisualStyleBackColor = false;
            this.btnShowemployee.Click += new System.EventHandler(this.btnShowemployee_Click);
            // 
            // btnlogout
            // 
            this.btnlogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnlogout.BackColor = System.Drawing.Color.Red;
            this.btnlogout.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnlogout.Location = new System.Drawing.Point(4, 314);
            this.btnlogout.Margin = new System.Windows.Forms.Padding(2);
            this.btnlogout.Name = "btnlogout";
            this.btnlogout.Size = new System.Drawing.Size(214, 28);
            this.btnlogout.TabIndex = 0;
            this.btnlogout.Text = "Logout";
            this.btnlogout.UseVisualStyleBackColor = false;
            this.btnlogout.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.btnAddProduct);
            this.groupBox2.Location = new System.Drawing.Point(278, 10);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(221, 346);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Product";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Location = new System.Drawing.Point(6, 96);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(211, 27);
            this.button2.TabIndex = 4;
            this.button2.Text = "Order";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DodgerBlue;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(5, 56);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(211, 27);
            this.button1.TabIndex = 3;
            this.button1.Text = "Show Product";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnAddProduct.Location = new System.Drawing.Point(5, 18);
            this.btnAddProduct.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(211, 27);
            this.btnAddProduct.TabIndex = 2;
            this.btnAddProduct.Text = "Add Product";
            this.btnAddProduct.UseVisualStyleBackColor = false;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(822, 366);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "MY APP";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnlogout;
        private System.Windows.Forms.Button btnShowemployee;
        private System.Windows.Forms.Button btnLottery;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}

