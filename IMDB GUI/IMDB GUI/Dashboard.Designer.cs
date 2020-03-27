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
            this.serieFilmComboBox = new System.Windows.Forms.ComboBox();
            this.filmButton = new System.Windows.Forms.Button();
            this.filmTextBoc = new System.Windows.Forms.TextBox();
            this.filmLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ratingTextBoc = new System.Windows.Forms.TextBox();
            this.serieLabel = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.serieButton = new System.Windows.Forms.Button();
            this.ratingButton = new System.Windows.Forms.Button();
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
            // filmButton
            // 
            this.filmButton.Location = new System.Drawing.Point(47, 253);
            this.filmButton.Name = "filmButton";
            this.filmButton.Size = new System.Drawing.Size(121, 23);
            this.filmButton.TabIndex = 1;
            this.filmButton.Text = "Toevoegen";
            this.filmButton.UseVisualStyleBackColor = true;
            this.filmButton.Click += new System.EventHandler(this.FilmButton_Click);
            // 
            // filmTextBoc
            // 
            this.filmTextBoc.Location = new System.Drawing.Point(47, 225);
            this.filmTextBoc.Name = "filmTextBoc";
            this.filmTextBoc.Size = new System.Drawing.Size(121, 22);
            this.filmTextBoc.TabIndex = 2;
            // 
            // filmLabel
            // 
            this.filmLabel.AutoSize = true;
            this.filmLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filmLabel.Location = new System.Drawing.Point(12, 159);
            this.filmLabel.Name = "filmLabel";
            this.filmLabel.Size = new System.Drawing.Size(187, 29);
            this.filmLabel.TabIndex = 3;
            this.filmLabel.Text = "Film toevoegen";
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
            // ratingTextBoc
            // 
            this.ratingTextBoc.Location = new System.Drawing.Point(550, 253);
            this.ratingTextBoc.Name = "ratingTextBoc";
            this.ratingTextBoc.Size = new System.Drawing.Size(121, 22);
            this.ratingTextBoc.TabIndex = 5;
            // 
            // serieLabel
            // 
            this.serieLabel.AutoSize = true;
            this.serieLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serieLabel.Location = new System.Drawing.Point(269, 159);
            this.serieLabel.Name = "serieLabel";
            this.serieLabel.Size = new System.Drawing.Size(197, 29);
            this.serieLabel.TabIndex = 8;
            this.serieLabel.Text = "Serie toevoegen";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(304, 225);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(121, 22);
            this.textBox2.TabIndex = 7;
            // 
            // serieButton
            // 
            this.serieButton.Location = new System.Drawing.Point(304, 253);
            this.serieButton.Name = "serieButton";
            this.serieButton.Size = new System.Drawing.Size(121, 23);
            this.serieButton.TabIndex = 6;
            this.serieButton.Text = "Toevoegen";
            this.serieButton.UseVisualStyleBackColor = true;
            this.serieButton.Click += new System.EventHandler(this.SerieButton_Click);
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
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ratingButton);
            this.Controls.Add(this.serieLabel);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.serieButton);
            this.Controls.Add(this.ratingTextBoc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.filmLabel);
            this.Controls.Add(this.filmTextBoc);
            this.Controls.Add(this.filmButton);
            this.Controls.Add(this.serieFilmComboBox);
            this.Name = "Dashboard";
            this.Text = "Bioscoop";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox serieFilmComboBox;
        private System.Windows.Forms.Button filmButton;
        private System.Windows.Forms.TextBox filmTextBoc;
        private System.Windows.Forms.Label filmLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ratingTextBoc;
        private System.Windows.Forms.Label serieLabel;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button serieButton;
        private System.Windows.Forms.Button ratingButton;
    }
}

