using SwissTransport.Core;
using SwissTransport.Models;
namespace TransportApp
{
    public partial class Abfhartstafel : Form
    {
        public Abfhartstafel()
        {
            InitializeComponent();
        }

        private void ButtonSchliessen_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Abfhartstafel_FormClosed(object sender, FormClosedEventArgs e)
        {
            Hauptmenu hauptmenu = new Hauptmenu();
            hauptmenu.Show();
        }

        private void PictureBoxHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ButtonSuchen_Click(object sender, EventArgs e)
        {
            ITransport transport = new Transport();
            Stations station = transport.GetStations(ComboBoxAbfhartstafel.Text);
            foreach (Station stat in station.StationList)
            {
                var board = transport.GetStationBoard(stat.Name);
                foreach (StationBoard Statboard in board.Entries)
                {
                    try
                    {
                        DateTime time = DateTime.Now;
                        var connection = transport.GetConnections(ComboBoxAbfhartstafel.Text, Statboard.To, time);
                        foreach (Connection conn in connection.ConnectionList)
                        {
                            int i = 0;
                            int rowID = DataGridAbfhartstafel.Rows.Add();
                            DataGridAbfhartstafel.Rows[rowID].Cells[0].Value = conn.From.Platform;
                            DataGridAbfhartstafel.Rows[rowID].Cells[1].Value = conn.From.Station.Name;
                            DataGridAbfhartstafel.Rows[rowID].Cells[2].Value = conn.To.Station.Name;
                            DataGridAbfhartstafel.Rows[rowID].Cells[3].Value = conn.From.Departure;
                            DataGridAbfhartstafel.Rows[rowID].Cells[4].Value = conn.To.Arrival;
                            DataGridAbfhartstafel.Rows[rowID].Cells[5].Value = conn.Duration;
                            DataGridAbfhartstafel.Rows[rowID].Cells[6].Value = conn.To.Delay;
                            if (i >= 6)
                            {
                                break;
                            }
                            i++;
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Es ist ein Fehler aufgetreten");
                    }
                }
            }
        }

        private void ComboBoxAbfhartstafel_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBoxAbfhartstafel.Items.Clear();
            try
            {

                ITransport transport = new Transport();
                Stations stationen = transport.GetStations(ComboBoxAbfhartstafel.Text);
                foreach (Station stat in stationen.StationList)
                {
                    if (ComboBoxAbfhartstafel.Text != "" && ComboBoxAbfhartstafel.Text.Length >= 1)
                    {
                        ComboBoxAbfhartstafel.Items.Add(stat.Name);
                        if (!ComboBoxAbfhartstafel.Items.Contains(ComboBoxAbfhartstafel.Text))
                        {
                            ComboBoxAbfhartstafel.Items.Remove(stat.Name);
                        }

                    }
                }
                ComboBoxAbfhartstafel.SelectionStart = ComboBoxAbfhartstafel.Text.Length;
            }
            catch (Exception ex)
            {
                ComboBoxAbfhartstafel.SelectedText = "";
            }
        }
    }
}
