namespace WinFormsApp1.control
{
	partial class ProductControl
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductControl));
			panel4 = new Panel();
			label1 = new Label();
			dataGridView1 = new DataGridView();
			comboBox2 = new ComboBox();
			BookImage = new PictureBox();
			NameBook = new Label();
			Author = new Label();
			Price = new Label();
			PubDate = new Label();
			button1 = new Button();
			label6 = new Label();
			panel1 = new Panel();
			Description = new RichTextBox();
			Quantity = new TextBox();
			label7 = new Label();
			Stock = new Label();
			panel4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
			((System.ComponentModel.ISupportInitialize)BookImage).BeginInit();
			SuspendLayout();
			// 
			// panel4
			// 
			panel4.Controls.Add(label1);
			panel4.Controls.Add(dataGridView1);
			panel4.Controls.Add(comboBox2);
			panel4.Dock = DockStyle.Left;
			panel4.Location = new Point(0, 0);
			panel4.Name = "panel4";
			panel4.Size = new Size(208, 375);
			panel4.TabIndex = 8;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
			label1.Location = new Point(15, 15);
			label1.Name = "label1";
			label1.Size = new Size(72, 20);
			label1.TabIndex = 5;
			label1.Text = "Category";
			// 
			// dataGridView1
			// 
			dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridView1.Dock = DockStyle.Bottom;
			dataGridView1.Location = new Point(0, 53);
			dataGridView1.Name = "dataGridView1";
			dataGridView1.RowHeadersWidth = 51;
			dataGridView1.RowTemplate.Height = 29;
			dataGridView1.Size = new Size(208, 322);
			dataGridView1.TabIndex = 3;
			dataGridView1.CellClick += dataGridView1_CellClick;
			// 
			// comboBox2
			// 
			comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
			comboBox2.FormattingEnabled = true;
			comboBox2.Items.AddRange(new object[] { "all", "horror", "manga", "romantic", "detective" });
			comboBox2.Location = new Point(93, 12);
			comboBox2.Name = "comboBox2";
			comboBox2.Size = new Size(106, 28);
			comboBox2.TabIndex = 4;
			comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
			// 
			// BookImage
			// 
			BookImage.BackColor = SystemColors.ActiveBorder;
			BookImage.Image = (Image)resources.GetObject("BookImage.Image");
			BookImage.Location = new Point(231, 15);
			BookImage.Name = "BookImage";
			BookImage.Size = new Size(138, 168);
			BookImage.SizeMode = PictureBoxSizeMode.Zoom;
			BookImage.TabIndex = 9;
			BookImage.TabStop = false;
			// 
			// NameBook
			// 
			NameBook.AutoSize = true;
			NameBook.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
			NameBook.Location = new Point(397, 12);
			NameBook.Name = "NameBook";
			NameBook.Size = new Size(97, 38);
			NameBook.TabIndex = 10;
			NameBook.Text = "Name";
			NameBook.Click += label2_Click;
			// 
			// Author
			// 
			Author.AutoSize = true;
			Author.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
			Author.Location = new Point(397, 59);
			Author.Name = "Author";
			Author.Size = new Size(65, 20);
			Author.TabIndex = 11;
			Author.Text = "Author :";
			// 
			// Price
			// 
			Price.AutoSize = true;
			Price.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
			Price.Location = new Point(397, 89);
			Price.Name = "Price";
			Price.Size = new Size(51, 20);
			Price.TabIndex = 12;
			Price.Text = "Price :";
			// 
			// PubDate
			// 
			PubDate.AutoSize = true;
			PubDate.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
			PubDate.Location = new Point(397, 119);
			PubDate.Name = "PubDate";
			PubDate.Size = new Size(128, 20);
			PubDate.TabIndex = 13;
			PubDate.Text = "Publication date :";
			// 
			// button1
			// 
			button1.BackColor = Color.FromArgb(232, 79, 46);
			button1.FlatStyle = FlatStyle.Flat;
			button1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
			button1.ForeColor = Color.FromArgb(241, 222, 193);
			button1.Location = new Point(231, 189);
			button1.Name = "button1";
			button1.Size = new Size(138, 39);
			button1.TabIndex = 14;
			button1.Text = "Add to cart";
			button1.UseVisualStyleBackColor = false;
			button1.Click += button1_Click;
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
			label6.Location = new Point(231, 244);
			label6.Name = "label6";
			label6.Size = new Size(87, 20);
			label6.TabIndex = 15;
			label6.Text = "Description";
			// 
			// panel1
			// 
			panel1.BackColor = Color.FromArgb(236, 80, 49);
			panel1.Location = new Point(231, 267);
			panel1.Name = "panel1";
			panel1.Size = new Size(378, 2);
			panel1.TabIndex = 16;
			// 
			// Description
			// 
			Description.BackColor = SystemColors.Control;
			Description.BorderStyle = BorderStyle.None;
			Description.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
			Description.Location = new Point(231, 275);
			Description.Name = "Description";
			Description.ReadOnly = true;
			Description.Size = new Size(378, 82);
			Description.TabIndex = 17;
			Description.Text = "";
			// 
			// Quantity
			// 
			Quantity.Location = new Point(479, 195);
			Quantity.Name = "Quantity";
			Quantity.Size = new Size(36, 27);
			Quantity.TabIndex = 18;
			// 
			// label7
			// 
			label7.AutoSize = true;
			label7.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
			label7.Location = new Point(397, 198);
			label7.Name = "label7";
			label7.Size = new Size(76, 20);
			label7.TabIndex = 19;
			label7.Text = "Quantity :";
			// 
			// Stock
			// 
			Stock.AutoSize = true;
			Stock.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
			Stock.Location = new Point(397, 152);
			Stock.Name = "Stock";
			Stock.Size = new Size(146, 20);
			Stock.TabIndex = 20;
			Stock.Text = "0 products available";
			// 
			// ProductControl
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			Controls.Add(Stock);
			Controls.Add(label7);
			Controls.Add(Quantity);
			Controls.Add(Description);
			Controls.Add(panel1);
			Controls.Add(label6);
			Controls.Add(button1);
			Controls.Add(PubDate);
			Controls.Add(Price);
			Controls.Add(Author);
			Controls.Add(NameBook);
			Controls.Add(BookImage);
			Controls.Add(panel4);
			Name = "ProductControl";
			Size = new Size(629, 375);
			panel4.ResumeLayout(false);
			panel4.PerformLayout();
			((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
			((System.ComponentModel.ISupportInitialize)BookImage).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Panel panel4;
		private Label label1;
		private DataGridView dataGridView1;
		private ComboBox comboBox2;
		private PictureBox BookImage;
		private Label NameBook;
		private Label Author;
		private Label Price;
		private Label PubDate;
		private Button button1;
		private Label label6;
		private Panel panel1;
		private RichTextBox Description;
		private TextBox Quantity;
		private Label label7;
		private Label Stock;
	}
}
