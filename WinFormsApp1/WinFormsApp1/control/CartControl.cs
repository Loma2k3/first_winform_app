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

namespace WinFormsApp1.control
{
	public partial class CartControl : UserControl
	{
		private SqlConnection _con = new SqlConnection(connect.BookDb);
		public CartControl()
		{
			InitializeComponent();


		}

		public void StartUp()
		{
			label3.Text = Cart.Total + "$";

			_con.Open();
			//cart view
			if (Cart.Status == 1)
			{
				SqlCommand cmdCart = new SqlCommand("select s.TenSach as [name], ct_hd.SLBan as [quantity] from ChiTietHoaDon ct_hd join Sach s on ct_hd.MaSach = s.MaSach where ct_hd.MaHoaDon = @MaHoaDon", _con);
				cmdCart.Parameters.AddWithValue("@MaHoaDon", Cart.Id);

				using (SqlDataAdapter adapter = new SqlDataAdapter(cmdCart))
				{
					DataTable dt = new DataTable();
					adapter.Fill(dt);
					CartView.DataSource = dt;
				}
			}
			else
			{
				CartView.DataSource= null;
			}


			//order view
			SqlCommand cmdOrder = new SqlCommand("select hd.MaHoaDon as [order code], hd.NgayBan as [date], hd.TongTien as [total] from HoaDon hd where hd.MaKH = @userName and hd.TinhTrang = 'order'", _con);
			cmdOrder.Parameters.AddWithValue("@userName", Form1.user);

			using (SqlDataAdapter adapter = new SqlDataAdapter(cmdOrder))
			{
				DataTable dt = new DataTable();
				adapter.Fill(dt);
				OrderView.DataSource = dt;
			}

			_con.Close();
		}
		private void label2_Click(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			Cart.Status = 0;
			Cart.Total = 0;
			_con.Open();
			SqlCommand cmd = new SqlCommand("UPDATE HoaDon SET TinhTrang = N'order' where MaHoaDon = @MaHoaDon",_con);
			cmd.Parameters.AddWithValue("@MaHoaDon", Cart.Id.ToString());
			cmd.ExecuteNonQuery();
			_con.Close();
			
			this.StartUp();
		}
	}
}
