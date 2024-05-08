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
            round = new DataGridViewTextBoxColumn();
            t1_gut = new DataGridViewTextBoxColumn();
            t1_sehrgut = new DataGridViewTextBoxColumn();
            t2_gut = new DataGridViewTextBoxColumn();
            t2_sehrgut = new DataGridViewTextBoxColumn();
            t_win = new DataGridViewComboBoxColumn();
            dgv_ranking = new DataGridView();
            name = new DataGridViewTextBoxColumn();
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
            dgv_player_gut.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_player_gut.Columns.AddRange(new DataGridViewColumn[] { team_gut });
            dgv_player_gut.Location = new Point(8, 167);
            dgv_player_gut.Name = "dgv_player_gut";
            dgv_player_gut.ReadOnly = true;
            dgv_player_gut.RowHeadersWidth = 5;
            dgv_player_gut.Size = new Size(240, 473);
            dgv_player_gut.TabIndex = 0;
            dgv_player_gut.CellValueChanged += dgv_player_gut_CellValueChanged;
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
            dgv_games.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_games.Columns.AddRange(new DataGridViewColumn[] { round, t1_gut, t1_sehrgut, t2_gut, t2_sehrgut, t_win });
            dgv_games.Location = new Point(500, 167);
            dgv_games.Name = "dgv_games";
            dgv_games.RowHeadersWidth = 5;
            dgv_games.Size = new Size(943, 473);
            dgv_games.TabIndex = 1;
            dgv_games.CellValueChanged += dgv_games_CellValueChanged;
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
            // t_win
            // 
            t_win.HeaderText = "Gewinnerteam";
            t_win.Items.AddRange(new object[] { "1", "2" });
            t_win.Name = "t_win";
            // 
            // dgv_ranking
            // 
            dgv_ranking.AllowUserToAddRows = false;
            dgv_ranking.AllowUserToDeleteRows = false;
            dgv_ranking.AllowUserToOrderColumns = true;
            dgv_ranking.AllowUserToResizeColumns = false;
            dgv_ranking.AllowUserToResizeRows = false;
            dgv_ranking.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_ranking.Columns.AddRange(new DataGridViewColumn[] { name, points, points_aussetzer });
            dgv_ranking.Location = new Point(1449, 167);
            dgv_ranking.Name = "dgv_ranking";
            dgv_ranking.ReadOnly = true;
            dgv_ranking.RowHeadersWidth = 5;
            dgv_ranking.Size = new Size(441, 473);
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
            // points
            // 
            points.HeaderText = "Punkte";
            points.Name = "points";
            points.ReadOnly = true;
            // 
            // points_aussetzer
            // 
            points_aussetzer.HeaderText = "davon Ausgesetzer";
            points_aussetzer.Name = "points_aussetzer";
            points_aussetzer.ReadOnly = true;
            // 
            // button1
            // 
            button1.Location = new Point(12, 676);
            button1.Name = "button1";
            button1.Size = new Size(113, 23);
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
            dgv_player_sehrgut.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_player_sehrgut.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1 });
            dgv_player_sehrgut.Location = new Point(254, 167);
            dgv_player_sehrgut.Name = "dgv_player_sehrgut";
            dgv_player_sehrgut.ReadOnly = true;
            dgv_player_sehrgut.RowHeadersWidth = 5;
            dgv_player_sehrgut.Size = new Size(240, 473);
            dgv_player_sehrgut.TabIndex = 4;
            dgv_player_sehrgut.CellValueChanged += dgv_player_sehrgut_CellValueChanged;
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
            AddVeryGoodPlayer.Location = new Point(419, 647);
            AddVeryGoodPlayer.Name = "AddVeryGoodPlayer";
            AddVeryGoodPlayer.Size = new Size(75, 23);
            AddVeryGoodPlayer.TabIndex = 5;
            AddVeryGoodPlayer.Text = "hinzufügen";
            AddVeryGoodPlayer.UseVisualStyleBackColor = true;
            AddVeryGoodPlayer.Click += AddVeryGoodPlayer_Click;
            // 
            // goodplayer_name
            // 
            goodplayer_name.Location = new Point(12, 646);
            goodplayer_name.Name = "goodplayer_name";
            goodplayer_name.Size = new Size(155, 23);
            goodplayer_name.TabIndex = 6;
            // 
            // AddGoodPlayer
            // 
            AddGoodPlayer.Location = new Point(173, 647);
            AddGoodPlayer.Name = "AddGoodPlayer";
            AddGoodPlayer.Size = new Size(75, 23);
            AddGoodPlayer.TabIndex = 7;
            AddGoodPlayer.Text = "hinzufügen";
            AddGoodPlayer.UseVisualStyleBackColor = true;
            AddGoodPlayer.Click += AddGoodPlayer_Click;
            // 
            // verygoodplayer_name
            // 
            verygoodplayer_name.Location = new Point(262, 647);
            verygoodplayer_name.Name = "verygoodplayer_name";
            verygoodplayer_name.Size = new Size(151, 23);
            verygoodplayer_name.TabIndex = 8;
            // 
            // button2
            // 
            button2.Location = new Point(262, 676);
            button2.Name = "button2";
            button2.Size = new Size(109, 23);
            button2.TabIndex = 9;
            button2.Text = "Randomize";
            button2.UseVisualStyleBackColor = true;
            button2.Click += RandomizeSpielerSehrGut;
            // 
            // button3
            // 
            button3.Location = new Point(500, 646);
            button3.Name = "button3";
            button3.Size = new Size(108, 23);
            button3.TabIndex = 10;
            button3.Text = "Spiel Generieren";
            button3.UseVisualStyleBackColor = true;
            button3.Click += GenerateGame;
            // 
            // Rotieren
            // 
            Rotieren.Location = new Point(131, 676);
            Rotieren.Name = "Rotieren";
            Rotieren.Size = new Size(117, 23);
            Rotieren.TabIndex = 11;
            Rotieren.Text = "Rotieren";
            Rotieren.UseVisualStyleBackColor = true;
            Rotieren.Click += PlayerGoodRotate;
            // 
            // button4
            // 
            button4.Location = new Point(377, 676);
            button4.Name = "button4";
            button4.Size = new Size(117, 23);
            button4.TabIndex = 12;
            button4.Text = "Rotieren";
            button4.UseVisualStyleBackColor = true;
            button4.Click += PlayerVeryGoodRotate;
            // 
            // current_round
            // 
            current_round.Location = new Point(614, 647);
            current_round.Name = "current_round";
            current_round.ReadOnly = true;
            current_round.Size = new Size(28, 23);
            current_round.TabIndex = 13;
            current_round.Text = "1";
            // 
            // button5
            // 
            button5.Location = new Point(1449, 647);
            button5.Name = "button5";
            button5.Size = new Size(136, 23);
            button5.TabIndex = 14;
            button5.Text = "Ranking berechnen";
            button5.UseVisualStyleBackColor = true;
            button5.Click += CalculateRanking;
            // 
            // load_cache
            // 
            load_cache.Location = new Point(114, 6);
            load_cache.Name = "load_cache";
            load_cache.Size = new Size(100, 23);
            load_cache.TabIndex = 15;
            load_cache.Text = "Load Cache";
            load_cache.UseVisualStyleBackColor = true;
            load_cache.Click += LoadCache;
            // 
            // save_cache
            // 
            save_cache.Location = new Point(8, 6);
            save_cache.Name = "save_cache";
            save_cache.Size = new Size(100, 23);
            save_cache.TabIndex = 16;
            save_cache.Text = "Save Cache";
            save_cache.UseVisualStyleBackColor = true;
            save_cache.Click += SaveCache;
            // 
            // button7
            // 
            button7.Location = new Point(220, 6);
            button7.Name = "button7";
            button7.Size = new Size(100, 23);
            button7.TabIndex = 18;
            button7.Text = "Clear Cache";
            button7.UseVisualStyleBackColor = true;
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
            button6.Location = new Point(326, 6);
            button6.Name = "button6";
            button6.Size = new Size(100, 23);
            button6.TabIndex = 25;
            button6.Text = "Clear Games";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click_1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("a Autobus Omnibus", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(140, 145);
            label3.Name = "label3";
            label3.Size = new Size(55, 12);
            label3.TabIndex = 22;
            label3.Text = "TEAMS";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("a Autobus Omnibus", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(695, 145);
            label4.Name = "label4";
            label4.Size = new Size(54, 12);
            label4.TabIndex = 23;
            label4.Text = "Spiele";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("a Autobus Omnibus", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(1256, 145);
            label5.Name = "label5";
            label5.Size = new Size(66, 12);
            label5.TabIndex = 24;
            label5.Text = "Ranking";
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1902, 757);
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
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn points;
        private DataGridViewTextBoxColumn points_aussetzer;
        private Panel panel2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button button6;
        private DataGridViewTextBoxColumn round;
        private DataGridViewTextBoxColumn t1_gut;
        private DataGridViewTextBoxColumn t1_sehrgut;
        private DataGridViewTextBoxColumn t2_gut;
        private DataGridViewTextBoxColumn t2_sehrgut;
        private DataGridViewComboBoxColumn t_win;
    }
}
