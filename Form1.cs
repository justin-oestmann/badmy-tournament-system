using System;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Windows.Forms;
using System.Data;
using System.IO;

namespace BadmyTournamentSystem
{
    public partial class Main : Form
    {
        PublicViewer publicViewer = new PublicViewer();


        public Main()
        {
            InitializeComponent();
            //AutoLoad();
            publicViewer.Show();
        }

        public void AutoSave()
        {
            SaveToCsv(dgv_player_gut, "cache/player_gut.csv");
            SaveToCsv(dgv_player_sehrgut, "cache/player_sehrgut.csv");
            SaveToCsv(dgv_games, "cache/games.csv");
            SaveToCsv(dgv_ranking, "cache/ranking.csv");
        }
        public void AutoLoad()
        {
            LoadFromCsv(dgv_player_gut, "cache/player_gut.csv");
            LoadFromCsv(dgv_player_sehrgut, "cache/player_sehrgut.csv");
            LoadFromCsv(dgv_games, "cache/games.csv");
            LoadFromCsv(dgv_ranking, "cache/ranking.csv");

            for (int i = 0; dgv_games.Rows.Count > i; i++)
            {
                if (Int32.Parse(current_round.Text) <= Int32.Parse((string)dgv_games.Rows[i].Cells[0].Value))
                {
                    current_round.Text = (Int32.Parse((string)dgv_games.Rows[i].Cells[0].Value) + 1).ToString();
                }
            }
        }


        private void RandomizeSpielerGut(object sender, EventArgs e)
        {
            if (dgv_player_gut.Rows.Count > 1)
            {
                RandomizeRows(dgv_player_gut);
            }
            else
            {
                MessageBox.Show("Es sind nicht genug Spieler in der Liste!");
            }
        }

        private void RandomizeRows(DataGridView dataGridView)
        {
            Random random = new Random();

            List<DataGridViewRow> rows = new List<DataGridViewRow>();

            // Kopiere die Zeilen der DataGridView in die Liste
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                rows.Add(row);
            }

            // Zufällige Reihenfolge der Zeilen in der Liste
            rows.Sort((a, b) => random.Next(-1, 2));

            // Leere die DataGridView
            dataGridView.Rows.Clear();

            // Füge die Zeilen in zufälliger Reihenfolge wieder hinzu
            foreach (DataGridViewRow row in rows)
            {
                dataGridView.Rows.Add(row.Cells[0].Value);
            }
        }

        private void RotateDataGridView(DataGridView dataGridView)
        {
            // Speichere die Anzahl der Zeilen in der DataGridView
            int rowCount = dataGridView.Rows.Count;

            if (rowCount < 2)
            {
                // Wenn weniger als zwei Zeilen vorhanden sind, ist keine Rotation erforderlich
                return;
            }

            // Speichere die Werte der ersten Zeile
            List<object> firstRowValues = new List<object>();
            foreach (DataGridViewCell cell in dataGridView.Rows[0].Cells)
            {
                firstRowValues.Add(cell.Value);
            }

            // Verschiebe die Werte aller Zeilen um eine Position nach oben (zyklisch)
            for (int i = 0; i < rowCount - 1; i++)
            {
                for (int j = 0; j < dataGridView.Columns.Count; j++)
                {
                    dataGridView.Rows[i].Cells[j].Value = dataGridView.Rows[i + 1].Cells[j].Value;
                }
            }

            // Setze die gespeicherten Werte der ersten Zeile in die letzte Zeile
            for (int j = 0; j < dataGridView.Columns.Count; j++)
            {
                dataGridView.Rows[rowCount - 1].Cells[j].Value = firstRowValues[j];
            }

            AutoSave();
        }

        private void AddGoodPlayer_Click(object sender, EventArgs e)
        {

            if (goodplayer_name.Text.Length <= 2)
            {
                MessageBox.Show("Spieler-Name ist zu kurz!");
                return;
            }


            foreach (DataGridViewRow row in dgv_player_gut.Rows)
            {
                if (row.Cells[0].Value.ToString() == goodplayer_name.Text.ToLower())
                {
                    MessageBox.Show("Spieler-Name existiert bereits in Gruppe Gut!");
                    return;
                }
            }
            foreach (DataGridViewRow row in dgv_player_sehrgut.Rows)
            {
                if (row.Cells[0].Value.ToString() == goodplayer_name.Text.ToLower())
                {
                    MessageBox.Show("Spieler-Name existiert bereits in Gruppe Sehr Gut!");
                    return;
                }
            }


            dgv_player_gut.Rows.Add(goodplayer_name.Text);
            goodplayer_name.Clear();
            AutoSave();

            CalculateRanking(null, null);
            MirrorRanking();
        }

