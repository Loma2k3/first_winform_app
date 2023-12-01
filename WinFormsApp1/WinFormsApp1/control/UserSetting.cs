using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1.control
{
	public partial class UserSetting : UserControl
	{
		private SqlConnection _con = new SqlConnection(connect.BookDb);
		public UserSetting()
		{
			InitializeComponent();
			//load info
			SqlCommand cmd;

			cmd = new SqlCommand("select * from KhachHang where MaKH=@name", _con);
			cmd.Parameters.AddWithValue("@name", Form1.user);
			_con.Open();

			using (SqlDataReader reader = cmd.ExecuteReader())
			{
				if (reader.Read())
				{
					userName.Text = reader["TenKH"].ToString();
					phone.Text = reader["DienThoai"].ToString();
					address.Text = reader["DiaChi"].ToString();
				}
			}

			_con.Close();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Cart.Status = 0;
			Cart.Total = 0;
			Form1.Instance.Show();
			FormBookShop.instance.Close();
		}
	}
}
