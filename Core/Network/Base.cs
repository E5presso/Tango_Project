using System;
using System.ComponentModel;

namespace Core.Network
{
	/// <summary>
	/// 소켓 연결시 발생하는 이벤트에 대한 정보입니다.
	/// </summary>
	public class ConnectEventArgs : EventArgs
	{
		/// <summary>
		/// 클라이언트의 IP주소를 가져옵니다.
		/// </summary>
		public string IP { get; private set; }

		/// <summary>
		/// AcceptEventArgs 클래스를 초기화합니다.
		/// </summary>
		/// <param name="ip">클라이언트의 IP주소를 지정합니다.</param>
		public ConnectEventArgs(string ip) => IP = ip;
	}
	/// <summary>
	/// 데이터 전송완료시 발생하는 이벤트에 대한 정보입니다.
	/// </summary>
	public class SendEventArgs : EventArgs
	{
		/// <summary>
		/// 클라이언트의 IP주소를 가져옵니다.
		/// </summary>
		public string IP { get; private set; }
		/// <summary>
		/// 전송된 데이터의 크기를 가져옵니다.
		/// </summary>
		public int BytesSent { get; private set; }

		/// <summary>
		/// SendEventArgs 클래스를 초기화합니다.
		/// </summary>
		/// <param name="ip">클라이언트의 IP주소를 지정합니다.</param>
		/// <param name="bytessent">전송된 데이터의 크기를 지정합니다.</param>
		public SendEventArgs(string ip, int bytessent)
		{
			IP = ip;
			BytesSent = bytessent;
		}
	}
	/// <summary>
	/// 데이터 수신완료시 발생하는 이벤트에 대한 정보입니다.
	/// </summary>
	public class ReceiveEventArgs : EventArgs
	{
		/// <summary>
		/// 클라이언트의 IP주소를 가져옵니다.
		/// </summary>
		public string IP { get; private set; }
		/// <summary>
		/// 수신된 데이터의 크기를 가져옵니다.
		/// </summary>
		public int BytesRead { get; private set; }
		/// <summary>
		/// 수신된 데이터를 가져옵니다.
		/// </summary>
		public byte[] Data { get; private set; }

		/// <summary>
		/// ReceiveEventArgs 클래스를 초기화합니다.
		/// </summary>
		/// <param name="ip">클라이언트의 IP주소를 지정합니다.</param>
		/// <param name="bytesread">수신된 데이터의 크기를 지정합니다.</param>
		/// <param name="data">수신된 데이터를 지정합니다.</param>
		public ReceiveEventArgs(string ip, int bytesread, byte[] data)
		{
			IP = ip;
			BytesRead = bytesread;
			Data = data;
		}
	}
	/// <summary>
	/// 소켓의 연결해제시 발생하는 이벤트에 대한 정보입니다.
	/// </summary>
	public class DisconnectEventArgs : EventArgs
	{
		/// <summary>
		/// 클라이언트의 IP주소를 가져옵니다.
		/// </summary>
		public string IP { get; private set; }

		/// <summary>
		/// DisconnectEventArgs 클래스를 초기화합니다.
		/// </summary>
		/// <param name="ip">클라이언트의 IP주소를 지정합니다.</param>
		public DisconnectEventArgs(string ip) => IP = ip;
	}
	/// <summary>
	/// 소켓 연결 거부 시 발생하는 이벤트에 대한 정보입니다.
	/// </summary>
	public class ConnectionRefusedEventArgs : EventArgs
	{
		/// <summary>
		/// 클라이언트의 IP주소를 가져옵니다.
		/// </summary>
		public string IP { get; private set; }

