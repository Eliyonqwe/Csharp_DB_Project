namespace Csharp_DB_Project
{
    partial class viewOffer
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
            this.btn_load = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_accept = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_price = new System.Windows.Forms.TextBox();
            this.txt_companyType = new System.Windows.Forms.TextBox();
            this.txt_amount = new System.Windows.Forms.TextBox();
            this.txt_companyName = new System.Windows.Forms.TextBox();
            this.txt_offeramount = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(25, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(640, 277);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // btn_load
            // 
            this.btn_load.BackColor = System.Drawing.Color.YellowGreen;
            this.btn_load.Location = new System.Drawing.Point(60, 332);
            this.btn_load.Name = "btn_load";
            this.btn_load.Size = new System.Drawing.Size(126, 50);
            this.btn_load.TabIndex = 17;
            this.btn_load.Text = "Load the offers";
            this.btn_load.UseVisualStyleBackColor = false;
            this.btn_load.Click += new System.EventHandler(this.btn_load_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.RosyBrown;
            this.button1.Location = new System.Drawing.Point(462, 332);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 50);
            this.button1.TabIndex = 107;
            this.button1.Text = "Back To HomePage";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_accept
            // 
            this.btn_accept.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_accept.Location = new System.Drawing.Point(259, 332);
            this.btn_accept.Name = "btn_accept";
            this.btn_accept.Size = new System.Drawing.Size(126, 50);
            this.btn_accept.TabIndex = 108;
            this.btn_accept.Text = "Accept selected offer";
            this.btn_accept.UseVisualStyleBackColor = false;
            this.btn_accept.Click += new System.EventHandler(this.btn_accept_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(671, 236);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 28);
            this.label2.TabIndex = 112;
            this.label2.Text = "Askingprice(birr)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(671, 179);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 28);
            this.label1.TabIndex = 111;
            this.label1.Text = "Amount(birr)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(671, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 28);
            this.label4.TabIndex = 110;
            this.label4.Text = "Company type";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(671, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 28);
            this.label3.TabIndex = 109;
            this.label3.Text = "Company Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(671, 298);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 28);
            this.label5.TabIndex = 113;
            this.label5.Text = "offer amount";
            // 
            // txt_price
            // 
            this.txt_price.Location = new System.Drawing.Point(856, 223);
            this.txt_price.Multiline = true;
            this.txt_price.Name = "txt_price";
            this.txt_price.ReadOnly = true;
            this.txt_price.Size = new System.Drawing.Size(233, 28);
            this.txt_price.TabIndex = 117;
            // 
            // txt_companyType
            // 
            this.txt_companyType.Location = new System.Drawing.Point(856, 123);
            this.txt_companyType.Multiline = true;
            this.txt_companyType.Name = "txt_companyType";
            this.txt_companyType.ReadOnly = true;
            this.txt_companyType.Size = new System.Drawing.Size(233, 28);
            this.txt_companyType.TabIndex = 116;
            // 
            // txt_amount
            // 
            this.txt_amount.Location = new System.Drawing.Point(856, 173);
            this.txt_amount.Multiline = true;
            this.txt_amount.Name = "txt_amount";
            this.txt_amount.ReadOnly = true;
            this.txt_amount.Size = new System.Drawing.Size(233, 28);
            this.txt_amount.TabIndex = 115;
            // 
            // txt_companyName
            // 
            this.txt_companyName.Location = new System.Drawing.Point(856, 73);
            this.txt_companyName.Multiline = true;
            this.txt_companyName.Name = "txt_companyName";
            this.txt_companyName.ReadOnly = true;
            this.txt_companyName.Size = new System.Drawing.Size(233, 28);
            this.txt_companyName.TabIndex = 114;
            // 
            // txt_offeramount
            // 
            this.txt_offeramount.Location = new System.Drawing.Point(856, 298);
            this.txt_offeramount.Multiline = true;
            this.txt_offeramount.Name = "txt_offeramount";
            this.txt_offeramount.ReadOnly = true;
            this.txt_offeramount.Size = new System.Drawing.Size(233, 28);
            this.txt_offeramount.TabIndex = 118;
            // 
            // viewOffer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1266, 575);
            this.Controls.Add(this.txt_offeramount);
            this.Controls.Add(this.txt_price);
            this.Controls.Add(this.txt_companyType);
            this.Controls.Add(this.txt_amount);
            this.Controls.Add(this.txt_companyName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_accept);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_load);
            this.Controls.Add(this.dataGridView1);
            this.Name = "viewOffer";
            this.Text = "viewOffer";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_load;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_accept;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_price;
        private System.Windows.Forms.TextBox txt_companyType;
        private System.Windows.Forms.TextBox txt_amount;
        private System.Windows.Forms.TextBox txt_companyName;
        private System.Windows.Forms.TextBox txt_offeramount;
    }
}