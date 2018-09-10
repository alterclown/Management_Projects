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
    public partial class Form18 : Form
    {
        public Form18()
        {
            InitializeComponent();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;

            if ((this.textBox1.Text == "Admin") && (this.textBox2.Text == "Admin"))
            {

                MessageBox.Show("you are granted with access");
                Form19 a = new Form19();
                a.Show();


            }
            else if ((this.textBox1.Text == "admin") && (this.textBox2.Text == "admin"))
            {
                MessageBox.Show("you are granted with access");
                Form19 a = new Form19();
                a.Show();
            }
            else
            {

                MessageBox.Show("you are not granted with access");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
