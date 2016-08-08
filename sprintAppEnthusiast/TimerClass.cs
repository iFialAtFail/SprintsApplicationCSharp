using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Diagnostics;

namespace sprintAppEnthusiast
{
    static class TimerClass
    {
        #region Public Static Variables

        public static Stopwatch Stop_watch { get; private set; }
        public static TimeSpan ElapsedTime { get; set; }

        #endregion

        #region Private Static Variables

        private static bool isRunning = false;

        #endregion

        #region Public Methods

        /// <summary>
        /// This method starts the timer system, which is based on a stopwatch.
        /// The stop watch just measures time from instantiation by checking
        /// the elapsed property.
        /// </summary>
        public static void Start()
        {
            if (!isRunning)
            {
                Stop_watch = new Stopwatch();
                Stop_watch.Start();
                isRunning = true;
            }
            else if (isRunning)
            {
                if (Stop_watch != null && !Stop_watch.IsRunning)
                {
                    Stop_watch.Start();
                }
            }

        }

        /// <summary>
        /// This method stops the stopwatch if it is running. Stop essentially
        /// pauses the stopwatch and can allow it to resume and maintain the 
        /// elapsed time.
        /// </summary>
        public static void Pause()
        {
            if (isRunning)
            {
                Stop_watch.Stop();
            }
        }

        /// <summary>
        /// This method stops and resets the stopwatch.
        /// </summary>
        public static void Stop()
        {
            if(Stop_watch != null)
            {
                Stop_watch.Reset();
                ElapsedTime = Stop_watch.Elapsed;
            }

            isRunning = false;
        }

        /// <summary>
        /// This method will return a formatted string as often as it is called.
        /// This method is designed to be used with a dispatcher timer or similar.
        /// </summary>
        /// <returns></returns>
        public static string GetElapsedTime()
        {
            return Stop_watch.Elapsed.ToString("hh\\:mm\\:ss\\:fff");
        }
        #endregion
        
    }
}
