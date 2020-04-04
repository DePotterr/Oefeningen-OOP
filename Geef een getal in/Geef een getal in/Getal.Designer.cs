namespace Geef_een_getal_in
{
    partial class Getal
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
            this.getalLabel = new System.Windows.Forms.Label();
            this.getalTextBox = new System.Windows.Forms.TextBox();
            this.outputLabel = new System.Windows.Forms.Label();
            this.enterButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // getalLabel
            // 
            this.getalLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.getalLabel.Location = new System.Drawing.Point(12, 9);
            this.getalLabel.Name = "getalLabel";
            this.getalLabel.Size = new System.Drawing.Size(558, 28);
            this.getalLabel.TabIndex = 0;
            this.getalLabel.Text = "Voer getal in.";
            this.getalLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // getalTextBox
            // 
            this.getalTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.getalTextBox.Location = new System.Drawing.Point(227, 40);
            this.getalTextBox.Name = "getalTextBox";
            this.getalTextBox.Size = new System.Drawing.Size(129, 22);
            this.getalTextBox.TabIndex = 1;
            // 
            // outputLabel
            // 
            this.outputLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.outputLabel.Location = new System.Drawing.Point(12, 145);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(556, 153);
            this.outputLabel.TabIndex = 2;
            this.outputLabel.Text = "output";
            this.outputLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // enterButton
            // 
            this.enterButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.enterButton.Location = new System.Drawing.Point(227, 68);
            this.enterButton.Name = "enterButton";
            this.enterButton.Size = new System.Drawing.Size(129, 39);
            this.enterButton.TabIndex = 3;
            this.enterButton.Text = "Enter";
            this.enterButton.UseVisualStyleBackColor = true;
            this.enterButton.Click += new System.EventHandler(this.EnterButton_Click);
            // 
            // Getal
            // 
            this.AcceptButton = this.enterButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 333);
            this.Controls.Add(this.enterButton);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.getalTextBox);
            this.Controls.Add(this.getalLabel);
            this.MinimumSize = new System.Drawing.Size(371, 320);
            this.Name = "Getal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Voer getal in";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label getalLabel;
        private System.Windows.Forms.TextBox getalTextBox;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.Button enterButton;
    }
}

