using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Euler
{
	public static class TIMER
	{
		static Stopwatch watch = new Stopwatch();

		public static long getElapsedTime() {
			return watch.ElapsedMilliseconds;
		}

		public static void Finish() {
			Stop();
			Console.WriteLine(getElapsedTime().ToString() + "ms");
			Console.ReadKey();
		}

		public static void Start() {
			watch.Start();
		}

		public static void Stop() {
			watch.Stop();
		}

	}
}
