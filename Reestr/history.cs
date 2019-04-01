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
    public partial class history : Form
    {
        public history()
        {
            InitializeComponent();
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
