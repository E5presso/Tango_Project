using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.CompactNet;

namespace TestConsole
{
	class Program
	{
		static Client client = new Client();
		static void Main(string[] args)
		{
			client.ErrorOccurred += Client_ErrorOccurred;

			client.Open("127.0.0.1", 11000, 1024);
			Console.ReadKey();
		}

		private static void Client_ErrorOccurred(object sender, ExceptionEventArgs e)
		{
			Console.WriteLine(e.ErrorCode);
		}
	}
}