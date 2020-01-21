using System;
using System.Threading;
using System.ComponentModel;
using System.Net;
using System.Net.Sockets;

namespace Core.CompactNet
{
	internal class Connector : IDisposable
	{
		private int size;
		private IPEndPoint point;
		private Socket socket;

		public string LocalIP;
		public bool AutoConnect { get; set; } = false;
		public int RetryInterval { get; set; }

		public event ConnectEvent Connected;
		public event ExceptionEvent ErrorOccurred;

		public void Start(string address, int port, int buffersize, bool autoConnect, int retryInterval)
		{
			try
			{
				size = buffersize;
				AutoConnect = autoConnect;
				RetryInterval = retryInterval;
				IPAddress ip = Dns.GetHostAddresses(address)[0];
				point = new IPEndPoint(ip, port);
				socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
				void Callback(IAsyncResult ar)
				{
					try
					{
						socket.EndConnect(ar);
						LocalIP = socket.LocalEndPoint.ToString();
						Connected?.BeginInvoke(new Session(socket, size), new AsyncCallback((iar) => Connected?.EndInvoke(iar)), null);
					}
					catch (Exception e)
					{
						if (e is Win32Exception w && w.ErrorCode == 10061 && AutoConnect)
						{
							Thread.Sleep(RetryInterval);
							socket.BeginConnect(point, new AsyncCallback(Callback), null);
						}
						else
						{
							ErrorOccurred?.BeginInvoke(e, new AsyncCallback((iar) => ErrorOccurred?.EndInvoke(iar)), null);
						}
					}
				}
				socket.BeginConnect(point, new AsyncCallback(Callback), null);
			}
			catch (Exception e) { ErrorOccurred?.BeginInvoke(e, new AsyncCallback((ar) => ErrorOccurred?.EndInvoke(ar)), null); }
		}
		#region IDisposable Support
		private bool disposedValue = false;
		~Connector()
		{
			Dispose(false);
		}
		protected virtual void Dispose(bool disposing)
		{
			if (!disposedValue)
			{
				if (disposing)
				{
					socket.Dispose();
				}
				point = null;
				LocalIP = null;
				disposedValue = true;
			}
		}
		public void Dispose()
		{
			Dispose(true);
			GC.SuppressFinalize(this);
		}
		#endregion
	}
}