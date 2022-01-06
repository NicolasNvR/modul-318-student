using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TransportApp
{
    public partial class Hauptmenu : Form
    {
        public Hauptmenu()
        {
            InitializeComponent();
        }

        private void ButtonVerbindungenSuchen_Click(object sender, EventArgs e)
        {
            VerbindungenSuchen verbindungenSuchen = new VerbindungenSuchen();
            verbindungenSuchen.Show();
            this.Hide();
        }

        private void ButtonNavigationzurStation_Click(object sender, EventArgs e)
        {
            NavigationzurStation navigationzurStation = new NavigationzurStation();
            navigationzurStation.Show();
            this.Hide();
        }

        private void ButtonAbfhartstafel_Click(object sender, EventArgs e)
        {
            Abfhartstafel abfhartstafel = new Abfhartstafel();
            abfhartstafel.Show();
            this.Hide();
        }

        private void ButtonStadtioneninderNähe_Click(object sender, EventArgs e)
        {
            NaheStationen naheStationen = new NaheStationen();
            naheStationen.Show();
            this.Hide();
        }

        private void ButtonAbbrechen_Click(object sender, EventArgs e)
        {
            ProgrammBeenden programmBeenden = new ProgrammBeenden();
            programmBeenden.Show();
            this.Hide();
        }

        private void Hauptmenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            ProgrammBeenden programmBeenden = new ProgrammBeenden();
            programmBeenden.Show();
            this.Hide();
        }
    }
}
