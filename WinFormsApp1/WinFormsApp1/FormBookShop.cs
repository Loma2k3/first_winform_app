using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
	public partial class FormBookShop : Form
	{
		public static FormBookShop instance;
		public FormBookShop()
		{
			InitializeComponent();
			instance = this;
			productControl1.BringToFront();		
		}

		private void setDefaultColor()
		{
			button1.BackColor = System.Drawing.ColorTranslator.FromHtml("#32344d");
			button2.BackColor = System.Drawing.ColorTranslator.FromHtml("#32344d");
			button3.BackColor = System.Drawing.ColorTranslator.FromHtml("#32344d");
		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{

		}

		private void button2_Click(object sender, EventArgs e)
		{
			label1.Text = "Cart";
			setDefaultColor();
			cartControl1.BringToFront();
			button2.BackColor = System.Drawing.ColorTranslator.FromHtml("#df4e2b");
			cartControl1.StartUp();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			label1.Text = "User Profile";
			setDefaultColor();
			userSetting1.BringToFront();
			button3.BackColor = System.Drawing.ColorTranslator.FromHtml("#df4e2b");
		}

		private void button1_Click(object sender, EventArgs e)
		{
			label1.Text = "Product";
			setDefaultColor();
			productControl1.BringToFront();
			button1.BackColor = System.Drawing.ColorTranslator.FromHtml("#df4e2b");
		}
	}
}
