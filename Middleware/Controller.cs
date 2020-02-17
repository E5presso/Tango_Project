using System;
using System.Text;
using System.Threading;
using Core.Network;
using System.Net;

namespace Middleware
{
	public class Controller
	{
		private bool Sensor1_pingReceived = true; // 센서 핑 수신여부
		private bool Sensor2_pingReceived = true; // 센서 핑 수신여부
		private bool InternalFlag = false; // BENDING PASS || BENDING NG 내부 플래그 (테스트 용)

		public bool PassFlag { get; set; } = false; // PASS 테스트 용
		public bool NgFlag { get; set; } = false; // NG 테스트 용
		public bool BPassFlag { get; set; } = false; // BENDING PASS 테스트 용
		public bool BNgFlag { get; set; } = false; // BENDING NG 테스트 용
		public bool PcCommErrorFlag { get; set; } = true; // PC_COMM_ERROR 테스트 용
		public bool SensorStatusFlag { get; set; } = true; // SENSOR_STATUS 테스트 용
		public bool SensorDataStatusFlag { get; set; } = false; // SENSOR_DATA_STATUS 테스트 용

		public bool BYPASS_MODE { get; set; } = false; // BYPASS 모드 스위치

		/* Robot Data Packet 구분 */
		const int Door_Info_ID_1 = 0x31;
		const int Door_Info_ID_2 = 0x31;
		const int Door_Info_R_ID_1 = 0x31;
		const int Door_Info_R_ID_2 = 0x32;
		const int Robot_Info_ID_1 = 0x31;
		const int Robot_Info_ID_2 = 0x33;
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
		const int FDLH = 0x32;
		const int FDRH = 0x31;
		const int Robot1_Number = 0x32;
		const int Robot2_Number = 0x31;
		const int OK_Pass = 0x30;
		const int NG1_Pass = 0x33;
		const int NG2_Pass = 0x32;

		/* Sensor Data Packet 구분 */
		const int Reset_R_ID = 0x11;
		const int Timing_R_ID = 0x0f;
		const int Measured_R_ID = 0x15;

		/* Sensor 통신 Data */
		bool Timing;    // true이면 Timing on 상태 false이면 Timing off 상태

		/* 기타 Data */
		int Bending_Cnt;                // Bending 횟수

		int X1, X2;                     // Sensor 측정값(Int)
		int X1_DP, X2_DP;               // Sensor 소수점
		int X1_Multiply;                // T, L 계산시 곱셈으로 사용되는 변수
		int X2_Multiply;                // T, L 계산시 곱셈으로 사용되는 변수

		byte[] Byte_X1;                 // 소수점 없는 X1(Byte)
		byte[] Byte_X2;                 // 소수점 없는 X2(Byte)

		float Double_DP_X1;             // 소수점 있는 X1(Double)
		float Double_DP_X2;             // 소수점 있는 X2(Double)

		float X1_Plus_T;                // X1 +Tolerance 
		float X1_Minus_T;               // X1 -Tolerance
		float X2_Plus_T;                // X2 +Tolerance 
		float X2_Minus_T;               // X2 -Tolerance

		float X1_Plus_L;                // X1 +Limit
		float X1_Minus_L;               // X1 -Limit
		float X2_Plus_L;                // X2 +Limit
		float X2_Minus_L;               // X2 -Limit

		const int DP0 = 0;              // (Decimal Point) 소수점 2째짜리(mm)
		const int DP1 = 1;              // 소수점 3째짜리(mm)
		const int DP2 = 2;              // 소수점 4째짜리(mm)
		const int DP3 = 3;              // 소수점 5째짜리(mm)
		const int DP4 = 4;              // 소수점 1째짜리(um)
		const int DP5 = 5;              // 소수점 2째짜리(um)
		const int DP6 = 6;              // 소수점 3째짜리(um)

		const int Home = 0x31;          // Home 위치
		const int Ready = 0x32;         // 준비 위치
		const int B_Ready = 0x33;       // Bending 준비 위치
		const int B_Strat = 0x34;       // Bending 시작(Door까지의 위치)
		const int B_End = 0x35;         // Bending 후(실제 Door를 미는 위치)

		readonly byte[] SENSOR_PING_REQ = new byte[]
		{
			0x09, 0x00, 0x07, 0x0A, 0x00, 0x01, 0x02, 0x00, 0x00
		};

		private SensorValue First_Sensing { get; set; }
		private SensorValue Second_Sensing { get; set; }
		private SensorValue Third_Sensing { get; set; }
		private SensorValue Delta { get; set; }

