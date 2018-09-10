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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void addTableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 a = new Form4();
            a.Show();
        }

        private void addFoodsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 a = new Form5();
            a.Show();
        }

        private void editFoodsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form6 a = new Form6();
            a.Show();
        }

        private void enterOrdersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form7 a = new Form7();
            a.Show();
        }

        private void billingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form8 a = new Form8();
            a.Show();
        }

        private void addCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form9 a = new Form9();
            a.Show();
        }

        private void editCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form10 a = new Form10();
            a.Show();
        }

        private void enterDebitAmountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form11 a = new Form11();
            a.Show();
        }

        private void tableReportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form12 a = new Form12();
            a.Show();
        }

        private void foodItemReportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form13 a = new Form13();
            a.Show();
        }

        private void debitCustomerReportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form14 a = new Form14();
            a.Show();
        }

        private void debitReportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form15 a = new Form15();
            a.Show();
        }
    }
}
