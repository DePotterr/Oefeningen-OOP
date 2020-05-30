namespace Herhalingsoef_2
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
            this.VoornaamTextBox = new System.Windows.Forms.TextBox();
            this.naamTextBox = new System.Windows.Forms.TextBox();
            this.startDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.benoemdCheckBox = new System.Windows.Forms.CheckBox();
            this.ToevoegenButton = new System.Windows.Forms.Button();
            this.verwijderenTextBox = new System.Windows.Forms.TextBox();
            this.verwijderenButton = new System.Windows.Forms.Button();
            this.atRadioButton = new System.Windows.Forms.RadioButton();
            this.opRadioButton = new System.Windows.Forms.RadioButton();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // VoornaamTextBox
            // 
            this.VoornaamTextBox.Location = new System.Drawing.Point(170, 67);
            this.VoornaamTextBox.Name = "VoornaamTextBox";
            this.VoornaamTextBox.Size = new System.Drawing.Size(100, 22);
            this.VoornaamTextBox.TabIndex = 0;
            // 
            // naamTextBox
            // 
            this.naamTextBox.Location = new System.Drawing.Point(170, 96);
            this.naamTextBox.Name = "naamTextBox";
            this.naamTextBox.Size = new System.Drawing.Size(100, 22);
            this.naamTextBox.TabIndex = 1;
            // 
            // startDateTimePicker
            // 
            this.startDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.startDateTimePicker.Location = new System.Drawing.Point(170, 125);
            this.startDateTimePicker.Name = "startDateTimePicker";
            this.startDateTimePicker.Size = new System.Drawing.Size(103, 22);
            this.startDateTimePicker.TabIndex = 2;
            // 
            // benoemdCheckBox
            // 
            this.benoemdCheckBox.AutoSize = true;
            this.benoemdCheckBox.Location = new System.Drawing.Point(170, 154);
            this.benoemdCheckBox.Name = "benoemdCheckBox";
            this.benoemdCheckBox.Size = new System.Drawing.Size(103, 21);
            this.benoemdCheckBox.TabIndex = 3;
            this.benoemdCheckBox.Text = "is benoemd";
            this.benoemdCheckBox.UseVisualStyleBackColor = true;
            // 
            // ToevoegenButton
            // 
            this.ToevoegenButton.Location = new System.Drawing.Point(170, 240);
            this.ToevoegenButton.Name = "ToevoegenButton";
            this.ToevoegenButton.Size = new System.Drawing.Size(200, 42);
            this.ToevoegenButton.TabIndex = 4;
            this.ToevoegenButton.Text = "Toevoegen";
            this.ToevoegenButton.UseVisualStyleBackColor = true;
            this.ToevoegenButton.Click += new System.EventHandler(this.ToevoegenButton_Click);
            // 
            // verwijderenTextBox
            // 
            this.verwijderenTextBox.Location = new System.Drawing.Point(556, 67);
            this.verwijderenTextBox.Name = "verwijderenTextBox";
            this.verwijderenTextBox.Size = new System.Drawing.Size(100, 22);
            this.verwijderenTextBox.TabIndex = 5;
            // 
            // verwijderenButton
            // 
            this.verwijderenButton.Location = new System.Drawing.Point(503, 105);
            this.verwijderenButton.Name = "verwijderenButton";
            this.verwijderenButton.Size = new System.Drawing.Size(200, 42);
            this.verwijderenButton.TabIndex = 6;
            this.verwijderenButton.Text = "Ontslagen";
            this.verwijderenButton.UseVisualStyleBackColor = true;
            this.verwijderenButton.Click += new System.EventHandler(this.VerwijderenButton_Click);
            // 
            // atRadioButton
            // 
            this.atRadioButton.AutoSize = true;
            this.atRadioButton.Location = new System.Drawing.Point(170, 182);
            this.atRadioButton.Name = "atRadioButton";
            this.atRadioButton.Size = new System.Drawing.Size(47, 21);
            this.atRadioButton.TabIndex = 7;
            this.atRadioButton.TabStop = true;
            this.atRadioButton.Text = "AT";
            this.atRadioButton.UseVisualStyleBackColor = true;
            this.atRadioButton.CheckedChanged += new System.EventHandler(this.AtRadioButton_CheckedChanged);
            // 
            // opRadioButton
            // 
            this.opRadioButton.AutoSize = true;
            this.opRadioButton.Location = new System.Drawing.Point(170, 210);
            this.opRadioButton.Name = "opRadioButton";
            this.opRadioButton.Size = new System.Drawing.Size(49, 21);
            this.opRadioButton.TabIndex = 8;
            this.opRadioButton.TabStop = true;
            this.opRadioButton.Text = "OP";
            this.opRadioButton.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(12, 288);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(358, 132);
            this.listBox1.TabIndex = 9;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 16;
            this.listBox2.Location = new System.Drawing.Point(443, 288);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(345, 132);
            this.listBox2.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.opRadioButton);
            this.Controls.Add(this.atRadioButton);
            this.Controls.Add(this.verwijderenButton);
            this.Controls.Add(this.verwijderenTextBox);
            this.Controls.Add(this.ToevoegenButton);
            this.Controls.Add(this.benoemdCheckBox);
            this.Controls.Add(this.startDateTimePicker);
            this.Controls.Add(this.naamTextBox);
            this.Controls.Add(this.VoornaamTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox VoornaamTextBox;
        private System.Windows.Forms.TextBox naamTextBox;
        private System.Windows.Forms.DateTimePicker startDateTimePicker;
        private System.Windows.Forms.CheckBox benoemdCheckBox;
        private System.Windows.Forms.Button ToevoegenButton;
        private System.Windows.Forms.TextBox verwijderenTextBox;
        private System.Windows.Forms.Button verwijderenButton;
        private System.Windows.Forms.RadioButton atRadioButton;
        private System.Windows.Forms.RadioButton opRadioButton;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
    }
}

