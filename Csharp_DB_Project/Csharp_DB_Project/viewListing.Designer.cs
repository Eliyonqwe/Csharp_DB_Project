﻿namespace Csharp_DB_Project
{
    partial class viewListing
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_userID = new System.Windows.Forms.TextBox();
            this.txt_stockID = new System.Windows.Forms.TextBox();
            this.txt_cname = new System.Windows.Forms.TextBox();
            this.txt_ctype = new System.Windows.Forms.TextBox();
            this.txt_amount = new System.Windows.Forms.TextBox();
            this.txt_price = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_offerPrice = new System.Windows.Forms.TextBox();
            this.btn_offer = new System.Windows.Forms.Button();
            this.btn_load = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(670, 262);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(697, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "userID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(697, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "stockID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(697, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Company Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(697, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(159, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Company Type";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(697, 197);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 25);
            this.label5.TabIndex = 5;
            this.label5.Text = "Amount";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(697, 239);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 25);
            this.label6.TabIndex = 6;
            this.label6.Text = "Selling Price";
            // 
            // txt_userID
            // 
            this.txt_userID.Location = new System.Drawing.Point(878, 24);
            this.txt_userID.Name = "txt_userID";
            this.txt_userID.ReadOnly = true;
            this.txt_userID.Size = new System.Drawing.Size(288, 22);
            this.txt_userID.TabIndex = 7;
            // 
            // txt_stockID
            // 
            this.txt_stockID.Location = new System.Drawing.Point(878, 69);
            this.txt_stockID.Name = "txt_stockID";
            this.txt_stockID.ReadOnly = true;
            this.txt_stockID.Size = new System.Drawing.Size(288, 22);
            this.txt_stockID.TabIndex = 8;
            // 
            // txt_cname
            // 
            this.txt_cname.Location = new System.Drawing.Point(878, 112);
            this.txt_cname.Name = "txt_cname";
            this.txt_cname.ReadOnly = true;
            this.txt_cname.Size = new System.Drawing.Size(288, 22);
            this.txt_cname.TabIndex = 9;
            // 
            // txt_ctype
            // 
            this.txt_ctype.Location = new System.Drawing.Point(878, 155);
            this.txt_ctype.Name = "txt_ctype";
            this.txt_ctype.ReadOnly = true;
            this.txt_ctype.Size = new System.Drawing.Size(288, 22);
            this.txt_ctype.TabIndex = 10;
            // 
            // txt_amount
            // 
            this.txt_amount.Location = new System.Drawing.Point(878, 201);
            this.txt_amount.Name = "txt_amount";
            this.txt_amount.ReadOnly = true;
            this.txt_amount.Size = new System.Drawing.Size(288, 22);
            this.txt_amount.TabIndex = 11;
            // 
            // txt_price
            // 
            this.txt_price.Location = new System.Drawing.Point(878, 243);
            this.txt_price.Name = "txt_price";
            this.txt_price.ReadOnly = true;
            this.txt_price.Size = new System.Drawing.Size(288, 22);
            this.txt_price.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(312, 392);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(157, 25);
            this.label7.TabIndex = 13;
            this.label7.Text = "Offering Price: ";
            // 
            // txt_offerPrice
            // 
            this.txt_offerPrice.Location = new System.Drawing.Point(475, 395);
            this.txt_offerPrice.Name = "txt_offerPrice";
            this.txt_offerPrice.Size = new System.Drawing.Size(199, 22);
            this.txt_offerPrice.TabIndex = 14;
            // 
            // btn_offer
            // 
            this.btn_offer.Location = new System.Drawing.Point(475, 478);
            this.btn_offer.Name = "btn_offer";
            this.btn_offer.Size = new System.Drawing.Size(93, 50);
            this.btn_offer.TabIndex = 15;
            this.btn_offer.Text = "Offer";
            this.btn_offer.UseVisualStyleBackColor = true;
            this.btn_offer.Click += new System.EventHandler(this.btn_offer_Click);
            // 
            // btn_load
            // 
            this.btn_load.Location = new System.Drawing.Point(87, 292);
            this.btn_load.Name = "btn_load";
            this.btn_load.Size = new System.Drawing.Size(93, 50);
            this.btn_load.TabIndex = 16;
            this.btn_load.Text = "Load the listings";
            this.btn_load.UseVisualStyleBackColor = true;
            this.btn_load.Click += new System.EventHandler(this.btn_load_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.RosyBrown;
            this.button1.Location = new System.Drawing.Point(947, 525);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 54);
            this.button1.TabIndex = 17;
            this.button1.Text = "Back To HomePage";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // viewListing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1178, 625);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_load);
            this.Controls.Add(this.btn_offer);
            this.Controls.Add(this.txt_offerPrice);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_price);
            this.Controls.Add(this.txt_amount);
            this.Controls.Add(this.txt_ctype);
            this.Controls.Add(this.txt_cname);
            this.Controls.Add(this.txt_stockID);
            this.Controls.Add(this.txt_userID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "viewListing";
            this.Text = "viewListingcs";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_userID;
        private System.Windows.Forms.TextBox txt_stockID;
        private System.Windows.Forms.TextBox txt_cname;
        private System.Windows.Forms.TextBox txt_ctype;
        private System.Windows.Forms.TextBox txt_amount;
        private System.Windows.Forms.TextBox txt_price;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_offerPrice;
        private System.Windows.Forms.Button btn_offer;
        private System.Windows.Forms.Button btn_load;
        private System.Windows.Forms.Button button1;
    }
}