using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Managementt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 a = new Form2();
            a.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form16 a = new Form16();
            a.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form18 a = new Form18();
            a.Show();
        }
    }
}
