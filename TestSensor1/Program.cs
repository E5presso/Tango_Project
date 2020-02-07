using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Core.Collections;
using Core.Security;
using Core.Network;

namespace TestSensor1
{
	class Program
	{
		private static readonly Server server = new Server();
		private static readonly Random random = new Random();
		private static readonly Thread thread = new Thread(new ThreadStart(() =>
		{
			while (true)
			{
				RingBuffer buffer = new RingBuffer();
				buffer.Write(new byte[]
				{
					0x74, 0x00, 0x07, 0x15, 0x00, 0x00, 0x00, 0x00,
					0x00, 0x00, 0xFF
				});
				float x1 = Convert.ToSingle(string.Format("{0:F2}", (8f * (float)random.NextDouble()) - 4f));
				float x2 = Convert.ToSingle(string.Format("{0:F2}", (8f * (float)random.NextDouble()) - 4f));
				int i1 = (int)(x1 * 100);
				int i2 = (int)(x2 * 100);
				buffer.Write(0x00);
				buffer.Write(0x00);
				buffer.Write(Key.GenerateBytes(55));
				buffer.Write(BitConverter.GetBytes(i1));
				buffer.Write(BitConverter.GetBytes(i2));
				buffer.Write(Key.GenerateBytes(40));
				server.Send(buffer.ToArray());
				Thread.Sleep(100);
			}
		}));

		private static void Main()
		{
			server.Connected += Server_Connected;
			server.Sended += Server_Sended;
			server.Received += Server_Received;
			server.Disconnected += Server_Disconnected;
			server.Open(11101, 100, 1500, false);
			Console.ReadKey();
			thread.Abort();
		}

		private static void Server_Connected(object sender, ConnectEventArgs e)
		{
			Console.WriteLine($"[{e.IP}] Connected");
			thread.Start();
		}
		private static void Server_Sended(object sender, SendEventArgs e)
		{
			Console.WriteLine($"{e.BytesSent} BytesSended to {e.IP}");
		}
		private static void Server_Received(object sender, ReceiveEventArgs e)
		{
		}
		private static void Server_Disconnected(object sender, DisconnectEventArgs e)
		{
			Console.WriteLine($"[{e.IP}] Disconnected");
		}
	}
}