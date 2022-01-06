using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SwissTransportApp
{
    public partial class Hauptmenu : Form
    {
        public Hauptmenu()
        {
            InitializeComponent();
            ITransport transport = new Transport();
        }

        private void ButtonVerbindungSuchen_Click(object sender, EventArgs e)
        {
            VerbindungenSuchen verbindungenSuchen = new VerbindungenSuchen();
            verbindungenSuchen.Show();
        }

        private void ButtonAbfhartstafel_Click(object sender, EventArgs e)
        {
            Abfhartstafel abfhartstafel = new Abfhartstafel();
            abfhartstafel.Show();
        }

        private void ButtonStationinderNähe_Click(object sender, EventArgs e)
        {
            NaheStationen naheStationen = new NaheStationen();
            naheStationen.Show();
        }

        private void ButtonStationNavigation_Click(object sender, EventArgs e)
        {
            NavigationzurStation navigationzurStation = new NavigationzurStation();
            navigationzurStation.Show();
            this.Hide();
        }

        
    }
}
