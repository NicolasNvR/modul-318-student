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
    public partial class NavigationzurStation : Form
    {
        public NavigationzurStation()
        {
            InitializeComponent();
        }


        private void ButtonSchlissen_Click(object sender, EventArgs e)
        {
            Hauptmenu hauptmenu = new Hauptmenu();
            hauptmenu.Show();
            this.Close();
        }
    }
}
