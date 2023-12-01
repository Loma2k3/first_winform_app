namespace WinFormsApp1
{
	partial class FormBookShop
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBookShop));
			panel1 = new Panel();
			pictureBox3 = new PictureBox();
			button3 = new Button();
			pictureBox2 = new PictureBox();
			button2 = new Button();
			pictureBox1 = new PictureBox();
			button1 = new Button();
			panel2 = new Panel();
			panel3 = new Panel();
			label1 = new Label();
			productControl1 = new control.ProductControl();
			cartControl1 = new control.CartControl();
			userSetting1 = new control.UserSetting();
			panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			panel3.SuspendLayout();
			SuspendLayout();
			// 
			// panel1
			// 
			panel1.BackColor = Color.FromArgb(51, 51, 76);
			panel1.Controls.Add(pictureBox3);
			panel1.Controls.Add(button3);
			panel1.Controls.Add(pictureBox2);
			panel1.Controls.Add(button2);
			panel1.Controls.Add(pictureBox1);
			panel1.Controls.Add(button1);
			panel1.Controls.Add(panel2);
			panel1.Dock = DockStyle.Left;
			panel1.Location = new Point(0, 0);
			panel1.Name = "panel1";
			panel1.Size = new Size(171, 450);
			panel1.TabIndex = 0;
			// 
			// pictureBox3
			// 
			pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
			pictureBox3.Location = new Point(0, 397);
			pictureBox3.Name = "pictureBox3";
			pictureBox3.Size = new Size(40, 53);
			pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
			pictureBox3.TabIndex = 6;
			pictureBox3.TabStop = false;
			// 
			// button3
			// 
			button3.Dock = DockStyle.Bottom;
			button3.FlatAppearance.BorderSize = 0;
			button3.FlatStyle = FlatStyle.Flat;
			button3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
			button3.ForeColor = Color.Gainsboro;
			button3.Location = new Point(0, 397);
			button3.Name = "button3";
			button3.Size = new Size(171, 53);
			button3.TabIndex = 5;
			button3.Text = "User";
			button3.UseVisualStyleBackColor = true;
			button3.Click += button3_Click;
			// 
			// pictureBox2
			// 
			pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
			pictureBox2.Location = new Point(0, 128);
			pictureBox2.Name = "pictureBox2";
			pictureBox2.Size = new Size(40, 53);
			pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
			pictureBox2.TabIndex = 4;
			pictureBox2.TabStop = false;
			// 
			// button2
			// 
			button2.Dock = DockStyle.Top;
			button2.FlatAppearance.BorderSize = 0;
			button2.FlatStyle = FlatStyle.Flat;
			button2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
			button2.ForeColor = Color.Gainsboro;
			button2.Location = new Point(0, 128);
			button2.Name = "button2";
			button2.Size = new Size(171, 53);
			button2.TabIndex = 3;
			button2.Text = "Cart";
			button2.UseVisualStyleBackColor = true;
			button2.Click += button2_Click;
			// 
			// pictureBox1
			// 
			pictureBox1.BackColor = Color.Transparent;
			pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
			pictureBox1.Location = new Point(0, 75);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(40, 53);
			pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
			pictureBox1.TabIndex = 2;
			pictureBox1.TabStop = false;
			pictureBox1.Click += pictureBox1_Click;
			// 
			// button1
			// 
			button1.BackColor = Color.FromArgb(223, 78, 43);
			button1.Dock = DockStyle.Top;
			button1.FlatAppearance.BorderSize = 0;
			button1.FlatStyle = FlatStyle.Flat;
			button1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
			button1.ForeColor = Color.Gainsboro;
			button1.Location = new Point(0, 75);
			button1.Name = "button1";
			button1.Size = new Size(171, 53);
			button1.TabIndex = 1;
			button1.Text = "Product";
			button1.UseVisualStyleBackColor = false;
			button1.Click += button1_Click;
			// 
			// panel2
			// 
			panel2.BackColor = Color.FromArgb(165, 56, 31);
			panel2.BackgroundImage = (Image)resources.GetObject("panel2.BackgroundImage");
			panel2.BackgroundImageLayout = ImageLayout.Zoom;
			panel2.Dock = DockStyle.Top;
			panel2.Location = new Point(0, 0);
			panel2.Name = "panel2";
			panel2.Size = new Size(171, 75);
			panel2.TabIndex = 0;
			// 
			// panel3
			// 
			panel3.BackColor = Color.FromArgb(242, 82, 48);
			panel3.Controls.Add(label1);
			panel3.Dock = DockStyle.Top;
			panel3.Location = new Point(171, 0);
			panel3.Name = "panel3";
			panel3.Size = new Size(629, 75);
			panel3.TabIndex = 1;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
			label1.ForeColor = Color.FromArgb(248, 239, 239);
			label1.Location = new Point(272, 20);
			label1.Name = "label1";
			label1.Size = new Size(99, 31);
			label1.TabIndex = 0;
			label1.Text = "Product";
			// 
			// productControl1
			// 
			productControl1.Location = new Point(171, 75);
			productControl1.Name = "productControl1";
			productControl1.Size = new Size(629, 375);
			productControl1.TabIndex = 2;
			// 
			// cartControl1
			// 
			cartControl1.BackColor = Color.IndianRed;
			cartControl1.Dock = DockStyle.Fill;
			cartControl1.Location = new Point(171, 75);
			cartControl1.Name = "cartControl1";
			cartControl1.Size = new Size(629, 375);
			cartControl1.TabIndex = 3;
			// 
			// userSetting1
			// 
			userSetting1.BackColor = SystemColors.AppWorkspace;
			userSetting1.Dock = DockStyle.Fill;
			userSetting1.Location = new Point(171, 75);
			userSetting1.Name = "userSetting1";
			userSetting1.Size = new Size(629, 375);
			userSetting1.TabIndex = 4;
			// 
			// FormBookShop
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(userSetting1);
			Controls.Add(cartControl1);
			Controls.Add(productControl1);
			Controls.Add(panel3);
			Controls.Add(panel1);
			FormBorderStyle = FormBorderStyle.FixedDialog;
			Name = "FormBookShop";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Book Shop";
			panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			panel3.ResumeLayout(false);
			panel3.PerformLayout();
			ResumeLayout(false);
		}

		#endregion

		private Panel panel1;
		private Panel panel2;
		private PictureBox pictureBox1;
		private Button button1;
		private PictureBox pictureBox3;
		private Button button3;
		private PictureBox pictureBox2;
		private Button button2;
		private Panel panel3;
		private Label label1;
		private control.ProductControl productControl1;
		public control.CartControl cartControl1;
		private control.UserSetting userSetting1;
	}
}