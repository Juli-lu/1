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
    public partial class vhod : Form
    {
        public vhod()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 glavn = new Form1();
            this.Hide();
            glavn.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "Julia" && textBox2.Text == "1234")
            {
                Form1 glavn = new Form1();
                this.Hide();
                glavn.Show();
            }
            else
                MessageBox.Show("Введен неверный логин или пароль!");
        }

        private void button3_Click(object sender, EventArgs e)
        {
        }
    }
}
