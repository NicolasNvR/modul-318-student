namespace TransportApp
{
    partial class Abfhartstafel
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ButtonSchliessen = new System.Windows.Forms.Button();
            this.LabelStation = new System.Windows.Forms.Label();
            this.ComboBoxAbfhartstafel = new System.Windows.Forms.ComboBox();
            this.PictureBoxHome = new System.Windows.Forms.PictureBox();
            this.DataGridAbfhartstafel = new System.Windows.Forms.DataGridView();
            this.ColumnVerkehrsmittel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNummer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnAbfahrtsstation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnEndstation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnAbfahrzeit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDauer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnVerspätung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ButtonSuchen = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxHome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridAbfhartstafel)).BeginInit();
            this.SuspendLayout();
            // 
            // ButtonSchliessen
            // 
            this.ButtonSchliessen.Location = new System.Drawing.Point(713, 415);
            this.ButtonSchliessen.Name = "ButtonSchliessen";
            this.ButtonSchliessen.Size = new System.Drawing.Size(75, 23);
            this.ButtonSchliessen.TabIndex = 0;
            this.ButtonSchliessen.Text = "Schliessen";
            this.ButtonSchliessen.UseVisualStyleBackColor = true;
            this.ButtonSchliessen.Click += new System.EventHandler(this.ButtonSchliessen_Click);
            // 
            // LabelStation
            // 
            this.LabelStation.AutoSize = true;
            this.LabelStation.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LabelStation.Location = new System.Drawing.Point(30, 70);
            this.LabelStation.Name = "LabelStation";
            this.LabelStation.Size = new System.Drawing.Size(106, 37);
            this.LabelStation.TabIndex = 1;
            this.LabelStation.Text = "Station:";
            // 
            // ComboBoxAbfhartstafel
            // 
            this.ComboBoxAbfhartstafel.FormattingEnabled = true;
            this.ComboBoxAbfhartstafel.Location = new System.Drawing.Point(209, 84);
            this.ComboBoxAbfhartstafel.Name = "ComboBoxAbfhartstafel";
            this.ComboBoxAbfhartstafel.Size = new System.Drawing.Size(155, 23);
            this.ComboBoxAbfhartstafel.TabIndex = 10;
            this.ComboBoxAbfhartstafel.SelectedIndexChanged += new System.EventHandler(this.ComboBoxAbfhartstafel_SelectedIndexChanged);
            // 
            // PictureBoxHome
            // 
            this.PictureBoxHome.Image = global::TransportApp.Properties.Resources.HomeIcon21;
            this.PictureBoxHome.Location = new System.Drawing.Point(708, 12);
            this.PictureBoxHome.Name = "PictureBoxHome";
            this.PictureBoxHome.Size = new System.Drawing.Size(80, 67);
            this.PictureBoxHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBoxHome.TabIndex = 11;
            this.PictureBoxHome.TabStop = false;
            this.PictureBoxHome.Click += new System.EventHandler(this.PictureBoxHome_Click);
            // 
            // DataGridAbfhartstafel
            // 
            this.DataGridAbfhartstafel.AllowUserToAddRows = false;
            this.DataGridAbfhartstafel.AllowUserToDeleteRows = false;
            this.DataGridAbfhartstafel.AllowUserToResizeColumns = false;
            this.DataGridAbfhartstafel.AllowUserToResizeRows = false;
            this.DataGridAbfhartstafel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridAbfhartstafel.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnVerkehrsmittel,
            this.ColumnNummer,
            this.ColumnAbfahrtsstation,
            this.ColumnEndstation,
            this.ColumnAbfahrzeit,
            this.ColumnDauer,
            this.ColumnVerspätung});
            this.DataGridAbfhartstafel.Location = new System.Drawing.Point(12, 164);
            this.DataGridAbfhartstafel.Name = "DataGridAbfhartstafel";
            this.DataGridAbfhartstafel.RowTemplate.Height = 25;
            this.DataGridAbfhartstafel.Size = new System.Drawing.Size(743, 245);
            this.DataGridAbfhartstafel.TabIndex = 12;
            // 
            // ColumnVerkehrsmittel
            // 
            this.ColumnVerkehrsmittel.HeaderText = "Verkehrsmittel";
            this.ColumnVerkehrsmittel.Name = "ColumnVerkehrsmittel";
            // 
            // ColumnNummer
            // 
            this.ColumnNummer.HeaderText = "Nummer";
            this.ColumnNummer.Name = "ColumnNummer";
            // 
            // ColumnAbfahrtsstation
            // 
            this.ColumnAbfahrtsstation.HeaderText = "Abfahrtsstation";
            this.ColumnAbfahrtsstation.Name = "ColumnAbfahrtsstation";
            // 
            // ColumnEndstation
            // 
            this.ColumnEndstation.HeaderText = "Endstation";
            this.ColumnEndstation.Name = "ColumnEndstation";
            // 
            // ColumnAbfahrzeit
            // 
            this.ColumnAbfahrzeit.HeaderText = "Abfahrzeit";
            this.ColumnAbfahrzeit.Name = "ColumnAbfahrzeit";
            // 
            // ColumnDauer
            // 
            this.ColumnDauer.HeaderText = "Dauer";
            this.ColumnDauer.Name = "ColumnDauer";
            // 
            // ColumnVerspätung
            // 
            this.ColumnVerspätung.HeaderText = "Verspätung";
            this.ColumnVerspätung.Name = "ColumnVerspätung";
            // 
            // ButtonSuchen
            // 
            this.ButtonSuchen.Location = new System.Drawing.Point(454, 84);
            this.ButtonSuchen.Name = "ButtonSuchen";
            this.ButtonSuchen.Size = new System.Drawing.Size(137, 23);
            this.ButtonSuchen.TabIndex = 13;
            this.ButtonSuchen.Text = "Suchen";
            this.ButtonSuchen.UseVisualStyleBackColor = true;
            this.ButtonSuchen.Click += new System.EventHandler(this.ButtonSuchen_Click);
            // 
            // Abfhartstafel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ButtonSuchen);
            this.Controls.Add(this.DataGridAbfhartstafel);
            this.Controls.Add(this.PictureBoxHome);
            this.Controls.Add(this.ComboBoxAbfhartstafel);
            this.Controls.Add(this.LabelStation);
            this.Controls.Add(this.ButtonSchliessen);
            this.Name = "Abfhartstafel";
            this.Text = "Abfhartstafel";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Abfhartstafel_FormClosed);
            this.Click += new System.EventHandler(this.ButtonSchliessen_Click);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxHome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridAbfhartstafel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button ButtonSchliessen;
        private Label LabelStation;
        private ComboBox ComboBoxAbfhartstafel;
        private PictureBox PictureBoxHome;
        private DataGridView DataGridAbfhartstafel;
        private DataGridViewTextBoxColumn ColumnVerkehrsmittel;
        private DataGridViewTextBoxColumn ColumnNummer;
        private DataGridViewTextBoxColumn ColumnAbfahrtsstation;
        private DataGridViewTextBoxColumn ColumnEndstation;
        private DataGridViewTextBoxColumn ColumnAbfahrzeit;
        private DataGridViewTextBoxColumn ColumnDauer;
        private DataGridViewTextBoxColumn ColumnVerspätung;
        private Button ButtonSuchen;
    }
}