using System;
using System.IO;
using System.Windows.Forms;

namespace Pinger
{
	public partial class SettingForm : Form
	{
		private MainForm pinger;
		private IniFile cfg;
		private readonly string cfgPath;

		public SettingForm()
		{
			InitializeComponent();

			cfgPath = "settings.ini";

			if (!File.Exists(cfgPath))
			{
				using (var sw = new StreamWriter(cfgPath))
				{
					sw.WriteLine("[Pinger]");
					sw.WriteLine($"max={Settings.STOCKCOND}");
					sw.WriteLine($"avg={Settings.STOCKCOND}");
					sw.WriteLine($"dif={Settings.STOCKCOND}");
					sw.WriteLine($"ip={Settings.STOCKIP}");
				}
			}

			cfg = new IniFile(cfgPath);

			SetSettings(cfg.Read("max", "Pinger"), cfg.Read("avg", "Pinger"), cfg.Read("dif", "Pinger"), cfg.Read("ip", "Pinger"));

			pinger = new MainForm(this);
		}

		private void Var_TextChanged(object sender, EventArgs e)
		{
			if (btn_start.Enabled) btn_start.Enabled = false;
			if (!btn_check.Enabled) btn_check.Enabled = true;
		}

		private void Btn_check_Click(object sender, EventArgs e)
		{
			SetSettings(var_max.Text, var_avg.Text, var_dif.Text, var_ip.Text);

			if (!btn_start.Enabled) btn_start.Enabled = true;
			if (btn_check.Enabled) btn_check.Enabled = false;
		}

		private void Btn_start_Click(object sender, EventArgs e)
		{
			SaveSettings();

			this.Hide();
			pinger.Show();
			pinger.SetMonitoringStatus(true);
		}

		private void SaveSettings()
		{
			cfg.Write("max", Settings.max.ToString(), "Pinger");
			cfg.Write("avg", Settings.avg.ToString(), "Pinger");
			cfg.Write("dif", Settings.dif.ToString(), "Pinger");
			cfg.Write("ip", Settings.ip.ToString(), "Pinger");
		}

		private void SetSettings(string max, string avg, string dif, string ip)
		{
			var_max.Text = SetVariable(max, out Settings.max) ? Settings.max.ToString() : Settings.STOCKCOND.ToString();
			var_avg.Text = SetVariable(avg, out Settings.avg) ? Settings.avg.ToString() : Settings.STOCKCOND.ToString();
			var_dif.Text = SetVariable(dif, out Settings.dif) ? Settings.dif.ToString() : Settings.STOCKCOND.ToString();
			var_ip.Text = SetIP(ip, out Settings.ip) ? Settings.ip.ToString() : Settings.STOCKIP.ToString();
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
