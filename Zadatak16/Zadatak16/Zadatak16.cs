﻿using System;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonDodaj_Click(object sender, EventArgs e)
        {
            Unos_novog_studenta unosForm = new Unos_novog_studenta();
            DialogResult result = unosForm.ShowDialog();

            if (result == DialogResult.OK)
            {
                listBoxStudenti.Items.Add(unosForm.Student1.ToString());
            }

        }

        private void buttonObrisiStudenta_Click(object sender, EventArgs e)
        {
            if (listBoxStudenti.SelectedIndex >= 0)
            {
                listBoxStudenti.Items.RemoveAt(listBoxStudenti.SelectedIndex);
            }
        }

        private void buttonObrisiSve_Click(object sender, EventArgs e)
        {
            listBoxStudenti.Items.Clear();
        }
    }
}
