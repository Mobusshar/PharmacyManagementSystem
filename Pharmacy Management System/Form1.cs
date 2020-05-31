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
using System.Data;


namespace Pharmacy_Management_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void exitbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void loginbtn_Click(object sender, EventArgs e)
        {
            try
            {
                String con = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=H:\c#\Pms\MitonmoyDb.mdf;Integrated Security=True;Connect Timeout=30";

                SqlConnection ss = new SqlConnection(con);

                ss.Open();

                SqlDataAdapter sda = new SqlDataAdapter("Select * from [Table] where ID = '" + textBox1.Text + "' and PASSWORD = '" + textBox2.Text + "' ", con);

                DataTable dt = new System.Data.DataTable();

                sda.Fill(dt);

                if (dt.Rows.Count == 1)
                {
                    SqlDataAdapter admin = new SqlDataAdapter("Select * from [Table] where ID = '" + textBox1.Text + "' and ROLE = 'Admin' ", con);
                    SqlDataAdapter user = new SqlDataAdapter("Select * from [Table] where ID = '" + textBox1.Text + "' and ROLE = 'User' ", con);
                    DataTable dt_admin = new DataTable();
                    DataTable dt_user = new DataTable();

                    admin.Fill(dt_admin);
                    user.Fill(dt_user);

                    if (dt_admin.Rows.Count == 1)
                    {
                        //go to admin panel
                        this.Hide();
                        Form2 a = new Form2();
                        a.Show();
                        MessageBox.Show("Welcome admin: "+textBox1.Text);
                    }
                    else if (dt_user.Rows.Count == 1)
                    {
                        //go to user panel
                        this.Hide();
                        Form3 b = new Form3();
                        b.Show();
                        MessageBox.Show("Welcome user: "+ textBox1.Text);

                    }
                    ss.Close();

                }
                else
                {
                    MessageBox.Show("Invalid username or password");

                }
            }
            catch(SqlException ex)
            {
                MessageBox.Show("Exeption: "+ex);
            }
            
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form6 b = new Form6();
            b.Show();
        }
    }
}
