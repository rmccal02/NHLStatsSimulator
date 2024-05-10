namespace NHLStatsProject
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            ColumnHeader columnHeader1;
            ColumnHeader columnHeader3;
            ColumnHeader columnHeader4;
            ColumnHeader columnHeader6;
            ColumnHeader columnHeader10;
            ColumnHeader columnHeader12;
            ColumnHeader columnHeader7;
            ColumnHeader columnHeader9;
            ColumnHeader columnHeader13;
            ColumnHeader columnHeader15;
            ColumnHeader columnHeader16;
            ColumnHeader columnHeader18;
            ListViewGroup listViewGroup1 = new ListViewGroup("Scored By", HorizontalAlignment.Left);
            pictureBox1 = new PictureBox();
            XLabel = new Label();
            YLabel = new Label();
            XSelect = new Label();
            YSelect = new Label();
            addHome = new Button();
            homeLabel = new Label();
            listView1 = new ListView();
            columnHeader2 = new ColumnHeader();
            onIceList = new ListView();
            columnHeader5 = new ColumnHeader();
            label1 = new Label();
            updateLine = new Button();
            StartButton = new Button();
            StopButton = new Button();
            timerLabel = new Label();
            gameTimer = new System.Windows.Forms.Timer(components);
            panel1 = new Panel();
            resetTimer = new Button();
            secondsBox = new TextBox();
            minutesBox = new TextBox();
            label2 = new Label();
            button1 = new Button();
            periodBox = new ComboBox();
            label3 = new Label();
            awayPenList = new ListView();
            columnHeader11 = new ColumnHeader();
            label4 = new Label();
            label5 = new Label();
            homePenList = new ListView();
            columnHeader8 = new ColumnHeader();
            penaltyButton = new Button();
            hPen1 = new Label();
            hPen2 = new Label();
            aPen2 = new Label();
            aPen1 = new Label();
            penaltyTimer = new System.Windows.Forms.Timer(components);
            panel2 = new Panel();
            label6 = new Label();
            listView2 = new ListView();
            columnHeader14 = new ColumnHeader();
            awayLabel = new Label();
            awayAdd = new Button();
            panel3 = new Panel();
            label8 = new Label();
            awayPen = new Button();
            label9 = new Label();
            onIceListA = new ListView();
            columnHeader17 = new ColumnHeader();
            panel4 = new Panel();
            scoredOnJersey = new NumericUpDown();
            assistByJersey = new NumericUpDown();
            scoredByJersey = new NumericUpDown();
            label19 = new Label();
            label18 = new Label();
            goalTeamCombo = new ComboBox();
            label17 = new Label();
            lockAssistCoordinates = new Button();
            lockGoalCoordinates = new Button();
            label15 = new Label();
            label16 = new Label();
            assistY = new TextBox();
            assistX = new TextBox();
            label14 = new Label();
            label13 = new Label();
            goalY = new TextBox();
            goalX = new TextBox();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            undoGoal = new Button();
            submitGoal = new Button();
            label7 = new Label();
            panel5 = new Panel();
            label21 = new Label();
            homeScore = new Label();
            panel6 = new Panel();
            label22 = new Label();
            awayScore = new Label();
            goalListView = new ListView();
            ScoredBy = new ColumnHeader();
            ScoredByTeam = new ColumnHeader();
            AssistByPlayer = new ColumnHeader();
            ScoredAgainstGoalie = new ColumnHeader();
            XAssist = new ColumnHeader();
            YAssist = new ColumnHeader();
            XGoal = new ColumnHeader();
            YGoal = new ColumnHeader();
            timeScored = new ColumnHeader();
            periodScored = new ColumnHeader();
            exportBtn = new Button();
            columnHeader1 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            columnHeader10 = new ColumnHeader();
            columnHeader12 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            columnHeader9 = new ColumnHeader();
            columnHeader13 = new ColumnHeader();
            columnHeader15 = new ColumnHeader();
            columnHeader16 = new ColumnHeader();
            columnHeader18 = new ColumnHeader();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)scoredOnJersey).BeginInit();
            ((System.ComponentModel.ISupportInitialize)assistByJersey).BeginInit();
            ((System.ComponentModel.ISupportInitialize)scoredByJersey).BeginInit();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            SuspendLayout();
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Player:";
            columnHeader1.Width = 100;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Position";
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Player:";
            columnHeader4.Width = 100;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Position";
            // 
            // columnHeader10
            // 
            columnHeader10.Text = "Player:";
            columnHeader10.Width = 100;
            // 
            // columnHeader12
            // 
            columnHeader12.Text = "Position";
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "Player:";
            columnHeader7.Width = 100;
            // 
            // columnHeader9
            // 
            columnHeader9.Text = "Position";
            // 
            // columnHeader13
            // 
            columnHeader13.Text = "Player:";
            columnHeader13.Width = 100;
            // 
            // columnHeader15
            // 
            columnHeader15.Text = "Position";
            // 
            // columnHeader16
            // 
            columnHeader16.Text = "Player:";
            columnHeader16.Width = 100;
            // 
            // columnHeader18
            // 
            columnHeader18.Text = "Position";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.Location = new Point(516, 250);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(760, 400);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            pictureBox1.MouseCaptureChanged += pictureBox1_MouseCaptureChanged;
            // 
            // XLabel
            // 
            XLabel.AutoSize = true;
            XLabel.BackColor = Color.White;
            XLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            XLabel.Location = new Point(651, 217);
            XLabel.Name = "XLabel";
            XLabel.Size = new Size(75, 30);
            XLabel.TabIndex = 1;
            XLabel.Text = "X: 000";
            // 
            // YLabel
            // 
            YLabel.AutoSize = true;
            YLabel.BackColor = Color.White;
            YLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            YLabel.Location = new Point(731, 217);
            YLabel.Name = "YLabel";
            YLabel.Size = new Size(74, 30);
            YLabel.TabIndex = 2;
            YLabel.Text = "Y: 000";
            // 
            // XSelect
            // 
            XSelect.AutoSize = true;
            XSelect.BackColor = Color.White;
            XSelect.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            XSelect.Location = new Point(910, 217);
            XSelect.Name = "XSelect";
            XSelect.Size = new Size(163, 30);
            XSelect.TabIndex = 3;
            XSelect.Text = "Selected X: 000";
            // 
            // YSelect
            // 
            YSelect.AutoSize = true;
            YSelect.BackColor = Color.White;
            YSelect.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            YSelect.Location = new Point(1079, 217);
            YSelect.Name = "YSelect";
            YSelect.Size = new Size(74, 30);
            YSelect.TabIndex = 4;
            YSelect.Text = "Y: 000";
            // 
            // addHome
            // 
            addHome.Location = new Point(161, 224);
            addHome.Name = "addHome";
            addHome.Size = new Size(75, 23);
            addHome.TabIndex = 7;
            addHome.Text = "Add";
            addHome.UseVisualStyleBackColor = true;
            addHome.Click += addHome_Click;
            // 
            // homeLabel
            // 
            homeLabel.AutoSize = true;
            homeLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            homeLabel.Location = new Point(12, 226);
            homeLabel.Name = "homeLabel";
            homeLabel.Size = new Size(60, 21);
            homeLabel.TabIndex = 8;
            homeLabel.Text = "Home:";
            // 
            // listView1
            // 
            listView1.AllowDrop = true;
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3 });
            listView1.Location = new Point(12, 250);
            listView1.Name = "listView1";
            listView1.Size = new Size(224, 400);
            listView1.TabIndex = 9;
            listView1.Tag = "Player";
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Number:";
            // 
            // onIceList
            // 
            onIceList.AllowDrop = true;
            onIceList.Columns.AddRange(new ColumnHeader[] { columnHeader4, columnHeader5, columnHeader6 });
            onIceList.Location = new Point(261, 250);
            onIceList.Name = "onIceList";
            onIceList.Size = new Size(224, 200);
            onIceList.TabIndex = 10;
            onIceList.Tag = "Player";
            onIceList.UseCompatibleStateImageBehavior = false;
            onIceList.View = View.Details;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Number:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(261, 226);
            label1.Name = "label1";
            label1.Size = new Size(112, 21);
            label1.TabIndex = 11;
            label1.Text = "Home On Ice:";
            // 
            // updateLine
            // 
            updateLine.Location = new Point(410, 224);
            updateLine.Name = "updateLine";
            updateLine.Size = new Size(75, 23);
            updateLine.TabIndex = 12;
            updateLine.Text = "Update Line";
            updateLine.UseVisualStyleBackColor = true;
            updateLine.Click += updateLine_Click;
            // 
            // StartButton
            // 
            StartButton.Location = new Point(50, 52);
            StartButton.Name = "StartButton";
            StartButton.Size = new Size(75, 23);
            StartButton.TabIndex = 13;
            StartButton.Text = "Start/Resume";
            StartButton.UseVisualStyleBackColor = true;
            StartButton.Click += StartButton_Click;
            // 
            // StopButton
            // 
            StopButton.Location = new Point(130, 52);
            StopButton.Name = "StopButton";
            StopButton.Size = new Size(75, 23);
            StopButton.TabIndex = 14;
            StopButton.Text = "Pause";
            StopButton.UseVisualStyleBackColor = true;
            StopButton.Click += StopButton_Click;
            // 
            // timerLabel
            // 
            timerLabel.AutoSize = true;
            timerLabel.BackColor = Color.White;
            timerLabel.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            timerLabel.Location = new Point(90, 17);
            timerLabel.Name = "timerLabel";
            timerLabel.Size = new Size(77, 32);
            timerLabel.TabIndex = 15;
            timerLabel.Text = "00:00";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(resetTimer);
            panel1.Controls.Add(secondsBox);
            panel1.Controls.Add(minutesBox);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(timerLabel);
            panel1.Controls.Add(StopButton);
            panel1.Controls.Add(StartButton);
            panel1.Location = new Point(771, 45);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 150);
            panel1.TabIndex = 16;
            // 
            // resetTimer
            // 
            resetTimer.Location = new Point(130, 79);
            resetTimer.Name = "resetTimer";
            resetTimer.Size = new Size(75, 23);
            resetTimer.TabIndex = 20;
            resetTimer.Text = "Reset";
            resetTimer.UseVisualStyleBackColor = true;
            resetTimer.Click += resetTimer_Click;
            // 
            // secondsBox
            // 
            secondsBox.Location = new Point(130, 115);
            secondsBox.Name = "secondsBox";
            secondsBox.Size = new Size(48, 23);
            secondsBox.TabIndex = 19;
            secondsBox.Text = "00";
            // 
            // minutesBox
            // 
            minutesBox.Location = new Point(75, 115);
            minutesBox.Name = "minutesBox";
            minutesBox.Size = new Size(48, 23);
            minutesBox.TabIndex = 18;
            minutesBox.Text = "00";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(117, 105);
            label2.Name = "label2";
            label2.Size = new Size(21, 32);
            label2.TabIndex = 17;
            label2.Text = ":";
            // 
            // button1
            // 
            button1.Location = new Point(50, 79);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 16;
            button1.Text = "Jump To";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // periodBox
            // 
            periodBox.FormattingEnabled = true;
            periodBox.Items.AddRange(new object[] { "1", "2", "3", "4" });
            periodBox.Location = new Point(988, 16);
            periodBox.Name = "periodBox";
            periodBox.Size = new Size(33, 23);
            periodBox.TabIndex = 20;
            periodBox.Text = "1";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Gray;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(918, 16);
            label3.Name = "label3";
            label3.Size = new Size(64, 21);
            label3.TabIndex = 21;
            label3.Text = "Period:";
            // 
            // awayPenList
            // 
            awayPenList.AllowDrop = true;
            awayPenList.Columns.AddRange(new ColumnHeader[] { columnHeader10, columnHeader11, columnHeader12 });
            awayPenList.Location = new Point(1161, 45);
            awayPenList.Name = "awayPenList";
            awayPenList.Size = new Size(224, 89);
            awayPenList.TabIndex = 23;
            awayPenList.Tag = "Player";
            awayPenList.UseCompatibleStateImageBehavior = false;
            awayPenList.View = View.Details;
            // 
            // columnHeader11
            // 
            columnHeader11.Text = "Number:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Gray;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(407, 18);
            label4.Name = "label4";
            label4.Size = new Size(118, 21);
            label4.TabIndex = 24;
            label4.Text = "Home Penalty";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Gray;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(1271, 18);
            label5.Name = "label5";
            label5.Size = new Size(114, 21);
            label5.TabIndex = 25;
            label5.Text = "Away Penalty";
            // 
            // homePenList
            // 
            homePenList.AllowDrop = true;
            homePenList.Columns.AddRange(new ColumnHeader[] { columnHeader7, columnHeader8, columnHeader9 });
            homePenList.Location = new Point(407, 45);
            homePenList.Name = "homePenList";
            homePenList.Size = new Size(224, 89);
            homePenList.TabIndex = 26;
            homePenList.Tag = "Player";
            homePenList.UseCompatibleStateImageBehavior = false;
            homePenList.View = View.Details;
            // 
            // columnHeader8
            // 
            columnHeader8.Text = "Number:";
            // 
            // penaltyButton
            // 
            penaltyButton.Location = new Point(74, 36);
            penaltyButton.Name = "penaltyButton";
            penaltyButton.Size = new Size(75, 23);
            penaltyButton.TabIndex = 27;
            penaltyButton.Text = "2:00";
            penaltyButton.UseVisualStyleBackColor = true;
            penaltyButton.Click += penaltyButton_Click;
            // 
            // hPen1
            // 
            hPen1.AutoSize = true;
            hPen1.BackColor = Color.White;
            hPen1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            hPen1.Location = new Point(408, 137);
            hPen1.Name = "hPen1";
            hPen1.Size = new Size(63, 32);
            hPen1.TabIndex = 28;
            hPen1.Text = "0:00";
            // 
            // hPen2
            // 
            hPen2.AutoSize = true;
            hPen2.BackColor = Color.White;
            hPen2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            hPen2.Location = new Point(477, 137);
            hPen2.Name = "hPen2";
            hPen2.Size = new Size(63, 32);
            hPen2.TabIndex = 29;
            hPen2.Text = "0:00";
            // 
            // aPen2
            // 
            aPen2.AutoSize = true;
            aPen2.BackColor = Color.White;
            aPen2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            aPen2.Location = new Point(1252, 137);
            aPen2.Name = "aPen2";
            aPen2.Size = new Size(63, 32);
            aPen2.TabIndex = 30;
            aPen2.Text = "0:00";
            // 
            // aPen1
            // 
            aPen1.AutoSize = true;
            aPen1.BackColor = Color.White;
            aPen1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            aPen1.Location = new Point(1321, 137);
            aPen1.Name = "aPen1";
            aPen1.Size = new Size(63, 32);
            aPen1.TabIndex = 31;
            aPen1.Text = "0:00";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(label6);
            panel2.Controls.Add(penaltyButton);
            panel2.Location = new Point(179, 45);
            panel2.Name = "panel2";
            panel2.Size = new Size(222, 73);
            panel2.TabIndex = 32;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(53, 12);
            label6.Name = "label6";
            label6.Size = new Size(122, 21);
            label6.TabIndex = 29;
            label6.Text = "Home Penalty:";
            // 
            // listView2
            // 
            listView2.AllowDrop = true;
            listView2.Columns.AddRange(new ColumnHeader[] { columnHeader13, columnHeader14, columnHeader15 });
            listView2.Location = new Point(1548, 250);
            listView2.Name = "listView2";
            listView2.Size = new Size(224, 400);
            listView2.TabIndex = 35;
            listView2.Tag = "Player";
            listView2.UseCompatibleStateImageBehavior = false;
            listView2.View = View.Details;
            // 
            // columnHeader14
            // 
            columnHeader14.Text = "Number:";
            // 
            // awayLabel
            // 
            awayLabel.AutoSize = true;
            awayLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            awayLabel.Location = new Point(1548, 226);
            awayLabel.Name = "awayLabel";
            awayLabel.Size = new Size(56, 21);
            awayLabel.TabIndex = 34;
            awayLabel.Text = "Away:";
            // 
            // awayAdd
            // 
            awayAdd.Location = new Point(1697, 224);
            awayAdd.Name = "awayAdd";
            awayAdd.Size = new Size(75, 23);
            awayAdd.TabIndex = 33;
            awayAdd.Text = "Add";
            awayAdd.UseVisualStyleBackColor = true;
            awayAdd.Click += awayAdd_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(label8);
            panel3.Controls.Add(awayPen);
            panel3.Location = new Point(1391, 45);
            panel3.Name = "panel3";
            panel3.Size = new Size(222, 73);
            panel3.TabIndex = 38;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(54, 12);
            label8.Name = "label8";
            label8.Size = new Size(118, 21);
            label8.TabIndex = 29;
            label8.Text = "Away Penalty:";
            // 
            // awayPen
            // 
            awayPen.Location = new Point(74, 36);
            awayPen.Name = "awayPen";
            awayPen.Size = new Size(75, 23);
            awayPen.TabIndex = 27;
            awayPen.Text = "2:00";
            awayPen.UseVisualStyleBackColor = true;
            awayPen.Click += awayPen_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(1303, 226);
            label9.Name = "label9";
            label9.Size = new Size(108, 21);
            label9.TabIndex = 37;
            label9.Text = "Away On Ice:";
            // 
            // onIceListA
            // 
            onIceListA.AllowDrop = true;
            onIceListA.Columns.AddRange(new ColumnHeader[] { columnHeader16, columnHeader17, columnHeader18 });
            onIceListA.Location = new Point(1303, 250);
            onIceListA.Name = "onIceListA";
            onIceListA.Size = new Size(224, 200);
            onIceListA.TabIndex = 36;
            onIceListA.Tag = "Player";
            onIceListA.UseCompatibleStateImageBehavior = false;
            onIceListA.View = View.Details;
            // 
            // columnHeader17
            // 
            columnHeader17.Text = "Number:";
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Controls.Add(exportBtn);
            panel4.Controls.Add(scoredOnJersey);
            panel4.Controls.Add(assistByJersey);
            panel4.Controls.Add(scoredByJersey);
            panel4.Controls.Add(label19);
            panel4.Controls.Add(label18);
            panel4.Controls.Add(goalTeamCombo);
            panel4.Controls.Add(label17);
            panel4.Controls.Add(lockAssistCoordinates);
            panel4.Controls.Add(lockGoalCoordinates);
            panel4.Controls.Add(label15);
            panel4.Controls.Add(label16);
            panel4.Controls.Add(assistY);
            panel4.Controls.Add(assistX);
            panel4.Controls.Add(label14);
            panel4.Controls.Add(label13);
            panel4.Controls.Add(goalY);
            panel4.Controls.Add(goalX);
            panel4.Controls.Add(label12);
            panel4.Controls.Add(label11);
            panel4.Controls.Add(label10);
            panel4.Controls.Add(undoGoal);
            panel4.Controls.Add(submitGoal);
            panel4.Controls.Add(label7);
            panel4.Location = new Point(933, 656);
            panel4.Name = "panel4";
            panel4.Size = new Size(393, 157);
            panel4.TabIndex = 39;
            // 
            // scoredOnJersey
            // 
            scoredOnJersey.Location = new Point(245, 126);
            scoredOnJersey.Name = "scoredOnJersey";
            scoredOnJersey.Size = new Size(35, 23);
            scoredOnJersey.TabIndex = 45;
            // 
            // assistByJersey
            // 
            assistByJersey.Location = new Point(76, 76);
            assistByJersey.Name = "assistByJersey";
            assistByJersey.Size = new Size(35, 23);
            assistByJersey.TabIndex = 44;
            // 
            // scoredByJersey
            // 
            scoredByJersey.Location = new Point(76, 47);
            scoredByJersey.Name = "scoredByJersey";
            scoredByJersey.Size = new Size(35, 23);
            scoredByJersey.TabIndex = 43;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(167, 19);
            label19.Name = "label19";
            label19.Size = new Size(82, 15);
            label19.TabIndex = 22;
            label19.Text = "Goal for team:\r\n";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(98, 128);
            label18.Name = "label18";
            label18.Size = new Size(151, 15);
            label18.TabIndex = 21;
            label18.Text = "Scored on (goalie number):";
            // 
            // goalTeamCombo
            // 
            goalTeamCombo.FormattingEnabled = true;
            goalTeamCombo.Items.AddRange(new object[] { "Home", "Away" });
            goalTeamCombo.Location = new Point(259, 16);
            goalTeamCombo.Name = "goalTeamCombo";
            goalTeamCombo.Size = new Size(121, 23);
            goalTeamCombo.TabIndex = 19;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(118, 101);
            label17.Name = "label17";
            label17.Size = new Size(139, 15);
            label17.TabIndex = 18;
            label17.Text = "(Leave Blank if No Assist)";
            // 
            // lockAssistCoordinates
            // 
            lockAssistCoordinates.Location = new Point(245, 75);
            lockAssistCoordinates.Name = "lockAssistCoordinates";
            lockAssistCoordinates.Size = new Size(54, 23);
            lockAssistCoordinates.TabIndex = 17;
            lockAssistCoordinates.Text = "Lock ";
            lockAssistCoordinates.UseVisualStyleBackColor = true;
            lockAssistCoordinates.Click += lockAssistCoordinates_Click;
            // 
            // lockGoalCoordinates
            // 
            lockGoalCoordinates.Location = new Point(245, 45);
            lockGoalCoordinates.Name = "lockGoalCoordinates";
            lockGoalCoordinates.Size = new Size(54, 23);
            lockGoalCoordinates.TabIndex = 16;
            lockGoalCoordinates.Text = "Lock ";
            lockGoalCoordinates.UseVisualStyleBackColor = true;
            lockGoalCoordinates.Click += lockGoalCoordinates_Click;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(180, 78);
            label15.Name = "label15";
            label15.Size = new Size(17, 15);
            label15.TabIndex = 15;
            label15.Text = "Y:";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(117, 78);
            label16.Name = "label16";
            label16.Size = new Size(17, 15);
            label16.TabIndex = 14;
            label16.Text = "X:";
            // 
            // assistY
            // 
            assistY.Location = new Point(199, 75);
            assistY.Name = "assistY";
            assistY.Size = new Size(40, 23);
            assistY.TabIndex = 13;
            // 
            // assistX
            // 
            assistX.Location = new Point(134, 75);
            assistX.Name = "assistX";
            assistX.Size = new Size(40, 23);
            assistX.TabIndex = 12;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(180, 49);
            label14.Name = "label14";
            label14.Size = new Size(17, 15);
            label14.TabIndex = 11;
            label14.Text = "Y:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(117, 49);
            label13.Name = "label13";
            label13.Size = new Size(17, 15);
            label13.TabIndex = 10;
            label13.Text = "X:";
            // 
            // goalY
            // 
            goalY.Location = new Point(199, 46);
            goalY.Name = "goalY";
            goalY.Size = new Size(40, 23);
            goalY.TabIndex = 9;
            // 
            // goalX
            // 
            goalX.Location = new Point(134, 46);
            goalX.Name = "goalX";
            goalX.Size = new Size(40, 23);
            goalX.TabIndex = 8;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(19, 101);
            label12.Name = "label12";
            label12.Size = new Size(93, 15);
            label12.TabIndex = 7;
            label12.Text = "(Jersey Number)";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(30, 78);
            label11.Name = "label11";
            label11.Size = new Size(41, 15);
            label11.TabIndex = 6;
            label11.Text = "Assist:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(6, 49);
            label10.Name = "label10";
            label10.Size = new Size(65, 15);
            label10.TabIndex = 5;
            label10.Text = "Scored by:";
            // 
            // undoGoal
            // 
            undoGoal.Location = new Point(305, 74);
            undoGoal.Name = "undoGoal";
            undoGoal.Size = new Size(75, 23);
            undoGoal.TabIndex = 2;
            undoGoal.Text = "Undo Goal";
            undoGoal.UseVisualStyleBackColor = true;
            // 
            // submitGoal
            // 
            submitGoal.Location = new Point(305, 45);
            submitGoal.Name = "submitGoal";
            submitGoal.Size = new Size(75, 23);
            submitGoal.TabIndex = 1;
            submitGoal.Text = "Goal";
            submitGoal.UseVisualStyleBackColor = true;
            submitGoal.Click += submitGoal_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(3, 4);
            label7.Name = "label7";
            label7.Size = new Size(142, 32);
            label7.TabIndex = 0;
            label7.Text = "Goal Panel:";
            // 
            // panel5
            // 
            panel5.BackColor = Color.White;
            panel5.Controls.Add(label21);
            panel5.Controls.Add(homeScore);
            panel5.Location = new Point(637, 45);
            panel5.Name = "panel5";
            panel5.Size = new Size(128, 150);
            panel5.TabIndex = 40;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label21.Location = new Point(21, 3);
            label21.Name = "label21";
            label21.Size = new Size(88, 32);
            label21.TabIndex = 17;
            label21.Text = "HOME:";
            // 
            // homeScore
            // 
            homeScore.AutoSize = true;
            homeScore.BackColor = Color.White;
            homeScore.Font = new Font("Segoe UI", 72F, FontStyle.Bold, GraphicsUnit.Point, 0);
            homeScore.Location = new Point(14, 9);
            homeScore.Name = "homeScore";
            homeScore.Size = new Size(109, 128);
            homeScore.TabIndex = 16;
            homeScore.Text = "0";
            // 
            // panel6
            // 
            panel6.BackColor = Color.White;
            panel6.Controls.Add(label22);
            panel6.Controls.Add(awayScore);
            panel6.Location = new Point(1027, 45);
            panel6.Name = "panel6";
            panel6.Size = new Size(128, 150);
            panel6.TabIndex = 41;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label22.Location = new Point(21, 3);
            label22.Name = "label22";
            label22.Size = new Size(79, 32);
            label22.TabIndex = 17;
            label22.Text = "AWAY:";
            // 
            // awayScore
            // 
            awayScore.AutoSize = true;
            awayScore.BackColor = Color.White;
            awayScore.Font = new Font("Segoe UI", 72F, FontStyle.Bold, GraphicsUnit.Point, 0);
            awayScore.Location = new Point(14, 9);
            awayScore.Name = "awayScore";
            awayScore.Size = new Size(109, 128);
            awayScore.TabIndex = 16;
            awayScore.Text = "0";
            // 
            // goalListView
            // 
            goalListView.Columns.AddRange(new ColumnHeader[] { ScoredBy, ScoredByTeam, AssistByPlayer, ScoredAgainstGoalie, XAssist, YAssist, XGoal, YGoal, timeScored, periodScored });
            listViewGroup1.Header = "Scored By";
            listViewGroup1.Name = "listViewGroup1";
            goalListView.Groups.AddRange(new ListViewGroup[] { listViewGroup1 });
            goalListView.Location = new Point(12, 656);
            goalListView.Name = "goalListView";
            goalListView.Size = new Size(915, 293);
            goalListView.TabIndex = 42;
            goalListView.UseCompatibleStateImageBehavior = false;
            goalListView.View = View.Details;
            // 
            // ScoredBy
            // 
            ScoredBy.Text = "Scored By";
            ScoredBy.Width = 80;
            // 
            // ScoredByTeam
            // 
            ScoredByTeam.Text = "Scored By Team";
            ScoredByTeam.Width = 100;
            // 
            // AssistByPlayer
            // 
            AssistByPlayer.Text = "Assist By Player";
            AssistByPlayer.Width = 95;
            // 
            // ScoredAgainstGoalie
            // 
            ScoredAgainstGoalie.Text = "Scored Against Goalie";
            ScoredAgainstGoalie.Width = 130;
            // 
            // XAssist
            // 
            XAssist.Text = "X-Cord (Assist)";
            XAssist.Width = 95;
            // 
            // YAssist
            // 
            YAssist.Text = "Y-Cord (Assist)";
            YAssist.Width = 95;
            // 
            // XGoal
            // 
            XGoal.Text = "X-Cord (Goal)";
            XGoal.Width = 95;
            // 
            // YGoal
            // 
            YGoal.Text = "Y-Cord (Goal)";
            YGoal.Width = 95;
            // 
            // timeScored
            // 
            timeScored.Text = "Goal Time";
            timeScored.Width = 75;
            // 
            // periodScored
            // 
            periodScored.Text = "Period";
            periodScored.Width = 50;
            // 
            // exportBtn
            // 
            exportBtn.Location = new Point(315, 131);
            exportBtn.Name = "exportBtn";
            exportBtn.Size = new Size(75, 23);
            exportBtn.TabIndex = 46;
            exportBtn.Text = "Export";
            exportBtn.UseVisualStyleBackColor = true;
            exportBtn.Click += exportBtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(1784, 961);
            Controls.Add(goalListView);
            Controls.Add(panel6);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(label9);
            Controls.Add(onIceListA);
            Controls.Add(listView2);
            Controls.Add(awayLabel);
            Controls.Add(awayAdd);
            Controls.Add(panel2);
            Controls.Add(aPen1);
            Controls.Add(aPen2);
            Controls.Add(hPen2);
            Controls.Add(hPen1);
            Controls.Add(homePenList);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(awayPenList);
            Controls.Add(label3);
            Controls.Add(periodBox);
            Controls.Add(panel1);
            Controls.Add(updateLine);
            Controls.Add(label1);
            Controls.Add(onIceList);
            Controls.Add(listView1);
            Controls.Add(homeLabel);
            Controls.Add(addHome);
            Controls.Add(YSelect);
            Controls.Add(XSelect);
            Controls.Add(YLabel);
            Controls.Add(XLabel);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)scoredOnJersey).EndInit();
            ((System.ComponentModel.ISupportInitialize)assistByJersey).EndInit();
            ((System.ComponentModel.ISupportInitialize)scoredByJersey).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label XLabel;
        private Label YLabel;
        private Label XSelect;
        private Label YSelect;
        private Button addHome;
        private Label homeLabel;
        private ListView listView1;
        private ColumnHeader columnHeader2;
        private ListView onIceList;
        private ColumnHeader columnHeader5;
        private Label label1;
        private Button updateLine;
        private Button StartButton;
        private Button StopButton;
        private Label timerLabel;
        private System.Windows.Forms.Timer gameTimer;
        private Panel panel1;
        private Button button1;
        private TextBox secondsBox;
        private TextBox minutesBox;
        private Label label2;
        private ComboBox periodBox;
        private Label label3;
        private Button resetTimer;
        private ListView awayPenList;
        private ColumnHeader columnHeader11;
        private Label label4;
        private Label label5;
        private ListView homePenList;
        private ColumnHeader columnHeader8;
        private Button penaltyButton;
        private Label homePen1;
        private Label hPen1;
        private Label hPen2;
        private Label aPen2;
        private Label aPen1;
        private System.Windows.Forms.Timer penaltyTimer;
        private Panel panel2;
        private Label label6;
        private ListView listView2;
        private ColumnHeader columnHeader14;
        private Label awayLabel;
        private Button awayAdd;
        private Panel panel3;
        private Label label8;
        private Button awayPen;
        private Label label9;
        private ListView onIceListA;
        private ColumnHeader columnHeader17;
        private Panel panel4;
        private Button undoGoal;
        private Button submitGoal;
        private Label label7;
        private Label label15;
        private Label label16;
        private TextBox assistY;
        private TextBox assistX;
        private Label label14;
        private Label label13;
        private TextBox goalY;
        private TextBox goalX;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label17;
        private Button lockAssistCoordinates;
        private Button lockGoalCoordinates;
        private ComboBox goalTeamCombo;
        private Label label19;
        private Label label18;
        private Panel panel5;
        private Label homeScore;
        private Label label21;
        private Panel panel6;
        private Label label22;
        private Label awayScore;
        private NumericUpDown scoredByJersey;
        private NumericUpDown assistByJersey;
        private NumericUpDown scoredOnJersey;
        private ListView goalListView;
        private ColumnHeader ScoredBy;
        private ColumnHeader ScoredByTeam;
        private ColumnHeader AssistByPlayer;
        private ColumnHeader ScoredAgainstGoalie;
        private ColumnHeader XAssist;
        private ColumnHeader YAssist;
        private ColumnHeader XGoal;
        private ColumnHeader YGoal;
        private ColumnHeader timeScored;
        private ColumnHeader periodScored;
        private Button exportBtn;
    }
}
