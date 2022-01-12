
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
            MessageBox.Show("Dieses Feature wurde noch nicht implementiert");
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
