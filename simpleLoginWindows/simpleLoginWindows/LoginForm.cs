using simpleLoginWindows.Functions;
using simpleLoginWindows.Models;
using simpleLoginWindows.Windows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace simpleLoginWindows
{
	public partial class LoginForm : Form
	{
		// Public Variables
		#region PubLicVariables
		public System.Threading.Tasks.Task<System.Collections.Generic.List<Models.UserHolders>> listOfUser = null;
		public UserHolders LoggingUser = new UserHolders();
		public List<UserHolders> listOfUsers;

		// URL to open 
		public string url = "https://jsonplaceholder.typicode.com/";
		public string myUrl = "https://kasra10design.com/";
		#endregion
		public LoginForm()
		{
			InitializeComponent();
		}

		// OnLoad
		private async void LoginForm_Load(object sender, System.EventArgs e)
		{
			try
			{
				listOfUsers = await GetPlaceHolderData.GetPlaceHoldersUsers(); // Added await
				Console.WriteLine("Retrieve Data was Successful");
			}
			catch (Exception ex)
			{
				DialogResult result = MessageBox.Show("Problem To Connect. Error: " + ex.Message,
					"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				Console.WriteLine("Problem To Connect. Error: " + ex.Message);
			}
		}

		// Click On Image
		private void pictureBox1_Click(object sender, System.EventArgs e)
		{
			try
			{
				// Use Process.Start to open the URL in the default browser 
				System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
				{
					FileName = url,
					UseShellExecute = true // Ensures it uses the default browser 
				});
			}
			catch (Exception ex)
			{
				// Handle exceptions, such as when a browser is unavailable 
				DialogResult result = MessageBox.Show("Unable to open the link. Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				Console.WriteLine("Unable to open the link. Error: " + ex.Message, "Error");
			}
		}

		// Click On Image
		private void pictureBox2_Click(object sender, EventArgs e)
		{
			try
			{
				// Use Process.Start to open the URL in the default browser 
				System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
				{
					FileName = myUrl,
					UseShellExecute = true // Ensures it uses the default browser 
				});
			}
			catch (Exception ex)
			{
				// Handle exceptions, such as when a browser is unavailable 
				DialogResult result = MessageBox.Show("Unable to open the link. Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				Console.WriteLine("Unable to open the link. Error: " + ex.Message);
			}
		}

		// CopyRight Text On Image
		private void CopyRightText_LBL_Click(object sender, EventArgs e)
		{
			try
			{
				// Use Process.Start to open the URL in the default browser 
				System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
				{
					FileName = myUrl,
					UseShellExecute = true // Ensures it uses the default browser 
				});
			}
			catch (Exception ex)
			{
				// Handle exceptions, such as when a browser is unavailable 
				DialogResult result = MessageBox.Show("Unable to open the link. Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				Console.WriteLine("Unable to open the link. Error: " + ex.Message);
			}

		}

		// Move counter to class level
		private int counter = 0;

		private async void Login_BTN_Click(object sender, EventArgs e)
		{
			// Input validation
			if (string.IsNullOrWhiteSpace(UserName_TB.Text))
			{
				MessageBox.Show("The UserName Is Empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				Console.WriteLine("The UserName Is Empty");
				return;
			}

			if (string.IsNullOrWhiteSpace(UserEmail_TB.Text))
			{
				MessageBox.Show("The UserEmail Is Empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				Console.WriteLine("The UserEmail Is Empty");
				return;
			}

			// Set initial properties for matching
			LoggingUser.UserHolders_UserName = UserName_TB.Text;
			LoggingUser.UserHolders_UserEmail = UserEmail_TB.Text;

			// Verify credentials
			if (listOfUsers != null && listOfUsers.Count > 0)
			{
				var matchedUser = listOfUsers.FirstOrDefault(u =>
					u.UserHolders_UserName == LoggingUser.UserHolders_UserName &&
					u.UserHolders_UserEmail == LoggingUser.UserHolders_UserEmail);

				if (matchedUser != null)
				{
					LoggingUser = matchedUser;
					MessageBox.Show($"Login Successful! User: {UserName_TB.Text}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
					Console.WriteLine($"Login Successful! User: {UserName_TB.Text}");

					UserProfile_FRM form = new UserProfile_FRM(LoggingUser);
					this.Hide();
					form.Show();
				}
				else
				{
					MessageBox.Show("Invalid username or email", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
					Console.WriteLine("Invalid username or email");
					counter++;
					if (counter == 3)
					{
						this.Enabled = false;
						Console.WriteLine("Too many failed attempts. Form will be locked for 5 seconds.");

						using (WaitingForm waitingForm = new WaitingForm())
						{
							waitingForm.ShowDialog(this); // Show the waiting form and let it handle its own closing
						}

						this.Enabled = true;
						counter = 0; // Reset counter after lockout
					}
				}
			}
			else
			{
				MessageBox.Show("User data not loaded. Please try again later.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				Console.WriteLine("User data not loaded. Please try again later.");
			}
		}
	}
}
