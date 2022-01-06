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
    public partial class Abfhartstafel : Form
    {
        public Abfhartstafel()
        {
            InitializeComponent();
        }

        private void Abfhartstafel_Leave(object sender, EventArgs e)
        {
            Hauptmenu hauptmenu = new Hauptmenu();
            hauptmenu.Show();
        }
    }
}
