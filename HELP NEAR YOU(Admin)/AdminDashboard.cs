using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HELP_NEAR_YOU_Admin_
{
    public partial class AdminDashboard : Form
    {
        public AdminDashboard()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            UpdateServant u = new UpdateServant();
            u.Show();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Add_Client c = new Add_Client();
            c.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddServant a = new AddServant();
            a.Show();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            UpdateClient up = new UpdateClient();
            up.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            AddUpdate ad = new AddUpdate();
            ad.Show();
        }
    }
}
