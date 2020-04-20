namespace Herhalingsoef_met_GUI
{
    partial class Form1
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
            this.bewonerLabel = new System.Windows.Forms.Label();
            this.bewonersComboBox = new System.Windows.Forms.ComboBox();
            this.activitetienComboBox = new System.Windows.Forms.ComboBox();
            this.activiteitLabel = new System.Windows.Forms.Label();
            this.datumLabel = new System.Windows.Forms.Label();
            this.dateMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.toevoegenButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bewonerLabel
            // 
            this.bewonerLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bewonerLabel.AutoSize = true;
            this.bewonerLabel.Location = new System.Drawing.Point(36, 35);
            this.bewonerLabel.Name = "bewonerLabel";
            this.bewonerLabel.Size = new System.Drawing.Size(93, 17);
            this.bewonerLabel.TabIndex = 0;
            this.bewonerLabel.Text = "Kies bewoner";
            // 
            // bewonersComboBox
            // 
            this.bewonersComboBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bewonersComboBox.FormattingEnabled = true;
            this.bewonersComboBox.Location = new System.Drawing.Point(39, 55);
            this.bewonersComboBox.Name = "bewonersComboBox";
            this.bewonersComboBox.Size = new System.Drawing.Size(195, 24);
            this.bewonersComboBox.TabIndex = 1;
            // 
            // activitetienComboBox
            // 
            this.activitetienComboBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.activitetienComboBox.FormattingEnabled = true;
            this.activitetienComboBox.Location = new System.Drawing.Point(522, 56);
            this.activitetienComboBox.Name = "activitetienComboBox";
            this.activitetienComboBox.Size = new System.Drawing.Size(195, 24);
            this.activitetienComboBox.TabIndex = 3;
            // 
            // activiteitLabel
            // 
            this.activiteitLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.activiteitLabel.AutoSize = true;
            this.activiteitLabel.Location = new System.Drawing.Point(519, 35);
            this.activiteitLabel.Name = "activiteitLabel";
            this.activiteitLabel.Size = new System.Drawing.Size(90, 17);
            this.activiteitLabel.TabIndex = 2;
            this.activiteitLabel.Text = "Kies activiteit";
            // 
            // datumLabel
            // 
            this.datumLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.datumLabel.AutoSize = true;
            this.datumLabel.Location = new System.Drawing.Point(519, 127);
            this.datumLabel.Name = "datumLabel";
            this.datumLabel.Size = new System.Drawing.Size(78, 17);
            this.datumLabel.TabIndex = 4;
            this.datumLabel.Text = "Kies datum";
            // 
            // dateMaskedTextBox
            // 
            this.dateMaskedTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dateMaskedTextBox.Location = new System.Drawing.Point(522, 147);
            this.dateMaskedTextBox.Mask = "00/00/0000";
            this.dateMaskedTextBox.Name = "dateMaskedTextBox";
            this.dateMaskedTextBox.Size = new System.Drawing.Size(100, 22);
            this.dateMaskedTextBox.TabIndex = 5;
            this.dateMaskedTextBox.ValidatingType = typeof(System.DateTime);
            // 
            // toevoegenButton
            // 
            this.toevoegenButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.toevoegenButton.Location = new System.Drawing.Point(236, 329);
            this.toevoegenButton.Name = "toevoegenButton";
            this.toevoegenButton.Size = new System.Drawing.Size(246, 30);
            this.toevoegenButton.TabIndex = 6;
            this.toevoegenButton.Text = "Voeg activiteit toe";
            this.toevoegenButton.UseVisualStyleBackColor = true;
            this.toevoegenButton.Click += new System.EventHandler(this.ToevoegenButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 419);
            this.Controls.Add(this.toevoegenButton);
            this.Controls.Add(this.dateMaskedTextBox);
            this.Controls.Add(this.datumLabel);
            this.Controls.Add(this.activitetienComboBox);
            this.Controls.Add(this.activiteitLabel);
            this.Controls.Add(this.bewonersComboBox);
            this.Controls.Add(this.bewonerLabel);
            this.MinimumSize = new System.Drawing.Size(760, 466);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label bewonerLabel;
        private System.Windows.Forms.ComboBox bewonersComboBox;
        private System.Windows.Forms.ComboBox activitetienComboBox;
        private System.Windows.Forms.Label activiteitLabel;
        private System.Windows.Forms.Label datumLabel;
        private System.Windows.Forms.MaskedTextBox dateMaskedTextBox;
        private System.Windows.Forms.Button toevoegenButton;
    }
}

