using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace Pinger
{
	public partial class MainForm : Form
	{
		private Pinger pinger;
		private Thread ping;
		private Form parent;
		private bool monitoringStatus;

		public MainForm(Form parent)
		{
			InitializeComponent();
			
			pinger = new Pinger(Settings.ip);
			this.parent = parent;
			monitoringStatus = false;
			Screen sc = Screen.FromHandle(Handle);
			Size = new Size(Size.Width, this.Height);
			Location = new Point(SystemInformation.PrimaryMonitorSize.Width - Size.Width, sc.WorkingArea.Height - Size.Height);

			Start();
		}

		private void Monitoring()
		{
			int max = 0, min = 0, avg = 0, sum = 0, i = 0;

			while (monitoringStatus)
			{
				i++;

				int time = pinger.SendPackage();

				if (time != 0)
				{
					max = time > max ? time : max;
					sum += time;
					avg = sum / i;
				}

				SetStatus($"Ping: {time} ms, Max: {max} ms, Avg: {avg} ms");

				if (max < Settings.max && avg < Settings.avg && min - avg < Settings.dif)
				{
					pct_status.BackColor = Color.Green;
				}
				else
				{
					pct_status.BackColor = Color.Red;
				}

				Thread.Sleep(500);
			}
		}

		public void SetMonitoringStatus(bool status)
		{
			monitoringStatus = status;
			Thread.Sleep(100);
			if (status) Start(); else Stop();
		}

		/* FORM */

		private void MainForm_MouseDown(object sender, MouseEventArgs e)
		{
			this.Hide();
			monitoringStatus = false;
			Thread.Sleep(2500);
			Stop();
			parent.Show();
		}

		private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			Stop();
		}

		/* THREADS */

		private void Start()
		{
			ping = new Thread(new ThreadStart(Monitoring));
			ping.Start();
		}

		private void Stop()
		{
			if (ping != null)
			{
				ping.Abort();
				ping = null;
			}
		}

		delegate void StringArgReturningVoidDelegate(string text);
		delegate void ColorArgReturningVoidDelegate(Color color);

		private void SetStatus(string text)
		{
			if (lab_status.InvokeRequired)
			{
				StringArgReturningVoidDelegate d = new StringArgReturningVoidDelegate(SetStatus);
				Invoke(d, new object[] { text });
			}
			else
			{
				lab_status.Text = text;
			}
		}

		private void SetStatusColor(Color color)
		{
			if (pct_status.InvokeRequired)
			{
				ColorArgReturningVoidDelegate d = new ColorArgReturningVoidDelegate(SetStatusColor);
				Invoke(d, new object[] { color });
			}
			else
			{
				pct_status.BackColor = color;
			}
		}
	}
}
