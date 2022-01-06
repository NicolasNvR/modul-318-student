namespace TransportApp
{
    partial class Hauptmenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ButtonAbbruch = new System.Windows.Forms.Button();
            this.ButtonStationinderNähe = new System.Windows.Forms.Button();
            this.ButtonAbfhartstafel = new System.Windows.Forms.Button();
            this.ButtonStationNavigation = new System.Windows.Forms.Button();
            this.ButtonVerbindungSuchen = new System.Windows.Forms.Button();
            this.LabelHauptseite = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ButtonAbbruch
            // 
            this.ButtonAbbruch.Location = new System.Drawing.Point(540, 400);
            this.ButtonAbbruch.Name = "ButtonAbbruch";
            this.ButtonAbbruch.Size = new System.Drawing.Size(72, 25);
            this.ButtonAbbruch.TabIndex = 17;
            this.ButtonAbbruch.Text = "Abbruch";
            this.ButtonAbbruch.UseVisualStyleBackColor = true;
            this.ButtonAbbruch.Click += new System.EventHandler(this.ButtonAbbruch_Click_1);
            // 
            // ButtonStationinderNähe
            // 
            this.ButtonStationinderNähe.Location = new System.Drawing.Point(188, 325);
            this.ButtonStationinderNähe.Name = "ButtonStationinderNähe";
            this.ButtonStationinderNähe.Size = new System.Drawing.Size(380, 41);
            this.ButtonStationinderNähe.TabIndex = 16;
            this.ButtonStationinderNähe.Text = "Station in der Nähe";
            this.ButtonStationinderNähe.UseVisualStyleBackColor = true;
            // 
            // ButtonAbfhartstafel
            // 
            this.ButtonAbfhartstafel.Location = new System.Drawing.Point(188, 250);
            this.ButtonAbfhartstafel.Name = "ButtonAbfhartstafel";
            this.ButtonAbfhartstafel.Size = new System.Drawing.Size(380, 41);
            this.ButtonAbfhartstafel.TabIndex = 15;
            this.ButtonAbfhartstafel.Text = "Abfahrtstafel";
            this.ButtonAbfhartstafel.UseVisualStyleBackColor = true;
            // 
            // ButtonStationNavigation
            // 
            this.ButtonStationNavigation.Location = new System.Drawing.Point(188, 175);
            this.ButtonStationNavigation.Name = "ButtonStationNavigation";
            this.ButtonStationNavigation.Size = new System.Drawing.Size(380, 41);
            this.ButtonStationNavigation.TabIndex = 14;
            this.ButtonStationNavigation.Text = "Navigation zur Station";
            this.ButtonStationNavigation.UseVisualStyleBackColor = true;
            // 
            // ButtonVerbindungSuchen
            // 
            this.ButtonVerbindungSuchen.Location = new System.Drawing.Point(188, 100);
            this.ButtonVerbindungSuchen.Name = "ButtonVerbindungSuchen";
            this.ButtonVerbindungSuchen.Size = new System.Drawing.Size(380, 41);
            this.ButtonVerbindungSuchen.TabIndex = 13;
            this.ButtonVerbindungSuchen.Text = "Verbindungen Suchen";
            this.ButtonVerbindungSuchen.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ButtonVerbindungSuchen.UseVisualStyleBackColor = true;
            // 
            // LabelHauptseite
            // 
            this.LabelHauptseite.AutoSize = true;
            this.LabelHauptseite.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LabelHauptseite.Location = new System.Drawing.Point(260, 25);
            this.LabelHauptseite.Name = "LabelHauptseite";
            this.LabelHauptseite.Size = new System.Drawing.Size(301, 30);
            this.LabelHauptseite.TabIndex = 12;
            this.LabelHauptseite.Text = "Was wollen Sie machen?";
            // 
            // Hauptmenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ButtonAbbruch);
            this.Controls.Add(this.ButtonStationinderNähe);
            this.Controls.Add(this.ButtonAbfhartstafel);
            this.Controls.Add(this.ButtonStationNavigation);
            this.Controls.Add(this.ButtonVerbindungSuchen);
            this.Controls.Add(this.LabelHauptseite);
            this.Name = "Hauptmenu";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button ButtonAbbruch;
        private Button ButtonStationinderNähe;
        private Button ButtonAbfhartstafel;
        private Button ButtonStationNavigation;
        private Button ButtonVerbindungSuchen;
        private Label LabelHauptseite;
    }
}