
namespace webBrowser1
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.webBrowser1 = new System.Windows.Forms.WebBrowser();
			this.webBrowser2 = new System.Windows.Forms.WebBrowser();
			this.webBrowser3 = new System.Windows.Forms.WebBrowser();
			this.txtUrl = new System.Windows.Forms.TextBox();
			this.btnGo = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.btnMultiply = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.btnDivide = new System.Windows.Forms.Button();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.btnSubtract = new System.Windows.Forms.Button();
			this.btnAdd = new System.Windows.Forms.Button();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.label6 = new System.Windows.Forms.Label();
			this.userTextEncrypt = new System.Windows.Forms.TextBox();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// webBrowser1
			// 
			this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.webBrowser1.Location = new System.Drawing.Point(0, 0);
			this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
			this.webBrowser1.Name = "webBrowser1";
			this.webBrowser1.Size = new System.Drawing.Size(800, 450);
			this.webBrowser1.TabIndex = 0;
			// 
			// webBrowser2
			// 
			this.webBrowser2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.webBrowser2.Location = new System.Drawing.Point(0, 0);
			this.webBrowser2.MinimumSize = new System.Drawing.Size(20, 20);
			this.webBrowser2.Name = "webBrowser2";
			this.webBrowser2.Size = new System.Drawing.Size(800, 450);
			this.webBrowser2.TabIndex = 1;
			// 
			// webBrowser3
			// 
			this.webBrowser3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.webBrowser3.Location = new System.Drawing.Point(0, 0);
			this.webBrowser3.MinimumSize = new System.Drawing.Size(20, 20);
			this.webBrowser3.Name = "webBrowser3";
			this.webBrowser3.Size = new System.Drawing.Size(800, 450);
			this.webBrowser3.TabIndex = 2;
			// 
			// txtUrl
			// 
			this.txtUrl.Location = new System.Drawing.Point(15, 43);
			this.txtUrl.Name = "txtUrl";
			this.txtUrl.Size = new System.Drawing.Size(608, 20);
			this.txtUrl.TabIndex = 3;
			this.txtUrl.Text = "http://";
			// 
			// btnGo
			// 
			this.btnGo.Location = new System.Drawing.Point(649, 43);
			this.btnGo.Name = "btnGo";
			this.btnGo.Size = new System.Drawing.Size(75, 23);
			this.btnGo.TabIndex = 4;
			this.btnGo.Text = "Go";
			this.btnGo.UseVisualStyleBackColor = true;
			this.btnGo.Click += new System.EventHandler(this.btnGo_Click_1);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(6, 22);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(65, 13);
			this.label1.TabIndex = 5;
			this.label1.Text = "1st Operand";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.textBox3);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.btnMultiply);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.btnDivide);
			this.groupBox1.Controls.Add(this.textBox1);
			this.groupBox1.Controls.Add(this.btnSubtract);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.btnAdd);
			this.groupBox1.Controls.Add(this.textBox2);
			this.groupBox1.Location = new System.Drawing.Point(577, 194);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(201, 164);
			this.groupBox1.TabIndex = 6;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Simple Calculator";
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(72, 140);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(100, 20);
			this.textBox3.TabIndex = 13;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(69, 143);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(0, 13);
			this.label5.TabIndex = 12;
			this.label5.Click += new System.EventHandler(this.label5_Click);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(6, 143);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(45, 13);
			this.label4.TabIndex = 7;
			this.label4.Text = "Answer:";
			this.label4.Click += new System.EventHandler(this.label4_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(43, 87);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(116, 13);
			this.label3.TabIndex = 11;
			this.label3.Text = "Click Button Operation ";
			this.label3.Click += new System.EventHandler(this.label3_Click);
			// 
			// btnMultiply
			// 
			this.btnMultiply.Location = new System.Drawing.Point(164, 103);
			this.btnMultiply.Name = "btnMultiply";
			this.btnMultiply.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.btnMultiply.Size = new System.Drawing.Size(26, 23);
			this.btnMultiply.TabIndex = 10;
			this.btnMultiply.Text = "*";
			this.btnMultiply.UseVisualStyleBackColor = true;
			this.btnMultiply.Click += new System.EventHandler(this.btnMultiply_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(2, 54);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(69, 13);
			this.label2.TabIndex = 9;
			this.label2.Text = "2nd Operand";
			// 
			// btnDivide
			// 
			this.btnDivide.Location = new System.Drawing.Point(113, 103);
			this.btnDivide.Name = "btnDivide";
			this.btnDivide.Size = new System.Drawing.Size(26, 23);
			this.btnDivide.TabIndex = 9;
			this.btnDivide.Text = "/";
			this.btnDivide.UseVisualStyleBackColor = true;
			this.btnDivide.Click += new System.EventHandler(this.btnDivide_Click);
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(72, 19);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(100, 20);
			this.textBox1.TabIndex = 7;
			this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			// 
			// btnSubtract
			// 
			this.btnSubtract.Location = new System.Drawing.Point(60, 103);
			this.btnSubtract.Name = "btnSubtract";
			this.btnSubtract.Size = new System.Drawing.Size(26, 23);
			this.btnSubtract.TabIndex = 8;
			this.btnSubtract.Text = "-";
			this.btnSubtract.UseVisualStyleBackColor = true;
			this.btnSubtract.Click += new System.EventHandler(this.btnSubtract_Click);
			// 
			// btnAdd
			// 
			this.btnAdd.Location = new System.Drawing.Point(9, 103);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(26, 23);
			this.btnAdd.TabIndex = 7;
			this.btnAdd.Text = "+";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.button1_Click);
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(72, 51);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(100, 20);
			this.textBox2.TabIndex = 8;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.button2);
			this.groupBox2.Controls.Add(this.button1);
			this.groupBox2.Controls.Add(this.textBox4);
			this.groupBox2.Controls.Add(this.label7);
			this.groupBox2.Controls.Add(this.userTextEncrypt);
			this.groupBox2.Controls.Add(this.label6);
			this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.groupBox2.Location = new System.Drawing.Point(0, 364);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(800, 86);
			this.groupBox2.TabIndex = 7;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Text Encryption Decryption";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(12, 16);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(58, 13);
			this.label6.TabIndex = 8;
			this.label6.Text = "Enter text :";
			this.label6.Click += new System.EventHandler(this.label6_Click);
			// 
			// userTextEncrypt
			// 
			this.userTextEncrypt.Location = new System.Drawing.Point(84, 16);
			this.userTextEncrypt.Name = "userTextEncrypt";
			this.userTextEncrypt.Size = new System.Drawing.Size(673, 20);
			this.userTextEncrypt.TabIndex = 9;
			this.userTextEncrypt.TextChanged += new System.EventHandler(this.userTextEncrypt_TextChanged);
			// 
			// textBox4
			// 
			this.textBox4.Location = new System.Drawing.Point(84, 58);
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size(673, 20);
			this.textBox4.TabIndex = 11;
			this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(1, 61);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(69, 13);
			this.label7.TabIndex = 10;
			this.label7.Text = "Output Text :";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(84, 35);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(347, 23);
			this.button1.TabIndex = 12;
			this.button1.Text = "ENCRYPT TEXT";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click_1);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(437, 35);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(320, 23);
			this.button2.TabIndex = 13;
			this.button2.Text = "DECRYPT TEXT";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("OCR A Extended", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(12, 9);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(621, 30);
			this.label8.TabIndex = 8;
			this.label8.Text = "Gabriel Valenzuela\'s Web Browser";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(640, 27);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(96, 13);
			this.label9.TabIndex = 9;
			this.label9.Text = "Click Go to Search";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.btnGo);
			this.Controls.Add(this.txtUrl);
			this.Controls.Add(this.webBrowser3);
			this.Controls.Add(this.webBrowser2);
			this.Controls.Add(this.webBrowser1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.WebBrowser webBrowser1;
		private System.Windows.Forms.WebBrowser webBrowser2;
		private System.Windows.Forms.WebBrowser webBrowser3;
		private System.Windows.Forms.TextBox txtUrl;
		private System.Windows.Forms.Button btnGo;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button btnMultiply;
		private System.Windows.Forms.Button btnDivide;
		private System.Windows.Forms.Button btnSubtract;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox userTextEncrypt;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
	}
}

