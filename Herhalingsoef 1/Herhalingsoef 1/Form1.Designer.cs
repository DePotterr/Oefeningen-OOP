namespace Herhalingsoef_1
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
            this.voornaamTextBox = new System.Windows.Forms.TextBox();
            this.naamTextBox = new System.Windows.Forms.TextBox();
            this.adresTextBox = new System.Windows.Forms.TextBox();
            this.statuutCheckBox = new System.Windows.Forms.CheckBox();
            this.faciliteitenComboBox = new System.Windows.Forms.ComboBox();
            this.toevoegenButton = new System.Windows.Forms.Button();
            this.geslachtComboBox = new System.Windows.Forms.ComboBox();
            this.voornaamLabelTonen = new System.Windows.Forms.Label();
            this.naamLabelTonen = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PreviousButton = new System.Windows.Forms.Button();
            this.nextButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.faciliteitLabelTonen = new System.Windows.Forms.Label();
            this.studentennrLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // voornaamTextBox
            // 
            this.voornaamTextBox.Location = new System.Drawing.Point(90, 41);
            this.voornaamTextBox.Name = "voornaamTextBox";
            this.voornaamTextBox.Size = new System.Drawing.Size(174, 22);
            this.voornaamTextBox.TabIndex = 1;
            // 
            // naamTextBox
            // 
            this.naamTextBox.Location = new System.Drawing.Point(90, 69);
            this.naamTextBox.Name = "naamTextBox";
            this.naamTextBox.Size = new System.Drawing.Size(174, 22);
            this.naamTextBox.TabIndex = 2;
            // 
            // adresTextBox
            // 
            this.adresTextBox.Location = new System.Drawing.Point(90, 97);
            this.adresTextBox.Name = "adresTextBox";
            this.adresTextBox.Size = new System.Drawing.Size(174, 22);
            this.adresTextBox.TabIndex = 3;
            // 
            // statuutCheckBox
            // 
            this.statuutCheckBox.AutoSize = true;
            this.statuutCheckBox.Location = new System.Drawing.Point(89, 155);
            this.statuutCheckBox.Name = "statuutCheckBox";
            this.statuutCheckBox.Size = new System.Drawing.Size(175, 21);
            this.statuutCheckBox.TabIndex = 4;
            this.statuutCheckBox.Text = "Heeft speciaal statuut?";
            this.statuutCheckBox.UseVisualStyleBackColor = true;
            this.statuutCheckBox.CheckedChanged += new System.EventHandler(this.StatuutCheckBox_CheckedChanged);
            // 
            // faciliteitenComboBox
            // 
            this.faciliteitenComboBox.FormattingEnabled = true;
            this.faciliteitenComboBox.Location = new System.Drawing.Point(89, 182);
            this.faciliteitenComboBox.Name = "faciliteitenComboBox";
            this.faciliteitenComboBox.Size = new System.Drawing.Size(175, 24);
            this.faciliteitenComboBox.TabIndex = 5;
            // 
            // toevoegenButton
            // 
            this.toevoegenButton.Location = new System.Drawing.Point(89, 213);
            this.toevoegenButton.Name = "toevoegenButton";
            this.toevoegenButton.Size = new System.Drawing.Size(175, 40);
            this.toevoegenButton.TabIndex = 6;
            this.toevoegenButton.Text = "Maak student aan";
            this.toevoegenButton.UseVisualStyleBackColor = true;
            this.toevoegenButton.Click += new System.EventHandler(this.ToevoegenButton_Click);
            // 
            // geslachtComboBox
            // 
            this.geslachtComboBox.FormattingEnabled = true;
            this.geslachtComboBox.Location = new System.Drawing.Point(90, 125);
            this.geslachtComboBox.Name = "geslachtComboBox";
            this.geslachtComboBox.Size = new System.Drawing.Size(174, 24);
            this.geslachtComboBox.TabIndex = 7;
            // 
            // voornaamLabelTonen
            // 
            this.voornaamLabelTonen.AutoSize = true;
            this.voornaamLabelTonen.Location = new System.Drawing.Point(9, 9);
            this.voornaamLabelTonen.Name = "voornaamLabelTonen";
            this.voornaamLabelTonen.Size = new System.Drawing.Size(73, 17);
            this.voornaamLabelTonen.TabIndex = 8;
            this.voornaamLabelTonen.Text = "Voornaam";
            // 
            // naamLabelTonen
            // 
            this.naamLabelTonen.AutoSize = true;
            this.naamLabelTonen.Location = new System.Drawing.Point(9, 26);
            this.naamLabelTonen.Name = "naamLabelTonen";
            this.naamLabelTonen.Size = new System.Drawing.Size(45, 17);
            this.naamLabelTonen.TabIndex = 9;
            this.naamLabelTonen.Text = "Naam";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.studentennrLabel);
            this.panel1.Controls.Add(this.faciliteitLabelTonen);
            this.panel1.Controls.Add(this.naamLabelTonen);
            this.panel1.Controls.Add(this.voornaamLabelTonen);
            this.panel1.Location = new System.Drawing.Point(398, 41);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(234, 121);
            this.panel1.TabIndex = 10;
            // 
            // PreviousButton
            // 
            this.PreviousButton.Location = new System.Drawing.Point(398, 213);
            this.PreviousButton.Name = "PreviousButton";
            this.PreviousButton.Size = new System.Drawing.Size(114, 39);
            this.PreviousButton.TabIndex = 11;
            this.PreviousButton.Text = "Previous";
            this.PreviousButton.UseVisualStyleBackColor = true;
            this.PreviousButton.Click += new System.EventHandler(this.PreviousButton_Click);
            // 
            // nextButton
            // 
            this.nextButton.Location = new System.Drawing.Point(518, 213);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(114, 39);
            this.nextButton.TabIndex = 12;
            this.nextButton.Text = "Next";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "Voornaam";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "Naam";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 17);
            this.label5.TabIndex = 15;
            this.label5.Text = "Adres";
            // 
            // faciliteitLabelTonen
            // 
            this.faciliteitLabelTonen.AutoSize = true;
            this.faciliteitLabelTonen.Location = new System.Drawing.Point(9, 43);
            this.faciliteitLabelTonen.Name = "faciliteitLabelTonen";
            this.faciliteitLabelTonen.Size = new System.Drawing.Size(59, 17);
            this.faciliteitLabelTonen.TabIndex = 10;
            this.faciliteitLabelTonen.Text = "Faciliteit";
            // 
            // studentennrLabel
            // 
            this.studentennrLabel.AutoSize = true;
            this.studentennrLabel.Location = new System.Drawing.Point(9, 91);
            this.studentennrLabel.Name = "studentennrLabel";
            this.studentennrLabel.Size = new System.Drawing.Size(86, 17);
            this.studentennrLabel.TabIndex = 11;
            this.studentennrLabel.Text = "Studentennr";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1258, 567);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.PreviousButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.geslachtComboBox);
            this.Controls.Add(this.toevoegenButton);
            this.Controls.Add(this.faciliteitenComboBox);
            this.Controls.Add(this.statuutCheckBox);
            this.Controls.Add(this.adresTextBox);
            this.Controls.Add(this.naamTextBox);
            this.Controls.Add(this.voornaamTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox voornaamTextBox;
        private System.Windows.Forms.TextBox naamTextBox;
        private System.Windows.Forms.TextBox adresTextBox;
        private System.Windows.Forms.CheckBox statuutCheckBox;
        private System.Windows.Forms.ComboBox faciliteitenComboBox;
        private System.Windows.Forms.Button toevoegenButton;
        private System.Windows.Forms.ComboBox geslachtComboBox;
        private System.Windows.Forms.Label voornaamLabelTonen;
        private System.Windows.Forms.Label naamLabelTonen;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button PreviousButton;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label faciliteitLabelTonen;
        private System.Windows.Forms.Label studentennrLabel;
    }
}

