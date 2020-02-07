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

		public event EventHandler<ConnectEventArgs> Robot2Connected;
		public event EventHandler<SendEventArgs> Robot2Sended;
		public event EventHandler<ReceiveEventArgs> Robot2Received;
		public event EventHandler<DisconnectEventArgs> Robot2Disconnected;

		public event EventHandler<ExceptionEventArgs> RobotErrorOccurred;

		public bool IsActive => server.IsActive;
		public string Robot1IpAddress { get; set; }
		public string Robot2IpAddress { get; set; }

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
			if (Robot1IpAddress != null && server.List.Contains(Robot1IpAddress)) server.Send(Robot1IpAddress, data);
		}
		public void SendToRobot2(byte[] data)
		{
			if (Robot1IpAddress != null && server.List.Contains(Robot2IpAddress)) server.Send(Robot2IpAddress, data);
		}

		private void Server_Connected(object sender, ConnectEventArgs e)
		{
			if (e.IP == Robot1IpAddress) Robot1Connected?.Invoke(sender, e);
			else if (e.IP == Robot2IpAddress) Robot2Connected?.Invoke(sender, e);
			else server.Disconnect(e.IP);
		}
		private void Server_Sended(object sender, SendEventArgs e)
		{
			if (e.IP == Robot1IpAddress) Robot1Sended?.Invoke(sender, e);
			else if (e.IP == Robot2IpAddress) Robot2Sended?.Invoke(sender, e);
		}
		private void Server_Received(object sender, ReceiveEventArgs e)
		{
			if (e.IP == Robot1IpAddress) Robot1Received?.Invoke(sender, e);
			else if (e.IP == Robot2IpAddress) Robot2Received?.Invoke(sender, e);
		}
		private void Server_Disconnected(object sender, DisconnectEventArgs e)
		{
			if (e.IP == Robot1IpAddress) Robot1Disconnected?.Invoke(sender, e);
			else if (e.IP == Robot2IpAddress) Robot2Disconnected?.Invoke(sender, e);
		}
		private void Server_ErrorOccurred(object sender, ExceptionEventArgs e)
		{
			RobotErrorOccurred?.Invoke(sender, e);
		}
	}
}