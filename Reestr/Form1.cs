using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reestr
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void реестрToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void вступитьВСРОToolStripMenuItem_Click(object sender, EventArgs e)
        {
            history inn = new history();
            inn.Show();
            this.Hide();
        }

        private void политикаСРОToolStripMenuItem_Click(object sender, EventArgs e)
        {
            politic politic = new politic();
            politic.Show();
            this.Hide();
        }

        private void стандартыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            standarts standarts = new standarts();
            this.Hide();
            standarts.Show();
        }

        private void инструкцииToolStripMenuItem_Click(object sender, EventArgs e)
        {
            instruction instruction = new instruction();
            instruction.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            vhod vhod = new vhod();
            this.Hide();
            vhod.Show();
        }

        private void действующиеЧленыСРОToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
