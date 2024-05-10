using System.Text;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace NHLStatsProject
{
    public partial class Form1 : Form
    {
        private Team canada, usa;
        private ListViewManager listViewManager1, listViewManager2;

        private List<Player> onIce = new List<Player>();
        private List<Player> penalty = new List<Player>();
        private TimerForm timerForm;

        private PenTimer penTimer;
        private PenTimer penTimer2;
        private PenTimer penTimerA;
        private PenTimer penTimer2A;
        private List<Goal> goalList = new List<Goal>();

        private int assistXval = 0;
        private int goalXval = 0;
        private int assistYval = 0;
        private int goalYval = 0;
        private int hScore = 0;
        private int aScore = 0;

        Point mousePosition;

        private string period = "1";

        public Form1()
        {
            InitializeComponent();
            timerForm = new TimerForm(timerLabel);
            penTimer = new PenTimer(hPen1);
            penTimer2 = new PenTimer(hPen2);
            penTimerA = new PenTimer(aPen1);
            penTimer2A = new PenTimer(aPen2);
            penTimer.PenaltyTimerReachedZero += PenTimer_PenaltyTimerReachedZero;
            penTimerA.PenaltyTimerReachedZero += PenTimer_PenaltyTimerReachedZero;
            timerForm.GameTimerReachedZero += gameTimer_GameTimerReachedZero;

            // Load a custom image into the PictureBox
            pictureBox1.Image = Image.FromFile("C:\\Users\\Robert\\Downloads\\RinkNHL.png");
            pictureBox1.MouseMove += pictureBox1_MouseMove;

            //sets up a drag and drop relationship between the lists
            listViewManager1 = new ListViewManager(listView1, onIceList, homePenList);
            listViewManager2 = new ListViewManager(listView2, onIceListA, awayPenList);

            // Creating players for Team Canada
            Player player1 = new Player { Name = "Sidney Crosby", JerseyNumber = 87, Position = "Center" };
            Player player2 = new Player { Name = "Connor McDavid", JerseyNumber = 97, Position = "Center" };
            Player player3 = new Player { Name = "Nathan MacKinnon", JerseyNumber = 29, Position = "Forward" };
            Player player4 = new Player { Name = "Jonathan Toews", JerseyNumber = 19, Position = "Center" };
            Player player5 = new Player { Name = "Wayne Gretzky", JerseyNumber = 99, Position = "Center" };
            Player player6 = new Player { Name = "John Tavares", JerseyNumber = 91, Position = "Center" };
            Player player7 = new Player { Name = "Steven Stamkos", JerseyNumber = 91, Position = "Center" };
            Player player8 = new Player { Name = "Mark Scheifele", JerseyNumber = 55, Position = "Center" };
            Player player9 = new Player { Name = "Taylor Hall", JerseyNumber = 91, Position = "Left Wing" };
            Player player10 = new Player { Name = "Drew Doughty", JerseyNumber = 8, Position = "Defense" };
            Player player11 = new Player { Name = "Shea Weber", JerseyNumber = 6, Position = "Defense" };
            Player player12 = new Player { Name = "Brent Burns", JerseyNumber = 88, Position = "Defense" };
            Player player13 = new Player { Name = "Carey Price", JerseyNumber = 31, Position = "Goalie" };
            Player player14 = new Player { Name = "Marc-Andre Fleury", JerseyNumber = 29, Position = "Goalie" };
            Player player15 = new Player { Name = "Duncan Keith", JerseyNumber = 2, Position = "Defense" };

            // Creating Team Canada
            canada = new Team
            {
                TeamName = "Canada",
                Players = { player1, player2, player3, player4, player5, player6, player7, player8, player9, player10, player11, player12, player13, player14, player15 }
            };

            // Creating players for Team U.S.A
            Player player1A = new Player { Name = "Patrick Kane", JerseyNumber = 88, Position = "Right Wing" };
            Player player2A = new Player { Name = "Auston Matthews", JerseyNumber = 34, Position = "Center" };
            Player player3A = new Player { Name = "Jack Eichel", JerseyNumber = 9, Position = "Center" };
            Player player4A = new Player { Name = "Johnny Gaudreau", JerseyNumber = 13, Position = "Left Wing" };
            Player player5A = new Player { Name = "Seth Jones", JerseyNumber = 3, Position = "Defense" };
            Player player6A = new Player { Name = "Zach Werenski", JerseyNumber = 8, Position = "Defense" };
            Player player7A = new Player { Name = "Matthew Tkachuk", JerseyNumber = 19, Position = "Left Wing" };
            Player player8A = new Player { Name = "Blake Wheeler", JerseyNumber = 26, Position = "Right Wing" };
            Player player9A = new Player { Name = "Dylan Larkin", JerseyNumber = 71, Position = "Center" };
            Player player10A = new Player { Name = "Chris Kreider", JerseyNumber = 20, Position = "Left Wing" };
            Player player11A = new Player { Name = "Quinn Hughes", JerseyNumber = 43, Position = "Defense" };
            Player player12A = new Player { Name = "John Gibson", JerseyNumber = 36, Position = "Goalie" };
            Player player13A = new Player { Name = "Connor Hellebuyck", JerseyNumber = 37, Position = "Goalie" };
            Player player14A = new Player { Name = "Patrick Maroon", JerseyNumber = 14, Position = "Left Wing" };
            Player player15A = new Player { Name = "T.J. Oshie", JerseyNumber = 77, Position = "Right Wing" };

            // Creating Team U.S.A
            usa = new Team
            {
                TeamName = "U.S.A",
                Players = { player1A, player2A, player3A, player4A, player5A, player6A, player7A, player8A, player9A, player10A, player11A, player12A, player13A, player14A, player15A }
            };
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            mousePosition = pictureBox1.PointToClient(MousePosition);

            // Display X and Y coordinates in labels
            XSelect.Text = $"Selected X: {mousePosition.X}";
            YSelect.Text = $"Y: {mousePosition.Y}";

        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            Point mousePosition = pictureBox1.PointToClient(MousePosition);

            // Display X and Y coordinates in labels
            XLabel.Text = $"X: {mousePosition.X}";
            YLabel.Text = $"Y: {mousePosition.Y}";

        }

        private void pictureBox1_MouseCaptureChanged(object sender, EventArgs e)
        {


        }
        //redundancy: addTeam(home) and addTeam(away)
        private void addHome_Click(object sender, EventArgs e)
        {
            // Clear existing items in the homeTeamList
            listView1.Items.Clear();

            listView1.View = View.Details;
            listView1.FullRowSelect = true;  // Select entire row
            listView1.MultiSelect = true;   // Allow only one selection at a time
            homeLabel.Text = $"Home: {canada.TeamName}";

            // Adding Team Canada players to the ListView
            for (int i = 0; i < canada.Players.Count; i++)
            {
                Player player = canada.Players[i];

                ListViewItem item = new ListViewItem(player.Name);
                item.SubItems.Add(player.JerseyNumber.ToString());
                item.SubItems.Add(player.Position);

                item.Tag = player;

                listView1.Items.Add(item);
            }
        }

        private void awayAdd_Click(object sender, EventArgs e)
        {
            // Clear existing items in the awayTeamList
            listView2.Items.Clear();

            listView2.View = View.Details;
            listView2.FullRowSelect = true;  // Select entire row
            listView2.MultiSelect = true;   // Allow only one selection at a time
            awayLabel.Text = $"Away: {usa.TeamName}";

            // Adding Team USA players to the ListView
            for (int i = 0; i < usa.Players.Count; i++)
            {
                Player player = usa.Players[i];

                ListViewItem item = new ListViewItem(player.Name);
                item.SubItems.Add(player.JerseyNumber.ToString());
                item.SubItems.Add(player.Position);

                item.Tag = player;

                listView2.Items.Add(item);
            }
        }

        private void updateLine_Click(object sender, EventArgs e)
        {

            // Clear existing items in the onIce list
            onIce.Clear();

            foreach (ListViewItem item in onIceList.Items)
            {
                // Assuming each ListViewItem's Tag property is set to a Player object
                if (item.Tag is Player player)
                {
                    // Add the jersey number to the onIce list
                    onIce.Add(player);
                }
            }

            // Now 'onIce' list contains the jersey numbers of players in the onIceList
            ShowPlayerInfoInMessageBox(onIce);
        }

        private void ShowPlayerInfoInMessageBox(List<Player> onIce)
        {
            if (onIce.Count > 0)
            {
                StringBuilder message = new StringBuilder("Players on the ice:\n");

                foreach (Player player in onIce)
                {
                    message.AppendLine($"- {player.Name} - Jersey: {player.JerseyNumber}, Position: {player.Position}");
                }

                MessageBox.Show(message.ToString(), "On Ice Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No players on the ice.", "On Ice Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            string currentTime = timerForm.GetFormattedTime();

            // Do something with currentTime, for example, display it in a MessageBox
            MessageBox.Show($"Current Time: {currentTime}, Period: {period}", "Time Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            timerForm.StartTimer();
            if (hPen1.Text != "0:00")
            {
                penTimer.StartTimer();
            }
            if (hPen2.Text != "0:00" && hPen1.Text != "0:00")
            {
                penTimer2.StartTimer();
            }
            if (aPen1.Text != "0:00")
            {
                penTimerA.StartTimer();
            }
            if (aPen2.Text != "0:00" && aPen1.Text != "0:00")
            {
                penTimer2A.StartTimer();
            }

        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            timerForm.StopTimer();
            penTimer.StopTimer();
            penTimer2.StopTimer();
            penTimerA.StopTimer();
            penTimer2A.StopTimer();
        }

        private void PenTimer_PenaltyTimerReachedZero(object sender, EventArgs e)
        {
            // This method will be called when the penalty timer reaches zero

            // Stop the gameTimer
            timerForm.StopTimer();
            penTimer.StopTimer();
            penTimer2.StopTimer();
            penTimerA.StopTimer();
            penTimer2A.StopTimer();

            if (hPen1.Text == "0:00")
            {
                BeginInvoke((Action)(() =>
                {
                    hPen1.Text = hPen2.Text;
                    ListViewItem removedItem = homePenList.Items[0];
                    int passTime = penTimer2.GetPenTimeInSeconds();
                    penTimer2.setPenTimeInSeconds(0);
                    penTimer.setPenTimeInSeconds(passTime);

                    hPen2.Text = "0:00";
                    homePenList.Items.RemoveAt(0);
                    listView1.Items.Add(removedItem);

                }));

                MessageBox.Show("Penalty over", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (aPen1.Text == "0:00")
            {
                BeginInvoke((Action)(() =>
                {
                    aPen1.Text = aPen2.Text;
                    ListViewItem removedItem = awayPenList.Items[0];
                    int passTime = penTimer2A.GetPenTimeInSeconds();
                    penTimer2A.setPenTimeInSeconds(0);
                    penTimerA.setPenTimeInSeconds(passTime);

                    aPen2.Text = "0:00";
                    awayPenList.Items.RemoveAt(0);
                    listView2.Items.Add(removedItem);

                }));

                MessageBox.Show("Penalty over", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void gameTimer_GameTimerReachedZero(object sender, EventArgs e)
        {
            // This method will be called when the penalty timer reaches zero

            // Stop the gameTimer
            timerForm.StopTimer();
            penTimer.StopTimer();
            penTimer2.StopTimer();
            penTimerA.StopTimer();
            penTimer2A.StopTimer();
            MessageBox.Show("Period Over", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        //jumpbutton
        private void button1_Click(object sender, EventArgs e)
        {
            // Assuming you have TimerForm instance named 'timerForm'
            int minutes, seconds;
            period = periodBox.Text;

            if (int.TryParse(minutesBox.Text, out minutes) && int.TryParse(secondsBox.Text, out seconds))
            {
                int gameTimeInSeconds = timerForm.GetGameTimeInSeconds();
                timerForm.JumpTo(minutes, seconds);
                int timeDiff = gameTimeInSeconds - (minutes * 60 + seconds);


                if (hPen2.Text != "0:00")
                {
                    penTimer2.SubtractTime(timeDiff);
                    if (penTimer2.GetPenTimeInSeconds() > 120 || penTimer2.GetPenTimeInSeconds() <= 0)
                    {
                        penTimer2.ResetPen();
                        RemoveItemAndAddToOtherList(1);
                    }

                }

                if (hPen1.Text != "0:00")
                {

                    penTimer.SubtractTime(timeDiff);


                    if (penTimer.GetPenTimeInSeconds() > 120 || penTimer.GetPenTimeInSeconds() <= 0)
                    {
                        penTimer.ResetPen();
                        RemoveItemAndAddToOtherList(0);

                    }

                }

                if (aPen2.Text != "0:00")
                {
                    penTimer2A.SubtractTime(timeDiff);
                    if (penTimer2A.GetPenTimeInSeconds() > 120 || penTimer2A.GetPenTimeInSeconds() <= 0)
                    {
                        penTimer2A.ResetPen();
                        RemoveItemAndAddToOtherListA(1);
                    }
                }

                if (aPen1.Text != "0:00")
                {
                    penTimerA.SubtractTime(timeDiff);
                    if (penTimerA.GetPenTimeInSeconds() > 120 || penTimerA.GetPenTimeInSeconds() <= 0)
                    {
                        penTimerA.ResetPen();
                        RemoveItemAndAddToOtherListA(0);
                    }
                }

                MessageBox.Show($"Time Difference: {timeDiff} seconds\nGame Time: {gameTimeInSeconds} seconds", "Values", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Invalid input. Please enter valid numeric values for minutes and seconds.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }

        private void resetTimer_Click(object sender, EventArgs e)
        {
            timerForm.JumpTo(20, 0);
            period = periodBox.Text;
        }

        private void penaltyButton_Click(object sender, EventArgs e)
        {
            timerForm.StopTimer();
            penTimer.StopTimer();
            penTimer2.StopTimer();
            penTimerA.StopTimer();
            penTimer2A.StopTimer();

            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem selected = listView1.SelectedItems[0].Clone() as ListViewItem;
                homePenList.Items.Add(selected);
                listView1.Items.Remove(listView1.SelectedItems[0]);
                if (hPen1.Text != "0:00")
                {

                    penTimer2.UpdateTimer();
                    hPen2.Text = "2:00";

                }

                if (hPen1.Text == "0:00")
                {

                    penTimer.UpdateTimer();
                    hPen1.Text = "2:00";

                }
            }

            // For onIceList
            else if (onIceList.SelectedItems.Count > 0)
            {
                ListViewItem selected = onIceList.SelectedItems[0].Clone() as ListViewItem;
                homePenList.Items.Add(selected);
                onIceList.Items.Remove(onIceList.SelectedItems[0]);
                if (hPen1.Text != "0:00")
                {

                    penTimer2.UpdateTimer();
                    hPen2.Text = "2:00";

                }

                if (hPen1.Text == "0:00")
                {

                    penTimer.UpdateTimer();
                    hPen1.Text = "2:00";

                }
            }
            else
            {
                MessageBox.Show("Please select player to give penalty.");

            }

        }

        private void awayPen_Click(object sender, EventArgs e)
        {
            timerForm.StopTimer();
            penTimer.StopTimer();
            penTimer2.StopTimer();
            penTimerA.StopTimer();
            penTimer2A.StopTimer();

            if (listView2.SelectedItems.Count > 0)
            {
                ListViewItem selected = listView2.SelectedItems[0].Clone() as ListViewItem;
                awayPenList.Items.Add(selected);
                listView2.Items.Remove(listView2.SelectedItems[0]);

                if (aPen1.Text != "0:00")
                {
                    penTimer2A.UpdateTimer();
                    aPen2.Text = "2:00";
                }

                if (aPen1.Text == "0:00")
                {
                    penTimerA.UpdateTimer();
                    aPen1.Text = "2:00";
                }
            }
            // For onIceList
            else if (onIceListA.SelectedItems.Count > 0)
            {
                foreach (ListViewItem selectedItem in onIceListA.SelectedItems)
                {
                    ListViewItem selected = selectedItem.Clone() as ListViewItem;
                    awayPenList.Items.Add(selected);
                    onIceListA.Items.Remove(selectedItem);
                }

                if (aPen1.Text != "0:00")
                {
                    penTimer2A.UpdateTimer();
                    aPen2.Text = "2:00";
                }

                if (aPen1.Text == "0:00")
                {
                    penTimerA.UpdateTimer();
                    aPen1.Text = "2:00";
                }
            }
            else
            {
                MessageBox.Show("Please select a player to give a penalty.");
            }
        }


        private void RemoveItemAndAddToOtherList(int index)
        {
            // Remove item from homePenList at the specified index
            if (index >= 0 && index < homePenList.Items.Count)
            {
                ListViewItem removedItem = homePenList.Items[index];
                homePenList.Items.RemoveAt(index);

                // Add the removed item to another list (e.g., otherListD)
                listView1.Items.Add((ListViewItem)removedItem.Clone());
            }
        }

        private void RemoveItemAndAddToOtherListA(int index)
        {
            // Remove item from homePenList at the specified index
            if (index >= 0 && index < awayPenList.Items.Count)
            {
                ListViewItem removedItem = awayPenList.Items[index];
                awayPenList.Items.RemoveAt(index);

                // Add the removed item to another list (e.g., otherListD)
                listView2.Items.Add((ListViewItem)removedItem.Clone());
            }
        }

        private void lockGoalCoordinates_Click(object sender, EventArgs e)
        {
            goalX.Text = $"{mousePosition.X}";
            goalY.Text = $"{mousePosition.Y}";
            goalXval = mousePosition.X;
            goalYval = mousePosition.Y;
        }

        private void lockAssistCoordinates_Click(object sender, EventArgs e)
        {
            assistX.Text = $"{mousePosition.X}";
            assistY.Text = $"{mousePosition.Y}";
            assistXval = mousePosition.X;
            assistYval = mousePosition.Y;
        }

        private void submitGoal_Click(object sender, EventArgs e)
        {
            // Retrieve values from input controls
            int scoredByPlayer = (int)scoredByJersey.Value;
            string scoredByTeam = goalTeamCombo.Text;
            int assistByPlayer = (int)assistByJersey.Value;
            int scoredOnGoalie = (int)scoredOnJersey.Value;

            int assistX = assistXval;  
            int assistY = assistYval; 
            int goalX = goalXval;     
            int goalY = goalYval;    
            string timeScored = timerLabel.Text;          
            string goalPeriod = periodBox.Text;

            // Create a new Goal instance
            Goal newGoal = new Goal
            {
                ScoredByPlayer = scoredByPlayer,
                ScoredByTeam = scoredByTeam,
                AssistByPlayer = assistByPlayer,
                ScoredAgainstGoalie = scoredOnGoalie,
                AssistX = assistX,
                AssistY = assistY,
                GoalX = goalX,
                GoalY = goalY,
                TimeScored = timeScored,
                Period = goalPeriod
            };

            // Add the new goal to the list
            goalList.Add(newGoal);

            ListViewItem listViewItem = new ListViewItem(new string[]
            {
                 scoredByPlayer.ToString(),
                 scoredByTeam,
                 assistByPlayer.ToString(),
                 scoredOnGoalie.ToString(),
                 assistX.ToString(),
                 assistY.ToString(),
                 goalX.ToString(),
                 goalY.ToString(),
                 timeScored.ToString(),
                 goalPeriod
            });

            goalListView.Items.Add(listViewItem);

            if (scoredByTeam == "Home")
            {
                hScore = hScore + 1;
                homeScore.Text = hScore.ToString();
            }
            else
            {
                aScore = aScore + 1;
                awayScore.Text = aScore.ToString();
            }

            
            ClearInputControls();

            
            MessageBox.Show("Goal submitted successfully!");
        }

        private void ClearInputControls()
        {
            
        }

        private void exportBtn_Click(object sender, EventArgs e)
        {
            try
            {
                // Create a new Excel package
                using (ExcelPackage excelPackage = new ExcelPackage())
                {
                    // Add a new worksheet to the Excel package
                    ExcelWorksheet worksheet = excelPackage.Workbook.Worksheets.Add("Goals");

                    // Add column headers
                    worksheet.Cells["A1"].Value = "ScoredByPlayer";
                    worksheet.Cells["B1"].Value = "ScoredByTeam";
                    worksheet.Cells["C1"].Value = "AssistByPlayer";
                    worksheet.Cells["D1"].Value = "ScoredAgainstGoalie";
                    worksheet.Cells["E1"].Value = "AssistX";
                    worksheet.Cells["F1"].Value = "AssistY";
                    worksheet.Cells["G1"].Value = "GoalX";
                    worksheet.Cells["H1"].Value = "GoalY";
                    worksheet.Cells["I1"].Value = "TimeScored";
                    worksheet.Cells["J1"].Value = "Period";

                    // Add data to the worksheet
                    int row = 2;
                    foreach (Goal goal in goalList)
                    {

                        if (goal != null)
                        {
                            worksheet.Cells[row, 1].Value = goal.ScoredByPlayer;
                            worksheet.Cells[row, 2].Value = goal.ScoredByTeam;
                            worksheet.Cells[row, 3].Value = goal.AssistByPlayer;
                            worksheet.Cells[row, 4].Value = goal.ScoredAgainstGoalie;
                            worksheet.Cells[row, 5].Value = goal.AssistX;
                            worksheet.Cells[row, 6].Value = goal.AssistY;
                            worksheet.Cells[row, 7].Value = goal.GoalX;
                            worksheet.Cells[row, 8].Value = goal.GoalY;
                            worksheet.Cells[row, 9].Value = goal.TimeScored;
                            worksheet.Cells[row, 10].Value = goal.Period;

                            row++;
                        }
                        else
                        {
                            // Handle the case where the Tag property is not set or is not a Goal object
                            MessageBox.Show("Invalid data in the ListView.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }


                    // Save the Excel package to a file
                    using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                    {
                        saveFileDialog.Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
                        saveFileDialog.FileName = "GoalsExport.xlsx";

                        if (saveFileDialog.ShowDialog() == DialogResult.OK)
                        {
                            FileInfo excelFile = new FileInfo(saveFileDialog.FileName);
                            excelPackage.SaveAs(excelFile);
                            MessageBox.Show("Data exported successfully!", "Export Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
