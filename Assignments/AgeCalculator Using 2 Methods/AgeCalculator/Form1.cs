using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgeCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btn_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {




            int Cyear = Convert.ToInt32(textBox1.Text);
            int DOBYear = Convert.ToInt32(textBox2.Text);

            int Calc = Cyear - DOBYear;

            int Month = Calc * 12;
            int Week = Month * 4;
            int Day = Week * 7;
            int Hour = Day * 24;
            int Minute = Hour * 60;
            int Second = Minute * 60;

            label18.Text = Calc.ToString();
            label7.Text = Month.ToString();
            label8.Text = Week.ToString();
            label12.Text = Day.ToString();
            label11.Text = Hour.ToString();
            label16.Text = Minute.ToString();
            label15.Text = Second.ToString();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            int cdays = Convert.ToInt32(textBox4.Text);
            int cmonths = Convert.ToInt32(textBox5.Text);
            int cyears = Convert.ToInt32(textBox6.Text);

            int ddays = Convert.ToInt32(textBox9.Text);
            int dmonths = Convert.ToInt32(textBox8.Text);
            int dyears = Convert.ToInt32(textBox7.Text);

            int tyear = cyears - dyears;
            int tmonth = tyear * 12;
            int tweeks = tmonth * 4;
            int tday = tweeks * 24;
            label20.Text = "Your Age Is " + tyear.ToString() + " Years / " + tmonth.ToString() + " Months / " + tweeks.ToString() + " Weeks / " + tday.ToString() + " Days / ";

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
