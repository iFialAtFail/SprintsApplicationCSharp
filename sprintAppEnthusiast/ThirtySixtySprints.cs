using System;
using System.Windows.Forms;

namespace sprintAppEnthusiast
{

    public class ThirtySixtySprints : ISprints
    {
        #region Singleton Object Setup

        //Singleton instance backing field
        private static readonly ThirtySixtySprints _instance = new ThirtySixtySprints();

        //Singleton instance Property
        public static ThirtySixtySprints Instance
        {
            get { return _instance; }
        }

        //Private constructor for Singleton.
        private ThirtySixtySprints()
        {

            //startSprints();
        }

        #endregion

        #region Private Variables
        private double startTime;
        private double currentTime;

        private bool thirty_sixty_30 = false;
        private bool thirty_sixty_60 = false;
        private Timer thirtySixtySprintTimer;

        #endregion

        #region Private Methods


        /// <summary>
        /// This method is the handler for the Tick event. It basically tracks the time elapsed with
        /// a resolution of the interval of the timer tick event. It then uses the elapsed time and 
        /// checks the notification system, essentially ensuring the notification system is on.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void excercise_tickPerSecond(object sender, EventArgs e)
        {
            SetTimeElapsed();
            startNotificationSystem();
        }

        /// <summary>
        /// Method that fires off notifications based on the current elapsed time of a stopwatch elapsed property
        /// </summary>
        private void startNotificationSystem()
        {
            if (currentTime >= 30 && !thirty_sixty_30)
            {
                startTime = TimerClass.Stop_watch.Elapsed.TotalSeconds;
                thirty_sixty_30 = true;
                thirty_sixty_60 = false;
                walkNotification();
            }
            else if (currentTime >= 60 && !thirty_sixty_60)
            {
                startTime = TimerClass.Stop_watch.Elapsed.TotalSeconds;
                thirty_sixty_30 = false;
                thirty_sixty_60 = true;
                sprintNotification(); //TODO: Add sounds
            }
        }

        /// <summary>
        /// Method that fires a message dictating when to Sprint in their exercise.
        /// </summary>
        private void sprintNotification()
        {
            MessageBox.Show("SPRINT!");//TODO: Add sounds
        }

        /// <summary>
        /// Method that fires a message dictating when to Walk in their exercise.
        /// </summary>
        private void walkNotification()
        {
            MessageBox.Show("Walk...");//TODO: Add sounds
        }

        /// <summary>
        /// Method that sets current time based on the difference between the current
        /// elapsed time and the start time variable.
        /// </summary>
        public void SetTimeElapsed()
        {
            currentTime = TimerClass.Stop_watch.Elapsed.TotalSeconds - startTime;
        }
        #endregion

        #region Interface/Public Methods

        /// <summary>
        /// Method to start sprints. Creates, Sets up, and starts a timer to fire the stopwatch based
        /// time measurement system off. Sets the initial time to a local origin to be used against 
        /// subsequent pulls of the elapsed timer.
        /// </summary>
        public void startSprints()
        {
            thirtySixtySprintTimer = new Timer();
            thirtySixtySprintTimer.Interval = 100;
            thirtySixtySprintTimer.Tick += new EventHandler(excercise_tickPerSecond);
            thirtySixtySprintTimer.Start();
            startTime = TimerClass.Stop_watch.Elapsed.TotalSeconds;

        }

        /// <summary>
        /// Method that finishes the sprints by resetting all the variables.
        /// </summary>
        public void finishSprints()
        {
            currentTime = 0;
            thirty_sixty_30 = false;
            thirty_sixty_60 = false;
            if (thirtySixtySprintTimer != null)
            {
                thirtySixtySprintTimer.Stop();
                thirtySixtySprintTimer.Dispose();
            }
        }
        #endregion



    }
}
