using System;
using System.Drawing;
using System.Windows.Forms;

namespace Pinger
{
	public partial class SettingForm : Form
	{
		public SettingForm()
		{
			InitializeComponent();
		}

		private void Var_TextChanged(object sender, EventArgs e)
		{
			if (btn_start.Enabled) btn_start.Enabled = false;
			if (!btn_check.Enabled) btn_check.Enabled = true;
		}

		private void Btn_check_Click(object sender, EventArgs e)
		{
			var_max.Text = SetVariable(var_max.Text, out Settings.max) ? Settings.max.ToString() : Settings.STOCKCOND.ToString();
			var_avg.Text = SetVariable(var_avg.Text, out Settings.avg) ? Settings.avg.ToString() : Settings.STOCKCOND.ToString();
			var_dif.Text = SetVariable(var_dif.Text, out Settings.dif) ? Settings.dif.ToString() : Settings.STOCKCOND.ToString();
			var_ip.Text = SetIP(var_ip.Text, out Settings.ip) ? Settings.ip.ToString() : Settings.STOCKIP.ToString();

			if (!btn_start.Enabled) btn_start.Enabled = true;
			if (btn_check.Enabled) btn_check.Enabled = false;
		}

		private void Btn_start_Click(object sender, EventArgs e)
		{
			this.Hide();
			Form pinger = new MainForm(this);
			pinger.Show();
		}

		private bool SetVariable(string variable, out int exit)
		{
			if (int.TryParse(variable, out exit))
			{
				if (exit > 250)
				{
					exit = 250;
				}
				else if (exit < 1)
				{
					exit = 1;
				}

				return true;
			}
			else
			{
				exit = Settings.STOCKCOND;
				return false;
			}
		}

		private bool SetIP(string ip, out System.Net.IPAddress exit)
		{
			if (System.Net.IPAddress.TryParse(ip, out exit))
			{
				return true;
			}
			else
			{
				exit = Settings.STOCKIP;
				return false;
			}
		}
	}
}
