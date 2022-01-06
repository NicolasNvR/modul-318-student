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
    public partial class ProgrammBeenden : Form
    {
        public ProgrammBeenden()
        {
            InitializeComponent();
        }

        private void ButtonJa_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ButtonNein_Click(object sender, EventArgs e)
        {
            Hauptmenu hauptmenu = new Hauptmenu();
            hauptmenu.Show();
            this.Close();
            
        }
    }
}
