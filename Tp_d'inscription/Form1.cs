using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tpvendredi_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Open the app", "open", MessageBoxButtons.OK, MessageBoxIcon.Information);
            maskedTextBox1.Mask = "00 00 00 00 00";
            monthCalendar1.MaxSelectionCount = 3;
        }
        private static int i=1;
        private void button1_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "") || (textBox2.Text == "") || (maskedTextBox1.Text == ""))
            {
                MessageBox.Show("Remplir tout les champs", "erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Confirmer l'ajout", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                listBox2.Items.Add("Nom et Prenom :" + textBox1.Text);
                listBox2.Items.Add("Date D'inscription :" + monthCalendar1.SelectionStart.ToShortDateString());
                listBox2.Items.Add("Adresse :" + textBox2.Text);
                listBox2.Items.Add("Téléphone :" + maskedTextBox1.Text);
                listBox2.Items.Add("------------------");
                listBox1.Items.Add(i);
                listBox1.Items.AddRange(new string[] { "", "", "" });
                i++;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            maskedTextBox1.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            listBox1.Items.Clear();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            monthCalendar1.MaxDate = DateTime.Today;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
          DialogResult d=  MessageBox.Show("close the  application?", "Close", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (d==DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }
    }
}
