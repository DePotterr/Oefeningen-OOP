using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Herhalingsoef_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public bool TestString()
        {
            string tekst = textBox1.Text;
            bool isGoed = true;
            for (int i = 0; i < tekst.Length && isGoed; i++)
            {
                if (tekst[i] == '@' || tekst[i] == '/' || tekst[i] == '_')
                {
                    isGoed = false;
                }
            }
            return isGoed;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            bool resultTest = TestString();
            if (resultTest)
            {
                label1.Text = "Is oke!";
            }
            else
            {
                label1.Text = "Niet oke!";
            }
        }
    }
}
