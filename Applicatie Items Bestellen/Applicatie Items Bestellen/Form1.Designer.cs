namespace Applicatie_Items_Bestellen
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
            this.titelLabel = new System.Windows.Forms.Label();
            this.titelTextBox = new System.Windows.Forms.TextBox();
            this.soortItemLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gameRadioButton = new System.Windows.Forms.RadioButton();
            this.boekRadioButton = new System.Windows.Forms.RadioButton();
            this.prijsLabel = new System.Windows.Forms.Label();
            this.prijsTextBox = new System.Windows.Forms.TextBox();
            this.aantalTextBox = new System.Windows.Forms.TextBox();
            this.aantalLabel = new System.Windows.Forms.Label();
            this.toevoegenButton = new System.Windows.Forms.Button();
            this.bestelbonTextBox = new System.Windows.Forms.TextBox();
            this.betaalButton = new System.Windows.Forms.Button();
            this.bedragLabel = new System.Windows.Forms.Label();
            this.bedragTextBox = new System.Windows.Forms.TextBox();
            this.editieComboBox = new System.Windows.Forms.ComboBox();
            this.editieLabel = new System.Windows.Forms.Label();
            this.acteurTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.aantalPaginasLabel = new System.Windows.Forms.Label();
            this.paginasTextBox = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // titelLabel
            // 
            this.titelLabel.AutoSize = true;
            this.titelLabel.Location = new System.Drawing.Point(12, 9);
            this.titelLabel.Name = "titelLabel";
            this.titelLabel.Size = new System.Drawing.Size(35, 17);
            this.titelLabel.TabIndex = 0;
            this.titelLabel.Text = "Titel";
            // 
            // titelTextBox
            // 
            this.titelTextBox.Location = new System.Drawing.Point(13, 30);
            this.titelTextBox.Name = "titelTextBox";
            this.titelTextBox.Size = new System.Drawing.Size(298, 22);
            this.titelTextBox.TabIndex = 1;
            // 
            // soortItemLabel
            // 
            this.soortItemLabel.AutoSize = true;
            this.soortItemLabel.Location = new System.Drawing.Point(12, 55);
            this.soortItemLabel.Name = "soortItemLabel";
            this.soortItemLabel.Size = new System.Drawing.Size(72, 17);
            this.soortItemLabel.TabIndex = 2;
            this.soortItemLabel.Text = "Soort item";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.boekRadioButton);
            this.panel1.Controls.Add(this.gameRadioButton);
            this.panel1.Location = new System.Drawing.Point(13, 75);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(122, 62);
            this.panel1.TabIndex = 3;
            // 
            // gameRadioButton
            // 
            this.gameRadioButton.AutoSize = true;
            this.gameRadioButton.Location = new System.Drawing.Point(16, 3);
            this.gameRadioButton.Name = "gameRadioButton";
            this.gameRadioButton.Size = new System.Drawing.Size(67, 21);
            this.gameRadioButton.TabIndex = 0;
            this.gameRadioButton.TabStop = true;
            this.gameRadioButton.Text = "Game";
            this.gameRadioButton.UseVisualStyleBackColor = true;
            this.gameRadioButton.CheckedChanged += new System.EventHandler(this.GameRadioButton_CheckedChanged);
            // 
            // boekRadioButton
            // 
            this.boekRadioButton.AutoSize = true;
            this.boekRadioButton.Location = new System.Drawing.Point(16, 30);
            this.boekRadioButton.Name = "boekRadioButton";
            this.boekRadioButton.Size = new System.Drawing.Size(61, 21);
            this.boekRadioButton.TabIndex = 1;
            this.boekRadioButton.TabStop = true;
            this.boekRadioButton.Text = "Boek";
            this.boekRadioButton.UseVisualStyleBackColor = true;
            // 
            // prijsLabel
            // 
            this.prijsLabel.AutoSize = true;
            this.prijsLabel.Location = new System.Drawing.Point(12, 140);
            this.prijsLabel.Name = "prijsLabel";
            this.prijsLabel.Size = new System.Drawing.Size(35, 17);
            this.prijsLabel.TabIndex = 4;
            this.prijsLabel.Text = "Prijs";
            // 
            // prijsTextBox
            // 
            this.prijsTextBox.Location = new System.Drawing.Point(12, 160);
            this.prijsTextBox.Name = "prijsTextBox";
            this.prijsTextBox.Size = new System.Drawing.Size(163, 22);
            this.prijsTextBox.TabIndex = 5;
            // 
            // aantalTextBox
            // 
            this.aantalTextBox.Location = new System.Drawing.Point(12, 205);
            this.aantalTextBox.Name = "aantalTextBox";
            this.aantalTextBox.Size = new System.Drawing.Size(163, 22);
            this.aantalTextBox.TabIndex = 7;
            // 
            // aantalLabel
            // 
            this.aantalLabel.AutoSize = true;
            this.aantalLabel.Location = new System.Drawing.Point(12, 185);
            this.aantalLabel.Name = "aantalLabel";
            this.aantalLabel.Size = new System.Drawing.Size(48, 17);
            this.aantalLabel.TabIndex = 6;
            this.aantalLabel.Text = "Aantal";
            // 
            // toevoegenButton
            // 
            this.toevoegenButton.Location = new System.Drawing.Point(12, 263);
            this.toevoegenButton.Name = "toevoegenButton";
            this.toevoegenButton.Size = new System.Drawing.Size(163, 50);
            this.toevoegenButton.TabIndex = 8;
            this.toevoegenButton.Text = "Toevoegen";
            this.toevoegenButton.UseVisualStyleBackColor = true;
            this.toevoegenButton.Click += new System.EventHandler(this.ToevoegenButton_Click);
            // 
            // bestelbonTextBox
            // 
            this.bestelbonTextBox.Location = new System.Drawing.Point(12, 320);
            this.bestelbonTextBox.Multiline = true;
            this.bestelbonTextBox.Name = "bestelbonTextBox";
            this.bestelbonTextBox.ReadOnly = true;
            this.bestelbonTextBox.Size = new System.Drawing.Size(358, 118);
            this.bestelbonTextBox.TabIndex = 9;
            // 
            // betaalButton
            // 
            this.betaalButton.Location = new System.Drawing.Point(376, 388);
            this.betaalButton.Name = "betaalButton";
            this.betaalButton.Size = new System.Drawing.Size(163, 50);
            this.betaalButton.TabIndex = 10;
            this.betaalButton.Text = "Betaal";
            this.betaalButton.UseVisualStyleBackColor = true;
            this.betaalButton.Click += new System.EventHandler(this.BetaalButton_Click);
            // 
            // bedragLabel
            // 
            this.bedragLabel.AutoSize = true;
            this.bedragLabel.Location = new System.Drawing.Point(376, 320);
            this.bedragLabel.Name = "bedragLabel";
            this.bedragLabel.Size = new System.Drawing.Size(115, 17);
            this.bedragLabel.TabIndex = 11;
            this.bedragLabel.Text = "Totaal te betalen";
            // 
            // bedragTextBox
            // 
            this.bedragTextBox.Location = new System.Drawing.Point(379, 340);
            this.bedragTextBox.Name = "bedragTextBox";
            this.bedragTextBox.ReadOnly = true;
            this.bedragTextBox.Size = new System.Drawing.Size(124, 22);
            this.bedragTextBox.TabIndex = 12;
            // 
            // editieComboBox
            // 
            this.editieComboBox.FormattingEnabled = true;
            this.editieComboBox.Location = new System.Drawing.Point(379, 78);
            this.editieComboBox.Name = "editieComboBox";
            this.editieComboBox.Size = new System.Drawing.Size(121, 24);
            this.editieComboBox.TabIndex = 13;
            // 
            // editieLabel
            // 
            this.editieLabel.AutoSize = true;
            this.editieLabel.Location = new System.Drawing.Point(376, 58);
            this.editieLabel.Name = "editieLabel";
            this.editieLabel.Size = new System.Drawing.Size(43, 17);
            this.editieLabel.TabIndex = 14;
            this.editieLabel.Text = "Editie";
            // 
            // acteurTextBox
            // 
            this.acteurTextBox.Location = new System.Drawing.Point(577, 80);
            this.acteurTextBox.Name = "acteurTextBox";
            this.acteurTextBox.Size = new System.Drawing.Size(163, 22);
            this.acteurTextBox.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(574, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 16;
            this.label1.Text = "Acteur";
            // 
            // aantalPaginasLabel
            // 
            this.aantalPaginasLabel.AutoSize = true;
            this.aantalPaginasLabel.Location = new System.Drawing.Point(574, 105);
            this.aantalPaginasLabel.Name = "aantalPaginasLabel";
            this.aantalPaginasLabel.Size = new System.Drawing.Size(59, 17);
            this.aantalPaginasLabel.TabIndex = 18;
            this.aantalPaginasLabel.Text = "Paginas";
            // 
            // paginasTextBox
            // 
            this.paginasTextBox.Location = new System.Drawing.Point(577, 125);
            this.paginasTextBox.Name = "paginasTextBox";
            this.paginasTextBox.Size = new System.Drawing.Size(119, 22);
            this.paginasTextBox.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.aantalPaginasLabel);
            this.Controls.Add(this.paginasTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.acteurTextBox);
            this.Controls.Add(this.editieLabel);
            this.Controls.Add(this.editieComboBox);
            this.Controls.Add(this.bedragTextBox);
            this.Controls.Add(this.bedragLabel);
            this.Controls.Add(this.betaalButton);
            this.Controls.Add(this.bestelbonTextBox);
            this.Controls.Add(this.toevoegenButton);
            this.Controls.Add(this.aantalTextBox);
            this.Controls.Add(this.aantalLabel);
            this.Controls.Add(this.prijsTextBox);
            this.Controls.Add(this.prijsLabel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.soortItemLabel);
            this.Controls.Add(this.titelTextBox);
            this.Controls.Add(this.titelLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titelLabel;
        private System.Windows.Forms.TextBox titelTextBox;
        private System.Windows.Forms.Label soortItemLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton boekRadioButton;
        private System.Windows.Forms.RadioButton gameRadioButton;
        private System.Windows.Forms.Label prijsLabel;
        private System.Windows.Forms.TextBox prijsTextBox;
        private System.Windows.Forms.TextBox aantalTextBox;
        private System.Windows.Forms.Label aantalLabel;
        private System.Windows.Forms.Button toevoegenButton;
        private System.Windows.Forms.TextBox bestelbonTextBox;
        private System.Windows.Forms.Button betaalButton;
        private System.Windows.Forms.Label bedragLabel;
        private System.Windows.Forms.TextBox bedragTextBox;
        private System.Windows.Forms.ComboBox editieComboBox;
        private System.Windows.Forms.Label editieLabel;
        private System.Windows.Forms.TextBox acteurTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label aantalPaginasLabel;
        private System.Windows.Forms.TextBox paginasTextBox;
    }
}

