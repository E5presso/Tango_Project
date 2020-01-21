using System;
using System.ComponentModel;
using System.Net.Sockets;

namespace Core.CompactNet
{
	internal class Session : IDisposable
	{
		private readonly int buffersize;

		private readonly Socket socket;
		private readonly byte[] buffer;

		public string IP { get; }
		public bool IsClosed { private set; get; } = false;

		public event SendEvent Sended;
		public event ReceiveEvent Received;
		public event DisconnectEvent Disconnected;
		public event ExceptionEvent ErrorOccurred;

		public Session(Socket socket, int buffersize)
		{
			this.socket = socket;
			this.buffersize = buffersize;

			IP = socket.RemoteEndPoint.ToString();
			buffer = new byte[buffersize];
			if (socket.Connected)
			{
				try
				{
					IsClosed = false;
					socket.BeginReceive(buffer, 0, buffersize, 0, new AsyncCallback(OnReceived), null);
				}
				catch (Exception e) { ErrorOccurred?.Invoke(e); }
			}
		}

		public void Send(byte[] data)
		{
			if (socket.Connected)
			{
				try
				{
					socket.BeginSend(data, 0, data.Length, 0, new AsyncCallback((ar) =>
					{
						int bytesSent = socket.EndSend(ar) - 4;
						Sended?.Invoke(this, bytesSent);
					}), null);
				}
				catch (Exception e) { ErrorOccurred?.Invoke(e); }
			}
			else
			{
				ErrorOccurred?.Invoke(new InvalidOperationException("현재 소켓이 연결되어있지 않습니다."));
			}
		}
		public void Close()
		{
			if (socket.Connected && !IsClosed)
			{
				try
				{
					IsClosed = true;
					socket.Shutdown(SocketShutdown.Both);
					socket.BeginDisconnect(false, new AsyncCallback((ar) =>
					{
						socket.EndDisconnect(ar);
						Disconnected?.Invoke(this);
					}), null);
				}
				catch (Exception e) { ErrorOccurred?.Invoke(e); }
			}
			else
			{
				ErrorOccurred?.Invoke(new InvalidOperationException("현재 소켓이 연결되어있지 않습니다."));
			}
		}

		private void OnReceived(IAsyncResult ar)
		{
			try
			{
				int bytesRead = socket.EndReceive(ar);
				if (bytesRead > 0)
				{
					byte[] data = new byte[bytesRead];
					Buffer.BlockCopy(buffer, 0, data, 0, bytesRead);
					Array.Clear(buffer, 0, bytesRead);
					socket.BeginReceive(buffer, 0, buffersize, 0, new AsyncCallback(OnReceived), null);
					Received?.Invoke(this, bytesRead, data);
				}
				else
				{
					Close();
				}
			}
			catch (Exception e)
			{
				if (e is Win32Exception w && w.ErrorCode == 10054)
				{
					Disconnected?.Invoke(this);
				}
				else
				{
					ErrorOccurred?.Invoke(e);
				}
			}
		}
		#region IDisposable Support
		private bool disposedValue = false;
		~Session()
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
				Close();
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