using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using System.IO;


namespace HELP_NEAR_YOU_Admin_
{
    public partial class Add_Client : Form
    {
        string cS = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
        string g;
        public Add_Client()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AdminDashboard ad = new AdminDashboard();
            ad.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Select Image";
            ofd.Filter = "All Image File(*.*) | *.*";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(ofd.FileName);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                g = "male";
            }
            else
            {
                g = "female";
            }

            SqlConnection con = new SqlConnection(cS);
            string query = "insert into CLIENT_DETAILS values (@id,@name,@email,@phonenumber,@gender,@nidnumber,@address,@img)";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@id", textBox5.Text);
            cmd.Parameters.AddWithValue("@name", textBox1.Text);
            cmd.Parameters.AddWithValue("@email", textBox2.Text);
            cmd.Parameters.AddWithValue("@phonenumber", textBox3.Text);
            cmd.Parameters.AddWithValue("@gender", "g");
            cmd.Parameters.AddWithValue("@nidnumber", textBox4.Text);
            cmd.Parameters.AddWithValue("@address", textBox6.Text);
            cmd.Parameters.AddWithValue("@img", SavePhoto());
            con.Open();
            cmd.ExecuteNonQuery();

            MessageBox.Show("Data Inserted Successfully!");

            con.Close();

        }

        private byte[] SavePhoto()
        {
            MemoryStream ms = new MemoryStream();
            pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
            return ms.GetBuffer();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            ResetControl();
        }

        void ResetControl()
        {
            textBox5.Clear();
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox6.Clear();
            pictureBox1.Image = Properties.Resources.client_profile;

        }
    }
    
}
