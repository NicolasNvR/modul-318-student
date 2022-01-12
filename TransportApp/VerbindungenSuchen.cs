using SwissTransport.Core;
using SwissTransport.Models;
using System.Diagnostics;

namespace TransportApp
{
    public partial class VerbindungenSuchen : Form
    {
        public VerbindungenSuchen()
        {
            InitializeComponent();
        }

        private void ButtonWiderholen_Click(object sender, EventArgs e)
        {
            string VorgängerText = "";
            string NachherText = "";
            if (ComboBoxAbfahrtstation.Text != null && ComboBoxEndstation.Text != null)
            {
                VorgängerText = ComboBoxAbfahrtstation.Text.ToString();
                NachherText = ComboBoxEndstation.Text.ToString();
            }
            ComboBoxAbfahrtstation.Text = NachherText;
            ComboBoxEndstation.Text = VorgängerText;
        }

        private void PictureBoxHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void VerbindungenSuchen_FormClosed(object sender, FormClosedEventArgs e)
        {
            Hauptmenu hauptmenu = new Hauptmenu();
            hauptmenu.Show();
        }
        private void ButtonVerbindungenSuchen_Click(object sender, EventArgs e)
        {
            if (ComboBoxAbfahrtstation.Text != null && ComboBoxEndstation.Text != null)
            {
                DataGridVerbindungenSuchen.Rows.Clear();
                try
                {
                    
                    DateTime Time = DateTimer.Value;
                    ITransport transport = new Transport();
                    var connection = transport.GetConnections(ComboBoxAbfahrtstation.Text, ComboBoxEndstation.Text, Time);
                    foreach (Connection conn in connection.ConnectionList)
                    {
                            int rowID = DataGridVerbindungenSuchen.Rows.Add();
                            DataGridVerbindungenSuchen.Rows[rowID].Cells[0].Value = conn.From.Platform;
                            DataGridVerbindungenSuchen.Rows[rowID].Cells[1].Value = conn.From.Station.Name;
                            DataGridVerbindungenSuchen.Rows[rowID].Cells[2].Value = conn.To.Station.Name;
                            DataGridVerbindungenSuchen.Rows[rowID].Cells[3].Value = conn.From.Departure;
                            DataGridVerbindungenSuchen.Rows[rowID].Cells[4].Value = conn.To.Arrival;
                            DataGridVerbindungenSuchen.Rows[rowID].Cells[5].Value = conn.Duration;
                            DataGridVerbindungenSuchen.Rows[rowID].Cells[6].Value = conn.To.Delay;
                    }
                }
                catch (Exception ex)
                {
                    Debug.WriteLine("During processing the following exception happened: \n" + ex.ToString());
                    MessageBox.Show("During processing the following exception happened: \n\n" + ex.ToString());
                }
            }
        }

        private void ComboBoxEndstation_KeyUp_1(object sender, KeyEventArgs e)
        {
            ComboBoxEndstation.Items.Clear();
            try
            {

                ITransport transport = new Transport();
                Stations stationen = transport.GetStations(ComboBoxEndstation.Text);
                foreach (Station stat in stationen.StationList)
                {
                    if (ComboBoxEndstation.Text != "" && ComboBoxEndstation.Text.Length >= 1)
                    {
                        ComboBoxEndstation.Items.Add(stat.Name);
                        if (!ComboBoxEndstation.Items.Contains(ComboBoxEndstation.Text))
                        {
                            ComboBoxEndstation.Items.Remove(stat.Name);
                        }

                    }
                }
                ComboBoxEndstation.SelectionStart = ComboBoxEndstation.Text.Length;
            }
            catch (Exception ex)
            {
                ComboBoxEndstation.SelectedText = "";
            }
        }

        private void ComboBoxAbfahrtstation_KeyUp(object sender, KeyEventArgs e)
        {
            ComboBoxAbfahrtstation.Items.Clear();
            try
            {
                ITransport transport = new Transport();
                Stations stationen = transport.GetStations(ComboBoxAbfahrtstation.Text);
                foreach (Station stat in stationen.StationList)
                {
                    if (ComboBoxAbfahrtstation.Text != "" && ComboBoxAbfahrtstation.Text.Length >= 1)
                    {
                        ComboBoxAbfahrtstation.Items.Add(stat.Name);
                        if (!ComboBoxAbfahrtstation.Items.Contains(ComboBoxAbfahrtstation.Text))
                        {
                            ComboBoxAbfahrtstation.Items.Remove(stat.Name);
                        }

                    }

                }
                ComboBoxAbfahrtstation.SelectionStart = ComboBoxAbfahrtstation.Text.Length;
            }
            catch (Exception ex)
            {
                ComboBoxAbfahrtstation.SelectedText = "";
            }
        }

        private void PictureBoxMailButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Funktion noch nicht vorhanden");
        }
    }
}

