using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace restaurant_management_system
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void customerFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            customer cc = new customer();
            cc.Show();
            this.Hide();
        }

        private void breakFastToolStripMenuItem_Click(object sender, EventArgs e)
        {
            breakfast b = new breakfast();
            b.Show();
            this.Hide();
        }

       

        private void dinnerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dinner dd = new dinner();
            dd.Show();
            this.Hide();
        }

        private void reportToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void breakfastToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            breakfastbill bb = new breakfastbill();
            bb.Show();
            this.Hide();
        }

        private void dinnerToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            dinnerbill db = new dinnerbill();
            db.Show();
            this.Hide();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            aboutus au = new aboutus();
            au.Show();
            this.Hide();
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            changepassword cp = new changepassword();
            cp.Show();
            this.Hide();

        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Hide();
        }

        private void customerReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            custreport cr = new custreport();
            cr.Show();

        }

        
    }
}
