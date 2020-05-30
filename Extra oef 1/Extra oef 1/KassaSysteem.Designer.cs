namespace Extra_oef_1
{
    partial class KassaSysteem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KassaSysteem));
            this.menuPanel = new System.Windows.Forms.Panel();
            this.ProductenMenuPanel = new System.Windows.Forms.Panel();
            this.klantenMenuPanel = new System.Windows.Forms.Panel();
            this.KlantMenuButton = new System.Windows.Forms.Button();
            this.voorraadPanel = new System.Windows.Forms.Panel();
            this.voorraadBtn = new System.Windows.Forms.Button();
            this.kassaMenuPanel = new System.Windows.Forms.Panel();
            this.kassaBtn = new System.Windows.Forms.Button();
            this.contentPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.productenBtn = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.menuPanel.SuspendLayout();
            this.ProductenMenuPanel.SuspendLayout();
            this.klantenMenuPanel.SuspendLayout();
            this.voorraadPanel.SuspendLayout();
            this.kassaMenuPanel.SuspendLayout();
            this.contentPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuPanel
            // 
            this.menuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.menuPanel.Controls.Add(this.ProductenMenuPanel);
            this.menuPanel.Controls.Add(this.klantenMenuPanel);
            this.menuPanel.Controls.Add(this.voorraadPanel);
            this.menuPanel.Controls.Add(this.kassaMenuPanel);
            this.menuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuPanel.Location = new System.Drawing.Point(0, 0);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(200, 587);
            this.menuPanel.TabIndex = 0;
            // 
            // ProductenMenuPanel
            // 
            this.ProductenMenuPanel.Controls.Add(this.productenBtn);
            this.ProductenMenuPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ProductenMenuPanel.Location = new System.Drawing.Point(0, 207);
            this.ProductenMenuPanel.Name = "ProductenMenuPanel";
            this.ProductenMenuPanel.Size = new System.Drawing.Size(200, 69);
            this.ProductenMenuPanel.TabIndex = 3;
            // 
            // klantenMenuPanel
            // 
            this.klantenMenuPanel.Controls.Add(this.KlantMenuButton);
            this.klantenMenuPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.klantenMenuPanel.Location = new System.Drawing.Point(0, 138);
            this.klantenMenuPanel.Name = "klantenMenuPanel";
            this.klantenMenuPanel.Size = new System.Drawing.Size(200, 69);
            this.klantenMenuPanel.TabIndex = 2;
            // 
            // KlantMenuButton
            // 
            this.KlantMenuButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.KlantMenuButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.KlantMenuButton.FlatAppearance.BorderSize = 0;
            this.KlantMenuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.KlantMenuButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KlantMenuButton.ForeColor = System.Drawing.Color.White;
            this.KlantMenuButton.Location = new System.Drawing.Point(0, 0);
            this.KlantMenuButton.Name = "KlantMenuButton";
            this.KlantMenuButton.Size = new System.Drawing.Size(200, 69);
            this.KlantMenuButton.TabIndex = 2;
            this.KlantMenuButton.Text = "Klanten";
            this.KlantMenuButton.UseVisualStyleBackColor = false;
            this.KlantMenuButton.Click += new System.EventHandler(this.KlantMenuButton_Click);
            // 
            // voorraadPanel
            // 
            this.voorraadPanel.Controls.Add(this.voorraadBtn);
            this.voorraadPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.voorraadPanel.Location = new System.Drawing.Point(0, 69);
            this.voorraadPanel.Name = "voorraadPanel";
            this.voorraadPanel.Size = new System.Drawing.Size(200, 69);
            this.voorraadPanel.TabIndex = 1;
            // 
            // voorraadBtn
            // 
            this.voorraadBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.voorraadBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.voorraadBtn.FlatAppearance.BorderSize = 0;
            this.voorraadBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.voorraadBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.voorraadBtn.ForeColor = System.Drawing.Color.White;
            this.voorraadBtn.Location = new System.Drawing.Point(0, 0);
            this.voorraadBtn.Name = "voorraadBtn";
            this.voorraadBtn.Size = new System.Drawing.Size(200, 69);
            this.voorraadBtn.TabIndex = 1;
            this.voorraadBtn.Text = "Voorraad";
            this.voorraadBtn.UseVisualStyleBackColor = false;
            this.voorraadBtn.Click += new System.EventHandler(this.VoorraadBtn_Click);
            // 
            // kassaMenuPanel
            // 
            this.kassaMenuPanel.Controls.Add(this.kassaBtn);
            this.kassaMenuPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.kassaMenuPanel.Location = new System.Drawing.Point(0, 0);
            this.kassaMenuPanel.Name = "kassaMenuPanel";
            this.kassaMenuPanel.Size = new System.Drawing.Size(200, 69);
            this.kassaMenuPanel.TabIndex = 0;
            // 
            // kassaBtn
            // 
            this.kassaBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.kassaBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kassaBtn.FlatAppearance.BorderSize = 0;
            this.kassaBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.kassaBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kassaBtn.ForeColor = System.Drawing.Color.White;
            this.kassaBtn.Location = new System.Drawing.Point(0, 0);
            this.kassaBtn.Name = "kassaBtn";
            this.kassaBtn.Size = new System.Drawing.Size(200, 69);
            this.kassaBtn.TabIndex = 0;
            this.kassaBtn.Text = "Kassa";
            this.kassaBtn.UseVisualStyleBackColor = false;
            this.kassaBtn.Click += new System.EventHandler(this.KassaBtn_Click);
            // 
            // contentPanel
            // 
            this.contentPanel.Controls.Add(this.label1);
            this.contentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentPanel.Location = new System.Drawing.Point(200, 0);
            this.contentPanel.Name = "contentPanel";
            this.contentPanel.Size = new System.Drawing.Size(1012, 587);
            this.contentPanel.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1012, 587);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welkom";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // productenBtn
            // 
            this.productenBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.productenBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.productenBtn.FlatAppearance.BorderSize = 0;
            this.productenBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.productenBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productenBtn.ForeColor = System.Drawing.Color.White;
            this.productenBtn.Location = new System.Drawing.Point(0, 0);
            this.productenBtn.Name = "productenBtn";
            this.productenBtn.Size = new System.Drawing.Size(200, 69);
            this.productenBtn.TabIndex = 3;
            this.productenBtn.Text = "Producten";
            this.productenBtn.UseVisualStyleBackColor = false;
            this.productenBtn.Click += new System.EventHandler(this.ProductenBtn_Click);
            // 
            // KassaSysteem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1212, 587);
            this.Controls.Add(this.contentPanel);
            this.Controls.Add(this.menuPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1230, 634);
            this.Name = "KassaSysteem";
            this.Text = "KassaSysteem";
            this.menuPanel.ResumeLayout(false);
            this.ProductenMenuPanel.ResumeLayout(false);
            this.klantenMenuPanel.ResumeLayout(false);
            this.voorraadPanel.ResumeLayout(false);
            this.kassaMenuPanel.ResumeLayout(false);
            this.contentPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel menuPanel;
        private System.Windows.Forms.Panel kassaMenuPanel;
        private System.Windows.Forms.Button kassaBtn;
        private System.Windows.Forms.Panel voorraadPanel;
        private System.Windows.Forms.Button voorraadBtn;
        private System.Windows.Forms.Panel contentPanel;
        private System.Windows.Forms.Panel klantenMenuPanel;
        private System.Windows.Forms.Button KlantMenuButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel ProductenMenuPanel;
        private System.Windows.Forms.Button productenBtn;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

