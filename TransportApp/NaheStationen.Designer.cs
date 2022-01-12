namespace TransportApp
{
    partial class NaheStationen
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
            this.DataGridNaheStationenGross = new System.Windows.Forms.DataGridView();
            this.ColumnVerkehrsmittel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNummer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnAbfahrtsstation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnEndstation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnAbfahrzeit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDauer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnVerspätung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridNaheStationenKlein = new System.Windows.Forms.DataGridView();
            this.ButtonSucheNachStation = new System.Windows.Forms.Button();
            this.ButtonTakeMeHome = new System.Windows.Forms.Button();
            this.PictureBoxHome = new System.Windows.Forms.PictureBox();
            this.ComboBoxNaheStationen = new System.Windows.Forms.ComboBox();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Station = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kordinaten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridNaheStationenGross)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridNaheStationenKlein)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxHome)).BeginInit();
            this.SuspendLayout();
            // 
            // ButtonSchliessen
            // 
            this.ButtonSchliessen.Location = new System.Drawing.Point(722, 402);
            this.ButtonSchliessen.Name = "ButtonSchliessen";
            this.ButtonSchliessen.Size = new System.Drawing.Size(75, 36);
            this.ButtonSchliessen.TabIndex = 0;
            this.ButtonSchliessen.Text = "Schliessen";
            this.ButtonSchliessen.UseVisualStyleBackColor = true;
            this.ButtonSchliessen.Click += new System.EventHandler(this.ButtonSchliessen_Click);
            // 
            // DataGridNaheStationenGross
            // 
            this.DataGridNaheStationenGross.AllowUserToAddRows = false;
            this.DataGridNaheStationenGross.AllowUserToDeleteRows = false;
            this.DataGridNaheStationenGross.AllowUserToResizeColumns = false;
            this.DataGridNaheStationenGross.AllowUserToResizeRows = false;
            this.DataGridNaheStationenGross.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridNaheStationenGross.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnVerkehrsmittel,
            this.ColumnNummer,
            this.ColumnAbfahrtsstation,
            this.ColumnEndstation,
            this.ColumnAbfahrzeit,
            this.ColumnDauer,
            this.ColumnVerspätung});
            this.DataGridNaheStationenGross.Location = new System.Drawing.Point(21, 251);
            this.DataGridNaheStationenGross.Name = "DataGridNaheStationenGross";
            this.DataGridNaheStationenGross.RowTemplate.Height = 25;
            this.DataGridNaheStationenGross.Size = new System.Drawing.Size(641, 157);
            this.DataGridNaheStationenGross.TabIndex = 13;
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
            // dataGridNaheStationenKlein
            // 
            this.dataGridNaheStationenKlein.AllowUserToAddRows = false;
            this.dataGridNaheStationenKlein.AllowUserToDeleteRows = false;
            this.dataGridNaheStationenKlein.AllowUserToResizeColumns = false;
            this.dataGridNaheStationenKlein.AllowUserToResizeRows = false;
            this.dataGridNaheStationenKlein.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridNaheStationenKlein.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Station,
            this.Kordinaten});
            this.dataGridNaheStationenKlein.Location = new System.Drawing.Point(21, 127);
            this.dataGridNaheStationenKlein.Name = "dataGridNaheStationenKlein";
            this.dataGridNaheStationenKlein.RowTemplate.Height = 25;
            this.dataGridNaheStationenKlein.Size = new System.Drawing.Size(337, 118);
            this.dataGridNaheStationenKlein.TabIndex = 14;
            // 
            // ButtonSucheNachStation
            // 
            this.ButtonSucheNachStation.Location = new System.Drawing.Point(21, 23);
            this.ButtonSucheNachStation.Name = "ButtonSucheNachStation";
            this.ButtonSucheNachStation.Size = new System.Drawing.Size(146, 36);
            this.ButtonSucheNachStation.TabIndex = 15;
            this.ButtonSucheNachStation.Text = "Suche nach Stationen";
            this.ButtonSucheNachStation.UseVisualStyleBackColor = true;
            this.ButtonSucheNachStation.Click += new System.EventHandler(this.ButtonSucheNachStation_Click);
            // 
            // ButtonTakeMeHome
            // 
            this.ButtonTakeMeHome.Location = new System.Drawing.Point(223, 23);
            this.ButtonTakeMeHome.Name = "ButtonTakeMeHome";
            this.ButtonTakeMeHome.Size = new System.Drawing.Size(146, 36);
            this.ButtonTakeMeHome.TabIndex = 16;
            this.ButtonTakeMeHome.Text = "Take My Home";
            this.ButtonTakeMeHome.UseVisualStyleBackColor = true;
            this.ButtonTakeMeHome.Click += new System.EventHandler(this.ButtonTakeMeHome_Click);
            // 
            // PictureBoxHome
            // 
            this.PictureBoxHome.Image = global::TransportApp.Properties.Resources.HomeIcon21;
            this.PictureBoxHome.Location = new System.Drawing.Point(708, 12);
            this.PictureBoxHome.Name = "PictureBoxHome";
            this.PictureBoxHome.Size = new System.Drawing.Size(80, 67);
            this.PictureBoxHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBoxHome.TabIndex = 17;
            this.PictureBoxHome.TabStop = false;
            this.PictureBoxHome.Click += new System.EventHandler(this.PictureBoxHome_Click_1);
            // 
            // ComboBoxNaheStationen
            // 
            this.ComboBoxNaheStationen.FormattingEnabled = true;
            this.ComboBoxNaheStationen.Location = new System.Drawing.Point(21, 81);
            this.ComboBoxNaheStationen.Name = "ComboBoxNaheStationen";
            this.ComboBoxNaheStationen.Size = new System.Drawing.Size(159, 23);
            this.ComboBoxNaheStationen.TabIndex = 18;
            this.ComboBoxNaheStationen.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ComboBoxNaheStationen_KeyUp);
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Station";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 250;
            // 
            // Station
            // 
            this.Station.HeaderText = "Station";
            this.Station.Name = "Station";
            this.Station.Width = 150;
            // 
            // Kordinaten
            // 
            this.Kordinaten.HeaderText = "Kordinaten";
            this.Kordinaten.Name = "Kordinaten";
            this.Kordinaten.Width = 150;
            // 
            // NaheStationen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ComboBoxNaheStationen);
            this.Controls.Add(this.PictureBoxHome);
            this.Controls.Add(this.ButtonTakeMeHome);
            this.Controls.Add(this.ButtonSucheNachStation);
            this.Controls.Add(this.dataGridNaheStationenKlein);
            this.Controls.Add(this.DataGridNaheStationenGross);
            this.Controls.Add(this.ButtonSchliessen);
            this.Name = "NaheStationen";
            this.Text = "NaheStationen";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.NaheStationen_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridNaheStationenGross)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridNaheStationenKlein)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxHome)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button ButtonSchliessen;
        private DataGridView DataGridNaheStationenGross;
        private DataGridViewTextBoxColumn ColumnVerkehrsmittel;
        private DataGridViewTextBoxColumn ColumnNummer;
        private DataGridViewTextBoxColumn ColumnAbfahrtsstation;
        private DataGridViewTextBoxColumn ColumnEndstation;
        private DataGridViewTextBoxColumn ColumnAbfahrzeit;
        private DataGridViewTextBoxColumn ColumnDauer;
        private DataGridViewTextBoxColumn ColumnVerspätung;
        private DataGridView dataGridNaheStationenKlein;
        private Button ButtonSucheNachStation;
        private Button ButtonTakeMeHome;
        private PictureBox PictureBoxHome;
        private ComboBox ComboBoxNaheStationen;
        private DataGridViewTextBoxColumn Station;
        private DataGridViewTextBoxColumn Kordinaten;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}