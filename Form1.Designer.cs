namespace BadmyTournamentSystem
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            dgv_player_gut = new DataGridView();
            team_gut = new DataGridViewTextBoxColumn();
            dgv_games = new DataGridView();
            dgv_ranking = new DataGridView();
            name = new DataGridViewTextBoxColumn();
            elopoints = new DataGridViewTextBoxColumn();
            points = new DataGridViewTextBoxColumn();
            points_aussetzer = new DataGridViewTextBoxColumn();
            button1 = new Button();
            dgv_player_sehrgut = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            AddVeryGoodPlayer = new Button();
            goodplayer_name = new TextBox();
            AddGoodPlayer = new Button();
            verygoodplayer_name = new TextBox();
            button2 = new Button();
            button3 = new Button();
            Rotieren = new Button();
            button4 = new Button();
            current_round = new TextBox();
            button5 = new Button();
            load_cache = new Button();
            save_cache = new Button();
            button7 = new Button();
            label1 = new Label();
            panel1 = new Panel();
            label2 = new Label();
            panel2 = new Panel();
            button6 = new Button();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            button8 = new Button();
            button9 = new Button();
            button10 = new Button();
            button11 = new Button();
            showRanking = new CheckBox();
            round = new DataGridViewTextBoxColumn();
            t1_gut = new DataGridViewTextBoxColumn();
            t1_sehrgut = new DataGridViewTextBoxColumn();
            t1_points = new DataGridViewComboBoxColumn();
            t2_points = new DataGridViewComboBoxColumn();
            t2_gut = new DataGridViewTextBoxColumn();
            t2_sehrgut = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgv_player_gut).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgv_games).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgv_ranking).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgv_player_sehrgut).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // dgv_player_gut
            // 
            dgv_player_gut.AllowUserToAddRows = false;
            dgv_player_gut.AllowUserToDeleteRows = false;
            dgv_player_gut.AllowUserToResizeColumns = false;
            dgv_player_gut.AllowUserToResizeRows = false;
            dgv_player_gut.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            dgv_player_gut.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_player_gut.Columns.AddRange(new DataGridViewColumn[] { team_gut });
            dgv_player_gut.Location = new Point(8, 167);
            dgv_player_gut.Name = "dgv_player_gut";
            dgv_player_gut.ReadOnly = true;
            dgv_player_gut.RowHeadersWidth = 5;
            dgv_player_gut.Size = new Size(240, 555);
            dgv_player_gut.TabIndex = 0;
            dgv_player_gut.CellValueChanged += dgv_player_gut_CellValueChanged;
            dgv_player_gut.MouseDown += dgv_player_gut_MouseDown;
            // 
            // team_gut
            // 
            team_gut.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            team_gut.HeaderText = "Team Gut";
            team_gut.Name = "team_gut";
            team_gut.ReadOnly = true;
            // 
            // dgv_games
            // 
            dgv_games.AllowUserToAddRows = false;
            dgv_games.AllowUserToDeleteRows = false;
            dgv_games.AllowUserToResizeRows = false;
            dgv_games.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            dgv_games.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_games.Columns.AddRange(new DataGridViewColumn[] { round, t1_gut, t1_sehrgut, t1_points, t2_points, t2_gut, t2_sehrgut });
            dgv_games.Location = new Point(500, 167);
            dgv_games.Name = "dgv_games";
            dgv_games.RowHeadersWidth = 5;
            dgv_games.Size = new Size(943, 554);
            dgv_games.TabIndex = 1;
            dgv_games.CellValueChanged += dgv_games_CellValueChanged;
            // 
            // dgv_ranking
            // 
            dgv_ranking.AllowUserToAddRows = false;
            dgv_ranking.AllowUserToDeleteRows = false;
            dgv_ranking.AllowUserToOrderColumns = true;
            dgv_ranking.AllowUserToResizeColumns = false;
            dgv_ranking.AllowUserToResizeRows = false;
            dgv_ranking.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            dgv_ranking.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_ranking.Columns.AddRange(new DataGridViewColumn[] { name, elopoints, points, points_aussetzer });
            dgv_ranking.Location = new Point(1449, 167);
            dgv_ranking.Name = "dgv_ranking";
            dgv_ranking.ReadOnly = true;
            dgv_ranking.RowHeadersWidth = 5;
            dgv_ranking.Size = new Size(441, 554);
            dgv_ranking.TabIndex = 2;
            dgv_ranking.CellValueChanged += dgv_ranking_CellValueChanged;
            // 
            // name
            // 
            name.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            name.HeaderText = "Name";
            name.Name = "name";
            name.ReadOnly = true;
            // 
            // elopoints
            // 
            elopoints.HeaderText = "Punkte (ELO)";
            elopoints.Name = "elopoints";
            elopoints.ReadOnly = true;
            // 
            // points
            // 
            points.HeaderText = "Punkte (Spiele)";
            points.Name = "points";
            points.ReadOnly = true;
            // 
            // points_aussetzer
            // 
            points_aussetzer.HeaderText = "Ausgesetze Spiele";
            points_aussetzer.Name = "points_aussetzer";
            points_aussetzer.ReadOnly = true;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Location = new Point(12, 764);
            button1.Name = "button1";
            button1.Size = new Size(94, 23);
            button1.TabIndex = 3;
            button1.Text = "Randomize";
            button1.UseVisualStyleBackColor = true;
            button1.Click += RandomizeSpielerGut;
            // 
            // dgv_player_sehrgut
            // 
            dgv_player_sehrgut.AllowUserToAddRows = false;
            dgv_player_sehrgut.AllowUserToDeleteRows = false;
            dgv_player_sehrgut.AllowUserToResizeColumns = false;
            dgv_player_sehrgut.AllowUserToResizeRows = false;
            dgv_player_sehrgut.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            dgv_player_sehrgut.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_player_sehrgut.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1 });
            dgv_player_sehrgut.Location = new Point(254, 167);
            dgv_player_sehrgut.Name = "dgv_player_sehrgut";
            dgv_player_sehrgut.ReadOnly = true;
            dgv_player_sehrgut.RowHeadersWidth = 5;
            dgv_player_sehrgut.Size = new Size(240, 555);
            dgv_player_sehrgut.TabIndex = 4;
            dgv_player_sehrgut.CellValueChanged += dgv_player_sehrgut_CellValueChanged;
            dgv_player_sehrgut.MouseDown += dgv_player_sehrgut_MouseDown;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumn1.HeaderText = "Team Sehr Gut";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // AddVeryGoodPlayer
            // 
            AddVeryGoodPlayer.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            AddVeryGoodPlayer.BackColor = Color.Chartreuse;
            AddVeryGoodPlayer.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            AddVeryGoodPlayer.Location = new Point(431, 728);
            AddVeryGoodPlayer.Name = "AddVeryGoodPlayer";
            AddVeryGoodPlayer.Size = new Size(29, 32);
            AddVeryGoodPlayer.TabIndex = 5;
            AddVeryGoodPlayer.Text = "+";
            AddVeryGoodPlayer.UseVisualStyleBackColor = false;
            AddVeryGoodPlayer.Click += AddVeryGoodPlayer_Click;
            // 
            // goodplayer_name
            // 
            goodplayer_name.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            goodplayer_name.Location = new Point(13, 735);
            goodplayer_name.Name = "goodplayer_name";
            goodplayer_name.Size = new Size(170, 23);
            goodplayer_name.TabIndex = 6;
            // 
            // AddGoodPlayer
            // 
            AddGoodPlayer.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            AddGoodPlayer.BackColor = Color.LawnGreen;
            AddGoodPlayer.FlatStyle = FlatStyle.Popup;
            AddGoodPlayer.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            AddGoodPlayer.Location = new Point(189, 728);
            AddGoodPlayer.Name = "AddGoodPlayer";
            AddGoodPlayer.Size = new Size(29, 32);
            AddGoodPlayer.TabIndex = 7;
            AddGoodPlayer.Text = "+";
            AddGoodPlayer.UseVisualStyleBackColor = false;
            AddGoodPlayer.Click += AddGoodPlayer_Click;
            // 
            // verygoodplayer_name
            // 
            verygoodplayer_name.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            verygoodplayer_name.Location = new Point(258, 735);
            verygoodplayer_name.Name = "verygoodplayer_name";
            verygoodplayer_name.Size = new Size(167, 23);
            verygoodplayer_name.TabIndex = 8;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Location = new Point(304, 764);
            button2.Name = "button2";
            button2.Size = new Size(94, 23);
            button2.TabIndex = 9;
            button2.Text = "Randomize";
            button2.UseVisualStyleBackColor = true;
            button2.Click += RandomizeSpielerSehrGut;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button3.BackColor = SystemColors.MenuHighlight;
            button3.FlatStyle = FlatStyle.Popup;
            button3.Location = new Point(501, 728);
            button3.Name = "button3";
            button3.Size = new Size(162, 23);
            button3.TabIndex = 10;
            button3.Text = "Spiel Generieren";
            button3.UseVisualStyleBackColor = false;
            button3.Click += GenerateGame;
            // 
            // Rotieren
            // 
            Rotieren.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            Rotieren.FlatStyle = FlatStyle.Popup;
            Rotieren.Location = new Point(112, 764);
            Rotieren.Name = "Rotieren";
            Rotieren.Size = new Size(94, 23);
            Rotieren.TabIndex = 11;
            Rotieren.Text = "Rotieren";
            Rotieren.UseVisualStyleBackColor = true;
            Rotieren.Click += PlayerGoodRotate;
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button4.FlatStyle = FlatStyle.Popup;
            button4.Location = new Point(404, 764);
            button4.Name = "button4";
            button4.Size = new Size(94, 23);
            button4.TabIndex = 12;
            button4.Text = "Rotieren";
            button4.UseVisualStyleBackColor = true;
            button4.Click += PlayerVeryGoodRotate;
            // 
            // current_round
            // 
            current_round.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            current_round.Location = new Point(669, 727);
            current_round.Name = "current_round";
            current_round.ReadOnly = true;
            current_round.Size = new Size(28, 23);
            current_round.TabIndex = 13;
            current_round.Text = "1";
            // 
            // button5
            // 
            button5.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button5.FlatStyle = FlatStyle.Popup;
            button5.Location = new Point(1450, 728);
            button5.Name = "button5";
            button5.Size = new Size(152, 23);
            button5.TabIndex = 14;
            button5.Text = "Ranking neu berechnen";
            button5.UseVisualStyleBackColor = true;
            button5.Click += CalculateRanking;
            // 
            // load_cache
            // 
            load_cache.BackColor = Color.White;
            load_cache.FlatStyle = FlatStyle.Popup;
            load_cache.Location = new Point(114, 6);
            load_cache.Name = "load_cache";
            load_cache.Size = new Size(100, 23);
            load_cache.TabIndex = 15;
            load_cache.Text = "Load Cache";
            load_cache.UseVisualStyleBackColor = false;
            load_cache.Click += LoadCache;
            // 
            // save_cache
            // 
            save_cache.BackColor = Color.White;
            save_cache.FlatStyle = FlatStyle.Popup;
            save_cache.Location = new Point(8, 6);
            save_cache.Name = "save_cache";
            save_cache.Size = new Size(100, 23);
            save_cache.TabIndex = 16;
            save_cache.Text = "Save Cache";
            save_cache.UseVisualStyleBackColor = false;
            save_cache.Click += SaveCache;
            // 
            // button7
            // 
            button7.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button7.BackColor = Color.White;
            button7.FlatStyle = FlatStyle.Popup;
            button7.Location = new Point(1790, 5);
            button7.Name = "button7";
            button7.Size = new Size(100, 23);
            button7.TabIndex = 18;
            button7.Text = "Clear Cache";
            button7.UseVisualStyleBackColor = false;
            button7.Click += ClearCache;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("a Autobus Omnibus", 23.9999962F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(40, 34);
            label1.Name = "label1";
            label1.Size = new Size(155, 32);
            label1.TabIndex = 19;
            label1.Text = "BADMY";
            // 
            // panel1
            // 
            panel1.AutoSize = true;
            panel1.BackColor = Color.FromArgb(40, 53, 131);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.MinimumSize = new Size(0, 100);
            panel1.Name = "panel1";
            panel1.Size = new Size(1902, 100);
            panel1.TabIndex = 20;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Nasalization Rg", 14.2499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(188, 42);
            label2.Name = "label2";
            label2.Size = new Size(255, 23);
            label2.TabIndex = 20;
            label2.Text = "TOURNAMENT SYSTEM";
            // 
            // panel2
            // 
            panel2.AutoSize = true;
            panel2.BackColor = Color.DimGray;
            panel2.Controls.Add(button6);
            panel2.Controls.Add(save_cache);
            panel2.Controls.Add(load_cache);
            panel2.Controls.Add(button7);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 100);
            panel2.MinimumSize = new Size(0, 33);
            panel2.Name = "panel2";
            panel2.Size = new Size(1902, 33);
            panel2.TabIndex = 21;
            // 
            // button6
            // 
            button6.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            button6.BackColor = Color.White;
            button6.FlatStyle = FlatStyle.Popup;
            button6.Location = new Point(924, 5);
            button6.Name = "button6";
            button6.Size = new Size(100, 23);
            button6.TabIndex = 25;
            button6.Text = "Clear Games";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click_1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("a Autobus Omnibus", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(219, 145);
            label3.Name = "label3";
            label3.Size = new Size(55, 12);
            label3.TabIndex = 22;
            label3.Text = "TEAMS";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("a Autobus Omnibus", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(941, 145);
            label4.Name = "label4";
            label4.Size = new Size(54, 12);
            label4.TabIndex = 23;
            label4.Text = "Spiele";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("a Autobus Omnibus", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(1647, 145);
            label5.Name = "label5";
            label5.Size = new Size(66, 12);
            label5.TabIndex = 24;
            label5.Text = "Ranking";
            // 
            // button8
            // 
            button8.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button8.FlatStyle = FlatStyle.Popup;
            button8.Location = new Point(220, 764);
            button8.Name = "button8";
            button8.Size = new Size(32, 23);
            button8.TabIndex = 25;
            button8.Text = "->";
            button8.UseVisualStyleBackColor = true;
            button8.Click += BringPlayerGoodToVeryGood;
            // 
            // button9
            // 
            button9.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button9.FlatStyle = FlatStyle.Popup;
            button9.Location = new Point(258, 764);
            button9.Name = "button9";
            button9.Size = new Size(32, 23);
            button9.TabIndex = 26;
            button9.Text = "<-";
            button9.UseVisualStyleBackColor = true;
            button9.Click += BringPlayerVeryGoodToGood;
            // 
            // button10
            // 
            button10.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button10.BackColor = Color.IndianRed;
            button10.FlatStyle = FlatStyle.Popup;
            button10.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            button10.Location = new Point(220, 728);
            button10.Name = "button10";
            button10.Size = new Size(29, 32);
            button10.TabIndex = 27;
            button10.Text = "-";
            button10.UseVisualStyleBackColor = false;
            button10.Click += RemoveGoodPlayer;
            // 
            // button11
            // 
            button11.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button11.BackColor = Color.IndianRed;
            button11.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button11.Location = new Point(466, 728);
            button11.Name = "button11";
            button11.Size = new Size(29, 32);
            button11.TabIndex = 28;
            button11.Text = "-";
            button11.UseVisualStyleBackColor = false;
            button11.Click += RemoveVeryGoodPlayer;
            // 
            // showRanking
            // 
            showRanking.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            showRanking.AutoSize = true;
            showRanking.Location = new Point(1611, 732);
            showRanking.Name = "showRanking";
            showRanking.Size = new Size(101, 19);
            showRanking.TabIndex = 29;
            showRanking.Text = "Zeige Ranking";
            showRanking.UseVisualStyleBackColor = true;
            showRanking.CheckStateChanged += ChangeVisability;
            // 
            // round
            // 
            round.HeaderText = "Runde";
            round.Name = "round";
            round.ReadOnly = true;
            // 
            // t1_gut
            // 
            t1_gut.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            t1_gut.HeaderText = "T1 Gut";
            t1_gut.Name = "t1_gut";
            t1_gut.ReadOnly = true;
            // 
            // t1_sehrgut
            // 
            t1_sehrgut.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            t1_sehrgut.HeaderText = "T1 Sehr Gut";
            t1_sehrgut.Name = "t1_sehrgut";
            t1_sehrgut.ReadOnly = true;
            // 
            // t1_points
            // 
            t1_points.HeaderText = "Team1 Points";
            t1_points.Items.AddRange(new object[] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30" });
            t1_points.Name = "t1_points";
            // 
            // t2_points
            // 
            t2_points.HeaderText = "Team2 Points";
            t2_points.Items.AddRange(new object[] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30" });
            t2_points.Name = "t2_points";
            t2_points.Resizable = DataGridViewTriState.True;
            t2_points.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // t2_gut
            // 
            t2_gut.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            t2_gut.HeaderText = "T2 Gut";
            t2_gut.Name = "t2_gut";
            t2_gut.ReadOnly = true;
            // 
            // t2_sehrgut
            // 
            t2_sehrgut.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            t2_sehrgut.HeaderText = "T2 Sehr Gut";
            t2_sehrgut.Name = "t2_sehrgut";
            t2_sehrgut.ReadOnly = true;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1902, 797);
            Controls.Add(showRanking);
            Controls.Add(button11);
            Controls.Add(button10);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(button5);
            Controls.Add(current_round);
            Controls.Add(button4);
            Controls.Add(Rotieren);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(verygoodplayer_name);
            Controls.Add(AddGoodPlayer);
            Controls.Add(goodplayer_name);
            Controls.Add(AddVeryGoodPlayer);
            Controls.Add(dgv_player_sehrgut);
            Controls.Add(button1);
            Controls.Add(dgv_ranking);
            Controls.Add(dgv_games);
            Controls.Add(dgv_player_gut);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(1918, 0);
            Name = "Main";
            Text = "Badmy | Tournament System";
            Load += Main_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_player_gut).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgv_games).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgv_ranking).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgv_player_sehrgut).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgv_player_gut;
        private DataGridView dgv_games;
        private DataGridView dgv_ranking;
        private Button button1;
        private DataGridViewTextBoxColumn team_gut;
        private DataGridView dgv_player_sehrgut;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private Button AddVeryGoodPlayer;
        private TextBox goodplayer_name;
        private Button AddGoodPlayer;
        private TextBox verygoodplayer_name;
        private Button button2;
        private Button button3;
        private Button Rotieren;
        private Button button4;
        private TextBox current_round;
        private Button button5;
        private Button load_cache;
        private Button save_cache;
        private Button button7;
        private Label label1;
        private Panel panel1;
        private Label label2;
        private Panel panel2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button button6;
        private Button button8;
        private Button button9;
        private Button button10;
        private Button button11;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn elopoints;
        private DataGridViewTextBoxColumn points;
        private DataGridViewTextBoxColumn points_aussetzer;
        private CheckBox showRanking;
        private DataGridViewTextBoxColumn round;
        private DataGridViewTextBoxColumn t1_gut;
        private DataGridViewTextBoxColumn t1_sehrgut;
        private DataGridViewComboBoxColumn t1_points;
        private DataGridViewComboBoxColumn t2_points;
        private DataGridViewTextBoxColumn t2_gut;
        private DataGridViewTextBoxColumn t2_sehrgut;
    }
}
