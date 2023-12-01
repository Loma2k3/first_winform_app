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
using System.Xml.Linq;

namespace WinFormsApp1.control
{
	public partial class ProductControl : UserControl
	{
		private string bookID;
		private SqlConnection _con = new SqlConnection(connect.BookDb);
		public ProductControl()
		{
			InitializeComponent();

		}

		private void label2_Click(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			if(Cart.Status == 0)
			{
				Cart.Status = 1;
				Cart.Id = Guid.NewGuid();
				SqlCommand cmd = new SqlCommand("insert into HoaDon values (@Id,@user,@date,@total,@status)", _con);
				cmd.Parameters.AddWithValue("@Id", Cart.Id.ToString());
				cmd.Parameters.AddWithValue("@user", Form1.user);
				cmd.Parameters.AddWithValue("@date", "2022-11-24");
				cmd.Parameters.AddWithValue("@total", 0);
				cmd.Parameters.AddWithValue("@status", "cart");
				_con.Open();
				cmd.ExecuteNonQuery();
				_con.Close();
			}

			Cart.Total += Cart.Cost * Int32.Parse(Quantity.Text);

			SqlCommand update = new SqlCommand("update HoaDon set TongTien=@total where MaHoaDon = @id", _con);
			update.Parameters.AddWithValue("@total", Cart.Total );
			update.Parameters.AddWithValue("@id", Cart.Id.ToString());

			SqlCommand cart = new SqlCommand("insert into ChiTietHoaDon Values (@MaHoaDon,@MaSach,@soLuong)",_con);
			cart.Parameters.AddWithValue("@MaHoaDon", Cart.Id);
			cart.Parameters.AddWithValue("@MaSach", bookID);
			cart.Parameters.AddWithValue("@soLuong", Int32.Parse(Quantity.Text));

			_con.Open();
			update.ExecuteNonQuery();
			cart.ExecuteNonQuery();
			_con.Close();
			MessageBox.Show("successfully add to cart");
		}

		private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
		{
			SqlCommand cmd;
			if (comboBox2.SelectedIndex == 0)
			{
				cmd = new SqlCommand("select TenSach as [Name] from Sach", _con);
			}
			else
			{
				cmd = new SqlCommand("select TenSach as [Name] from Sach where MaTheLoai= @type", _con);
				cmd.Parameters.AddWithValue("@type", comboBox2.SelectedItem.ToString());
			}

			_con.Open();
			SqlDataAdapter adapter = new SqlDataAdapter(cmd);
			DataTable dt = new DataTable();
			adapter.Fill(dt);
			_con.Close();

			dataGridView1.DataSource = dt;
		}

		private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex >= 0)
			{
				DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];

		
				string? value = selectedRow.Cells["Name"].Value.ToString();

				SqlCommand cmd;

				cmd = new SqlCommand("select * from Sach where TenSach=@name", _con);
				cmd.Parameters.AddWithValue("@name", value);
				_con.Open();

				using (SqlDataReader reader = cmd.ExecuteReader())
				{
					if (reader.Read())
					{
						bookID = reader["MaSach"].ToString();
						NameBook.Text = reader["TenSach"].ToString();
						Author.Text = "Author : " + reader["TacGia"].ToString();
						Price.Text = "Price : " + reader["DonGiaBan"].ToString()+"$";
						Cart.Cost = reader.GetInt32(reader.GetOrdinal("DonGiaBan"));
						DateTime ngayXuatBan = reader.GetDateTime(reader.GetOrdinal("NgayXuatBan"));
						PubDate.Text = "Publication date : " + ngayXuatBan.ToString("dd/MM/yyyy");
						Stock.Text = reader["Stock"].ToString() + " products available";
						Description.Text = reader["Description"].ToString();
						string img = reader["Image"].ToString();
						BookImage.Image = Image.FromFile(Path.Combine(Application.StartupPath, "Resources", img));
					}
				}

				_con.Close();
			}
		}
	}
}
