namespace MinorsNotAllowd
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
            this.naamTextBox = new System.Windows.Forms.TextBox();
            this.voornaamTextBox = new System.Windows.Forms.TextBox();
            this.geslachtComboBox = new System.Windows.Forms.ComboBox();
            this.geboortedatumDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.toevoegenPersoonButton = new System.Windows.Forms.Button();
            this.personenListView = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // naamTextBox
            // 
            this.naamTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.naamTextBox.Location = new System.Drawing.Point(141, 26);
            this.naamTextBox.Name = "naamTextBox";
            this.naamTextBox.Size = new System.Drawing.Size(132, 22);
            this.naamTextBox.TabIndex = 0;
            // 
            // voornaamTextBox
            // 
            this.voornaamTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.voornaamTextBox.Location = new System.Drawing.Point(141, 54);
            this.voornaamTextBox.Name = "voornaamTextBox";
            this.voornaamTextBox.Size = new System.Drawing.Size(132, 22);
            this.voornaamTextBox.TabIndex = 1;
            // 
            // geslachtComboBox
            // 
            this.geslachtComboBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.geslachtComboBox.FormattingEnabled = true;
            this.geslachtComboBox.Location = new System.Drawing.Point(141, 83);
            this.geslachtComboBox.Name = "geslachtComboBox";
            this.geslachtComboBox.Size = new System.Drawing.Size(132, 24);
            this.geslachtComboBox.TabIndex = 2;
            // 
            // geboortedatumDateTimePicker
            // 
            this.geboortedatumDateTimePicker.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.geboortedatumDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.geboortedatumDateTimePicker.Location = new System.Drawing.Point(141, 114);
            this.geboortedatumDateTimePicker.MaxDate = new System.DateTime(2020, 4, 4, 0, 0, 0, 0);
            this.geboortedatumDateTimePicker.MinDate = new System.DateTime(1890, 1, 1, 0, 0, 0, 0);
            this.geboortedatumDateTimePicker.Name = "geboortedatumDateTimePicker";
            this.geboortedatumDateTimePicker.Size = new System.Drawing.Size(132, 22);
            this.geboortedatumDateTimePicker.TabIndex = 3;
            this.geboortedatumDateTimePicker.Value = new System.DateTime(2020, 4, 4, 0, 0, 0, 0);
            // 
            // toevoegenPersoonButton
            // 
            this.toevoegenPersoonButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.toevoegenPersoonButton.Location = new System.Drawing.Point(141, 143);
            this.toevoegenPersoonButton.Name = "toevoegenPersoonButton";
            this.toevoegenPersoonButton.Size = new System.Drawing.Size(132, 42);
            this.toevoegenPersoonButton.TabIndex = 4;
            this.toevoegenPersoonButton.Text = "Toevoegen";
            this.toevoegenPersoonButton.UseVisualStyleBackColor = true;
            this.toevoegenPersoonButton.Click += new System.EventHandler(this.ToevoegenPersoonButton_Click);
            // 
            // personenListView
            // 
            this.personenListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.personenListView.HideSelection = false;
            this.personenListView.Location = new System.Drawing.Point(12, 191);
            this.personenListView.Name = "personenListView";
            this.personenListView.Size = new System.Drawing.Size(374, 364);
            this.personenListView.TabIndex = 5;
            this.personenListView.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(279, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 567);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.personenListView);
            this.Controls.Add(this.toevoegenPersoonButton);
            this.Controls.Add(this.geboortedatumDateTimePicker);
            this.Controls.Add(this.geslachtComboBox);
            this.Controls.Add(this.voornaamTextBox);
            this.Controls.Add(this.naamTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox naamTextBox;
        private System.Windows.Forms.TextBox voornaamTextBox;
        private System.Windows.Forms.ComboBox geslachtComboBox;
        private System.Windows.Forms.DateTimePicker geboortedatumDateTimePicker;
        private System.Windows.Forms.Button toevoegenPersoonButton;
        private System.Windows.Forms.ListView personenListView;
        private System.Windows.Forms.Label label1;
    }
}

