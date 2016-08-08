using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace sprintAppEnthusiast
{
    class RunSystem
    {
        #region Private static variables
        private static int warmUp, coolDown, coreTime;
        private static bool warmUpCompleted, coolDownCompleted, mainExerciseCompleted;
        private static ISprints notificationObject; // TODO 4 April 16 Modify Sprints DLL to modify/remove singleton.
        #endregion

        #region Time Choice Option Enums
        public enum warmUpChoice { zero, five, ten }
        public enum coolDownChoice { zero, five, ten }
        public enum sprintNotificationStyle { ThirtySixty, SixtyOneTwenty }
        #endregion

        #region Public Methods

        /// <summary>
        /// Method used to set up the amount of time for the warmup option. Uses enum.
        /// </summary>
        /// <param name="wc"></param>
        public static void SetWarmup(warmUpChoice wc)
        {
            switch (wc)
            {
                case warmUpChoice.zero:
                    warmUp = 0;
                    break;
                case warmUpChoice.five:
                    warmUp = 5;
                    break;
                case warmUpChoice.ten:
                    warmUp = 10;
                    break;
                default:
                    break;
            }
        }

        /// <summary>
        /// Method used to set the amount of time for the main exercise/sprint routines. Takes an integer.
        /// </summary>
        /// <param name="ct"></param>
        public static void SetCoreTime(int ct)
        {
            coreTime = ct;
        }

        /// <summary>
        /// Method used to set up the amount of time for the cooldown option. Uses enum.
        /// </summary>
        /// <param name="cd"></param>
        public static void SetCooldown(coolDownChoice cd)
        {
            switch (cd)
            {
                case coolDownChoice.zero:
                    coolDown = 0;
                    break;
                case coolDownChoice.five:
                    coolDown = 5;
                    break;
                case coolDownChoice.ten:
                    coolDown = 10;
                    break;
                default:
                    break;
            }
        }

        /// <summary>
        /// Method to initialize identify which sprint style is used. Choices are 30/60 and 60/120.
        /// </summary>
        /// <param name="sns"></param>
        public static void InitializeSprintNotificationSystem(sprintNotificationStyle sns)
        {
            switch (sns)
            {
                case sprintNotificationStyle.ThirtySixty:
                    notificationObject = ThirtySixtySprints.Instance;
                    
                    break;
                case sprintNotificationStyle.SixtyOneTwenty:
                    notificationObject = SixtyOneTwentySprints.Instance;
                    
                    break;
                default:
                    break;
            }
        }

        /// <summary>
        /// Method to start the notification system polymorphically. If no object is chosen, do nothing.
        /// </summary>
        public static void StartNotificationSystem()
        {
            if (notificationObject != null)
            {
                notificationObject.startSprints();
            }
        }

        /// <summary>
        /// Method to stop the notification system polymorphically. If no object is chosen, do nothing.
        /// </summary>
        public static void StopNotificationSystem()
        {
            if (notificationObject != null)
            {
                notificationObject.finishSprints();
            }
        }

        /// <summary>
        /// Method that should be used with a timer. Method should be called every tenth of a second
        /// to maintain a decent resolution of time. The method is designed to take the stopwatch objects
        /// elapsed timespan property for the logic to work.
        /// </summary>
        /// <param name="ts"></param>
        public static void NotificationSystem(TimeSpan ts)
        {
            if (ts.TotalMinutes > warmUp && !warmUpCompleted)
            {
                warmUpCompleted = true;

                //TODO: Replace with proper notification of warmup being complete
                System.Windows.Forms.MessageBox.Show("WarmupCompleted");

                if (notificationObject != null)
                {
                    notificationObject.startSprints();
                }

            }
            if (ts.TotalMinutes >= (warmUp+coreTime) && !mainExerciseCompleted)
            {
                mainExerciseCompleted = true;

                //TODO: Replace with proper notification of starting cooldown
                System.Windows.Forms.MessageBox.Show("Main Exercise Completed");

                if (notificationObject != null)
                {
                    notificationObject.finishSprints();
                }
            }
            if (ts.TotalMinutes >= (warmUp+coreTime+coolDown) && !coolDownCompleted)
            {
                coolDownCompleted = true;
                System.Windows.Forms.MessageBox.Show("CoolDown Completed");
            }
        }

        /// <summary>
        /// Method that resets the Run System.
        /// </summary>
        public static void Reset()
        {
            warmUpCompleted = false;
            coolDownCompleted = false;
            mainExerciseCompleted = false;

            warmUp = 0;
            coolDown = 0;
            coreTime = 0;
        }
#endregion
    }
}
