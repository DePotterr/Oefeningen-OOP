namespace Auto_GUI_Exceptions
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
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.merkTextBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.typeTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.nummerplaatTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.aantalkmTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.datumTextBox = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Merk";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(297, 355);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(206, 66);
            this.button1.TabIndex = 1;
            this.button1.Text = "Auto toevoegen";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // merkTextBox
            // 
            this.merkTextBox.Location = new System.Drawing.Point(53, 48);
            this.merkTextBox.Name = "merkTextBox";
            this.merkTextBox.Size = new System.Drawing.Size(100, 22);
            this.merkTextBox.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.datumTextBox);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.aantalkmTextBox);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.nummerplaatTextBox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.typeTextBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.merkTextBox);
            this.panel1.Location = new System.Drawing.Point(297, 34);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(206, 264);
            this.panel1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Type";
            // 
            // typeTextBox
            // 
            this.typeTextBox.Location = new System.Drawing.Point(53, 93);
            this.typeTextBox.Name = "typeTextBox";
            this.typeTextBox.Size = new System.Drawing.Size(100, 22);
            this.typeTextBox.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nummerplaat";
            // 
            // nummerplaatTextBox
            // 
            this.nummerplaatTextBox.Location = new System.Drawing.Point(53, 138);
            this.nummerplaatTextBox.Name = "nummerplaatTextBox";
            this.nummerplaatTextBox.Size = new System.Drawing.Size(100, 22);
            this.nummerplaatTextBox.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(53, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Aantalkm";
            // 
            // aantalkmTextBox
            // 
            this.aantalkmTextBox.Location = new System.Drawing.Point(53, 183);
            this.aantalkmTextBox.Name = "aantalkmTextBox";
            this.aantalkmTextBox.Size = new System.Drawing.Size(100, 22);
            this.aantalkmTextBox.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(53, 208);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Ingebruikname";
            // 
            // datumTextBox
            // 
            this.datumTextBox.Location = new System.Drawing.Point(53, 228);
            this.datumTextBox.Name = "datumTextBox";
            this.datumTextBox.Size = new System.Drawing.Size(100, 22);
            this.datumTextBox.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox merkTextBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox datumTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox aantalkmTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nummerplaatTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox typeTextBox;
    }
}

