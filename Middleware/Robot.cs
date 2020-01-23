using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Network;

namespace Middleware
{
	internal class Robot
	{
		private readonly Server server = new Server();

		public event EventHandler<ConnectEventArgs> Robot1Connected;
		public event EventHandler<SendEventArgs> Robot1Sended;
		public event EventHandler<ReceiveEventArgs> Robot1Received;
		public event EventHandler<DisconnectEventArgs> Robot1Disconnected;
		public event EventHandler<ExceptionEventArgs> Robot1ErrorOccurred;

		public event EventHandler<ConnectEventArgs> Robot2Connected;
		public event EventHandler<SendEventArgs> Robot2Sended;
		public event EventHandler<ReceiveEventArgs> Robot2Received;
		public event EventHandler<DisconnectEventArgs> Robot2Disconnected;
		public event EventHandler<ExceptionEventArgs> Robot2ErrorOccurred;

		public bool IsActive => server.IsActive;

		public Robot()
		{
			server.Connected += Server_Connected;
			server.Sended += Server_Sended;
			server.Received += Server_Received;
			server.Disconnected += Server_Disconnected;
			server.ErrorOccurred += Server_ErrorOccurred;
		}

		public void Start(int port, int buffersize) => server.Open(port, 100, buffersize, false);
		public void Stop() => server.Close();
		public void SendToRobot1(byte[] data)
		{
			server.Send("", data);
		}
		public void SendToRobot2(byte[] data)
		{
			server.Send("", data);
		}

		private void Server_Connected(object sender, ConnectEventArgs e)
		{

		}
		private void Server_Sended(object sender, SendEventArgs e)
		{

		}
		private void Server_Received(object sender, ReceiveEventArgs e)
		{

		}
		private void Server_Disconnected(object sender, DisconnectEventArgs e)
		{

		}
		private void Server_ErrorOccurred(object sender, ExceptionEventArgs e)
		{

		}
	}
}