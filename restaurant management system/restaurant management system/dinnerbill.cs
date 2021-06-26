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
    public partial class dinnerbill : Form
    {
        public dinnerbill()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox4.Text = (Convert.ToInt32(textBox3.Text) * (Convert.ToInt32(textBox2.Text))).ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = " ";
            comboBox1.Text = " ";
            textBox3.Text = " ";
            textBox2.Text = " ";
            textBox4.Text = " ";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int row = 0;
            dataGridView1.Rows.Add();
            row = dataGridView1.Rows.Count - 2;
            dataGridView1["TableNo", row].Value = textBox1.Text;
            dataGridView1["order", row].Value = comboBox1.SelectedItem.ToString();
            dataGridView1["Quantity", row].Value = textBox3.Text;
            dataGridView1["Price", row].Value = textBox2.Text;
            dataGridView1["Amount", row].Value = textBox4.Text;
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

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dinnerbill_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseDataSet2.dinner' table. You can move, or remove it, as needed.
            this.dinnerTableAdapter.Fill(this.databaseDataSet2.dinner);

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\swamygurav\Database.mdb");
            con.Open();
            OleDbCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from dinner where tableno='" + textBox1.Text + "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            da.Fill(dt);
            dataGridView2.DataSource = dt;
            con.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\swamygurav\Database.mdb");
            con.Open();
            OleDbCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from dinner";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            da.Fill(dt);
            dataGridView2.DataSource = dt;
            con.Close();
        }
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\swamygurav\Database.mdb");
        private void button6_Click(object sender, EventArgs e)
        {
            con.Open();
            OleDbCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from dinner where tableno='" + textBox1.Text + "'";
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record removed sucessfully");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            if (comboBox1.Text == "Pav-Bhaji")
            {
                textBox2.Text = "75";
            }
            if (comboBox1.Text == "Masala-Dosa")
            {
                textBox2.Text = "50";
            }
            if (comboBox1.Text == "Chicken-Dinner")
            {
                textBox2.Text = "125";
            }
            if (comboBox1.Text == "Paneer-Tikka")
            {
                textBox2.Text = "110";
            }
            if (comboBox1.Text == "Channa-Masala")
            {
                textBox2.Text = "95";
            }
            if (comboBox1.Text == "Butter-Chicken")
            {
                textBox2.Text = "150";
            }
            if (comboBox1.Text == "Aloo-Mattar")
            {
                textBox2.Text = "80";
            }
            if (comboBox1.Text == "Masharoom")
            {
                textBox2.Text = "100";
            }
            if (comboBox1.Text == "Rise")
            {
                textBox2.Text = "35";
            }
            if (comboBox1.Text == "Pestries-Puff")
            {
                textBox2.Text = "15";
            }
            if (comboBox1.Text == "Vanella-Cone")
            {
                textBox2.Text = "25";
            }
            if (comboBox1.Text == "Strawberry Shake")
            {
                textBox2.Text = "15";
            }
            if (comboBox1.Text == "Cocklate Muffin")
            {
                textBox2.Text = "30";
            }
            if (comboBox1.Text == "Pancake Syrup")
            {
                textBox2.Text = "30";
            }
            if (comboBox1.Text == "Apple Juice")
            {
                textBox2.Text = "15";
            }
            if (comboBox1.Text == "Soft Drink")
            {
                textBox2.Text = "10";
            }
            if (comboBox1.Text == "Fruit Juice")
            {
                textBox2.Text = "15";
            }
            if (comboBox1.Text == "Cola")
            {
                textBox2.Text = "15";
            }
            if (comboBox1.Text == "Orange Juice")
            {
                textBox2.Text = "15";
            }
            if (comboBox1.Text == "Mix-Veg")
            {
                textBox2.Text = "25";
            }
            if (comboBox1.Text == "Tomato")
            {
                textBox2.Text = "25";
            }
            if (comboBox1.Text == "NonVeg")
            {
                textBox2.Text = "50";
            }
            if (comboBox1.Text == "Mashroom Soup")
            {
                textBox2.Text = "45";
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            dinner dd = new dinner();
            dd.Show();
            this.Hide();

        }

        private void button9_Click(object sender, EventArgs e)
        {
            Main m = new Main();
            m.Show();
            this.Hide();
        }

      
    }
}
