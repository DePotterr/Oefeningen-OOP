namespace Examen_school_meldingen
{
    partial class MeldingenAP
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
            this.medewerkerLabel = new System.Windows.Forms.Label();
            this.titelTextBox = new System.Windows.Forms.TextBox();
            this.medewerkerComboBox = new System.Windows.Forms.ComboBox();
            this.titelLabel = new System.Windows.Forms.Label();
            this.soortLabel = new System.Windows.Forms.Label();
            this.beschrijvingLabel = new System.Windows.Forms.Label();
            this.beschrijvingTextBox = new System.Windows.Forms.TextBox();
            this.radiobuttunsPanel = new System.Windows.Forms.Panel();
            this.defectRadioButton = new System.Windows.Forms.RadioButton();
            this.opdrachtRadioButton = new System.Windows.Forms.RadioButton();
            this.datumDeadlineLabel = new System.Windows.Forms.Label();
            this.deadlineMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.prioriteitLabel = new System.Windows.Forms.Label();
            this.prioriteitComboBox = new System.Windows.Forms.ComboBox();
            this.toevoegenButton = new System.Windows.Forms.Button();
            this.meldingenLabel = new System.Windows.Forms.Label();
            this.meldingenComboBox = new System.Windows.Forms.ComboBox();
            this.wisGeslotenButton = new System.Windows.Forms.Button();
            this.sluitenButton = new System.Windows.Forms.Button();
            this.meldingInfoTextBox = new System.Windows.Forms.TextBox();
            this.radiobuttunsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // medewerkerLabel
            // 
            this.medewerkerLabel.AutoSize = true;
            this.medewerkerLabel.Location = new System.Drawing.Point(13, 13);
            this.medewerkerLabel.Name = "medewerkerLabel";
            this.medewerkerLabel.Size = new System.Drawing.Size(85, 17);
            this.medewerkerLabel.TabIndex = 0;
            this.medewerkerLabel.Text = "Medewerker";
            // 
            // titelTextBox
            // 
            this.titelTextBox.Location = new System.Drawing.Point(103, 56);
            this.titelTextBox.Name = "titelTextBox";
            this.titelTextBox.Size = new System.Drawing.Size(171, 22);
            this.titelTextBox.TabIndex = 1;
            // 
            // medewerkerComboBox
            // 
            this.medewerkerComboBox.FormattingEnabled = true;
            this.medewerkerComboBox.Location = new System.Drawing.Point(103, 10);
            this.medewerkerComboBox.Name = "medewerkerComboBox";
            this.medewerkerComboBox.Size = new System.Drawing.Size(121, 24);
            this.medewerkerComboBox.TabIndex = 2;
            this.medewerkerComboBox.SelectedIndexChanged += new System.EventHandler(this.MedewerkerComboBox_SelectedIndexChanged);
            // 
            // titelLabel
            // 
            this.titelLabel.AutoSize = true;
            this.titelLabel.Location = new System.Drawing.Point(13, 59);
            this.titelLabel.Name = "titelLabel";
            this.titelLabel.Size = new System.Drawing.Size(35, 17);
            this.titelLabel.TabIndex = 3;
            this.titelLabel.Text = "Titel";
            // 
            // soortLabel
            // 
            this.soortLabel.AutoSize = true;
            this.soortLabel.Location = new System.Drawing.Point(13, 218);
            this.soortLabel.Name = "soortLabel";
            this.soortLabel.Size = new System.Drawing.Size(42, 17);
            this.soortLabel.TabIndex = 5;
            this.soortLabel.Text = "Soort";
            // 
            // beschrijvingLabel
            // 
            this.beschrijvingLabel.AutoSize = true;
            this.beschrijvingLabel.Location = new System.Drawing.Point(13, 111);
            this.beschrijvingLabel.Name = "beschrijvingLabel";
            this.beschrijvingLabel.Size = new System.Drawing.Size(84, 17);
            this.beschrijvingLabel.TabIndex = 4;
            this.beschrijvingLabel.Text = "Beschrijving";
            // 
            // beschrijvingTextBox
            // 
            this.beschrijvingTextBox.Location = new System.Drawing.Point(103, 108);
            this.beschrijvingTextBox.Multiline = true;
            this.beschrijvingTextBox.Name = "beschrijvingTextBox";
            this.beschrijvingTextBox.Size = new System.Drawing.Size(171, 86);
            this.beschrijvingTextBox.TabIndex = 6;
            // 
            // radiobuttunsPanel
            // 
            this.radiobuttunsPanel.Controls.Add(this.defectRadioButton);
            this.radiobuttunsPanel.Controls.Add(this.opdrachtRadioButton);
            this.radiobuttunsPanel.Location = new System.Drawing.Point(103, 218);
            this.radiobuttunsPanel.Name = "radiobuttunsPanel";
            this.radiobuttunsPanel.Size = new System.Drawing.Size(121, 65);
            this.radiobuttunsPanel.TabIndex = 7;
            // 
            // defectRadioButton
            // 
            this.defectRadioButton.AutoSize = true;
            this.defectRadioButton.Location = new System.Drawing.Point(4, 31);
            this.defectRadioButton.Name = "defectRadioButton";
            this.defectRadioButton.Size = new System.Drawing.Size(70, 21);
            this.defectRadioButton.TabIndex = 1;
            this.defectRadioButton.TabStop = true;
            this.defectRadioButton.Text = "Defect";
            this.defectRadioButton.UseVisualStyleBackColor = true;
            // 
            // opdrachtRadioButton
            // 
            this.opdrachtRadioButton.AutoSize = true;
            this.opdrachtRadioButton.Location = new System.Drawing.Point(4, 4);
            this.opdrachtRadioButton.Name = "opdrachtRadioButton";
            this.opdrachtRadioButton.Size = new System.Drawing.Size(88, 21);
            this.opdrachtRadioButton.TabIndex = 0;
            this.opdrachtRadioButton.TabStop = true;
            this.opdrachtRadioButton.Text = "Opdracht";
            this.opdrachtRadioButton.UseVisualStyleBackColor = true;
            this.opdrachtRadioButton.CheckedChanged += new System.EventHandler(this.OpdrachtRadioButton_CheckedChanged);
            // 
            // datumDeadlineLabel
            // 
            this.datumDeadlineLabel.AutoSize = true;
            this.datumDeadlineLabel.Location = new System.Drawing.Point(13, 308);
            this.datumDeadlineLabel.Name = "datumDeadlineLabel";
            this.datumDeadlineLabel.Size = new System.Drawing.Size(64, 17);
            this.datumDeadlineLabel.TabIndex = 8;
            this.datumDeadlineLabel.Text = "Deadline";
            // 
            // deadlineMaskedTextBox
            // 
            this.deadlineMaskedTextBox.Location = new System.Drawing.Point(103, 305);
            this.deadlineMaskedTextBox.Mask = "00/00/0000";
            this.deadlineMaskedTextBox.Name = "deadlineMaskedTextBox";
            this.deadlineMaskedTextBox.Size = new System.Drawing.Size(100, 22);
            this.deadlineMaskedTextBox.TabIndex = 9;
            this.deadlineMaskedTextBox.ValidatingType = typeof(System.DateTime);
            // 
            // prioriteitLabel
            // 
            this.prioriteitLabel.AutoSize = true;
            this.prioriteitLabel.Location = new System.Drawing.Point(13, 351);
            this.prioriteitLabel.Name = "prioriteitLabel";
            this.prioriteitLabel.Size = new System.Drawing.Size(60, 17);
            this.prioriteitLabel.TabIndex = 10;
            this.prioriteitLabel.Text = "Prioriteit";
            // 
            // prioriteitComboBox
            // 
            this.prioriteitComboBox.FormattingEnabled = true;
            this.prioriteitComboBox.Location = new System.Drawing.Point(103, 348);
            this.prioriteitComboBox.Name = "prioriteitComboBox";
            this.prioriteitComboBox.Size = new System.Drawing.Size(121, 24);
            this.prioriteitComboBox.TabIndex = 11;
            // 
            // toevoegenButton
            // 
            this.toevoegenButton.Location = new System.Drawing.Point(16, 412);
            this.toevoegenButton.Name = "toevoegenButton";
            this.toevoegenButton.Size = new System.Drawing.Size(94, 26);
            this.toevoegenButton.TabIndex = 12;
            this.toevoegenButton.Text = "Toevoegen";
            this.toevoegenButton.UseVisualStyleBackColor = true;
            this.toevoegenButton.Click += new System.EventHandler(this.ToevoegenButton_Click);
            // 
            // meldingenLabel
            // 
            this.meldingenLabel.AutoSize = true;
            this.meldingenLabel.Location = new System.Drawing.Point(406, 13);
            this.meldingenLabel.Name = "meldingenLabel";
            this.meldingenLabel.Size = new System.Drawing.Size(73, 17);
            this.meldingenLabel.TabIndex = 13;
            this.meldingenLabel.Text = "Meldingen";
            // 
            // meldingenComboBox
            // 
            this.meldingenComboBox.FormattingEnabled = true;
            this.meldingenComboBox.Location = new System.Drawing.Point(485, 10);
            this.meldingenComboBox.Name = "meldingenComboBox";
            this.meldingenComboBox.Size = new System.Drawing.Size(121, 24);
            this.meldingenComboBox.TabIndex = 15;
            this.meldingenComboBox.SelectedIndexChanged += new System.EventHandler(this.MeldingenComboBox_SelectedIndexChanged);
            // 
            // wisGeslotenButton
            // 
            this.wisGeslotenButton.Location = new System.Drawing.Point(669, 8);
            this.wisGeslotenButton.Name = "wisGeslotenButton";
            this.wisGeslotenButton.Size = new System.Drawing.Size(119, 26);
            this.wisGeslotenButton.TabIndex = 16;
            this.wisGeslotenButton.Text = "Wis Gesloten";
            this.wisGeslotenButton.UseVisualStyleBackColor = true;
            this.wisGeslotenButton.Click += new System.EventHandler(this.WisGeslotenButton_Click);
            // 
            // sluitenButton
            // 
            this.sluitenButton.Location = new System.Drawing.Point(409, 249);
            this.sluitenButton.Name = "sluitenButton";
            this.sluitenButton.Size = new System.Drawing.Size(94, 26);
            this.sluitenButton.TabIndex = 17;
            this.sluitenButton.Text = "Sluiten";
            this.sluitenButton.UseVisualStyleBackColor = true;
            this.sluitenButton.Click += new System.EventHandler(this.SluitenButton_Click);
            // 
            // meldingInfoTextBox
            // 
            this.meldingInfoTextBox.Location = new System.Drawing.Point(409, 56);
            this.meldingInfoTextBox.Multiline = true;
            this.meldingInfoTextBox.Name = "meldingInfoTextBox";
            this.meldingInfoTextBox.ReadOnly = true;
            this.meldingInfoTextBox.Size = new System.Drawing.Size(379, 187);
            this.meldingInfoTextBox.TabIndex = 18;
            // 
            // MeldingenAP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.meldingInfoTextBox);
            this.Controls.Add(this.sluitenButton);
            this.Controls.Add(this.wisGeslotenButton);
            this.Controls.Add(this.meldingenComboBox);
            this.Controls.Add(this.meldingenLabel);
            this.Controls.Add(this.toevoegenButton);
            this.Controls.Add(this.prioriteitComboBox);
            this.Controls.Add(this.prioriteitLabel);
            this.Controls.Add(this.deadlineMaskedTextBox);
            this.Controls.Add(this.datumDeadlineLabel);
            this.Controls.Add(this.radiobuttunsPanel);
            this.Controls.Add(this.beschrijvingTextBox);
            this.Controls.Add(this.soortLabel);
            this.Controls.Add(this.beschrijvingLabel);
            this.Controls.Add(this.titelLabel);
            this.Controls.Add(this.medewerkerComboBox);
            this.Controls.Add(this.titelTextBox);
            this.Controls.Add(this.medewerkerLabel);
            this.MinimumSize = new System.Drawing.Size(818, 497);
            this.Name = "MeldingenAP";
            this.Text = "MeldingenAP";
            this.Load += new System.EventHandler(this.MeldingenAP_Load);
            this.radiobuttunsPanel.ResumeLayout(false);
            this.radiobuttunsPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label medewerkerLabel;
        private System.Windows.Forms.TextBox titelTextBox;
        private System.Windows.Forms.ComboBox medewerkerComboBox;
        private System.Windows.Forms.Label titelLabel;
        private System.Windows.Forms.Label soortLabel;
        private System.Windows.Forms.Label beschrijvingLabel;
        private System.Windows.Forms.TextBox beschrijvingTextBox;
        private System.Windows.Forms.Panel radiobuttunsPanel;
        private System.Windows.Forms.RadioButton defectRadioButton;
        private System.Windows.Forms.RadioButton opdrachtRadioButton;
        private System.Windows.Forms.Label datumDeadlineLabel;
        private System.Windows.Forms.MaskedTextBox deadlineMaskedTextBox;
        private System.Windows.Forms.Label prioriteitLabel;
        private System.Windows.Forms.ComboBox prioriteitComboBox;
        private System.Windows.Forms.Button toevoegenButton;
        private System.Windows.Forms.Label meldingenLabel;
        private System.Windows.Forms.ComboBox meldingenComboBox;
        private System.Windows.Forms.Button wisGeslotenButton;
        private System.Windows.Forms.Button sluitenButton;
        private System.Windows.Forms.TextBox meldingInfoTextBox;
    }
}

