namespace simpleLoginWindows
{
	partial class UserProfile_FRM
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserProfile_FRM));
			this.panel1 = new System.Windows.Forms.Panel();
			this.Reset_BTN = new System.Windows.Forms.Button();
			this.UserPhone_TB = new System.Windows.Forms.TextBox();
			this.UserPhone_LBL = new System.Windows.Forms.Label();
			this.UserEmail_TB = new System.Windows.Forms.TextBox();
			this.UserEmail_LBL = new System.Windows.Forms.Label();
			this.UserName_TB = new System.Windows.Forms.TextBox();
			this.UserName_LBL = new System.Windows.Forms.Label();
			this.UserFullName_TB = new System.Windows.Forms.TextBox();
			this.UserFullName_LBL = new System.Windows.Forms.Label();
			this.UserId_TB = new System.Windows.Forms.TextBox();
			this.UserId_LBL = new System.Windows.Forms.Label();
			this.LogoFrame_PNL = new System.Windows.Forms.Panel();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.panel1.SuspendLayout();
			this.LogoFrame_PNL.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.Ivory;
			this.panel1.Controls.Add(this.Reset_BTN);
			this.panel1.Controls.Add(this.UserPhone_TB);
			this.panel1.Controls.Add(this.UserPhone_LBL);
			this.panel1.Controls.Add(this.UserEmail_TB);
			this.panel1.Controls.Add(this.UserEmail_LBL);
			this.panel1.Controls.Add(this.UserName_TB);
			this.panel1.Controls.Add(this.UserName_LBL);
			this.panel1.Controls.Add(this.UserFullName_TB);
			this.panel1.Controls.Add(this.UserFullName_LBL);
			this.panel1.Controls.Add(this.UserId_TB);
			this.panel1.Controls.Add(this.UserId_LBL);
			this.panel1.Controls.Add(this.LogoFrame_PNL);
			this.panel1.Location = new System.Drawing.Point(16, 13);
			this.panel1.Margin = new System.Windows.Forms.Padding(4);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(355, 425);
			this.panel1.TabIndex = 0;
			// 
			// Reset_BTN
			// 
			this.Reset_BTN.BackColor = System.Drawing.SystemColors.Highlight;
			this.Reset_BTN.ForeColor = System.Drawing.Color.White;
			this.Reset_BTN.Location = new System.Drawing.Point(35, 360);
			this.Reset_BTN.Margin = new System.Windows.Forms.Padding(4);
			this.Reset_BTN.Name = "Reset_BTN";
			this.Reset_BTN.Size = new System.Drawing.Size(284, 30);
			this.Reset_BTN.TabIndex = 1;
			this.Reset_BTN.Text = "Reset";
			this.Reset_BTN.UseVisualStyleBackColor = false;
			this.Reset_BTN.Click += new System.EventHandler(this.Reset_BTN_Click);
			// 
			// UserPhone_TB
			// 
			this.UserPhone_TB.BackColor = System.Drawing.SystemColors.Menu;
			this.UserPhone_TB.Location = new System.Drawing.Point(120, 321);
			this.UserPhone_TB.Name = "UserPhone_TB";
			this.UserPhone_TB.ReadOnly = true;
			this.UserPhone_TB.Size = new System.Drawing.Size(199, 24);
			this.UserPhone_TB.TabIndex = 10;
			// 
			// UserPhone_LBL
			// 
			this.UserPhone_LBL.AutoSize = true;
			this.UserPhone_LBL.Location = new System.Drawing.Point(32, 323);
			this.UserPhone_LBL.Name = "UserPhone_LBL";
			this.UserPhone_LBL.Size = new System.Drawing.Size(53, 17);
			this.UserPhone_LBL.TabIndex = 9;
			this.UserPhone_LBL.Text = "Phone:";
			// 
			// UserEmail_TB
			// 
			this.UserEmail_TB.BackColor = System.Drawing.SystemColors.Menu;
			this.UserEmail_TB.Location = new System.Drawing.Point(119, 279);
			this.UserEmail_TB.Name = "UserEmail_TB";
			this.UserEmail_TB.ReadOnly = true;
			this.UserEmail_TB.Size = new System.Drawing.Size(200, 24);
			this.UserEmail_TB.TabIndex = 8;
			// 
			// UserEmail_LBL
			// 
			this.UserEmail_LBL.AutoSize = true;
			this.UserEmail_LBL.Location = new System.Drawing.Point(34, 281);
			this.UserEmail_LBL.Name = "UserEmail_LBL";
			this.UserEmail_LBL.Size = new System.Drawing.Size(48, 17);
			this.UserEmail_LBL.TabIndex = 7;
			this.UserEmail_LBL.Text = "Email:";
			// 
			// UserName_TB
			// 
			this.UserName_TB.BackColor = System.Drawing.SystemColors.Menu;
			this.UserName_TB.Location = new System.Drawing.Point(120, 237);
			this.UserName_TB.Name = "UserName_TB";
			this.UserName_TB.ReadOnly = true;
			this.UserName_TB.Size = new System.Drawing.Size(199, 24);
			this.UserName_TB.TabIndex = 6;
			// 
			// UserName_LBL
			// 
			this.UserName_LBL.AutoSize = true;
			this.UserName_LBL.Location = new System.Drawing.Point(34, 240);
			this.UserName_LBL.Name = "UserName_LBL";
			this.UserName_LBL.Size = new System.Drawing.Size(79, 17);
			this.UserName_LBL.TabIndex = 5;
			this.UserName_LBL.Text = "UserName:";
			// 
			// UserFullName_TB
			// 
			this.UserFullName_TB.BackColor = System.Drawing.SystemColors.Menu;
			this.UserFullName_TB.Location = new System.Drawing.Point(119, 195);
			this.UserFullName_TB.Name = "UserFullName_TB";
			this.UserFullName_TB.ReadOnly = true;
			this.UserFullName_TB.Size = new System.Drawing.Size(200, 24);
			this.UserFullName_TB.TabIndex = 4;
			// 
			// UserFullName_LBL
			// 
			this.UserFullName_LBL.AutoSize = true;
			this.UserFullName_LBL.Location = new System.Drawing.Point(35, 198);
			this.UserFullName_LBL.Name = "UserFullName_LBL";
			this.UserFullName_LBL.Size = new System.Drawing.Size(50, 17);
			this.UserFullName_LBL.TabIndex = 3;
			this.UserFullName_LBL.Text = "Name:";
			// 
			// UserId_TB
			// 
			this.UserId_TB.BackColor = System.Drawing.SystemColors.Menu;
			this.UserId_TB.Location = new System.Drawing.Point(119, 153);
			this.UserId_TB.Name = "UserId_TB";
			this.UserId_TB.ReadOnly = true;
			this.UserId_TB.Size = new System.Drawing.Size(200, 24);
			this.UserId_TB.TabIndex = 2;
			// 
			// UserId_LBL
			// 
			this.UserId_LBL.AutoSize = true;
			this.UserId_LBL.Location = new System.Drawing.Point(34, 157);
			this.UserId_LBL.Name = "UserId_LBL";
			this.UserId_LBL.Size = new System.Drawing.Size(56, 17);
			this.UserId_LBL.TabIndex = 1;
			this.UserId_LBL.Text = "User Id:";
			// 
			// LogoFrame_PNL
			// 
			this.LogoFrame_PNL.BackColor = System.Drawing.SystemColors.Menu;
			this.LogoFrame_PNL.Controls.Add(this.pictureBox1);
			this.LogoFrame_PNL.Location = new System.Drawing.Point(14, 14);
			this.LogoFrame_PNL.Margin = new System.Windows.Forms.Padding(4);
			this.LogoFrame_PNL.Name = "LogoFrame_PNL";
			this.LogoFrame_PNL.Size = new System.Drawing.Size(327, 120);
			this.LogoFrame_PNL.TabIndex = 0;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::simpleLoginWindows.Properties.Resources.icons8_login_as_user_48px;
			this.pictureBox1.Location = new System.Drawing.Point(140, 36);
			this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(48, 49);
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// UserProfile_FRM
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveBorder;
			this.ClientSize = new System.Drawing.Size(384, 451);
			this.Controls.Add(this.panel1);
			this.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "UserProfile_FRM";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "User Profile";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.LogoFrame_PNL.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel LogoFrame_PNL;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Button Reset_BTN;
		private System.Windows.Forms.Label UserId_LBL;
		private System.Windows.Forms.Label UserFullName_LBL;
		private System.Windows.Forms.TextBox UserId_TB;
		private System.Windows.Forms.TextBox UserFullName_TB;
		private System.Windows.Forms.Label UserName_LBL;
		private System.Windows.Forms.Label UserEmail_LBL;
		private System.Windows.Forms.TextBox UserName_TB;
		private System.Windows.Forms.TextBox UserEmail_TB;
		private System.Windows.Forms.TextBox UserPhone_TB;
		private System.Windows.Forms.Label UserPhone_LBL;
	}
}