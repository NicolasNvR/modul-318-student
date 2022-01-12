using SwissTransport.Core;
using SwissTransport.Models;
namespace TransportApp
{
    public partial class NaheStationen : Form
    {
        public NaheStationen()
        {
            InitializeComponent();
        }

        private void ButtonSchliessen_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void NaheStationen_FormClosed(object sender, FormClosedEventArgs e)
        {
            Hauptmenu hauptmenu = new Hauptmenu();
            hauptmenu.Show();
        }

        private void PictureBoxHome_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }





        private void ComboBoxNaheStationen_KeyUp(object sender, KeyEventArgs e)
        {
            ComboBoxNaheStationen.Items.Clear();
            try
            {

                ITransport transport = new Transport();
                Stations stationen = transport.GetStations(ComboBoxNaheStationen.Text);
                foreach (Station stat in stationen.StationList)
                {
                    if (ComboBoxNaheStationen.Text != "" && ComboBoxNaheStationen.Text.Length >= 1)
                    {
                        ComboBoxNaheStationen.Items.Add(stat.Name);
                        if (!ComboBoxNaheStationen.Items.Contains(ComboBoxNaheStationen.Text))
                        {
                            ComboBoxNaheStationen.Items.Remove(stat.Name);
                        }

                    }
                }
                ComboBoxNaheStationen.SelectionStart = ComboBoxNaheStationen.Text.Length;
            }
            catch (Exception ex)
            {
                ComboBoxNaheStationen.SelectedText = "";
            }
        }

        private void ButtonTakeMeHome_Click(object sender, EventArgs e)
        {
            ITransport transport = new Transport();
            try
            {
                int rowIDklein = dataGridNaheStationenKlein.Rows.Add();
                dataGridNaheStationenKlein.Rows[rowIDklein].Cells[0].Value = "Ebikon, Schweizerheim";
                dataGridNaheStationenKlein.Rows[rowIDklein].Cells[1].Value = "47.07047451986242, 8.328749746030015";
                DateTime time = DateTime.Now;
                var connection = transport.GetConnections(ComboBoxNaheStationen.Text, "Ebikon, Schweizerheim", time);
                foreach (Connection conn in connection.ConnectionList)
                {
                    int i = 0;
                    int rowID = DataGridNaheStationenGross.Rows.Add();
                    DataGridNaheStationenGross.Rows[rowID].Cells[0].Value = conn.From.Platform;
                    DataGridNaheStationenGross.Rows[rowID].Cells[1].Value = conn.From.Station.Name;
                    DataGridNaheStationenGross.Rows[rowID].Cells[2].Value = conn.To.Station.Name;
                    DataGridNaheStationenGross.Rows[rowID].Cells[3].Value = conn.From.Departure;
                    DataGridNaheStationenGross.Rows[rowID].Cells[4].Value = conn.To.Arrival;
                    DataGridNaheStationenGross.Rows[rowID].Cells[5].Value = conn.Duration;
                    DataGridNaheStationenGross.Rows[rowID].Cells[6].Value = conn.To.Delay;
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
        private void ButtonSucheNachStation_Click(object sender, EventArgs e)
        {
            ITransport transport = new Transport();
            Stations station = transport.GetStations(ComboBoxNaheStationen.Text);
            foreach (Station stat in station.StationList)
            {
                var board = transport.GetStationBoard(stat.Name);
                foreach (StationBoard Statboard in board.Entries)
                {
                    try
                    {
                        int rowIDklein = dataGridNaheStationenKlein.Rows.Add();
                        dataGridNaheStationenKlein.Rows[rowIDklein].Cells[0].Value = ComboBoxNaheStationen.Text;
                        dataGridNaheStationenKlein.Rows[rowIDklein].Cells[1].Value = "unknown";

                        DateTime time = DateTime.Now;
                        var connection = transport.GetConnections(ComboBoxNaheStationen.Text, Statboard.To, time);
                        foreach (Connection conn in connection.ConnectionList)
                        {
                            int i = 0;
                            int rowID = DataGridNaheStationenGross.Rows.Add();
                            DataGridNaheStationenGross.Rows[rowID].Cells[0].Value = conn.From.Platform;
                            DataGridNaheStationenGross.Rows[rowID].Cells[1].Value = conn.From.Station.Name;
                            DataGridNaheStationenGross.Rows[rowID].Cells[2].Value = conn.To.Station.Name;
                            DataGridNaheStationenGross.Rows[rowID].Cells[3].Value = conn.From.Departure;
                            DataGridNaheStationenGross.Rows[rowID].Cells[4].Value = conn.To.Arrival;
                            DataGridNaheStationenGross.Rows[rowID].Cells[5].Value = conn.Duration;
                            DataGridNaheStationenGross.Rows[rowID].Cells[6].Value = conn.To.Delay;
                            i += 1;
                            if (i >= 6)
                            {
                                break;
                            }
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Es ist ein Fehler aufgetreten");
                    }
                }

            }
        }
    }
}
