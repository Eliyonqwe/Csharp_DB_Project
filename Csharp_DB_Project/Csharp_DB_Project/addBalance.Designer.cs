namespace Csharp_DB_Project
{
    partial class addBalance
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
            this.txt_balance = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_minus = new System.Windows.Forms.PictureBox();
            this.btn_plus = new System.Windows.Forms.PictureBox();
            this.btn_update = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.btn_minus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_plus)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_balance
            // 
            this.txt_balance.Location = new System.Drawing.Point(379, 102);
            this.txt_balance.Multiline = true;
            this.txt_balance.Name = "txt_balance";
            this.txt_balance.Size = new System.Drawing.Size(233, 28);
            this.txt_balance.TabIndex = 64;
            this.txt_balance.TextChanged += new System.EventHandler(this.txt_balance_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(201, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(163, 28);
            this.label4.TabIndex = 63;
            this.label4.Text = "Current Balance";
            // 
            // btn_minus
            // 
            this.btn_minus.Image = global::Csharp_DB_Project.Properties.Resources.Screenshot__16_;
            this.btn_minus.Location = new System.Drawing.Point(638, 127);
            this.btn_minus.Name = "btn_minus";
            this.btn_minus.Size = new System.Drawing.Size(30, 30);
            this.btn_minus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_minus.TabIndex = 66;
            this.btn_minus.TabStop = false;
            this.btn_minus.Click += new System.EventHandler(this.btn_minus_Click);
            // 
            // btn_plus
            // 
            this.btn_plus.Image = global::Csharp_DB_Project.Properties.Resources.Screenshot__15_;
            this.btn_plus.Location = new System.Drawing.Point(638, 76);
            this.btn_plus.Name = "btn_plus";
            this.btn_plus.Size = new System.Drawing.Size(30, 30);
            this.btn_plus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_plus.TabIndex = 65;
            this.btn_plus.TabStop = false;
            this.btn_plus.Click += new System.EventHandler(this.btn_plus_Click);
            // 
            // btn_update
            // 
            this.btn_update.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_update.Location = new System.Drawing.Point(417, 238);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(141, 60);
            this.btn_update.TabIndex = 71;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = false;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // addBalance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 536);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_minus);
            this.Controls.Add(this.btn_plus);
            this.Controls.Add(this.txt_balance);
            this.Controls.Add(this.label4);
            this.Name = "addBalance";
            this.Text = "addBalancecs";
            ((System.ComponentModel.ISupportInitialize)(this.btn_minus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_plus)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_balance;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox btn_plus;
        private System.Windows.Forms.PictureBox btn_minus;
        private System.Windows.Forms.Button btn_update;
    }
}