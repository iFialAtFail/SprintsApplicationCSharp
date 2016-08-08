using System;
using System.Windows.Forms;

namespace sprintAppEnthusiast
{
    public class SixtyOneTwentySprints : ISprints
    {

        #region Singleton Object Setup

        //Singleton instance backing field
        private static readonly SixtyOneTwentySprints _instance = new SixtyOneTwentySprints();

        //Singleton instance Property
        public static SixtyOneTwentySprints Instance
        {
            get { return _instance; }
        }

        //Private constructor for Singleton.
        private SixtyOneTwentySprints()
        {

        }

        #endregion

        #region Private Variables

        private double startTime;
        private double currentTime;

        private bool sixty_one_twenty_30 = false;
        private bool sixty_one_twenty_60 = false;
        private Timer sixtyOneTwentySprintTimer;

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
            setTimeElapsed();
            startNotificationSystem();
        }

        /// <summary>
        /// Method that fires off notifications based on the current elapsed time of a stopwatch elapsed property
        /// </summary>
        private void startNotificationSystem()
        {
            if (currentTime >= 60 && !sixty_one_twenty_30)
            {
                startTime = TimerClass.Stop_watch.Elapsed.TotalSeconds;
                sixty_one_twenty_30 = true;
                sixty_one_twenty_60 = false;
                walkNotification();
            }
            else if (currentTime >= 120 && !sixty_one_twenty_60)
            {
                startTime = TimerClass.Stop_watch.Elapsed.TotalSeconds;
                sixty_one_twenty_30 = false;
                sixty_one_twenty_60 = true;
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
        private void setTimeElapsed()
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
            sixtyOneTwentySprintTimer = new Timer();
            sixtyOneTwentySprintTimer.Interval = 100;
            sixtyOneTwentySprintTimer.Tick += new EventHandler(excercise_tickPerSecond);
            sixtyOneTwentySprintTimer.Start();
            startTime = TimerClass.Stop_watch.Elapsed.TotalSeconds;
        }

        /// <summary>
        /// Method that finishes the sprints by resetting all the variables.
        /// </summary>
        public void finishSprints()
        {
            currentTime = 0;
            sixty_one_twenty_30 = false;
            sixty_one_twenty_60 = false;
            if (sixtyOneTwentySprintTimer != null)
            {
                sixtyOneTwentySprintTimer.Stop();
                sixtyOneTwentySprintTimer.Dispose();
            }

        }
        #endregion

    }
}
