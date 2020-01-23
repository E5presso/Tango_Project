using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Network;

namespace Middleware
{
	public class Controller
	{
		private readonly Sensor sensor;
		private readonly Robot robot;

		public event EventHandler<SensorValueEventArgs> SensorValueReceived;
		public event EventHandler<RobotPhaseEventArgs> RobotPhaseChanged;

		public float Bias { get; set; }
		public bool BypassMode { get; set; }

		public Controller()
		{
			sensor = new Sensor();
			robot = new Robot();

			sensor.Sensor1Connected += Sensor_Sensor1Connected;
			sensor.Sensor1Sended += Sensor_Sensor1Sended;
			sensor.Sensor1Received += Sensor_Sensor1Received;
			sensor.Sensor1Disconnected += Sensor_Sensor1Disconnected;
			sensor.Sensor1ErrorOccurred += Sensor_Sensor1ErrorOccurred;

			sensor.Sensor2Connected += Sensor_Sensor2Connected;
			sensor.Sensor2Sended += Sensor_Sensor2Sended;
			sensor.Sensor2Received += Sensor_Sensor2Received;
			sensor.Sensor2Disconnected += Sensor_Sensor2Disconnected;
			sensor.Sensor2ErrorOccurred += Sensor_Sensor2ErrorOccurred;

			robot.Robot1Connected += Robot_Robot1Connected;
			robot.Robot1Sended += Robot_Robot1Sended;
			robot.Robot1Received += Robot_Robot1Received;
			robot.Robot1Disconnected += Robot_Robot1Disconnected;
			robot.Robot1ErrorOccurred += Robot_Robot1ErrorOccurred;

			robot.Robot2Connected += Robot_Robot2Connected;
			robot.Robot2Sended += Robot_Robot2Sended;
			robot.Robot2Received += Robot_Robot2Received;
			robot.Robot2Disconnected += Robot_Robot2Disconnected;
			robot.Robot2ErrorOccurred += Robot_Robot2ErrorOccurred;
		}

		public void ConnectToSensor1(string ip, int port, int buffersize) => sensor.ConnectToSensor1(ip, port, buffersize);
		public void ConnectToSensor2(string ip, int port, int buffersize) => sensor.ConnectToSensor2(ip, port, buffersize);
		public void DisconnectFromSensor1() => sensor.DisconnectFromSensor1();
		public void DisconnectFromSensor2() => sensor.DisconnectFromSensor2();

		public void StartRobotServer(int port, int buffersize) => robot.Start(port, buffersize);
		public void StopRobotServer() => robot.Stop();

		private void SendToSensor1(byte[] data) => sensor.SendToSensor1(data);
		private void SendToSensor2(byte[] data) => sensor.SendToSensor2(data);
		private void SendToRobot1(byte[] data) => robot.SendToRobot1(data);
		private void SendToRobot2(byte[] data) => robot.SendToRobot2(data);

		private void ProcessingSensorData(byte[] data)
		{
		}

		private void Sensor_Sensor1Connected(object sender, ConnectEventArgs e)
		{
		}
		private void Sensor_Sensor1Sended(object sender, SendEventArgs e)
		{
		}
		private void Sensor_Sensor1Received(object sender, ReceiveEventArgs e)
		{
		}
		private void Sensor_Sensor1Disconnected(object sender, DisconnectEventArgs e)
		{
		}
		private void Sensor_Sensor1ErrorOccurred(object sender, ExceptionEventArgs e)
		{
		}

		private void Sensor_Sensor2Connected(object sender, ConnectEventArgs e)
		{
		}
		private void Sensor_Sensor2Sended(object sender, SendEventArgs e)
		{
		}
		private void Sensor_Sensor2Received(object sender, ReceiveEventArgs e)
		{
		}
		private void Sensor_Sensor2Disconnected(object sender, DisconnectEventArgs e)
		{
		}
		private void Sensor_Sensor2ErrorOccurred(object sender, ExceptionEventArgs e)
		{
		}

		private void Robot_Robot1Connected(object sender, ConnectEventArgs e)
		{
		}
		private void Robot_Robot1Sended(object sender, SendEventArgs e)
		{
		}
		private void Robot_Robot1Received(object sender, ReceiveEventArgs e)
		{
		}
		private void Robot_Robot1Disconnected(object sender, DisconnectEventArgs e)
		{
		}
		private void Robot_Robot1ErrorOccurred(object sender, ExceptionEventArgs e)
		{
		}

		private void Robot_Robot2Connected(object sender, ConnectEventArgs e)
		{
		}
		private void Robot_Robot2Sended(object sender, SendEventArgs e)
		{
		}
		private void Robot_Robot2Received(object sender, ReceiveEventArgs e)
		{
		}
		private void Robot_Robot2Disconnected(object sender, DisconnectEventArgs e)
		{
		}
		private void Robot_Robot2ErrorOccurred(object sender, ExceptionEventArgs e)
		{
		}
	}
}