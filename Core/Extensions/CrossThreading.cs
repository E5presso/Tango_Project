using System.ComponentModel;

namespace Core.Extensions
{
	/// <summary>
	/// 컨트롤의 크로스스레딩을 지원합니다.
	/// </summary>
	public static class CrossThreading
	{
		/// <summary>
		/// 컨트롤의 크로스스레딩을 위한 전달인자입니다.
		/// </summary>
		/// <typeparam name="T">컨트롤의 형식을 지정합니다.</typeparam>
		/// <param name="obj">컨트롤 통신을 위한 인자입니다.</param>
		public delegate void SyncInvokeThread<T>(T obj) where T : ISynchronizeInvoke;

		/// <summary>
		/// 컨트롤의 크로스스레딩을 수행합니다.
		/// </summary>
		/// <typeparam name="T">컨트롤의 형식을 지정합니다.</typeparam>
		/// <param name="obj">컨트롤 통신을 위한 인자입니다.</param>
		/// <param name="action">수행할 동작을 지정합니다.</param>
		public static void SyncInvoke<T>(this T obj, SyncInvokeThread<T> action) where T : ISynchronizeInvoke
		{
			if (obj.InvokeRequired) obj.Invoke(action, new object[] { obj });
			else action(obj);
		}
		/// <summary>
		/// 컨트롤의 비동기 크로스스레딩을 수행합니다.
		/// </summary>
		/// <typeparam name="T">컨트롤의 형식을 지정합니다.</typeparam>
		/// <param name="obj">컨트롤 통신을 위한 인자입니다.</param>
		/// <param name="action">수행할 동작을 지정합니다.</param>
		public static void AsyncInvoke<T>(this T obj, SyncInvokeThread<T> action) where T : ISynchronizeInvoke
		{
			if (obj.InvokeRequired) obj.BeginInvoke(action, new object[] { obj });
			else action(obj);
		}
	}
}