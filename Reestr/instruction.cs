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
    public partial class instruction : Form
    {
        public instruction()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("C:\\Users\\Yivanova\\source\\repos\\Reestr\\mi-16-1-polozhenie-po-hraneniyu-i-peredachi-aktov-soglasovaniya-granic.doc");
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("C:\\Users\\Yivanova\\source\\repos\\Reestr\\mi-18-1-ispravlenie-chasti-granicy-smezhnogo-zu.pdf");
        }

        private void вступитьВСРОToolStripMenuItem_Click(object sender, EventArgs e)
        {
            history history = new history();
            this.Hide();
            history.Show();
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
    }
}
