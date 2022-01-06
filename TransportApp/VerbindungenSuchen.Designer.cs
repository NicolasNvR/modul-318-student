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
            this.LabelAbfahrtsstation = new System.Windows.Forms.Label();
            this.LabelEndstation = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.DataGridVerbindungenSuchen = new System.Windows.Forms.DataGridView();
            this.ColumnVerkehrsmittel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNummer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnAbfahrtsstation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnEndstation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnAbfahrzeit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDauer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnVerspätung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ButtonVerbindungenSuchen = new System.Windows.Forms.Button();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridVerbindungenSuchen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // LabelAbfahrtsstation
            // 
            this.LabelAbfahrtsstation.AutoSize = true;
            this.LabelAbfahrtsstation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LabelAbfahrtsstation.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LabelAbfahrtsstation.Location = new System.Drawing.Point(27, 28);
            this.LabelAbfahrtsstation.Name = "LabelAbfahrtsstation";
            this.LabelAbfahrtsstation.Size = new System.Drawing.Size(155, 30);
            this.LabelAbfahrtsstation.TabIndex = 2;
            this.LabelAbfahrtsstation.Text = "Abfahrtssation";
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
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TransportApp.Properties.Resources._59417;
            this.pictureBox1.Location = new System.Drawing.Point(217, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(70, 74);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
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
            this.DataGridVerbindungenSuchen.Size = new System.Drawing.Size(776, 245);
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
            this.ButtonVerbindungenSuchen.Location = new System.Drawing.Point(521, 56);
            this.ButtonVerbindungenSuchen.Name = "ButtonVerbindungenSuchen";
            this.ButtonVerbindungenSuchen.Size = new System.Drawing.Size(137, 23);
            this.ButtonVerbindungenSuchen.TabIndex = 6;
            this.ButtonVerbindungenSuchen.Text = "Verbindungen Suchen";
            this.ButtonVerbindungenSuchen.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(12, 150);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 23);
            this.dateTimePicker2.TabIndex = 7;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(27, 79);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(155, 23);
            this.comboBox1.TabIndex = 8;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(326, 79);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(155, 23);
            this.comboBox2.TabIndex = 9;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::TransportApp.Properties.Resources.HomeIcon21;
            this.pictureBox2.Location = new System.Drawing.Point(708, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(80, 67);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // VerbindungenSuchen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.ButtonVerbindungenSuchen);
            this.Controls.Add(this.DataGridVerbindungenSuchen);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.LabelEndstation);
            this.Controls.Add(this.LabelAbfahrtsstation);
            this.Name = "VerbindungenSuchen";
            this.Text = "VerbindungenSuchen";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.VerbindungenSuchen_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridVerbindungenSuchen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DateTimePicker dateTimePicker1;
        private ImageList imageList1;
        private Label LabelAbfahrtsstation;
        private Label LabelEndstation;
        private PictureBox pictureBox1;
        private DataGridView DataGridVerbindungenSuchen;
        private DataGridViewTextBoxColumn ColumnVerkehrsmittel;
        private DataGridViewTextBoxColumn ColumnNummer;
        private DataGridViewTextBoxColumn ColumnAbfahrtsstation;
        private DataGridViewTextBoxColumn ColumnEndstation;
        private DataGridViewTextBoxColumn ColumnAbfahrzeit;
        private DataGridViewTextBoxColumn ColumnDauer;
        private DataGridViewTextBoxColumn ColumnVerspätung;
        private Button ButtonVerbindungenSuchen;
        private DateTimePicker dateTimePicker2;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private PictureBox pictureBox2;
    }
}