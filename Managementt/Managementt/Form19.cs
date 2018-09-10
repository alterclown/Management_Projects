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
    public partial class Form19 : Form
    {
        public Form19()
        {
            InitializeComponent();
        }

        private void productToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form20 a = new Form20();
            a.Show();
        }

        private void categoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form23 a = new Form23();
            a.Show();
        }

        private void customerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form24 a = new Form24();
            a.Show();
        }

        private void orderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form25 a = new Form25();
            a.Show();
        }

        private void userToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
    }
}
