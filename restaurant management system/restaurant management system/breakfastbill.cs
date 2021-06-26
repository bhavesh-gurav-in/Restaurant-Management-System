using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace restaurant_management_system
{
    public partial class breakfastbill : Form
    {
        public breakfastbill()
        {
            InitializeComponent();
        }

        private void breakfastbill_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseDataSet1.breakfast' table. You can move, or remove it, as needed.
            this.breakfastTableAdapter.Fill(this.databaseDataSet1.breakfast);
           
           

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = " ";
            comboBox1.Text = " ";
            textBox3.Text = " ";
            textBox2.Text = " ";
            textBox4.Text = " ";
           


        }

        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\swamygurav\Database.mdb");
        private void button2_Click(object sender, EventArgs e)
        {
            int row = 0;
            dataGridView1.Rows.Add();
            row = dataGridView1.Rows.Count - 2;
            dataGridView1["TableNo",row].Value=textBox1.Text;
            dataGridView1["order", row].Value = comboBox1.SelectedItem.ToString();
            dataGridView1["Quantity", row].Value = textBox3.Text;
            dataGridView1["Price", row].Value = textBox2.Text;
            dataGridView1["Amount", row].Value = textBox4.Text;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox4.Text = (Convert.ToInt32(textBox3.Text) * (Convert.ToInt32(textBox2.Text))).ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sum = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; ++i)
            {
                sum += Convert.ToInt32(dataGridView1.Rows[i].Cells[4].Value);
            }
            MessageBox.Show(sum.ToString());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\swamygurav\Database.mdb");
            con.Open();
            OleDbCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from breakfast where tableno='" + textBox1.Text + "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            da.Fill(dt);
            dataGridView2.DataSource = dt;
            con.Close();

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\swamygurav\Database.mdb");
            con.Open();
            OleDbCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from breakfast";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            da.Fill(dt);
            dataGridView2.DataSource = dt;
            con.Close();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            con.Open();
            OleDbCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from breakfast where tableno='" + textBox1.Text + "'";
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record removed sucessfully");

        }

       
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Boil Eggs")
            {
                textBox2.Text = "15";
            }
            if (comboBox1.Text == "Bread Butter")
            {
                textBox2.Text = "10";
            }
            if (comboBox1.Text == "Sandwich")
            {
                textBox2.Text = "10";
            }
            if (comboBox1.Text == "Cornflex")
            {
                textBox2.Text = "25";
            }
            if (comboBox1.Text == "Poha")
            {
                textBox2.Text = "10";
            }
            if (comboBox1.Text == "Salad")
            {
                textBox2.Text = "15";
            }
            if (comboBox1.Text == "Omlet")
            {
                textBox2.Text = "20";
            }
            if (comboBox1.Text == "Tea")
            {
                textBox2.Text = "10";
            }
            if (comboBox1.Text == "Coffee")
            {
                textBox2.Text = "15";
            }
            if (comboBox1.Text == "Green Tea")
            {
                textBox2.Text = "15";
            }
            if (comboBox1.Text == "Milk")
            {
                textBox2.Text = "15";
            }
            if (comboBox1.Text == "Mix Fruit Juice")
            {
                textBox2.Text = "20";
            }
            if (comboBox1.Text == "Orange Juice")
            {
                textBox2.Text = "20";
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Main m = new Main();
            m.Show();
            this.Hide();

        }

        private void button8_Click(object sender, EventArgs e)
        {
            breakfast bb = new breakfast();
            bb.Show();
            this.Hide();
        }
    }
}
