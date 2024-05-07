namespace Dine360.View.Login
{
    partial class formLogin
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblCopyright = new System.Windows.Forms.Label();
            this.btnBypass = new System.Windows.Forms.Panel();
            this.btnLogin = new Guna.UI2.WinForms.Guna2Button();
            this.txtPhoneNumber = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtUsername = new Guna.UI2.WinForms.Guna2TextBox();
            this.pnlSub = new System.Windows.Forms.Panel();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.lblLogo = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblCompanytitle = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.picBoxLoadingGIF = new System.Windows.Forms.PictureBox();
            this.btnClose = new Guna.UI2.WinForms.Guna2TileButton();
            this.btnLogo = new Guna.UI2.WinForms.Guna2Button();
            this.pcbLoginLogo = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            this.btnBypass.SuspendLayout();
            this.pnlSub.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLoadingGIF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLoginLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(57)))), ((int)(((byte)(78)))));
            this.panel3.Controls.Add(this.lblCopyright);
            this.panel3.Location = new System.Drawing.Point(0, 726);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1024, 40);
            this.panel3.TabIndex = 43;
            // 
            // lblCopyright
            // 
            this.lblCopyright.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblCopyright.AutoSize = true;
            this.lblCopyright.ForeColor = System.Drawing.Color.White;
            this.lblCopyright.Location = new System.Drawing.Point(358, 16);
            this.lblCopyright.Name = "lblCopyright";
            this.lblCopyright.Size = new System.Drawing.Size(310, 13);
            this.lblCopyright.TabIndex = 2;
            this.lblCopyright.Text = "© 2018-2024 APP360 (PVT) Ltd. Software. All Rights Reserved.";
            // 
            // btnBypass
            // 
            this.btnBypass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBypass.Controls.Add(this.btnLogin);
            this.btnBypass.Controls.Add(this.txtPhoneNumber);
            this.btnBypass.Controls.Add(this.txtUsername);
            this.btnBypass.Controls.Add(this.pnlSub);
            this.btnBypass.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnBypass.Location = new System.Drawing.Point(0, 0);
            this.btnBypass.Name = "btnBypass";
            this.btnBypass.Size = new System.Drawing.Size(1024, 768);
            this.btnBypass.TabIndex = 1;
            // 
            // btnLogin
            // 
            this.btnLogin.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(65)))), ((int)(((byte)(88)))));
            this.btnLogin.BorderRadius = 5;
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLogin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLogin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLogin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLogin.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(65)))), ((int)(((byte)(88)))));
            this.btnLogin.FocusedColor = System.Drawing.Color.Aqua;
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.IndicateFocus = true;
            this.btnLogin.Location = new System.Drawing.Point(368, 574);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(295, 50);
            this.btnLogin.TabIndex = 33;
            this.btnLogin.Text = "Sign in";
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtPhoneNumber.BorderColor = System.Drawing.Color.Silver;
            this.txtPhoneNumber.BorderRadius = 5;
            this.txtPhoneNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPhoneNumber.DefaultText = "";
            this.txtPhoneNumber.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPhoneNumber.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPhoneNumber.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPhoneNumber.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPhoneNumber.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhoneNumber.ForeColor = System.Drawing.Color.Black;
            this.txtPhoneNumber.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPhoneNumber.Location = new System.Drawing.Point(368, 525);
            this.txtPhoneNumber.Margin = new System.Windows.Forms.Padding(5);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.PasswordChar = '●';
            this.txtPhoneNumber.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.txtPhoneNumber.PlaceholderText = "Type Password";
            this.txtPhoneNumber.SelectedText = "";
            this.txtPhoneNumber.Size = new System.Drawing.Size(295, 35);
            this.txtPhoneNumber.TabIndex = 32;
            // 
            // txtUsername
            // 
            this.txtUsername.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtUsername.BorderColor = System.Drawing.Color.Silver;
            this.txtUsername.BorderRadius = 5;
            this.txtUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUsername.DefaultText = "";
            this.txtUsername.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtUsername.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtUsername.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUsername.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUsername.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.ForeColor = System.Drawing.Color.Black;
            this.txtUsername.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUsername.Location = new System.Drawing.Point(368, 450);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(5);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.PasswordChar = '\0';
            this.txtUsername.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.txtUsername.PlaceholderText = "Type username";
            this.txtUsername.SelectedText = "";
            this.txtUsername.Size = new System.Drawing.Size(295, 35);
            this.txtUsername.TabIndex = 31;
            // 
            // pnlSub
            // 
            this.pnlSub.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(28)))), ((int)(((byte)(50)))));
            this.pnlSub.Controls.Add(this.label2);
            this.pnlSub.Controls.Add(this.picBoxLoadingGIF);
            this.pnlSub.Controls.Add(this.btnClose);
            this.pnlSub.Controls.Add(this.guna2Button1);
            this.pnlSub.Controls.Add(this.btnLogo);
            this.pnlSub.Controls.Add(this.lblLogo);
            this.pnlSub.Controls.Add(this.lblUsername);
            this.pnlSub.Controls.Add(this.lblCompanytitle);
            this.pnlSub.Controls.Add(this.lblPassword);
            this.pnlSub.Controls.Add(this.panel3);
            this.pnlSub.Controls.Add(this.pcbLoginLogo);
            this.pnlSub.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSub.Location = new System.Drawing.Point(0, 0);
            this.pnlSub.Name = "pnlSub";
            this.pnlSub.Size = new System.Drawing.Size(1024, 768);
            this.pnlSub.TabIndex = 48;
            // 
            // guna2Button1
            // 
            this.guna2Button1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.guna2Button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(56)))), ((int)(((byte)(187)))));
            this.guna2Button1.BorderRadius = 5;
            this.guna2Button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(56)))), ((int)(((byte)(187)))));
            this.guna2Button1.FocusedColor = System.Drawing.Color.Aqua;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.IndicateFocus = true;
            this.guna2Button1.Location = new System.Drawing.Point(368, 630);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(295, 50);
            this.guna2Button1.TabIndex = 44;
            this.guna2Button1.Text = "Sign in(Bypass)";
            // 
            // lblLogo
            // 
            this.lblLogo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblLogo.BackColor = System.Drawing.Color.Transparent;
            this.lblLogo.Font = new System.Drawing.Font("Lucida Bright", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogo.ForeColor = System.Drawing.Color.White;
            this.lblLogo.Location = new System.Drawing.Point(3, 343);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(1018, 39);
            this.lblLogo.TabIndex = 47;
            this.lblLogo.Text = "DINE360";
            this.lblLogo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblUsername
            // 
            this.lblUsername.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblUsername.AutoSize = true;
            this.lblUsername.BackColor = System.Drawing.Color.Transparent;
            this.lblUsername.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.ForeColor = System.Drawing.Color.White;
            this.lblUsername.Location = new System.Drawing.Point(364, 424);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(83, 21);
            this.lblUsername.TabIndex = 35;
            this.lblUsername.Text = "Username";
            // 
            // lblCompanytitle
            // 
            this.lblCompanytitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblCompanytitle.BackColor = System.Drawing.Color.Transparent;
            this.lblCompanytitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompanytitle.ForeColor = System.Drawing.Color.White;
            this.lblCompanytitle.Location = new System.Drawing.Point(3, 311);
            this.lblCompanytitle.Name = "lblCompanytitle";
            this.lblCompanytitle.Size = new System.Drawing.Size(1021, 32);
            this.lblCompanytitle.TabIndex = 42;
            this.lblCompanytitle.Text = "{Company - Branch}";
            this.lblCompanytitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPassword
            // 
            this.lblPassword.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblPassword.AutoSize = true;
            this.lblPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblPassword.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.ForeColor = System.Drawing.Color.White;
            this.lblPassword.Location = new System.Drawing.Point(364, 499);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(79, 21);
            this.lblPassword.TabIndex = 37;
            this.lblPassword.Text = "Password";
            // 
            // picBoxLoadingGIF
            // 
            this.picBoxLoadingGIF.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.picBoxLoadingGIF.BackColor = System.Drawing.Color.Transparent;
            this.picBoxLoadingGIF.Image = global::Dine360.Properties.Resources.loading_gif;
            this.picBoxLoadingGIF.Location = new System.Drawing.Point(671, 525);
            this.picBoxLoadingGIF.Name = "picBoxLoadingGIF";
            this.picBoxLoadingGIF.Size = new System.Drawing.Size(33, 35);
            this.picBoxLoadingGIF.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxLoadingGIF.TabIndex = 46;
            this.picBoxLoadingGIF.TabStop = false;
            this.picBoxLoadingGIF.Visible = false;
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
            this.btnClose.Location = new System.Drawing.Point(989, 7);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(28, 25);
            this.btnClose.TabIndex = 48;
            // 
            // btnLogo
            // 
            this.btnLogo.BackColor = System.Drawing.Color.Transparent;
            this.btnLogo.BorderRadius = 7;
            this.btnLogo.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLogo.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLogo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLogo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLogo.FillColor = System.Drawing.Color.White;
            this.btnLogo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnLogo.ForeColor = System.Drawing.Color.White;
            this.btnLogo.Image = global::Dine360.Properties.Resources.App360Logo;
            this.btnLogo.ImageSize = new System.Drawing.Size(80, 18);
            this.btnLogo.Location = new System.Drawing.Point(8, 7);
            this.btnLogo.Name = "btnLogo";
            this.btnLogo.Size = new System.Drawing.Size(84, 31);
            this.btnLogo.TabIndex = 45;
            // 
            // pcbLoginLogo
            // 
            this.pcbLoginLogo.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.pcbLoginLogo.BackColor = System.Drawing.Color.Transparent;
            this.pcbLoginLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pcbLoginLogo.Location = new System.Drawing.Point(2, 57);
            this.pcbLoginLogo.Name = "pcbLoginLogo";
            this.pcbLoginLogo.Size = new System.Drawing.Size(1021, 234);
            this.pcbLoginLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbLoginLogo.TabIndex = 41;
            this.pcbLoginLogo.TabStop = false;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(0, 378);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1025, 31);
            this.label2.TabIndex = 49;
            this.label2.Text = "{Envioronment}";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // formLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 768);
            this.Controls.Add(this.btnBypass);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "formLogin";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.btnBypass.ResumeLayout(false);
            this.pnlSub.ResumeLayout(false);
            this.pnlSub.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLoadingGIF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLoginLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblCopyright;
        private System.Windows.Forms.Panel btnBypass;
        private System.Windows.Forms.PictureBox picBoxLoadingGIF;
        private System.Windows.Forms.Label lblLogo;
        private Guna.UI2.WinForms.Guna2Button btnLogo;
        private System.Windows.Forms.Label lblCompanytitle;
        private System.Windows.Forms.Label lblUsername;
        private Guna.UI2.WinForms.Guna2Button btnLogin;
        private System.Windows.Forms.Label lblPassword;
        public Guna.UI2.WinForms.Guna2TextBox txtPhoneNumber;
        public Guna.UI2.WinForms.Guna2TextBox txtUsername;
        private System.Windows.Forms.PictureBox pcbLoginLogo;
        private System.Windows.Forms.Panel pnlSub;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2TileButton btnClose;
        private System.Windows.Forms.Label label2;
    }
}