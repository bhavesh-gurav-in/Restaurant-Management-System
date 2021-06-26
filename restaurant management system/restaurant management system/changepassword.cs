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
    public partial class changepassword : Form
    {
        public changepassword()
        {
            InitializeComponent();
        }

        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\swamygurav\Database.mdb");
        private void button1_Click(object sender, EventArgs e)
        {
             con.Open();
            OleDbCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from Login where username='" + textBox1.Text + "'";
            cmd.ExecuteNonQuery();
            con.Close();
            if (textBox3.Text == textBox4.Text)
            {
                con.Open();
                OleDbCommand cm = con.CreateCommand();
                cm.CommandType = CommandType.Text;
                cm.CommandText = "insert into Login values('" + textBox1.Text + "','" + textBox4.Text + "')";
                cm.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Password Changed sucessfully......");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Main m = new Main();
            m.Show();
            this.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
           
        }
    }
}
