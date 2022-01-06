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
            this.SuspendLayout();
            // 
            // ButtonSchliessen
            // 
            this.ButtonSchliessen.Location = new System.Drawing.Point(636, 343);
            this.ButtonSchliessen.Name = "ButtonSchliessen";
            this.ButtonSchliessen.Size = new System.Drawing.Size(75, 23);
            this.ButtonSchliessen.TabIndex = 0;
            this.ButtonSchliessen.Text = "Schliessen";
            this.ButtonSchliessen.UseVisualStyleBackColor = true;
            this.ButtonSchliessen.Click += new System.EventHandler(this.ButtonSchliessen_Click);
            // 
            // Abfhartstafel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ButtonSchliessen);
            this.Name = "Abfhartstafel";
            this.Text = "Abfhartstafel";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Abfhartstafel_FormClosed);
            this.Click += new System.EventHandler(this.ButtonSchliessen_Click);
            this.ResumeLayout(false);

        }

        #endregion

        private Button ButtonSchliessen;
    }
}