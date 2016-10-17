using System;
using System.Windows.Forms;

namespace Desktop_notifications_tray
{
	public partial class Form1 : Form
	{

		public Form1()
		{
			InitializeComponent();
			notifyIcon1.ContextMenuStrip = contextMenuStrip1;

		}

		private void button1_Click(object sender, EventArgs e)
		{
			notifyIcon1.BalloonTipText = "Windows notification";
			notifyIcon1.ShowBalloonTip(100, "title", "text", ToolTipIcon.Error);
		}

		private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			label2.Text = "doubleclick";
		}

		private void NotifyIcon1_Click(object sender, EventArgs e)
		{
			label2.Text = "Clicked the balloon!";
		}

		private void button2_Click(object sender, EventArgs e)
		{




		}
	}
}
