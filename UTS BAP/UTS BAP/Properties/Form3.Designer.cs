namespace UTS_BAP.Properties
{
    partial class Form3
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.NoOrder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Menu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.About = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Searchbtn = new System.Windows.Forms.Button();
            this.textFoodID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Printbtn = new System.Windows.Forms.Button();
            this.textID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textAbout = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textPrice = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textFood = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textQty = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textNoOrder = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NoOrder,
            this.ID,
            this.Menu,
            this.Quantity,
            this.Price,
            this.About});
            this.dataGridView1.Location = new System.Drawing.Point(11, 306);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(450, 314);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // NoOrder
            // 
            this.NoOrder.HeaderText = "No Order";
            this.NoOrder.MinimumWidth = 6;
            this.NoOrder.Name = "NoOrder";
            this.NoOrder.Width = 125;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.Width = 125;
            // 
            // Menu
            // 
            this.Menu.HeaderText = "Menu";
            this.Menu.MinimumWidth = 6;
            this.Menu.Name = "Menu";
            this.Menu.Width = 125;
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.MinimumWidth = 6;
            this.Quantity.Name = "Quantity";
            this.Quantity.Width = 125;
            // 
            // Price
            // 
            this.Price.HeaderText = "Price";
            this.Price.MinimumWidth = 6;
            this.Price.Name = "Price";
            this.Price.Width = 125;
            // 
            // About
            // 
            this.About.HeaderText = "About";
            this.About.MinimumWidth = 6;
            this.About.Name = "About";
            this.About.Width = 125;
            // 
            // Searchbtn
            // 
            this.Searchbtn.Font = new System.Drawing.Font("Microsoft Uighur", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Searchbtn.Location = new System.Drawing.Point(447, 238);
            this.Searchbtn.Name = "Searchbtn";
            this.Searchbtn.Size = new System.Drawing.Size(119, 48);
            this.Searchbtn.TabIndex = 62;
            this.Searchbtn.Text = "Search";
            this.Searchbtn.UseVisualStyleBackColor = true;
            this.Searchbtn.Click += new System.EventHandler(this.Searchbtn_Click);
            // 
            // textFoodID
            // 
            this.textFoodID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textFoodID.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.textFoodID.Location = new System.Drawing.Point(161, 245);
            this.textFoodID.Multiline = true;
            this.textFoodID.Name = "textFoodID";
            this.textFoodID.Size = new System.Drawing.Size(223, 32);
            this.textFoodID.TabIndex = 61;
            this.textFoodID.TextChanged += new System.EventHandler(this.textFoodID_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Uighur", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 242);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 39);
            this.label2.TabIndex = 60;
            this.label2.Text = "Food ID :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.dataGridView2.Location = new System.Drawing.Point(515, 306);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(438, 314);
            this.dataGridView2.TabIndex = 63;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Menu";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Price";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "About";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // Printbtn
            // 
            this.Printbtn.Font = new System.Drawing.Font("Microsoft Uighur", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Printbtn.Location = new System.Drawing.Point(427, 669);
            this.Printbtn.Name = "Printbtn";
            this.Printbtn.Size = new System.Drawing.Size(119, 48);
            this.Printbtn.TabIndex = 64;
            this.Printbtn.Text = "Print";
            this.Printbtn.UseVisualStyleBackColor = true;
            this.Printbtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // textID
            // 
            this.textID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textID.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.textID.Location = new System.Drawing.Point(162, 27);
            this.textID.Multiline = true;
            this.textID.Name = "textID";
            this.textID.Size = new System.Drawing.Size(94, 32);
            this.textID.TabIndex = 72;
            this.textID.TextChanged += new System.EventHandler(this.textID_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Uighur", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 39);
            this.label3.TabIndex = 71;
            this.label3.Text = "ID :";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // textAbout
            // 
            this.textAbout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textAbout.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.textAbout.Location = new System.Drawing.Point(659, 132);
            this.textAbout.Multiline = true;
            this.textAbout.Name = "textAbout";
            this.textAbout.Size = new System.Drawing.Size(223, 32);
            this.textAbout.TabIndex = 70;
            this.textAbout.TextChanged += new System.EventHandler(this.textAbout_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Uighur", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(509, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 39);
            this.label1.TabIndex = 69;
            this.label1.Text = "About :";
            // 
            // textPrice
            // 
            this.textPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPrice.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.textPrice.Location = new System.Drawing.Point(162, 132);
            this.textPrice.Multiline = true;
            this.textPrice.Name = "textPrice";
            this.textPrice.Size = new System.Drawing.Size(223, 32);
            this.textPrice.TabIndex = 68;
            this.textPrice.TextChanged += new System.EventHandler(this.textPrice_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Uighur", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 39);
            this.label4.TabIndex = 67;
            this.label4.Text = "Price :";
            // 
            // textFood
            // 
            this.textFood.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textFood.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.textFood.Location = new System.Drawing.Point(162, 78);
            this.textFood.Multiline = true;
            this.textFood.Name = "textFood";
            this.textFood.Size = new System.Drawing.Size(223, 32);
            this.textFood.TabIndex = 66;
            this.textFood.TextChanged += new System.EventHandler(this.textFood_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Uighur", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 75);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 39);
            this.label7.TabIndex = 65;
            this.label7.Text = "Food :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(-2, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(969, 20);
            this.label5.TabIndex = 73;
            this.label5.Text = "_________________________________________________________________________________" +
    "_______________";
            // 
            // textQty
            // 
            this.textQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textQty.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.textQty.Location = new System.Drawing.Point(659, 78);
            this.textQty.Multiline = true;
            this.textQty.Name = "textQty";
            this.textQty.Size = new System.Drawing.Size(223, 32);
            this.textQty.TabIndex = 75;
            this.textQty.TextChanged += new System.EventHandler(this.textQty_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Uighur", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(509, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 39);
            this.label6.TabIndex = 74;
            this.label6.Text = "Qty :";
            // 
            // textNoOrder
            // 
            this.textNoOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textNoOrder.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.textNoOrder.Location = new System.Drawing.Point(659, 27);
            this.textNoOrder.Multiline = true;
            this.textNoOrder.Name = "textNoOrder";
            this.textNoOrder.Size = new System.Drawing.Size(223, 32);
            this.textNoOrder.TabIndex = 77;
            this.textNoOrder.TextChanged += new System.EventHandler(this.textNoOrder_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Uighur", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(509, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(123, 39);
            this.label8.TabIndex = 76;
            this.label8.Text = "No Order :";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 795);
            this.Controls.Add(this.textNoOrder);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textQty);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textAbout);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textPrice);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textFood);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Printbtn);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.Searchbtn);
            this.Controls.Add(this.textFoodID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form3";
            this.Text = "Print";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Searchbtn;
        private System.Windows.Forms.TextBox textFoodID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Button Printbtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn NoOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Menu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn About;
        private System.Windows.Forms.TextBox textID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textAbout;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textPrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textFood;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textQty;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textNoOrder;
        private System.Windows.Forms.Label label8;
    }
}