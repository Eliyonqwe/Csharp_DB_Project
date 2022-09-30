namespace Csharp_DB_Project
{
    partial class HomePage
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomePage));
            this.sidebarTImer = new System.Windows.Forms.Timer(this.components);
            this.myListingTImer = new System.Windows.Forms.Timer(this.components);
            this.myProfileTimer = new System.Windows.Forms.Timer(this.components);
            this.lb_Welcome = new System.Windows.Forms.Label();
            this.sidebarContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.menuButton = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btn_Home = new System.Windows.Forms.Button();
            this.myProfileContainer = new System.Windows.Forms.Panel();
            this.btn_balance = new System.Windows.Forms.Button();
            this.btn_editProfile = new System.Windows.Forms.Button();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.btn_Profile = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.btn_viewAllListing = new System.Windows.Forms.Button();
            this.myListingContainer = new System.Windows.Forms.Panel();
            this.button8 = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.button7 = new System.Windows.Forms.Button();
            this.btn_myListing = new System.Windows.Forms.Button();
            this.btn_addListing = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.button5 = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.sidebarContainer.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menuButton)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.myProfileContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.myListingContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.SuspendLayout();
            // 
            // sidebarTImer
            // 
            this.sidebarTImer.Interval = 1;
            this.sidebarTImer.Tick += new System.EventHandler(this.sidebarTimer_Tick);
            // 
            // myListingTImer
            // 
            this.myListingTImer.Interval = 10;
            this.myListingTImer.Tick += new System.EventHandler(this.myListingTImer_Tick);
            // 
            // myProfileTimer
            // 
            this.myProfileTimer.Interval = 10;
            this.myProfileTimer.Tick += new System.EventHandler(this.myProfileTimer_Tick);
            // 
            // lb_Welcome
            // 
            this.lb_Welcome.AutoSize = true;
            this.lb_Welcome.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Welcome.ForeColor = System.Drawing.Color.White;
            this.lb_Welcome.Image = global::Csharp_DB_Project.Properties.Resources._1000_F_96517407_L7uJrR5xOIxHuJ7IQsfLkOFCbwkryefA__1_;
            this.lb_Welcome.Location = new System.Drawing.Point(604, 89);
            this.lb_Welcome.Name = "lb_Welcome";
            this.lb_Welcome.Size = new System.Drawing.Size(0, 38);
            this.lb_Welcome.TabIndex = 48;
            // 
            // sidebarContainer
            // 
            this.sidebarContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.sidebarContainer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("sidebarContainer.BackgroundImage")));
            this.sidebarContainer.Controls.Add(this.panel1);
            this.sidebarContainer.Controls.Add(this.panel2);
            this.sidebarContainer.Controls.Add(this.myProfileContainer);
            this.sidebarContainer.Controls.Add(this.panel4);
            this.sidebarContainer.Controls.Add(this.myListingContainer);
            this.sidebarContainer.Controls.Add(this.panel5);
            this.sidebarContainer.Controls.Add(this.panel6);
            this.sidebarContainer.Controls.Add(this.label2);
            this.sidebarContainer.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebarContainer.Location = new System.Drawing.Point(0, 0);
            this.sidebarContainer.MaximumSize = new System.Drawing.Size(267, 638);
            this.sidebarContainer.MinimumSize = new System.Drawing.Size(82, 638);
            this.sidebarContainer.Name = "sidebarContainer";
            this.sidebarContainer.Size = new System.Drawing.Size(267, 638);
            this.sidebarContainer.TabIndex = 47;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.menuButton);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(264, 130);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Image = global::Csharp_DB_Project.Properties.Resources._1000_F_96517407_L7uJrR5xOIxHuJ7IQsfLkOFCbwkryefA__1_;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(78, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 41);
            this.label1.TabIndex = 48;
            this.label1.Text = "Menu";
            // 
            // menuButton
            // 
            this.menuButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menuButton.Image = global::Csharp_DB_Project.Properties.Resources.Screenshot__14_;
            this.menuButton.Location = new System.Drawing.Point(15, 53);
            this.menuButton.Name = "menuButton";
            this.menuButton.Size = new System.Drawing.Size(46, 50);
            this.menuButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.menuButton.TabIndex = 50;
            this.menuButton.TabStop = false;
            this.menuButton.Click += new System.EventHandler(this.menuButton_Click);
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.btn_Home);
            this.panel2.Location = new System.Drawing.Point(3, 139);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(264, 68);
            this.panel2.TabIndex = 49;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = global::Csharp_DB_Project.Properties.Resources.Screenshot__14_;
            this.pictureBox2.Location = new System.Drawing.Point(24, 22);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(33, 33);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 51;
            this.pictureBox2.TabStop = false;
            // 
            // btn_Home
            // 
            this.btn_Home.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_Home.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Home.BackgroundImage")));
            this.btn_Home.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Home.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Home.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_Home.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Home.Location = new System.Drawing.Point(9, 11);
            this.btn_Home.Name = "btn_Home";
            this.btn_Home.Size = new System.Drawing.Size(246, 54);
            this.btn_Home.TabIndex = 48;
            this.btn_Home.Text = "           Home";
            this.btn_Home.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Home.UseVisualStyleBackColor = false;
            this.btn_Home.Click += new System.EventHandler(this.button2_Click);
            // 
            // myProfileContainer
            // 
            this.myProfileContainer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("myProfileContainer.BackgroundImage")));
            this.myProfileContainer.Controls.Add(this.btn_balance);
            this.myProfileContainer.Controls.Add(this.btn_editProfile);
            this.myProfileContainer.Controls.Add(this.pictureBox6);
            this.myProfileContainer.Controls.Add(this.btn_Profile);
            this.myProfileContainer.Location = new System.Drawing.Point(3, 213);
            this.myProfileContainer.MaximumSize = new System.Drawing.Size(264, 190);
            this.myProfileContainer.MinimumSize = new System.Drawing.Size(264, 68);
            this.myProfileContainer.Name = "myProfileContainer";
            this.myProfileContainer.Size = new System.Drawing.Size(264, 68);
            this.myProfileContainer.TabIndex = 50;
            // 
            // btn_balance
            // 
            this.btn_balance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_balance.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_balance.BackgroundImage")));
            this.btn_balance.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_balance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_balance.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btn_balance.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_balance.Location = new System.Drawing.Point(15, 131);
            this.btn_balance.Name = "btn_balance";
            this.btn_balance.Size = new System.Drawing.Size(246, 54);
            this.btn_balance.TabIndex = 57;
            this.btn_balance.Text = "          - Add Balance";
            this.btn_balance.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_balance.UseVisualStyleBackColor = false;
            this.btn_balance.Click += new System.EventHandler(this.btn_balance_Click);
            // 
            // btn_editProfile
            // 
            this.btn_editProfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_editProfile.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_editProfile.BackgroundImage")));
            this.btn_editProfile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_editProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_editProfile.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btn_editProfile.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_editProfile.Location = new System.Drawing.Point(15, 71);
            this.btn_editProfile.Name = "btn_editProfile";
            this.btn_editProfile.Size = new System.Drawing.Size(246, 54);
            this.btn_editProfile.TabIndex = 56;
            this.btn_editProfile.Text = "          - Edit Profile";
            this.btn_editProfile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_editProfile.UseVisualStyleBackColor = false;
            this.btn_editProfile.Click += new System.EventHandler(this.btn_editProfile_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox6.Image = global::Csharp_DB_Project.Properties.Resources.Screenshot__14_;
            this.pictureBox6.Location = new System.Drawing.Point(23, 22);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(33, 33);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 55;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Click += new System.EventHandler(this.pictureBox6_Click);
            // 
            // btn_Profile
            // 
            this.btn_Profile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_Profile.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Profile.BackgroundImage")));
            this.btn_Profile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Profile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Profile.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Profile.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_Profile.Location = new System.Drawing.Point(9, 10);
            this.btn_Profile.Name = "btn_Profile";
            this.btn_Profile.Size = new System.Drawing.Size(246, 54);
            this.btn_Profile.TabIndex = 48;
            this.btn_Profile.Text = "           My Profile";
            this.btn_Profile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Profile.UseVisualStyleBackColor = false;
            this.btn_Profile.Click += new System.EventHandler(this.button3_Click);
            // 
            // panel4
            // 
            this.panel4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel4.BackgroundImage")));
            this.panel4.Controls.Add(this.pictureBox5);
            this.panel4.Controls.Add(this.btn_viewAllListing);
            this.panel4.Location = new System.Drawing.Point(3, 287);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(264, 68);
            this.panel4.TabIndex = 49;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox5.Image = global::Csharp_DB_Project.Properties.Resources.Screenshot__14_;
            this.pictureBox5.Location = new System.Drawing.Point(24, 17);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(33, 33);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 54;
            this.pictureBox5.TabStop = false;
            // 
            // btn_viewAllListing
            // 
            this.btn_viewAllListing.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_viewAllListing.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_viewAllListing.BackgroundImage")));
            this.btn_viewAllListing.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_viewAllListing.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_viewAllListing.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_viewAllListing.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_viewAllListing.Location = new System.Drawing.Point(9, 7);
            this.btn_viewAllListing.Name = "btn_viewAllListing";
            this.btn_viewAllListing.Size = new System.Drawing.Size(246, 54);
            this.btn_viewAllListing.TabIndex = 48;
            this.btn_viewAllListing.Text = "           View All Listings";
            this.btn_viewAllListing.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_viewAllListing.UseVisualStyleBackColor = false;
            this.btn_viewAllListing.Click += new System.EventHandler(this.btn_viewAllListing_Click);
            // 
            // myListingContainer
            // 
            this.myListingContainer.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.myListingContainer.BackgroundImage = global::Csharp_DB_Project.Properties.Resources._1000_F_96517407_L7uJrR5xOIxHuJ7IQsfLkOFCbwkryefA__1_;
            this.myListingContainer.Controls.Add(this.button8);
            this.myListingContainer.Controls.Add(this.pictureBox4);
            this.myListingContainer.Controls.Add(this.button7);
            this.myListingContainer.Controls.Add(this.btn_myListing);
            this.myListingContainer.Controls.Add(this.btn_addListing);
            this.myListingContainer.Location = new System.Drawing.Point(3, 361);
            this.myListingContainer.MaximumSize = new System.Drawing.Size(264, 245);
            this.myListingContainer.MinimumSize = new System.Drawing.Size(264, 68);
            this.myListingContainer.Name = "myListingContainer";
            this.myListingContainer.Size = new System.Drawing.Size(264, 68);
            this.myListingContainer.TabIndex = 56;
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button8.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button8.BackgroundImage")));
            this.button8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.button8.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button8.Location = new System.Drawing.Point(15, 129);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(246, 54);
            this.button8.TabIndex = 56;
            this.button8.Text = "          - Edit my Listings";
            this.button8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button8.UseVisualStyleBackColor = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox4.Image = global::Csharp_DB_Project.Properties.Resources.Screenshot__14_;
            this.pictureBox4.Location = new System.Drawing.Point(24, 19);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(33, 33);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 53;
            this.pictureBox4.TabStop = false;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button7.BackgroundImage")));
            this.button7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.button7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button7.Location = new System.Drawing.Point(15, 189);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(246, 54);
            this.button7.TabIndex = 55;
            this.button7.Text = "          - View Offers ";
            this.button7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button7.UseVisualStyleBackColor = false;
            // 
            // btn_myListing
            // 
            this.btn_myListing.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_myListing.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_myListing.BackgroundImage")));
            this.btn_myListing.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_myListing.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_myListing.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_myListing.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_myListing.Location = new System.Drawing.Point(9, 7);
            this.btn_myListing.Name = "btn_myListing";
            this.btn_myListing.Size = new System.Drawing.Size(246, 54);
            this.btn_myListing.TabIndex = 48;
            this.btn_myListing.Text = "           My Listings";
            this.btn_myListing.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_myListing.UseVisualStyleBackColor = false;
            this.btn_myListing.Click += new System.EventHandler(this.button6_Click);
            // 
            // btn_addListing
            // 
            this.btn_addListing.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_addListing.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_addListing.BackgroundImage")));
            this.btn_addListing.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_addListing.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addListing.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btn_addListing.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_addListing.Location = new System.Drawing.Point(15, 67);
            this.btn_addListing.Name = "btn_addListing";
            this.btn_addListing.Size = new System.Drawing.Size(246, 54);
            this.btn_addListing.TabIndex = 54;
            this.btn_addListing.Text = "          - Add Listing";
            this.btn_addListing.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_addListing.UseVisualStyleBackColor = false;
            this.btn_addListing.Click += new System.EventHandler(this.btn_addListing_Click);
            // 
            // panel5
            // 
            this.panel5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel5.BackgroundImage")));
            this.panel5.Controls.Add(this.pictureBox3);
            this.panel5.Controls.Add(this.button5);
            this.panel5.Location = new System.Drawing.Point(3, 435);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(264, 68);
            this.panel5.TabIndex = 55;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Image = global::Csharp_DB_Project.Properties.Resources.Screenshot__14_;
            this.pictureBox3.Location = new System.Drawing.Point(24, 22);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(33, 33);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 52;
            this.pictureBox3.TabStop = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button5.BackgroundImage")));
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button5.Location = new System.Drawing.Point(9, 11);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(246, 54);
            this.button5.TabIndex = 48;
            this.button5.Text = "           My Offers";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.UseVisualStyleBackColor = false;
            // 
            // panel6
            // 
            this.panel6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel6.BackgroundImage")));
            this.panel6.Controls.Add(this.pictureBox7);
            this.panel6.Controls.Add(this.button1);
            this.panel6.Location = new System.Drawing.Point(3, 509);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(264, 68);
            this.panel6.TabIndex = 56;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox7.Image = global::Csharp_DB_Project.Properties.Resources.Screenshot__14_;
            this.pictureBox7.Location = new System.Drawing.Point(23, 16);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(33, 33);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 53;
            this.pictureBox7.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(9, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(246, 54);
            this.button1.TabIndex = 48;
            this.button1.Text = "           About";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(3, 580);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 18);
            this.label2.TabIndex = 51;
            this.label2.Text = " © All RIghts Reserved";
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1159, 638);
            this.Controls.Add(this.lb_Welcome);
            this.Controls.Add(this.sidebarContainer);
            this.Name = "HomePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.sidebarContainer.ResumeLayout(false);
            this.sidebarContainer.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menuButton)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.myProfileContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.myListingContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel sidebarContainer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Home;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_Profile;
        private System.Windows.Forms.Panel myProfileContainer;
        private System.Windows.Forms.Button btn_viewAllListing;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btn_myListing;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox menuButton;
        private System.Windows.Forms.Timer sidebarTImer;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Panel myListingContainer;
        private System.Windows.Forms.Button btn_addListing;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Timer myListingTImer;
        private System.Windows.Forms.Button btn_balance;
        private System.Windows.Forms.Button btn_editProfile;
        private System.Windows.Forms.Timer myProfileTimer;
        private System.Windows.Forms.Label lb_Welcome;
    }
}