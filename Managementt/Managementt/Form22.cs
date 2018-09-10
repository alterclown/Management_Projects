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
    public partial class Form22 : Form
    {
        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=management;Integrated Security=True");
        public Form22()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string q = @"UPDATE  product 
            SET cat_id='" + comboBox2.Text + "',prod_id=" + textBox9.Text + ",prod_name='" + textBox8.Text + "',stock = " + textBox7.Text + " ,price = " + textBox6.Text + ",description = '" + textBox5.Text + "' WHERE( prod_id=" + textBox9.Text + ")";
            con.Open();
            SqlCommand cmd = new SqlCommand(q, con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Successfully Updated......!");
            //Display();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from product where cat_id = '" + comboBox2.SelectedItem.ToString() + "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                textBox9.Text = dr["prod_id"].ToString();
                textBox8.Text = dr["prod_name"].ToString();
                textBox7.Text = dr["stock"].ToString();
                textBox6.Text = dr["price"].ToString();
                textBox5.Text = dr["description"].ToString();
            }
            con.Close();
        }
        public void a()
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from product";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                comboBox2.Items.Add(dr["cat_id"].ToString());
            }
            con.Close();


        }

        private void Form22_Load(object sender, EventArgs e)
        {
            a();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
   
}
