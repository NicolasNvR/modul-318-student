namespace TransportApp
{
    partial class NavigationzurStation
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
            this.ButtonSchlissen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ButtonSchlissen
            // 
            this.ButtonSchlissen.Location = new System.Drawing.Point(419, 278);
            this.ButtonSchlissen.Name = "ButtonSchlissen";
            this.ButtonSchlissen.Size = new System.Drawing.Size(108, 27);
            this.ButtonSchlissen.TabIndex = 1;
            this.ButtonSchlissen.Text = "Schliessen";
            this.ButtonSchlissen.UseVisualStyleBackColor = true;
            this.ButtonSchlissen.Click += new System.EventHandler(this.ButtonSchlissen_Click);
            // 
            // NavigationzurStation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ButtonSchlissen);
            this.Name = "NavigationzurStation";
            this.Text = "NavigationzurStation";
            this.ResumeLayout(false);

        }

        #endregion

        private Button ButtonSchlissen;
    }
}