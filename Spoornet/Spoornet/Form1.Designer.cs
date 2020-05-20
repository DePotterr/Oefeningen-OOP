namespace Spoornet
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.zoekButton = new System.Windows.Forms.Button();
            this.treinLabel = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.cloneButton = new System.Windows.Forms.Button();
            this.cloneTextBox = new System.Windows.Forms.TextBox();
            this.sortButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(12, 60);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(575, 484);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.ListBox1_SelectedIndexChanged);
            this.listBox1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ListBox1_MouseDoubleClick);
            // 
            // zoekButton
            // 
            this.zoekButton.Location = new System.Drawing.Point(593, 486);
            this.zoekButton.Name = "zoekButton";
            this.zoekButton.Size = new System.Drawing.Size(182, 58);
            this.zoekButton.TabIndex = 1;
            this.zoekButton.Text = "Zoek";
            this.zoekButton.UseVisualStyleBackColor = true;
            this.zoekButton.Click += new System.EventHandler(this.ZoekButton_Click);
            // 
            // treinLabel
            // 
            this.treinLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treinLabel.Location = new System.Drawing.Point(12, 9);
            this.treinLabel.Name = "treinLabel";
            this.treinLabel.Size = new System.Drawing.Size(575, 48);
            this.treinLabel.TabIndex = 3;
            this.treinLabel.Text = "Treinen";
            this.treinLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(593, 428);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(182, 24);
            this.comboBox1.TabIndex = 4;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(593, 458);
            this.maskedTextBox1.Mask = "0,0,0 0-0";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(182, 22);
            this.maskedTextBox1.TabIndex = 2;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 16;
            this.listBox2.Location = new System.Drawing.Point(593, 60);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(540, 356);
            this.listBox2.TabIndex = 5;
            // 
            // cloneButton
            // 
            this.cloneButton.Location = new System.Drawing.Point(781, 486);
            this.cloneButton.Name = "cloneButton";
            this.cloneButton.Size = new System.Drawing.Size(182, 58);
            this.cloneButton.TabIndex = 6;
            this.cloneButton.Text = "Clone";
            this.cloneButton.UseVisualStyleBackColor = true;
            this.cloneButton.Click += new System.EventHandler(this.CloneButton_Click);
            // 
            // cloneTextBox
            // 
            this.cloneTextBox.Location = new System.Drawing.Point(782, 458);
            this.cloneTextBox.Name = "cloneTextBox";
            this.cloneTextBox.Size = new System.Drawing.Size(181, 22);
            this.cloneTextBox.TabIndex = 7;
            // 
            // sortButton
            // 
            this.sortButton.Location = new System.Drawing.Point(969, 510);
            this.sortButton.Name = "sortButton";
            this.sortButton.Size = new System.Drawing.Size(99, 34);
            this.sortButton.TabIndex = 8;
            this.sortButton.Text = "Sort";
            this.sortButton.UseVisualStyleBackColor = true;
            this.sortButton.Click += new System.EventHandler(this.SortButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1145, 558);
            this.Controls.Add(this.sortButton);
            this.Controls.Add(this.cloneTextBox);
            this.Controls.Add(this.cloneButton);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.treinLabel);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.zoekButton);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button zoekButton;
        private System.Windows.Forms.Label treinLabel;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button cloneButton;
        private System.Windows.Forms.TextBox cloneTextBox;
        private System.Windows.Forms.Button sortButton;
    }
}

