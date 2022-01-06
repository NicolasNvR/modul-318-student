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
    public partial class VerbindungenSuchen : Form
    {
        public VerbindungenSuchen()
        {
            InitializeComponent();
        }

        private void ButtonSchliessen_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void VerbindungenSuchen_FormClosed(object sender, FormClosedEventArgs e)
        {
            Hauptmenu hauptmenu = new Hauptmenu();
            hauptmenu.Show();
        }

        private void ButtonWiderholen_Click(object sender, EventArgs e)
        {

        }
    }
}
