
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
            Hauptmenu hauptmenu = new Hauptmenu();
            this.Close();
            hauptmenu.Close();
            Application.Exit();
        }

        private void ButtonNein_Click(object sender, EventArgs e)
        {
            Hauptmenu hauptmenu = new Hauptmenu();
            hauptmenu.Show();
            this.Close();
        }
    }
}