		private readonly Thread sensorPingThread;
		private readonly Thread robotPingThread;
		private readonly Thread bypassPingThread;

		private readonly Sensor sensor;
		private readonly Robot robot;

		public event EventHandler<string> SensorPingReceived;
		public event EventHandler DoorInformationReceived;

		public event EventHandler<ConnectEventArgs> Sensor1Connected;
		public event EventHandler<ConnectEventArgs> Sensor2Connected;
		public event EventHandler<SendEventArgs> Sensor1Sended;
		public event EventHandler<SendEventArgs> Sensor2Sended;
		public event EventHandler<ReceiveEventArgs> Sensor1Received;
		public event EventHandler<ReceiveEventArgs> Sensor2Received;
		public event EventHandler<SensorValueEventArgs> Sensor1ValueReceived;
		public event EventHandler<SensorValueEventArgs> Sensor2ValueReceived;
		public event EventHandler<ConnectionRefusedEventArgs> Sensor1ConnectionRefused;
		public event EventHandler<ConnectionRefusedEventArgs> Sensor2ConnectionRefused;
		public event EventHandler<DisconnectEventArgs> Sensor1Disconnected;
		public event EventHandler<DisconnectEventArgs> Sensor2Disconnected;

		public event EventHandler<ConnectEventArgs> Robot1Connected;
		public event EventHandler<ConnectEventArgs> Robot2Connected;
		public event EventHandler<SendEventArgs> Robot1Sended;
		public event EventHandler<SendEventArgs> Robot2Sended;
		public event EventHandler<ReceiveEventArgs> Robot1Received;
		public event EventHandler<ReceiveEventArgs> Robot2Received;
		public event EventHandler<RobotPhaseEventArgs> Robot1PhaseChanged;
		public event EventHandler<RobotPhaseEventArgs> Robot2PhaseChanged;
		public event EventHandler<DisconnectEventArgs> Robot1Disconnected;
		public event EventHandler<DisconnectEventArgs> Robot2Disconnected;

		public event EventHandler<ExceptionEventArgs> ErrorOccurred;

		public bool IsRobotServerActive => robot.IsActive;
		public bool IsSensor1Connected => sensor.IsSensor1Connected;
		public bool IsSensor2Connected => sensor.IsSensor2Connected;

		public string Sensor1IpAddress
		{
			get => sensor.Sensor1IpAddress;
			set => sensor.Sensor1IpAddress = value;
		}
		public string Sensor2IpAddress
		{
			get => sensor.Sensor2IpAddress;
			set => sensor.Sensor2IpAddress = value;
		}
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
		public float S1_X1_Offset { get; set; }
		public float S1_X2_Offset { get; set; }
		public float S2_X1_Offset { get; set; }
		public float S2_X2_Offset { get; set; }