        private void AddVeryGoodPlayer_Click(object sender, EventArgs e)
        {
            if (verygoodplayer_name.Text.Length <= 2)
            {
                MessageBox.Show("Spieler-Name ist zu kurz!");
                return;
            }


            foreach (DataGridViewRow row in dgv_player_gut.Rows)
            {
                if (row.Cells[0].Value.ToString() == verygoodplayer_name.Text.ToLower())
                {
                    MessageBox.Show("Spieler-Name existiert bereits in Gruppe Gut!");
                    return;
                }
            }
            foreach (DataGridViewRow row in dgv_player_sehrgut.Rows)
            {
                if (row.Cells[0].Value.ToString() == verygoodplayer_name.Text.ToLower())
                {
                    MessageBox.Show("Spieler-Name existiert bereits in Gruppe Sehr Gut!");
                    return;
                }
            }


            dgv_player_sehrgut.Rows.Add(verygoodplayer_name.Text);
            verygoodplayer_name.Clear();
            AutoSave();
            CalculateRanking(null, null);
            MirrorRanking();
        }

        private void RandomizeSpielerSehrGut(object sender, EventArgs e)
        {
            if (dgv_player_sehrgut.Rows.Count > 1)
            {
                RandomizeRows(dgv_player_sehrgut);
            }
            else
            {
                MessageBox.Show("Es sind nicht genug Spieler in der Liste!");
            }
        }

        private void GenerateGame(object sender, EventArgs e)
        {

            if (dgv_player_gut.Rows.Count < 2 || dgv_player_sehrgut.Rows.Count < 2)
            {
                MessageBox.Show("Es sind nicht genug Spieler verfügbar (Mindestens 2 Gute und 2 Sehr gute Spieler)");
                return;
            }




            if (dgv_player_gut.Rows.Count > dgv_player_sehrgut.Rows.Count)
            {

                for (int i = 0; dgv_player_sehrgut.Rows.Count % 4 > i; i++)
                {
                    RotateDataGridView(dgv_player_gut);
                }

                for (int i = 0; dgv_player_sehrgut.Rows.Count % 4 > i - 1; i++)
                {
                    RotateDataGridView(dgv_player_sehrgut);
                }

            }
            if (dgv_player_gut.Rows.Count < dgv_player_sehrgut.Rows.Count)
            {

                for (int i = 0; dgv_player_gut.Rows.Count % 4 > i - 1; i++)
                {
                    RotateDataGridView(dgv_player_gut);
                }

                for (int i = 0; dgv_player_gut.Rows.Count % 4 > i; i++)
                {
                    RotateDataGridView(dgv_player_sehrgut);
                }

            }
            if (dgv_player_gut.Rows.Count == dgv_player_sehrgut.Rows.Count)
            {

                RotateDataGridView(dgv_player_gut);
                if (dgv_player_gut.Rows.Count % 2 == 1)
                {
                    RotateDataGridView(dgv_player_gut);
                    RotateDataGridView(dgv_player_sehrgut);
                }

            }



            List<String> teams = new List<String>();

            int maxteams = dgv_player_gut.Rows.Count;

            if (maxteams > dgv_player_sehrgut.Rows.Count)
            {
                maxteams = dgv_player_sehrgut.Rows.Count;
            }

            if (maxteams % 2 != 0)
            {

                maxteams -= 1;
            }

            //if (current_round.Text != "1" && (maxteams) % (Int32.Parse(current_round.Text) - 1) == 0)
            //{
            //    MessageBox.Show("Maximale Runden für diese Sotierung gespielt. Nun werden beide Listen zufällig gewürfelt und neue Spiele werden generiert!");
            //    RandomizeRows(dgv_player_gut);
            //    RandomizeRows(dgv_player_sehrgut);
            //}


            //

            List<int> teams_ids = new List<int>();
            for (int j = 0; j < maxteams; j++)
            {
                teams_ids.Add(j);
            }

            Shuffle(teams_ids);

            int teams_count = teams_ids.Count;

            for (int j = 0; j < teams_count / 2; j++)
            {
                String t1g = dgv_player_gut.Rows[teams_ids[0]].Cells[0].Value.ToString();
                String t1vg = dgv_player_sehrgut.Rows[teams_ids[0]].Cells[0].Value.ToString();
                String t2g = dgv_player_gut.Rows[teams_ids[1]].Cells[0].Value.ToString();
                String t2vg = dgv_player_sehrgut.Rows[teams_ids[1]].Cells[0].Value.ToString();


                dgv_games.Rows.Add(current_round.Text, t1g, t1vg, t2g, t2vg);
                teams_ids.Remove(teams_ids[0]);
                teams_ids.Remove(teams_ids[0]);
            }




            MessageBox.Show("Spiele Generiert!");

            current_round.Text = (Int32.Parse(current_round.Text) + 1).ToString();

            AutoSave();
            CalculateRanking(null, null);
            MirrorGames();
            publicViewer.SetRound(int.Parse(current_round.Text));
        }

