using System;
using System.ComponentModel;
using System.Threading;
using System.Timers;

namespace microondas
{
	public class TimerMicroondas
	{
		public static System.Timers.Timer aTimer;
		public static int timeToSeconds;
		
		/// <summary>
		/// Start the timer with the time set
		/// </summary>
		/// <param name="time"></param>
		public static void GoTime(string time)
		{
			timeToSeconds = ConvertInputTimer(time);
			
			if(timeToSeconds <= 0)
			{
				Console.WriteLine("Tiempo inválido");
			}

			aTimer = new System.Timers.Timer(1000); 
			aTimer.Elapsed += OnTimedEvent;
			aTimer.AutoReset = true;	
			aTimer.Enabled = true;
			aTimer.Start();

		}

		/// <summary>
		/// Event to timer elapsed 
		/// </summary>
		/// <param name="source"></param>
		/// <param name="e"></param>
		public static void OnTimedEvent(Object source, ElapsedEventArgs e)
		{
			if (timeToSeconds > 0)
			{
				timeToSeconds--;
				Console.Clear();
				Console.WriteLine(SetFormat(timeToSeconds));
			}
			else
			{
				aTimer.Stop();
				Console.Clear();
				Console.WriteLine("End");
			}
		}

		/// <summary>
		/// Set time in format mm:ss
		/// </summary>
		/// <param name="totalSeconds">integer param with total seconds</param>
		/// <returns>string with format</returns>
		public static string SetFormat(int totalSeconds)
		{
			int minutes = totalSeconds / 60;
			int seconds = totalSeconds % 60;
			return string.Format("{0:D2}:{1:D2}", minutes, seconds);
		}

		/// <summary>
		/// Set the time in seconds
		/// </summary>
		/// <param name="time">input parameter with time to set</param>
		/// <returns>integer with second value</returns>
		public static int ConvertInputTimer(string time)
		{
			int seconds = 0;
			int length = time.Length;
			
			if(length > 4 || length == 0)
				return -1;

			try
			{
				int imputNumber = int.Parse(time);

				if(length <= 2)
				{
					seconds = imputNumber;
				}
				else
				{
					int minutes = imputNumber / 100;
					int secs = imputNumber % 100;
					seconds = minutes * 60 + secs;
				}
			}
			catch (Exception)
			{
				return -1;
			}

			return seconds;
		}


	}
}
