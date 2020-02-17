using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Middleware
{
	public class SystemMonitor
	{
		private static readonly DriveInfo drive;
		private static readonly PerformanceCounter cpu;
		private static readonly PerformanceCounter mem;
		private static readonly PerformanceCounter disk_read;
		private static readonly PerformanceCounter disk_write;
		private static readonly PerformanceCounter net_sent;
		private static readonly PerformanceCounter net_received;

		public static float CpuUsage => cpu.NextValue();
		public static float MemUsage => mem.NextValue();
		public static float DiskRead => disk_read.NextValue();
		public static float DiskWrite => disk_write.NextValue();
		public static long DiskTotal => drive.TotalSize;
		public static long DiskUsed => drive.TotalSize - drive.TotalFreeSpace;
		public static long DiskFree => drive.TotalFreeSpace;
		public static float NetSent => net_sent.NextValue();
		public static float NetReceived => net_received.NextValue();

		static SystemMonitor()
		{
			string diskname = "C:";
			string[] disks = new PerformanceCounterCategory("PhysicalDisk").GetInstanceNames();
			string disk = disks.FirstOrDefault(s => s.IndexOf(diskname) > -1);

			string[] nets = new PerformanceCounterCategory("Network Interface").GetInstanceNames();
			string net = nets.FirstOrDefault();

			drive = new DriveInfo(diskname.Substring(0, 1));
			cpu = new PerformanceCounter("Processor", "% Processor Time", "_Total");
			mem = new PerformanceCounter("Memory", "% Committed Bytes In Use");
			disk_read = new PerformanceCounter("PhysicalDisk", "% Disk Read Time", disk);
			disk_write = new PerformanceCounter("PhysicalDisk", "% Disk Write Time", disk);
			net_sent = new PerformanceCounter("Network Interface", "Bytes Sent/sec", net);
			net_received = new PerformanceCounter("Network Interface", "Bytes Received/sec", net);
		}
	}
}