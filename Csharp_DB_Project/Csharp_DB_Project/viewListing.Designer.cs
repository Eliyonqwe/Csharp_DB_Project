namespace Csharp_DB_Project
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
            this.label7 = new System.Windows.Forms.Label();
            this.txt_offerPrice = new System.Windows.Forms.TextBox();
            this.btn_offer = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.display_panel = new System.Windows.Forms.FlowLayoutPanel();
            this.txt_price = new System.Windows.Forms.TextBox();
            this.txt_amount = new System.Windows.Forms.TextBox();
            this.txt_ctype = new System.Windows.Forms.TextBox();
            this.txt_cname = new System.Windows.Forms.TextBox();
            this.txt_stockID = new System.Windows.Forms.TextBox();
            this.txt_userID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.title = new System.Windows.Forms.Label();
            this.search_btn = new System.Windows.Forms.PictureBox();
            this.search_txt = new System.Windows.Forms.TextBox();
            this.displayLsitings1 = new Csharp_DB_Project.displayLsitingsControl();
            this.display_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.search_btn)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Location = new System.Drawing.Point(577, 546);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(166, 23);
            this.label7.TabIndex = 13;
            this.label7.Text = "Offering Price: ";
            // 
            // txt_offerPrice
            // 
            this.txt_offerPrice.Location = new System.Drawing.Point(749, 548);
            this.txt_offerPrice.Name = "txt_offerPrice";
            this.txt_offerPrice.Size = new System.Drawing.Size(190, 22);
            this.txt_offerPrice.TabIndex = 14;
            // 
            // btn_offer
            // 
            this.btn_offer.Location = new System.Drawing.Point(634, 613);
            this.btn_offer.Name = "btn_offer";
            this.btn_offer.Size = new System.Drawing.Size(93, 50);
            this.btn_offer.TabIndex = 15;
            this.btn_offer.Text = "Offer";
            this.btn_offer.UseVisualStyleBackColor = true;
            this.btn_offer.Click += new System.EventHandler(this.btn_offer_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.RosyBrown;
            this.button1.Location = new System.Drawing.Point(761, 612);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 54);
            this.button1.TabIndex = 17;
            this.button1.Text = "Back To HomePage";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // display_panel
            // 
            this.display_panel.AutoScroll = true;
            this.display_panel.BackColor = System.Drawing.Color.Transparent;
            this.display_panel.Controls.Add(this.displayLsitings1);
            this.display_panel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.display_panel.Location = new System.Drawing.Point(125, 108);
            this.display_panel.Margin = new System.Windows.Forms.Padding(4);
            this.display_panel.Name = "display_panel";
            this.display_panel.Size = new System.Drawing.Size(838, 305);
            this.display_panel.TabIndex = 19;
            this.display_panel.WrapContents = false;
            this.display_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.display_panel_Paint);
            // 
            // txt_price
            // 
            this.txt_price.BackColor = System.Drawing.SystemColors.ControlDark;
            this.txt_price.Location = new System.Drawing.Point(271, 594);
            this.txt_price.Name = "txt_price";
            this.txt_price.ReadOnly = true;
            this.txt_price.Size = new System.Drawing.Size(288, 22);
            this.txt_price.TabIndex = 33;
            // 
            // txt_amount
            // 
            this.txt_amount.BackColor = System.Drawing.SystemColors.ControlDark;
            this.txt_amount.Location = new System.Drawing.Point(271, 639);
            this.txt_amount.Name = "txt_amount";
            this.txt_amount.ReadOnly = true;
            this.txt_amount.Size = new System.Drawing.Size(288, 22);
            this.txt_amount.TabIndex = 32;
            // 
            // txt_ctype
            // 
            this.txt_ctype.BackColor = System.Drawing.SystemColors.ControlDark;
            this.txt_ctype.Location = new System.Drawing.Point(271, 593);
            this.txt_ctype.Name = "txt_ctype";
            this.txt_ctype.ReadOnly = true;
            this.txt_ctype.Size = new System.Drawing.Size(288, 22);
            this.txt_ctype.TabIndex = 31;
            // 
            // txt_cname
            // 
            this.txt_cname.BackColor = System.Drawing.SystemColors.ControlDark;
            this.txt_cname.Location = new System.Drawing.Point(271, 550);
            this.txt_cname.Name = "txt_cname";
            this.txt_cname.ReadOnly = true;
            this.txt_cname.Size = new System.Drawing.Size(288, 22);
            this.txt_cname.TabIndex = 30;
            // 
            // txt_stockID
            // 
            this.txt_stockID.BackColor = System.Drawing.SystemColors.ControlDark;
            this.txt_stockID.Location = new System.Drawing.Point(271, 507);
            this.txt_stockID.Name = "txt_stockID";
            this.txt_stockID.ReadOnly = true;
            this.txt_stockID.Size = new System.Drawing.Size(288, 22);
            this.txt_stockID.TabIndex = 29;
            // 
            // txt_userID
            // 
            this.txt_userID.BackColor = System.Drawing.SystemColors.ControlDark;
            this.txt_userID.Location = new System.Drawing.Point(271, 462);
            this.txt_userID.Name = "txt_userID";
            this.txt_userID.ReadOnly = true;
            this.txt_userID.Size = new System.Drawing.Size(288, 22);
            this.txt_userID.TabIndex = 28;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(90, 589);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(139, 23);
            this.label6.TabIndex = 27;
            this.label6.Text = "Selling Price";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(90, 635);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 23);
            this.label5.TabIndex = 26;
            this.label5.Text = "Amount";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(90, 589);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(159, 23);
            this.label4.TabIndex = 25;
            this.label4.Text = "Company Type";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(90, 546);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 23);
            this.label3.TabIndex = 24;
            this.label3.Text = "Company Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(90, 504);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 23);
            this.label2.TabIndex = 23;
            this.label2.Text = "stockID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(90, 459);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 23);
            this.label1.TabIndex = 22;
            this.label1.Text = "userID";
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.title.Font = new System.Drawing.Font("Cooper Black", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.title.Location = new System.Drawing.Point(12, 9);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(304, 32);
            this.title.TabIndex = 20;
            this.title.Text = "Listings you can buy";
            // 
            // search_btn
            // 
            this.search_btn.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.search_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.search_btn.Image = global::Csharp_DB_Project.Properties.Resources.My_project_1__15_;
            this.search_btn.Location = new System.Drawing.Point(824, 38);
            this.search_btn.Name = "search_btn";
            this.search_btn.Size = new System.Drawing.Size(43, 36);
            this.search_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.search_btn.TabIndex = 54;
            this.search_btn.TabStop = false;
            this.search_btn.Click += new System.EventHandler(this.search_btn_Click);
            // 
            // search_txt
            // 
            this.search_txt.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_txt.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.search_txt.Location = new System.Drawing.Point(560, 49);
            this.search_txt.Name = "search_txt";
            this.search_txt.Size = new System.Drawing.Size(258, 25);
            this.search_txt.TabIndex = 137;
            this.search_txt.Text = "search keyword";
            this.search_txt.Click += new System.EventHandler(this.search_txt_Click);
            // 
            // displayLsitings1
            // 
            this.displayLsitings1.amount = "                    Amount";
            this.displayLsitings1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.displayLsitings1.companyname = "                    Companyname";
            this.displayLsitings1.companytype = "                    Companytype";
            this.displayLsitings1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.displayLsitings1.Location = new System.Drawing.Point(3, 3);
            this.displayLsitings1.Name = "displayLsitings1";
            this.displayLsitings1.sellingprice = "                    Sellingprice";
            this.displayLsitings1.Size = new System.Drawing.Size(835, 273);
            this.displayLsitings1.stockid = "                    stockid";
            this.displayLsitings1.TabIndex = 18;
            this.displayLsitings1.userid = "                    userID";
            this.displayLsitings1.Load += new System.EventHandler(this.displayLsitings1_Load);
            // 
            // viewListing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Csharp_DB_Project.Properties.Resources.blue;
            this.ClientSize = new System.Drawing.Size(1123, 694);
            this.Controls.Add(this.search_txt);
            this.Controls.Add(this.txt_price);
            this.Controls.Add(this.search_btn);
            this.Controls.Add(this.title);
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
            this.Controls.Add(this.display_panel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_offer);
            this.Controls.Add(this.txt_offerPrice);
            this.Controls.Add(this.label7);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "viewListing";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "viewListingcs";
            this.Load += new System.EventHandler(this.viewListing_Load);
            this.display_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.search_btn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_offerPrice;
        private System.Windows.Forms.Button btn_offer;
        private System.Windows.Forms.Button button1;
        private displayLsitingsControl displayLsitings1;
        private System.Windows.Forms.FlowLayoutPanel display_panel;
        private System.Windows.Forms.TextBox txt_price;
        private System.Windows.Forms.TextBox txt_amount;
        private System.Windows.Forms.TextBox txt_ctype;
        private System.Windows.Forms.TextBox txt_cname;
        private System.Windows.Forms.TextBox txt_stockID;
        private System.Windows.Forms.TextBox txt_userID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label title;
        private System.Windows.Forms.PictureBox search_btn;
        private System.Windows.Forms.TextBox search_txt;
    }
}