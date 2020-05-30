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
        public int pagina = 0;
        public List<Student> studenten = new List<Student>();
        public Form1()
        {
            InitializeComponent();
            faciliteitenComboBox.DataSource = Enum.GetValues(typeof(Faciliteiten));
            geslachtComboBox.DataSource = Enum.GetValues(typeof(Geslachten));
            statuutCheckBox.Checked = true;
            UpdateLabels();
        }
        public void UpdateLabels()
        {
            if(studenten.Count == 0)
            {
                voornaamLabelTonen.Text = "";
                naamLabelTonen.Text = "";
                faciliteitLabelTonen.Text = "";
                studentennrLabel.Text = "";
            }
            else
            {
                if (IsFaciliteit(studenten[pagina]))
                {
                    faciliteitLabelTonen.Text = ((FaciliteitStudet)studenten[pagina]).Faciliteit.ToString();
                }
                else
                {
                    faciliteitLabelTonen.Text = "";
                }
                voornaamLabelTonen.Text = studenten[pagina].Voornaam;
                naamLabelTonen.Text = studenten[pagina].Naam;
                studentennrLabel.Text = studenten[pagina].Studentennr.ToString();
            }
        }
        public bool IsFaciliteit(Student student)
        {
            if(student.GetType() == typeof(Student))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public double ZoekTijdsduurExamenStudent(int studentnr, Examen examen)
        {
            for (int i = 0; i < studenten.Count; i++)
            {
                if (studenten[i].Studentennr == studentnr)
                {
                    return examen.BerekenTijdsduurStudent(studenten[i]);
                }
            }
            throw new Exception("Kon tijdsduur van student niet vinden.");
        }

        private void ToevoegenButton_Click(object sender, EventArgs e)
        {
            try
            {
                Student student;
                if (statuutCheckBox.Checked)
                {
                    student = new FaciliteitStudet(voornaamTextBox.Text, naamTextBox.Text, adresTextBox.Text, (Geslachten)geslachtComboBox.SelectedItem, (Faciliteiten)faciliteitenComboBox.SelectedItem);
                }
                else
                {
                    student = new Student(voornaamTextBox.Text, naamTextBox.Text, adresTextBox.Text, (Geslachten)geslachtComboBox.SelectedItem);
                }
                studenten.Add(student);
                UpdateLabels();
            }
            catch (CustumExceptionStudentNaam ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (CustumExceptionStudentAdres ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            if(pagina < studenten.Count - 1)
            {
                pagina++;
                UpdateLabels();
            }
        }

        private void PreviousButton_Click(object sender, EventArgs e)
        {
            if (pagina > 0)
            {
                pagina--;
                UpdateLabels();
            }
        }

        private void StatuutCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (statuutCheckBox.Checked)
            {
                faciliteitenComboBox.Enabled = true;
            }
            else
            {
                faciliteitenComboBox.Enabled = false;
            }
        }
    }
}
