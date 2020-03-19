namespace Dobbelspel
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
            this.bedragLabel = new System.Windows.Forms.Label();
            this.GooiButton = new System.Windows.Forms.Button();
            this.waardeLabel = new System.Windows.Forms.Label();
            this.resultaatLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bedragLabel
            // 
            this.bedragLabel.AutoSize = true;
            this.bedragLabel.Location = new System.Drawing.Point(65, 38);
            this.bedragLabel.Name = "bedragLabel";
            this.bedragLabel.Size = new System.Drawing.Size(54, 17);
            this.bedragLabel.TabIndex = 0;
            this.bedragLabel.Text = "Bedrag";
            this.bedragLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // GooiButton
            // 
            this.GooiButton.Location = new System.Drawing.Point(243, 122);
            this.GooiButton.Name = "GooiButton";
            this.GooiButton.Size = new System.Drawing.Size(75, 23);
            this.GooiButton.TabIndex = 1;
            this.GooiButton.Text = "Gooi dobbesteen";
            this.GooiButton.UseVisualStyleBackColor = true;
            this.GooiButton.Click += new System.EventHandler(this.GooiButton_Click);
            // 
            // waardeLabel
            // 
            this.waardeLabel.AutoSize = true;
            this.waardeLabel.Location = new System.Drawing.Point(240, 176);
            this.waardeLabel.Name = "waardeLabel";
            this.waardeLabel.Size = new System.Drawing.Size(113, 17);
            this.waardeLabel.TabIndex = 2;
            this.waardeLabel.Text = "Waarde gegooid";
            this.waardeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.waardeLabel.Click += new System.EventHandler(this.WaardeLabel_Click);
            // 
            // resultaatLabel
            // 
            this.resultaatLabel.AutoSize = true;
            this.resultaatLabel.Location = new System.Drawing.Point(240, 225);
            this.resultaatLabel.Name = "resultaatLabel";
            this.resultaatLabel.Size = new System.Drawing.Size(102, 17);
            this.resultaatLabel.TabIndex = 3;
            this.resultaatLabel.Text = "Resultaat tekst";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 311);
            this.Controls.Add(this.resultaatLabel);
            this.Controls.Add(this.waardeLabel);
            this.Controls.Add(this.GooiButton);
            this.Controls.Add(this.bedragLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label bedragLabel;
        private System.Windows.Forms.Button GooiButton;
        private System.Windows.Forms.Label waardeLabel;
        private System.Windows.Forms.Label resultaatLabel;
    }
}

