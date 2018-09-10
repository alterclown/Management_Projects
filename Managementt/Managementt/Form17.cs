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
    public partial class Form17 : Form
    {
        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=management;Integrated Security=True");
        public Form17()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int weekdays = Convert.ToInt32(this.textBox6.Text);
            int saturdays = Convert.ToInt32(this.textBox5.Text);
            int sundays = Convert.ToInt32(this.textBox4.Text);

            int hour= Convert.ToInt32(this.textBox9.Text);
            int hoursat= Convert.ToInt32(this.textBox8.Text);
            int hoursun= Convert.ToInt32(this.textBox7.Text);

            int weekhour = weekdays * hour*8;
            int sathour = saturdays * hour * 8;
            int sunhour = sundays * hour * 8;

            double grosspay = weekhour+ sathour+ sunhour;
            double deduc = grosspay * (10 / 100);
            double tax = grosspay * (15 / 100);

            textBox12.Text = grosspay.ToString();
            textBox11.Text = deduc.ToString();
            textBox10.Text = tax.ToString();
            double TNP = grosspay - (deduc + tax);
            textBox13.Text = TNP.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string q = @"INSERT INTO employee 
                     (employee_no,sur_name,other_name,total_gross,total_net)
                   VALUES(" + textBox1.Text + ",'" + textBox2.Text + "','" + textBox3.Text + "'," + textBox12.Text + "," + textBox13.Text + ")";
            con.Open();
            SqlCommand cmd = new SqlCommand(q, con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Successfully saved......!");
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            textBox1.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            textBox12.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            textBox13.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString(); ;
        }

        void Display()
        {
            SqlDataAdapter sda = new SqlDataAdapter("Select * from employee", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.Rows.Clear();
            foreach (DataRow item in dt.Rows)
            {
                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[0].Value = item["employee_no"].ToString();
                dataGridView1.Rows[n].Cells[1].Value = item[1].ToString();
                dataGridView1.Rows[n].Cells[2].Value = item[2].ToString();
                dataGridView1.Rows[n].Cells[3].Value = item[3].ToString();
                dataGridView1.Rows[n].Cells[4].Value = item[4].ToString();



            }

        }

        private void Form17_Load(object sender, EventArgs e)
        {

            Display();
        }
    }
}
