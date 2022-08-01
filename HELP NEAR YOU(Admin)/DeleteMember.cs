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
    public partial class DeleteMember : Form
    {
        string cS = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
        public DeleteMember()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
          /*  SqlConnection con = new SqlConnection(cS);
            string query = "delete  from EMPLOYEE_DETAILS values where id=@id;
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@id", textBox5.Text);
            cmd.Parameters.AddWithValue("@name", textBox1.Text);
            cmd.Parameters.AddWithValue("@email", textBox2.Text);
            cmd.Parameters.AddWithValue("@phonenumber", textBox3.Text);
            cmd.Parameters.AddWithValue("@gender", "g");
            cmd.Parameters.AddWithValue("@worktime", comboBox1.SelectedItem);
            cmd.Parameters.AddWithValue("@worktype", comboBox2.SelectedItem);
            cmd.Parameters.AddWithValue("@nidnumber", textBox4.Text);
            cmd.Parameters.AddWithValue("@address", textBox6.Text);
            cmd.Parameters.AddWithValue("@img", SavePhoto());
            con.Open();
            cmd.ExecuteNonQuery();

            MessageBox.Show("Data Inserted Successfully!");

            con.Close();*/

        }
    }
}
