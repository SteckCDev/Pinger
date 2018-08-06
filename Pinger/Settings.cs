using System.Net;

namespace Pinger
{
	class Settings
	{
		public static readonly int STOCKCOND = 100;
		public static readonly IPAddress STOCKIP = IPAddress.Parse("127.0.0.1");

		public static int max = STOCKCOND;
		public static int avg = STOCKCOND;
		public static int dif = STOCKCOND;
		public static IPAddress ip = STOCKIP;
	}
}
