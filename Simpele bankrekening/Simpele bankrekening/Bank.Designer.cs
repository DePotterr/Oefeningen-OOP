namespace Simpele_bankrekening
{
    partial class Bank
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
            this.walletLabel = new System.Windows.Forms.Label();
            this.overschrijvenButton = new System.Windows.Forms.Button();
            this.opvragenButton = new System.Windows.Forms.Button();
            this.bedragNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.naamLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bedragNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // walletLabel
            // 
            this.walletLabel.AutoSize = true;
            this.walletLabel.Location = new System.Drawing.Point(24, 24);
            this.walletLabel.Name = "walletLabel";
            this.walletLabel.Size = new System.Drawing.Size(93, 17);
            this.walletLabel.TabIndex = 0;
            this.walletLabel.Text = "Portomonnee";
            // 
            // overschrijvenButton
            // 
            this.overschrijvenButton.Location = new System.Drawing.Point(276, 214);
            this.overschrijvenButton.Name = "overschrijvenButton";
            this.overschrijvenButton.Size = new System.Drawing.Size(123, 44);
            this.overschrijvenButton.TabIndex = 2;
            this.overschrijvenButton.Text = "Overschrijven";
            this.overschrijvenButton.UseVisualStyleBackColor = true;
            this.overschrijvenButton.Click += new System.EventHandler(this.OverschrijvenButton_Click);
            // 
            // opvragenButton
            // 
            this.opvragenButton.Location = new System.Drawing.Point(414, 214);
            this.opvragenButton.Name = "opvragenButton";
            this.opvragenButton.Size = new System.Drawing.Size(123, 44);
            this.opvragenButton.TabIndex = 3;
            this.opvragenButton.Text = "Opvragen";
            this.opvragenButton.UseVisualStyleBackColor = true;
            this.opvragenButton.Click += new System.EventHandler(this.OpvragenButton_Click);
            // 
            // bedragNumericUpDown
            // 
            this.bedragNumericUpDown.Location = new System.Drawing.Point(345, 177);
            this.bedragNumericUpDown.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.bedragNumericUpDown.Minimum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.bedragNumericUpDown.Name = "bedragNumericUpDown";
            this.bedragNumericUpDown.Size = new System.Drawing.Size(120, 22);
            this.bedragNumericUpDown.TabIndex = 4;
            this.bedragNumericUpDown.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // naamLabel
            // 
            this.naamLabel.AutoSize = true;
            this.naamLabel.Location = new System.Drawing.Point(352, 23);
            this.naamLabel.Name = "naamLabel";
            this.naamLabel.Size = new System.Drawing.Size(45, 17);
            this.naamLabel.TabIndex = 5;
            this.naamLabel.Text = "Naam";
            // 
            // Bank
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.naamLabel);
            this.Controls.Add(this.bedragNumericUpDown);
            this.Controls.Add(this.opvragenButton);
            this.Controls.Add(this.overschrijvenButton);
            this.Controls.Add(this.walletLabel);
            this.Name = "Bank";
            this.Text = "Rekening";
            ((System.ComponentModel.ISupportInitialize)(this.bedragNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label walletLabel;
        private System.Windows.Forms.Button overschrijvenButton;
        private System.Windows.Forms.Button opvragenButton;
        private System.Windows.Forms.NumericUpDown bedragNumericUpDown;
        private System.Windows.Forms.Label naamLabel;
    }
}

