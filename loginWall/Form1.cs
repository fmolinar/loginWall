using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace loginWall
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }


        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e) // Close Button
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e) // Login Button
        {
            SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\fermo\OneDrive\Documents\Data.mdf;Integrated Security=True;Connect Timeout=30;");
            SqlCommand cmd = new SqlCommand("select * from LOGINtbl where USERNAME=@USERNAME and PASSWORD=@PASSWORD ", connection);

            cmd.Parameters.AddWithValue("@USERNAME", username.Text);
            cmd.Parameters.AddWithValue("@PASSWORD", password.Text);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            sda.Fill(dt);

            connection.Open();
            int i = cmd.ExecuteNonQuery();

            if (dt.Rows.Count > 0)
            {
                this.Hide();

                Main ss = new Main();
                ss.Show();
            }
            else
            {
                MessageBox.Show("Incorrect Username or Password");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void password_TextChanged(object sender, EventArgs e)
        {

        }
    }
}