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
            this.ButtonSchliessen = new System.Windows.Forms.Button();
            this.ButtonWiderholen = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.LabelAbfahrtsstation = new System.Windows.Forms.Label();
            this.LabelEndstation = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ButtonSchliessen
            // 
            this.ButtonSchliessen.BackColor = System.Drawing.Color.Transparent;
            this.ButtonSchliessen.Image = global::TransportApp.Properties.Resources.HomeIcon;
            this.ButtonSchliessen.Location = new System.Drawing.Point(717, 28);
            this.ButtonSchliessen.Name = "ButtonSchliessen";
            this.ButtonSchliessen.Size = new System.Drawing.Size(71, 70);
            this.ButtonSchliessen.TabIndex = 0;
            this.ButtonSchliessen.UseVisualStyleBackColor = false;
            this.ButtonSchliessen.Click += new System.EventHandler(this.ButtonSchliessen_Click);
            // 
            // ButtonWiderholen
            // 
            this.ButtonWiderholen.BackColor = System.Drawing.Color.Transparent;
            this.ButtonWiderholen.Image = global::TransportApp.Properties.Resources.WiderholenIcon1_min1;
            this.ButtonWiderholen.Location = new System.Drawing.Point(229, 90);
            this.ButtonWiderholen.Name = "ButtonWiderholen";
            this.ButtonWiderholen.Size = new System.Drawing.Size(70, 70);
            this.ButtonWiderholen.TabIndex = 1;
            this.ButtonWiderholen.UseVisualStyleBackColor = false;
            this.ButtonWiderholen.Click += new System.EventHandler(this.ButtonWiderholen_Click);
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
            this.LabelAbfahrtsstation.Location = new System.Drawing.Point(44, 40);
            this.LabelAbfahrtsstation.Name = "LabelAbfahrtsstation";
            this.LabelAbfahrtsstation.Size = new System.Drawing.Size(84, 15);
            this.LabelAbfahrtsstation.TabIndex = 2;
            this.LabelAbfahrtsstation.Text = "Abfahrtssation";
            // 
            // LabelEndstation
            // 
            this.LabelEndstation.AutoSize = true;
            this.LabelEndstation.Location = new System.Drawing.Point(378, 40);
            this.LabelEndstation.Name = "LabelEndstation";
            this.LabelEndstation.Size = new System.Drawing.Size(84, 15);
            this.LabelEndstation.TabIndex = 3;
            this.LabelEndstation.Text = "Abfahrtssation";
            // 
            // VerbindungenSuchen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LabelEndstation);
            this.Controls.Add(this.LabelAbfahrtsstation);
            this.Controls.Add(this.ButtonWiderholen);
            this.Controls.Add(this.ButtonSchliessen);
            this.Name = "VerbindungenSuchen";
            this.Text = "VerbindungenSuchen";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.VerbindungenSuchen_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button ButtonSchliessen;
        private DateTimePicker dateTimePicker1;
        private Button ButtonWiderholen;
        private ImageList imageList1;
        private Label LabelAbfahrtsstation;
        private Label LabelEndstation;
    }
}