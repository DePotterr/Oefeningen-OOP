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
            this.bevestigButton = new System.Windows.Forms.Button();
            this.naamLabel = new System.Windows.Forms.Label();
            this.errorLabel = new System.Windows.Forms.Label();
            this.bedragTextbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // walletLabel
            // 
            this.walletLabel.AutoSize = true;
            this.walletLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.walletLabel.Location = new System.Drawing.Point(11, 38);
            this.walletLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.walletLabel.Name = "walletLabel";
            this.walletLabel.Size = new System.Drawing.Size(129, 25);
            this.walletLabel.TabIndex = 0;
            this.walletLabel.Text = "Portomonnee";
            // 
            // bevestigButton
            // 
            this.bevestigButton.Location = new System.Drawing.Point(237, 179);
            this.bevestigButton.Margin = new System.Windows.Forms.Padding(2);
            this.bevestigButton.Name = "bevestigButton";
            this.bevestigButton.Size = new System.Drawing.Size(92, 36);
            this.bevestigButton.TabIndex = 2;
            this.bevestigButton.Text = "Overschrijven/ Afhalen";
            this.bevestigButton.UseVisualStyleBackColor = true;
            this.bevestigButton.Click += new System.EventHandler(this.BevestigButton_Click);
            // 
            // naamLabel
            // 
            this.naamLabel.AutoSize = true;
            this.naamLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.naamLabel.Location = new System.Drawing.Point(11, 9);
            this.naamLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.naamLabel.Name = "naamLabel";
            this.naamLabel.Size = new System.Drawing.Size(77, 29);
            this.naamLabel.TabIndex = 5;
            this.naamLabel.Text = "Naam";
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorLabel.Location = new System.Drawing.Point(192, 265);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(184, 31);
            this.errorLabel.TabIndex = 6;
            this.errorLabel.Text = "ErrorMessage";
            // 
            // bedragTextbox
            // 
            this.bedragTextbox.Location = new System.Drawing.Point(237, 154);
            this.bedragTextbox.Name = "bedragTextbox";
            this.bedragTextbox.Size = new System.Drawing.Size(92, 20);
            this.bedragTextbox.TabIndex = 7;
            // 
            // Bank
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.bedragTextbox);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.naamLabel);
            this.Controls.Add(this.bevestigButton);
            this.Controls.Add(this.walletLabel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Bank";
            this.Text = "Rekening";
            this.Load += new System.EventHandler(this.Bank_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label walletLabel;
        private System.Windows.Forms.Button bevestigButton;
        private System.Windows.Forms.Label naamLabel;
        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.TextBox bedragTextbox;
    }
}

