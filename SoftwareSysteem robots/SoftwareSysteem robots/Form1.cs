using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftwareSysteem_robots
{
    public partial class Form1 : Form
    {
        readonly List<Robot> robots = new List<Robot>();
        public Form1()
        {
            InitializeComponent();
            robots.Add(new DweilRobot("dweilrobot",waterCheckBox2.Checked,zeepCheckBox.Checked));
            robots.Add(new StofzuigenRobot("stofzuigrobot",opvangbakCheckBox.Checked));
            robots.Add(new GrasmaaienRobot("grasmaairobot", opvangbakCheckBox.Checked));
            robots.Sort();
            comboBox1.DataSource = robots;
            listBox1.DataSource = robots;
            timer1.Interval = 10;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (CheckPower())
            {
                ((Robot)comboBox1.SelectedItem).Uitschakelen();
                timer1.Stop();
            }
            else
            {
                try
                {
                    ((Robot)comboBox1.SelectedItem).Opstarten();
                    timer1.Start();
                }
                catch (CustumRobotException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.Message);
                }
            }
            UpdateLabels();
        }
        public bool CheckPower()
        {
            if (((Robot)comboBox1.SelectedItem).PowerOn)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void UpdateLabels()
        {
            if (CheckPower())
            {
                label2.Text = "Robot staat aan.";
                Butopstarten.Text = "Uitzetten";
            }
            else
            {
                Butopstarten.Text = "Aanzetten";
                label2.Text = "Robot staat af.";
            }
            label1.Text = ((Robot)comboBox1.SelectedItem).Batterijverbuik.ToString();
            if (typeof(DweilRobot) == comboBox1.SelectedItem.GetType())
            {
                opvangbakCheckBox.Enabled = false;
                waterCheckBox2.Enabled = true;
                zeepCheckBox.Enabled = true;
            }
            else
            {
                waterCheckBox2.Enabled = false;
                zeepCheckBox.Enabled = false;
                opvangbakCheckBox.Enabled = true;
            }
        }
        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateLabels();
        }

        private void WaterCheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            ((DweilRobot)comboBox1.SelectedItem).WaterAanwezig = waterCheckBox2.Checked;
            UpdateLabels();
        }

        private void ZeepCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            ((DweilRobot)comboBox1.SelectedItem).ZeepAanwezig = zeepCheckBox.Checked;
            UpdateLabels();
        }

        private void OpvangbakCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if(typeof(StofzuigenRobot) == comboBox1.SelectedItem.GetType())
            {
                ((StofzuigenRobot)comboBox1.SelectedItem).OpvangbakVol = opvangbakCheckBox.Checked;
            }
            else
            {
                ((GrasmaaienRobot)comboBox1.SelectedItem).OpvangbakVol = opvangbakCheckBox.Checked;
            }
            UpdateLabels();
        }

        private void OpladenButton_Click(object sender, EventArgs e)
        {
            ((Robot)comboBox1.SelectedItem).Opladen();
            UpdateLabels();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            UpdateLabels();
        }
    }
}
