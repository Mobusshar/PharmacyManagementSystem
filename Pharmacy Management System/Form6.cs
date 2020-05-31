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

namespace Pharmacy_Management_System
{
    public partial class Form6 : Form
    {
        public string gender;
        public Form6()
        {
            InitializeComponent();
        }
        Getvalue info = new Getvalue();
        private void Form6_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 p = new Form1();
            p.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            /* SqlConnection cooler = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=H:\c#\Pms\Pharmacy Management System\MitonmoyDb.mdf;Integrated Security=True;Connect Timeout=30");

            cooler.Open();
            String Namen = textBox2.Text;
            String Passwordp = textBox7.Text;
            String Role = "User";
            String qrrrrtnm = " insert into Table(Name,PASSWORD,ROLE) values ('" + Namen + "' , '" + Passwordp + "' , '" + Role + "')";

            SqlCommand mm = new SqlCommand(qrrrrtnm, cooler);
            int f = mm.ExecuteNonQuery();

            cooler.Close(); */

            try
            {
                SqlConnection cool = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=H:\c#\Pms\Pharmacy Management System\MitonmoyDb.mdf;Integrated Security=True;Connect Timeout=30");

                cool.Open();
                /*info.Name = textBox2.Text;
                info.Password = textBox7.Text;
                info.Role = "User";*/
                String name = textBox2.Text;
                String password = textBox7.Text;
                String address = textBox3.Text;
                String age = textBox4.Text;
                String id = textBox5.Text;
                

                String maritual_status = comboBox1.SelectedItem.ToString();

                String tnm = "insert into Client(Name,ID,DOB,Age,Address,Password,Maritual_status,Gender) values ( '"+name+"' , '"+id+"' , '"+dateTimePicker1.Text+"' , '"+age+"' , '"+address+"' , '"+password+"' , '"+maritual_status+"' , '"+gender+"'  )";

                //String qrrrrtnm = " insert into Table (Name,PASSWORD,ROLE) values ('" + info.Name + "' , '" + info.Password + "' , '" + info.Role + "')";

//                SqlCommand mm = new SqlCommand(qrrrrtnm, cool);

                SqlCommand nn = new SqlCommand(tnm, cool);

  //              int f = mm.ExecuteNonQuery();
                int l = nn.ExecuteNonQuery();
                if (l >= 1)
                    MessageBox.Show(l + " User registered successfully " + name);
                else
                    MessageBox.Show("User is not registered ");
                cool.Close();
                button2_Click(sender, e);
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error is " + ex.ToString());

            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            gender = "Male";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            gender = "Female";
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            gender = "Others";
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {

                e.Handled = true;
                MessageBox.Show("please enter valid value");
            }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {

                e.Handled = true;
                MessageBox.Show("please enter valid value");
            }
        }
    }
}
