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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 fm = new Form1();
            this.Hide();
            fm.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            SqlConnection c = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=H:\c#\Pms\Pharmacy Management System\MitonmoyDb.mdf;Integrated Security=True;Connect Timeout=30");

            c.Open();

            String q = "select * from Product";

            SqlCommand bb = new SqlCommand(q, c);

            int j = bb.ExecuteNonQuery();

            DataTable dd = new DataTable();

            SqlDataAdapter da = new SqlDataAdapter(bb);

            da.Fill(dd);
            dataGridView1.DataSource = dd;

            c.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form2 am = new Form2();
            this.Hide();
            am.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.textBox2.Text = "";            
            this.textBox3.Text = "";
            this.textBox4.Text = "";
            this.textBox5.Text = "";
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("You sure you want to delete the product ? ", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)

            {
                String pid = textBox2.Text;

                SqlConnection coc = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=H:\c#\Pms\Pharmacy Management System\MitonmoyDb.mdf;Integrated Security=True;Connect Timeout=30");

                coc.Open();
                String qrrr = "delete from Product where P_id = '" + textBox2.Text + "'";



                SqlCommand aa = new SqlCommand(qrrr, coc);

                int i = aa.ExecuteNonQuery();
                if (i >= 1)
                    MessageBox.Show(i + " Product Deleted successfully " + pid);
                else
                    MessageBox.Show("Product is not deleted ");
                coc.Close();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection coo = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=H:\c#\Pms\Pharmacy Management System\MitonmoyDb.mdf;Integrated Security=True;Connect Timeout=30");

                coo.Open();

                String pid = textBox2.Text;
                
                String pname = textBox3.Text;
                String pbrand = textBox4.Text;
                String pprice = textBox5.Text;
                

            

                String qrrr = "insert into Product(P_id,P_name,P_exp,P_price,P_brand) values ( '" + pid + "',  '" + pname + "', '" + dateTimePicker1.Text + "' , '" + pprice + "' , '" + pbrand + "')";



                SqlCommand ff = new SqlCommand(qrrr, coo);

                int l = ff.ExecuteNonQuery();
                if (l >= 1)
                    MessageBox.Show(l + " Product registered successfully " + pid);
                else
                    MessageBox.Show("Product is not registered ");
                coo.Close();
                button4_Click(sender, e);
            }
            catch (Exception ex)
           {

                MessageBox.Show( ex.ToString());

            }
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

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {

                e.Handled = true;
                MessageBox.Show("please enter valid value");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
