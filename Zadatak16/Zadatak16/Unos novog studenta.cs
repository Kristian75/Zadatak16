using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadatak16
{
    public partial class Unos_novog_studenta : Form
    {
        private Student student1;

        public Student Student1
        {
            get { return student1; }
            set { student1 = value; }
        }

        public Unos_novog_studenta()
        {
            InitializeComponent();
            comboBoxSmjer.Items.Add("Programer");
            comboBoxSmjer.Items.Add("Sistem administrator");
            comboBoxSmjer.Items.Add("Mrežni administrator");
        }

        private void buttonSnimi_Click(object sender, EventArgs e)
        {
            student1 = new Student
            {
                Ime = textBoxIme.Text,
                Prezime = textBoxPrezime.Text,
                BrojIndeksa = textBoxBrojIndeksa.Text,
                Smjer = comboBoxSmjer.SelectedItem.ToString(),
                DatumRodjenja = dateTimePickerDatumRodjenja.Value
            };

            DialogResult = DialogResult.OK;
            Close();
        }

        private void buttonOtkazi_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void comboBoxSmjer_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
