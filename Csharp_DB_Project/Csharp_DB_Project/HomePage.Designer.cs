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
            this.myProfileTimer = new System.Windows.Forms.Timer(this.components);
            this.myListingTImer = new System.Windows.Forms.Timer(this.components);
            this.sidebarTImer = new System.Windows.Forms.Timer(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.lb_welcome = new System.Windows.Forms.Label();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
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
            this.btn_myListing = new System.Windows.Forms.Button();
            this.btn_addListing = new System.Windows.Forms.Button();
            this.offerContainer = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.button5 = new System.Windows.Forms.Button();
            this.btn_viewOffer = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.orderContainer = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_orders = new System.Windows.Forms.Button();
            this.btn_orderRecieved = new System.Windows.Forms.Button();
            this.btn_orderSent = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.offerTimer = new System.Windows.Forms.Timer(this.components);
            this.orderTimer = new System.Windows.Forms.Timer(this.components);
            this.btn_logout = new System.Windows.Forms.Button();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
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
            this.offerContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.orderContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.SuspendLayout();
            // 
            // myProfileTimer
            // 
            this.myProfileTimer.Interval = 10;
            this.myProfileTimer.Tick += new System.EventHandler(this.myProfileTimer_Tick);
            // 
            // myListingTImer
            // 
            this.myListingTImer.Interval = 10;
            this.myListingTImer.Tick += new System.EventHandler(this.myListingTImer_Tick);
            // 
            // sidebarTImer
            // 
            this.sidebarTImer.Interval = 1;
            this.sidebarTImer.Tick += new System.EventHandler(this.sidebarTImer_Tick);
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = global::Csharp_DB_Project.Properties.Resources.My_project1;
            this.panel3.Controls.Add(this.btn_logout);
            this.panel3.Location = new System.Drawing.Point(365, 34);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1069, 702);
            this.panel3.TabIndex = 52;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint_1);
            // 
            // lb_welcome
            // 
            this.lb_welcome.AutoSize = true;
            this.lb_welcome.BackColor = System.Drawing.Color.Transparent;
            this.lb_welcome.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_welcome.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lb_welcome.Location = new System.Drawing.Point(375, 583);
            this.lb_welcome.Name = "lb_welcome";
            this.lb_welcome.Size = new System.Drawing.Size(222, 41);
            this.lb_welcome.TabIndex = 51;
            this.lb_welcome.Text = "Welcome back ";
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackColor = System.Drawing.Color.IndianRed;
            this.pictureBox8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox8.Image = global::Csharp_DB_Project.Properties.Resources.My_project_1__14_;
            this.pictureBox8.Location = new System.Drawing.Point(1355, 6);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(64, 22);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox8.TabIndex = 52;
            this.pictureBox8.TabStop = false;
            this.pictureBox8.Click += new System.EventHandler(this.pictureBox8_Click_1);
            // 
            // sidebarContainer
            // 
            this.sidebarContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.sidebarContainer.BackgroundImage = global::Csharp_DB_Project.Properties.Resources.blue;
            this.sidebarContainer.Controls.Add(this.panel1);
            this.sidebarContainer.Controls.Add(this.panel2);
            this.sidebarContainer.Controls.Add(this.myProfileContainer);
            this.sidebarContainer.Controls.Add(this.panel4);
            this.sidebarContainer.Controls.Add(this.myListingContainer);
            this.sidebarContainer.Controls.Add(this.offerContainer);
            this.sidebarContainer.Controls.Add(this.orderContainer);
            this.sidebarContainer.Controls.Add(this.panel6);
            this.sidebarContainer.Controls.Add(this.label2);
            this.sidebarContainer.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebarContainer.Location = new System.Drawing.Point(0, 0);
            this.sidebarContainer.MaximumSize = new System.Drawing.Size(267, 0);
            this.sidebarContainer.MinimumSize = new System.Drawing.Size(82, 0);
            this.sidebarContainer.Name = "sidebarContainer";
            this.sidebarContainer.Size = new System.Drawing.Size(267, 736);
            this.sidebarContainer.TabIndex = 51;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackgroundImage = global::Csharp_DB_Project.Properties.Resources.blue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.menuButton);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(264, 133);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Image = global::Csharp_DB_Project.Properties.Resources.blue;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(113, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 41);
            this.label1.TabIndex = 48;
            this.label1.Text = "Menu";
            // 
            // menuButton
            // 
            this.menuButton.BackColor = System.Drawing.Color.Transparent;
            this.menuButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menuButton.Image = global::Csharp_DB_Project.Properties.Resources.My_project__1_2;
            this.menuButton.Location = new System.Drawing.Point(-3, 51);
            this.menuButton.Name = "menuButton";
            this.menuButton.Size = new System.Drawing.Size(124, 41);
            this.menuButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.menuButton.TabIndex = 50;
            this.menuButton.TabStop = false;
            this.menuButton.Click += new System.EventHandler(this.menuButton_Click);
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::Csharp_DB_Project.Properties.Resources.blue;
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.btn_Home);
            this.panel2.Location = new System.Drawing.Point(3, 142);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(264, 68);
            this.panel2.TabIndex = 49;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = global::Csharp_DB_Project.Properties.Resources.My_project_1__8_;
            this.pictureBox2.Location = new System.Drawing.Point(15, 20);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(75, 33);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 51;
            this.pictureBox2.TabStop = false;
            // 
            // btn_Home
            // 
            this.btn_Home.BackColor = System.Drawing.Color.Transparent;
            this.btn_Home.BackgroundImage = global::Csharp_DB_Project.Properties.Resources.blue;
            this.btn_Home.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Home.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Home.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_Home.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Home.Location = new System.Drawing.Point(7, 9);
            this.btn_Home.Name = "btn_Home";
            this.btn_Home.Size = new System.Drawing.Size(246, 54);
            this.btn_Home.TabIndex = 48;
            this.btn_Home.Text = "                 Home";
            this.btn_Home.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Home.UseVisualStyleBackColor = false;
            this.btn_Home.Click += new System.EventHandler(this.btn_Home_Click);
            // 
            // myProfileContainer
            // 
            this.myProfileContainer.BackColor = System.Drawing.Color.Transparent;
            this.myProfileContainer.Controls.Add(this.btn_balance);
            this.myProfileContainer.Controls.Add(this.btn_editProfile);
            this.myProfileContainer.Controls.Add(this.pictureBox6);
            this.myProfileContainer.Controls.Add(this.btn_Profile);
            this.myProfileContainer.Location = new System.Drawing.Point(3, 216);
            this.myProfileContainer.MaximumSize = new System.Drawing.Size(264, 190);
            this.myProfileContainer.MinimumSize = new System.Drawing.Size(264, 68);
            this.myProfileContainer.Name = "myProfileContainer";
            this.myProfileContainer.Size = new System.Drawing.Size(264, 68);
            this.myProfileContainer.TabIndex = 58;
            // 
            // btn_balance
            // 
            this.btn_balance.BackColor = System.Drawing.Color.Transparent;
            this.btn_balance.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_balance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_balance.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btn_balance.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_balance.Location = new System.Drawing.Point(45, 132);
            this.btn_balance.Name = "btn_balance";
            this.btn_balance.Size = new System.Drawing.Size(210, 54);
            this.btn_balance.TabIndex = 57;
            this.btn_balance.Text = "   Balance";
            this.btn_balance.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_balance.UseVisualStyleBackColor = false;
            this.btn_balance.Click += new System.EventHandler(this.btn_balance_Click);
            // 
            // btn_editProfile
            // 
            this.btn_editProfile.BackColor = System.Drawing.Color.Transparent;
            this.btn_editProfile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_editProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_editProfile.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btn_editProfile.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_editProfile.Location = new System.Drawing.Point(45, 71);
            this.btn_editProfile.Name = "btn_editProfile";
            this.btn_editProfile.Size = new System.Drawing.Size(210, 54);
            this.btn_editProfile.TabIndex = 56;
            this.btn_editProfile.Text = "   Edit Profile";
            this.btn_editProfile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_editProfile.UseVisualStyleBackColor = false;
            this.btn_editProfile.Click += new System.EventHandler(this.btn_editProfile_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox6.Image = global::Csharp_DB_Project.Properties.Resources.My_project_1__9_;
            this.pictureBox6.Location = new System.Drawing.Point(15, 20);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(75, 33);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 55;
            this.pictureBox6.TabStop = false;
            // 
            // btn_Profile
            // 
            this.btn_Profile.BackColor = System.Drawing.Color.Transparent;
            this.btn_Profile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Profile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Profile.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Profile.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_Profile.Location = new System.Drawing.Point(7, 9);
            this.btn_Profile.Name = "btn_Profile";
            this.btn_Profile.Size = new System.Drawing.Size(246, 54);
            this.btn_Profile.TabIndex = 55;
            this.btn_Profile.Text = "                 My Profile";
            this.btn_Profile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Profile.UseVisualStyleBackColor = false;
            this.btn_Profile.Click += new System.EventHandler(this.btn_Profile_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.Controls.Add(this.pictureBox5);
            this.panel4.Controls.Add(this.btn_viewAllListing);
            this.panel4.Location = new System.Drawing.Point(3, 290);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(264, 87);
            this.panel4.TabIndex = 49;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox5.Image = global::Csharp_DB_Project.Properties.Resources.My_project_1__10_;
            this.pictureBox5.Location = new System.Drawing.Point(15, 20);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(75, 48);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 54;
            this.pictureBox5.TabStop = false;
            // 
            // btn_viewAllListing
            // 
            this.btn_viewAllListing.BackColor = System.Drawing.Color.Transparent;
            this.btn_viewAllListing.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_viewAllListing.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_viewAllListing.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_viewAllListing.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_viewAllListing.Location = new System.Drawing.Point(7, 9);
            this.btn_viewAllListing.Name = "btn_viewAllListing";
            this.btn_viewAllListing.Size = new System.Drawing.Size(245, 68);
            this.btn_viewAllListing.TabIndex = 48;
            this.btn_viewAllListing.Text = "                 View All                         Listings";
            this.btn_viewAllListing.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_viewAllListing.UseVisualStyleBackColor = false;
            this.btn_viewAllListing.Click += new System.EventHandler(this.btn_viewAllListing_Click);
            // 
            // myListingContainer
            // 
            this.myListingContainer.BackColor = System.Drawing.Color.Transparent;
            this.myListingContainer.Controls.Add(this.button8);
            this.myListingContainer.Controls.Add(this.pictureBox4);
            this.myListingContainer.Controls.Add(this.btn_myListing);
            this.myListingContainer.Controls.Add(this.btn_addListing);
            this.myListingContainer.Location = new System.Drawing.Point(3, 383);
            this.myListingContainer.MaximumSize = new System.Drawing.Size(264, 188);
            this.myListingContainer.MinimumSize = new System.Drawing.Size(264, 68);
            this.myListingContainer.Name = "myListingContainer";
            this.myListingContainer.Size = new System.Drawing.Size(264, 68);
            this.myListingContainer.TabIndex = 56;
            this.myListingContainer.Paint += new System.Windows.Forms.PaintEventHandler(this.myListingContainer_Paint);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.Transparent;
            this.button8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.button8.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button8.Location = new System.Drawing.Point(45, 132);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(210, 54);
            this.button8.TabIndex = 56;
            this.button8.Text = "   Edit my Listings";
            this.button8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.btn_editlising_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox4.Image = global::Csharp_DB_Project.Properties.Resources.My_project_1__11_;
            this.pictureBox4.Location = new System.Drawing.Point(15, 20);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(75, 33);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 53;
            this.pictureBox4.TabStop = false;
            // 
            // btn_myListing
            // 
            this.btn_myListing.BackColor = System.Drawing.Color.Transparent;
            this.btn_myListing.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_myListing.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_myListing.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_myListing.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_myListing.Location = new System.Drawing.Point(7, 9);
            this.btn_myListing.Name = "btn_myListing";
            this.btn_myListing.Size = new System.Drawing.Size(246, 54);
            this.btn_myListing.TabIndex = 48;
            this.btn_myListing.Text = "                 My Listings";
            this.btn_myListing.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_myListing.UseVisualStyleBackColor = false;
            this.btn_myListing.Click += new System.EventHandler(this.btn_myListing_Click);
            // 
            // btn_addListing
            // 
            this.btn_addListing.BackColor = System.Drawing.Color.Transparent;
            this.btn_addListing.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_addListing.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addListing.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btn_addListing.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_addListing.Location = new System.Drawing.Point(45, 71);
            this.btn_addListing.Name = "btn_addListing";
            this.btn_addListing.Size = new System.Drawing.Size(210, 54);
            this.btn_addListing.TabIndex = 54;
            this.btn_addListing.Text = "   Add Listing";
            this.btn_addListing.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_addListing.UseVisualStyleBackColor = false;
            this.btn_addListing.Click += new System.EventHandler(this.btn_addListing_Click);
            // 
            // offerContainer
            // 
            this.offerContainer.BackColor = System.Drawing.Color.Transparent;
            this.offerContainer.Controls.Add(this.pictureBox3);
            this.offerContainer.Controls.Add(this.button5);
            this.offerContainer.Controls.Add(this.btn_viewOffer);
            this.offerContainer.Controls.Add(this.button1);
            this.offerContainer.Location = new System.Drawing.Point(3, 457);
            this.offerContainer.MaximumSize = new System.Drawing.Size(264, 196);
            this.offerContainer.MinimumSize = new System.Drawing.Size(264, 68);
            this.offerContainer.Name = "offerContainer";
            this.offerContainer.Size = new System.Drawing.Size(264, 68);
            this.offerContainer.TabIndex = 55;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Image = global::Csharp_DB_Project.Properties.Resources.My_project_1__12_;
            this.pictureBox3.Location = new System.Drawing.Point(15, 20);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(75, 33);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 52;
            this.pictureBox3.TabStop = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Transparent;
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.button5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button5.Location = new System.Drawing.Point(45, 71);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(210, 54);
            this.button5.TabIndex = 48;
            this.button5.Text = "   Offers(Sent)";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // btn_viewOffer
            // 
            this.btn_viewOffer.BackColor = System.Drawing.Color.Transparent;
            this.btn_viewOffer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_viewOffer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_viewOffer.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btn_viewOffer.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_viewOffer.Location = new System.Drawing.Point(45, 132);
            this.btn_viewOffer.Name = "btn_viewOffer";
            this.btn_viewOffer.Size = new System.Drawing.Size(210, 54);
            this.btn_viewOffer.TabIndex = 55;
            this.btn_viewOffer.Text = "   Offers(Recieved)";
            this.btn_viewOffer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_viewOffer.UseVisualStyleBackColor = false;
            this.btn_viewOffer.Click += new System.EventHandler(this.viewOffer_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(7, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(246, 54);
            this.button1.TabIndex = 53;
            this.button1.Text = "                 Offers";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // orderContainer
            // 
            this.orderContainer.BackColor = System.Drawing.Color.Transparent;
            this.orderContainer.Controls.Add(this.pictureBox1);
            this.orderContainer.Controls.Add(this.btn_orders);
            this.orderContainer.Controls.Add(this.btn_orderRecieved);
            this.orderContainer.Controls.Add(this.btn_orderSent);
            this.orderContainer.Location = new System.Drawing.Point(3, 531);
            this.orderContainer.MaximumSize = new System.Drawing.Size(264, 190);
            this.orderContainer.MinimumSize = new System.Drawing.Size(264, 68);
            this.orderContainer.Name = "orderContainer";
            this.orderContainer.Size = new System.Drawing.Size(264, 68);
            this.orderContainer.TabIndex = 58;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::Csharp_DB_Project.Properties.Resources.My_project_1__12_;
            this.pictureBox1.Location = new System.Drawing.Point(15, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(75, 33);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 53;
            this.pictureBox1.TabStop = false;
            // 
            // btn_orders
            // 
            this.btn_orders.BackColor = System.Drawing.Color.Transparent;
            this.btn_orders.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_orders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_orders.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_orders.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_orders.Location = new System.Drawing.Point(7, 9);
            this.btn_orders.Name = "btn_orders";
            this.btn_orders.Size = new System.Drawing.Size(246, 54);
            this.btn_orders.TabIndex = 55;
            this.btn_orders.Text = "                 Orders";
            this.btn_orders.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_orders.UseVisualStyleBackColor = false;
            this.btn_orders.Click += new System.EventHandler(this.btn_orders_Click);
            // 
            // btn_orderRecieved
            // 
            this.btn_orderRecieved.BackColor = System.Drawing.Color.Transparent;
            this.btn_orderRecieved.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_orderRecieved.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_orderRecieved.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btn_orderRecieved.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_orderRecieved.Location = new System.Drawing.Point(37, 77);
            this.btn_orderRecieved.Name = "btn_orderRecieved";
            this.btn_orderRecieved.Size = new System.Drawing.Size(216, 54);
            this.btn_orderRecieved.TabIndex = 54;
            this.btn_orderRecieved.Text = "   Orders(recieved)";
            this.btn_orderRecieved.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_orderRecieved.UseVisualStyleBackColor = false;
            this.btn_orderRecieved.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_orderSent
            // 
            this.btn_orderSent.BackColor = System.Drawing.Color.Transparent;
            this.btn_orderSent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_orderSent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_orderSent.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btn_orderSent.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_orderSent.Location = new System.Drawing.Point(37, 133);
            this.btn_orderSent.Name = "btn_orderSent";
            this.btn_orderSent.Size = new System.Drawing.Size(216, 54);
            this.btn_orderSent.TabIndex = 48;
            this.btn_orderSent.Text = "   Orders(sent)";
            this.btn_orderSent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_orderSent.UseVisualStyleBackColor = false;
            this.btn_orderSent.Click += new System.EventHandler(this.btn_order_Click);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Transparent;
            this.panel6.Controls.Add(this.pictureBox7);
            this.panel6.Controls.Add(this.button2);
            this.panel6.Location = new System.Drawing.Point(3, 605);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(264, 68);
            this.panel6.TabIndex = 56;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox7.Image = global::Csharp_DB_Project.Properties.Resources.My_project_1__12_;
            this.pictureBox7.Location = new System.Drawing.Point(15, 20);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(75, 33);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 56;
            this.pictureBox7.TabStop = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button2.Location = new System.Drawing.Point(7, 9);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(246, 54);
            this.button2.TabIndex = 56;
            this.button2.Text = "                 About";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(3, 676);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 18);
            this.label2.TabIndex = 51;
            this.label2.Text = " © All RIghts Reserved";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Cooper Black", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(321, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 42);
            this.label3.TabIndex = 52;
            this.label3.Text = "Start";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Cooper Black", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(274, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(228, 42);
            this.label4.TabIndex = 53;
            this.label4.Text = "Trade Now";
            // 
            // offerTimer
            // 
            this.offerTimer.Interval = 10;
            this.offerTimer.Tick += new System.EventHandler(this.offerTimer_Tick);
            // 
            // orderTimer
            // 
            this.orderTimer.Interval = 10;
            this.orderTimer.Tick += new System.EventHandler(this.orderTimer_Tick);
            // 
            // btn_logout
            // 
            this.btn_logout.BackColor = System.Drawing.Color.IndianRed;
            this.btn_logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_logout.ForeColor = System.Drawing.Color.White;
            this.btn_logout.Location = new System.Drawing.Point(944, 643);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(110, 47);
            this.btn_logout.TabIndex = 53;
            this.btn_logout.Text = "Log Out";
            this.btn_logout.UseVisualStyleBackColor = false;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click_1);
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Csharp_DB_Project.Properties.Resources.blue;
            this.ClientSize = new System.Drawing.Size(1431, 736);
            this.Controls.Add(this.lb_welcome);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.sidebarContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(2000, 2000);
            this.Name = "HomePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HomePag";
            this.Load += new System.EventHandler(this.HomePage_Load);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
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
            this.offerContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.orderContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Button btn_balance;
        private System.Windows.Forms.Button btn_editProfile;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Panel myListingContainer;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button btn_viewOffer;
        private System.Windows.Forms.Button btn_myListing;
        private System.Windows.Forms.Button btn_addListing;
        private System.Windows.Forms.Button btn_viewAllListing;
        private System.Windows.Forms.Panel offerContainer;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button btn_orderSent;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Profile;
        private System.Windows.Forms.Panel myProfileContainer;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btn_Home;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox menuButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel sidebarContainer;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Timer myProfileTimer;
        private System.Windows.Forms.Timer myListingTImer;
        private System.Windows.Forms.Timer sidebarTImer;
        private System.Windows.Forms.Label lb_welcome;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.Button btn_orderRecieved;
        private System.Windows.Forms.Button btn_orders;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel orderContainer;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Timer offerTimer;
        private System.Windows.Forms.Timer orderTimer;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Button btn_logout;
    }
}