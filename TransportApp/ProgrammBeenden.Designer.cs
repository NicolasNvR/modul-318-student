namespace TransportApp
{
    partial class ProgrammBeenden
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
            this.LabelProgrammBeenden = new System.Windows.Forms.Label();
            this.ButtonNein = new System.Windows.Forms.Button();
            this.ButtonJa = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LabelProgrammBeenden
            // 
            this.LabelProgrammBeenden.AutoSize = true;
            this.LabelProgrammBeenden.Location = new System.Drawing.Point(30, 33);
            this.LabelProgrammBeenden.Name = "LabelProgrammBeenden";
            this.LabelProgrammBeenden.Size = new System.Drawing.Size(196, 15);
            this.LabelProgrammBeenden.TabIndex = 0;
            this.LabelProgrammBeenden.Text = "Wollen sie das Programm beenden?";
            // 
            // ButtonNein
            // 
            this.ButtonNein.Location = new System.Drawing.Point(125, 80);
            this.ButtonNein.Name = "ButtonNein";
            this.ButtonNein.Size = new System.Drawing.Size(75, 23);
            this.ButtonNein.TabIndex = 1;
            this.ButtonNein.Text = "Nein";
            this.ButtonNein.UseVisualStyleBackColor = true;
            this.ButtonNein.Click += new System.EventHandler(this.ButtonNein_Click);
            // 
            // ButtonJa
            // 
            this.ButtonJa.Location = new System.Drawing.Point(44, 80);
            this.ButtonJa.Name = "ButtonJa";
            this.ButtonJa.Size = new System.Drawing.Size(75, 23);
            this.ButtonJa.TabIndex = 2;
            this.ButtonJa.Text = "Ja";
            this.ButtonJa.UseVisualStyleBackColor = true;
            this.ButtonJa.Click += new System.EventHandler(this.ButtonJa_Click);
            // 
            // ProgrammBeenden
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(262, 129);
            this.Controls.Add(this.ButtonJa);
            this.Controls.Add(this.ButtonNein);
            this.Controls.Add(this.LabelProgrammBeenden);
            this.Name = "ProgrammBeenden";
            this.Text = "ProgrammBeenden";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label LabelProgrammBeenden;
        private Button ButtonNein;
        private Button ButtonJa;
    }
}