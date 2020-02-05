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
		/* Robot Data Packet 구분 */
		const int Door_Info_ID_1 = 0x31;
		const int Door_Info_ID_2 = 0x31;
		const int Door_Info_R_ID_1 = 0x31;
		const int Door_Info_R_ID_2 = 0x32;
		const int Bending_REQ_ID_1 = 0x32;
		const int Bending_REQ_ID_2 = 0x33;
		const int Bending_R_ID_1 = 0x32;
		const int Bending_R_ID_2 = 0x34;
		const int Pass_REQ_ID_1 = 0x33;
		const int Pass_REQ_ID_2 = 0x35;
		const int Pass_R_ID_1 = 0x33;
		const int Pass_R_ID_2 = 0x36;

		/* Robot 통신 Data */
		bool Interlock_R1, Interlock_R2;    // 둘 다 true가 되어야 다음 단계 진행
		int Door_Information;               // 현재 Door가 FDLH인지 FDRH인지를 구분
		const int FDLH = 0x38;
		const int FDRH = 0x34;
		const int Robot1_Number = 0x38;
		const int Robot2_Number = 0x34;
		const int OK_Pass = 0x30;
		const int NG1_Pass = 0x33;
		const int NG2_Pass = 0x32;

		/* Sensor Data Packet 구분 */
		const int Reset_R_ID = 0x10;
		const int Timing_R_ID = 0x0f;
		const int Measured_R_ID = 0x15;

		/* Sensor 통신 Data */
		bool Timing;    // true이면 Timing on 상태 false이면 Timing off 상태

		/* 기타 Data */
		int Bending_Cnt;                // Bending 횟수

		byte[] Copy_X1 = new byte[4];   // Sensor 측정값(Byte)
		byte[] Copy_X2 = new byte[4];   // Sensor 측정값(Byte)
		int X1, X2;                     // Sensor 측정값(Int)
		int X1_DP, X2_DP;               // Sensor 소수점
		int X1_Multiply;                // T, L 계산시 곱셈으로 사용되는 변수
		int X2_Multiply;                // T, L 계산시 곱셈으로 사용되는 변수

		byte[] Byte_X1;                 // 소수점 없는 X1(Byte)
		byte[] Byte_X2;                 // 소수점 없는 X2(Byte)

		float Double_DP_X1;            // 소수점 있는 X1(Double)
		float Double_DP_X2;            // 소수점 있는 X2(Double)

		float X1_Plus_T;               // X1 +Tolerance 
		float X1_Minus_T;              // X1 -Tolerance
		float X2_Plus_T;               // X2 +Tolerance 
		float X2_Minus_T;              // X2 -Tolerance

		float X1_Plus_L;               // X1 +Limit
		float X1_Minus_L;              // X1 -Limit
		float X2_Plus_L;               // X2 +Limit
		float X2_Minus_L;              // X2 -Limit

		const int DP0 = 0;              // (Decimal Point) 소수점 2째짜리(mm)
		const int DP1 = 1;              // 소수점 3째짜리(mm)
		const int DP2 = 2;              // 소수점 4째짜리(mm)
		const int DP3 = 3;              // 소수점 5째짜리(mm)
		const int DP4 = 4;              // 소수점 1째짜리(um)
		const int DP5 = 5;              // 소수점 2째짜리(um)
		const int DP6 = 6;              // 소수점 3째짜리(um)

		private SensorValue First_Sensing {get; set;}
		private SensorValue Second_Sensing { get; set; }
		private SensorValue Third_Sensing { get; set; }
		private SensorValue Delta { get; set; }

		private readonly Sensor sensor;
		private readonly Robot robot;

		public event EventHandler<ConnectEventArgs> Sensor1Connected;
		public event EventHandler<ConnectEventArgs> Sensor2Connected;
		public event EventHandler<DisconnectEventArgs> Sensor1Disconnected;
		public event EventHandler<DisconnectEventArgs> Sensor2Disconnected;

		public event EventHandler<ConnectEventArgs> Robot1Connected;
		public event EventHandler<ConnectEventArgs> Robot2Connected;
		public event EventHandler<DisconnectEventArgs> Robot1Disconnected;
		public event EventHandler<DisconnectEventArgs> Robot2Disconnected;

		public event EventHandler<ExceptionEventArgs> ErrorOccurred;

		public event EventHandler<SensorValueEventArgs> Sensor1ValueReceived;
		public event EventHandler<SensorValueEventArgs> Sensor2ValueReceived;

		public event EventHandler<RobotPhaseEventArgs> Robot1PhaseChanged;
		public event EventHandler<RobotPhaseEventArgs> Robot2PhaseChanged;

		public float Bias { get; set; }
		public bool BypassMode { get; set; }
		public string Robot1IpAddress
		{
			get => robot.Robot1IpAddress;
			set => robot.Robot1IpAddress = value;
		}
		public string Robot2IpAddress
		{
			get => robot.Robot2IpAddress;
			set => robot.Robot2IpAddress = value;
		}

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

			robot.Robot2Connected += Robot_Robot2Connected;
			robot.Robot2Sended += Robot_Robot2Sended;
			robot.Robot2Received += Robot_Robot2Received;
			robot.Robot2Disconnected += Robot_Robot2Disconnected;

			robot.RobotErrorOccurred += Robot_RobotErrorOccurred;
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

		private void Door_Information_R(byte[] D)   // PC에서 Robot으로 보내는 (Door_Information_R) Data Packet
		{
			D[0] = 0x39;                // Bytes 0 to 3 -> 고정값
			D[1] = 0x37;
			D[2] = 0x39;
			D[3] = 0x30;
			D[4] = Door_Info_R_ID_1;    // Bytes 4, 5 -> Door_Information_R 구분
			D[5] = Door_Info_R_ID_2;
			D[6] = 0x46;                // Bytes 6, 7 -> 고정값
			D[7] = 0x46;
			D[8] = 0x30;				// Door_Information과 동일
			D[9] = 0x30;				// Door_Information과 동일 (Door Information Data)
			D[10] = 0x30;               // Bytes 10 to 15 -> 고정값
			D[11] = 0x30;
			D[12] = 0x30;
			D[13] = 0x30;
			D[14] = 0x30;
			D[15] = 0x30;
			D[16] = 0x0D;               // Bytes 16, 17 -> Packet 끝
			D[17] = 0x0A;
		}
		private void Pass_REQ_Input(byte[] P)   // PC에서 Robot으로 보내는 (Pass_REQ_Input) Data Packet
		{
			P[0] = 0x39;				// Bytes 0 to 3 -> 고정값
			P[1] = 0x37;
			P[2] = 0x39;
			P[3] = 0x30;
			P[4] = Pass_REQ_ID_1;		// Bytes 4, 5 -> Pass_REQ_Input 구분
			P[5] = Pass_REQ_ID_2;
			P[6] = 0x46;				// Bytes 6, 7 -> 고정값
			P[7] = 0x46;
			P[8] = 0x30;				// Robot No.
			P[9] = 0x30;				// Pass Case 구분
			P[10] = 0x30;				// Bytes 10 to 15 -> 고정값
			P[11] = 0x30;
			P[12] = 0x30;
			P[13] = 0x30;
			P[14] = 0x30;
			P[15] = 0x30;
			P[16] = 0x0D;				// Bytes 16, 17 -> Packet 끝
			P[17] = 0x0A;
		}
		private void Bending_REQ_Input(byte[] B)    // PC에서 Robot으로 보내는 (Bending_REQ_Input) Data Packet
		{
			B[0] = 0x39;
			B[1] = 0x37;
			B[2] = 0x39;
			B[3] = 0x30;
			B[4] = Bending_REQ_ID_1;    // Bytes 4, 5 -> Bending_REQ_Input 구분
			B[5] = Bending_REQ_ID_2;
			B[6] = 0x30;                // Bytes 6, 7 -> Location No.
			B[7] = 0x30;
			B[8] = 0x30;                // Robot No.
			B[9] = 0x46;                // 고정값
			B[10] = 0x30;               // X1 소수점
			B[11] = 0x30;               // X2 소수점
			B[12] = 0x30;               // Bytes 12 to 20 -> X1 값
			B[13] = 0x30;
			B[14] = 0x30;
			B[15] = 0x30;
			B[16] = 0x30;
			B[17] = 0x30;
			B[18] = 0x30;
			B[19] = 0x30;
			B[20] = 0x30;
			B[21] = 0x30;               // Bytes 21 to 29 -> X2 값
			B[22] = 0x30;
			B[23] = 0x30;
			B[24] = 0x30;
			B[25] = 0x30;
			B[26] = 0x30;
			B[27] = 0x30;
			B[28] = 0x30;
			B[29] = 0x30;
			B[30] = 0x0D;               // Bytes 30, 31 -> Packet 끝
			B[31] = 0x0A;
		}
		private void Reset_Input(byte[] R)  // PC에서 Sensor로 보내는 (Reset_Input) Data Packet
		{
			R[0] = 0x06;
			R[1] = 0x00;
			R[2] = 0x07;
			R[3] = 0x10;
			R[4] = 0x6C;
			R[5] = 0x00;
		}
		private void Timing_On_Input(byte[] TOn)    // PC에서 Sensor로 보내는 (Timing_On_Input) Data Packet
		{
			TOn[0] = 0x06;
			TOn[1] = 0x00;
			TOn[2] = 0x07;
			TOn[3] = 0x0E;
			TOn[4] = 0xEC;
			TOn[5] = 0x00;
		}
		private void Timing_Off_Input(byte[] TOff)  // PC에서 Sensor로 보내는 (Timing_Off_Input) Data Packet
		{
			TOff[0] = 0x06;
			TOff[1] = 0x00;
			TOff[2] = 0x07;
			TOff[3] = 0x0E;
			TOff[4] = 0x6C;
			TOff[5] = 0x00;
		}
		private void Measured_REQ_Input(byte[] M)   // PC에서 Sensor로 보내는 (Measured_REQ_Input) Data Packet
		{
			M[0] = 0x07;
			M[1] = 0x00;
			M[2] = 0x07;
			M[3] = 0x14;
			M[4] = 0x00;
			M[5] = 0x00;
			M[6] = 0x00;
		}
		private void ProcessingSensorData(string IP, byte[] data)
		{
			Buffer.BlockCopy(data, 68, Copy_X1, 0, 4);
			Buffer.BlockCopy(data, 72, Copy_X2, 0, 4);

			X1 = Convert.ToInt32(Copy_X1);
			X1 = Convert.ToInt32(Copy_X2);

			Byte_X1 = Encoding.Default.GetBytes(Convert.ToString(X1));
			Byte_X2 = Encoding.Default.GetBytes(Convert.ToString(X2));

			X1_DP = data[12];
			X2_DP = data[13];

			switch (X1_DP)
			{
				case DP0:
					X1_Multiply = 100;
					Double_DP_X1 = X1 * 0.01f;
					break;

				case DP1:
					X1_Multiply = 1000;
					Double_DP_X1 = X1 * 0.001f;
					break;

				case DP2:
					X1_Multiply = 10000;
					Double_DP_X1 = X1 * 0.0001f;
					break;

				case DP3:
					X1_Multiply = 100000;
					Double_DP_X1 = X1 * 0.00001f;
					break;

				case DP4:
					X1_Multiply = 10000;
					Double_DP_X1 = X1 * 0.1f;
					break;

				case DP5:
					X1_Multiply = 100000;
					Double_DP_X1 = X1 * 0.01f;
					break;

				case DP6:
					X1_Multiply = 1000000;
					Double_DP_X1 = X1 * 0.001f;
					break;
			}
			switch (X2_DP)
			{
				case DP0:
					X2_Multiply = 100;
					Double_DP_X2 = X2 * 0.01f;
					break;

				case DP1:
					X2_Multiply = 1000;
					Double_DP_X2 = X2 * 0.001f;
					break;

				case DP2:
					X2_Multiply = 10000;
					Double_DP_X2 = X2 * 0.0001f;
					break;

				case DP3:
					X2_Multiply = 100000;
					Double_DP_X2 = X2 * 0.00001f;
					break;

				case DP4:
					X2_Multiply = 10000;
					Double_DP_X2 = X2 * 0.1f;
					break;

				case DP5:
					X2_Multiply = 100000;
					Double_DP_X2 = X2 * 0.01f;
					break;

				case DP6:
					X2_Multiply = 1000000;
					Double_DP_X2 = X2 * 0.001f;
					break;
			}

			X1_Plus_L = 3.5f * X1_Multiply;
			X1_Minus_L = -3.5f * X1_Multiply;
			X1_Plus_T = 0.75f * X1_Multiply;
			X1_Minus_T = -0.75f * X1_Multiply;

			X2_Plus_L = 3.5f * X2_Multiply;
			X2_Minus_L = -3.5f * X2_Multiply;
			X2_Plus_T = 0.75f * X2_Multiply;
			X2_Minus_T = -0.75f * X2_Multiply;

			if (Bending_Cnt == 0)
			{
				First_Sensing = new SensorValue(Double_DP_X1, Double_DP_X2);

				if ((X1 < X1_Minus_L || X1 > X1_Plus_L) || (X2 < X2_Minus_L || X2 > X2_Plus_L))
				{
					if (IP == "") Sensor1ValueReceived?.Invoke(this, new SensorValueEventArgs(StatusCode.PASS, First_Sensing, null, null));
					else if (IP == "") Sensor2ValueReceived?.Invoke(this, new SensorValueEventArgs(StatusCode.PASS, First_Sensing, null, null));
				}
				else if ((X1 >= X1_Minus_T && X1 <= X1_Plus_T) && (X2 >= X2_Minus_T && X2 <= X2_Plus_T))
				{
					if (IP == "") Sensor1ValueReceived?.Invoke(this, new SensorValueEventArgs(StatusCode.FAILED, First_Sensing, null, null));
					else if (IP == "") Sensor2ValueReceived?.Invoke(this, new SensorValueEventArgs(StatusCode.FAILED, First_Sensing, null, null));
				}
			}
			else if (Bending_Cnt == 1)
			{
				Second_Sensing = new SensorValue(Double_DP_X1, Double_DP_X2);
				Delta = new SensorValue(Second_Sensing.Sensor1 - First_Sensing.Sensor1, Second_Sensing.Sensor2 - First_Sensing.Sensor2);

				if (IP == "") Sensor1ValueReceived?.Invoke(this, new SensorValueEventArgs(StatusCode.FIRST_BENDED, First_Sensing, Second_Sensing, Delta));
				else if (IP == "") Sensor2ValueReceived?.Invoke(this, new SensorValueEventArgs(StatusCode.FIRST_BENDED, First_Sensing, Second_Sensing, Delta));
			}
			else if (Bending_Cnt == 2)
			{
				Third_Sensing = new SensorValue(Double_DP_X1, Double_DP_X2);
				Delta = new SensorValue(Third_Sensing.Sensor1 - Second_Sensing.Sensor1, Third_Sensing.Sensor2 - Second_Sensing.Sensor2);

				if (IP == "") Sensor1ValueReceived?.Invoke(this, new SensorValueEventArgs(StatusCode.SECOND_BENDED, Second_Sensing, Third_Sensing, Delta));
				else if (IP == "") Sensor2ValueReceived?.Invoke(this, new SensorValueEventArgs(StatusCode.SECOND_BENDED, Second_Sensing, Third_Sensing, Delta));
			}
		}

		private void Sensor_Sensor1Connected(object sender, ConnectEventArgs e)
		{
			Sensor1Connected?.Invoke(sender, e);
		}
		private void Sensor_Sensor1Sended(object sender, SendEventArgs e)
		{
		}
		private void Sensor_Sensor1Received(object sender, ReceiveEventArgs e)
		{
			byte[] Timing_On = new byte[6];
			byte[] Timing_Off = new byte[6];
			byte[] Measured_REQ = new byte[7];
			byte[] Pass_REQ = new byte[18];
			byte[] Bending_REQ = new byte[32];
			byte[] Sensor1_Receive_Data = e.Data;

			if (e.BytesRead == 9 && Sensor1_Receive_Data[3] == Reset_R_ID)
			{
				Timing_On_Input(Timing_On);
				Timing = true;
				// delay 필요
				SendToSensor1(Timing_On);
			}
			else if (e.BytesRead == 9 && Sensor1_Receive_Data[3] == Timing_R_ID)
			{
				if (Timing)
				{
					Timing_Off_Input(Timing_Off);
					Timing = false;
					SendToSensor1(Timing_Off);
				}
				else
				{
					Measured_REQ_Input(Measured_REQ);
					SendToSensor1(Measured_REQ);
				}
			}
			else if (e.BytesRead == 116 && Sensor1_Receive_Data[3] == Measured_R_ID)
			{
				ProcessingSensorData(e.IP, Sensor1_Receive_Data);

				if ((X1 >= X1_Minus_T && X1 <= X1_Plus_T) && (X2 >= X2_Minus_T && X2 <= X2_Plus_T)) // X1, X2 둘 다 +-0.75 안에 들어오는 경우 (정상적인 Pass)
				{
					Pass_REQ_Input(Pass_REQ);

					Pass_REQ[8] = Robot1_Number;
					Pass_REQ[9] = OK_Pass;
					SendToRobot1(Pass_REQ);

					Pass_REQ[8] = Robot2_Number;
					SendToRobot2(Pass_REQ);
				}
				else if ((X1 < X1_Minus_L || X1 > X1_Plus_L) || (X2 < X2_Minus_L || X2 > X2_Plus_L))   // X1, X2 둘 중 하나라도 -3.5보다 작거나 3.5보다 클 경우 (Error 상황에서의 Pass)
				{
					Pass_REQ_Input(Pass_REQ);

					Pass_REQ[8] = Robot1_Number;
					Pass_REQ[9] = NG1_Pass;
					SendToRobot1(Pass_REQ);

					Pass_REQ[8] = Robot2_Number;
					SendToRobot2(Pass_REQ);
				}
				else if (Bending_Cnt == 2 && (X1 >= X1_Minus_L && X1 <= X1_Plus_L) && (X2 >= X2_Minus_L && X2 <= X2_Plus_L) && ((X1 < X1_Minus_T || X1 > X1_Plus_T) || (X2 < X2_Minus_T || X2 > X2_Plus_T)))    // 2번 Bending 했지만 X1, X2가 정상적인 Pass가 아닌 경우 (Error 상황에서의 Pass)
				{
					Pass_REQ_Input(Pass_REQ);

					Pass_REQ[8] = Robot1_Number;
					Pass_REQ[9] = NG2_Pass;
					SendToRobot1(Pass_REQ);

					Pass_REQ[8] = Robot2_Number;
					SendToRobot2(Pass_REQ);
				}
				else if (Bending_Cnt < 2 && (X1 >= X1_Minus_L && X1 <= X1_Plus_L) && (X2 >= X2_Minus_L && X2 <= X2_Plus_L) && ((X1 < X1_Minus_T || X1 > X1_Plus_T) || (X2 < X2_Minus_T || X2 > X2_Plus_T)))     // Bending이 필요한 경우
				{
					Bending_REQ_Input(Bending_REQ);

					Bending_REQ[10] = Convert.ToByte(Convert.ToString(X1_DP));
					Bending_REQ[11] = Convert.ToByte(Convert.ToString(X2_DP));

					if (X1 >= 0)
					{
						Bending_REQ[12] = 0x2b; // '+'
						Buffer.BlockCopy(Byte_X1, 0, Bending_REQ, 20 - Byte_X1.Length + 1, Byte_X1.Length); 
					}

					else
					{
						Bending_REQ[12] = 0x2d; // '-'
						Buffer.BlockCopy(Byte_X1, 1, Bending_REQ, 20 - Byte_X1.Length + 2, Byte_X1.Length - 1);
					}

					if (X2 >= 0)
					{
						Bending_REQ[21] = 0x2b; // '+'
						Buffer.BlockCopy(Byte_X2, 0, Bending_REQ, 29 - Byte_X2.Length + 1, Byte_X2.Length); 
					}

					else
					{
						Bending_REQ[21] = 0x2d; // '-'
						Buffer.BlockCopy(Byte_X2, 1, Bending_REQ, 29 - Byte_X2.Length + 2, Byte_X2.Length - 1); 
					}

					Bending_REQ[8] = Robot1_Number;
					SendToRobot1(Bending_REQ);

					Bending_REQ[8] = Robot2_Number;
					SendToRobot2(Bending_REQ);
				}
			}
		}
		private void Sensor_Sensor1Disconnected(object sender, DisconnectEventArgs e)
		{
			Sensor1Disconnected?.Invoke(sender, e);
		}
		private void Sensor_Sensor1ErrorOccurred(object sender, ExceptionEventArgs e) => ErrorOccurred?.Invoke(sender, e);

		private void Sensor_Sensor2Connected(object sender, ConnectEventArgs e)
		{
			Sensor2Connected?.Invoke(sender, e);
		}
		private void Sensor_Sensor2Sended(object sender, SendEventArgs e)
		{
		}
		private void Sensor_Sensor2Received(object sender, ReceiveEventArgs e)
		{
			byte[] Timing_On = new byte[6];
			byte[] Timing_Off = new byte[6];
			byte[] Measured_REQ = new byte[7];
			byte[] Pass_REQ = new byte[18];
			byte[] Bending_REQ = new byte[32];
			byte[] Sensor2_Receive_Data = e.Data;

			if (e.BytesRead == 9 && Sensor2_Receive_Data[3] == Reset_R_ID)
			{
				Timing_On_Input(Timing_On);
				Timing = true;
				// delay필요
				SendToSensor2(Timing_On);
			}
			else if (e.BytesRead == 9 && Sensor2_Receive_Data[3] == Timing_R_ID)
			{
				if (Timing)
				{
					Timing_Off_Input(Timing_Off);
					Timing = false;
					SendToSensor2(Timing_Off);
				}
				else
				{
					Measured_REQ_Input(Measured_REQ);
					SendToSensor2(Measured_REQ);
				}
			}
			else if (e.BytesRead == 116 && Sensor2_Receive_Data[3] == Measured_R_ID)
			{
				ProcessingSensorData(e.IP, Sensor2_Receive_Data);

				if ((X1 >= X1_Minus_T && X1 <= X1_Plus_T) && (X2 >= X2_Minus_T && X2 <= X2_Plus_T)) // X1, X2 둘 다 +-0.75 안에 들어오는 경우 (정상적인 Pass)
				{
					Pass_REQ_Input(Pass_REQ);

					Pass_REQ[8] = Robot1_Number;
					Pass_REQ[9] = OK_Pass;
					SendToRobot1(Pass_REQ);

					Pass_REQ[8] = Robot2_Number;
					SendToRobot2(Pass_REQ);
				}
				else if ((X1 < X1_Minus_L || X1 > X1_Plus_L) || (X2 < X2_Minus_L || X2 > X2_Plus_L))   // X1, X2 둘 중 하나라도 -3.5보다 작거나 3.5보다 클 경우 (Error 상황에서의 Pass)
				{
					Pass_REQ_Input(Pass_REQ);

					Pass_REQ[8] = Robot1_Number;
					Pass_REQ[9] = NG1_Pass;
					SendToRobot1(Pass_REQ);

					Pass_REQ[8] = Robot2_Number;
					SendToRobot2(Pass_REQ);
				}
				else if (Bending_Cnt == 2 && (X1 >= X1_Minus_L && X1 <= X1_Plus_L) && (X2 >= X2_Minus_L && X2 <= X2_Plus_L) && ((X1 < X1_Minus_T || X1 > X1_Plus_T) || (X2 < X2_Minus_T || X2 > X2_Plus_T)))    // 2번 Bending 했지만 X1, X2가 정상적인 Pass가 아닌 경우 (Error 상황에서의 Pass)
				{
					Pass_REQ_Input(Pass_REQ);

					Pass_REQ[8] = Robot1_Number;
					Pass_REQ[9] = NG2_Pass;
					SendToRobot1(Pass_REQ);

					Pass_REQ[8] = Robot2_Number;
					SendToRobot2(Pass_REQ);
				}
				else if (Bending_Cnt < 2 && (X1 >= X1_Minus_L && X1 <= X1_Plus_L) && (X2 >= X2_Minus_L && X2 <= X2_Plus_L) && ((X1 < X1_Minus_T || X1 > X1_Plus_T) || (X2 < X2_Minus_T || X2 > X2_Plus_T)))     // Bending이 필요한 경우
				{
					Bending_REQ_Input(Bending_REQ);

					Bending_REQ[10] = Convert.ToByte(Convert.ToString(X1_DP));
					Bending_REQ[11] = Convert.ToByte(Convert.ToString(X2_DP));

					if (X1 >= 0)
					{
						Bending_REQ[12] = 0x2b; // '+'
						Buffer.BlockCopy(Byte_X1, 0, Bending_REQ, 20 - Byte_X1.Length + 1, Byte_X1.Length);
					}

					else
					{
						Bending_REQ[12] = 0x2d; // '-'
						Buffer.BlockCopy(Byte_X1, 1, Bending_REQ, 20 - Byte_X1.Length + 2, Byte_X1.Length - 1);
					}

					if (X2 >= 0)
					{
						Bending_REQ[21] = 0x2b; // '+'
						Buffer.BlockCopy(Byte_X2, 0, Bending_REQ, 29 - Byte_X2.Length + 1, Byte_X2.Length);
					}

					else
					{
						Bending_REQ[21] = 0x2d; // '-'
						Buffer.BlockCopy(Byte_X2, 1, Bending_REQ, 29 - Byte_X2.Length + 2, Byte_X2.Length - 1);
					}

					Bending_REQ[8] = Robot1_Number;
					SendToRobot1(Bending_REQ);

					Bending_REQ[8] = Robot2_Number;
					SendToRobot2(Bending_REQ);
				}
			}
		}
		private void Sensor_Sensor2Disconnected(object sender, DisconnectEventArgs e)
		{
			Sensor2Disconnected?.Invoke(sender, e);
		}
		private void Sensor_Sensor2ErrorOccurred(object sender, ExceptionEventArgs e) => ErrorOccurred?.Invoke(sender, e);

		private void Robot_Robot1Connected(object sender, ConnectEventArgs e)
		{
			Robot1Connected?.Invoke(sender, e);
		}
		private void Robot_Robot1Sended(object sender, SendEventArgs e)
		{
		}
		private void Robot_Robot1Received(object sender, ReceiveEventArgs e)
		{
			Door_Information = 0;
			Interlock_R1 = false;
			byte[] Door_Info_R_R1 = new byte[18];
			byte[] Reset = new byte[6];
			byte[] Robot1_Receive_Data = e.Data;

			if (Robot1_Receive_Data[4] == Door_Info_ID_1 && Robot1_Receive_Data[5] == Door_Info_ID_2)
			{
				if (Robot1_Receive_Data[9] == FDLH)
				{
					Door_Information_R(Door_Info_R_R1);
					Door_Info_R_R1[8] = Robot1_Receive_Data[8];
					Door_Info_R_R1[9] = Robot1_Receive_Data[9];

					Interlock_R1 = true;
					Door_Information = FDLH;
					SendToRobot1(Door_Info_R_R1);

					while (!(Interlock_R1 && Interlock_R2)) ;

					Reset_Input(Reset);
					SendToSensor1(Reset);
				}

				else if (Robot1_Receive_Data[9] == FDRH)
				{
					Door_Information_R(Door_Info_R_R1);
					Door_Info_R_R1[8] = Robot1_Receive_Data[8];
					Door_Info_R_R1[9] = Robot1_Receive_Data[9];

					Interlock_R1 = true;
					Door_Information = FDRH;
					SendToRobot1(Door_Info_R_R1);

					while (!(Interlock_R1 && Interlock_R2)) ;

					Reset_Input(Reset);
					SendToSensor2(Reset);
				}
			}

			else if(Robot1_Receive_Data[4] == Pass_R_ID_1 && Robot1_Receive_Data[5] == Pass_R_ID_2)
			{
				Interlock_R1 = true;
				while (!(Interlock_R1 && Interlock_R2)) ;
				Bending_Cnt = 0;
			}

			else if (Robot1_Receive_Data[4] == Bending_R_ID_1 && Robot1_Receive_Data[5] == Bending_R_ID_2)
			{
				Interlock_R1 = true;
				while (!(Interlock_R1 && Interlock_R2)) ;
				Bending_Cnt++;

				if (Door_Information == FDLH)
				{
					Reset_Input(Reset);
					SendToSensor1(Reset);
				}

				else if (Door_Information == FDRH)
				{
					Reset_Input(Reset);
					SendToSensor2(Reset);
				}
			}
		}
		private void Robot_Robot1Disconnected(object sender, DisconnectEventArgs e)
		{
			Robot1Disconnected?.Invoke(sender, e);
		}

		private void Robot_Robot2Connected(object sender, ConnectEventArgs e)
		{
			Robot2Connected?.Invoke(sender, e);
		}
		private void Robot_Robot2Sended(object sender, SendEventArgs e)
		{
		}
		private void Robot_Robot2Received(object sender, ReceiveEventArgs e)
		{
			byte[] Door_Info_R_R2 = new byte[18];
			byte[] Robot2_Receive_Data = e.Data;

			if (Robot2_Receive_Data[4] == Door_Info_ID_1 && Robot2_Receive_Data[5] == Door_Info_ID_2)
			{
				if (Robot2_Receive_Data[9] == FDLH)
				{
					Door_Information_R(Door_Info_R_R2);
					Door_Info_R_R2[8] = Robot2_Receive_Data[8];
					Door_Info_R_R2[9] = Robot2_Receive_Data[9];

					Interlock_R2 = true;
					SendToRobot2(Door_Info_R_R2);
				}

				else if (Robot2_Receive_Data[9] == FDRH)
				{
					Door_Information_R(Door_Info_R_R2);
					Door_Info_R_R2[8] = Robot2_Receive_Data[8];
					Door_Info_R_R2[9] = Robot2_Receive_Data[9];

					Interlock_R2 = true;
					SendToRobot2(Door_Info_R_R2);
				}
			}

			else if (Robot2_Receive_Data[4] == Pass_R_ID_1 && Robot2_Receive_Data[5] == Pass_R_ID_2)
			{
				Interlock_R2 = true;
			}

			else if (Robot2_Receive_Data[4] == Bending_R_ID_1 && Robot2_Receive_Data[5] == Bending_R_ID_2)
			{
				Interlock_R2 = true;
			}
		}
		private void Robot_Robot2Disconnected(object sender, DisconnectEventArgs e)
		{
			Robot2Disconnected?.Invoke(sender, e);
		}

		private void Robot_RobotErrorOccurred(object sender, ExceptionEventArgs e) => ErrorOccurred?.Invoke(sender, e);
	}
}