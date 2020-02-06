using System;
using Core.Network;

namespace Middleware
{
	internal class Sensor
	{
		private readonly Client sensor1 = new Client();
		private readonly Client sensor2 = new Client();

		public event EventHandler<ConnectEventArgs> Sensor1Connected;
		public event EventHandler<SendEventArgs> Sensor1Sended;
		public event EventHandler<ReceiveEventArgs> Sensor1Received;
		public event EventHandler<DisconnectEventArgs> Sensor1Disconnected;
		public event EventHandler<ConnectionRefusedEventArgs> Sensor1ConnectionRefused;
		public event EventHandler<ExceptionEventArgs> Sensor1ErrorOccurred;

		public event EventHandler<ConnectEventArgs> Sensor2Connected;
		public event EventHandler<SendEventArgs> Sensor2Sended;
		public event EventHandler<ReceiveEventArgs> Sensor2Received;
		public event EventHandler<DisconnectEventArgs> Sensor2Disconnected;
		public event EventHandler<ConnectionRefusedEventArgs> Sensor2ConnectionRefused;
		public event EventHandler<ExceptionEventArgs> Sensor2ErrorOccurred;

		public bool IsSensor1Connected => sensor1.IsActive;
		public bool IsSensor2Connected => sensor2.IsActive;
		public string Sensor1IpAddress { get; set; }
		public string Sensor2IpAddress { get; set; }

		public Sensor()
		{
			sensor1.Connected += Sensor1_Connected;
			sensor1.Sended += Sensor1_Sended;
			sensor1.Received += Sensor1_Received;
			sensor1.Disconnected += Sensor1_Disconnected;
			sensor1.ConnectionRefused += Sensor1_ConnectionRefused;
			sensor1.ErrorOccurred += Sensor1_ErrorOccurred;

			sensor2.Connected += Sensor2_Connected;
			sensor2.Sended += Sensor2_Sended;
			sensor2.Received += Sensor2_Received;
			sensor2.Disconnected += Sensor2_Disconnected;
			sensor2.ConnectionRefused += Sensor2_ConnectionRefused;
			sensor2.ErrorOccurred += Sensor2_ErrorOccurred;
		}

		public void ConnectToSensor1(string ip, int port, int buffersize) => sensor1.Open(ip, port, buffersize, false);
		public void ConnectToSensor2(string ip, int port, int buffersize) => sensor2.Open(ip, port, buffersize, false);
		public void DisconnectFromSensor1() => sensor1.Close();
		public void DisconnectFromSensor2() => sensor2.Close();
		public void SendToSensor1(byte[] data) => sensor1.Send(data);
		public void SendToSensor2(byte[] data) => sensor2.Send(data);

		private void Sensor1_Connected(object sender, ConnectEventArgs e) => Sensor1Connected?.Invoke(sender, e);
		private void Sensor1_Sended(object sender, SendEventArgs e) => Sensor1Sended?.Invoke(sender, e);
		private void Sensor1_Received(object sender, ReceiveEventArgs e) => Sensor1Received?.Invoke(sender, e);
		private void Sensor1_Disconnected(object sender, DisconnectEventArgs e) => Sensor1Disconnected?.Invoke(sender, e);
		private void Sensor1_ConnectionRefused(object sender, ConnectionRefusedEventArgs e) => Sensor1ConnectionRefused?.Invoke(sender, e);
		private void Sensor1_ErrorOccurred(object sender, ExceptionEventArgs e) => Sensor1ErrorOccurred?.Invoke(sender, e);

		private void Sensor2_Connected(object sender, ConnectEventArgs e) => Sensor2Connected?.Invoke(sender, e);
		private void Sensor2_Sended(object sender, SendEventArgs e) => Sensor2Sended?.Invoke(sender, e);
		private void Sensor2_Received(object sender, ReceiveEventArgs e) => Sensor2Received?.Invoke(sender, e);
		private void Sensor2_Disconnected(object sender, DisconnectEventArgs e) => Sensor2Disconnected?.Invoke(sender, e);
		private void Sensor2_ConnectionRefused(object sender, ConnectionRefusedEventArgs e) => Sensor2ConnectionRefused?.Invoke(sender, e);
		private void Sensor2_ErrorOccurred(object sender, ExceptionEventArgs e) => Sensor2ErrorOccurred?.Invoke(sender, e);
	}
}