		/// <summary>
		/// DisconnectEventArgs 클래스를 초기화합니다.
		/// </summary>
		/// <param name="ip">클라이언트의 IP주소를 지정합니다.</param>
		public ConnectionRefusedEventArgs(string ip) => IP = ip;
	}
	/// <summary>
	/// 예외발생 이벤트에 대한 정보를 정의합니다.
	/// </summary>
	public class ExceptionEventArgs : EventArgs
	{
		/// <summary>
		/// 예외발생에 대한 정보를 담고 있는 개체를 가져옵니다.
		/// </summary>
		public Exception Exception { get; private set; }
		/// <summary>
		/// 에러 메세지를 가져옵니다.
		/// </summary>
		public string Message => Exception.Message;
		/// <summary>
		/// 에러 코드를 가져옵니다. 시스템 에러가 아니라면 -1을 반환합니다.
		/// </summary>
		public int ErrorCode => (Exception is Win32Exception e) ? e.ErrorCode : -1;
		/// <summary>
		/// 예외 발생 시 호출된 함수의 콜스택을 가져옵니다.
		/// </summary>
		public string StackTrace => Exception.StackTrace;

		/// <summary>
		/// 지정한 예외발생 정보를 이용해 ExceptionEventArgs 클래스를 초기화합니다.
		/// </summary>
		/// <param name="e">예외발생에 대한 정보를 지정합니다.</param>
		public ExceptionEventArgs(Exception e) => Exception = e;
		/// <summary>
		/// 예외발생 정보를 문자열 형식으로 반환합니다.
		/// </summary>
		/// <returns>문자열로 변환된 예외발생 정보입니다.</returns>
		public override string ToString() => Exception.ToString();
	}

	internal delegate void ConnectEvent(Session session);
	internal delegate void SendEvent(Session session, int bytesSent);
	internal delegate void ReceiveEvent(Session session, int bytesRead, byte[] data);
	internal delegate void DisconnectEvent(Session session);
	internal delegate void ConnectionRefusedEvent(string ip);
	internal delegate void ExceptionEvent(Exception e);

	/// <summary>
	/// 네트워크 관련 유틸리티 클래스입니다.
	/// </summary>
	public static class NetworkUtilities
	{
		/// <summary>
		/// 주소 문자열을 포트번호와 IP주소로 분리합니다.
		/// </summary>
		/// <param name="address">분리할 주소를 지정합니다.</param>
		/// <param name="ip">분리된 IP주소를 반환합니다.</param>
		/// <param name="port">분리된 포트번호를 반환합니다.</param>
		public static void ParseAddressWithPort(string address, out string ip, out int port)
		{
			string[] parsed = address.Split(':');
			ip = parsed[0];
			port = Convert.ToInt32(parsed[1]);
		}
		/// <summary>
		/// IP 주소의 유효성을 검증합니다.
		/// </summary>
		/// <param name="ip">검증할 IP 주소를 지정합니다.</param>
		/// <param name="includesPort">포트 번호를 포함하는지 여부를 지정합니다.</param>
		/// <returns>IP 주소의 검증 결과를 반환합니다.</returns>
		public static bool ValidateIPAddress(string ip, bool includesPort)
		{
			if (string.IsNullOrWhiteSpace(ip)) return false;
			if (includesPort)
			{
				string[] parsed = ip.Split(':');
				if (parsed.Length != 2) return false;
				string address = parsed[0];
				if (parsed[1].Length == 0) return false;
				try
				{
					int port = Convert.ToInt32(parsed[1]);
					if (port > 65535) return false;
				}
				catch { return false; }
				string[] ipsections = address.Split('.');
				if (ipsections.Length != 4) return false;
				try
				{
					foreach (string section in ipsections)
						if (Convert.ToInt32(section) > 255) return false;
				}
				catch { return false; }
				return true;
			}
			else
			{
				string[] ipsections = ip.Split('.');
				if (ipsections.Length != 4) return false;
				try
				{
					foreach (string section in ipsections)
						if (Convert.ToInt32(section) > 255) return false;
				}
				catch { return false; }
				return true;
			}
		}
		/// <summary>
		/// 두 IP주소가 같은지 여부를 확인합니다.
		/// </summary>
		/// <param name="left">비교할 IP주소를 지정합니다.</param>
		/// <param name="right">비교할 IP주소를 지정합니다.</param>
		/// <returns>두 IP주소의 비교 결과를 반환합니다.</returns>
		public static bool CompareIPAddress(string left, string right)
		{
			string[] parsed_left = left.Split(':');
			string[] parsed_right = right.Split(':');
			return parsed_left[0] == parsed_right[0];
		}
	}
}