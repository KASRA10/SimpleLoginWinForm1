namespace simpleLoginWindows
{
	partial class LoginForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
			this.Hedaer_Panel = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.Footer_PNL = new System.Windows.Forms.Panel();
			this.CopyRightText_LBL = new System.Windows.Forms.Label();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.UserName_LBL = new System.Windows.Forms.Label();
			this.Fields_PNL = new System.Windows.Forms.Panel();
			this.UserEmail_LBL = new System.Windows.Forms.Label();
			this.UserName_TB = new System.Windows.Forms.TextBox();
			this.UserEmail_TB = new System.Windows.Forms.TextBox();
			this.Login_BTN = new System.Windows.Forms.Button();
			this.Hedaer_Panel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.Footer_PNL.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			this.Fields_PNL.SuspendLayout();
			this.SuspendLayout();
			// 
			// Hedaer_Panel
			// 
			this.Hedaer_Panel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.Hedaer_Panel.Controls.Add(this.label1);
			this.Hedaer_Panel.Controls.Add(this.pictureBox1);
			this.Hedaer_Panel.Location = new System.Drawing.Point(12, 12);
			this.Hedaer_Panel.Name = "Hedaer_Panel";
			this.Hedaer_Panel.Size = new System.Drawing.Size(760, 100);
			this.Hedaer_Panel.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(316, 69);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(140, 17);
			this.label1.TabIndex = 1;
			this.label1.Text = "JsonPlaceHolderAPI";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pictureBox1.Image = global::simpleLoginWindows.Properties.Resources.brackets;
			this.pictureBox1.Location = new System.Drawing.Point(361, 16);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(43, 50);
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
			// 
			// Footer_PNL
			// 
			this.Footer_PNL.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.Footer_PNL.Controls.Add(this.pictureBox2);
			this.Footer_PNL.Controls.Add(this.CopyRightText_LBL);
			this.Footer_PNL.Location = new System.Drawing.Point(12, 509);
			this.Footer_PNL.Name = "Footer_PNL";
			this.Footer_PNL.Size = new System.Drawing.Size(760, 40);
			this.Footer_PNL.TabIndex = 1;
			// 
			// CopyRightText_LBL
			// 
			this.CopyRightText_LBL.AutoSize = true;
			this.CopyRightText_LBL.Cursor = System.Windows.Forms.Cursors.Hand;
			this.CopyRightText_LBL.Location = new System.Drawing.Point(302, 13);
			this.CopyRightText_LBL.Name = "CopyRightText_LBL";
			this.CopyRightText_LBL.Size = new System.Drawing.Size(197, 17);
			this.CopyRightText_LBL.TabIndex = 0;
			this.CopyRightText_LBL.Text = "2025 © Powered By KasraK10";
			this.CopyRightText_LBL.Click += new System.EventHandler(this.CopyRightText_LBL_Click);
			// 
			// pictureBox2
			// 
			this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pictureBox2.Image = global::simpleLoginWindows.Properties.Resources.favIcon;
			this.pictureBox2.Location = new System.Drawing.Point(269, 6);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(30, 29);
			this.pictureBox2.TabIndex = 1;
			this.pictureBox2.TabStop = false;
			this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
			// 
			// UserName_LBL
			// 
			this.UserName_LBL.AutoSize = true;
			this.UserName_LBL.Location = new System.Drawing.Point(230, 133);
			this.UserName_LBL.Name = "UserName_LBL";
			this.UserName_LBL.Size = new System.Drawing.Size(82, 17);
			this.UserName_LBL.TabIndex = 2;
			this.UserName_LBL.Text = "User Name:";
			// 
			// Fields_PNL
			// 
			this.Fields_PNL.BackColor = System.Drawing.Color.Ivory;
			this.Fields_PNL.Controls.Add(this.Login_BTN);
			this.Fields_PNL.Controls.Add(this.UserEmail_TB);
			this.Fields_PNL.Controls.Add(this.UserName_TB);
			this.Fields_PNL.Controls.Add(this.UserEmail_LBL);
			this.Fields_PNL.Controls.Add(this.UserName_LBL);
			this.Fields_PNL.Location = new System.Drawing.Point(13, 119);
			this.Fields_PNL.Name = "Fields_PNL";
			this.Fields_PNL.Size = new System.Drawing.Size(759, 384);
			this.Fields_PNL.TabIndex = 2;
			// 
			// UserEmail_LBL
			// 
			this.UserEmail_LBL.AutoSize = true;
			this.UserEmail_LBL.Location = new System.Drawing.Point(229, 165);
			this.UserEmail_LBL.Name = "UserEmail_LBL";
			this.UserEmail_LBL.Size = new System.Drawing.Size(80, 17);
			this.UserEmail_LBL.TabIndex = 3;
			this.UserEmail_LBL.Text = "User Email:";
			// 
			// UserName_TB
			// 
			this.UserName_TB.BackColor = System.Drawing.Color.Gainsboro;
			this.UserName_TB.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
			this.UserName_TB.Location = new System.Drawing.Point(315, 130);
			this.UserName_TB.Name = "UserName_TB";
			this.UserName_TB.Size = new System.Drawing.Size(200, 24);
			this.UserName_TB.TabIndex = 4;
			// 
			// UserEmail_TB
			// 
			this.UserEmail_TB.BackColor = System.Drawing.Color.Gainsboro;
			this.UserEmail_TB.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
			this.UserEmail_TB.Location = new System.Drawing.Point(316, 162);
			this.UserEmail_TB.Name = "UserEmail_TB";
			this.UserEmail_TB.Size = new System.Drawing.Size(200, 24);
			this.UserEmail_TB.TabIndex = 5;
			// 
			// Login_BTN
			// 
			this.Login_BTN.BackColor = System.Drawing.Color.MediumSeaGreen;
			this.Login_BTN.Location = new System.Drawing.Point(234, 192);
			this.Login_BTN.Name = "Login_BTN";
			this.Login_BTN.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
			this.Login_BTN.Size = new System.Drawing.Size(282, 30);
			this.Login_BTN.TabIndex = 7;
			this.Login_BTN.Text = "Login";
			this.Login_BTN.UseVisualStyleBackColor = false;
			this.Login_BTN.Click += new System.EventHandler(this.Login_BTN_Click);
			// 
			// LoginForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.BackColor = System.Drawing.SystemColors.ActiveBorder;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.ClientSize = new System.Drawing.Size(784, 561);
			this.Controls.Add(this.Fields_PNL);
			this.Controls.Add(this.Footer_PNL);
			this.Controls.Add(this.Hedaer_Panel);
			this.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "LoginForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Login Windows";
			this.Load += new System.EventHandler(this.LoginForm_Load);
			this.Hedaer_Panel.ResumeLayout(false);
			this.Hedaer_Panel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.Footer_PNL.ResumeLayout(false);
			this.Footer_PNL.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			this.Fields_PNL.ResumeLayout(false);
			this.Fields_PNL.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel Hedaer_Panel;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Panel Footer_PNL;
		private System.Windows.Forms.Label CopyRightText_LBL;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.Label UserName_LBL;
		private System.Windows.Forms.Panel Fields_PNL;
		private System.Windows.Forms.TextBox UserName_TB;
		private System.Windows.Forms.Label UserEmail_LBL;
		private System.Windows.Forms.TextBox UserEmail_TB;
		private System.Windows.Forms.Button Login_BTN;
	}
}

