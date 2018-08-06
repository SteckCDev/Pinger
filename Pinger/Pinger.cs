using System.Net;
using System.Net.NetworkInformation;

namespace Pinger
{
	class Pinger
	{
		private readonly IPAddress IP;

		private Ping ping;
		private PingReply reply;

		public Pinger(IPAddress IP)
		{
			this.IP = IP;

			ping = new Ping();
			reply = ping.Send(IP);
		}

		public int SendPackage()
		{
			reply = ping.Send(IP);
			return (int)reply.RoundtripTime;
		}
	}
}
