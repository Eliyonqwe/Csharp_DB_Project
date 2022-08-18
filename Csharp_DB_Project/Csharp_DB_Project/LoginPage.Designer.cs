namespace Csharp_DB_Project
{
    partial class LoginPage
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
            this.label2 = new System.Windows.Forms.Label();
            this.txt_uname = new System.Windows.Forms.TextBox();
            this.txt_passwd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_login = new System.Windows.Forms.Button();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pic_usericon = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_usericon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.label2.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label2.Location = new System.Drawing.Point(680, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = "Log-in Page";
            // 
            // txt_uname
            // 
            this.txt_uname.BackColor = System.Drawing.Color.Silver;
            this.txt_uname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_uname.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txt_uname.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txt_uname.Location = new System.Drawing.Point(564, 241);
            this.txt_uname.Multiline = true;
            this.txt_uname.Name = "txt_uname";
            this.txt_uname.Size = new System.Drawing.Size(341, 29);
            this.txt_uname.TabIndex = 9;
            this.txt_uname.Text = "username";
            this.txt_uname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_passwd
            // 
            this.txt_passwd.BackColor = System.Drawing.Color.Silver;
            this.txt_passwd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_passwd.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txt_passwd.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txt_passwd.Location = new System.Drawing.Point(564, 317);
            this.txt_passwd.Multiline = true;
            this.txt_passwd.Name = "txt_passwd";
            this.txt_passwd.PasswordChar = '*';
            this.txt_passwd.Size = new System.Drawing.Size(341, 29);
            this.txt_passwd.TabIndex = 10;
            this.txt_passwd.Text = "Type Your Password";
            this.txt_passwd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_passwd.TextChanged += new System.EventHandler(this.txt_passwd_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.label3.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label3.Location = new System.Drawing.Point(625, 511);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 22);
            this.label3.TabIndex = 15;
            this.label3.Text = "New User?";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Orange;
            this.label4.Location = new System.Drawing.Point(737, 511);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 21);
            this.label4.TabIndex = 16;
            this.label4.Text = "Register Here";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // btn_login
            // 
            this.btn_login.BackColor = System.Drawing.Color.Orange;
            this.btn_login.BackgroundImage = global::Csharp_DB_Project.Properties.Resources.test;
            this.btn_login.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_login.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_login.Image = global::Csharp_DB_Project.Properties.Resources.test;
            this.btn_login.Location = new System.Drawing.Point(606, 405);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(269, 50);
            this.btn_login.TabIndex = 14;
            this.btn_login.Text = "Log In";
            this.btn_login.UseVisualStyleBackColor = false;
            this.btn_login.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = global::Csharp_DB_Project.Properties.Resources.this_is_a_graphic_reation_of_a_pad_lock_username_and_password_icon_115534595184fsadfncq61;
            this.pictureBox8.Location = new System.Drawing.Point(522, 312);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(29, 28);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox8.TabIndex = 13;
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::Csharp_DB_Project.Properties.Resources._469_4691153_png_file_svg_user_id_icon_transparent_png1;
            this.pictureBox7.Location = new System.Drawing.Point(522, 235);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(33, 28);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 12;
            this.pictureBox7.TabStop = false;
            this.pictureBox7.Click += new System.EventHandler(this.pictureBox7_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::Csharp_DB_Project.Properties.Resources.png_transparent_orange_button_blue_orange_button_blue_text_rectangle1;
            this.pictureBox6.Location = new System.Drawing.Point(580, 394);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(316, 85);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 11;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::Csharp_DB_Project.Properties.Resources.rounded;
            this.pictureBox5.Location = new System.Drawing.Point(559, 293);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(356, 58);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 8;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Csharp_DB_Project.Properties.Resources.rounded;
            this.pictureBox4.Location = new System.Drawing.Point(559, 216);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(356, 58);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 7;
            this.pictureBox4.TabStop = false;
            // 
            // pic_usericon
            // 
            this.pic_usericon.Image = global::Csharp_DB_Project.Properties.Resources.fantom1;
            this.pic_usericon.Location = new System.Drawing.Point(698, 64);
            this.pic_usericon.Name = "pic_usericon";
            this.pic_usericon.Size = new System.Drawing.Size(82, 79);
            this.pic_usericon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_usericon.TabIndex = 3;
            this.pic_usericon.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Csharp_DB_Project.Properties.Resources.Screenshot__11_;
            this.pictureBox2.Location = new System.Drawing.Point(114, 200);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(103, 67);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Constantia", 19.8F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Image = global::Csharp_DB_Project.Properties.Resources.orangepattern1;
            this.label1.Location = new System.Drawing.Point(221, 211);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 40);
            this.label1.TabIndex = 1;
            this.label1.Text = "The Score";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Csharp_DB_Project.Properties.Resources.orangepattern;
            this.pictureBox1.Location = new System.Drawing.Point(-213, -189);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(823, 870);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // LoginPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(950, 600);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.txt_passwd);
            this.Controls.Add(this.txt_uname);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pic_usericon);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_usericon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pic_usericon;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.TextBox txt_uname;
        private System.Windows.Forms.TextBox txt_passwd;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}