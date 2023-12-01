using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
	
	public partial class FormRegister : Form
	{
		private readonly SqlConnection con;
		public FormRegister()
		{
			InitializeComponent();
			con = new SqlConnection(connect.BookDb);
		}

		private void button1_Click(object sender, EventArgs e)
		{
			//authentication

			//add to database
			con.Open();
			SqlCommand cmd = new SqlCommand("insert into KhachHang values (@MaKH,@password,@TenKH,@DiaChi,@DienThoai)", con);
			cmd.Parameters.AddWithValue("@MaKH",userName.Text);
			cmd.Parameters.AddWithValue("@password", password.Text);
			cmd.Parameters.AddWithValue("@TenKH", fullName.Text);
			cmd.Parameters.AddWithValue("@DiaChi", Location.Text);
			cmd.Parameters.AddWithValue("@DienThoai", phone.Text);
			cmd.ExecuteNonQuery();
			con.Close();
			MessageBox.Show("You have successfully registered");
			this.Close();
			Form1.Instance.Show();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			Form1.Instance.Show();
			this.Close();
		}
	}
}
