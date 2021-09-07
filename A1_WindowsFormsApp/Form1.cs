using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A1_WindowsFormsApp
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

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            

        }
        //When button is clicked user-input of textBox1.Text is convereted
        //to Fahrenheit using server refrence
        private void button1_Click(object sender, EventArgs e)
        {
            //creates server refrenece
            ServiceReference1.Service1Client sc = new ServiceReference1.Service1Client();
            //varaible declarations
            string var;
            int calcNum;
            //string var is set to user input of textBox1
            var = textBox1.Text;
            //calNum is set to the server client c2f() method that converts 
            //the userinput var to calcuated fahrenheit
            calcNum = sc.c2f(Int32.Parse(var));
            //Button displays Calulations have been done
            button1.Text = "DONE! Click me again for new Caluculation";
            //Outputs calcuted Farhrenheit to button2.Text
            button2.Text = calcNum + "";
            //closes sercver client
            sc.Close();



        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
        //When button is clicked user-input of textBox2.Text is convereted
        //to Celsius using server refrence
        private void button4_Click(object sender, EventArgs e)
        {
            //creates server refrenece
            ServiceReference1.Service1Client sc = new ServiceReference1.Service1Client();
            //declares variables
            string var;
            int calcNum;
            //var is set to user-input of textBox2.Text
            var = textBox2.Text;
            //calNum is set to the server client f2c() method that converts 
            //the userinput var to calcuated Celsius
            calcNum = sc.f2c(Int32.Parse(var));
            //Displays calculations are done
            button4.Text = "DONE! Click me again for new Caluculation";
            //displays calculated Celsius to button3.Text
            button3.Text = calcNum + "";
            //closes client
            sc.Close();
        }
    }
}
