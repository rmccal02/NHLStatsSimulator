using System;
using System.Diagnostics.Eventing.Reader;
using System.Globalization;
using System.Windows.Forms;

namespace NHLStatsProject
{
    public class PenTimer
    {
        private System.Windows.Forms.Timer penaltyTimer;
        private TimeSpan penaltyTime;
        private Label timerLabel;

        public event EventHandler PenaltyTimerReachedZero;

        public PenTimer(Label label)
        {
            penaltyTimer = new System.Windows.Forms.Timer();
            penaltyTimer.Interval = 1000;
            penaltyTimer.Tick += PenaltyTimer_Tick;


            // Initialize penaltyTime to 2 minutes
            penaltyTime = new TimeSpan(0, 0, 0);

            // Initialize the label
            timerLabel = label;
            UpdateTimerLabel();
        }

        public void StartTimer()
        {
            // Start the penaltyTimer
            
            penaltyTimer.Start();
        }

        public void StopTimer()
        {
            // Stop the penaltyTimer
            penaltyTimer.Stop();
        }

        public void ResetPen()
        {
            // Stop the penaltyTimer
            StopTimer();

            // Set penaltyTime to 0
            penaltyTime = TimeSpan.Zero;

            // Update the timer label
            UpdateTimerLabel();
        }
        private void PenaltyTimer_Tick(object sender, EventArgs e)
        {
            // Update the penaltyTime on each tick
            penaltyTime = penaltyTime.Subtract(TimeSpan.FromSeconds(1));

            // Display the penaltyTime in the label
            UpdateTimerLabel();

            // Check if penaltyTime has reached 00:00 and stop the timer
            if (penaltyTime.TotalSeconds <= 0)
            {
                StopTimer();

                OnPenaltyTimerReachedZero(EventArgs.Empty);

                // Optionally add actions when the timer reaches zero
            }
        }
        protected virtual void OnPenaltyTimerReachedZero(EventArgs e)
        {
            PenaltyTimerReachedZero?.Invoke(this, e);
        }
        public void UpdateTimer()
        {
            penaltyTime = new TimeSpan(0, 2, 0);
        }
        public void UpdateTimer5()
        {
            penaltyTime = new TimeSpan(0, 5, 0);
        }

        public string GetFormattedTime()
        {
            return penaltyTime.ToString(@"m\:ss");
        }

        private void UpdateTimerLabel()
        {
            // Format and update the label text with the penaltyTime
            timerLabel.Text = penaltyTime.ToString(@"m\:ss");
        }

        public void SubtractTime(int timeDifference)
        {
            TimeSpan timeSpanSub = TimeSpan.FromSeconds(timeDifference);

            penaltyTime = penaltyTime.Subtract(timeSpanSub);

            // Update the timer label
            UpdateTimerLabel();

        }

        public int GetPenTimeInSeconds()
        {
            return (int)penaltyTime.TotalSeconds;
        }
        public void setPenTimeInSeconds(int x)
        {
            penaltyTime = TimeSpan.FromSeconds(x);
        }
    }
}

