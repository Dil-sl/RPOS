namespace Dine360.View.Main
{
    partial class formMain
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
            this.pnlAccount = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.pnlLeft = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.rBtnDashboard = new System.Windows.Forms.RadioButton();
            this.pnlTop = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlMain = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMinimize = new Guna.UI2.WinForms.Guna2TileButton();
            this.btnMaximize = new Guna.UI2.WinForms.Guna2TileButton();
            this.btnClose = new Guna.UI2.WinForms.Guna2TileButton();
            this.picBoxProfile = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.rBtnSettings = new System.Windows.Forms.RadioButton();
            this.rBtnPurchase = new System.Windows.Forms.RadioButton();
            this.rBtnReports = new System.Windows.Forms.RadioButton();
            this.rBtnStock = new System.Windows.Forms.RadioButton();
            this.rBtnRooms = new System.Windows.Forms.RadioButton();
            this.rBtnSales = new System.Windows.Forms.RadioButton();
            this.lblInternetStatus = new System.Windows.Forms.Label();
            this.pnlNetConnection = new Guna.UI2.WinForms.Guna2Panel();
            this.picBoxNetStatus = new System.Windows.Forms.PictureBox();
            this.lblCurrentTime = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlAccount.SuspendLayout();
            this.pnlLeft.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxProfile)).BeginInit();
            this.pnlNetConnection.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxNetStatus)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlAccount
            // 
            this.pnlAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(41)))), ((int)(((byte)(69)))));
            this.pnlAccount.BorderColor = System.Drawing.Color.Black;
            this.pnlAccount.BorderRadius = 8;
            this.pnlAccount.BorderThickness = 1;
            this.pnlAccount.Controls.Add(this.label1);
            this.pnlAccount.Controls.Add(this.picBoxProfile);
            this.pnlAccount.CustomBorderColor = System.Drawing.Color.Black;
            this.pnlAccount.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(28)))), ((int)(((byte)(50)))));
            this.pnlAccount.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(65)))), ((int)(((byte)(88)))));
            this.pnlAccount.Location = new System.Drawing.Point(655, 7);
            this.pnlAccount.Name = "pnlAccount";
            this.pnlAccount.Size = new System.Drawing.Size(198, 34);
            this.pnlAccount.TabIndex = 2;
            // 
            // pnlLeft
            // 
            this.pnlLeft.Controls.Add(this.rBtnSettings);
            this.pnlLeft.Controls.Add(this.rBtnPurchase);
            this.pnlLeft.Controls.Add(this.rBtnReports);
            this.pnlLeft.Controls.Add(this.rBtnStock);
            this.pnlLeft.Controls.Add(this.rBtnRooms);
            this.pnlLeft.Controls.Add(this.rBtnSales);
            this.pnlLeft.Controls.Add(this.rBtnDashboard);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(57)))), ((int)(((byte)(78)))));
            this.pnlLeft.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(57)))), ((int)(((byte)(78)))));
            this.pnlLeft.Location = new System.Drawing.Point(0, 0);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(64, 768);
            this.pnlLeft.TabIndex = 3;
            // 
            // rBtnDashboard
            // 
            this.rBtnDashboard.Appearance = System.Windows.Forms.Appearance.Button;
            this.rBtnDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(57)))), ((int)(((byte)(78)))));
            this.rBtnDashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rBtnDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.rBtnDashboard.FlatAppearance.BorderSize = 0;
            this.rBtnDashboard.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.rBtnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rBtnDashboard.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rBtnDashboard.ForeColor = System.Drawing.Color.White;
            this.rBtnDashboard.Location = new System.Drawing.Point(0, 0);
            this.rBtnDashboard.Name = "rBtnDashboard";
            this.rBtnDashboard.Size = new System.Drawing.Size(64, 48);
            this.rBtnDashboard.TabIndex = 1;
            this.rBtnDashboard.Text = "DINE360";
            this.rBtnDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rBtnDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.rBtnDashboard.UseVisualStyleBackColor = false;
            // 
            // pnlTop
            // 
            this.pnlTop.Controls.Add(this.label2);
            this.pnlTop.Controls.Add(this.pnlNetConnection);
            this.pnlTop.Controls.Add(this.lblInternetStatus);
            this.pnlTop.Controls.Add(this.pnlAccount);
            this.pnlTop.Controls.Add(this.panel1);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(28)))), ((int)(((byte)(50)))));
            this.pnlTop.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(20)))), ((int)(((byte)(36)))));
            this.pnlTop.Location = new System.Drawing.Point(64, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(960, 48);
            this.pnlTop.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.btnMinimize);
            this.panel1.Controls.Add(this.btnMaximize);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Location = new System.Drawing.Point(859, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(101, 28);
            this.panel1.TabIndex = 3;
            // 
            // pnlMain
            // 
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(28)))), ((int)(((byte)(50)))));
            this.pnlMain.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(20)))), ((int)(((byte)(36)))));
            this.pnlMain.Location = new System.Drawing.Point(64, 48);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(960, 720);
            this.pnlMain.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(36, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "{Sample User First Name}";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnMinimize
            // 
            this.btnMinimize.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnMinimize.CheckedState.FillColor = System.Drawing.Color.DarkGray;
            this.btnMinimize.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnMinimize.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnMinimize.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnMinimize.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnMinimize.FillColor = System.Drawing.Color.Transparent;
            this.btnMinimize.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnMinimize.ForeColor = System.Drawing.Color.White;
            this.btnMinimize.HoverState.BorderColor = System.Drawing.Color.Gray;
            this.btnMinimize.HoverState.FillColor = System.Drawing.Color.Silver;
            this.btnMinimize.Image = global::Dine360.Properties.Resources.minimize;
            this.btnMinimize.Location = new System.Drawing.Point(14, 1);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(28, 25);
            this.btnMinimize.TabIndex = 2;
            // 
            // btnMaximize
            // 
            this.btnMaximize.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnMaximize.CheckedState.FillColor = System.Drawing.Color.DarkGray;
            this.btnMaximize.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnMaximize.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnMaximize.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnMaximize.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnMaximize.FillColor = System.Drawing.Color.Transparent;
            this.btnMaximize.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnMaximize.ForeColor = System.Drawing.Color.White;
            this.btnMaximize.HoverState.BorderColor = System.Drawing.Color.Gray;
            this.btnMaximize.HoverState.FillColor = System.Drawing.Color.Silver;
            this.btnMaximize.Image = global::Dine360.Properties.Resources.maximize;
            this.btnMaximize.Location = new System.Drawing.Point(43, 2);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(28, 25);
            this.btnMaximize.TabIndex = 1;
            // 
            // btnClose
            // 
            this.btnClose.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnClose.CheckedState.FillColor = System.Drawing.Color.DarkGray;
            this.btnClose.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnClose.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnClose.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnClose.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnClose.FillColor = System.Drawing.Color.Transparent;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.HoverState.BorderColor = System.Drawing.Color.Gray;
            this.btnClose.HoverState.FillColor = System.Drawing.Color.Silver;
            this.btnClose.Image = global::Dine360.Properties.Resources.Close_white;
            this.btnClose.Location = new System.Drawing.Point(71, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(28, 25);
            this.btnClose.TabIndex = 0;
            // 
            // picBoxProfile
            // 
            this.picBoxProfile.BackColor = System.Drawing.Color.Transparent;
            this.picBoxProfile.Image = global::Dine360.Properties.Resources.UserPic;
            this.picBoxProfile.ImageRotate = 0F;
            this.picBoxProfile.Location = new System.Drawing.Point(3, 3);
            this.picBoxProfile.Name = "picBoxProfile";
            this.picBoxProfile.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.picBoxProfile.Size = new System.Drawing.Size(32, 29);
            this.picBoxProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxProfile.TabIndex = 0;
            this.picBoxProfile.TabStop = false;
            // 
            // rBtnSettings
            // 
            this.rBtnSettings.Appearance = System.Windows.Forms.Appearance.Button;
            this.rBtnSettings.BackColor = System.Drawing.Color.Transparent;
            this.rBtnSettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rBtnSettings.Dock = System.Windows.Forms.DockStyle.Top;
            this.rBtnSettings.FlatAppearance.BorderSize = 0;
            this.rBtnSettings.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.rBtnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rBtnSettings.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rBtnSettings.ForeColor = System.Drawing.Color.White;
            this.rBtnSettings.Image = global::Dine360.Properties.Resources.setting36;
            this.rBtnSettings.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.rBtnSettings.Location = new System.Drawing.Point(0, 368);
            this.rBtnSettings.Name = "rBtnSettings";
            this.rBtnSettings.Size = new System.Drawing.Size(64, 64);
            this.rBtnSettings.TabIndex = 7;
            this.rBtnSettings.Text = "Settings";
            this.rBtnSettings.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.rBtnSettings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.rBtnSettings.UseVisualStyleBackColor = false;
            // 
            // rBtnPurchase
            // 
            this.rBtnPurchase.Appearance = System.Windows.Forms.Appearance.Button;
            this.rBtnPurchase.BackColor = System.Drawing.Color.Transparent;
            this.rBtnPurchase.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rBtnPurchase.Dock = System.Windows.Forms.DockStyle.Top;
            this.rBtnPurchase.FlatAppearance.BorderSize = 0;
            this.rBtnPurchase.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.rBtnPurchase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rBtnPurchase.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rBtnPurchase.ForeColor = System.Drawing.Color.White;
            this.rBtnPurchase.Image = global::Dine360.Properties.Resources.cash;
            this.rBtnPurchase.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.rBtnPurchase.Location = new System.Drawing.Point(0, 304);
            this.rBtnPurchase.Name = "rBtnPurchase";
            this.rBtnPurchase.Size = new System.Drawing.Size(64, 64);
            this.rBtnPurchase.TabIndex = 6;
            this.rBtnPurchase.Text = "12345";
            this.rBtnPurchase.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.rBtnPurchase.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.rBtnPurchase.UseVisualStyleBackColor = false;
            // 
            // rBtnReports
            // 
            this.rBtnReports.Appearance = System.Windows.Forms.Appearance.Button;
            this.rBtnReports.BackColor = System.Drawing.Color.Transparent;
            this.rBtnReports.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rBtnReports.Dock = System.Windows.Forms.DockStyle.Top;
            this.rBtnReports.FlatAppearance.BorderSize = 0;
            this.rBtnReports.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.rBtnReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rBtnReports.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rBtnReports.ForeColor = System.Drawing.Color.White;
            this.rBtnReports.Image = global::Dine360.Properties.Resources.reports36;
            this.rBtnReports.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.rBtnReports.Location = new System.Drawing.Point(0, 240);
            this.rBtnReports.Name = "rBtnReports";
            this.rBtnReports.Size = new System.Drawing.Size(64, 64);
            this.rBtnReports.TabIndex = 5;
            this.rBtnReports.Text = "Reports";
            this.rBtnReports.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.rBtnReports.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.rBtnReports.UseVisualStyleBackColor = false;
            // 
            // rBtnStock
            // 
            this.rBtnStock.Appearance = System.Windows.Forms.Appearance.Button;
            this.rBtnStock.BackColor = System.Drawing.Color.Transparent;
            this.rBtnStock.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rBtnStock.Dock = System.Windows.Forms.DockStyle.Top;
            this.rBtnStock.FlatAppearance.BorderSize = 0;
            this.rBtnStock.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.rBtnStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rBtnStock.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rBtnStock.ForeColor = System.Drawing.Color.White;
            this.rBtnStock.Image = global::Dine360.Properties.Resources.Stock36;
            this.rBtnStock.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.rBtnStock.Location = new System.Drawing.Point(0, 176);
            this.rBtnStock.Name = "rBtnStock";
            this.rBtnStock.Size = new System.Drawing.Size(64, 64);
            this.rBtnStock.TabIndex = 4;
            this.rBtnStock.Text = "Stock";
            this.rBtnStock.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.rBtnStock.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.rBtnStock.UseVisualStyleBackColor = false;
            // 
            // rBtnRooms
            // 
            this.rBtnRooms.Appearance = System.Windows.Forms.Appearance.Button;
            this.rBtnRooms.BackColor = System.Drawing.Color.Transparent;
            this.rBtnRooms.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rBtnRooms.Dock = System.Windows.Forms.DockStyle.Top;
            this.rBtnRooms.FlatAppearance.BorderSize = 0;
            this.rBtnRooms.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.rBtnRooms.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rBtnRooms.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rBtnRooms.ForeColor = System.Drawing.Color.White;
            this.rBtnRooms.Image = global::Dine360.Properties.Resources.Rooms42;
            this.rBtnRooms.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.rBtnRooms.Location = new System.Drawing.Point(0, 112);
            this.rBtnRooms.Name = "rBtnRooms";
            this.rBtnRooms.Size = new System.Drawing.Size(64, 64);
            this.rBtnRooms.TabIndex = 3;
            this.rBtnRooms.Text = "Rooms";
            this.rBtnRooms.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.rBtnRooms.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.rBtnRooms.UseVisualStyleBackColor = false;
            // 
            // rBtnSales
            // 
            this.rBtnSales.Appearance = System.Windows.Forms.Appearance.Button;
            this.rBtnSales.BackColor = System.Drawing.Color.Transparent;
            this.rBtnSales.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rBtnSales.Dock = System.Windows.Forms.DockStyle.Top;
            this.rBtnSales.FlatAppearance.BorderSize = 0;
            this.rBtnSales.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.rBtnSales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rBtnSales.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rBtnSales.ForeColor = System.Drawing.Color.White;
            this.rBtnSales.Image = global::Dine360.Properties.Resources.sales42;
            this.rBtnSales.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.rBtnSales.Location = new System.Drawing.Point(0, 48);
            this.rBtnSales.Name = "rBtnSales";
            this.rBtnSales.Size = new System.Drawing.Size(64, 64);
            this.rBtnSales.TabIndex = 2;
            this.rBtnSales.Text = "Sales";
            this.rBtnSales.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.rBtnSales.UseVisualStyleBackColor = false;
            // 
            // lblInternetStatus
            // 
            this.lblInternetStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblInternetStatus.BackColor = System.Drawing.Color.Transparent;
            this.lblInternetStatus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblInternetStatus.ForeColor = System.Drawing.Color.White;
            this.lblInternetStatus.Location = new System.Drawing.Point(338, 17);
            this.lblInternetStatus.Name = "lblInternetStatus";
            this.lblInternetStatus.Size = new System.Drawing.Size(283, 15);
            this.lblInternetStatus.TabIndex = 30;
            this.lblInternetStatus.Text = "Disconnected";
            this.lblInternetStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblInternetStatus.Visible = false;
            // 
            // pnlNetConnection
            // 
            this.pnlNetConnection.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlNetConnection.BackColor = System.Drawing.Color.Transparent;
            this.pnlNetConnection.Controls.Add(this.picBoxNetStatus);
            this.pnlNetConnection.Controls.Add(this.lblCurrentTime);
            this.pnlNetConnection.Location = new System.Drawing.Point(164, 7);
            this.pnlNetConnection.Name = "pnlNetConnection";
            this.pnlNetConnection.Size = new System.Drawing.Size(106, 36);
            this.pnlNetConnection.TabIndex = 31;
            // 
            // picBoxNetStatus
            // 
            this.picBoxNetStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picBoxNetStatus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picBoxNetStatus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picBoxNetStatus.Location = new System.Drawing.Point(78, 8);
            this.picBoxNetStatus.Name = "picBoxNetStatus";
            this.picBoxNetStatus.Size = new System.Drawing.Size(17, 17);
            this.picBoxNetStatus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxNetStatus.TabIndex = 30;
            this.picBoxNetStatus.TabStop = false;
            // 
            // lblCurrentTime
            // 
            this.lblCurrentTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCurrentTime.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblCurrentTime.ForeColor = System.Drawing.Color.White;
            this.lblCurrentTime.Location = new System.Drawing.Point(-4, 10);
            this.lblCurrentTime.Name = "lblCurrentTime";
            this.lblCurrentTime.Size = new System.Drawing.Size(81, 18);
            this.lblCurrentTime.TabIndex = 28;
            this.lblCurrentTime.Text = "00:00:00 AM";
            this.lblCurrentTime.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(3, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 46);
            this.label2.TabIndex = 32;
            this.label2.Text = "{Envioronment}";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // formMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 768);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.pnlLeft);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "formMain";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(20)))));
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pnlAccount.ResumeLayout(false);
            this.pnlLeft.ResumeLayout(false);
            this.pnlTop.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxProfile)).EndInit();
            this.pnlNetConnection.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxNetStatus)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2GradientPanel pnlAccount;
        private Guna.UI2.WinForms.Guna2GradientPanel pnlLeft;
        private Guna.UI2.WinForms.Guna2GradientPanel pnlTop;
        private Guna.UI2.WinForms.Guna2GradientPanel pnlMain;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2TileButton btnClose;
        private Guna.UI2.WinForms.Guna2TileButton btnMinimize;
        private Guna.UI2.WinForms.Guna2TileButton btnMaximize;
        public System.Windows.Forms.RadioButton rBtnSettings;
        public System.Windows.Forms.RadioButton rBtnPurchase;
        public System.Windows.Forms.RadioButton rBtnReports;
        public System.Windows.Forms.RadioButton rBtnStock;
        public System.Windows.Forms.RadioButton rBtnRooms;
        public System.Windows.Forms.RadioButton rBtnSales;
        public System.Windows.Forms.RadioButton rBtnDashboard;
        private Guna.UI2.WinForms.Guna2CirclePictureBox picBoxProfile;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Panel pnlNetConnection;
        public System.Windows.Forms.PictureBox picBoxNetStatus;
        private System.Windows.Forms.Label lblCurrentTime;
        private System.Windows.Forms.Label lblInternetStatus;
        private System.Windows.Forms.Label label2;
    }
}