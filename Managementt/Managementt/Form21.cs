using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Managementt
{
    public partial class Form21 : Form
    {
        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=management;Integrated Security=True");
        public Form21()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string q = @"INSERT INTO product 
                     (cat_id,prod_id,prod_name,stock,price,description)
                   VALUES('" + comboBox1.Text + "'," + textBox1.Text + ",'" + textBox2.Text + "'," + textBox3.Text + "," + textBox4.Text + ",'" + textBox5.Text + "')";
            con.Open();
            SqlCommand cmd = new SqlCommand(q,con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Successfully saved......!");
           
        }
    }
}
