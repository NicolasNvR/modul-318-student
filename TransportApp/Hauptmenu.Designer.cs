namespace TransportApp
{
    partial class Hauptmenu
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
            this.ButtonVerbindungenSuchen = new System.Windows.Forms.Button();
            this.ButtonStadtioneninderNähe = new System.Windows.Forms.Button();
            this.ButtonAbfhartstafel = new System.Windows.Forms.Button();
            this.ButtonNavigationzurStation = new System.Windows.Forms.Button();
            this.ButtonAbbrechen = new System.Windows.Forms.Button();
            this.LabelHauptmenu = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ButtonVerbindungenSuchen
            // 
            this.ButtonVerbindungenSuchen.Location = new System.Drawing.Point(112, 124);
            this.ButtonVerbindungenSuchen.Name = "ButtonVerbindungenSuchen";
            this.ButtonVerbindungenSuchen.Size = new System.Drawing.Size(204, 31);
            this.ButtonVerbindungenSuchen.TabIndex = 0;
            this.ButtonVerbindungenSuchen.Text = "Verbindungen Suchen";
            this.ButtonVerbindungenSuchen.UseVisualStyleBackColor = true;
            this.ButtonVerbindungenSuchen.Click += new System.EventHandler(this.ButtonVerbindungenSuchen_Click);
            // 
            // ButtonStadtioneninderNähe
            // 
            this.ButtonStadtioneninderNähe.Location = new System.Drawing.Point(112, 281);
            this.ButtonStadtioneninderNähe.Name = "ButtonStadtioneninderNähe";
            this.ButtonStadtioneninderNähe.Size = new System.Drawing.Size(204, 31);
            this.ButtonStadtioneninderNähe.TabIndex = 1;
            this.ButtonStadtioneninderNähe.Text = "Stationen in der Nähe";
            this.ButtonStadtioneninderNähe.UseVisualStyleBackColor = true;
            this.ButtonStadtioneninderNähe.Click += new System.EventHandler(this.ButtonStadtioneninderNähe_Click);
            // 
            // ButtonAbfhartstafel
            // 
            this.ButtonAbfhartstafel.Location = new System.Drawing.Point(112, 229);
            this.ButtonAbfhartstafel.Name = "ButtonAbfhartstafel";
            this.ButtonAbfhartstafel.Size = new System.Drawing.Size(204, 31);
            this.ButtonAbfhartstafel.TabIndex = 2;
            this.ButtonAbfhartstafel.Text = "Abfhartstafel";
            this.ButtonAbfhartstafel.UseVisualStyleBackColor = true;
            this.ButtonAbfhartstafel.Click += new System.EventHandler(this.ButtonAbfhartstafel_Click);
            // 
            // ButtonNavigationzurStation
            // 
            this.ButtonNavigationzurStation.Location = new System.Drawing.Point(112, 174);
            this.ButtonNavigationzurStation.Name = "ButtonNavigationzurStation";
            this.ButtonNavigationzurStation.Size = new System.Drawing.Size(204, 31);
            this.ButtonNavigationzurStation.TabIndex = 3;
            this.ButtonNavigationzurStation.Text = "Navigation zur Station";
            this.ButtonNavigationzurStation.UseVisualStyleBackColor = true;
            this.ButtonNavigationzurStation.Click += new System.EventHandler(this.ButtonNavigationzurStation_Click);
            // 
            // ButtonAbbrechen
            // 
            this.ButtonAbbrechen.Location = new System.Drawing.Point(301, 345);
            this.ButtonAbbrechen.Name = "ButtonAbbrechen";
            this.ButtonAbbrechen.Size = new System.Drawing.Size(75, 23);
            this.ButtonAbbrechen.TabIndex = 4;
            this.ButtonAbbrechen.Text = "Abbrechen";
            this.ButtonAbbrechen.UseVisualStyleBackColor = true;
            this.ButtonAbbrechen.Click += new System.EventHandler(this.ButtonAbbrechen_Click);
            // 
            // LabelHauptmenu
            // 
            this.LabelHauptmenu.AutoSize = true;
            this.LabelHauptmenu.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LabelHauptmenu.Location = new System.Drawing.Point(70, 57);
            this.LabelHauptmenu.Name = "LabelHauptmenu";
            this.LabelHauptmenu.Size = new System.Drawing.Size(306, 37);
            this.LabelHauptmenu.TabIndex = 5;
            this.LabelHauptmenu.Text = "Was wollen Sie machen?";
            // 
            // Hauptmenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 393);
            this.Controls.Add(this.LabelHauptmenu);
            this.Controls.Add(this.ButtonAbbrechen);
            this.Controls.Add(this.ButtonNavigationzurStation);
            this.Controls.Add(this.ButtonAbfhartstafel);
            this.Controls.Add(this.ButtonStadtioneninderNähe);
            this.Controls.Add(this.ButtonVerbindungenSuchen);
            this.Name = "Hauptmenu";
            this.Text = "Hauptmenu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Hauptmenu_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button ButtonVerbindungenSuchen;
        private Button ButtonStadtioneninderNähe;
        private Button ButtonAbfhartstafel;
        private Button ButtonNavigationzurStation;
        private Button ButtonAbbrechen;
        private Label LabelHauptmenu;
    }
}