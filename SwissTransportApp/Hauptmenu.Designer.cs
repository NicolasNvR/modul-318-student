namespace SwissTransportApp
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
            this.ButtonAbbruch.Location = new System.Drawing.Point(480, 480);
            this.ButtonAbbruch.Name = "ButtonAbbruch";
            this.ButtonAbbruch.Size = new System.Drawing.Size(82, 27);
            this.ButtonAbbruch.TabIndex = 11;
            this.ButtonAbbruch.Text = "Abbruch";
            this.ButtonAbbruch.UseVisualStyleBackColor = true;
            // 
            // ButtonStationinderNähe
            // 
            this.ButtonStationinderNähe.Location = new System.Drawing.Point(78, 400);
            this.ButtonStationinderNähe.Name = "ButtonStationinderNähe";
            this.ButtonStationinderNähe.Size = new System.Drawing.Size(434, 44);
            this.ButtonStationinderNähe.TabIndex = 10;
            this.ButtonStationinderNähe.Text = "Station in der Nähe";
            this.ButtonStationinderNähe.UseVisualStyleBackColor = true;
            this.ButtonStationinderNähe.Click += new System.EventHandler(this.ButtonStationinderNähe_Click);
            // 
            // ButtonAbfhartstafel
            // 
            this.ButtonAbfhartstafel.Location = new System.Drawing.Point(78, 320);
            this.ButtonAbfhartstafel.Name = "ButtonAbfhartstafel";
            this.ButtonAbfhartstafel.Size = new System.Drawing.Size(434, 44);
            this.ButtonAbfhartstafel.TabIndex = 9;
            this.ButtonAbfhartstafel.Text = "Abfahrtstafel";
            this.ButtonAbfhartstafel.UseVisualStyleBackColor = true;
            this.ButtonAbfhartstafel.Click += new System.EventHandler(this.ButtonAbfhartstafel_Click);
            // 
            // ButtonStationNavigation
            // 
            this.ButtonStationNavigation.Location = new System.Drawing.Point(78, 240);
            this.ButtonStationNavigation.Name = "ButtonStationNavigation";
            this.ButtonStationNavigation.Size = new System.Drawing.Size(434, 44);
            this.ButtonStationNavigation.TabIndex = 8;
            this.ButtonStationNavigation.Text = "Navigation zur Station";
            this.ButtonStationNavigation.UseVisualStyleBackColor = true;
            this.ButtonStationNavigation.Click += new System.EventHandler(this.ButtonStationNavigation_Click);
            // 
            // ButtonVerbindungSuchen
            // 
            this.ButtonVerbindungSuchen.Location = new System.Drawing.Point(78, 160);
            this.ButtonVerbindungSuchen.Name = "ButtonVerbindungSuchen";
            this.ButtonVerbindungSuchen.Size = new System.Drawing.Size(434, 44);
            this.ButtonVerbindungSuchen.TabIndex = 7;
            this.ButtonVerbindungSuchen.Text = "Verbindungen Suchen";
            this.ButtonVerbindungSuchen.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ButtonVerbindungSuchen.UseVisualStyleBackColor = true;
            this.ButtonVerbindungSuchen.Click += new System.EventHandler(this.ButtonVerbindungSuchen_Click);
            // 
            // LabelHauptseite
            // 
            this.LabelHauptseite.AutoSize = true;
            this.LabelHauptseite.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelHauptseite.Location = new System.Drawing.Point(160, 80);
            this.LabelHauptseite.Name = "LabelHauptseite";
            this.LabelHauptseite.Size = new System.Drawing.Size(301, 30);
            this.LabelHauptseite.TabIndex = 6;
            this.LabelHauptseite.Text = "Was wollen Sie machen?";
            // 
            // Hauptmenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 526);
            this.Controls.Add(this.ButtonAbbruch);
            this.Controls.Add(this.ButtonStationinderNähe);
            this.Controls.Add(this.ButtonAbfhartstafel);
            this.Controls.Add(this.ButtonStationNavigation);
            this.Controls.Add(this.ButtonVerbindungSuchen);
            this.Controls.Add(this.LabelHauptseite);
            this.Name = "Hauptmenu";
            this.Text = "Hauptmenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonAbbruch;
        private System.Windows.Forms.Button ButtonStationinderNähe;
        private System.Windows.Forms.Button ButtonAbfhartstafel;
        private System.Windows.Forms.Button ButtonStationNavigation;
        private System.Windows.Forms.Button ButtonVerbindungSuchen;
        private System.Windows.Forms.Label LabelHauptseite;
    }
}