		public Controller()
		{
			sensor = new Sensor();
			robot = new Robot();

			sensor.Sensor1Connected += Sensor_Sensor1Connected;
			sensor.Sensor1Sended += Sensor_Sensor1Sended;
			sensor.Sensor1Received += Sensor_Sensor1Received;
			sensor.Sensor1Disconnected += Sensor_Sensor1Disconnected;
			sensor.Sensor1ConnectionRefused += Sensor_Sensor1ConnectionRefused;
			sensor.Sensor1ErrorOccurred += Sensor_Sensor1ErrorOccurred;

			sensor.Sensor2Connected += Sensor_Sensor2Connected;
			sensor.Sensor2Sended += Sensor_Sensor2Sended;
			sensor.Sensor2Received += Sensor_Sensor2Received;
			sensor.Sensor2Disconnected += Sensor_Sensor2Disconnected;
			sensor.Sensor2ConnectionRefused += Sensor_Sensor2ConnectionRefused;
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

			sensorPingThread = new Thread(new ThreadStart(() =>
			{
				while (true)
				{
					if (Sensor1_pingReceived && Sensor2_pingReceived)
					{
						if (SensorStatusFlag)
						{
							try
							{
								string url1 = $"http://{Robot1IpAddress}/KCL/SET%20PORT%20DOUT[647]=ON";
								HttpWebRequest request1 = WebRequest.Create(url1) as HttpWebRequest;
								request1.BeginGetResponse(new AsyncCallback((ar) =>
								{
									try
									{
										request1.EndGetResponse(ar);
									}
									catch (Exception ex) { ErrorOccurred?.Invoke(this, new ExceptionEventArgs(ex)); }
								}), request1);
							}
							catch (Exception ex) { ErrorOccurred?.Invoke(this, new ExceptionEventArgs(ex)); }
							try
							{
								string url2 = $"http://{Robot2IpAddress}/KCL/SET%20PORT%20DOUT[647]=ON";
								HttpWebRequest request2 = WebRequest.Create(url2) as HttpWebRequest;
								request2.BeginGetResponse(new AsyncCallback((ar) =>
								{
									try
									{
										request2.EndGetResponse(ar);
									}
									catch (Exception ex) { ErrorOccurred?.Invoke(this, new ExceptionEventArgs(ex)); }
								}), request2);
							}
							catch (Exception ex) { ErrorOccurred?.Invoke(this, new ExceptionEventArgs(ex)); }
						}
						else
						{
							try
							{
								string url1 = $"http://{Robot1IpAddress}/KCL/SET%20PORT%20DOUT[647]=OFF";
								HttpWebRequest request1 = WebRequest.Create(url1) as HttpWebRequest;
								request1.BeginGetResponse(new AsyncCallback((ar) =>
								{
									try
									{
										request1.EndGetResponse(ar);
									}
									catch (Exception ex) { ErrorOccurred?.Invoke(this, new ExceptionEventArgs(ex)); }
								}), request1);
							}
							catch (Exception ex) { ErrorOccurred?.Invoke(this, new ExceptionEventArgs(ex)); }
							try
							{
								string url2 = $"http://{Robot2IpAddress}/KCL/SET%20PORT%20DOUT[647]=OFF";
								HttpWebRequest request2 = WebRequest.Create(url2) as HttpWebRequest;
								request2.BeginGetResponse(new AsyncCallback((ar) =>
								{
									try
									{
										request2.EndGetResponse(ar);
									}
									catch (Exception ex) { ErrorOccurred?.Invoke(this, new ExceptionEventArgs(ex)); }
								}), request2);
							}
							catch (Exception ex) { ErrorOccurred?.Invoke(this, new ExceptionEventArgs(ex)); }
						}
						SendToSensor1(SENSOR_PING_REQ);
						SendToSensor2(SENSOR_PING_REQ);
					}
					else
					{
						try
						{
							string url1 = $"http://{Robot1IpAddress}/KCL/SET%20PORT%20DOUT[647]=OFF";
							HttpWebRequest request1 = WebRequest.Create(url1) as HttpWebRequest;
							request1.BeginGetResponse(new AsyncCallback((ar) =>
							{
								try
								{
									request1.EndGetResponse(ar);
								}
								catch (Exception ex) { ErrorOccurred?.Invoke(this, new ExceptionEventArgs(ex)); }
							}), request1);
						}
						catch (Exception ex) { ErrorOccurred?.Invoke(this, new ExceptionEventArgs(ex)); }
						try
						{
							string url2 = $"http://{Robot2IpAddress}/KCL/SET%20PORT%20DOUT[647]=OFF";
							HttpWebRequest request2 = WebRequest.Create(url2) as HttpWebRequest;
							request2.BeginGetResponse(new AsyncCallback((ar) =>
							{
								try
								{
									request2.EndGetResponse(ar);
								}
								catch (Exception ex) { ErrorOccurred?.Invoke(this, new ExceptionEventArgs(ex)); }
							}), request2);
						}
						catch (Exception ex) { ErrorOccurred?.Invoke(this, new ExceptionEventArgs(ex)); }
					}
					Thread.Sleep(1000);
				}
			}));
			robotPingThread = new Thread(new ThreadStart(() =>
			{
				while (true)
				{
					if (PcCommErrorFlag)
					{
						try
						{
							string url1 = $"http://{Robot1IpAddress}/KCLDO/SET%20VAR%20[REAL_OUT]pgs=true";
							HttpWebRequest request1 = WebRequest.Create(url1) as HttpWebRequest;
							request1.BeginGetResponse(new AsyncCallback((ar) =>
							{
								try
								{
									request1.EndGetResponse(ar);
								}
								catch (Exception ex) { ErrorOccurred?.Invoke(this, new ExceptionEventArgs(ex)); }
							}), request1);
						}
						catch (Exception ex) { ErrorOccurred?.Invoke(this, new ExceptionEventArgs(ex)); }
						try
						{
							string url2 = $"http://{Robot2IpAddress}/KCLDO/SET%20VAR%20[REAL_OUT]pgs=true";
							HttpWebRequest request2 = WebRequest.Create(url2) as HttpWebRequest;
							request2.BeginGetResponse(new AsyncCallback((ar) =>
							{
								try
								{
									request2.EndGetResponse(ar);
								}
								catch (Exception ex) { ErrorOccurred?.Invoke(this, new ExceptionEventArgs(ex)); }
							}), request2);
						}
						catch (Exception ex) { ErrorOccurred?.Invoke(this, new ExceptionEventArgs(ex)); }
					}
					Thread.Sleep(1000);
				}
			}));
			bypassPingThread = new Thread(new ThreadStart(() =>
			{
				while (true)
				{
					if (BYPASS_MODE)
					{
						try
						{
							string url1 = "http://124.127.248.84/KCLDO/SET%20PORT%20DOUT[649]=ON";
							HttpWebRequest request1 = WebRequest.Create(url1) as HttpWebRequest;
							request1.BeginGetResponse(new AsyncCallback((ar) =>
							{
								try
								{
									request1.EndGetResponse(ar);
								}
								catch (Exception ex) { ErrorOccurred?.Invoke(this, new ExceptionEventArgs(ex)); }
							}), request1);
						}
						catch (Exception ex) { ErrorOccurred?.Invoke(this, new ExceptionEventArgs(ex)); }
						try
						{
							string url2 = "http://124.127.248.85/KCLDO/SET%20PORT%20DOUT[649]=ON";
							HttpWebRequest request2 = WebRequest.Create(url2) as HttpWebRequest;
							request2.BeginGetResponse(new AsyncCallback((ar) =>
							{
								try
								{
									request2.EndGetResponse(ar);
								}
								catch (Exception ex) { ErrorOccurred?.Invoke(this, new ExceptionEventArgs(ex)); }
							}), request2);
						}
						catch (Exception ex) { ErrorOccurred?.Invoke(this, new ExceptionEventArgs(ex)); }
					}
					else
					{
						try
						{
							string url1 = "http://124.127.248.84/KCLDO/SET%20PORT%20DOUT[649]=OFF";
							HttpWebRequest request1 = WebRequest.Create(url1) as HttpWebRequest;
							request1.BeginGetResponse(new AsyncCallback((ar) =>
							{
								try
								{
									request1.EndGetResponse(ar);
								}
								catch (Exception ex) { ErrorOccurred?.Invoke(this, new ExceptionEventArgs(ex)); }
							}), request1);
						}
						catch (Exception ex) { ErrorOccurred?.Invoke(this, new ExceptionEventArgs(ex)); }
						try
						{
							string url2 = "http://124.127.248.85/KCLDO/SET%20PORT%20DOUT[649]=OFF";
							HttpWebRequest request2 = WebRequest.Create(url2) as HttpWebRequest;
							request2.BeginGetResponse(new AsyncCallback((ar) =>
							{
								try
								{
									request2.EndGetResponse(ar);
								}
								catch (Exception ex) { ErrorOccurred?.Invoke(this, new ExceptionEventArgs(ex)); }
							}), request2);
						}
						catch (Exception ex) { ErrorOccurred?.Invoke(this, new ExceptionEventArgs(ex)); }
					}
					Thread.Sleep(1000);
				}
			}));

			sensorPingThread.Start();
			robotPingThread.Start();
			bypassPingThread.Start();
		}

