using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Network;

namespace TestConsole
{
	class Program
	{
		private static readonly Client client = new Client();
		private static void Main()
		{
			client.ErrorOccurred += Client_ErrorOccurred;

			client.Open("127.0.0.1", 11000, 1024, true);
			Console.ReadKey();
		}

		private static void Client_ErrorOccurred(object sender, ExceptionEventArgs e)
		{
			Console.WriteLine(e.ErrorCode);
		}
	}
}