        public static void Shuffle(List<int> list)
        {
            Random rng = new Random();
            int n = list.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                int value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }
        private void PlayerGoodRotate(object sender, EventArgs e)
        {
            if (dgv_player_gut.Rows.Count > 1)
            {
                RotateDataGridView(dgv_player_gut);

            }
            else
            {
                MessageBox.Show("Es sind nicht genug Spieler in der Liste!");
            }
            AutoSave();
        }
        private void PlayerVeryGoodRotate(object sender, EventArgs e)
        {
            if (dgv_player_gut.Rows.Count > 1)
            {
                RotateDataGridView(dgv_player_sehrgut);
            }
            else
            {
                MessageBox.Show("Es sind nicht genug Spieler in der Liste!");
            }
            AutoSave();
        }
        public void CalculateRanking(object sender, EventArgs e)
        {
            dgv_ranking.Rows.Clear();

            foreach (DataGridViewRow dr in dgv_player_gut.Rows)
            {
                dgv_ranking.Rows.Add(dr.Cells[0].Value, 0, 0);
            }
            foreach (DataGridViewRow dr in dgv_player_sehrgut.Rows)
            {
                dgv_ranking.Rows.Add(dr.Cells[0].Value, 0, 0);
            }


            if (dgv_games.Rows.Count > 0)
            {
                for (int i = 0; dgv_games.Rows.Count > i; i++)
                {
                    if ((string)dgv_games.Rows[i].Cells["t_win"].Value == "1")
                    {
                        DataGridViewRow dgvr = FindRowByValue(dgv_ranking, "name", dgv_games.Rows[i].Cells[1].Value.ToString());
                        dgvr.Cells[1].Value = (int)dgvr.Cells[1].Value + 1;
                        DataGridViewRow dgvr2 = FindRowByValue(dgv_ranking, "name", dgv_games.Rows[i].Cells[2].Value.ToString());
                        dgvr2.Cells[1].Value = (int)dgvr2.Cells[1].Value + 1;
                    }
                    if ((string)dgv_games.Rows[i].Cells["t_win"].Value == "2")
                    {
                        DataGridViewRow dgvr = FindRowByValue(dgv_ranking, "name", dgv_games.Rows[i].Cells[3].Value.ToString());
                        dgvr.Cells[1].Value = (int)dgvr.Cells[1].Value + 1;
                        DataGridViewRow dgvr2 = FindRowByValue(dgv_ranking, "name", dgv_games.Rows[i].Cells[4].Value.ToString());
                        dgvr2.Cells[1].Value = (int)dgvr2.Cells[1].Value + 1;
                    }
                }
            }



            int max_rounds = 0;

            for (int i = 0; dgv_games.Rows.Count > i; i++)
            {
                if (max_rounds < Int32.Parse((string)dgv_games.Rows[i].Cells[0].Value))
                {
                    max_rounds = Int32.Parse((string)dgv_games.Rows[i].Cells[0].Value);
                }
            }

            for (int round = 1; round <= max_rounds; round++)
            {
                List<String> users = ExtractColumnToStringList(dgv_ranking, 0);

                for (int i = 0; i < dgv_games.Rows.Count; i++)
                {
                    if (dgv_games.Rows[i].Cells[0].Value.ToString() == round.ToString())
                    {
                        if (users.Contains(dgv_games.Rows[i].Cells[1].Value.ToString()))
                        {
                            users.Remove(dgv_games.Rows[i].Cells[1].Value.ToString());
                        }
                        if (users.Contains(dgv_games.Rows[i].Cells[2].Value.ToString()))
                        {
                            users.Remove(dgv_games.Rows[i].Cells[2].Value.ToString());
                        }
                        if (users.Contains(dgv_games.Rows[i].Cells[3].Value.ToString()))
                        {
                            users.Remove(dgv_games.Rows[i].Cells[3].Value.ToString());
                        }
                        if (users.Contains(dgv_games.Rows[i].Cells[4].Value.ToString()))
                        {
                            users.Remove(dgv_games.Rows[i].Cells[4].Value.ToString());
                        }

                    }
                }

                if (users.Count > 0)
                {
                    foreach (var user in users)
                    {
                        for (int i = 0; i < dgv_ranking.Rows.Count; i++)
                        {
                            if (dgv_ranking.Rows[i].Cells[0].Value.ToString() == user.ToString())
                            {




                                int temp = int.Parse(dgv_ranking.Rows[i].Cells[1].Value.ToString());
                                int temp2 = int.Parse(dgv_ranking.Rows[i].Cells[2].Value.ToString());

                                dgv_ranking.Rows[i].Cells[1].Value = temp + 1;
                                dgv_ranking.Rows[i].Cells[2].Value = temp2 + 1;
                            }
                        }
                    }
                }
            }



            AutoSave();
            MirrorRanking();
            dgv_ranking.Update();
            dgv_ranking.Refresh();
        }
        private DataGridViewRow FindRowByValue(DataGridView dataGridView, string columnName, string searchValue)
        {
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                if (row.Cells[columnName].Value != null && row.Cells[columnName].Value.ToString() == searchValue)
                {
                    // Wert in der gewünschten Zelle gefunden
                    return row;
                }
            }

