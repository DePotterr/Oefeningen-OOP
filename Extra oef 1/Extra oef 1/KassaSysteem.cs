using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Extra_oef_1
{
    public partial class KassaSysteem : Form
    {
        bool isExternAccessoires;
        //
        //menu control
        //
        bool isKassaMenu = false;
        bool isVoorraadMenu = false;
        bool isKlantenMenu = false;
        bool isProductenMenu = false;
        //
        //Controls
        //
        Panel winkelmandPanel = new Panel();
        Button productToevoegenWinkelmandBtn = new Button();
        Button betalenBtn = new Button();
        Button productenAanvullenBtn = new Button();
        Button klantToevoegenBtn = new Button();
        Button productToevoegenBtn = new Button();
        Button productVerwijderenBtn = new Button();
        ListBox productenListBox = new ListBox();
        TextBox winkelmandTextBox = new TextBox();
        TextBox klantNaamTextBox = new TextBox();
        TextBox klantVoornaamTextBox = new TextBox();
        TextBox productNaamTextBox = new TextBox();
        TextBox afmetingenProductTextBox = new TextBox();
        ComboBox klantenCombobox = new ComboBox();
        Label subtotaalLbl = new Label();
        NumericUpDown voorraadNUD = new NumericUpDown();
        NumericUpDown prijsNUD = new NumericUpDown();
        CheckBox extraGarantieCheckBox = new CheckBox();
        CheckBox isDraadloosCheckBox = new CheckBox();
        RadioButton externeAccessoiresRadiobutton = new RadioButton();
        RadioButton interneOnderdelenRadioButton = new RadioButton();
        //
        //PCWinkel
        //
        PCWinkel winkel = new PCWinkel();
        public KassaSysteem()
        {
            InitializeComponent();
            winkel.ProductToevoegen(new ExterneAccessoires("Scherm", 50, 5, false, false));
            winkel.ProductToevoegen(new ExterneAccessoires("Muis", 100, 9, false, true));
            winkel.ProductToevoegen(new ExterneAccessoires("Toetsenbord", 150, 15, true, false));
            winkel.ProductToevoegen(new InterneOnderdelen("GPU", 50, 5, false, "150cm*50cm*30cm"));
            winkel.ProductToevoegen(new InterneOnderdelen("Moederbord", 100, 9, false, "150cm*100cm*20cm"));
            winkel.ProductToevoegen(new InterneOnderdelen("Processor", 150, 15, true, "10cm*10cm*1cm"));
            winkel.KlantToevoegen(new Klant("Lisanne", "Gouwloos"));
            klantenCombobox.DataSource = winkel.Klanten;
            productenListBox.DataSource = winkel.Producten;
            externeAccessoiresRadiobutton.Checked = true;
            betalenBtn.Click += new EventHandler(BetalenBtn_Click);
            productToevoegenWinkelmandBtn.Click += new EventHandler(ProductToevoegenWinkelmandBtn_Click);
            klantenCombobox.SelectedIndexChanged += new EventHandler(klantenCombobox_SelectedIndexChanged);
            productenAanvullenBtn.Click += new EventHandler(ProductenAanvullenBtn_Click);
            klantToevoegenBtn.Click += new EventHandler(KlantToevoegenBtn_Click);
            productToevoegenBtn.Click += new EventHandler(ProductToevoegenBtn_Click);
            productVerwijderenBtn.Click += new EventHandler(productVerwijderenBtn_Click);
            externeAccessoiresRadiobutton.CheckedChanged += new EventHandler(externeAccessoiresRadiobutton_CheckedChanged);
            SubtotaalUpdaten();
            UpdateRadiobuttons();
        }
        //
        //GUI
        //
        private void KassaGUI()
        {
            if (!isKassaMenu)
            {
                this.contentPanel.Controls.Clear();
                //
                //ProductButton
                //
                if (WindowState == FormWindowState.Maximized)
                {
                    productToevoegenWinkelmandBtn.Location = new Point(549, 270);
                }
                else
                {
                    productToevoegenWinkelmandBtn.Location = new Point(226, 270);
                }
                productToevoegenWinkelmandBtn.Text = "Toevoegen";
                productToevoegenWinkelmandBtn.Name = "productToevoegenBtn";
                productToevoegenWinkelmandBtn.Size = new Size(120, 41);
                productToevoegenWinkelmandBtn.Font = new Font("Microsoft Sans Serif", 15);
                productToevoegenWinkelmandBtn.Padding = new Padding(0);
                productToevoegenWinkelmandBtn.Anchor = AnchorStyles.Top;
                productToevoegenWinkelmandBtn.FlatStyle = FlatStyle.Flat;
                productToevoegenWinkelmandBtn.FlatAppearance.BorderSize = 0;
                productToevoegenWinkelmandBtn.BackColor = Color.FromArgb(43, 43, 43);
                productToevoegenWinkelmandBtn.ForeColor = Color.White;
                //
                //ProductenListBox
                //
                productenListBox.Location = new Point(200, 0);
                productenListBox.BackColor = Color.FromArgb(242, 242, 242);
                productenListBox.BorderStyle = BorderStyle.None;
                productenListBox.Size = new Size(945, 200);
                productenListBox.Name = "productenListBox";
                productenListBox.Font = new Font("Microsoft Sans Serif", 10);
                productenListBox.Dock = DockStyle.Top;
                //
                //KlantenComboBox
                //
                if (WindowState == FormWindowState.Maximized)
                {
                    klantenCombobox.Location = new Point(549, 217);
                }
                else
                {
                    klantenCombobox.Location = new Point(226, 217);
                }
                klantenCombobox.Size = new Size(200, 24);
                klantenCombobox.Anchor = AnchorStyles.Top;
                klantenCombobox.Name = "klantenCombobox";
                //
                //WinkelmandPanel
                //
                winkelmandPanel.Dock = DockStyle.Right;
                winkelmandPanel.Name = "winkelmandPanel";
                winkelmandPanel.BackColor = Color.FromArgb(43, 43, 43);
                //
                //WinkelmandTextBox
                //
                winkelmandTextBox.Dock = DockStyle.Top;
                winkelmandTextBox.Size = new Size(200, 350);
                winkelmandTextBox.Multiline = true;
                winkelmandTextBox.Name = "winkelmandTextBox";
                winkelmandTextBox.BackColor = Color.FromArgb(43, 43, 43);
                winkelmandTextBox.BorderStyle = BorderStyle.None;
                winkelmandTextBox.ForeColor = Color.White;
                //
                //LabelSubTotaal
                //
                subtotaalLbl.Dock = DockStyle.Bottom;
                subtotaalLbl.Size = new Size(200, 40);
                subtotaalLbl.Name = "subtotaalLbl";
                subtotaalLbl.Text = "SubTotaal: ";
                subtotaalLbl.ForeColor = Color.White;
                //
                //BetalenButton
                //
                betalenBtn.Dock = DockStyle.Bottom;
                betalenBtn.Size = new Size(200, 46);
                betalenBtn.Name = "betalenBtn";
                betalenBtn.Text = "Betalen";
                betalenBtn.Font = new Font("Microsoft Sans Serif", 15);
                betalenBtn.ForeColor = Color.White;
                betalenBtn.FlatStyle = FlatStyle.Flat;
                betalenBtn.FlatAppearance.BorderSize = 0;
                //
                //AddControls
                //
                this.contentPanel.Controls.Add(productToevoegenWinkelmandBtn);
                this.contentPanel.Controls.Add(productenListBox);
                this.contentPanel.Controls.Add(klantenCombobox);
                this.contentPanel.Controls.Add(winkelmandPanel);
                this.winkelmandPanel.Controls.Add(winkelmandTextBox);
                this.winkelmandPanel.Controls.Add(subtotaalLbl);
                this.winkelmandPanel.Controls.Add(betalenBtn);

                isKassaMenu = true;
                isVoorraadMenu = false;
                isKlantenMenu = false;
                isProductenMenu = false;
            }
        }
        private void VoorraadGUI()
        {
            if (!isVoorraadMenu)
            {
                this.contentPanel.Controls.Clear();
                //
                //ProductenListBox
                //
                productenListBox.Location = new Point(200, 0);
                productenListBox.BackColor = Color.FromArgb(242, 242, 242);
                productenListBox.BorderStyle = BorderStyle.None;
                productenListBox.Size = new Size(945, 200);
                productenListBox.Name = "productenListBox";
                productenListBox.Font = new Font("Microsoft Sans Serif", 10);
                productenListBox.Dock = DockStyle.Top;
                //
                //ProductenAanvullen
                //
                if (WindowState == FormWindowState.Maximized)
                {
                    productenAanvullenBtn.Location = new Point(625, 270);
                }
                else
                {
                    productenAanvullenBtn.Location = new Point(302, 270);
                }
                productenAanvullenBtn.Text = "Aanvullen";
                productenAanvullenBtn.Name = "productenAanvullenBtn";
                productenAanvullenBtn.Size = new Size(118, 41);
                productenAanvullenBtn.Font = new Font("Microsoft Sans Serif", 15);
                productenAanvullenBtn.Padding = new Padding(0);
                productenAanvullenBtn.Anchor = AnchorStyles.Top;
                productenAanvullenBtn.FlatStyle = FlatStyle.Flat;
                productenAanvullenBtn.FlatAppearance.BorderSize = 0;
                productenAanvullenBtn.BackColor = Color.FromArgb(43, 43, 43);
                productenAanvullenBtn.ForeColor = Color.White;
                //
                //Controls toevoegen
                //
                this.contentPanel.Controls.Add(productenListBox);
                this.contentPanel.Controls.Add(productenAanvullenBtn);

                isVoorraadMenu = true;
                isKassaMenu = false;
                isKlantenMenu = false;
                isProductenMenu = false;
            }
        }
        private void KlantenGUI()
        {
            if (!isKlantenMenu)
            {
                this.contentPanel.Controls.Clear();
                //
                //Klant voornaam textbox
                //
                if (WindowState == FormWindowState.Maximized)
                {
                    klantVoornaamTextBox.Location = new Point(625, 47);
                }
                else
                {
                    klantVoornaamTextBox.Location = new Point(302, 47);
                }
                klantVoornaamTextBox.Size = new Size(184, 22);
                klantVoornaamTextBox.Name = "klantVoornaamTextBox";
                klantVoornaamTextBox.Text = "Voornaam";
                klantVoornaamTextBox.Anchor = AnchorStyles.Top;
                //
                //Klant naam textbox
                //
                if (WindowState == FormWindowState.Maximized)
                {
                    klantNaamTextBox.Location = new Point(625, 70);
                }
                else
                {
                    klantNaamTextBox.Location = new Point(302, 70);
                }
                klantNaamTextBox.Size = new Size(184, 22);
                klantNaamTextBox.Name = "klantNaamTextBox";
                klantNaamTextBox.Text = "Naam";
                klantNaamTextBox.Anchor = AnchorStyles.Top;
                //
                //Klant toevoegen button
                //
                klantToevoegenBtn.Name = "klantToevoegenBtn";
                klantToevoegenBtn.Text = "Klant toevoegen";
                if (WindowState == FormWindowState.Maximized)
                {
                    klantToevoegenBtn.Location = new Point(625, 99);
                }
                else
                {
                    klantToevoegenBtn.Location = new Point(302, 99);
                }
                klantToevoegenBtn.Size = new Size(184, 41);
                klantToevoegenBtn.FlatStyle = FlatStyle.Flat;
                klantToevoegenBtn.FlatAppearance.BorderSize = 0;
                klantToevoegenBtn.Font = new Font("Microsoft Sans Serif", 15);
                klantToevoegenBtn.Padding = new Padding(0);
                klantToevoegenBtn.Anchor = AnchorStyles.Top;
                klantToevoegenBtn.BackColor = Color.FromArgb(43, 43, 43);
                klantToevoegenBtn.ForeColor = Color.White;
                //
                //Controls toevoegen
                //
                this.contentPanel.Controls.Add(klantVoornaamTextBox);
                this.contentPanel.Controls.Add(klantNaamTextBox);
                this.contentPanel.Controls.Add(klantToevoegenBtn);
                isKlantenMenu = true;
                isVoorraadMenu = false;
                isKassaMenu = false;
                isProductenMenu = false;
            }
        }
        private void ProductenGUI()
        {
            if (!isProductenMenu)
            {
                this.contentPanel.Controls.Clear();
                //
                //ProductenListBox
                //
                productenListBox.Location = new Point(200, 0);
                productenListBox.BackColor = Color.FromArgb(242, 242, 242);
                productenListBox.BorderStyle = BorderStyle.None;
                productenListBox.Size = new Size(945, 200);
                productenListBox.Name = "productenListBox";
                productenListBox.Font = new Font("Microsoft Sans Serif", 10);
                productenListBox.Dock = DockStyle.Top;
                //
                //Producten toevoegen btn
                //
                if (WindowState == FormWindowState.Maximized)
                {
                    productToevoegenBtn.Location = new Point(525, 370);
                }
                else
                {
                    productToevoegenBtn.Location = new Point(202, 370);
                }
                productToevoegenBtn.Text = "Toevoegen";
                productToevoegenBtn.Name = "productToevoegenBtn";
                productToevoegenBtn.Size = new Size(120, 41);
                productToevoegenBtn.Font = new Font("Microsoft Sans Serif", 15);
                productToevoegenBtn.Padding = new Padding(0);
                productToevoegenBtn.Anchor = AnchorStyles.Top;
                productToevoegenBtn.FlatStyle = FlatStyle.Flat;
                productToevoegenBtn.FlatAppearance.BorderSize = 0;
                productToevoegenBtn.BackColor = Color.FromArgb(43, 43, 43);
                productToevoegenBtn.ForeColor = Color.White;
                //
                //Producten verwijderen btn
                //
                if (WindowState == FormWindowState.Maximized)
                {
                    productVerwijderenBtn.Location = new Point(725, 370);
                }
                else
                {
                    productVerwijderenBtn.Location = new Point(402, 370);
                }
                productVerwijderenBtn.Text = "Verwijderen";
                productVerwijderenBtn.Name = "productVerwijderenBtn";
                productVerwijderenBtn.Size = new Size(123, 41);
                productVerwijderenBtn.Font = new Font("Microsoft Sans Serif", 15);
                productVerwijderenBtn.Padding = new Padding(0);
                productVerwijderenBtn.Anchor = AnchorStyles.Top;
                productVerwijderenBtn.FlatStyle = FlatStyle.Flat;
                productVerwijderenBtn.FlatAppearance.BorderSize = 0;
                productVerwijderenBtn.BackColor = Color.FromArgb(43, 43, 43);
                productVerwijderenBtn.ForeColor = Color.White;
                //
                //naam product textbox
                //
                if (WindowState == FormWindowState.Maximized)
                {
                    productNaamTextBox.Location = new Point(496, 220);
                }
                else
                {
                    productNaamTextBox.Location = new Point(173, 220);
                }
                productNaamTextBox.Size = new Size(184, 22);
                productNaamTextBox.Name = "productNaamTextBox";
                productNaamTextBox.Text = "Naam";
                productNaamTextBox.Anchor = AnchorStyles.Top;
                //
                //prijs product numeric
                //
                if (WindowState == FormWindowState.Maximized)
                {
                    prijsNUD.Location = new Point(496, 243);
                }
                else
                {
                    prijsNUD.Location = new Point(173, 243);
                }
                prijsNUD.Size = new Size(184, 22);
                prijsNUD.Name = "prijsNUD";
                prijsNUD.Anchor = AnchorStyles.Top;
                prijsNUD.Maximum = 10000;
                //
                //product voorraad numeric
                //
                if (WindowState == FormWindowState.Maximized)
                {
                    voorraadNUD.Location = new Point(496, 266);
                }
                else
                {
                    voorraadNUD.Location = new Point(173, 266);
                }
                voorraadNUD.Size = new Size(184, 22);
                voorraadNUD.Name = "voorraadNUD";
                voorraadNUD.Anchor = AnchorStyles.Top;
                //
                //prijs extra garantie numeric
                //
                if (WindowState == FormWindowState.Maximized)
                {
                    extraGarantieCheckBox.Location = new Point(496, 289);
                }
                else
                {
                    extraGarantieCheckBox.Location = new Point(173, 289);
                }
                extraGarantieCheckBox.Size = new Size(105, 22);
                extraGarantieCheckBox.Name = "extraGarantieCheckBox";
                extraGarantieCheckBox.Text = "Extra garantie";
                extraGarantieCheckBox.Anchor = AnchorStyles.Top;
                extraGarantieCheckBox.Font = new Font("Microsoft Sans Serif", 9);
                extraGarantieCheckBox.ForeColor = Color.Black;
                //
                //Externe accessoires radiobutton
                //
                if (WindowState == FormWindowState.Maximized)
                {
                    externeAccessoiresRadiobutton.Location = new Point(350, 220);
                }
                else
                {
                    externeAccessoiresRadiobutton.Location = new Point(28, 220);
                }
                externeAccessoiresRadiobutton.Size = new Size(184, 22);
                externeAccessoiresRadiobutton.Name = "externeAccessoiresRadiobutton";
                externeAccessoiresRadiobutton.Text = "Externe accessoires";
                externeAccessoiresRadiobutton.Anchor = AnchorStyles.Top;
                //
                //Interne onderdelen radiobutton
                //
                if (WindowState == FormWindowState.Maximized)
                {
                    interneOnderdelenRadioButton.Location = new Point(350, 240);
                }
                else
                {
                    interneOnderdelenRadioButton.Location = new Point(28, 240);
                }
                interneOnderdelenRadioButton.Size = new Size(184, 22);
                interneOnderdelenRadioButton.Name = "interneOnderdelenRadioButton";
                interneOnderdelenRadioButton.Text = "Interne onderdelen";
                interneOnderdelenRadioButton.Anchor = AnchorStyles.Top;
                //
                //IsDraadloos checkbox
                //
                if (WindowState == FormWindowState.Maximized)
                {
                    isDraadloosCheckBox.Location = new Point(496, 312);
                }
                else
                {
                    isDraadloosCheckBox.Location = new Point(173, 312);
                }
                isDraadloosCheckBox.Size = new Size(105, 22);
                isDraadloosCheckBox.Name = "isDraadloosCheckBox";
                isDraadloosCheckBox.Text = "Draadloos";
                isDraadloosCheckBox.Anchor = AnchorStyles.Top;
                isDraadloosCheckBox.Font = new Font("Microsoft Sans Serif", 9);
                isDraadloosCheckBox.ForeColor = Color.Black;
                //
                //Afmetingen textbox
                //
                if (WindowState == FormWindowState.Maximized)
                {
                    afmetingenProductTextBox.Location = new Point(496, 335);
                }
                else
                {
                    afmetingenProductTextBox.Location = new Point(173, 335);
                }
                afmetingenProductTextBox.Size = new Size(184, 22);
                afmetingenProductTextBox.Name = "afmetingenProductTextBox";
                afmetingenProductTextBox.Text = "Afmetingen";
                afmetingenProductTextBox.Anchor = AnchorStyles.Top;
                //
                //Controls toevoegen
                //
                this.contentPanel.Controls.Add(productenListBox);
                this.contentPanel.Controls.Add(productToevoegenBtn);
                this.contentPanel.Controls.Add(productVerwijderenBtn);
                this.contentPanel.Controls.Add(productNaamTextBox);
                this.contentPanel.Controls.Add(prijsNUD);
                this.contentPanel.Controls.Add(voorraadNUD);
                this.contentPanel.Controls.Add(extraGarantieCheckBox);
                this.contentPanel.Controls.Add(externeAccessoiresRadiobutton);
                this.contentPanel.Controls.Add(interneOnderdelenRadioButton);
                this.contentPanel.Controls.Add(isDraadloosCheckBox);
                this.contentPanel.Controls.Add(afmetingenProductTextBox);
                isProductenMenu = true;
                isKassaMenu = false;
                isKlantenMenu = false;
                isVoorraadMenu = false;
            }
        }
        //
        //Menu
        //
        private void KassaBtn_Click(object sender, EventArgs e)
        {
            productenListBox.ClearSelected();
            KassaGUI();
        }
        private void VoorraadBtn_Click(object sender, EventArgs e)
        {
            productenListBox.ClearSelected();
            VoorraadGUI();
        }
        private void KlantMenuButton_Click(object sender, EventArgs e)
        {
            productenListBox.ClearSelected();
            KlantenGUI();
        }
        private void ProductenBtn_Click(object sender, EventArgs e)
        {
            productenListBox.ClearSelected();
            ProductenGUI();
        }
        //
        //button events
        //
        private void BetalenBtn_Click(object sender, EventArgs e)
        {
            try
            {
                double totaal = ((Klant)klantenCombobox.SelectedItem).Betalen();
                MessageBox.Show(totaal.ToString());
                UpdateWinkelmand();
                SubtotaalUpdaten();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            UpdateProducten();
        }
        private void ProductToevoegenWinkelmandBtn_Click(object sender, EventArgs e)
        {
            try
            {
                ((Klant)klantenCombobox.SelectedItem).ProductToevoegen((Product)productenListBox.SelectedItem);
            }
            catch (UitverkochtException ex)
            {
                MessageBox.Show(ex.Message);
            }
            UpdateProducten();
            UpdateWinkelmand();
            UpdateKlanten();
            SubtotaalUpdaten();
        }
        private void klantenCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateWinkelmand();
            SubtotaalUpdaten();
        }
        private void ProductenAanvullenBtn_Click(object sender, EventArgs e)
        {
            ((Product)productenListBox.SelectedItem).VoorraadBijvullen(1);
            UpdateProducten();
        }
        private void KlantToevoegenBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Klant nieuweKlant = new Klant(klantVoornaamTextBox.Text, klantNaamTextBox.Text);
                winkel.KlantToevoegen(nieuweKlant);
            }
            catch (KlantBestaatAlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void ProductToevoegenBtn_Click(object sender, EventArgs e)
        {
            if (isExternAccessoires)
            {
                ExterneAccessoires product = new ExterneAccessoires(productNaamTextBox.Text, double.Parse(prijsNUD.Value.ToString()), int.Parse(voorraadNUD.Value.ToString()), extraGarantieCheckBox.Checked, isDraadloosCheckBox.Checked);
                winkel.ProductToevoegen(product);
            }
            else
            {
                InterneOnderdelen product = new InterneOnderdelen(productNaamTextBox.Text, double.Parse(prijsNUD.Value.ToString()), int.Parse(voorraadNUD.Value.ToString()), extraGarantieCheckBox.Checked, afmetingenProductTextBox.Text);
                winkel.ProductToevoegen(product);
            }
            UpdateProducten();
        }
        private void productVerwijderenBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Product product = (Product)productenListBox.SelectedItem;
                winkel.ProductVerwijderen(product);
                MessageBox.Show("Product verwijderd\n" + product.Naam,"Succes");
            }
            catch (Exception)
            {
                MessageBox.Show("Kon product niet verwijderen.","ERROR");
            }
            UpdateProducten();
            productenListBox.ClearSelected();
        }
        //
        //Checked changed event producten
        //
        private void externeAccessoiresRadiobutton_CheckedChanged(object sender, EventArgs e)
        {
            UpdateRadiobuttons();
        }
        //
        //Update Controls
        //
        private void UpdateProducten()
        {
            productenListBox.DataSource = null;
            //BUGFIX WANNEER LIJST LEEG IS
            if(winkel.Producten.Count != 0)
            {
                productenListBox.DataSource = winkel.Producten;

            }
        }
        private void UpdateKlanten()
        {
            klantenCombobox.DataSource = null;
            klantenCombobox.DataSource = winkel.Klanten;
        }
        private void UpdateWinkelmand()
        {
            try
            {
                winkelmandTextBox.Text = ((Klant)klantenCombobox.SelectedItem).DrukWinkelkarAf();
                ((Klant)klantenCombobox.SelectedItem).SorteerWinkelmandNaam();
            }
            catch (NullReferenceException)
            {
            }
        }
        private void SubtotaalUpdaten()
        {
            try
            {
                subtotaalLbl.Text = "Subtotaal:" + ((Klant)klantenCombobox.SelectedItem).SubTotaal().ToString();
            }
            catch (NullReferenceException)
            {
            }
        }
        private void UpdateRadiobuttons()
        {
            if (externeAccessoiresRadiobutton.Checked)
            {
                isExternAccessoires = true;
                isDraadloosCheckBox.Enabled = true;
                afmetingenProductTextBox.Enabled = false;
            }
            else
            {
                isExternAccessoires = false;
                isDraadloosCheckBox.Enabled = false;
                afmetingenProductTextBox.Enabled = true;
            }
        }
    }
}
