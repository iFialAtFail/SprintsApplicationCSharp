using System;
using System.Windows.Forms;


namespace sprintAppEnthusiast
{
    public partial class SprintMain : Form
    {
        private bool timerStarted = false;
        

        public SprintMain()
        {
            InitializeComponent();

        }

        private void GOButton_Click(object sender, EventArgs e)
        {
            StartSystem();

        }



        private void timerUpdate_Tick(object sender, EventArgs e)
        {
            NotificationSystemUpdate();
        }



        private void stopButton_Click(object sender, EventArgs e)
        {
            StopSystem();
        }



        private void btnPause_Click(object sender, EventArgs e)
        {
            TimerClass.Pause();
        }
        
        private void SprintMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            TimerClass.Stop();
        }

        #region Private Helper Methods

        private void SetProperties()
        {
            if (coolDown0.Checked) { RunSystem.SetCooldown(RunSystem.coolDownChoice.zero); }
            else if (coolDown5.Checked) { RunSystem.SetCooldown(RunSystem.coolDownChoice.five); }
            else if (coolDown10.Checked) { RunSystem.SetCooldown(RunSystem.coolDownChoice.ten); }

            if (warmUp0.Checked) { RunSystem.SetWarmup(RunSystem.warmUpChoice.zero); }
            else if (warmUp5.Checked) { RunSystem.SetWarmup(RunSystem.warmUpChoice.five); }
            else if (warmUp10.Checked) { RunSystem.SetWarmup(RunSystem.warmUpChoice.ten); }

            RunSystem.SetCoreTime((int)excerciseTargetNumber.Value);
        }

        private void StartSystem()
        {
            TimerClass.Start();
            if (!timerStarted)
            {
                timerStarted = true;
                timerUpdate.Enabled = true;
                timerUpdate.Start();
                SetProperties();
            }

            if (thirtySixtyRadioButton.Checked)
            {
                RunSystem.InitializeSprintNotificationSystem(RunSystem.sprintNotificationStyle.ThirtySixty);
            }
            else if (sixtyOneTwentyRadioButton.Checked)
            {
                RunSystem.InitializeSprintNotificationSystem(RunSystem.sprintNotificationStyle.SixtyOneTwenty);
            }
        }

        private void NotificationSystemUpdate()
        {
            timeElapsed_Label.Text = TimerClass.GetElapsedTime();
            RunSystem.NotificationSystem(TimerClass.Stop_watch.Elapsed);
        }

        private void StopSystem()
        {
            StopTimerClass();
            StopNotificationSystem();
        }

        private void StopTimerClass()
        {
            timerStarted = false;
            TimerClass.Stop();
            timerUpdate.Stop();
            timerStarted = false;
        }

        private static void StopNotificationSystem()
        {
            RunSystem.StopNotificationSystem();
            RunSystem.Reset();
        }
        #endregion
    }
}
