using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Core.Collections;
using Core.Network;

namespace InterlockTest
{
	public partial class Form1 : Form
	{
		private bool PcStatusFlag = true;
		private bool SocketFlag = true;
		private bool BypassFlag = false;
		private bool SensorStatusFlag = false;
		private int BendingSequence = 0;

		private readonly Server server = new Server();
		private readonly Thread thread;


		public Form1()
		{
			InitializeComponent();

			server.Connected += Server_Connected;
			server.Sended += Server_Sended;
			server.Received += Server_Received;
			server.Disconnected += Server_Disconnected;
			server.ErrorOccurred += Server_ErrorOccurred;

			server.Open(11002, 100, 1500, false);
			thread = new Thread(new ThreadStart(() =>
			{
				while (true)
				{
					if (PcStatusFlag)
					{
						string url1 = "http://124.127.248.84/KCLDO/SET%20VAR%20[REAL_OUT]pgs=true";
						HttpWebRequest request1 = WebRequest.Create(url1) as HttpWebRequest;
						request1.GetResponse();

						string url2 = "http://124.127.248.85/KCLDO/SET%20VAR%20[REAL_OUT]pgs=true";
						HttpWebRequest request2 = WebRequest.Create(url2) as HttpWebRequest;
						request2.GetResponse();
					}
					Thread.Sleep(1000);
				}
			}));
			thread.Start();
		}

		private void EnableButtons()
		{
			Pass.Enabled = true;
			Ng.Enabled = true;
			BendingPass.Enabled = true;
			BendingNg.Enabled = true;
			SensorDataStatus.Enabled = true;
		}
		private void DisableButtons()
		{
			Pass.Enabled = false;
			Ng.Enabled = false;
			BendingPass.Enabled = false;
			BendingNg.Enabled = false;
			SensorDataStatus.Enabled = false;
		}

		private void Server_Connected(object sender, ConnectEventArgs e)
		{
		}
		private void Server_Sended(object sender, SendEventArgs e)
		{
		}
		private void Server_Received(object sender, ReceiveEventArgs e)
		{
			byte[] packet = e.Data;
			if (packet[4] == 0x31 && packet[5] == 0x31)
			{
				// Door Information
				packet[5] = 0x32;
				server.Send(packet);
				EnableButtons();
			}
			else if (packet[4] == 0x32 && packet[5] == 0x34)
			{
				if (BendingSequence == 1)
				{
					packet = new byte[]
					{
						0x39, 0x37, 0x39, 0x30, 0x33, 0x35, 0x46, 0x46,
						0x38, 0x30, 0x30, 0x30, 0x30, 0x30, 0x30, 0x30,
						0x0D, 0x0A
					};
					server.Send(packet);
					BendingSequence = 0;
					DisableButtons();
				}
				else if (BendingSequence == 2)
				{
					packet = new byte[]
					{
						0x39, 0x37, 0x39, 0x30, 0x33, 0x35, 0x46, 0x46,
						0x38, 0x33, 0x30, 0x30, 0x30, 0x30, 0x30, 0x30,
						0x0D, 0x0A
					};
					server.Send(packet);
					BendingSequence = 0;
					DisableButtons();
				}
				else if (BendingSequence == 3)
				{
					BendingSequence = 0;
					DisableButtons();
				}
			}
		}
		private void Server_Disconnected(object sender, DisconnectEventArgs e)
		{
		}
		private void Server_ErrorOccurred(object sender, ExceptionEventArgs e)
		{
		}

