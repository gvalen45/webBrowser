using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using webBrowser1.ServiceReference1;
//Windows Froms App that generates a webBrowser that can browse the internet.
//And a simple calculator that persons the operations of +,-,*,/.
//And Lastly a text encryption and decryption tool.
namespace webBrowser1
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		

		private void btnGo_Click_1(object sender, EventArgs e)
		{
			webBrowser3.Navigate(txtUrl.Text);
		}
		//Method to add two numbers
		private void button1_Click(object sender, EventArgs e)
		{
			//declared first and second operand
			float firstNum = float.Parse(textBox1.Text);
			float secondNum = float.Parse(textBox2.Text);
			//outputted add  calculation to textBox3
			textBox3.Text = (firstNum + secondNum) + "";
		}

		private void label3_Click(object sender, EventArgs e)
		{

		}

		private void label4_Click(object sender, EventArgs e)
		{

		}

		private void label5_Click(object sender, EventArgs e)
		{

		}
		//Method to multiply two numbers
		private void btnMultiply_Click(object sender, EventArgs e)
		{           
			//declared first and second operand
			float firstNum = float.Parse(textBox1.Text);
			float secondNum = float.Parse(textBox2.Text);
			//outputted multiply  calculation to textBox3
			textBox3.Text = (firstNum * secondNum) + "";

		}
		//Method to divide two numbers
		private void btnDivide_Click(object sender, EventArgs e)
		{
			//declared first and second operand

			float firstNum = float.Parse(textBox1.Text);
			float secondNum = float.Parse(textBox2.Text);
			//outputted divide  calculation to textBox3

			textBox3.Text = (firstNum / secondNum) + "";
		}
		//Method to subtract two numbers
		private void btnSubtract_Click(object sender, EventArgs e)
		{
			//declared first and second operand
			float firstNum = float.Parse( textBox1.Text );
			float secondNum = float.Parse(textBox2.Text) ;
			//outputted subtraction calculation to textBox3
			textBox3.Text = (firstNum - secondNum) + "";

			
		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}

		private void label6_Click(object sender, EventArgs e)
		{

		}
		//Method to encrypt a string using ASU repo service
		private void button1_Click_1(object sender, EventArgs e)
		{
			//Declared cleint
			ServiceClient client = new ServiceClient();

			// Sets textBox4.Text to encrypted string of userTextEncrypt.Text
			//by making a Encrypt() ASU service call
			textBox4.Text = "" + client.Encrypt(userTextEncrypt.Text);
			//Displays encrypted messaged to label7
			label7.Text = "Encrypted Text:";


			// Always close the client.
			client.Close();
		}
        
    

	private void userTextEncrypt_TextChanged(object sender, EventArgs e)
		{

		}

		private void textBox4_TextChanged(object sender, EventArgs e)
		{

		}
		//Method that decrypts a string using ASU service
		private void button2_Click(object sender, EventArgs e)
		{
			// Declare sService client
			ServiceClient client = new ServiceClient();

			// Sets textBox4.Text to decrypted string of userTextEncrypt.Text
			//by using ASU Service Repository 
			textBox4.Text = "" + client.Decrypt(userTextEncrypt.Text);
			//Displays decrypted message to label7
			label7.Text = "Decrypted Text:";


			// close the client.
			client.Close();
		}
	}
}
