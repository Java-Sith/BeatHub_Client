using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NAudio.Wave;

namespace WindowsFormsApp2
{
	public static class WaveStreamExtensions
	{
		public static long SetPosition(this WaveStream strm, long position)
		{
			long adj = position % strm.WaveFormat.BlockAlign;
			long newPos = Math.Max(0, Math.Min(strm.Length, position - adj));
			strm.Position = newPos;
			return strm.Position;
		}
		// Set playback position of WaveStream by seconds
		public static long SetPosition(this WaveStream strm, double seconds)
		{
			strm.SetPosition((long)(seconds * strm.WaveFormat.AverageBytesPerSecond));
			return strm.Position;
		}
		// Set playback position of WaveStream by time (as a TimeSpan)
		public static long SetPosition(this WaveStream strm, TimeSpan time)
		{
			strm.SetPosition(time.TotalSeconds);
			return strm.Position;
		}
		// Set playback position of WaveStream relative to current position
		public static long Seek(this WaveStream strm, double offset)
		{
			strm.SetPosition(strm.Position + (long)(offset * strm.WaveFormat.AverageBytesPerSecond));
			return strm.Position;
		}
	}
}