		public void ConnectToSensor1(string ip, int port, int buffersize) => sensor.ConnectToSensor1(ip, port, buffersize);
		public void ConnectToSensor2(string ip, int port, int buffersize) => sensor.ConnectToSensor2(ip, port, buffersize);
		public void DisconnectFromSensor1() => sensor.DisconnectFromSensor1();
		public void DisconnectFromSensor2() => sensor.DisconnectFromSensor2();

		public void StartRobotServer(int port, int buffersize) => robot.Start(port, buffersize);
		public void StopRobotServer() => robot.Stop();

		public void Stop()
		{
			DisconnectFromSensor1();
			DisconnectFromSensor2();
			StopRobotServer();

			sensorPingThread.Abort();
			robotPingThread.Abort();
			bypassPingThread.Abort();
		}

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
			D[8] = 0x30;                // Door_Information과 동일
			D[9] = 0x30;                // Door_Information과 동일 (Door Information Data)
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
			P[0] = 0x39;                // Bytes 0 to 3 -> 고정값
			P[1] = 0x37;
			P[2] = 0x39;
			P[3] = 0x30;
			P[4] = Pass_REQ_ID_1;       // Bytes 4, 5 -> Pass_REQ_Input 구분
			P[5] = Pass_REQ_ID_2;
			P[6] = 0x46;                // Bytes 6, 7 -> 고정값
			P[7] = 0x46;
			P[8] = 0x30;                // Robot No.
			P[9] = 0x30;                // Pass Case 구분
			P[10] = 0x30;               // Bytes 10 to 15 -> 고정값
			P[11] = 0x30;
			P[12] = 0x30;
			P[13] = 0x30;
			P[14] = 0x30;
			P[15] = 0x30;
			P[16] = 0x0D;               // Bytes 16, 17 -> Packet 끝
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
			X1 = BitConverter.ToInt32(data, 68);
			X2 = BitConverter.ToInt32(data, 72);

