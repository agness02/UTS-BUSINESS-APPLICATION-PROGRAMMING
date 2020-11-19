namespace UTS_BAP.Properties
{
    partial class Form2
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
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Menu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.About = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textFood = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textPrice = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textAbout = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Addbtn = new System.Windows.Forms.Button();
            this.Clearbtn = new System.Windows.Forms.Button();
            this.LogOutbtn = new System.Windows.Forms.Button();
            this.listbtn = new System.Windows.Forms.Button();
            this.textID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Menu,
            this.Price,
            this.About});
            this.dataGridView1.Location = new System.Drawing.Point(13, 242);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(776, 314);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            // textFood
            // 
            this.textFood.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textFood.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.textFood.Location = new System.Drawing.Point(162, 12);
            this.textFood.Multiline = true;
            this.textFood.Name = "textFood";
            this.textFood.Size = new System.Drawing.Size(223, 32);
            this.textFood.TabIndex = 54;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Uighur", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 39);
            this.label7.TabIndex = 53;
            this.label7.Text = "Food :";
            // 
            // textPrice
            // 
            this.textPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPrice.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.textPrice.Location = new System.Drawing.Point(162, 66);
            this.textPrice.Multiline = true;
            this.textPrice.Name = "textPrice";
            this.textPrice.Size = new System.Drawing.Size(223, 32);
            this.textPrice.TabIndex = 56;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Uighur", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 39);
            this.label1.TabIndex = 55;
            this.label1.Text = "Price :";
            // 
            // textAbout
            // 
            this.textAbout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textAbout.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.textAbout.Location = new System.Drawing.Point(162, 128);
            this.textAbout.Multiline = true;
            this.textAbout.Name = "textAbout";
            this.textAbout.Size = new System.Drawing.Size(223, 32);
            this.textAbout.TabIndex = 58;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Uighur", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 39);
            this.label2.TabIndex = 57;
            this.label2.Text = "About :";
            // 
            // Addbtn
            // 
            this.Addbtn.Font = new System.Drawing.Font("Microsoft Uighur", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Addbtn.Location = new System.Drawing.Point(13, 178);
            this.Addbtn.Name = "Addbtn";
            this.Addbtn.Size = new System.Drawing.Size(119, 48);
            this.Addbtn.TabIndex = 59;
            this.Addbtn.Text = "Add";
            this.Addbtn.UseVisualStyleBackColor = true;
            this.Addbtn.Click += new System.EventHandler(this.Addbtn_Click);
            // 
            // Clearbtn
            // 
            this.Clearbtn.Font = new System.Drawing.Font("Microsoft Uighur", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clearbtn.Location = new System.Drawing.Point(216, 178);
            this.Clearbtn.Name = "Clearbtn";
            this.Clearbtn.Size = new System.Drawing.Size(119, 48);
            this.Clearbtn.TabIndex = 60;
            this.Clearbtn.Text = "Clear";
            this.Clearbtn.UseVisualStyleBackColor = true;
            this.Clearbtn.Click += new System.EventHandler(this.Clearbtn_Click);
            // 
            // LogOutbtn
            // 
            this.LogOutbtn.Font = new System.Drawing.Font("Microsoft Uighur", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogOutbtn.Location = new System.Drawing.Point(669, 12);
            this.LogOutbtn.Name = "LogOutbtn";
            this.LogOutbtn.Size = new System.Drawing.Size(119, 48);
            this.LogOutbtn.TabIndex = 61;
            this.LogOutbtn.Text = "Log Out";
            this.LogOutbtn.UseVisualStyleBackColor = true;
            // 
            // listbtn
            // 
            this.listbtn.Font = new System.Drawing.Font("Microsoft Uighur", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listbtn.Location = new System.Drawing.Point(426, 178);
            this.listbtn.Name = "listbtn";
            this.listbtn.Size = new System.Drawing.Size(119, 48);
            this.listbtn.TabIndex = 62;
            this.listbtn.Text = "List Order";
            this.listbtn.UseVisualStyleBackColor = true;
            // 
            // textID
            // 
            this.textID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textID.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.textID.Location = new System.Drawing.Point(498, 12);
            this.textID.Multiline = true;
            this.textID.Name = "textID";
            this.textID.Size = new System.Drawing.Size(94, 32);
            this.textID.TabIndex = 64;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Uighur", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(419, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 39);
            this.label3.TabIndex = 63;
            this.label3.Text = "ID :";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 568);
            this.Controls.Add(this.textID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listbtn);
            this.Controls.Add(this.LogOutbtn);
            this.Controls.Add(this.Clearbtn);
            this.Controls.Add(this.Addbtn);
            this.Controls.Add(this.textAbout);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textPrice);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textFood);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form2";
            this.Text = "Admin";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textFood;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textPrice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textAbout;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Addbtn;
        private System.Windows.Forms.Button Clearbtn;
        private System.Windows.Forms.Button LogOutbtn;
        private System.Windows.Forms.Button listbtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Menu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn About;
        private System.Windows.Forms.TextBox textID;
        private System.Windows.Forms.Label label3;
    }
}