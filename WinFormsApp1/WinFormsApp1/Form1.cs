using System.Data.SqlClient;

namespace WinFormsApp1
{
	public partial class Form1 : Form
	{
		public static Form1 Instance;
		private SqlConnection _con= new SqlConnection(connect.BookDb);
		public static string user;
		public Form1()
		{
			InitializeComponent();
			Instance = this;
			
		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}

		private void pictureBox2_Click(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			SqlCommand cmd = new SqlCommand("select * from KhachHang where MaKH=@userName and password=@password",_con);
			cmd.Parameters.AddWithValue("@userName", userName.Text);
			cmd.Parameters.AddWithValue("@password", password.Text);

			_con.Open();

			object result = cmd.ExecuteScalar();

			_con.Close();

			if (result != null)
			{
				user = userName.Text;
				FormBookShop bookShop = new FormBookShop();
				bookShop.Show();
				this.Hide();
			}
			else
			{
				MessageBox.Show("Wrong password or username");
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			this.Hide();
			FormRegister register = new FormRegister();
			register.Show();
		}
	}
}