			Byte_X1 = Encoding.ASCII.GetBytes(Convert.ToString(X1));
			Byte_X2 = Encoding.ASCII.GetBytes(Convert.ToString(X2));

			X1_DP = data[11];
			X2_DP = data[12];

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

			Double_DP_X1 = (float)Math.Round(Double_DP_X1, 2);
			Double_DP_X2 = (float)Math.Round(Double_DP_X2, 2);

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
					if (IP == Sensor1IpAddress) Sensor1ValueReceived?.Invoke(this, new SensorValueEventArgs(StatusCode.FAILED, First_Sensing, null, null));
					else if (IP == Sensor2IpAddress) Sensor2ValueReceived?.Invoke(this, new SensorValueEventArgs(StatusCode.FAILED, First_Sensing, null, null));
				}
				else if ((X1 >= X1_Minus_T && X1 <= X1_Plus_T) && (X2 >= X2_Minus_T && X2 <= X2_Plus_T))
				{
					if (IP == Sensor1IpAddress) Sensor1ValueReceived?.Invoke(this, new SensorValueEventArgs(StatusCode.PASS, First_Sensing, null, null));
					else if (IP == Sensor2IpAddress) Sensor2ValueReceived?.Invoke(this, new SensorValueEventArgs(StatusCode.PASS, First_Sensing, null, null));
				}
			}
			else if (Bending_Cnt == 1)
			{
				Second_Sensing = new SensorValue(Double_DP_X1, Double_DP_X2);
				Delta = new SensorValue(Second_Sensing.Sensor1 - First_Sensing.Sensor1, Second_Sensing.Sensor2 - First_Sensing.Sensor2);

				if (IP == Sensor1IpAddress) Sensor1ValueReceived?.Invoke(this, new SensorValueEventArgs(StatusCode.FIRST_BENDED, First_Sensing, Second_Sensing, Delta));
				else if (IP == Sensor2IpAddress) Sensor2ValueReceived?.Invoke(this, new SensorValueEventArgs(StatusCode.FIRST_BENDED, First_Sensing, Second_Sensing, Delta));
			}
			else if (Bending_Cnt == 2)
			{
				Third_Sensing = new SensorValue(Double_DP_X1, Double_DP_X2);
				Delta = new SensorValue(Third_Sensing.Sensor1 - Second_Sensing.Sensor1, Third_Sensing.Sensor2 - Second_Sensing.Sensor2);

				if (IP == Sensor1IpAddress) Sensor1ValueReceived?.Invoke(this, new SensorValueEventArgs(StatusCode.SECOND_BENDED, Second_Sensing, Third_Sensing, Delta));
				else if (IP == Sensor2IpAddress) Sensor2ValueReceived?.Invoke(this, new SensorValueEventArgs(StatusCode.SECOND_BENDED, Second_Sensing, Third_Sensing, Delta));
			}
		}

		private void Sensor_Sensor1Connected(object sender, ConnectEventArgs e)
		{
			Sensor1_pingReceived = true;
			Sensor1Connected?.Invoke(sender, e);
		}
		private void Sensor_Sensor1Sended(object sender, SendEventArgs e)
		{
			Sensor1Sended?.Invoke(sender, e);
		}
		private void Sensor_Sensor1Received(object sender, ReceiveEventArgs e)
		{
			Sensor1Received?.Invoke(sender, e);

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
				Thread.Sleep(100);
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

				if (PassFlag)
				{
					Pass_REQ_Input(Pass_REQ);

					Pass_REQ[8] = Robot1_Number;
					Pass_REQ[9] = OK_Pass;
					SendToRobot1(Pass_REQ);

					Pass_REQ[8] = Robot2_Number;
					SendToRobot2(Pass_REQ);
					PassFlag = false;
				}
				else if (NgFlag)
				{
					Pass_REQ_Input(Pass_REQ);

					Pass_REQ[8] = Robot1_Number;
					Pass_REQ[9] = NG1_Pass;
					SendToRobot1(Pass_REQ);

					Pass_REQ[8] = Robot2_Number;
					SendToRobot2(Pass_REQ);
					NgFlag = false;
				}
				else if (BPassFlag || BNgFlag)
				{
					if (BPassFlag && InternalFlag)
					{
						byte[] packet = new byte[]
						{
							0x39, 0x37, 0x39, 0x30, 0x33, 0x35, 0x46, 0x46,
							0x38, 0x30, 0x30, 0x30, 0x30, 0x30, 0x30, 0x30,
							0x0D, 0x0A
						};
						InternalFlag = false;
						BPassFlag = false;
						packet[8] = Robot1_Number;
						SendToRobot1(packet);

						packet[8] = Robot2_Number;
						SendToRobot2(packet);
					}
					else if (BNgFlag && InternalFlag)
					{
						byte[] packet = new byte[]
						{
							0x39, 0x37, 0x39, 0x30, 0x33, 0x35, 0x46, 0x46,
							0x38, 0x33, 0x30, 0x30, 0x30, 0x30, 0x30, 0x30,
							0x0D, 0x0A
						};
						InternalFlag = false;
						BNgFlag = false;
						packet[8] = Robot1_Number;
						SendToRobot1(packet);

						packet[8] = Robot2_Number;
						SendToRobot2(packet);
					}
					else
					{
						byte[] packet = new byte[]
						{
							0x39, 0x37, 0x39, 0x30, 0x32, 0x33, 0x30, 0x30,
							0x38, 0x46, 0x30, 0x30, 0x2B, 0x30, 0x30, 0x30,
							0x30, 0x30, 0x31, 0x30, 0x30, 0x2B, 0x30, 0x30,
							0x30, 0x30, 0x30, 0x31, 0x30, 0x30, 0x0D, 0x0A
						};
						packet[8] = Robot1_Number;
						SendToRobot1(packet);

						packet[8] = Robot2_Number;
						SendToRobot2(packet);
					}
				}
				else if (SensorDataStatusFlag)
				{
					byte[] packet = new byte[]
					{
							0x39, 0x37, 0x39, 0x30, 0x32, 0x33, 0x30, 0x30,
							0x38, 0x46, 0x30, 0x30, 0x2B, 0x30, 0x30, 0x30,
							0x30, 0x31, 0x30, 0x30, 0x30, 0x2B, 0x30, 0x30,
							0x30, 0x30, 0x31, 0x30, 0x30, 0x30, 0x0D, 0x0A
					};
					packet[8] = Robot1_Number;
					SendToRobot1(packet);

					packet[8] = Robot2_Number;
					SendToRobot2(packet);
					SensorDataStatusFlag = false;
				}
				else
				{
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

						Bending_REQ[10] = Encoding.ASCII.GetBytes(X1_DP.ToString())[0];
						Bending_REQ[11] = Encoding.ASCII.GetBytes(X2_DP.ToString())[0];

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
			else if (e.BytesRead == 8)
			{
				SensorPingReceived?.Invoke(this, Core.Utilities.Convert.ToHexCode(Sensor1_Receive_Data));
			}
		}
		private void Sensor_Sensor1Disconnected(object sender, DisconnectEventArgs e)
		{
			Sensor1_pingReceived = false;
			Sensor1Disconnected?.Invoke(sender, e);
		}
		private void Sensor_Sensor1ConnectionRefused(object sender, ConnectionRefusedEventArgs e)
		{
			Sensor1ConnectionRefused?.Invoke(sender, e);
		}
		private void Sensor_Sensor1ErrorOccurred(object sender, ExceptionEventArgs e)
		{
			ErrorOccurred?.Invoke(sender, e);
		}

		private void Sensor_Sensor2Connected(object sender, ConnectEventArgs e)
		{
			Sensor2_pingReceived = true;
			Sensor2Connected?.Invoke(sender, e);
		}
		private void Sensor_Sensor2Sended(object sender, SendEventArgs e)
		{
			Sensor2Sended?.Invoke(sender, e);
		}
		private void Sensor_Sensor2Received(object sender, ReceiveEventArgs e)
		{
			Sensor2Received?.Invoke(sender, e);

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
				Thread.Sleep(100);
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
				if (PassFlag)
				{
					Pass_REQ_Input(Pass_REQ);

					Pass_REQ[8] = Robot1_Number;
					Pass_REQ[9] = OK_Pass;
					SendToRobot1(Pass_REQ);

					Pass_REQ[8] = Robot2_Number;
					SendToRobot2(Pass_REQ);
					PassFlag = false;
				}
				else if (NgFlag)
				{
					Pass_REQ_Input(Pass_REQ);

					Pass_REQ[8] = Robot1_Number;
					Pass_REQ[9] = NG1_Pass;
					SendToRobot1(Pass_REQ);

					Pass_REQ[8] = Robot2_Number;
					SendToRobot2(Pass_REQ);
					NgFlag = false;
				}
				else if (BPassFlag || BNgFlag)
				{
					if (BPassFlag && InternalFlag)
					{
						byte[] packet = new byte[]
						{
							0x39, 0x37, 0x39, 0x30, 0x33, 0x35, 0x46, 0x46,
							0x38, 0x30, 0x30, 0x30, 0x30, 0x30, 0x30, 0x30,
							0x0D, 0x0A
						};
						InternalFlag = false;
						BPassFlag = false;
						packet[8] = Robot1_Number;
						SendToRobot1(packet);

						packet[8] = Robot2_Number;
						SendToRobot2(packet);
					}
					else if (BNgFlag && InternalFlag)
					{
						byte[] packet = new byte[]
						{
							0x39, 0x37, 0x39, 0x30, 0x33, 0x35, 0x46, 0x46,
							0x38, 0x33, 0x30, 0x30, 0x30, 0x30, 0x30, 0x30,
							0x0D, 0x0A
						};
						InternalFlag = false;
						BNgFlag = false;
						packet[8] = Robot1_Number;
						SendToRobot1(packet);

						packet[8] = Robot2_Number;
						SendToRobot2(packet);
					}
					else
					{
						byte[] packet = new byte[]
						{
							0x39, 0x37, 0x39, 0x30, 0x32, 0x33, 0x30, 0x30,
							0x38, 0x46, 0x30, 0x30, 0x2B, 0x30, 0x30, 0x30,
							0x30, 0x30, 0x31, 0x30, 0x30, 0x2B, 0x30, 0x30,
							0x30, 0x30, 0x30, 0x31, 0x30, 0x30, 0x0D, 0x0A
						};
						packet[8] = Robot1_Number;
						SendToRobot1(packet);

						packet[8] = Robot2_Number;
						SendToRobot2(packet);
					}
				}
				else if (SensorDataStatusFlag)
				{
					byte[] packet = new byte[]
					{
							0x39, 0x37, 0x39, 0x30, 0x32, 0x33, 0x30, 0x30,
							0x38, 0x46, 0x30, 0x30, 0x2B, 0x30, 0x30, 0x30,
							0x30, 0x31, 0x30, 0x30, 0x30, 0x2B, 0x30, 0x30,
							0x30, 0x30, 0x31, 0x30, 0x30, 0x30, 0x0D, 0x0A
					};
					packet[8] = Robot1_Number;
					SendToRobot1(packet);

					packet[8] = Robot2_Number;
					SendToRobot2(packet);
					SensorDataStatusFlag = false;
				}
				else
				{
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

						Bending_REQ[10] = Encoding.ASCII.GetBytes(X1_DP.ToString())[0];
						Bending_REQ[11] = Encoding.ASCII.GetBytes(X2_DP.ToString())[0];

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
			else if (e.BytesRead == 8)
			{
				SensorPingReceived?.Invoke(this, Core.Utilities.Convert.ToHexCode(Sensor2_Receive_Data));
			}
		}
		private void Sensor_Sensor2Disconnected(object sender, DisconnectEventArgs e)
		{
			Sensor2_pingReceived = false;
			Sensor2Disconnected?.Invoke(sender, e);
		}
		private void Sensor_Sensor2ConnectionRefused(object sender, ConnectionRefusedEventArgs e)
		{
			Sensor2ConnectionRefused?.Invoke(sender, e);
		}
		private void Sensor_Sensor2ErrorOccurred(object sender, ExceptionEventArgs e)
		{
			ErrorOccurred?.Invoke(sender, e);
		}

		private void Robot_Robot1Connected(object sender, ConnectEventArgs e)
		{
			Robot1Connected?.Invoke(sender, e);
		}
		private void Robot_Robot1Sended(object sender, SendEventArgs e)
		{
			Robot1Sended?.Invoke(sender, e);
		}
		private void Robot_Robot1Received(object sender, ReceiveEventArgs e)
		{
			Robot1Received?.Invoke(sender, e);

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

					Door_Information = FDLH;
					SendToRobot1(Door_Info_R_R1);
					Interlock_R1 = true;
					Reset_Input(Reset);
					while (!Interlock_R1 || !Interlock_R2) ;
					SendToSensor1(Reset);
				}

				else if (Robot1_Receive_Data[9] == FDRH)
				{
					Door_Information_R(Door_Info_R_R1);
					Door_Info_R_R1[8] = Robot1_Receive_Data[8];
					Door_Info_R_R1[9] = Robot1_Receive_Data[9];

					Door_Information = FDRH;
					SendToRobot1(Door_Info_R_R1);
					Interlock_R1 = true;
					Reset_Input(Reset);
					while (!Interlock_R1 || !Interlock_R2) ;
					SendToSensor2(Reset);
				}
				DoorInformationReceived?.Invoke(this, new EventArgs());
			}
			else if (Robot1_Receive_Data[4] == Pass_R_ID_1 && Robot1_Receive_Data[5] == Pass_R_ID_2)
			{
				Interlock_R1 = true;
				Bending_Cnt = 0;
				Door_Information = 0;
			}
			else if (Robot1_Receive_Data[4] == Bending_R_ID_1 && Robot1_Receive_Data[5] == Bending_R_ID_2)
			{
				Interlock_R1 = true;
				Bending_Cnt++;

				if (BPassFlag || BNgFlag) InternalFlag = true;
				if (Door_Information == FDLH)
				{
					Reset_Input(Reset);
					while (!Interlock_R1 || !Interlock_R2) ;
					SendToSensor1(Reset);
				}

				else if (Door_Information == FDRH)
				{
					Reset_Input(Reset);
					while (!Interlock_R1 || !Interlock_R2) ;
					SendToSensor2(Reset);
				}
			}
			else if (Robot1_Receive_Data[4] == Robot_Info_ID_1 && Robot1_Receive_Data[5] == Robot_Info_ID_2)
			{
				switch (Robot1_Receive_Data[8])
				{
					case Home:
						Robot1PhaseChanged?.Invoke(this, new RobotPhaseEventArgs(PhaseCode.HOME));
						break;

					case Ready:
						Robot1PhaseChanged?.Invoke(this, new RobotPhaseEventArgs(PhaseCode.READY));
						break;

					case B_Ready:
						Robot1PhaseChanged?.Invoke(this, new RobotPhaseEventArgs(PhaseCode.BENDING_READY));
						break;

					case B_Strat:
						Robot1PhaseChanged?.Invoke(this, new RobotPhaseEventArgs(PhaseCode.BENDING_START));
						break;

					case B_End:
						Robot1PhaseChanged?.Invoke(this, new RobotPhaseEventArgs(PhaseCode.BENDING_END));
						break;
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
			Robot2Sended?.Invoke(sender, e);
		}
		private void Robot_Robot2Received(object sender, ReceiveEventArgs e)
		{
			Robot2Received?.Invoke(sender, e);

			byte[] Door_Info_R_R2 = new byte[18];
			byte[] Robot2_Receive_Data = e.Data;

			if (Robot2_Receive_Data[4] == Door_Info_ID_1 && Robot2_Receive_Data[5] == Door_Info_ID_2)
			{
				if (Robot2_Receive_Data[9] == FDLH)
				{
					Door_Information_R(Door_Info_R_R2);
					Door_Info_R_R2[8] = Robot2_Receive_Data[8];
					Door_Info_R_R2[9] = Robot2_Receive_Data[9];

					SendToRobot2(Door_Info_R_R2);
					Interlock_R2 = true;
				}

				else if (Robot2_Receive_Data[9] == FDRH)
				{
					Door_Information_R(Door_Info_R_R2);
					Door_Info_R_R2[8] = Robot2_Receive_Data[8];
					Door_Info_R_R2[9] = Robot2_Receive_Data[9];

					SendToRobot2(Door_Info_R_R2);
					Interlock_R2 = true;
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
			else if (Robot2_Receive_Data[4] == Robot_Info_ID_1 && Robot2_Receive_Data[5] == Robot_Info_ID_2)
			{
				switch (Robot2_Receive_Data[8])
				{
					case Home:
						Robot2PhaseChanged?.Invoke(this, new RobotPhaseEventArgs(PhaseCode.HOME));
						break;

					case Ready:
						Robot2PhaseChanged?.Invoke(this, new RobotPhaseEventArgs(PhaseCode.READY));
						break;

					case B_Ready:
						Robot2PhaseChanged?.Invoke(this, new RobotPhaseEventArgs(PhaseCode.BENDING_READY));
						break;

					case B_Strat:
						Robot2PhaseChanged?.Invoke(this, new RobotPhaseEventArgs(PhaseCode.BENDING_START));
						break;

					case B_End:
						Robot2PhaseChanged?.Invoke(this, new RobotPhaseEventArgs(PhaseCode.BENDING_END));
						break;
				}
			}
		}
		private void Robot_Robot2Disconnected(object sender, DisconnectEventArgs e)
		{
			Robot2Disconnected?.Invoke(sender, e);
		}

		private void Robot_RobotErrorOccurred(object sender, ExceptionEventArgs e)
		{
			ErrorOccurred?.Invoke(sender, e);
		}
	}
}