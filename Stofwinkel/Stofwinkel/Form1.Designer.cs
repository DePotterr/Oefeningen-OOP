namespace Stofwinkel
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
            this.katoenstofRadioButoon = new System.Windows.Forms.RadioButton();
            this.stretchstofRadioButton = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.stoffenListBox = new System.Windows.Forms.ListBox();
            this.toevoegenButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.bioCheckBox = new System.Windows.Forms.CheckBox();
            this.droogkastCheckBox = new System.Windows.Forms.CheckBox();
            this.panel9 = new System.Windows.Forms.Panel();
            this.stretchPercNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.stretchPercLabel = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.kwaliteitsComboBox = new System.Windows.Forms.ComboBox();
            this.kwaliteitsLabel = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.krimpPerNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.krimpPerLabel = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.PrijsPerMeternumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.prijsPerMeterLabel = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.designlabelTextbox = new System.Windows.Forms.TextBox();
            this.designLabel = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.naamTextbox = new System.Windows.Forms.TextBox();
            this.naamLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stretchPercNumericUpDown)).BeginInit();
            this.panel8.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.krimpPerNumericUpDown)).BeginInit();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PrijsPerMeternumericUpDown)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // katoenstofRadioButoon
            // 
            this.katoenstofRadioButoon.AutoSize = true;
            this.katoenstofRadioButoon.Location = new System.Drawing.Point(12, 12);
            this.katoenstofRadioButoon.Name = "katoenstofRadioButoon";
            this.katoenstofRadioButoon.Size = new System.Drawing.Size(97, 21);
            this.katoenstofRadioButoon.TabIndex = 0;
            this.katoenstofRadioButoon.TabStop = true;
            this.katoenstofRadioButoon.Text = "Katoenstof";
            this.katoenstofRadioButoon.UseVisualStyleBackColor = true;
            this.katoenstofRadioButoon.CheckedChanged += new System.EventHandler(this.CheckedChanged);
            // 
            // stretchstofRadioButton
            // 
            this.stretchstofRadioButton.AutoSize = true;
            this.stretchstofRadioButton.Location = new System.Drawing.Point(12, 40);
            this.stretchstofRadioButton.Name = "stretchstofRadioButton";
            this.stretchstofRadioButton.Size = new System.Drawing.Size(97, 21);
            this.stretchstofRadioButton.TabIndex = 1;
            this.stretchstofRadioButton.TabStop = true;
            this.stretchstofRadioButton.Text = "Stretchstof";
            this.stretchstofRadioButton.UseVisualStyleBackColor = true;
            this.stretchstofRadioButton.CheckedChanged += new System.EventHandler(this.CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.panel1.Controls.Add(this.stoffenListBox);
            this.panel1.Controls.Add(this.toevoegenButton);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(234, 424);
            this.panel1.TabIndex = 2;
            // 
            // stoffenListBox
            // 
            this.stoffenListBox.FormattingEnabled = true;
            this.stoffenListBox.ItemHeight = 16;
            this.stoffenListBox.Location = new System.Drawing.Point(12, 80);
            this.stoffenListBox.Name = "stoffenListBox";
            this.stoffenListBox.Size = new System.Drawing.Size(207, 244);
            this.stoffenListBox.TabIndex = 4;
            // 
            // toevoegenButton
            // 
            this.toevoegenButton.Location = new System.Drawing.Point(58, 377);
            this.toevoegenButton.Name = "toevoegenButton";
            this.toevoegenButton.Size = new System.Drawing.Size(118, 35);
            this.toevoegenButton.TabIndex = 3;
            this.toevoegenButton.Text = "Toevoegen";
            this.toevoegenButton.UseVisualStyleBackColor = true;
            this.toevoegenButton.Click += new System.EventHandler(this.ToevoegenButton_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(107)))), ((int)(((byte)(107)))));
            this.panel2.Controls.Add(this.katoenstofRadioButoon);
            this.panel2.Controls.Add(this.stretchstofRadioButton);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(234, 74);
            this.panel2.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.panel10);
            this.panel3.Controls.Add(this.panel9);
            this.panel3.Controls.Add(this.panel8);
            this.panel3.Controls.Add(this.panel7);
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(234, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(715, 424);
            this.panel3.TabIndex = 3;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel10.Controls.Add(this.bioCheckBox);
            this.panel10.Controls.Add(this.droogkastCheckBox);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel10.Location = new System.Drawing.Point(0, 318);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(715, 103);
            this.panel10.TabIndex = 7;
            // 
            // bioCheckBox
            // 
            this.bioCheckBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bioCheckBox.AutoSize = true;
            this.bioCheckBox.Location = new System.Drawing.Point(307, 30);
            this.bioCheckBox.Name = "bioCheckBox";
            this.bioCheckBox.Size = new System.Drawing.Size(50, 21);
            this.bioCheckBox.TabIndex = 1;
            this.bioCheckBox.Text = "Bio";
            this.bioCheckBox.UseVisualStyleBackColor = true;
            // 
            // droogkastCheckBox
            // 
            this.droogkastCheckBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.droogkastCheckBox.AutoSize = true;
            this.droogkastCheckBox.Location = new System.Drawing.Point(307, 3);
            this.droogkastCheckBox.Name = "droogkastCheckBox";
            this.droogkastCheckBox.Size = new System.Drawing.Size(95, 21);
            this.droogkastCheckBox.TabIndex = 1;
            this.droogkastCheckBox.Text = "Droogkast";
            this.droogkastCheckBox.UseVisualStyleBackColor = true;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel9.Controls.Add(this.stretchPercNumericUpDown);
            this.panel9.Controls.Add(this.stretchPercLabel);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel9.Location = new System.Drawing.Point(0, 265);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(715, 53);
            this.panel9.TabIndex = 6;
            // 
            // stretchPercNumericUpDown
            // 
            this.stretchPercNumericUpDown.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.stretchPercNumericUpDown.Location = new System.Drawing.Point(307, 25);
            this.stretchPercNumericUpDown.Name = "stretchPercNumericUpDown";
            this.stretchPercNumericUpDown.Size = new System.Drawing.Size(120, 22);
            this.stretchPercNumericUpDown.TabIndex = 1;
            // 
            // stretchPercLabel
            // 
            this.stretchPercLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.stretchPercLabel.AutoSize = true;
            this.stretchPercLabel.Location = new System.Drawing.Point(304, 5);
            this.stretchPercLabel.Name = "stretchPercLabel";
            this.stretchPercLabel.Size = new System.Drawing.Size(129, 17);
            this.stretchPercLabel.TabIndex = 0;
            this.stretchPercLabel.Text = "Stretch percentage";
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.kwaliteitsComboBox);
            this.panel8.Controls.Add(this.kwaliteitsLabel);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel8.Location = new System.Drawing.Point(0, 212);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(715, 53);
            this.panel8.TabIndex = 5;
            // 
            // kwaliteitsComboBox
            // 
            this.kwaliteitsComboBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.kwaliteitsComboBox.FormattingEnabled = true;
            this.kwaliteitsComboBox.Location = new System.Drawing.Point(307, 24);
            this.kwaliteitsComboBox.Name = "kwaliteitsComboBox";
            this.kwaliteitsComboBox.Size = new System.Drawing.Size(121, 24);
            this.kwaliteitsComboBox.TabIndex = 6;
            // 
            // kwaliteitsLabel
            // 
            this.kwaliteitsLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.kwaliteitsLabel.AutoSize = true;
            this.kwaliteitsLabel.Location = new System.Drawing.Point(304, 4);
            this.kwaliteitsLabel.Name = "kwaliteitsLabel";
            this.kwaliteitsLabel.Size = new System.Drawing.Size(96, 17);
            this.kwaliteitsLabel.TabIndex = 0;
            this.kwaliteitsLabel.Text = "Kwaliteitslabel";
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.krimpPerNumericUpDown);
            this.panel7.Controls.Add(this.krimpPerLabel);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 159);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(715, 53);
            this.panel7.TabIndex = 4;
            // 
            // krimpPerNumericUpDown
            // 
            this.krimpPerNumericUpDown.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.krimpPerNumericUpDown.Location = new System.Drawing.Point(307, 25);
            this.krimpPerNumericUpDown.Name = "krimpPerNumericUpDown";
            this.krimpPerNumericUpDown.Size = new System.Drawing.Size(120, 22);
            this.krimpPerNumericUpDown.TabIndex = 1;
            // 
            // krimpPerLabel
            // 
            this.krimpPerLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.krimpPerLabel.AutoSize = true;
            this.krimpPerLabel.Location = new System.Drawing.Point(304, 5);
            this.krimpPerLabel.Name = "krimpPerLabel";
            this.krimpPerLabel.Size = new System.Drawing.Size(120, 17);
            this.krimpPerLabel.TabIndex = 0;
            this.krimpPerLabel.Text = "Krimp percantage";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.PrijsPerMeternumericUpDown);
            this.panel6.Controls.Add(this.prijsPerMeterLabel);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 106);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(715, 53);
            this.panel6.TabIndex = 3;
            // 
            // PrijsPerMeternumericUpDown
            // 
            this.PrijsPerMeternumericUpDown.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PrijsPerMeternumericUpDown.Location = new System.Drawing.Point(307, 25);
            this.PrijsPerMeternumericUpDown.Name = "PrijsPerMeternumericUpDown";
            this.PrijsPerMeternumericUpDown.Size = new System.Drawing.Size(120, 22);
            this.PrijsPerMeternumericUpDown.TabIndex = 1;
            // 
            // prijsPerMeterLabel
            // 
            this.prijsPerMeterLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.prijsPerMeterLabel.AutoSize = true;
            this.prijsPerMeterLabel.Location = new System.Drawing.Point(304, 5);
            this.prijsPerMeterLabel.Name = "prijsPerMeterLabel";
            this.prijsPerMeterLabel.Size = new System.Drawing.Size(100, 17);
            this.prijsPerMeterLabel.TabIndex = 0;
            this.prijsPerMeterLabel.Text = "Prijs per meter";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.designlabelTextbox);
            this.panel5.Controls.Add(this.designLabel);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 53);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(715, 53);
            this.panel5.TabIndex = 2;
            // 
            // designlabelTextbox
            // 
            this.designlabelTextbox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.designlabelTextbox.Location = new System.Drawing.Point(307, 25);
            this.designlabelTextbox.Name = "designlabelTextbox";
            this.designlabelTextbox.Size = new System.Drawing.Size(120, 22);
            this.designlabelTextbox.TabIndex = 1;
            // 
            // designLabel
            // 
            this.designLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.designLabel.AutoSize = true;
            this.designLabel.Location = new System.Drawing.Point(304, 5);
            this.designLabel.Name = "designLabel";
            this.designLabel.Size = new System.Drawing.Size(82, 17);
            this.designLabel.TabIndex = 0;
            this.designLabel.Text = "Designlabel";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.Controls.Add(this.naamTextbox);
            this.panel4.Controls.Add(this.naamLabel);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(715, 53);
            this.panel4.TabIndex = 1;
            // 
            // naamTextbox
            // 
            this.naamTextbox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.naamTextbox.Location = new System.Drawing.Point(307, 25);
            this.naamTextbox.MinimumSize = new System.Drawing.Size(120, 22);
            this.naamTextbox.Name = "naamTextbox";
            this.naamTextbox.Size = new System.Drawing.Size(120, 22);
            this.naamTextbox.TabIndex = 1;
            // 
            // naamLabel
            // 
            this.naamLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.naamLabel.AutoSize = true;
            this.naamLabel.Location = new System.Drawing.Point(304, 5);
            this.naamLabel.Name = "naamLabel";
            this.naamLabel.Size = new System.Drawing.Size(45, 17);
            this.naamLabel.TabIndex = 0;
            this.naamLabel.Text = "Naam";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(949, 424);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(967, 471);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stretchPercNumericUpDown)).EndInit();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.krimpPerNumericUpDown)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PrijsPerMeternumericUpDown)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton katoenstofRadioButoon;
        private System.Windows.Forms.RadioButton stretchstofRadioButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox naamTextbox;
        private System.Windows.Forms.Label naamLabel;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox designlabelTextbox;
        private System.Windows.Forms.Label designLabel;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label prijsPerMeterLabel;
        private System.Windows.Forms.NumericUpDown PrijsPerMeternumericUpDown;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.NumericUpDown krimpPerNumericUpDown;
        private System.Windows.Forms.Label krimpPerLabel;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label kwaliteitsLabel;
        private System.Windows.Forms.ComboBox kwaliteitsComboBox;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.CheckBox droogkastCheckBox;
        private System.Windows.Forms.NumericUpDown stretchPercNumericUpDown;
        private System.Windows.Forms.Label stretchPercLabel;
        private System.Windows.Forms.CheckBox bioCheckBox;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Button toevoegenButton;
        private System.Windows.Forms.ListBox stoffenListBox;
    }
}

