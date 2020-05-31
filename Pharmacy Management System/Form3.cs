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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            txtTotal.Text = "0";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
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

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            this.txtProductName.Text = "";
            this.txtCash.Text = "";
            this.txtPrice.Text = "";
            this.txtQuantity.Text = "";
            this.txtTotal.Text = "";
            this.textBox1.Text = "";
        }
        
        private void btnAdd_Click(object sender, EventArgs e)
        {
            
            txtTotal.Text=(int.Parse(txtTotal.Text) + int.Parse(txtPrice.Text) * int.Parse(txtQuantity.Text)).ToString();
            
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            textBox1.Text = (int.Parse(txtCash.Text)- int.Parse(txtTotal.Text)).ToString();
            MessageBox.Show("Printed");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 p = new Form1();
            p.Show();
        }

        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8 &&  ch != 46 ) {

                e.Handled = true;
                MessageBox.Show("please enter valid value");
            }

        }

        private void txtCash_KeyPress(object sender, KeyPressEventArgs e)
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
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];

                txtProductName.Text = row.Cells["P_name"].Value.ToString();
                txtPrice.Text = row.Cells["P_price"].Value.ToString();


            }
        }
    }
}
