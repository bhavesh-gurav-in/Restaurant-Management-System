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
    public partial class dinner : Form
    {
        public dinner()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = " ";
            textBox2.Text = " ";
            textBox3.Text = " ";
            textBox4.Text = " ";
            textBox5.Text = " ";
            textBox6.Text = " ";
            textBox7.Text = " ";
            textBox8.Text = " ";
            textBox9.Text = " ";
            textBox10.Text = " ";
            textBox11.Text = " ";
            textBox12.Text = " ";
            textBox13.Text = " ";
            textBox14.Text = " ";
            textBox13.Text = " ";
            textBox14.Text = " ";
            textBox15.Text = " ";
            textBox16.Text = " ";
            textBox17.Text = " ";
            textBox18.Text = " ";
            textBox19.Text = " ";
            textBox20.Text = " ";
            textBox21.Text = " ";
            textBox22.Text = " ";
            textBox23.Text = " ";
            comboBox1.Text = " ";
        }

      

        private void button3_Click(object sender, EventArgs e)
        {
            Main m = new Main();
            m.Show();
            this.Close();
        }

        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\swamygurav\Database.mdb");
        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            OleDbCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into dinner values('" + comboBox1.Text + "','" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + textBox7.Text + "','" + textBox8.Text + "','" + textBox9.Text + "','" + textBox10.Text + "','" + textBox11.Text + "','" + textBox12.Text + "','" + textBox13.Text + "','" + textBox14.Text + "','" + textBox15.Text + "','" + textBox16.Text + "','" + textBox17.Text + "','" + textBox18.Text + "','" + textBox19.Text + "','" + textBox20.Text + "','" + textBox21.Text + "','" + textBox22.Text + "','" + textBox23.Text + "','" + dateTimePicker1.Text + "')";
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Order inserted sucessfully");


        }

        private void button4_Click(object sender, EventArgs e)
        {
            dinnerbill bb = new dinnerbill();
            bb.Show();
            this.Hide();
        }
    }
}
