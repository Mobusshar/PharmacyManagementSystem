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
    public partial class Form4 : Form
    {
        public Getvalue info { get; set; }


        string gender;


        public Form4()
        {
            InitializeComponent();
            

        }

        private void Form4_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 fm = new Form1();
            this.Hide();
            fm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            /*
            String name = textBox2.Text;
            String password = textBox7.Text;
            String address = textBox3.Text;
            String email = textBox4.Text;
            String phone = textBox5.Text;
            String salary = textBox6.Text;

            String department = comboBox1.SelectedItem.ToString();

            SqlConnection co = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=H:\c#\Pms\Pharmacy Management System\MitonmoyDb.mdf;Integrated Security=True;Connect Timeout=30");

            co.Open();
            String qr = " Update Employee set  Address= '" + address + "', Email = '" + email + "' , Phone = '" + phone + "', Salary = '" + salary + "' , Department = '" + department + "' , Gender = '" + gender + "' where Name = '" + name + "'";



            SqlCommand aa = new SqlCommand(qr, co);

            int i = aa.ExecuteNonQuery();
            if (i >= 1)
                MessageBox.Show(i + " Employee Updated successfully " + name);
            else
                MessageBox.Show("Employee is not Updated ");
            co.Close();
            */
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.textBox2.Text = "";
            this.textBox7.Text = "";
            this.textBox3.Text = "";
            this.textBox4.Text = "";
            this.textBox5.Text = "";
            this.textBox6.Text = "";
            this.comboBox1.SelectedIndex = -1;

            SqlConnection c = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=H:\c#\Pms\Pharmacy Management System\MitonmoyDb.mdf;Integrated Security=True;Connect Timeout=30");

            c.Open();

            String qrr = "Select isnull(max(cast(ID as int )) , 0 )+1  from Employee";



            

            SqlCommand cc = new SqlCommand(qrr, c);

            int k = cc.ExecuteNonQuery();

            DataTable ee = new DataTable();

            SqlDataAdapter daa = new SqlDataAdapter(cc);

            daa.Fill(ee);




            
            textBox1.Text = ee.Rows[0][0].ToString();
            c.Close();
            //textBox2.Focus();
            this.ActiveControl = textBox2;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("You sure you want to delete the employee ? " , "Delete" , MessageBoxButtons.YesNo , MessageBoxIcon.Question)== DialogResult.Yes)
            {

                String name = textBox2.Text;

                SqlConnection coc = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=H:\c#\Pms\Pharmacy Management System\MitonmoyDb.mdf;Integrated Security=True;Connect Timeout=30");

                coc.Open();
                String qrrr = "delete from Employee where Name = '" + textBox2.Text + "'";



                SqlCommand aa = new SqlCommand(qrrr, coc);

                int i = aa.ExecuteNonQuery();
                if (i >= 1)
                    MessageBox.Show(i + " Employee Deleted successfully " + name);
                else
                    MessageBox.Show("Employee is not deleted ");
                coc.Close();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form2 am = new Form2();
            this.Hide();
            am.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {

            try {
                SqlConnection coooo = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=H:\c#\Pms\Pharmacy Management System\MitonmoyDb.mdf;Integrated Security=True;Connect Timeout=30");

                coooo.Open();
                /*info.Name = textBox2.Text;
                info.Password = textBox7.Text;
                info.Role = "Admin";*/
                String name = textBox2.Text;                
                String password = textBox7.Text;
                String address = textBox3.Text;
                String email = textBox4.Text;
                String phone = textBox5.Text;
                String salary = textBox6.Text;

                String department = comboBox1.SelectedItem.ToString();

                String qrrrq = "insert into Employee(Name,Address,Email,Phone,Salary,Department,Gender,DOB) values ( '"+name+ "',  '" + address+ "', '"+email+ "' , '"+phone+ "', '"+salary+ "' , '"+department+ "' , '" + gender + "' , '" + dateTimePicker1.Text + "')";

//                String qrrrrrr = " insert into Table (Name,PASSWORD,ROLE) values ('" + info.Name + "' , '" + info.Password + "' , '" + info.Role + "')";

  //              SqlCommand ll = new SqlCommand(qrrrrrr, coooo);

                SqlCommand ff = new SqlCommand(qrrrq,coooo);

    //            int f = ll.ExecuteNonQuery();
                int l = ff.ExecuteNonQuery();
                if(l>=1)
                MessageBox.Show(l + " Employee registered successfully "+ name);
                else
                    MessageBox.Show( "Employee is not registered " );
                coooo.Close();
                button4_Click(sender, e);
            }
            catch (Exception ex)
            {

                MessageBox.Show( "Error is " + ex.ToString() );

            }
        }
        
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

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

        private void button8_Click(object sender, EventArgs e)
        {
            SqlConnection c = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=H:\c#\Pms\Pharmacy Management System\MitonmoyDb.mdf;Integrated Security=True;Connect Timeout=30");

            c.Open();

            String q = "select * from Employee";

            SqlCommand bb = new SqlCommand(q, c);

            int j = bb.ExecuteNonQuery();

            DataTable dd = new DataTable();

            SqlDataAdapter da = new SqlDataAdapter(bb);

            da.Fill(dd);
            dataGridView1.DataSource = dd;

            c.Close();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            SqlConnection cccc = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=H:\c#\Pms\Pharmacy Management System\MitonmoyDb.mdf;Integrated Security=True;Connect Timeout=30");

            cccc.Open();

            String qrqq = "Select isnull(max(cast(ID as int )) , 0 )+1  from Employee";





            SqlCommand gg = new SqlCommand(qrqq, cccc);

            int m = gg.ExecuteNonQuery();

            DataTable dd = new DataTable();

            SqlDataAdapter da = new SqlDataAdapter(gg);

            da.Fill(dd);





            textBox1.Text = dd.Rows[0][0].ToString();
            cccc.Close();
            //textBox2.Focus();
            this.ActiveControl = textBox2;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            /*textBox2.Text=dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            textBox3.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            textBox6.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
            textBox4.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
            textBox5.Text = dataGridView1.SelectedRows[0].Cells[8].Value.ToString();
            comboBox1.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            */


        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            textBox2.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            textBox3.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            textBox6.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
            textBox4.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
            textBox5.Text = dataGridView1.SelectedRows[0].Cells[8].Value.ToString();
            comboBox1.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {

                e.Handled = true;
                MessageBox.Show("please enter valid value");
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
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
