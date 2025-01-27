using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop4
{
    internal class Duration
    {
		private int hours;
        private int seconds;
        private int minutes;
        public int Hours
		{
			get { return hours; }
			set { hours = value; }
		}
		public int Minutes
        {
			get { return minutes; }
			set { minutes = value; }
		}
		public int Seconds
        {
			get { return seconds; }
			set { seconds = value; }
		}
        private int ToSeconds()
        {
            return Hours * 3600 + Minutes * 60 + Seconds;
        }
        public Duration(int hours, int minutes, int seconds)
        {
            Hours = hours;
            Minutes = minutes;
            Seconds = seconds;
            Normalize();
        }
        public Duration(int totalSeconds)
        {
            Hours = totalSeconds / 3600;
            totalSeconds %= 3600;
            Minutes = totalSeconds / 60;
            Seconds = totalSeconds % 60;
            Normalize();
        }
        private void Normalize()
        {
            Minutes += Seconds / 60;
            Seconds %= 60;
            Hours += Minutes / 60;
            Minutes %= 60;
        }
        public override string ToString()
        {
            if (Hours > 0)
                return $"Hours: {Hours}, Minutes: {Minutes}, Seconds: {Seconds}";
            else 
                return $"Minutes: {Minutes}, Seconds: {Seconds}";
        }
        public static Duration operator +(Duration d1, Duration d2)
        {
            return new Duration(d1.Hours + d2.Hours, d1.Minutes + d2.Minutes, d1.Seconds + d2.Seconds);
        }
        public static Duration operator +(Duration d, int seconds)
        {
            return new Duration(d.Hours, d.Minutes, d.Seconds + seconds);
        }
        public static Duration operator +(int seconds, Duration d)
        {
            return d + seconds;
        }
        public static Duration operator -(Duration d1, Duration d2)
        {
            int totalSeconds1 = d1.ToSeconds();
            int totalSeconds2 = d2.ToSeconds();
            return new Duration(totalSeconds1 - totalSeconds2);
        }
        public static Duration operator ++(Duration d)
        {
            return new Duration(d.Hours, d.Minutes + 1, d.Seconds);
        }
        public static Duration operator --(Duration d)
        {
            return new Duration(d.Hours, d.Minutes - 1, d.Seconds);
        }
        public static bool operator >(Duration d1, Duration d2)
        {
            return d1.ToSeconds() > d2.ToSeconds();
        }
        public static bool operator <(Duration d1, Duration d2)
        {
            return d1.ToSeconds() < d2.ToSeconds();
        }
        public static bool operator <=(Duration d1, Duration d2)
        {
            return d1.ToSeconds() <= d2.ToSeconds();
        }
        public static bool operator >=(Duration d1, Duration d2)
        {
            return d1.ToSeconds() <= d2.ToSeconds();
        }


    }
}
