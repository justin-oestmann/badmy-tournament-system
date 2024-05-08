namespace BadmyTournamentSystem
{
    partial class PublicViewer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PublicViewer));
            panel1 = new Panel();
            rounddisplay = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label5 = new Label();
            label4 = new Label();
            dgv_ranking = new DataGridView();
            dgv_games = new DataGridView();
            round = new DataGridViewTextBoxColumn();
            t1_gut = new DataGridViewTextBoxColumn();
            t1_sehrgut = new DataGridViewTextBoxColumn();
            t2_gut = new DataGridViewTextBoxColumn();
            t2_sehrgut = new DataGridViewTextBoxColumn();
            t_win = new DataGridViewComboBoxColumn();
            platz = new DataGridViewTextBoxColumn();
            name = new DataGridViewTextBoxColumn();
            points = new DataGridViewTextBoxColumn();
            points_aussetzer = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_ranking).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgv_games).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.AutoSize = true;
            panel1.BackColor = Color.FromArgb(40, 53, 131);
            panel1.Controls.Add(rounddisplay);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.MinimumSize = new Size(0, 100);
            panel1.Name = "panel1";
            panel1.Size = new Size(1904, 100);
            panel1.TabIndex = 21;
            // 
            // rounddisplay
            // 
            rounddisplay.AutoSize = true;
            rounddisplay.Font = new Font("a Autobus Omnibus", 47.9999924F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rounddisplay.ForeColor = SystemColors.ButtonFace;
            rounddisplay.Location = new Point(958, 19);
            rounddisplay.Name = "rounddisplay";
            rounddisplay.Size = new Size(66, 64);
            rounddisplay.TabIndex = 30;
            rounddisplay.Text = "-";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("a Autobus Omnibus", 47.9999924F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(671, 19);
            label3.Name = "label3";
            label3.Size = new Size(299, 64);
            label3.TabIndex = 29;
            label3.Text = "Runde ";
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
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("a Autobus Omnibus", 47.9999924F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(1402, 124);
            label5.Name = "label5";
            label5.Size = new Size(351, 64);
            label5.TabIndex = 28;
            label5.Text = "Ranking";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("a Autobus Omnibus", 47.9999924F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(0, 124);
            label4.Name = "label4";
            label4.Size = new Size(293, 64);
            label4.TabIndex = 27;
            label4.Text = "Spiele";
            // 
            // dgv_ranking
            // 
            dgv_ranking.AllowUserToAddRows = false;
            dgv_ranking.AllowUserToDeleteRows = false;
            dgv_ranking.AllowUserToOrderColumns = true;
            dgv_ranking.AllowUserToResizeColumns = false;
            dgv_ranking.AllowUserToResizeRows = false;
            dgv_ranking.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_ranking.Columns.AddRange(new DataGridViewColumn[] { platz, name, points, points_aussetzer });
            dgv_ranking.Location = new Point(1415, 196);
            dgv_ranking.Name = "dgv_ranking";
            dgv_ranking.ReadOnly = true;
            dgv_ranking.RowHeadersWidth = 5;
            dgv_ranking.Size = new Size(477, 653);
            dgv_ranking.TabIndex = 26;
            dgv_ranking.SelectionChanged += dgv_ranking_SelectionChanged;
            // 
            // dgv_games
            // 
            dgv_games.AllowUserToAddRows = false;
            dgv_games.AllowUserToDeleteRows = false;
            dgv_games.AllowUserToResizeRows = false;
            dgv_games.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_games.Columns.AddRange(new DataGridViewColumn[] { round, t1_gut, t1_sehrgut, t2_gut, t2_sehrgut, t_win });
            dgv_games.Location = new Point(12, 196);
            dgv_games.Name = "dgv_games";
            dgv_games.ReadOnly = true;
            dgv_games.RowHeadersWidth = 5;
            dgv_games.Size = new Size(1366, 653);
            dgv_games.TabIndex = 25;
            dgv_games.SelectionChanged += dgv_games_SelectionChanged;
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
            t1_gut.HeaderText = "Team 1 Spieler 1";
            t1_gut.Name = "t1_gut";
            t1_gut.ReadOnly = true;
            // 
            // t1_sehrgut
            // 
            t1_sehrgut.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            t1_sehrgut.HeaderText = "Team 1 Spieler 2";
            t1_sehrgut.Name = "t1_sehrgut";
            t1_sehrgut.ReadOnly = true;
            // 
            // t2_gut
            // 
            t2_gut.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            t2_gut.HeaderText = "Team 2 Spieler 1";
            t2_gut.Name = "t2_gut";
            t2_gut.ReadOnly = true;
            // 
            // t2_sehrgut
            // 
            t2_sehrgut.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            t2_sehrgut.HeaderText = "Team 2 Spieler 2";
            t2_sehrgut.Name = "t2_sehrgut";
            t2_sehrgut.ReadOnly = true;
            // 
            // t_win
            // 
            t_win.DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing;
            t_win.HeaderText = "Gewinnerteam";
            t_win.Items.AddRange(new object[] { "1", "2" });
            t_win.Name = "t_win";
            t_win.ReadOnly = true;
            t_win.Visible = false;
            // 
            // platz
            // 
            platz.HeaderText = "Platz";
            platz.Name = "platz";
            platz.ReadOnly = true;
            platz.Width = 50;
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
            // PublicViewer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1904, 861);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(dgv_ranking);
            Controls.Add(dgv_games);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "PublicViewer";
            Text = "Overview | Badmy | Tournament System";
            Load += PublicViewer_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_ranking).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgv_games).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Label label1;
        private Label label5;
        private Label label4;
        private DataGridView dgv_ranking;
        private DataGridView dgv_games;
        private Label rounddisplay;
        private Label label3;
        private DataGridViewTextBoxColumn round;
        private DataGridViewTextBoxColumn t1_gut;
        private DataGridViewTextBoxColumn t1_sehrgut;
        private DataGridViewTextBoxColumn t2_gut;
        private DataGridViewTextBoxColumn t2_sehrgut;
        private DataGridViewComboBoxColumn t_win;
        private DataGridViewTextBoxColumn platz;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn points;
        private DataGridViewTextBoxColumn points_aussetzer;
    }
}