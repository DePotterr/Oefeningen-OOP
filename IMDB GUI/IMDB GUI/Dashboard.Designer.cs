namespace IMDB_GUI
{
    partial class Dashboard
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
            this.serieFilmComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.filmSerieLabel = new System.Windows.Forms.Label();
            this.naamTextBox = new System.Windows.Forms.TextBox();
            this.toevoegenButton = new System.Windows.Forms.Button();
            this.ratingButton = new System.Windows.Forms.Button();
            this.filmRadioButton = new System.Windows.Forms.RadioButton();
            this.SerieRadioButton = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ratingComboBox = new System.Windows.Forms.ComboBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // serieFilmComboBox
            // 
            this.serieFilmComboBox.FormattingEnabled = true;
            this.serieFilmComboBox.Location = new System.Drawing.Point(550, 223);
            this.serieFilmComboBox.Name = "serieFilmComboBox";
            this.serieFilmComboBox.Size = new System.Drawing.Size(121, 24);
            this.serieFilmComboBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(509, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "Rating toevoegen";
            // 
            // filmSerieLabel
            // 
            this.filmSerieLabel.AutoSize = true;
            this.filmSerieLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filmSerieLabel.Location = new System.Drawing.Point(173, 159);
            this.filmSerieLabel.Name = "filmSerieLabel";
            this.filmSerieLabel.Size = new System.Drawing.Size(144, 29);
            this.filmSerieLabel.TabIndex = 8;
            this.filmSerieLabel.Text = "film of serie";
            // 
            // naamTextBox
            // 
            this.naamTextBox.Location = new System.Drawing.Point(178, 223);
            this.naamTextBox.Name = "naamTextBox";
            this.naamTextBox.Size = new System.Drawing.Size(121, 22);
            this.naamTextBox.TabIndex = 7;
            // 
            // toevoegenButton
            // 
            this.toevoegenButton.Location = new System.Drawing.Point(178, 251);
            this.toevoegenButton.Name = "toevoegenButton";
            this.toevoegenButton.Size = new System.Drawing.Size(121, 23);
            this.toevoegenButton.TabIndex = 6;
            this.toevoegenButton.Text = "Toevoegen";
            this.toevoegenButton.UseVisualStyleBackColor = true;
            this.toevoegenButton.Click += new System.EventHandler(this.ToevoegenButton_Click);
            // 
            // ratingButton
            // 
            this.ratingButton.Location = new System.Drawing.Point(550, 281);
            this.ratingButton.Name = "ratingButton";
            this.ratingButton.Size = new System.Drawing.Size(121, 23);
            this.ratingButton.TabIndex = 9;
            this.ratingButton.Text = "Toevoegen";
            this.ratingButton.UseVisualStyleBackColor = true;
            this.ratingButton.Click += new System.EventHandler(this.RatingButton_Click);
            // 
            // filmRadioButton
            // 
            this.filmRadioButton.AutoSize = true;
            this.filmRadioButton.Location = new System.Drawing.Point(11, 15);
            this.filmRadioButton.Name = "filmRadioButton";
            this.filmRadioButton.Size = new System.Drawing.Size(54, 21);
            this.filmRadioButton.TabIndex = 10;
            this.filmRadioButton.TabStop = true;
            this.filmRadioButton.Text = "Film";
            this.filmRadioButton.UseVisualStyleBackColor = true;
            this.filmRadioButton.CheckedChanged += new System.EventHandler(this.CheckedChanged);
            // 
            // SerieRadioButton
            // 
            this.SerieRadioButton.AutoSize = true;
            this.SerieRadioButton.Location = new System.Drawing.Point(11, 42);
            this.SerieRadioButton.Name = "SerieRadioButton";
            this.SerieRadioButton.Size = new System.Drawing.Size(62, 21);
            this.SerieRadioButton.TabIndex = 11;
            this.SerieRadioButton.TabStop = true;
            this.SerieRadioButton.Text = "Serie";
            this.SerieRadioButton.UseVisualStyleBackColor = true;
            this.SerieRadioButton.CheckedChanged += new System.EventHandler(this.CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.filmRadioButton);
            this.panel1.Controls.Add(this.SerieRadioButton);
            this.panel1.Location = new System.Drawing.Point(370, 62);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(76, 81);
            this.panel1.TabIndex = 12;
            // 
            // ratingComboBox
            // 
            this.ratingComboBox.FormattingEnabled = true;
            this.ratingComboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.ratingComboBox.Location = new System.Drawing.Point(550, 251);
            this.ratingComboBox.Name = "ratingComboBox";
            this.ratingComboBox.Size = new System.Drawing.Size(121, 24);
            this.ratingComboBox.TabIndex = 13;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ratingComboBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ratingButton);
            this.Controls.Add(this.filmSerieLabel);
            this.Controls.Add(this.naamTextBox);
            this.Controls.Add(this.toevoegenButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.serieFilmComboBox);
            this.Name = "Dashboard";
            this.Text = "Bioscoop";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox serieFilmComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label filmSerieLabel;
        private System.Windows.Forms.TextBox naamTextBox;
        private System.Windows.Forms.Button toevoegenButton;
        private System.Windows.Forms.Button ratingButton;
        private System.Windows.Forms.RadioButton filmRadioButton;
        private System.Windows.Forms.RadioButton SerieRadioButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox ratingComboBox;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

