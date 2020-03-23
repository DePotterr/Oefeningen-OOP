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
            this.messageLabel = new System.Windows.Forms.Label();
            this.bedragTextbox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // walletLabel
            // 
            this.walletLabel.AutoSize = true;
            this.walletLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.walletLabel.Location = new System.Drawing.Point(15, 47);
            this.walletLabel.Name = "walletLabel";
            this.walletLabel.Size = new System.Drawing.Size(165, 29);
            this.walletLabel.TabIndex = 0;
            this.walletLabel.Text = "Portomonnee";
            // 
            // bevestigButton
            // 
            this.bevestigButton.Location = new System.Drawing.Point(316, 220);
            this.bevestigButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bevestigButton.Name = "bevestigButton";
            this.bevestigButton.Size = new System.Drawing.Size(123, 44);
            this.bevestigButton.TabIndex = 2;
            this.bevestigButton.Text = "Overschrijven/ Afhalen";
            this.bevestigButton.UseVisualStyleBackColor = true;
            this.bevestigButton.Click += new System.EventHandler(this.BevestigButton_Click);
            // 
            // naamLabel
            // 
            this.naamLabel.AutoSize = true;
            this.naamLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.naamLabel.Location = new System.Drawing.Point(15, 11);
            this.naamLabel.Name = "naamLabel";
            this.naamLabel.Size = new System.Drawing.Size(92, 36);
            this.naamLabel.TabIndex = 5;
            this.naamLabel.Text = "Naam";
            // 
            // messageLabel
            // 
            this.messageLabel.AutoSize = true;
            this.messageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.messageLabel.Location = new System.Drawing.Point(309, 325);
            this.messageLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.messageLabel.Name = "messageLabel";
            this.messageLabel.Size = new System.Drawing.Size(155, 39);
            this.messageLabel.TabIndex = 6;
            this.messageLabel.Text = "Message";
            // 
            // bedragTextbox
            // 
            this.bedragTextbox.Location = new System.Drawing.Point(316, 190);
            this.bedragTextbox.Margin = new System.Windows.Forms.Padding(4);
            this.bedragTextbox.Name = "bedragTextbox";
            this.bedragTextbox.Size = new System.Drawing.Size(121, 22);
            this.bedragTextbox.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioButton2);
            this.panel1.Controls.Add(this.radioButton1);
            this.panel1.Location = new System.Drawing.Point(316, 47);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 8;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(4, 7);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(45, 21);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "20";
            this.radioButton1.UseVisualStyleBackColor = true;
//            this.radioButton1.CheckedChanged += new System.EventHandler(this.CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(4, 35);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(45, 21);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "50";
            this.radioButton2.UseVisualStyleBackColor = true;
//            this.radioButton2.CheckedChanged += new System.EventHandler(this.CheckedChanged);
            // 
            // Bank
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bedragTextbox);
            this.Controls.Add(this.messageLabel);
            this.Controls.Add(this.naamLabel);
            this.Controls.Add(this.bevestigButton);
            this.Controls.Add(this.walletLabel);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Bank";
            this.Text = "Rekening";
            this.Load += new System.EventHandler(this.Bank_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label walletLabel;
        private System.Windows.Forms.Button bevestigButton;
        private System.Windows.Forms.Label naamLabel;
        private System.Windows.Forms.Label messageLabel;
        private System.Windows.Forms.TextBox bedragTextbox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
    }
}

