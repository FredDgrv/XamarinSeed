using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace XamarinSeed
{
	public static class Logger
	{
		public static long initGC = GC.GetTotalMemory(false);
		private static long previousGC = 0;

		public static string GCmem ()
		{
			long gc = GC.GetTotalMemory(false) - initGC;
			long diff = gc - previousGC;
			previousGC = gc;
			return string.Format("total:{0}kb/diff:{1}kb", (gc / 1024d).ToString("N1"), (diff / 1024d).ToString("N1"));	
		}

		public static void Info(string message)
		{			
			var str = string.Format("[{0}] {1}", GCmem(), message);
			System.Diagnostics.Debug.WriteLine(str);
		}

		public static void Info (string message, string arg1)
		{
			Logger.Info(string.Format(message, arg1));
		}

		public static void Error (string e)
		{			
			Logger.Info(string.Format("[ERROR] {0}", e));
		}

		public static void Error (Exception e)
		{			
			Logger.Error (e.ToString ());
		}
	}
}