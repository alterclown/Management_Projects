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
    public partial class Form8 : Form
    {
        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=management;Integrated Security=True");
        public Form8()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from food_add where new_food = '" + comboBox1.SelectedItem.ToString() + "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                textBox1.Text = dr["new_food"].ToString();
                textBox2.Text = dr["price"].ToString();

            }
            con.Close();
        }
        public void a()
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from food_add";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                comboBox1.Items.Add(dr["new_food"].ToString());
            }
            con.Close();


        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string q = @"INSERT INTO bill 
                     (bill_no,sel_table,date,f_name,price,quantity,total_price)
                   VALUES('" + textBox6.Text + "','" + comboBox1.Text + "','" + textBox7.Text + "','" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox5.Text + "')";
            con.Open();
            SqlCommand cmd = new SqlCommand(q, con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Successfully saved......!");
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            a();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int price = Convert.ToInt32(this.textBox2.Text);
            int qty = Convert.ToInt32(this.textBox3.Text);
            
            double calculate = price * qty;
            textBox4.Text = calculate.ToString();
            textBox5.Text = calculate.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

