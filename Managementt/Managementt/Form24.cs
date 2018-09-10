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
    public partial class Form24 : Form
    {
        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=management;Integrated Security=True");
        public Form24()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=management;Integrated Security=True");
            SqlDataAdapter sda = new SqlDataAdapter(@"select * from manage_customer", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand(@"DELETE FROM manage_customer ", con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Deleted Successfully......!");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string q = @"INSERT INTO manage_customer 
                     (cust_id,first_name,last_name,tel,email)
                   VALUES(" + textBox1.Text + ",'" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "')";
            con.Open();
            SqlCommand cmd = new SqlCommand(q, con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Successfully saved......!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string q = @"UPDATE  manage_customer 
            SET cust_id = " + textBox1.Text + ",first_name ='" + textBox2.Text + "',last_name ='" + textBox3.Text + "',tel ='" + textBox4.Text + "',email ='" + textBox5.Text + "' WHERE( cust_id=" + textBox1.Text + ")";
            con.Open();
            SqlCommand cmd = new SqlCommand(q, con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Successfully Updated......!");
        }
    }
    }

