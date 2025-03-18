using System.Windows.Forms;

namespace simpleLoginWindows.Windows
{
	public partial class WaitingForm : Form
	{
		private Timer timer;
		private int countdown = 5; // Set to 5 seconds (or your desired duration)

		public WaitingForm()
		{
			InitializeComponent();
			this.FormBorderStyle = FormBorderStyle.FixedDialog; // Optional: Prevent resizing
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.StartPosition = FormStartPosition.CenterParent;

			// Initialize the label
			lblMessage = new Label
			{
				Text = $"Too many failed attempts.\nPlease wait {countdown} seconds...",
				TextAlign = System.Drawing.ContentAlignment.MiddleCenter,
				Dock = DockStyle.Fill,
				Font = new System.Drawing.Font("Roboto", 14)
			};

			// Initialize the timer
			timer = new Timer
			{
				Interval = 1000 // 1 second
			};
			timer.Tick += (s, e) =>
			{
				countdown--;
				lblMessage.Text = $"Too many failed attempts.\nPlease wait {countdown} seconds...";
				if (countdown <= 0)
				{
					timer.Stop();
					this.Close(); // Close the form when countdown reaches 0
				}
			};

			// Add controls to the form
			this.Controls.Add(lblMessage);

			// Start the timer when the form is shown
			this.Shown += (s, e) => timer.Start();
		}
	}
}