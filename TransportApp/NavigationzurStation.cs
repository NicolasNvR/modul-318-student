﻿using System;
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
    public partial class NavigationzurStation : Form
    {
        public NavigationzurStation()
        {
            InitializeComponent();
        }

        private void ButtonSchliessen_Click(object sender, EventArgs e)
        {;
            this.Close();
        }

        private void NavigationzurStation_FormClosed(object sender, FormClosedEventArgs e)
        {
            Hauptmenu hauptmenu = new Hauptmenu();
            hauptmenu.Show();
        }
    }
}
