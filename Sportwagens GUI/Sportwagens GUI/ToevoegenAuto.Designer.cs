namespace Sportwagens_GUI
{
    partial class ToevoegenAuto
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
            this.sportwagenRadioButton = new System.Windows.Forms.RadioButton();
            this.gezinswagenRadioButton = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.merkComboBox = new System.Windows.Forms.ComboBox();
            this.merkLabel = new System.Windows.Forms.Label();
            this.typeLabel = new System.Windows.Forms.Label();
            this.typeComboBox = new System.Windows.Forms.ComboBox();
            this.kmTellerNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.kmTellerLabel = new System.Windows.Forms.Label();
            this.IGDDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.nummerplaatTextBox = new System.Windows.Forms.TextBox();
            this.nummerplaatLabel = new System.Windows.Forms.Label();
            this.brandstofverbruikLabel = new System.Windows.Forms.Label();
            this.BrandstofverbruikNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.zitplaatsenLabel = new System.Windows.Forms.Label();
            this.zitplaatsenNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.koffervolumeNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.koffervolumeLabel = new System.Windows.Forms.Label();
            this.pkNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.aantalVitessenNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.pkLabel = new System.Windows.Forms.Label();
            this.aantalVitessenLabel = new System.Windows.Forms.Label();
            this.toevoegenButton = new System.Windows.Forms.Button();
            this.discriptionToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.listView1 = new System.Windows.Forms.ListView();
            this.verwijderenButton = new System.Windows.Forms.Button();
            this.verwijderenNummerplaatTextBox = new System.Windows.Forms.TextBox();
            this.verwijderenNummerplaatLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kmTellerNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BrandstofverbruikNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zitplaatsenNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.koffervolumeNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pkNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aantalVitessenNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // sportwagenRadioButton
            // 
            this.sportwagenRadioButton.AutoSize = true;
            this.sportwagenRadioButton.Location = new System.Drawing.Point(13, 17);
            this.sportwagenRadioButton.Name = "sportwagenRadioButton";
            this.sportwagenRadioButton.Size = new System.Drawing.Size(104, 21);
            this.sportwagenRadioButton.TabIndex = 0;
            this.sportwagenRadioButton.Text = "Sportwagen";
            this.sportwagenRadioButton.UseVisualStyleBackColor = true;
            this.sportwagenRadioButton.CheckedChanged += new System.EventHandler(this.CheckedChanged);
            // 
            // gezinswagenRadioButton
            // 
            this.gezinswagenRadioButton.AutoSize = true;
            this.gezinswagenRadioButton.Location = new System.Drawing.Point(13, 44);
            this.gezinswagenRadioButton.Name = "gezinswagenRadioButton";
            this.gezinswagenRadioButton.Size = new System.Drawing.Size(114, 21);
            this.gezinswagenRadioButton.TabIndex = 1;
            this.gezinswagenRadioButton.Text = "Gezinswagen";
            this.gezinswagenRadioButton.UseVisualStyleBackColor = true;
            this.gezinswagenRadioButton.CheckedChanged += new System.EventHandler(this.CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gezinswagenRadioButton);
            this.panel1.Controls.Add(this.sportwagenRadioButton);
            this.panel1.Location = new System.Drawing.Point(148, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(132, 76);
            this.panel1.TabIndex = 2;
            // 
            // merkComboBox
            // 
            this.merkComboBox.FormattingEnabled = true;
            this.merkComboBox.Location = new System.Drawing.Point(159, 112);
            this.merkComboBox.Name = "merkComboBox";
            this.merkComboBox.Size = new System.Drawing.Size(121, 24);
            this.merkComboBox.TabIndex = 3;
            // 
            // merkLabel
            // 
            this.merkLabel.AutoSize = true;
            this.merkLabel.Location = new System.Drawing.Point(27, 115);
            this.merkLabel.Name = "merkLabel";
            this.merkLabel.Size = new System.Drawing.Size(39, 17);
            this.merkLabel.TabIndex = 4;
            this.merkLabel.Text = "Merk";
            // 
            // typeLabel
            // 
            this.typeLabel.AutoSize = true;
            this.typeLabel.Location = new System.Drawing.Point(27, 145);
            this.typeLabel.Name = "typeLabel";
            this.typeLabel.Size = new System.Drawing.Size(40, 17);
            this.typeLabel.TabIndex = 5;
            this.typeLabel.Text = "Type";
            // 
            // typeComboBox
            // 
            this.typeComboBox.FormattingEnabled = true;
            this.typeComboBox.Location = new System.Drawing.Point(159, 142);
            this.typeComboBox.Name = "typeComboBox";
            this.typeComboBox.Size = new System.Drawing.Size(121, 24);
            this.typeComboBox.TabIndex = 6;
            // 
            // kmTellerNumericUpDown
            // 
            this.kmTellerNumericUpDown.Location = new System.Drawing.Point(159, 173);
            this.kmTellerNumericUpDown.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.kmTellerNumericUpDown.Name = "kmTellerNumericUpDown";
            this.kmTellerNumericUpDown.Size = new System.Drawing.Size(121, 22);
            this.kmTellerNumericUpDown.TabIndex = 7;
            // 
            // kmTellerLabel
            // 
            this.kmTellerLabel.AutoSize = true;
            this.kmTellerLabel.Location = new System.Drawing.Point(27, 175);
            this.kmTellerLabel.Name = "kmTellerLabel";
            this.kmTellerLabel.Size = new System.Drawing.Size(64, 17);
            this.kmTellerLabel.TabIndex = 8;
            this.kmTellerLabel.Text = "KmTeller";
            // 
            // IGDDateTimePicker
            // 
            this.IGDDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.IGDDateTimePicker.Location = new System.Drawing.Point(159, 201);
            this.IGDDateTimePicker.MaxDate = new System.DateTime(2020, 3, 30, 13, 39, 20, 0);
            this.IGDDateTimePicker.Name = "IGDDateTimePicker";
            this.IGDDateTimePicker.Size = new System.Drawing.Size(121, 22);
            this.IGDDateTimePicker.TabIndex = 9;
            this.IGDDateTimePicker.Value = new System.DateTime(2020, 3, 30, 0, 0, 0, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 206);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "In gebruik datum";
            // 
            // nummerplaatTextBox
            // 
            this.nummerplaatTextBox.Location = new System.Drawing.Point(159, 229);
            this.nummerplaatTextBox.Name = "nummerplaatTextBox";
            this.nummerplaatTextBox.Size = new System.Drawing.Size(121, 22);
            this.nummerplaatTextBox.TabIndex = 11;
//            this.nummerplaatTextBox.TextChanged += new System.EventHandler(this.NummerplaatTextBox_TextChanged);
            // 
            // nummerplaatLabel
            // 
            this.nummerplaatLabel.AutoSize = true;
            this.nummerplaatLabel.Location = new System.Drawing.Point(27, 232);
            this.nummerplaatLabel.Name = "nummerplaatLabel";
            this.nummerplaatLabel.Size = new System.Drawing.Size(92, 17);
            this.nummerplaatLabel.TabIndex = 12;
            this.nummerplaatLabel.Text = "Nummerplaat";
            // 
            // brandstofverbruikLabel
            // 
            this.brandstofverbruikLabel.AutoSize = true;
            this.brandstofverbruikLabel.Location = new System.Drawing.Point(27, 260);
            this.brandstofverbruikLabel.Name = "brandstofverbruikLabel";
            this.brandstofverbruikLabel.Size = new System.Drawing.Size(120, 17);
            this.brandstofverbruikLabel.TabIndex = 13;
            this.brandstofverbruikLabel.Text = "Brandstofverbruik";
            // 
            // BrandstofverbruikNumericUpDown
            // 
            this.BrandstofverbruikNumericUpDown.Location = new System.Drawing.Point(159, 258);
            this.BrandstofverbruikNumericUpDown.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.BrandstofverbruikNumericUpDown.Name = "BrandstofverbruikNumericUpDown";
            this.BrandstofverbruikNumericUpDown.Size = new System.Drawing.Size(121, 22);
            this.BrandstofverbruikNumericUpDown.TabIndex = 14;
            // 
            // zitplaatsenLabel
            // 
            this.zitplaatsenLabel.AutoSize = true;
            this.zitplaatsenLabel.Location = new System.Drawing.Point(27, 303);
            this.zitplaatsenLabel.Name = "zitplaatsenLabel";
            this.zitplaatsenLabel.Size = new System.Drawing.Size(78, 17);
            this.zitplaatsenLabel.TabIndex = 15;
            this.zitplaatsenLabel.Text = "Zitplaatsen";
            // 
            // zitplaatsenNumericUpDown
            // 
            this.zitplaatsenNumericUpDown.Location = new System.Drawing.Point(159, 301);
            this.zitplaatsenNumericUpDown.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.zitplaatsenNumericUpDown.Name = "zitplaatsenNumericUpDown";
            this.zitplaatsenNumericUpDown.Size = new System.Drawing.Size(120, 22);
            this.zitplaatsenNumericUpDown.TabIndex = 16;
            // 
            // koffervolumeNumericUpDown
            // 
            this.koffervolumeNumericUpDown.Location = new System.Drawing.Point(159, 329);
            this.koffervolumeNumericUpDown.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.koffervolumeNumericUpDown.Name = "koffervolumeNumericUpDown";
            this.koffervolumeNumericUpDown.Size = new System.Drawing.Size(120, 22);
            this.koffervolumeNumericUpDown.TabIndex = 17;
            // 
            // koffervolumeLabel
            // 
            this.koffervolumeLabel.AutoSize = true;
            this.koffervolumeLabel.Location = new System.Drawing.Point(27, 331);
            this.koffervolumeLabel.Name = "koffervolumeLabel";
            this.koffervolumeLabel.Size = new System.Drawing.Size(91, 17);
            this.koffervolumeLabel.TabIndex = 18;
            this.koffervolumeLabel.Text = "Koffervolume";
            // 
            // pkNumericUpDown
            // 
            this.pkNumericUpDown.Location = new System.Drawing.Point(159, 373);
            this.pkNumericUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.pkNumericUpDown.Name = "pkNumericUpDown";
            this.pkNumericUpDown.Size = new System.Drawing.Size(120, 22);
            this.pkNumericUpDown.TabIndex = 19;
            // 
            // aantalVitessenNumericUpDown
            // 
            this.aantalVitessenNumericUpDown.Location = new System.Drawing.Point(159, 401);
            this.aantalVitessenNumericUpDown.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.aantalVitessenNumericUpDown.Name = "aantalVitessenNumericUpDown";
            this.aantalVitessenNumericUpDown.Size = new System.Drawing.Size(120, 22);
            this.aantalVitessenNumericUpDown.TabIndex = 20;
            // 
            // pkLabel
            // 
            this.pkLabel.AutoSize = true;
            this.pkLabel.Location = new System.Drawing.Point(28, 375);
            this.pkLabel.Name = "pkLabel";
            this.pkLabel.Size = new System.Drawing.Size(26, 17);
            this.pkLabel.TabIndex = 21;
            this.pkLabel.Text = "PK";
            // 
            // aantalVitessenLabel
            // 
            this.aantalVitessenLabel.AutoSize = true;
            this.aantalVitessenLabel.Location = new System.Drawing.Point(28, 403);
            this.aantalVitessenLabel.Name = "aantalVitessenLabel";
            this.aantalVitessenLabel.Size = new System.Drawing.Size(106, 17);
            this.aantalVitessenLabel.TabIndex = 22;
            this.aantalVitessenLabel.Text = "Aantal Vitessen";
            // 
            // toevoegenButton
            // 
            this.toevoegenButton.Location = new System.Drawing.Point(321, 374);
            this.toevoegenButton.Name = "toevoegenButton";
            this.toevoegenButton.Size = new System.Drawing.Size(121, 49);
            this.toevoegenButton.TabIndex = 23;
            this.toevoegenButton.Text = "Toevoegen";
            this.toevoegenButton.UseVisualStyleBackColor = true;
            this.toevoegenButton.Click += new System.EventHandler(this.ToevoegenButton_Click);
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(321, 12);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(467, 357);
            this.listView1.TabIndex = 24;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // verwijderenButton
            // 
            this.verwijderenButton.Location = new System.Drawing.Point(667, 375);
            this.verwijderenButton.Name = "verwijderenButton";
            this.verwijderenButton.Size = new System.Drawing.Size(121, 49);
            this.verwijderenButton.TabIndex = 25;
            this.verwijderenButton.Text = "Verwijderen";
            this.verwijderenButton.UseVisualStyleBackColor = true;
            this.verwijderenButton.Click += new System.EventHandler(this.VerwijderenButton_Click);
            // 
            // verwijderenNummerplaatTextBox
            // 
            this.verwijderenNummerplaatTextBox.Location = new System.Drawing.Point(540, 400);
            this.verwijderenNummerplaatTextBox.Name = "verwijderenNummerplaatTextBox";
            this.verwijderenNummerplaatTextBox.Size = new System.Drawing.Size(121, 22);
            this.verwijderenNummerplaatTextBox.TabIndex = 26;
            // 
            // verwijderenNummerplaatLabel
            // 
            this.verwijderenNummerplaatLabel.AutoSize = true;
            this.verwijderenNummerplaatLabel.Location = new System.Drawing.Point(537, 380);
            this.verwijderenNummerplaatLabel.Name = "verwijderenNummerplaatLabel";
            this.verwijderenNummerplaatLabel.Size = new System.Drawing.Size(92, 17);
            this.verwijderenNummerplaatLabel.TabIndex = 27;
            this.verwijderenNummerplaatLabel.Text = "Nummerplaat";
            // 
            // ToevoegenAuto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.verwijderenNummerplaatLabel);
            this.Controls.Add(this.verwijderenNummerplaatTextBox);
            this.Controls.Add(this.verwijderenButton);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.toevoegenButton);
            this.Controls.Add(this.aantalVitessenLabel);
            this.Controls.Add(this.pkLabel);
            this.Controls.Add(this.aantalVitessenNumericUpDown);
            this.Controls.Add(this.pkNumericUpDown);
            this.Controls.Add(this.koffervolumeLabel);
            this.Controls.Add(this.koffervolumeNumericUpDown);
            this.Controls.Add(this.zitplaatsenNumericUpDown);
            this.Controls.Add(this.zitplaatsenLabel);
            this.Controls.Add(this.BrandstofverbruikNumericUpDown);
            this.Controls.Add(this.brandstofverbruikLabel);
            this.Controls.Add(this.nummerplaatLabel);
            this.Controls.Add(this.nummerplaatTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.IGDDateTimePicker);
            this.Controls.Add(this.kmTellerLabel);
            this.Controls.Add(this.kmTellerNumericUpDown);
            this.Controls.Add(this.typeComboBox);
            this.Controls.Add(this.typeLabel);
            this.Controls.Add(this.merkLabel);
            this.Controls.Add(this.merkComboBox);
            this.Controls.Add(this.panel1);
            this.Name = "ToevoegenAuto";
            this.Text = "Toevoegen auto";
            this.Load += new System.EventHandler(this.ToevoegenAuto_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kmTellerNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BrandstofverbruikNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zitplaatsenNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.koffervolumeNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pkNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aantalVitessenNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton sportwagenRadioButton;
        private System.Windows.Forms.RadioButton gezinswagenRadioButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox merkComboBox;
        private System.Windows.Forms.Label merkLabel;
        private System.Windows.Forms.Label typeLabel;
        private System.Windows.Forms.ComboBox typeComboBox;
        private System.Windows.Forms.NumericUpDown kmTellerNumericUpDown;
        private System.Windows.Forms.Label kmTellerLabel;
        private System.Windows.Forms.DateTimePicker IGDDateTimePicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nummerplaatTextBox;
        private System.Windows.Forms.Label nummerplaatLabel;
        private System.Windows.Forms.Label brandstofverbruikLabel;
        private System.Windows.Forms.NumericUpDown BrandstofverbruikNumericUpDown;
        private System.Windows.Forms.Label zitplaatsenLabel;
        private System.Windows.Forms.NumericUpDown zitplaatsenNumericUpDown;
        private System.Windows.Forms.NumericUpDown koffervolumeNumericUpDown;
        private System.Windows.Forms.Label koffervolumeLabel;
        private System.Windows.Forms.NumericUpDown pkNumericUpDown;
        private System.Windows.Forms.NumericUpDown aantalVitessenNumericUpDown;
        private System.Windows.Forms.Label pkLabel;
        private System.Windows.Forms.Label aantalVitessenLabel;
        private System.Windows.Forms.Button toevoegenButton;
        private System.Windows.Forms.ToolTip discriptionToolTip;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button verwijderenButton;
        private System.Windows.Forms.TextBox verwijderenNummerplaatTextBox;
        private System.Windows.Forms.Label verwijderenNummerplaatLabel;
    }
}

