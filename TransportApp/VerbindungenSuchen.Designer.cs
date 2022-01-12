namespace TransportApp
{
    partial class VerbindungenSuchen
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
            this.components = new System.ComponentModel.Container();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.LabelAbfahrtstation = new System.Windows.Forms.Label();
            this.LabelEndstation = new System.Windows.Forms.Label();
            this.PictureBoxWiederholen = new System.Windows.Forms.PictureBox();
            this.DataGridVerbindungenSuchen = new System.Windows.Forms.DataGridView();
            this.ColumnVerkehrsmittel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNummer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnAbfahrtsstation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnEndstation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnAbfahrzeit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDauer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnVerspätung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ButtonVerbindungenSuchen = new System.Windows.Forms.Button();
            this.DateTimer = new System.Windows.Forms.DateTimePicker();
            this.ComboBoxAbfahrtstation = new System.Windows.Forms.ComboBox();
            this.ComboBoxEndstation = new System.Windows.Forms.ComboBox();
            this.PictureBoxHome = new System.Windows.Forms.PictureBox();
            this.pictureBoxMailButton = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxWiederholen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridVerbindungenSuchen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxHome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMailButton)).BeginInit();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // LabelAbfahrtstation
            // 
            this.LabelAbfahrtstation.AutoSize = true;
            this.LabelAbfahrtstation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LabelAbfahrtstation.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LabelAbfahrtstation.Location = new System.Drawing.Point(27, 28);
            this.LabelAbfahrtstation.Name = "LabelAbfahrtstation";
            this.LabelAbfahrtstation.Size = new System.Drawing.Size(154, 30);
            this.LabelAbfahrtstation.TabIndex = 2;
            this.LabelAbfahrtstation.Text = "Abfahrtstation";
            // 
            // LabelEndstation
            // 
            this.LabelEndstation.AutoSize = true;
            this.LabelEndstation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LabelEndstation.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LabelEndstation.Location = new System.Drawing.Point(326, 28);
            this.LabelEndstation.Name = "LabelEndstation";
            this.LabelEndstation.Size = new System.Drawing.Size(115, 30);
            this.LabelEndstation.TabIndex = 3;
            this.LabelEndstation.Text = "Endstation";
            // 
            // PictureBoxWiederholen
            // 
            this.PictureBoxWiederholen.Image = global::TransportApp.Properties.Resources._59417;
            this.PictureBoxWiederholen.Location = new System.Drawing.Point(217, 28);
            this.PictureBoxWiederholen.Name = "PictureBoxWiederholen";
            this.PictureBoxWiederholen.Size = new System.Drawing.Size(69, 66);
            this.PictureBoxWiederholen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBoxWiederholen.TabIndex = 4;
            this.PictureBoxWiederholen.TabStop = false;
            this.PictureBoxWiederholen.Click += new System.EventHandler(this.ButtonWiderholen_Click);
            // 
            // DataGridVerbindungenSuchen
            // 
            this.DataGridVerbindungenSuchen.AllowUserToAddRows = false;
            this.DataGridVerbindungenSuchen.AllowUserToDeleteRows = false;
            this.DataGridVerbindungenSuchen.AllowUserToResizeColumns = false;
            this.DataGridVerbindungenSuchen.AllowUserToResizeRows = false;
            this.DataGridVerbindungenSuchen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridVerbindungenSuchen.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnVerkehrsmittel,
            this.ColumnNummer,
            this.ColumnAbfahrtsstation,
            this.ColumnEndstation,
            this.ColumnAbfahrzeit,
            this.ColumnDauer,
            this.ColumnVerspätung});
            this.DataGridVerbindungenSuchen.Location = new System.Drawing.Point(12, 193);
            this.DataGridVerbindungenSuchen.Name = "DataGridVerbindungenSuchen";
            this.DataGridVerbindungenSuchen.RowTemplate.Height = 25;
            this.DataGridVerbindungenSuchen.Size = new System.Drawing.Size(743, 245);
            this.DataGridVerbindungenSuchen.TabIndex = 5;
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
            // ButtonVerbindungenSuchen
            // 
            this.ButtonVerbindungenSuchen.Location = new System.Drawing.Point(519, 78);
            this.ButtonVerbindungenSuchen.Name = "ButtonVerbindungenSuchen";
            this.ButtonVerbindungenSuchen.Size = new System.Drawing.Size(137, 23);
            this.ButtonVerbindungenSuchen.TabIndex = 6;
            this.ButtonVerbindungenSuchen.Text = "Verbindungen Suchen";
            this.ButtonVerbindungenSuchen.UseVisualStyleBackColor = true;
            this.ButtonVerbindungenSuchen.Click += new System.EventHandler(this.ButtonVerbindungenSuchen_Click);
            // 
            // DateTimer
            // 
            this.DateTimer.CalendarTrailingForeColor = System.Drawing.Color.Gray;
            this.DateTimer.Cursor = System.Windows.Forms.Cursors.Default;
            this.DateTimer.CustomFormat = "MM-dd-yyyy / hh:mm";
            this.DateTimer.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DateTimer.Location = new System.Drawing.Point(27, 151);
            this.DateTimer.Name = "DateTimer";
            this.DateTimer.Size = new System.Drawing.Size(154, 23);
            this.DateTimer.TabIndex = 7;
            // 
            // ComboBoxAbfahrtstation
            // 
            this.ComboBoxAbfahrtstation.FormattingEnabled = true;
            this.ComboBoxAbfahrtstation.Location = new System.Drawing.Point(27, 79);
            this.ComboBoxAbfahrtstation.Name = "ComboBoxAbfahrtstation";
            this.ComboBoxAbfahrtstation.Size = new System.Drawing.Size(155, 23);
            this.ComboBoxAbfahrtstation.TabIndex = 8;
            this.ComboBoxAbfahrtstation.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ComboBoxAbfahrtstation_KeyUp);
            // 
            // ComboBoxEndstation
            // 
            this.ComboBoxEndstation.FormattingEnabled = true;
            this.ComboBoxEndstation.Location = new System.Drawing.Point(326, 79);
            this.ComboBoxEndstation.Name = "ComboBoxEndstation";
            this.ComboBoxEndstation.Size = new System.Drawing.Size(155, 23);
            this.ComboBoxEndstation.TabIndex = 9;
            this.ComboBoxEndstation.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ComboBoxEndstation_KeyUp_1);
            // 
            // PictureBoxHome
            // 
            this.PictureBoxHome.Image = global::TransportApp.Properties.Resources.HomeIcon21;
            this.PictureBoxHome.Location = new System.Drawing.Point(708, 12);
            this.PictureBoxHome.Name = "PictureBoxHome";
            this.PictureBoxHome.Size = new System.Drawing.Size(80, 67);
            this.PictureBoxHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBoxHome.TabIndex = 10;
            this.PictureBoxHome.TabStop = false;
            this.PictureBoxHome.Click += new System.EventHandler(this.PictureBoxHome_Click);
            // 
            // pictureBoxMailButton
            // 
            this.pictureBoxMailButton.Image = global::TransportApp.Properties.Resources.Mailicon__2_;
            this.pictureBoxMailButton.Location = new System.Drawing.Point(708, 97);
            this.pictureBoxMailButton.Name = "pictureBoxMailButton";
            this.pictureBoxMailButton.Size = new System.Drawing.Size(80, 63);
            this.pictureBoxMailButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxMailButton.TabIndex = 11;
            this.pictureBoxMailButton.TabStop = false;
            this.pictureBoxMailButton.Click += new System.EventHandler(this.PictureBoxMailButton_Click);
            // 
            // VerbindungenSuchen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBoxMailButton);
            this.Controls.Add(this.PictureBoxHome);
            this.Controls.Add(this.ComboBoxEndstation);
            this.Controls.Add(this.ComboBoxAbfahrtstation);
            this.Controls.Add(this.DateTimer);
            this.Controls.Add(this.ButtonVerbindungenSuchen);
            this.Controls.Add(this.DataGridVerbindungenSuchen);
            this.Controls.Add(this.PictureBoxWiederholen);
            this.Controls.Add(this.LabelEndstation);
            this.Controls.Add(this.LabelAbfahrtstation);
            this.Name = "VerbindungenSuchen";
            this.Text = "VerbindungenSuchen";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.VerbindungenSuchen_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxWiederholen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridVerbindungenSuchen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxHome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMailButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DateTimePicker dateTimePicker1;
        private ImageList imageList1;
        private Label LabelAbfahrtstation;
        private Label LabelEndstation;
        private PictureBox PictureBoxWiederholen;
        private DataGridView DataGridVerbindungenSuchen;
        private DataGridViewTextBoxColumn ColumnVerkehrsmittel;
        private DataGridViewTextBoxColumn ColumnNummer;
        private DataGridViewTextBoxColumn ColumnAbfahrtsstation;
        private DataGridViewTextBoxColumn ColumnEndstation;
        private DataGridViewTextBoxColumn ColumnAbfahrzeit;
        private DataGridViewTextBoxColumn ColumnDauer;
        private DataGridViewTextBoxColumn ColumnVerspätung;
        private Button ButtonVerbindungenSuchen;
        private ComboBox ComboBoxAbfahrtstation;
        private ComboBox ComboBoxEndstation;
        private PictureBox PictureBoxHome;
        public DateTimePicker DateTimer;
        private PictureBox pictureBoxMailButton;
    }
}