		private void Pass_Click(object sender, EventArgs e)
		{
			byte[] packet = new byte[]
			{
				0x39, 0x37, 0x39, 0x30, 0x33, 0x35, 0x46, 0x46,
				0x38, 0x30, 0x30, 0x30, 0x30, 0x30, 0x30, 0x30,
				0x0D, 0x0A
			};
			server.Send(packet);
			DisableButtons();
		}
		private void Ng_Click(object sender, EventArgs e)
		{
			byte[] packet = new byte[]
			{
				0x39, 0x37, 0x39, 0x30, 0x33, 0x35, 0x46, 0x46,
				0x38, 0x33, 0x30, 0x30, 0x30, 0x30, 0x30, 0x30,
				0x0D, 0x0A
			};
			server.Send(packet);
			DisableButtons();
		}
		private void BendingPass_Click(object sender, EventArgs e)
		{
			byte[] packet = new byte[]
			{
				0x39, 0x37, 0x39, 0x30, 0x32, 0x33, 0x30, 0x30,
				0x38, 0x46, 0x30, 0x30, 0x2B, 0x30, 0x30, 0x30,
				0x30, 0x30, 0x31, 0x30, 0x30, 0x2D, 0x30, 0x30,
				0x30, 0x30, 0x30, 0x31, 0x30, 0x30, 0x0D, 0x0A
			};
			server.Send(packet);
			BendingSequence = 1;
		}
		private void BendingNg_Click(object sender, EventArgs e)
		{
			byte[] packet = new byte[]
			{
				0x39, 0x37, 0x39, 0x30, 0x32, 0x33, 0x30, 0x30,
				0x38, 0x46, 0x30, 0x30, 0x2B, 0x30, 0x30, 0x30,
				0x30, 0x30, 0x31, 0x30, 0x30, 0x2D, 0x30, 0x30,
				0x30, 0x30, 0x30, 0x31, 0x30, 0x30, 0x0D, 0x0A
			};
			server.Send(packet);
			BendingSequence = 2;
		}
		private void PcStatus_Click(object sender, EventArgs e)
		{
			PcStatusFlag = !PcStatusFlag;
		}
		private void PcComError_Click(object sender, EventArgs e)
		{
			if (SocketFlag)
			{
				server.Close();
				SocketFlag = false;
			}
			else
			{
				server.Open(11002, 100, 1500, false);
				SocketFlag = true;
			}
		}
		private void SensorStatus_Click(object sender, EventArgs e)
		{
			if (SensorStatusFlag)
			{
				string url1 = "http://124.127.248.84/KCLDO/SET%20PORT%20DOUT[647]=OFF";
				HttpWebRequest request1 = WebRequest.Create(url1) as HttpWebRequest;
				request1.GetResponse();

				string url2 = "http://124.127.248.85/KCLDO/SET%20PORT%20DOUT[647]=OFF";
				HttpWebRequest request2 = WebRequest.Create(url2) as HttpWebRequest;
				request2.GetResponse();

				SensorStatusFlag = false;
			}
			else
			{
				string url1 = "http://124.127.248.84/KCLDO/SET%20PORT%20DOUT[647]=ON";
				HttpWebRequest request1 = WebRequest.Create(url1) as HttpWebRequest;
				request1.GetResponse();

				string url2 = "http://124.127.248.85/KCLDO/SET%20PORT%20DOUT[647]=ON";
				HttpWebRequest request2 = WebRequest.Create(url2) as HttpWebRequest;
				request2.GetResponse();

				SensorStatusFlag = true;
			}
		}
		private void SensorDataStatus_Click(object sender, EventArgs e)
		{
			byte[] packet = new byte[]
			{
				0x39, 0x37, 0x39, 0x30, 0x32, 0x33, 0x30, 0x30,
				0x38, 0x46, 0x30, 0x30, 0x2B, 0x30, 0x30, 0x30,
				0x30, 0x39, 0x30, 0x30, 0x30, 0x2D, 0x30, 0x30,
				0x30, 0x30, 0x39, 0x30, 0x30, 0x30, 0x0D, 0x0A
			};
			server.Send(packet);
			BendingSequence = 3;
		}
		private void Bypass_Click(object sender, EventArgs e)
		{
			if (BypassFlag)
			{
				string url1 = "http://124.127.248.84/KCLDO/SET%20PORT%20DOUT[649]=OFF";
				HttpWebRequest request1 = WebRequest.Create(url1) as HttpWebRequest;
				request1.GetResponse();

				string url2 = "http://124.127.248.85/KCLDO/SET%20PORT%20DOUT[649]=OFF";
				HttpWebRequest request2 = WebRequest.Create(url2) as HttpWebRequest;
				request2.GetResponse();

				BypassFlag = false;
			}
			else
			{
				string url1 = "http://124.127.248.84/KCLDO/SET%20PORT%20DOUT[649]=ON";
				HttpWebRequest request1 = WebRequest.Create(url1) as HttpWebRequest;
				request1.GetResponse();

				string url2 = "http://124.127.248.85/KCLDO/SET%20PORT%20DOUT[649]=ON";
				HttpWebRequest request2 = WebRequest.Create(url2) as HttpWebRequest;
				request2.GetResponse();

				BypassFlag = true;
			}
		}

		private void Form1_FormClosing(object sender, FormClosingEventArgs e)
		{
			thread.Abort();
			server.Dispose();
		}
	}
}