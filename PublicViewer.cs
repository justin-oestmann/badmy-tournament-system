using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BadmyTournamentSystem
{
    public partial class PublicViewer : Form
    {
        public PublicViewer()
        {
            InitializeComponent();
            dgv_games.RowsDefaultCellStyle.SelectionBackColor = System.Drawing.Color.Transparent;
            dgv_ranking.RowsDefaultCellStyle.SelectionBackColor = System.Drawing.Color.Transparent;
        }

        private void PublicViewer_Load(object sender, EventArgs e)
        {

        }

        public void LoadRanking(DataGridView dataGridView)
        {

            dgv_ranking.Rows.Clear();
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                // Create a new row for the target DataGridView
                int rowIndex = dgv_ranking.Rows.Add();

                // Loop through each cell in the source row and copy the cell values to the target row
                for (int i = 0; i < row.Cells.Count; i++)
                {
                    dgv_ranking.Rows[rowIndex].Cells[i +1].Value = row.Cells[i].Value;
                }
            }
            this.dgv_ranking.Sort(this.dgv_ranking.Columns[2], ListSortDirection.Descending);

            int rank = 0;

            foreach (DataGridViewRow row in dgv_ranking.Rows)
            {
                rank++;
                row.Cells[0].Value = rank;
            }


        }
        public void LoadGames(DataGridView dataGridView)
        {
            dgv_games.Rows.Clear();
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                // Create a new row for the target DataGridView
                int rowIndex = dgv_games.Rows.Add();

                // Loop through each cell in the source row and copy the cell values to the target row
                for (int i = 0; i < row.Cells.Count; i++)
                {
                    dgv_games.Rows[rowIndex].Cells[i].Value = row.Cells[i].Value;
                }
            }
            this.dgv_games.Sort(this.dgv_games.Columns[0], ListSortDirection.Descending);
            if (rounddisplay.Text != "-")
            {
                SyncRoundDisplay();
            }
        }
        public void SetRound(int round)
        {
            rounddisplay.Text = (round - 1).ToString();
            SyncRoundDisplay();
        }
        public void SyncRoundDisplay()
        {
            foreach (DataGridViewColumn col in dgv_games.Columns)
            {
                if (col.DefaultCellStyle.BackColor != Color.Empty)
                    col.DefaultCellStyle.BackColor = Color.Empty;
            }
            foreach (DataGridViewRow row in dgv_games.Rows)
            {
                if (int.Parse(row.Cells[0].Value.ToString()) == int.Parse(rounddisplay.Text))
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        cell.Style.BackColor = Color.LightBlue;
                    }
                }
                else
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        cell.Style.BackColor = Color.Empty;
                    }
                }
            }

            foreach (DataGridViewRow row in dgv_games.Rows)
            {
                try
                {
                    if (row.Cells[5].Value.ToString() == "1")
                    {
                        row.Cells[1].Style.BackColor = Color.LightGreen;
                        row.Cells[2].Style.BackColor = Color.LightGreen;
                        row.Cells[3].Style.BackColor = Color.LightPink;
                        row.Cells[4].Style.BackColor = Color.LightPink;
                    }
                    else if (row.Cells[5].Value.ToString() == "2")
                    {
                        row.Cells[4].Style.BackColor = Color.LightGreen;
                        row.Cells[3].Style.BackColor = Color.LightGreen;
                        row.Cells[2].Style.BackColor = Color.LightPink;
                        row.Cells[1].Style.BackColor = Color.LightPink;
                    }
                }
                catch (System.NullReferenceException ex) { };
            }
        }

        private void dgv_games_SelectionChanged(object sender, EventArgs e)
        {
            this.dgv_games.ClearSelection();
        }

        private void dgv_ranking_SelectionChanged(object sender, EventArgs e)
        {
            this.dgv_ranking.ClearSelection();
        }
    }

}