            // Wert nicht gefunden
            return null;
        }
        public static void LoadFromCsv(DataGridView dataGridView, string filePath)
        {
            try
            {
                if (!File.Exists(filePath))
                {
                    //MessageBox.Show("Die angegebene CSV-Datei existiert nicht.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Lese die CSV-Daten
                string[] lines = File.ReadAllLines(filePath);

                // Lösche vorhandene Daten in der DataGridView
                dataGridView.Rows.Clear();

                // Füge Daten aus der CSV-Datei in die DataGridView ein
                foreach (string line in lines)
                {
                    string[] values = line.Split(',');

                    // Füge die Zellenwerte als neue Zeile in die DataGridView ein
                    dataGridView.Rows.Add(values);
                }

                //MessageBox.Show("Die Daten wurden erfolgreich aus der CSV-Datei geladen.", "Erfolg", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                //MessageBox.Show($"Fehler beim Laden der CSV-Datei: {ex.Message}", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public static void SaveToCsv(DataGridView dataGridView, string filePath)
        {
            try
            {
                if (dataGridView == null || dataGridView.Rows.Count == 0)
                {
                    //MessageBox.Show("Die DataGridView ist leer.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Erzeuge das Verzeichnis, falls es nicht existiert
                string directoryPath = Path.GetDirectoryName(filePath);
                if (!Directory.Exists(directoryPath))
                {
                    Directory.CreateDirectory(directoryPath);
                }

                // Erzeuge die CSV-Daten ohne Spaltenüberschriften
                StringBuilder csvData = new StringBuilder();

                // Zeilenwerte
                foreach (DataGridViewRow row in dataGridView.Rows)
                {
                    for (int i = 0; i < dataGridView.Columns.Count; i++)
                    {
                        if (i > 0)
                            csvData.Append(",");
                        csvData.Append(row.Cells[i].Value);
                    }
                    csvData.AppendLine();
                }

                // Speichere die CSV-Daten in die Datei
                File.WriteAllText(filePath, csvData.ToString());

                //MessageBox.Show("Die Daten wurden erfolgreich in die CSV-Datei gespeichert.", "Erfolg", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                //MessageBox.Show($"Fehler beim Speichern der CSV-Datei: {ex.Message}", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadCache(object sender, EventArgs e)
        {
            AutoLoad();
            MirrorGames();
            MirrorRanking();
            publicViewer.SetRound(int.Parse(current_round.Text));
        }

        private void SaveCache(object sender, EventArgs e)
        {
            AutoSave();
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }
        private List<string> ExtractColumnToStringList(DataGridView dataGridView, int columnIndex)
        {
            List<string> dataList = new List<string>();

            // Loop through each row in the DataGridView
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                // Check if the cell value is not null and the cell index is within bounds
                if (row.Cells[columnIndex].Value != null)
                {
                    // Add the cell value to the dataList as a string
                    dataList.Add(row.Cells[columnIndex].Value.ToString());
                }
            }

            return dataList;
        }

        private void ClearCache(object sender, EventArgs e)
        {
            File.Delete("cache/player_gut.csv");
            File.Delete("cache/player_sehrgut.csv");
            File.Delete("cache/games.csv");
            File.Delete("cache/ranking.csv");

        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void dgv_games_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            CalculateRanking(null, null);
            MirrorGames();
            MirrorRanking();
        }

        private void dgv_games_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            CalculateRanking(null, null);
            MirrorGames();
            MirrorRanking();
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            File.Delete("cache/games.csv");
            File.Delete("cache/ranking.csv");
            dgv_games.Rows.Clear();
            dgv_ranking.Rows.Clear();
            CalculateRanking(null, null);
            MirrorRanking();
            MirrorGames();
            current_round.Text = "1";
            publicViewer.SetRound(int.Parse(current_round.Text));
        }

        public void MirrorRanking()
        {
            publicViewer.LoadRanking(dgv_ranking);
        }
        public void MirrorGames()
        {
            publicViewer.LoadGames(dgv_games);
        }

        private void dgv_ranking_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            this.dgv_ranking.ClearSelection();
        }

        private void dgv_player_gut_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            this.dgv_player_gut.ClearSelection();
        }

        private void dgv_player_sehrgut_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            this.dgv_player_sehrgut.ClearSelection();
        }
    }

}
