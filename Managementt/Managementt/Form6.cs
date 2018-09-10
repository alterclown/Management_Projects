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
    public partial class Form6 : Form
    {
        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=management;Integrated Security=True");
        public Form6()
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
                comboBox1.Text = dr["new_food"].ToString();
                textBox1.Text = dr["price"].ToString();
                comboBox2.Text = dr["type"].ToString();
                comboBox3.Text = dr["time"].ToString();
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

        private void Form6_Load(object sender, EventArgs e)
        {
            a();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string q = @"UPDATE  food_add 
            SET new_food = '" + comboBox1.Text + "',price ='" + textBox1.Text + "',type ='" + comboBox2.Text + "',time ='" + comboBox3.Text + "' WHERE( new_food='" + comboBox1.Text + "')";
            con.Open();
            SqlCommand cmd = new SqlCommand(q, con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Successfully Updated......!");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
