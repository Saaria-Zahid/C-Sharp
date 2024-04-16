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

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string dapp = "Data Source=PROSAARIA\\SQLEXPRESS;Initial Catalog=dapp1;Integrated Security=True";
            SqlConnection connection = new SqlConnection(dapp);

            string name, email, contact;
            name = textBox1.Text;
            email = textBox2.Text;
            contact = textBox3.Text;

            if (name != string.Empty || email != string.Empty || contact != string.Empty)
            {

                connection.Open();

                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandType = CommandType.Text;
                command.CommandText = "insert into info (name , email , contact ) Values('" + name + "', '" + email + "', '" + contact + "' )";
                command.ExecuteNonQuery();
                MessageBox.Show("Account Successfully created");
            }
            else
            { MessageBox.Show("Error"); }
            connection.Close();
        }

           

          
        }
            
    }

    
    
