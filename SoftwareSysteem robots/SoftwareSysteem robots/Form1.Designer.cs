namespace SoftwareSysteem_robots
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
            this.components = new System.ComponentModel.Container();
            this.Butopstarten = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.opvangbakCheckBox = new System.Windows.Forms.CheckBox();
            this.waterCheckBox2 = new System.Windows.Forms.CheckBox();
            this.OpladenButton = new System.Windows.Forms.Button();
            this.zeepCheckBox = new System.Windows.Forms.CheckBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // Butopstarten
            // 
            this.Butopstarten.Location = new System.Drawing.Point(335, 261);
            this.Butopstarten.Name = "Butopstarten";
            this.Butopstarten.Size = new System.Drawing.Size(121, 29);
            this.Butopstarten.TabIndex = 0;
            this.Butopstarten.Text = "Opstarten";
            this.Butopstarten.UseVisualStyleBackColor = true;
            this.Butopstarten.Click += new System.EventHandler(this.Button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(335, 231);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(335, 208);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Batterij";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(335, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "label2";
            // 
            // opvangbakCheckBox
            // 
            this.opvangbakCheckBox.AutoSize = true;
            this.opvangbakCheckBox.Location = new System.Drawing.Point(504, 164);
            this.opvangbakCheckBox.Name = "opvangbakCheckBox";
            this.opvangbakCheckBox.Size = new System.Drawing.Size(133, 21);
            this.opvangbakCheckBox.TabIndex = 4;
            this.opvangbakCheckBox.Text = "Opvangbak vol?";
            this.opvangbakCheckBox.UseVisualStyleBackColor = true;
            this.opvangbakCheckBox.CheckedChanged += new System.EventHandler(this.OpvangbakCheckBox_CheckedChanged);
            // 
            // waterCheckBox2
            // 
            this.waterCheckBox2.AutoSize = true;
            this.waterCheckBox2.Location = new System.Drawing.Point(504, 216);
            this.waterCheckBox2.Name = "waterCheckBox2";
            this.waterCheckBox2.Size = new System.Drawing.Size(139, 21);
            this.waterCheckBox2.TabIndex = 5;
            this.waterCheckBox2.Text = "Water aanwezig?";
            this.waterCheckBox2.UseVisualStyleBackColor = true;
            this.waterCheckBox2.CheckedChanged += new System.EventHandler(this.WaterCheckBox2_CheckedChanged);
            // 
            // OpladenButton
            // 
            this.OpladenButton.Location = new System.Drawing.Point(504, 244);
            this.OpladenButton.Name = "OpladenButton";
            this.OpladenButton.Size = new System.Drawing.Size(98, 29);
            this.OpladenButton.TabIndex = 6;
            this.OpladenButton.Text = "Opladen";
            this.OpladenButton.UseVisualStyleBackColor = true;
            this.OpladenButton.Click += new System.EventHandler(this.OpladenButton_Click);
            // 
            // zeepCheckBox
            // 
            this.zeepCheckBox.AutoSize = true;
            this.zeepCheckBox.Location = new System.Drawing.Point(504, 191);
            this.zeepCheckBox.Name = "zeepCheckBox";
            this.zeepCheckBox.Size = new System.Drawing.Size(134, 21);
            this.zeepCheckBox.TabIndex = 7;
            this.zeepCheckBox.Text = "Zeep aanwezig?";
            this.zeepCheckBox.UseVisualStyleBackColor = true;
            this.zeepCheckBox.CheckedChanged += new System.EventHandler(this.ZeepCheckBox_CheckedChanged);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(38, 41);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(210, 196);
            this.listBox1.TabIndex = 8;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.zeepCheckBox);
            this.Controls.Add(this.OpladenButton);
            this.Controls.Add(this.waterCheckBox2);
            this.Controls.Add(this.opvangbakCheckBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.Butopstarten);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Butopstarten;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox opvangbakCheckBox;
        private System.Windows.Forms.CheckBox waterCheckBox2;
        private System.Windows.Forms.Button OpladenButton;
        private System.Windows.Forms.CheckBox zeepCheckBox;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Timer timer1;
    }
}

