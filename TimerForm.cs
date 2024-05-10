using System;
using System.Globalization;
using System.Windows.Forms;

namespace NHLStatsProject
{
    public class TimerForm
    {
        private System.Windows.Forms.Timer gameTimer; // Fully qualify the Timer class
        private TimeSpan gameTime;
        private Label timerLabel; // Add the label declaration

        public event EventHandler GameTimerReachedZero;

        public TimerForm(Label label) // Pass the label as a parameter to the constructor
        {
            gameTimer = new System.Windows.Forms.Timer();
            gameTimer.Interval = 1000;
            gameTimer.Tick += GameTimer_Tick;

            // Initialize gameTime to 20 minutes
            gameTime = new TimeSpan(0, 20, 0);

            // Initialize the label
            timerLabel = label;
            UpdateTimerLabel();
        }

        public void StartTimer()
        {
            // Start the timer
            gameTimer.Start();
        }

        public void StopTimer()
        {
            // Stop the timer
            gameTimer.Stop();
        }

        private void GameTimer_Tick(object sender, EventArgs e)
        {
            // Update the gameTime on each tick
            
            gameTime = gameTime.Subtract(TimeSpan.FromSeconds(1));

            // Display the gameTime in the label
            UpdateTimerLabel();

            if (gameTime.TotalSeconds <= 0)
            {
                StopTimer();
                OnGameTimerReachedZero(EventArgs.Empty);
            }

        }
        protected virtual void OnGameTimerReachedZero(EventArgs e)
        {
            // Invoke the event
            GameTimerReachedZero?.Invoke(this, e);
        }



        public string GetFormattedTime()
        {
            return gameTime.ToString(@"mm\:ss");
        }

        private void UpdateTimerLabel()
        {
            // Format and update the label text with the gameTime
            timerLabel.Text = gameTime.ToString(@"mm\:ss");
        }
        

        public void JumpTo(int minutes, int seconds)
        {
            gameTime = new TimeSpan(0, minutes, seconds);
            UpdateTimerLabel();
        }

        public int GetGameTimeInSeconds()
        {
            return (int)gameTime.TotalSeconds;
        }

        

    }
}
