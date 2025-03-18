// Ignore Spelling: FRM

using simpleLoginWindows.Models;
using System.Windows.Forms;

namespace simpleLoginWindows
{
	public partial class UserProfile_FRM : Form
	{
		public UserHolders userLogged;

		// Constructor that accepts a UserHolders object
		public UserProfile_FRM(UserHolders loggedUser)
		{
			InitializeComponent();
			userLogged = loggedUser;
			DisplayUserInfo(); // Call a method to populate the fields
		}

		private void DisplayUserInfo()
		{
			if (userLogged != null)
			{
				UserId_TB.Text = userLogged.UserHolders_Id.ToString();
				UserFullName_TB.Text = userLogged.UserHolders_FullName ?? "N/A";
				UserName_TB.Text = userLogged.UserHolders_UserName ?? "N/A";
				UserEmail_TB.Text = userLogged.UserHolders_UserEmail ?? "N/A";
				UserPhone_TB.Text = userLogged.UserHolders_Phone ?? "N/A";
			}
		}

		private void Reset_BTN_Click(object sender, System.EventArgs e)
		{
			LoginForm form = new LoginForm();
			userLogged = null;
			UserId_TB.Text = string.Empty;
			UserFullName_TB.Text = string.Empty;
			UserName_TB.Text = string.Empty;
			UserEmail_TB.Text = string.Empty;
			UserPhone_TB.Text = string.Empty;
			this.Hide();
			form.Show();
		}
	}
}