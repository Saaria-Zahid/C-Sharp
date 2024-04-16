using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace clientform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog uimg = new OpenFileDialog();
            uimg.Filter = "Image Files (*.png;*.jpg;*.jpeg;.*.gif;)|*.jpg;*.jpeg;.*.gif";
            if (uimg.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(uimg.FileName);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            string dapp = "Data Source=PROSAARIA\\SQLEXPRESS;Initial Catalog=client;Integrated Security=True";
            SqlConnection connection = new SqlConnection(dapp);


            string contactval = "";

            if (radioButton1.Checked)
            {
                contactval = "Email";
            }
            else
            {
                contactval = "Phone";
            }

            string name, title, company, contact, address, addressline, city, state, postal, country, cweb, hours, days, bill, additional;
            name = textBox1.Text;
            title = textBox2.Text;
            company = textBox3.Text;
            contact = contactval;
            address = textBox4.Text;
            addressline = textBox5.Text;
            city = textBox6.Text;
            state = textBox7.Text;
            postal = textBox8.Text;
            country = this.comboBox1.Text;
            cweb = textBox9.Text;
            //logo = pictureBox1.Image;
            hours = textBox10.Text;
            days = textBox11.Text;
            bill = this.dateTimePicker1.Text;
            additional = textBox12.Text;

            if (name != string.Empty || title != string.Empty || company != string.Empty || contact != string.Empty || address != string.Empty || addressline != string.Empty || city != string.Empty || postal != string.Empty || country != string.Empty || cweb != string.Empty || hours != string.Empty || days != string.Empty || bill != string.Empty || additional != string.Empty)
            {

                connection.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connection;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into info (name, title, company, contact, address, addressline, city, state, postal, country, cweb, hours, days, bill, additional) Values('" + name + "','" + title + "','" + company + "','" + contact + "','" + address + "','" + addressline + "','" + city + "','" + state + "','" + postal + "','" + country + "','" + cweb + "','" + hours + "', '" + days + "', '" + bill + "', '" + additional + "')  ";
                cmd.ExecuteNonQuery();


                MessageBox.Show("Your Data Successfully Submitted");
            }

            else
            {

                MessageBox.Show("Error Hai");
            }
            connection.Close();

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
