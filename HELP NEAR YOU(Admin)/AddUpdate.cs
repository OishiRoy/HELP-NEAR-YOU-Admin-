using System;
using System.Data;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;

namespace HELP_NEAR_YOU_Admin_
{
    public partial class AddUpdate : Form
    {
        string cS = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
        public AddUpdate()
        {
            InitializeComponent();
            

        }

        private object Code()
        {
            throw new NotImplementedException();
        }

        public object DataGridView1 { get; private set; }

        private void AddUpdate_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           /* SqlConnection con = new SqlConnection(cS);
            string query = "SELECT * FROM EMPLOYEE_DETAILS";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);


            //Data in gridview
            DataTable data1 = new DataTable();
            sda.Fill(data1);
            dataGridView1.DataSource = data1;*/
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cS);
            string query = "SELECT * FROM EMPLOYEE_DETAILS";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            string query2 = "SELECT * FROM CLIENT_DETAILS";
            SqlDataAdapter sd = new SqlDataAdapter(query2, con);


            //Data in gridview
            DataTable data1 = new DataTable();
            sda.Fill(data1);
            dataGridView1.DataSource = data1;


            DataTable data2 = new DataTable();
            sd.Fill(data2);
            dataGridView2.DataSource = data2;

            //image column
            DataGridViewImageColumn dgv = new DataGridViewImageColumn();
            dgv = (DataGridViewImageColumn)dataGridView1.Columns[9];
            dgv.ImageLayout = DataGridViewImageCellLayout.Stretch;

            DataGridViewImageColumn dg = new DataGridViewImageColumn();
            dg = (DataGridViewImageColumn)dataGridView2.Columns[7];
            dg.ImageLayout = DataGridViewImageCellLayout.Stretch;



            //Autosize Table column

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            //image Row hight

            dataGridView1.RowTemplate.Height = 50;
            dataGridView2.RowTemplate.Height = 50;

        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            AddServant myform = new AddServant();
           
            myform.textBox5.Text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            myform.textBox1.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            myform.textBox2.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
            //myform.Enter = dataGridView1.CurrentRow.Cells[3].Value.ToString();//
            myform.comboBox1.SelectedItem = this.dataGridView1.CurrentRow.Cells[4].Value;
            myform.comboBox2.SelectedItem = this.dataGridView1.CurrentRow.Cells[5].Value;
            myform.textBox4.Text = this.dataGridView1.CurrentRow.Cells[6].Value.ToString();
            myform.textBox6.Text = this.dataGridView1.CurrentRow.Cells[7].Value.ToString();
            pictureBox1.Image =this. GetPhoto((byte[])dataGridView1.CurrentRow.Cells[8].Value);//
            myform.ShowDialog();



        }

        private Image GetPhoto(byte[] photo)
        {
            MemoryStream ms = new MemoryStream();
            return Image.FromStream(ms);
        }
    }
}
